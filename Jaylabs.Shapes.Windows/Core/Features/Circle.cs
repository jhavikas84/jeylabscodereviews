using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Jaylabs.Shapes.Windows.Core.Design;


namespace Jaylabs.Shapes.Windows.Core.Features
{
    public class Circle : GeometricalShapeBase
    {
        public override Dimension TheDimension { get => base.TheDimension; set => base.TheDimension = value; }

        public override void DrawShape(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (TheShape == ShapesEnum.Circle) e.Graphics.DrawEllipse(ThePen, TheDimension.Length, TheDimension.Length, TheDimension.Length, TheDimension.Length);
            else e.Graphics.DrawEllipse(ThePen, new System.Drawing.Rectangle(TheDimension.Length, TheDimension.Height, TheDimension.Length, TheDimension.Height));
        }
    }
}
