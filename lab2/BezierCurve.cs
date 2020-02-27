using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;

namespace lab2
{
    public sealed class BezierCurve
    {
        public List<Vector2> Points;

        public BezierCurve()
        {
            Points = new List<Vector2>();
        }
        
        public void Render(Graphics graphics, Pen pen, float step)
        {
            if (Points.Count < 2) return;

            float current = 0;

            while (current + step <= 1)
            {
                var p1 = getPointOnCurve(current);
                var p2 = getPointOnCurve(current + step);
                
                graphics.DrawLine(pen, (float)p1.X, (float)p1.Y, (float)p2.X, (float)p2.Y);
                
                current += step;
            }
        }

        public Vector2 getPointOnCurve(float t)
        {
            if (t < 0 || t > 1) return new Vector2(0, 0);

            var result = new Vector2(0, 0);
            for (int i = 1; i <= Points.Count; i++)
            {
                var combinations = MathExt.Combinations(Points.Count - 1, i - 1);
                var pow = Math.Pow(1 - t, Points.Count - i);
                var point = Points[i - 1];
                var pow2 = Math.Pow(t, i - 1);
                result += pow * 
                          point * pow2 *
                          combinations;
            }

            return result;
        }

        public void Clear()
        {
            Points.Clear();
        }
    }
}