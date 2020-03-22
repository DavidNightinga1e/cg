using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace lab4
{
    public class ObjectDispatcher
    {
        public Frame Frame;
        public List<Line> Lines;
        public List<Line> ClippedLines;

        public Brush FrameBrush = new SolidBrush(Color.FromArgb(15, 0, 255, 100));
        public Pen FramePen = Pens.Black;
        public Brush LineBrush = Brushes.Red;
        public Pen LinePen = Pens.CornflowerBlue;
        public Brush ClippedLineBrush = Brushes.Chartreuse;
        public Pen ClippedLinePen = Pens.Lime;
        

        private Random _random;

        public ObjectDispatcher()
        {
            Frame = new Frame(230, 70, 70, 230);
            Lines = new List<Line>();
            ClippedLines = new List<Line>();
            _random = new Random();
        }

        public Image Render()
        {
            var bitmap = new Bitmap(360, 360);

            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                Frame.Render(graphics, FramePen, FrameBrush);
                Lines.ForEach(t => t.Render(graphics, LinePen, LineBrush));
                ClippedLines.ForEach(t => t.Render(graphics, ClippedLinePen, ClippedLineBrush));
            }

            return bitmap;
        }

        public void RandomizeSegments(int count)
        {
            Lines.Clear();
            ClippedLines.Clear();
            for (int i = 0; i < count; ++i)
            {
                Lines.Add(new Line(_random.Next(0, 360), _random.Next(0, 360), _random.Next(0, 360),
                    _random.Next(0, 360)));
            }
        }

        public void Clip()
        {
            ClippedLines.Clear();
            
            var clippedLines = Lines
                .Select(line => CohenSutherland.CreateClippedLine(line, Frame))
                .Where(clipped => clipped != null);

            ClippedLines.AddRange(clippedLines);
        }
    }
}