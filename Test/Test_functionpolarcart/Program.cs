using System;

namespace Test_functionpolarcart
{
    class Program
    {
        private static double[]  CartToPolar(double x, double y)
        {
            double radius = Math.Sqrt((x * x) + (y * y));
            double alpha;

            if (x > 0 && y > 0)
            {
                alpha = Math.Atan(y/x) * 180 /Math.PI;
            }
            else if (x < 0 || y >= 0)
            {
                alpha = (Math.Atan(y/x) + Math.PI) * 180 / Math.PI;
            }
            else if (x < 0 && y < 0)
            {
                alpha = (Math.Atan(y/x) - Math.PI ) * 180 / Math.PI;
            }
            else if (x > 0 && y < 0)
            {
                alpha = (Math.Atan(y/x) + 2*Math.PI) * 180 / Math.PI; 
            }
            else
            {
                alpha = 0;
            }

            double[] CartToPolar = new double[2] { radius, alpha };

            return CartToPolar;
            
        }
        private static double[] PolarToCart(double radius, double alpha)
        {
            double deg = Math.PI * alpha / 180;

            double x = radius * Math.Cos(deg);
            double y = radius * Math.Sin(deg);
            

            double[] PolarToCart = new double[2] { x, y };

            return PolarToCart;
        }
        private static void ArrayToString(double[] Target)
        {
            foreach (var item in Target)
            {
                Console.WriteLine(Convert.ToString(item));
            }
        }
        private static int alpha(int number)
        {
            int[] TargetNumber = new int[20] { 6, 13, 4, 18, 1, 20, 5, 12, 9, 14, 11, 8, 16, 7, 19, 3, 17, 2, 15, 10 };
            int[] middlealpha = new int[20] { 0, 18, 36, 54, 72, 90, 108, 126, 144, 162, 180, 198, 216, 234, 252, 270, 288, 306, 324, 342 };

            for (int i = 0; i < 19; i++)
            {
                if (number == TargetNumber[i])
                {
                    return middlealpha[i];
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            double RandomRadius = (double)random.NextDouble();
            double RandomAlpha = (double)random.Next(0,10);
            
            double[] EndDistance = new double[2] {0,0};
            for (int i = 0; i < 2; i++)
            {
                EndDistance[i] = PolarToCart(RandomRadius, RandomAlpha)[i] + PolarToCart(55, alpha(15))[i];
            }
            
            ArrayToString(CartToPolar(EndDistance[0], EndDistance[1]));
            
        }
    }
}
