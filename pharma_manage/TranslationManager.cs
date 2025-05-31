using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Drawing;

public class Translator
{
    private static readonly ResourceManager _resourceManager;

    static Translator()
    {
        // Replace "YourNamespace.Resources" with the actual namespace and class name of your resource file.
        _resourceManager = new ResourceManager("pharma_manage.Resources", typeof(Translator).Assembly);
    }

    public static string Translate(string original)
    {
        CultureInfo culture = new CultureInfo("en-US");

        try
        {
            string translatedText = _resourceManager.GetString(original, culture);
            return translatedText ?? original;
        }
        catch (Exception ex)
        {
            // Console.WriteLine($"Error loading resource for key '{original}': {ex.Message}");
            return original;
        }
    }
}

public static class FormTranslator
{
    public static void LocalizeForm(Form form)
    {
        TranslateFormText(form);
        TranslateControls(form.Controls);

        form.RightToLeft = RightToLeft.Yes;  // Set RightToLeft for the form explicitly
        form.RightToLeftLayout = true;
    }

    private static void TranslateFormText(Form form)
    {
        string originalText = form.Text.Trim();
        string translatedText = Translator.Translate(originalText);
        form.Text = translatedText;
    }

    private static void TranslateControls(Control.ControlCollection controls)
    {
        foreach (Control control in controls)
        {
            if (control is Label || control is CheckBox || control is Button || control is GroupBox)
            {
                TranslateControlText(control);
            }
            else if (control is DataGridView)
            {
                TranslateDataGridViewHeaders(control as DataGridView);
            }
            else if (control is MenuStrip)
            {
                TranslateMenuStrip(control as MenuStrip);
            }

            // Recursively translate controls within containers
            if (control.HasChildren)
            {
                TranslateControls(control.Controls);
            }

            // Arrange controls within GroupBox from right to left
            if (control is GroupBox)
            {
                ArrangeControlsInGroupBoxRightToLeft(control as GroupBox);
            }
        }
    }

    private static void TranslateControlText(Control control)
    {
        string originalText = control.Text.Trim();
        string translatedText = Translator.Translate(originalText);

        control.Text = translatedText;

        // Set RightToLeft for controls, if needed
        control.RightToLeft = RightToLeft.Yes;

        // Explicitly apply the RTL layout for the control
        ApplyRTLLayout(control);
    }

    private static void ApplyRTLLayout(Control control)
    {
        Form form = control as Form;
        if (form != null)
        {
            ApplyRTLLayout(form);
        }

        foreach (Control childControl in control.Controls)
        {
            ApplyRTLLayout(childControl);
        }
    }

    private static void ApplyRTLLayout(Form form)
    {
        Type formType = form.GetType();
        MethodInfo applyRTLMethod = formType.GetMethod("ApplyRightToLeft", BindingFlags.Instance | BindingFlags.NonPublic);

        if (applyRTLMethod != null)
        {
            applyRTLMethod.Invoke(form, new object[] { });
        }
    }

    private static void TranslateDataGridViewHeaders(DataGridView dataGridView)
    {
        foreach (DataGridViewColumn column in dataGridView.Columns)
        {
            // Translate header text
            string originalHeaderText = column.HeaderText.Trim();
            string translatedHeaderText = Translator.Translate(originalHeaderText);
            column.HeaderText = translatedHeaderText;
        }
    }

    private static void ArrangeControlsInGroupBoxRightToLeft(GroupBox groupBox)
    {
        if (groupBox.RightToLeft == RightToLeft.Yes)
        {
            int groupWidth = groupBox.ClientSize.Width;

            // Get the controls in reverse order
            Control[] reversedControls = new Control[groupBox.Controls.Count];
            groupBox.Controls.CopyTo(reversedControls, 0);
            Array.Reverse(reversedControls);

            foreach (Control control in reversedControls)
            {
                int controlRight = groupWidth - control.Right; // Calculate the right position from the right edge
                control.Location = new Point(controlRight, control.Top);
            }
        }
    }

    private static void TranslateMenuStrip(MenuStrip menuStrip)
    {
        foreach (ToolStripMenuItem menuItem in menuStrip.Items)
        {
            TranslateToolStripMenuItem(menuItem);
        }
    }

    private static void TranslateToolStripMenuItem(ToolStripMenuItem menuItem)
    {
        // Translate menu item text
        string originalText = menuItem.Text.Trim();
        string translatedText = Translator.Translate(originalText);
        menuItem.Text = translatedText;

        // Recursively translate sub-menu items
        foreach (object subItem in menuItem.DropDownItems)
        {
            if (subItem is ToolStripMenuItem)
            {
                TranslateToolStripMenuItem(subItem as ToolStripMenuItem);
            }
        }
    }
}
