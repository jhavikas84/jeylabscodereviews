using Jaylabs.Shapes.Windows.Core.Design;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Jaylabs.Shapes.Windows.Forms
{
    public partial class Main : Form
    {
        const string _ShapeText = @"<shape>";
        const string _MesurementText = @"<measurement>";
        const string _AmountText = @"<amount>";

        public List<Shape> Shapes => new List<Shape>()
        {
            new Shape(){ Name ="<shape>" , Value=""},
            new Shape(){ Name ="Isosceles Triangle" , Value="Line"},
            new Shape(){ Name= "Square", Value ="Rectangle" },
            new Shape(){ Name= "Scalene Triangle", Value ="Line" },
            new Shape(){ Name= "Parallelogram", Value ="Rectangle" },
            new Shape(){ Name= "Equilateral Triangle", Value ="Line" },
            new Shape(){ Name= "Pentagon", Value ="Polygon" },
            new Shape(){ Name= "Rectangle", Value ="Rectangle" },
            new Shape(){ Name= "Hexagon", Value ="Polygon" },
            new Shape(){ Name= "Heptagon", Value ="Polygon" },
            new Shape(){ Name= "Octagon", Value ="Polygon" },
            new Shape(){ Name= "Circle", Value ="Circle" },
            new Shape(){ Name= "Oval", Value ="Circle" }
        };

        public Main()
        {
            InitializeComponent();

            txtAmount.Text = txtAndMesurementAmount.Text = _AmountText;
            txtMesurement.Text = txtAndMesurement.Text = _MesurementText;

            InitialSetup();
        }

        private void InitialSetup()
        {
            foreach (Control panel in Controls.Find("FilterPanel", true))
            {
                foreach (Control item in panel.Controls)
                {
                    if (item.GetType().Equals(typeof(TextBox)))
                    {
                        item.ForeColor = Color.Gray;

                        item.GotFocus += OnAmountFocus;
                        item.LostFocus += OnAmountLostFocus;

                        //switch (item.Name)
                        //{
                        //   case "txtAmount":
                        //    case "txtAndMesurementAmount":
                        //        break;
                        //    case "txtMesurement":
                        //    case "txtAndMesurement":
                        //        break;
                        //    case "txtShape":                            
                        //        break;
                        //    default:
                        //        break;
                        //}
                    }
                    else if (item.GetType().Equals(typeof(ComboBox)))
                    {
                        var shapes = (ComboBox)item;
                        shapes.Items.Clear();

                        shapes.DataSource = Shapes;
                        shapes.ValueMember = "Value";
                        shapes.DisplayMember = "Name";
                    }
                }
            }
        }

        private void OnAmountLostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                textBox.ForeColor = Color.Gray;
                switch (textBox.Name)
                {
                    case "txtAmount":
                    case "txtAndMesurementAmount":
                        textBox.Text = _AmountText;
                        break;
                    case "txtMesurement":
                    case "txtAndMesurement":
                        textBox.Text = _MesurementText;
                        break;
                    case "txtShape":
                        textBox.Text = _ShapeText;
                        break;
                    default:
                        break;
                }

            }
        }

        private void OnAmountFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.ForeColor = Color.Black;
            textBox.Text = string.Empty;
        }

        private void OnGenerateShapeClick(object sender, EventArgs e)
        {
            if (shapeComboBox.SelectedIndex > 0)
            {
                try
                {
                    using (var theShape = CreateInstance(shapeComboBox.SelectedValue.ToString()))
                    {
                        var selected = shapeComboBox.GetItemText(shapeComboBox.SelectedItem);

                        theShape.TheShape = GetShapeEnum(selected);
                        theShape.TheDimension = new Dimension()
                        {
                            Length = txtAmount.Text.Replace(_AmountText, string.Empty) != string.Empty ? Convert.ToInt32(txtAmount.Text.Trim()) : 0,
                            Height = txtAndMesurementAmount.Text.Replace(_AmountText, string.Empty) != string.Empty ? Convert.ToInt32(txtAndMesurementAmount.Text.Trim()) : 0
                        };
                        ShapeForm sf = new ShapeForm()
                        {
                            TheShape = theShape
                        };
                        sf.ShowDialog(this);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private ShapesEnum GetShapeEnum(string selectedShape)
        {
            var instanceName = selectedShape;

            switch (selectedShape)
            { 
                case "Isosceles Triangle":
                    instanceName = "IsoscelesTriangle";
                    break;
                case "Scalene Triangle":
                    instanceName = "ScaleneTriangle";
                    break;              
                case "Equilateral Triangle":
                    instanceName = "EquilateralTriangle";
                    break;
            }

            return (ShapesEnum)Enum.Parse(typeof(ShapesEnum), instanceName);
        }

        public GeometricalShapeBase CreateInstance(string selectedShape)
        {
            Assembly assembly = typeof(GeometricalShapeBase).Assembly;
            GeometricalShapeBase theShape = (GeometricalShapeBase)assembly.CreateInstance($"Jaylabs.Shapes.Windows.Core.Features.{selectedShape}");
            return theShape;
        }
    }
}
