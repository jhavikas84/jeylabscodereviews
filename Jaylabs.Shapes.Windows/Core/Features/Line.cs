using Jaylabs.Shapes.Windows.Core.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Jaylabs.Shapes.Windows.Core.Features
{
    public class Line : GeometricalShapeBase
    {
        public override Dimension TheDimension { get => base.TheDimension; set => base.TheDimension = value; }

        public override void DrawShape(PaintEventArgs e)
        {
            Point p1 = new Point(TheDimension.Length, TheDimension.Length);
            Point p2 = new Point(TheDimension.Length, TheDimension.Height);
            Point p3 = new Point(TheDimension.Height - TheDimension.Length, TheDimension.Length);
            e.Graphics.RenderingOrigin = new Point(100, 100);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(ThePen, p1, p2);
            e.Graphics.DrawLine(ThePen, p2, p3);
            e.Graphics.DrawLine(ThePen, p3, p1);
        }
    }
}
