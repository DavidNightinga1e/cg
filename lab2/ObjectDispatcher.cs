using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace lab2
{
    public sealed class ObjectDispatcher
    {
        public Pen PenBrokenCurve = Pens.Navy;
        public Pen PenBezierCurve = Pens.Lime;

        private readonly BrokenCurve _brokenCurve;
        private readonly BezierCurve _bezierCurve;

        public ObjectDispatcher()
        {
            _bezierCurve = new BezierCurve();
            _brokenCurve = new BrokenCurve();
        }

        public Image GetRender()
        {
            var image = new Bitmap(360, 360);
            using (var graphics = Graphics.FromImage(image))
            {
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                
                _brokenCurve.Render(graphics, PenBrokenCurve);
                _bezierCurve.Render(graphics, PenBezierCurve, 0.001f);
            }

            return image;
        }

        public void AddPoint(Vector2 point)
        {
            _brokenCurve.AddPoint(point);
            _bezierCurve.Points = new List<Vector2>(_brokenCurve.Points);
        }

        public void Clear()
        {
            _brokenCurve.Clear();
            _bezierCurve.Clear();
        }
    }
}