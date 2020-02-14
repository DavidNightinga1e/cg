using System.Drawing;

namespace lab1
{
    public static class ExtGraphics
    {
        public static void DrawRectangle(this Graphics graphics, Pen pen, Rect rect)
        {
            graphics.DrawLine(pen, (int)rect.TopLeft.X, (int)rect.TopLeft.Y, (int)rect.TopRight.X, (int)rect.TopRight.Y);
            graphics.DrawLine(pen, (int)rect.TopRight.X, (int)rect.TopRight.Y, (int)rect.BottomRight.X, (int)rect.BottomRight.Y);
            graphics.DrawLine(pen, (int)rect.BottomRight.X, (int)rect.BottomRight.Y, (int)rect.BottomLeft.X, (int)rect.BottomLeft.Y);
            graphics.DrawLine(pen, (int)rect.BottomLeft.X, (int)rect.BottomLeft.Y, (int)rect.TopLeft.X, (int)rect.TopLeft.Y);
        }
    }
}