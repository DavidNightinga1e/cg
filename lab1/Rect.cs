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

        public Vector2[] GetAllPoints()
        {
            return new[] {TopLeft, TopRight, BottomLeft, BottomRight};
        }

        public void SetAllPoints(Vector2[] points)
        {
            TopLeft = points[0];
            TopRight = points[1];
            BottomLeft = points[2];
            BottomRight = points[3];
        }
    }
}