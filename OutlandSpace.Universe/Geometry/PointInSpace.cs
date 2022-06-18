using System;

namespace OutlandSpace.Universe.Geometry
{
    [Serializable]
    public class PointInSpace
    {
        public readonly double X;

        public readonly double Y;
        
        public PointInSpace(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool IsEqualTo(PointInSpace point)
        {
            return (Math.Abs(point.X - X) < 0.001 && Math.Abs(point.Y - Y) < 0.001);
        }
    }
}
