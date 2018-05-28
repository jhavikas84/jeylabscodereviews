using Jaylabs.Shapes.Windows.Core.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Jaylabs.Shapes.Windows.Core.Features
{
    public class Polygon : GeometricalShapeBase
    {
        public override Dimension TheDimension { get => base.TheDimension; set => base.TheDimension = value; }



        private Point[] GetPentaPoints()
        {
            Point[] curvePoints =
                       {
                            new Point(50, 50),
                            new Point(100, 25),
                            new Point(200, 5),
                            new Point(250, 50),
                            new Point(300, 100)
                        };                      
          

            return curvePoints;
        }

        private Point[] GetHexaPoints()
        {
            Point[] curvePoints =
                       {
                            new Point(50, 50),
                            new Point(100, 25),
                            new Point(200, 5),
                            new Point(250, 50),
                            new Point(300, 100),
                            new Point(350, 200)
                        };

            return curvePoints;

        }

        private Point[] GetHeptaPoints()
        {

            Point[] curvePoints =
                       {
                            new Point(50, 50),
                            new Point(100, 25),
                            new Point(200, 5),
                            new Point(250, 50),
                            new Point(300, 100),
                            new Point(350, 200),
                            new Point(250, 250)
                        };

            return curvePoints;
        }

        private Point[] GetOctaPoints()
        {
            Point[] curvePoints =
                       {
                            new Point(50, 50),
                            new Point(100, 25),
                            new Point(200, 5),
                            new Point(250, 50),
                            new Point(300, 100),
                            new Point(350, 200),
                            new Point(250, 250),
                            new Point(200, 200)
                        };

            return curvePoints;
        }
        public override void DrawShape(PaintEventArgs e)
        {

            switch (TheShape)
            {
                case ShapesEnum.Pentagon:
                    e.Graphics.DrawPolygon(ThePen, GetPentaPoints());
                    break;
                case ShapesEnum.Hexagon:
                    e.Graphics.DrawPolygon(ThePen, GetHexaPoints());
                    break;
                case ShapesEnum.Heptagon:
                    e.Graphics.DrawPolygon(ThePen, GetHeptaPoints());
                    break;
                case ShapesEnum.Octagon:
                    e.Graphics.DrawPolygon(ThePen, GetOctaPoints());
                    break;               
            }

        }
    }
}
