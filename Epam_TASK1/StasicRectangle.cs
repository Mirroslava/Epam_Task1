using System;
namespace Epam_TASK1
{
    public static class StasicRectangle
    {
        public static int Perimetr(Point pointLeft , Point pointRight)
        {
            return (pointLeft.Y + pointRight.X) * 2;
        }
        public static int Squere(Point pointLeft, Point pointRight)
        {
            return (pointLeft.Y * pointRight.X);
        }
    }
}
