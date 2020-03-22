using System.Diagnostics;

namespace lab4
{
    public static class CohenSutherland
    {
        public static Line CreateClippedLine(Line line, Frame frame)
        {
            var codeA = frame.GetCode(line.A);
            var codeB = frame.GetCode(line.B);

            if (codeA == 0 && codeB == 0)
                return line;

            if ((codeA & codeB) != 0)
                return null;

            if (codeA == 0)
            {
                var newB = line.GetIntersection(frame, line.B);
                if (newB.HasValue)
                    return CreateClippedLine(new Line(line.A.X, line.A.Y, newB.Value.X, newB.Value.Y), frame);
            }
            else
            {
                var newA = line.GetIntersection(frame, line.A);
                if (newA.HasValue)
                    return CreateClippedLine(new Line(newA.Value.X, newA.Value.Y, line.B.X, line.B.Y), frame);
            }

            return null;
        }
    }
}