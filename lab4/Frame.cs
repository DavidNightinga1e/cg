using System.Drawing;

namespace lab4
{
    public class Frame
    {
        public readonly float Top;
        public readonly float Bottom;
        public readonly float Left;
        public readonly float Right;

        public Frame(float top, float bottom, float left, float right)
        {
            Top = top;
            Bottom = bottom;
            Left = left;
            Right = right;
        }

        public byte GetCode(Vector2 point)
        {
            byte result = 0;
            if (point.X < Left)
                result |= 1;
            else if (point.X > Right)
                result |= 2;
            if (point.Y < Bottom)
                result |= 4;
            else if (point.Y > Top)
                result |= 8;
            return result;
        }

        public void Render(Graphics graphics, Pen pen, Brush brush)
        {
            graphics.FillRectangle(brush, Left, Bottom, Right - Left, Top - Bottom);
            graphics.DrawRectangle(pen, Left, Bottom, Right - Left, Top - Bottom);
        }
    }
}