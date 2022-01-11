using System;

namespace Test_functionpolarcart
{
    class Program
    {
        private static Array CartToPolar(double x, double y)
        {
            double radius = Math.Sqrt((x * x) + (y * y));
            double alpha = Math.Atan(y/x);

            double[] CartToPolar = new double[2] { radius, alpha };

            return CartToPolar;
            
        }
        private static Array PolarToCart(double radius, double alpha)
        {
            double x = radius * Math.Cos(alpha);
            double y = radius * Math.Sin(alpha);

            double[] PolarToCart = new double[2] { x, y };

            return PolarToCart;
        }
        private static void ArrayToString(Array Target)
        {
            foreach (var item in Target)
            {
                Console.WriteLine(Convert.ToString(item));
            }
        }
        static void Main(string[] args)
        {
            double[] XY = new double[2] { 1, 15 };
            double[] RadiusAlpha = new double[2] { 3.1622776601683795, 1.2490457723982544 };

            ArrayToString(CartToPolar(XY[0], XY[1]));
            ArrayToString(PolarToCart(RadiusAlpha[0], RadiusAlpha[1]));

        }
    }
}
