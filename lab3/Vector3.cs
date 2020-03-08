using System;

namespace lab3
{
    public struct Vector3
    {
        public double X;
        public double Y;
        public double Z;

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Rotate(Axis axis, float angle)
        {
            angle = angle * (float) Math.PI / 180;
            switch (axis)
            {
                case Axis.X:
                    Y = Y * Math.Cos(angle) - Z * Math.Sin(angle);
                    Z = Y * Math.Sin(angle) + Z * Math.Cos(angle);
                    break;
                case Axis.Y:
                    X = X * Math.Cos(angle) + Z * Math.Sin(angle);
                    Z = - X * Math.Sin(angle) + Z * Math.Cos(angle);
                    break;
                case Axis.Z:
                    X = X * Math.Cos(angle) - Y * Math.Sin(angle);
                    Y = X * Math.Sin(angle) + Y * Math.Cos(angle);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(axis), axis, null);
            }
        }
        
        public static Vector3 operator +(Vector3 l, Vector3 r) => new Vector3(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        public static Vector3 operator -(Vector3 l, Vector3 r) => new Vector3(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        public static Vector3 operator *(Vector3 l, int m) => new Vector3(l.X * m, l.Y * m, l.Z * m);
        public static Vector3 operator *(int m, Vector3 r) => r * m;
        public static Vector3 operator *(Vector3 l, double m) => new Vector3(l.X * m, l.Y * m, l.Z * m);
        public static Vector3 operator *(double m, Vector3 r) => r * m;

        public enum Axis
        {
            X,
            Y,
            Z
        }
    }
}