namespace lab1
{
    public struct Rect
    {
        public Vector2 TopLeft;
        public Vector2 TopRight;
        public Vector2 BottomLeft;
        public Vector2 BottomRight;

        public Rect(double x1, double y1, double x2, double y2)
        {
            TopLeft = new Vector2(x1, y1);
            TopRight = new Vector2(x2, y1);
            BottomLeft = new Vector2(x1, y2);
            BottomRight = new Vector2(x2, y2);
        }

        public void Rotate(Vector2 point, float angle)
        {
            TopLeft.RotateAround(point, angle);
            TopRight.RotateAround(point, angle);
            BottomLeft.RotateAround(point, angle);
            BottomRight.RotateAround(point, angle);
        }
    }
}