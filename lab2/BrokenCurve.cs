using System.Collections.Generic;
using System.Drawing;

namespace lab2
{
    public sealed class BrokenCurve
    {
        public List<Vector2> Points;

        public BrokenCurve()
        {
            Points = new List<Vector2>();
        }
        
        public void Render(Graphics graphics, Pen pen)
        {
            for (int i = 0; i < Points.Count - 1; i++)
            {
                graphics.DrawLine(pen, (float)Points[i].X, (float)Points[i].Y, (float)Points[i + 1].X, (float)Points[i + 1].Y);
            }

            foreach (var point in Points)
            {
                graphics.DrawRectangle(pen, (float)point.X - 2, (float)point.Y - 2, 4, 4);
            }
        }

        public void AddPoint(Vector2 point) => Points.Add(point);

        public void Clear()
        {
            Points.Clear();
        }
    }
}