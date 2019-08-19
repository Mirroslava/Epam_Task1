using System;
namespace Epam_TASK1
{
    public class RectangleAutoProp
    {
        public RectangleAutoProp()
        {
        }
        public Point PointLeft { get; set; }
        public Point PointRight { get; set; }
        private int perimetr;
        public int Perimetr { get => (PointLeft.Y + PointRight.X) * 2; set => perimetr = value; }
        private int squere;
        public int Squere { get => (PointLeft.Y * PointLeft.X); set => squere = value; }
        public RectangleAutoProp(Point pointLeft, Point pointRight)
        {
            PointLeft = pointLeft;

            PointRight = pointRight;
        }
    }
}
