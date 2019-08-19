using System;
namespace Epam_TASK1
{
    public class Rectangle
    {

        private Point pointLeft;
        private Point pointRight;

        public Rectangle()
        {
        }
       public Rectangle(Point pointLeft,Point pointRight)
        {
            this.pointLeft = pointLeft;

            this.pointRight = pointRight;
        }
        public int Perimetr ()
        {
            return (pointLeft.Y + pointRight.X) * 2;
        }
        public int Squere()
        {
            return (pointLeft.Y * pointRight.X) ;
        }
    }
}
