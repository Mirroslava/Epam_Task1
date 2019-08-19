using System;
namespace Epam_TASK1
{
    public static class CircleStatic
    {
   
        public static  double Pi = Math.PI;

     


       
        public static double Area(double radius)
        {
            return Pi * radius * radius;

        }
        public static double Lenght(double radius)
        {
            return 2 * Pi * radius;
        }

    }
}
