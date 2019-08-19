using System;
namespace Epam_TASK1
{
    public class Circle
    {
        private double radius;
        public const double Pi = Math.PI;

        public double Radius { get => radius; set => radius = value; }


        public Circle(double radius)
        {
            this.radius = radius;
        }

        public  double Area()
        {
            return Pi * radius* radius;

        }
        public  double Lenght()
        {
            return 2 * Pi * radius;
        }
       
    }
}
