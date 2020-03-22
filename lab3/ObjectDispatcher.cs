using System.Drawing;

namespace lab3
{
    public class ObjectDispatcher
    {
        public BilinearSurface BilinearSurface;
        private AxisBase _axisBase;

        public ObjectDispatcher()
        {
            BilinearSurface = new BilinearSurface(
                new Vector3(0, 0, 100),
                new Vector3(100, 100, 100),
                new Vector3(100, 0, 0),
                new Vector3(0, 100, 0));
            _axisBase = new AxisBase();
        }

        public void SetSurface(BilinearSurface surface)
        {
            BilinearSurface = surface;
            _axisBase = new AxisBase();
        }
        
        public void Render(Graphics graphics)
        {
            BilinearSurface.Render(graphics, Pens.Black, 10);
            _axisBase.Render(graphics);
        }

        public void Rotate(Vector3.Axis axis, float angle)
        {
            BilinearSurface.Rotate(axis, angle);
            _axisBase.Rotate(axis, angle);
        }
    }
}