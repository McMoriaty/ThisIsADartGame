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
        private static int alpha(int number)
        {
            int[] TargetNumber = new int[20] { 6, 13, 4, 18, 1, 20, 5, 12, 9, 14, 11, 8, 16, 7, 19, 3, 17, 2, 15, 10 };
            int[] Winkelmitte = new int[20] { 0, 18, 36, 54, 72, 90, 108, 126, 144, 162, 180, 198, 216, 234, 252, 270, 288, 306, 324, 342 };

            for (int i = 0; i < 19; i++)
            {
                if (number == TargetNumber[i])
                {
                    return Winkelmitte[i];
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            double[] XY = new double[2] { 1, 15 };
            double[] RadiusAlpha = new double[2] { 3.1622776601683795, 1.2490457723982544 };

            //ArrayToString(CartToPolar(XY[0], XY[1]));
            //ArrayToString(PolarToCart(RadiusAlpha[0], RadiusAlpha[1]));
            Console.WriteLine(alpha(9));
        }
    }
}
