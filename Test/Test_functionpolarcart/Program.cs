using System;

namespace Test_functionpolarcart
{
    class Program
    {
        private static Tuple<double,double> CartToPolar(double x, double y)
        {
            double radius = Math.Sqrt((x * x) + (y * y));
            double alpha = Math.Atan(y/x);

            try
            {
                return new Tuple<double, double>(radius, alpha);
            }
            catch (Exception)
            {
                return new Tuple<double, double>(radius, alpha);
            }

            
        }
        private static Tuple<double, double> PolarToCart(double radius, double alpha)
        {
            double x = radius * Math.Cos(alpha);
            double y = radius * Math.Sin(alpha);

            try
            {
                return new Tuple<double, double>(x, y);
            }
            catch (Exception)
            {
                return new Tuple<double, double>(x, y);
            }


        }
        static void Main(string[] args)
        {
            double x;
            double y;

            Console.WriteLine(CartToPolar(1, 3));
            Console.WriteLine(PolarToCart(3.1622776601683795, 1.2490457723982544));
        }
    }
}
