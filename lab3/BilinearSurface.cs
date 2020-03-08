using System;
using System.Drawing;
using System.Linq;

namespace lab3
{
    public class BilinearSurface
    {
        public Vector3 P00;
        public Vector3 P01;
        public Vector3 P10;
        public Vector3 P11;

        public BilinearSurface(Vector3 p00, Vector3 p01, Vector3 p10, Vector3 p11)
        {
            P00 = p00;
            P01 = p01;
            P10 = p10;
            P11 = p11;
        }

        public void Rotate(Vector3.Axis axis, float angle)
        {
            P00.Rotate(axis, angle);
            P01.Rotate(axis, angle);
            P10.Rotate(axis, angle);
            P11.Rotate(axis, angle);
        }

        public void Render(Graphics graphics, Pen pen, uint density)
        {
            if (density == 0)
                throw new Exception("density must be positive and not a zero");

            var currentX = 0f;
            var step = 1f / density;

            while (currentX <= 1f - step)
            {
                var currentY = 0f;
                while (currentY <= 1f - step)
                {
                    var pt1 = SpaceSettings.WorldPointToScreen(Evaluate(currentX, currentY));
                    var pt2 = SpaceSettings.WorldPointToScreen(Evaluate(currentX, currentY + step));
                    var pt3 = SpaceSettings.WorldPointToScreen(Evaluate(currentX + step, currentY + step));
                    graphics.DrawLine(pen, (float)pt1.X, (float)pt1.Y, (float)pt2.X,
                        (float)pt2.Y);
                    graphics.DrawLine(pen, (float)pt3.X, (float)pt3.Y, (float)pt2.X,
                        (float)pt2.Y);

                    currentY += step;
                }

                currentX += step;
            }
        }

        public Vector3 Evaluate(double u, double w)
        {
            return P00 * (1 - u) * (1 - w) +
                   P01 * (1 - u) * w +
                   P10 * u * (1 - w) +
                   P11 * u * w;
        }
    }
}