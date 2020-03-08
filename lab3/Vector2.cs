namespace lab3
{
    public struct Vector2
    {
        public double X;
        public double Y;

        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        public static Vector2 operator +(Vector2 l, Vector2 r) => new Vector2(l.X + r.X, l.Y + r.Y);
        public static Vector2 operator -(Vector2 l, Vector2 r) => new Vector2(l.X - r.X, l.Y - r.Y);
        public static Vector2 operator *(Vector2 l, int m) => new Vector2(l.X * m, l.Y * m);
        public static Vector2 operator *(int m, Vector2 r) => r * m;
        public static Vector2 operator *(Vector2 l, double m) => new Vector2(l.X * m, l.Y * m);
        public static Vector2 operator *(double m, Vector2 r) => r * m;
    }
}