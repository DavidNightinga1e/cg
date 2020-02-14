using System;

namespace lab1
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

        public void RotateAroundZero(float angleDegrees)
        {
            var angle = angleDegrees * Math.PI / 180;
            var sin = Math.Sin(angle);
            var cos = Math.Cos(angle);
            var newX = X * cos - Y * sin;
            var newY = X * sin + Y * cos;
            X = newX;
            Y = newY;
        }

        public void RotateAround(Vector2 point, float angle)
        {
            var positionInNewSpace= this - point;
            positionInNewSpace.RotateAroundZero(angle);
            var positionInOldSpace = positionInNewSpace + point;
            this = positionInOldSpace;
        }

        public static Vector2 operator +(Vector2 l, Vector2 r) => new Vector2(l.X + r.X, l.Y + r.Y);
        public static Vector2 operator -(Vector2 l, Vector2 r) => new Vector2(l.X - r.X, l.Y - r.Y);
    }
}