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

            while (current + step <= 1 - step)
            {
                var p1 = getPointOnCurve(current);
                var p2 = getPointOnCurve(current + step);
                
                graphics.DrawLine(pen, (float)p1.X, (float)p1.Y, (float)p2.X, (float)p2.Y);
                
                current += step;
            }
        }

        public Vector2 getPointOnCurve(float t)
        {
            if (t < 0 || t > 1) 
                throw new Exception("t c [0; 1]");

            var result = new Vector2(0, 0);
            var n = Points.Count - 1;
            for (int k = 0; k <= n; k++)
            {
                var combinations = MathExt.Combinations(n, k);
                var pow = Math.Pow(1 - t, n - k);
                var point = Points[k];
                var pow2 = Math.Pow(t, k);
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