
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jaylabs.Shapes.Windows.Core.Design
{
    public abstract class GeometricalShapeBase : IGeometricalShapes
    {
        private Dimension _TheDimension;
        public virtual Dimension TheDimension
        {
            get => _TheDimension;
            set => _TheDimension = value;
        }
        public Pen ThePen => new Pen(Color.Red, 5);

        private ShapesEnum _TheShape;
        public ShapesEnum TheShape
        {
            get => _TheShape;
            set => _TheShape = value;
        }

        public abstract void DrawShape(PaintEventArgs e);

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~GeometricalShapeBase() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
