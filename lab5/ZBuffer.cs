using System;

namespace lab5
{
    public class ZBuffer
    {
        public float[,] Buffer;

        public ZBuffer()
        {
            Buffer = new float[360, 360];
        }
    }
}