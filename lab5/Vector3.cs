using System;

namespace lab5
{
    public struct Vector3
    {
        public float X;
        public float Y;
        public float Z;

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public static Vector3 operator +(Vector3 l, Vector3 r) => new Vector3(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        public static Vector3 operator -(Vector3 l, Vector3 r) => new Vector3(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        public static Vector3 operator *(Vector3 l, int m) => new Vector3(l.X * m, l.Y * m, l.Z * m);
        public static Vector3 operator *(int m, Vector3 r) => r * m;
        public static Vector3 operator *(Vector3 l, float m) => new Vector3(l.X * m, l.Y * m, l.Z * m);
        public static Vector3 operator *(float m, Vector3 r) => r * m;
    }
}