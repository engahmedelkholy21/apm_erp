using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharma_manage
{
    public partial class SubstringAutoCompleteTextBox : UserControl
    {
        private TextBox textBox;
        private ListBox listBox;
        private List<SuggestionItem> suggestions;
        private Form parentForm;
        private Timer debounceTimer;
        // Holds the text as last typed by the user (used for filtering and as the "user portion").
        private string lastFilterText = string.Empty;
        // Flag to suppress filtering when updating text programmatically.
        private bool _suppressTextChanged = false;

        // New flag: indicates that focus was shifted via the Down arrow.
        private bool arrowDownInitiatedFocus = false;

        public SubstringAutoCompleteTextBox()
        {
            InitializeComponent();

            // Set up the control appearance.
            this.BackColor = Color.Transparent;
            this.BorderStyle = BorderStyle.None;

            // Initialize the TextBox.
            textBox = new TextBox
            {
                RightToLeft = RightToLeft.Yes,
                Font = new Font("Tahoma", 9F, FontStyle.Bold),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Width = this.Width,
                Location = new Point(0, 0)
            };

            // Initialize the ListBox for suggestions.
            listBox = new ListBox
            {
                RightToLeft = RightToLeft.Yes,
                Font = new Font("Tahoma", 9F, FontStyle.Bold),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Height = 350,
                Width = textBox.Width,
                Visible = false
            };

            // Add the TextBox to the control (the ListBox is attached to the parent form later).
            this.Controls.Add(textBox);

            // Initialize the suggestion collection.
            suggestions = new List<SuggestionItem>();

            // Set up a debouncing timer (150ms delay).
            debounceTimer = new Timer { Interval =350 };
            debounceTimer.Tick += new EventHandler(debounceTimer_Tick);

            // Hook up event handlers.
            textBox.TextChanged += new EventHandler(textBox_TextChanged);
            textBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            listBox.KeyDown += new KeyEventHandler(listBox_KeyDown);
            listBox.Click += new EventHandler(listBox_Click);
            listBox.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
            // When ListBox receives focus, ensure an item is selected.
            listBox.Enter += new EventHandler(listBox_Enter);
        }

        /// <summary>
        /// Exposes the internal TextBox for additional event handlers.
        /// </summary>
        public TextBox TextBox_
        {
            get { return textBox; }
        }

        /// <summary>
        /// Exposes the internal ListBox for additional event handlers.
        /// </summary>
        public ListBox Listbox_
        {
            get { return listBox; }
        }

        /// <summary>
        /// Attaches the ListBox to the provided parent form and subscribes to its Resize event
        /// to keep the suggestion list positioned correctly.
        /// </summary>
        public void AttachListBoxToParent(Form parentForm)
        {
            if (parentForm == null)
                throw new ArgumentNullException("parentForm");

            this.parentForm = parentForm;
            parentForm.Controls.Add(listBox);
            parentForm.Resize += new EventHandler(parentForm_Resize);
        }

        private void parentForm_Resize(object sender, EventArgs e)
        {
            // Reposition the listbox if it is visible.
            if (listBox.Visible)
            {
                PositionListBox();
            }
        }

        /// <summary>
        /// Populates the suggestions list from a DataTable using the specified column.
        /// Duplicate and empty suggestions are filtered out.
        /// </summary>
        public void SetSuggestions(DataTable dataTable, string columnName)
        {
            SetSuggestions(dataTable, columnName, null);
        }

        /// <summary>
        /// Populates the suggestions list from a DataTable using the specified columns.
        /// </summary>
        public void SetSuggestions(DataTable dataTable, string columnName, string countColumnName)
        {
            if (dataTable == null)
                throw new ArgumentNullException("dataTable");
            if (string.IsNullOrEmpty(columnName))
                throw new ArgumentException("Column name must be provided.", "columnName");

            // Build suggestion items and cache the lower-case string.
            suggestions = (from DataRow row in dataTable.Rows
                           let valObj = row[columnName]
                           where valObj != null
                           let s = valObj.ToString().Trim()
                           where !string.IsNullOrEmpty(s)
                           select new SuggestionItem
                           {
                               Value = s,
                               LowerValue = s.ToLowerInvariant(),
                               Count = GetDecimalValue(row, countColumnName),
                               HasCount = !string.IsNullOrEmpty(countColumnName) &&
                                          dataTable.Columns.Contains(countColumnName)
                           })
                // Remove duplicates based on the lower-case value.
                           .GroupBy(si => si.LowerValue)
                           .Select(g => g.First())
                           .ToList();
        }

        /// <summary>
        /// Safely retrieves a decimal value from the DataRow for the given column.
        /// Returns 0 if the column doesn't exist, is null, empty, or cannot be parsed.
        /// </summary>
        private decimal GetDecimalValue(DataRow row, string colName)
        {
            if (!string.IsNullOrEmpty(colName) &&
                row.Table.Columns.Contains(colName) &&
                row[colName] != DBNull.Value)
            {
                string strVal = row[colName].ToString().Trim();
                decimal result;
                if (decimal.TryParse(strVal, out result))
                {
                    return result;
                }
            }
            return 0m;
        }

        #region Debounce and Asynchronous Suggestion Updating

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // If the change is due to a programmatic update (via arrow navigation), do not re-trigger filtering.
            if (_suppressTextChanged)
                return;

            // Capture what the user typed.
            lastFilterText = textBox.Text;
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void debounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            UpdateSuggestionsAsync();
        }

        /// <summary>
        /// Asynchronously updates the suggestion list based on the current text.
        /// Filtering is offloaded to a background thread to keep the UI responsive.
        /// </summary>
        private void UpdateSuggestionsAsync()
        {
            string searchText = textBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                if (listBox.InvokeRequired)
                {
                    listBox.BeginInvoke(new Action(() => listBox.Visible = false));
                }
                else
                {
                    listBox.Visible = false;
                }
                return;
            }

            string searchTextLower = searchText.ToLowerInvariant();
            string[] searchWords = searchTextLower.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Task.Factory.StartNew(() =>
            {
                // Filter suggestions (local database)
                var filteredSuggestions = suggestions
                    .Where(si => searchWords.All(word => si.LowerValue.Contains(word)))
                    .OrderBy(si => si.LowerValue.StartsWith(searchTextLower) ? 0 : 1)
                    .Take(40)
                    .ToList();

                return filteredSuggestions;
            }).ContinueWith(t =>
            {
                if (t.Status == TaskStatus.RanToCompletion)
                {
                    List<SuggestionItem> filtered = t.Result;

                    if (listBox.InvokeRequired)
                    {
                        listBox.BeginInvoke(new Action(() =>
                        {
                            listBox.BeginUpdate();
                            listBox.DataSource = filtered.Count > 0 ? filtered : null;
                            listBox.SelectedIndex = filtered.Count > 0 ? 0 : -1;
                            listBox.EndUpdate();
                            listBox.Visible = filtered.Count > 0;
                            PositionListBox();
                        }));
                    }
                    else
                    {
                        listBox.BeginUpdate();
                        listBox.DataSource = filtered.Count > 0 ? filtered : null;
                        listBox.SelectedIndex = filtered.Count > 0 ? 0 : -1;
                        listBox.EndUpdate();
                        listBox.Visible = filtered.Count > 0;
                        PositionListBox();
                    }
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }


        /// <summary>
        /// Positions the ListBox just below the TextBox on the parent form.
        /// </summary>
        private void PositionListBox()
        {
            if (parentForm == null)
                return;

            Point textBoxScreenLocation = textBox.PointToScreen(Point.Empty);
            Point listBoxLocation = parentForm.PointToClient(new Point(textBoxScreenLocation.X, textBoxScreenLocation.Y + textBox.Height));

            listBox.Location = listBoxLocation;
            listBox.Width = textBox.Width;
            listBox.BringToFront();
        }

        #endregion

        #region Key and Click Handlers

        /// <summary>
        /// Handles key events for the TextBox.
        /// When the user is typing, focus remains in the TextBox.
        /// If the Down arrow is pressed and the suggestion list is visible,
        /// we set a flag and shift focus to the ListBox.
        /// </summary>
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox.Visible)
            {
                if (e.KeyCode == Keys.Down)
                {
                    // Set the flag to indicate arrow key navigation from the TextBox.
                    arrowDownInitiatedFocus = true;
                    listBox.Focus(); // move focus so that ListBox_KeyDown / Enter event can work
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    listBox.Visible = false;
                }
            }
        }

        /// <summary>
        /// Handles key events for the ListBox.
        /// Normal navigation is allowed, and Enter commits the suggestion.
        /// </summary>
        private void listBox_KeyDown(object sender, KeyEventArgs e)
        {
            // If the focus came here via the Down arrow, clear the flag.
            if (arrowDownInitiatedFocus)
            {
                arrowDownInitiatedFocus = false;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                // Allow normal navigation if there is more than one item.
                e.Handled = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.BeginInvoke(new Action(SelectItem));
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                listBox.Visible = false;
                textBox.Focus();
            }
        }

        /// <summary>
        /// Handles a click event on the ListBox to select the item.
        /// </summary>
        private void listBox_Click(object sender, EventArgs e)
        {
            SelectItem();
            // Optionally, move focus to the next control if needed:
            // next_textbox?.Focus();
        }

        /// <summary>
        /// As the selection in the ListBox changes (via arrow keys),
        /// update the TextBox—but only if the ListBox has focus.
        /// This mimics the built-in AutoComplete behavior.
        /// </summary>
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Only update if the ListBox has focus.
            if (!listBox.Focused)
                return;

            if (listBox.SelectedItem != null)
            {
                SuggestionItem selectedItem = listBox.SelectedItem as SuggestionItem;
                if (selectedItem != null)
                {
                    // Use the user-typed portion (lastFilterText) and the full suggestion.
                    string userText = lastFilterText;
                    string suggestion = selectedItem.Value;

                    // Temporarily suppress TextChanged processing.
                    _suppressTextChanged = true;
                    if (suggestion.ToLowerInvariant().StartsWith(userText.ToLowerInvariant()))
                    {
                        textBox.Text = suggestion;
                        textBox.SelectionStart = userText.Length;
                        textBox.SelectionLength = suggestion.Length - userText.Length;
                    }
                    else
                    {
                        textBox.Text = suggestion;
                        textBox.SelectionStart = suggestion.Length;
                        textBox.SelectionLength = 0;
                    }
                    _suppressTextChanged = false;
                }
            }
        }

        /// <summary>
        /// Selects the currently highlighted item in the ListBox.
        /// This commits the suggestion to the TextBox.
        /// </summary>
        private void SelectItem()
        {
            if (listBox.Items.Count > 0)
            {
                if (listBox.SelectedItem == null)
                    listBox.SelectedIndex = 0;

                SuggestionItem selectedItem = listBox.SelectedItem as SuggestionItem;
                if (selectedItem != null)
                {
                    debounceTimer.Stop();
                    textBox.Text = selectedItem.Value;
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                }

                // Ensure hiding the ListBox on the UI thread
                this.BeginInvoke(new Action(() =>
                {
                    listBox.Visible = false;
                    textBox.Focus(); // Return focus to TextBox
                }));


                listBox.Visible = false;
                textBox.Focus(); // Return focus to TextBox
                // Perform AcceptButton click if assigned
                //if (AcceptButton != null)
                //{
                //    this.BeginInvoke(new Action(() =>
                //    {
                //        AcceptButton.PerformClick();
                //    }));
                //}
            }
        }


        /// <summary>
        /// When the ListBox receives focus, ensure that an item is selected.
        /// If the focus was transferred via the Down arrow from the TextBox and there's only one item,
        /// immediately commit the suggestion.
        /// </summary>
        private void listBox_Enter(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0 && listBox.SelectedIndex < 0)
                listBox.SelectedIndex = 0;

            // If focus came here because of an arrow key from the TextBox and there is only one suggestion,
            // commit it immediately.
            if (arrowDownInitiatedFocus && listBox.Items.Count == 1)
            {
                arrowDownInitiatedFocus = false;
                SelectItem();
            }
        }

        #endregion

        /// <summary>
        /// Gets or sets a button that will be "clicked" automatically when an item is selected.
        /// </summary>
        public Button AcceptButton { get; set; }
        public TextBox next_textbox { get; set; }

        /// <summary>
        /// Unsubscribe from events and dispose managed resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (debounceTimer != null)
                {
                    debounceTimer.Tick -= new EventHandler(debounceTimer_Tick);
                    debounceTimer.Dispose();
                    debounceTimer = null;
                }
                if (parentForm != null)
                {
                    parentForm.Resize -= new EventHandler(parentForm_Resize);
                }
                if (textBox != null)
                {
                    textBox.TextChanged -= new EventHandler(textBox_TextChanged);
                    textBox.KeyDown -= new KeyEventHandler(textBox_KeyDown);
                    textBox.Dispose();
                    textBox = null;
                }
                if (listBox != null)
                {
                    listBox.KeyDown -= new KeyEventHandler(listBox_KeyDown);
                    listBox.Click -= new EventHandler(listBox_Click);
                    listBox.SelectedIndexChanged -= new EventHandler(listBox_SelectedIndexChanged);
                    listBox.Enter -= new EventHandler(listBox_Enter);
                    listBox.Dispose();
                    listBox = null;
                }
            }
            base.Dispose(disposing);
        }

        #region Nested SuggestionItem Class

        /// <summary>
        /// Represents an autocomplete suggestion item with additional display data.
        /// </summary>
        private class SuggestionItem
        {
            /// <summary>
            /// The actual text value.
            /// </summary>
            public string Value { get; set; }

            /// <summary>
            /// Cached lower-case version for fast filtering.
            /// </summary>
            public string LowerValue { get; set; }

            /// <summary>
            /// An additional count or other data to display.
            /// </summary>
            public decimal Count { get; set; }

            /// <summary>
            /// Indicates whether a count value was provided.
            /// </summary>
            public bool HasCount { get; set; }

            /// <summary>
            /// Overrides ToString to display both the value and the count if applicable.
            /// </summary>
            public override string ToString()
            {
                return HasCount ? string.Format("{0} ({1})", Value, Count) : Value;
            }
        }

        #endregion
    }
}
