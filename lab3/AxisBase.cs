using System.Drawing;
using System.Windows.Forms;

namespace lab3
{
    public class AxisBase
    {
        Vector3 _up = new Vector3(0, 0, 100);
        Vector3 _right = new Vector3(0, 100, 0);
        Vector3 _forward = new Vector3(100, 0, 0);

        public void Render(Graphics graphics)
        {
            graphics.DrawLine(Pens.Chartreuse, (float) SpaceSettings.ScreenZero.X, (float) SpaceSettings.ScreenZero.Y,
                (float) SpaceSettings.WorldPointToScreen(_up).X, (float) SpaceSettings.WorldPointToScreen(_up).Y);
            graphics.DrawLine(Pens.Red, (float) SpaceSettings.ScreenZero.X, (float) SpaceSettings.ScreenZero.Y,
                (float) SpaceSettings.WorldPointToScreen(_right).X, (float) SpaceSettings.WorldPointToScreen(_right).Y);
            graphics.DrawLine(Pens.Blue, (float) SpaceSettings.ScreenZero.X, (float) SpaceSettings.ScreenZero.Y,
                (float) SpaceSettings.WorldPointToScreen(_forward).X, (float) SpaceSettings.WorldPointToScreen(_forward).Y);
        }
        
        public void Rotate(Vector3.Axis axis, float angle)
        {
            _up.Rotate(axis, angle);
            _right.Rotate(axis, angle);
            _forward.Rotate(axis, angle);
        }
    }
}