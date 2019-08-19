using System;

namespace Epam_TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter leftPoints" );
            Point pointLeft; Point pointRight;
            pointLeft.X =Convert.ToInt32(Console.ReadLine());
            pointLeft.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rightPoints");
            pointRight.X = Convert.ToInt32(Console.ReadLine());
            pointRight.Y = Convert.ToInt32(Console.ReadLine());
            Rectangle rectangle1 = new Rectangle(pointLeft, pointRight);
            Console.WriteLine( "P : {0} ,Squre : {1} ",rectangle1.Perimetr(),rectangle1.Squere());
            RectangleAutoProp rectangle2 = new RectangleAutoProp(pointLeft, pointRight);

            Console.WriteLine("P : {0} ,Squre : {1} ", rectangle2.Perimetr, rectangle2.Squere);

            Console.Write("Enter radius of circle : ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle(radius);
            Console.WriteLine("Lenght : {0} ,Squre : {1} ", circle.Lenght(), circle.Area());
            Console.WriteLine("staticCircle area : {0} \n staticCircle lenght : {1}  ", CircleStatic.Area(radius), CircleStatic.Lenght(radius));
            Console.WriteLine("P : {0} ,Squre : {1} ", StasicRectangle.Perimetr(pointLeft , pointRight),
                               StasicRectangle.Squere(pointLeft, pointRight));

        }
    }
}
