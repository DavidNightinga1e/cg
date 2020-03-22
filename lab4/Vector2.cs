namespace lab4
{
    public struct Vector2
    {
        public float X;
        public float Y;

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }
        public float SqrDistance(Vector2 r) => (r.X - X) *(r.X - X) + (r.Y - Y) * (r.Y - Y);
        
        public static Vector2 operator +(Vector2 l, Vector2 r) => new Vector2(l.X + r.X, l.Y + r.Y);
        public static Vector2 operator -(Vector2 l, Vector2 r) => new Vector2(l.X - r.X, l.Y - r.Y);
        public static Vector2 operator *(Vector2 l, int m) => new Vector2(l.X * m, l.Y * m);
        public static Vector2 operator *(int m, Vector2 r) => r * m;
        public static Vector2 operator *(Vector2 l, float m) => new Vector2(l.X * m, l.Y * m);
        public static Vector2 operator *(float m, Vector2 r) => r * m;
    }
}