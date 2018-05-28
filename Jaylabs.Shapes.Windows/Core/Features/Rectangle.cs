using Jaylabs.Shapes.Windows.Core.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Jaylabs.Shapes.Windows.Core.Features
{
    public class Rectangle : GeometricalShapeBase
    {
        public override Dimension TheDimension { get => base.TheDimension; set => base.TheDimension = value; }

        public override void DrawShape(PaintEventArgs e)
        {
            e.Graphics.RenderingOrigin = new Point(100, 100);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        
            if (TheShape == ShapesEnum.Square) e.Graphics.DrawRectangle(ThePen, new System.Drawing.Rectangle(TheDimension.Length, TheDimension.Length, TheDimension.Length, TheDimension.Length));
            else e.Graphics.DrawRectangle(ThePen, new System.Drawing.Rectangle(TheDimension.Length, TheDimension.Height, TheDimension.Length, TheDimension.Height));

        }
    }
}
