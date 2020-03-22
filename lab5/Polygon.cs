using System.Drawing;

namespace lab5
{
    public class Polygon
    {
        public Color Color { get; }
        public float A { get; }
        public float B { get; }
        public float C { get; }
        
        private Vector3 _p1;
        private Vector3 _p2;
        private Vector3 _p3;

        public Polygon(Vector3 p1, Vector3 p2, Vector3 p3, Color color)
        {
            _p1 = p1;
            _p2 = p2;
            _p3 = p3;
            Color = color;

            var b = new Vector3(-1, -1, -1);
            var det = Det(p1, p2, p3);
            var det1 = Det(b, p2, p3);
            var det2 = Det(p1, b, p3);
            var det3 = Det(p1, p2, b);
            A = det1 / det;
            B = det2 / det;
            C = det3 / det;
            
            float Det(Vector3 k, Vector3 l, Vector3 m)
            {
                return k.X * l.Y * m.Z
                       + m.X * k.Y * l.Z
                       + l.X * m.Y * k.Z
                       - m.X * l.Y * k.Z
                       - k.X * m.Y * l.Z
                       - l.X * k.Y * m.Z;
            }
        }

        public bool IsContainsPoint(Vector2 point)
        {
            // считаются произведения (1, 2, 3 - вершины треугольника, 0 - точка):
            // (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0)
            // (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0)
            // (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0)
            // Если они одинакового знака, то точка внутри треугольника, если что-то из этого - ноль,
            // то точка лежит на стороне, иначе точка вне треугольника.
            
            var a = (_p1.X - point.X) * (_p2.Y - _p1.Y) - (_p2.X - _p1.X) * (_p1.Y - point.Y);
            var b = (_p2.X - point.X) * (_p3.Y - _p2.Y) - (_p3.X - _p2.X) * (_p2.Y - point.Y);
            var c = (_p3.X - point.X) * (_p1.Y - _p3.Y) - (_p1.X - _p3.X) * (_p3.Y - point.Y);
            return a >= 0 && b >= 0 && c >= 0 || a <= 0 && b <= 0 && c <= 0;
        }

        public float GetZValueOfPoint(Vector2 point)
        {
            // Ax + By + Cz + 1 = 0 =>
            // z = - (1 + Ax + By) / C

            return -(1 + A * point.X + B * point.Y) / C;
        }
    }
}