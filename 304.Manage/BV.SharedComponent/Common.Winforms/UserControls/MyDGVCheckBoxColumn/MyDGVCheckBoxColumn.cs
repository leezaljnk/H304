using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Winforms.UserControls
{
    public class MyDGVCheckBoxColumn : DataGridViewCheckBoxColumn
    {
        public string Label { get; set; }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return new MyDGVCheckBoxCell();
            }
        }
    }

    public class MyDGVCheckBoxCell : DataGridViewCheckBoxCell
    {
        public string Label { get; set; }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {

            // the base Paint implementation paints the check box
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            // Get the check box bounds: they are the content bounds
            Rectangle contentBounds = this.GetContentBounds(rowIndex);

            // Compute the location where we want to paint the string.
            Point stringLocation = new Point();

            // Compute the Y.
            // NOTE: the current logic does not take into account padding.
            stringLocation.Y = cellBounds.Y + 2;


            // Compute the X.
            // Content bounds are computed relative to the cell bounds
            // - not relative to the DataGridView control.
            stringLocation.X = cellBounds.X + contentBounds.Right + 2;


            // Paint the string.
            if (this.Label == null)
            {
                MyDGVCheckBoxColumn col = (MyDGVCheckBoxColumn)this.OwningColumn;
                Label = col.Label;
            }

            graphics.DrawString(
            this.Label, Control.DefaultFont, System.Drawing.Brushes.Red, stringLocation);

        }

    }
}
