using System.Drawing;

namespace lab3
{
    public class ObjectDispatcher
    {
        public BilinearSurface _bilinearSurface;
        private AxisBase _axisBase;

        public ObjectDispatcher()
        {
            _bilinearSurface = new BilinearSurface(
                new Vector3(0, 0, 100),
                new Vector3(100, 100, 100),
                new Vector3(100, 0, 0),
                new Vector3(0, 100, 0));
            _axisBase = new AxisBase();
            
        }

        public void SetSurface(BilinearSurface surface)
        {
            _bilinearSurface = surface;
            _axisBase = new AxisBase();
        }
        
        public void Render(Graphics graphics)
        {
            _bilinearSurface.Render(graphics, Pens.Black, 10);
            _axisBase.Render(graphics);
        }

        public void Rotate(Vector3.Axis axis, float angle)
        {
            _bilinearSurface.Rotate(axis, angle);
            _axisBase.Rotate(axis, angle);
        }
    }
}