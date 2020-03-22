using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace lab2
{
    public sealed class ObjectDispatcher
    {
        public Pen PenBrokenCurve = Pens.Navy;
        public Pen PenBezierCurve = Pens.Lime;

        public BrokenCurve BrokenCurve { get; }
        private readonly BezierCurve _bezierCurve;

        public ObjectDispatcher()
        {
            _bezierCurve = new BezierCurve();
            BrokenCurve = new BrokenCurve();
        }

        public Image GetRender()
        {
            var image = new Bitmap(360, 360);
            using (var graphics = Graphics.FromImage(image))
            {
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                
                BrokenCurve.Render(graphics, PenBrokenCurve);
                _bezierCurve.Render(graphics, PenBezierCurve, 0.001f);
            }

            return image;
        }

        public void AddPoint(Vector2 point)
        {
            BrokenCurve.AddPoint(point);
            _bezierCurve.Points = new List<Vector2>(BrokenCurve.Points);
        }

        public void Clear()
        {
            BrokenCurve.Clear();
            _bezierCurve.Clear();
        }
    }
}