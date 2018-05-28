using Jaylabs.Shapes.Windows.Core.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaylabs.Shapes.Windows.Forms
{
    public partial class ShapeForm : Form
    {
        public ShapeForm()
        {
            InitializeComponent();
            Paint += OnShapeFormPaint;
        }

        private GeometricalShapeBase _TheShape;
        public GeometricalShapeBase TheShape
        {
            get => _TheShape;
            set => _TheShape = value;
        }

        private void OnShapeFormPaint(object sender, PaintEventArgs e)
        {
            DrawPolygonPoint(e);
        }

        public void DrawPolygonPoint(PaintEventArgs e)
        {
            using (TheShape)
            {
                TheShape.DrawShape(e);
            }
             
        }
    }
}
