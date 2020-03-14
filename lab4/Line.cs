using System;
using System.Collections.Generic;
using System.Drawing;

namespace lab4
{
    public class Line
    {
        public Vector2 A;
        public Vector2 B;

        public Line(float ax, float ay, float bx, float by)
        {
            A = new Vector2(ax, ay);
            B = new Vector2(bx, by);
        }

        public void Render(Graphics graphics, Pen pen, Brush brush)
        {
            graphics.DrawLine(pen, A.X, A.Y, B.X, B.Y);
            graphics.FillEllipse(brush, A.X - 3, A.Y - 3, 6, 6);
            graphics.FillEllipse(brush, B.X - 3, B.Y - 3, 6, 6);
        }

        public Vector2? GetPointWithX(float x, float top, float bottom)
        {
            var a = A.Y - B.Y;
            var b = B.X - A.X;
            var c = A.X * B.Y - B.X * A.Y;

            // ax + by + c = 0;
            // y = - (ax + c)/b

            var y = -(a * x + c) / b;
            return y < top && y > bottom ? new Vector2?(new Vector2(x, y)) : null;
        }

        public Vector2? GetPointWithY(float y, float left, float right)
        {
            var a = A.Y - B.Y;
            var b = B.X - A.X;
            var c = A.X * B.Y - B.X * A.Y;

            // ax + by + c = 0;
            // x = - (by + c)/a

            var x = -(b * y + c) / a;
            return x > left && x < right ? new Vector2?(new Vector2(x, y)) : null;
        }

        public Vector2? GetIntersection(Frame frame, Vector2 point)
        {
            var left = GetPointWithX(frame.Left, frame.Top, frame.Bottom);
            var right = GetPointWithX(frame.Right, frame.Top, frame.Bottom);
            var top = GetPointWithY(frame.Top, frame.Left, frame.Right);
            var bottom = GetPointWithY(frame.Bottom, frame.Left, frame.Right);

            float leftDistance = float.PositiveInfinity,
                rightDistance = float.PositiveInfinity,
                bottomDistance = float.PositiveInfinity,
                topDistance = float.PositiveInfinity;

            if (left != null)
            {
                leftDistance = left.Value.SqrDistance(point);
            }

            if (right != null)
            {
                rightDistance = right.Value.SqrDistance(point);
            }

            if (top != null)
            {
                topDistance = top.Value.SqrDistance(point);
            }

            if (bottom != null)
            {
                bottomDistance = bottom.Value.SqrDistance(point);
            }

            if (leftDistance < rightDistance && leftDistance < bottomDistance && leftDistance < topDistance)
                return left;
            if (rightDistance < leftDistance && rightDistance < bottomDistance && rightDistance < topDistance)
                return right;
            if (topDistance < rightDistance && topDistance < bottomDistance && topDistance < leftDistance)
                return top;
            if (bottomDistance < rightDistance && bottomDistance < leftDistance && bottomDistance < topDistance)
                return bottom;
            
            return null;
        }
    }
}