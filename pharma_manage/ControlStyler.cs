using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class ControlStyler
{
    public static void ApplyModernStyle(Control control)
    {
        // Calculate corner radius and border width
        int cornerRadius = Math.Min(control.Width, control.Height) / 5;
        int borderWidth = Math.Max(control.Height / 20, 1);
        Color borderColor = Color.LightGray;  // Color of the border
        Color shadowColor = Color.FromArgb(80, 0, 0, 0); // Shadow color

        // Check if the control is a TextBox, Button, or Panel
        if (control is TextBox || control is Button || control is Panel)
        {
            // Create a rounded rectangle path for the control's region
            GraphicsPath path = CreateRoundedRectanglePath(control.ClientRectangle, cornerRadius);
            control.Region = new Region(path);

            // Attach Paint event to draw the border and shadow
            control.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw shadow
                using (SolidBrush shadowBrush = new SolidBrush(shadowColor))
                {
                    e.Graphics.TranslateTransform(3, 3);  // Apply shadow offset
                    e.Graphics.FillPath(shadowBrush, path);
                    e.Graphics.TranslateTransform(-3, -3); // Reset transform
                }

                // Draw border
                using (Pen borderPen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            };
        }

        // Handle Button controls (for flat style)
        if (control is Button)
        {
            Button button = (Button)control;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }
        // Handle TextBox controls (remove border)
        else if (control is TextBox)
        {
            TextBox textBox = (TextBox)control;
            textBox.BorderStyle = BorderStyle.None;
        }

        // Optional: Force redraw when resized
        control.Resize += (s, e) =>
        {
            control.Region = new Region(CreateRoundedRectanglePath(control.ClientRectangle, cornerRadius));
            control.Invalidate();
        };
    }

    private static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90);
        path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90);
        path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
        path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
        path.CloseFigure();
        return path;
    }
}
