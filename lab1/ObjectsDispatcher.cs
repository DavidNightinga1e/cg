using System.Drawing;

namespace lab1
{
    public class ObjectsDispatcher
    {
        public Vector2 RotationPoint;
        public Rect Rectangle;
        public Rect LastPositionRectangle;

        public ObjectsDispatcher()
        {
            Rectangle = new Rect(120, 120, 150, 150);
            LastPositionRectangle = Rectangle;
            RotationPoint = new Vector2(100, 100);
        }

        public Image Render()
        {
            var image = new Bitmap(360, 360);
            using (var graphics = Graphics.FromImage(image))
            {
                var pen = Pens.Turquoise;
                graphics.DrawRectangle(pen, LastPositionRectangle);
                pen = Pens.MediumVioletRed;
                graphics.DrawEllipse(pen, (int) RotationPoint.X - 2, (int) RotationPoint.Y - 2, 4, 4);
                pen = Pens.Black;
                graphics.DrawRectangle(pen, Rectangle);
            }

            return image;
        }

        public void RotateRectangle(float angle)
        {
            LastPositionRectangle = Rectangle;
            Rectangle.Rotate(RotationPoint, angle);
        }
    }
}