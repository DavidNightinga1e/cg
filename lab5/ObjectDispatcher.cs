using System.Collections.Generic;
using System.Drawing;

namespace lab5
{
    public class ObjectDispatcher
    {
        private readonly List<Polygon> _polygons;
        private readonly ZBuffer _zBuffer;

        public ObjectDispatcher()
        {
            _polygons = new List<Polygon>();
            _zBuffer = new ZBuffer();
        }

        public void AddPolygons(params Polygon[] polygons)
        {
            _polygons.AddRange(polygons);
        }

        public void Render(Bitmap bitmap)
        {
            _zBuffer.Render(bitmap, _polygons);
        }

        public void ClearPolygons()
        {
            _polygons.Clear();
        }
    }
}