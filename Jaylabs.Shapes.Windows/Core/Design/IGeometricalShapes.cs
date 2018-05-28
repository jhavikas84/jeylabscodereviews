
using System;
using System.Windows.Forms;

namespace Jaylabs.Shapes.Windows.Core.Design
{
    public interface IGeometricalShapes: IDisposable 
    {
        void DrawShape(PaintEventArgs e);
    }
}
