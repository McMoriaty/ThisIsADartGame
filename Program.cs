﻿using System;

namespace DartGame
{
    class Program
    {
        private static int alpha(int Number)
        {
            int[] TargetNumber = new int[20] { 6, 13, 4, 18, 1, 20, 5, 12, 9, 14, 11, 8, 16, 7, 19, 3, 17, 2, 15, 10 };
            int[] middlealpha = new int[20] { 0, 18, 36, 54, 72, 90, 108, 126, 144, 162, 180, 198, 216, 234, 252, 270, 288, 306, 324, 342 };

            for (int i = 0; i < 19; i++)
            {
                if (Number == TargetNumber[i])
                {
                    return middlealpha[i];
                }
            }
            return 0;
        }
        private static Array CartToPolar(double x, double y)
        {
            double radius = Math.Sqrt((x * x) + (y * y));
            double alpha = Math.Atan(y / x);

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

        static void Main(string[] args)
        {
            int Score = 501;
            int Counter = 0;
            while (Score>0)
            {

                Console.WriteLine("Für einen Wurf in das Bulseye drücken sie die 1.");
                Console.WriteLine("Für einen Wurf in das Eye drücken sie die 2.");
                Console.WriteLine("Für einen Wurf in ein Triple Wert drücken sie die 3.");
                Console.WriteLine("Für einen Wurf in das Doubble Wert drücken sie die 4.");
                Console.WriteLine("Für einen Wurf in das Normalen drücken sie die 5.");

                int b = Int32.Parse(Console.ReadLine());

                string Multi;
                int Radius = 0;
                int Winkel = 0;
                int Promille;

                if (b == 1)
                {
                    Radius = 0;
                    Winkel = 0;
                }
                else if (b == 2)
                {
                    Radius = 10;

                }
                else if (b == 3)
                {
                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    int Number = Int32.Parse(Console.ReadLine());
                    Radius = 55;
                    Random random = new Random();
                    double RandomRadius = (double)random.NextDouble();
                    double RandomAlpha = (double)random.Next(0,360);

                    Console.WriteLine(PolarToCart(Radius, alpha(Number)));
                    PolarToCart(RandomRadius,RandomAlpha);

                }
                else if (b == 4)
                {
                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    int Number = Int32.Parse(Console.ReadLine());

                    Radius = 85;
                }
                else if (b == 5)
                {
                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    int Number = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Möchten Sie in das grössere/äussere Singel Feld schiessen, dann drücken sie 1. Wenn sie jedoch das kleinere/innere treffen wollen drücken Sie 2.");
                    int GrossKleinFeld = Int32.Parse(Console.ReadLine());
                    if (GrossKleinFeld == 1)
                    {
                        Radius = 70;
                    }
                    else if (GrossKleinFeld == 2)
                    {
                        Radius = 38;
                    }   

                }
                else
                {
                    Console.WriteLine("Möchten sie mich verarschen.");
                }
            }
            if (Score==0)
            {
                Console.WriteLine("Dein Ergebniss ist "+Counter);
            }
            else if (Score<0)
            {
                Counter = Counter + 2 *(Score * -1);
                Console.WriteLine("Dein Ergebniss ist " + Counter);
            }
            Console.WriteLine(@"                         __.__                         ");
            Console.WriteLine(@"                    ____/     \____                    ");
            Console.WriteLine(@"                ___/      20       \___                ");
            Console.WriteLine(@"             __/       5       1       \__             ");
            Console.WriteLine(@"          __/   12                  18    \__          ");
            Console.WriteLine(@"         /                                   \         ");
            Console.WriteLine(@"      __/  9                              4   \__      ");
            Console.WriteLine(@"    _/                                           \_    ");
            Console.WriteLine(@"   /   14                                    13    \   ");
            Console.WriteLine(@"  /                        \ /                      \  ");
            Console.WriteLine(@" {  11                      X                     6  } ");
            Console.WriteLine(@"  \                        / \                      /  ");
            Console.WriteLine(@"   \_  8                                      10  _/   ");
            Console.WriteLine(@"     \__                                       __/     ");
            Console.WriteLine(@"        \   16                           15   /        ");
            Console.WriteLine(@"         \__                               __/         ");
            Console.WriteLine(@"            \__  7                   2  __/            ");
            Console.WriteLine(@"               \___  19         17  ___/               ");
            Console.WriteLine(@"                   \____   3   ____/                   ");
            Console.WriteLine(@"                        \__.__/                        ");
        }
    }
}

