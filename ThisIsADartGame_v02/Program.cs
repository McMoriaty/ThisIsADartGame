using System;

namespace ThisIsADartGame_v02
{
    class Program
    {
        public class DartGame 
        {
            public override string Name => "Dart";
            public override string Description => "In diesem Spiel geht es um Dart. Sie dürfen einen Pfeil werfen und je nach Anzahl Punkten wird Ihnen Punkte vom Startwert abgezogen.  Ziel dieses Spiel ist es 0 Punkte zu erreichen. Wenn Sie 0 Punkte unterschreiten bekommen sie eine kleine Strafe und das Spiel ist beendet. Je weniger Würfe sie gebraucht haben, desto besser haben Sie abgeschnitten. ";
            public override string Rules => "Sie werfen einen Pfeil auf ein bestimmtes Feld, mit gewisser Wahrscheinlichkeit treffen sie genau dieses Feld oder in einem Kreisförmigen Umfeld ein anderes Feld. Diese Punkte werden Ihnen vom Startwert (501 Punkte) abgezogen. Sie spielen solange bis Sie einen Wert erreichen der kleiner  oder gleich 0 ist. Wenn sie es schaffen 0 Punkte genau zu erreichen ist Ihr Endergebnis gleich der Anzahl Pfeile die Sie geworfen haben, und das Spiel ist beendet. Wenn sie 0 Punkte unterschreiten bekommen Sie 2 mal die Punkte welche Sie unter 0 geworfen haben zu den Anzahl Würfen dazu addiert, und somit ist das Spiel auch hier beendet.";
            public override bool TheHigherTheBetter => false;
            public override int LevelMax => 1;
        }
        private static double[] CartToPolar(double x, double y) // Calculates cartesan Coordiantes to polar Cordinates
        {
            double radius = Math.Sqrt((x * x) + (y * y));
            double alpha;

            if (x > 0 && y > 0)
            {
                alpha = Math.Atan(y / x) * 180 / Math.PI;
            }
            else if (x < 0 || y >= 0)
            {
                alpha = (Math.Atan(y / x) + Math.PI) * 180 / Math.PI;
            }
            else if (x < 0 && y < 0)
            {
                alpha = (Math.Atan(y / x) - Math.PI) * 180 / Math.PI;
            }
            else if (x > 0 && y < 0)
            {
                alpha = (Math.Atan(y / x) + 2 * Math.PI) * 180 / Math.PI;
            }
            else
            {
                alpha = 0;
            }

            double[] CartToPolar = new double[2] { radius, alpha };

            return CartToPolar;

        }
        private static double[] PolarToCart(double radius, double alpha) // Calculates polar Coordiantes to cartesan  Cordinates
        {
            double deg = Math.PI * alpha / 180;

            double x = radius * Math.Cos(deg);
            double y = radius * Math.Sin(deg);


            double[] PolarToCart = new double[2] { x, y };

            return PolarToCart;
        }
 
        private static int TargetNumberToAlpha(int number) // function to find out the degree of the Target Number
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

        private static int AlphaToTargetNumber(double alpha) // function to find out the Number of the degree
        {
            int[] TargetNumber = new int[20] { 6, 13, 4, 18, 1, 20, 5, 12, 9, 14, 11, 8, 16, 7, 19, 3, 17, 2, 15, 10 };
            int[] MiddleAlpha = new int[20] { 9, 18, 36, 54, 72, 90, 108, 126, 144, 162, 180, 198, 216, 234, 252, 270, 288, 306, 333, 361 };

            for (int i = 0; i < 19; i++)
            {
                if (alpha <= MiddleAlpha[i])
                {
                    return TargetNumber[i];
                }
            }
            return 0;
        }

        private static double[] GetFinalNumber(double Radius, int Number)
        {
            Random random = new Random();
            double RandomRadius = (double)random.Next(0,20);
            double RandomAlpha = (double)random.Next(0, 360);

            double[] EndDistance = new double[2] { 0, 0 };
            double[] EndResult = new double[2] { 0, 0 };
            for (int i = 0; i < 2; i++)
            {
                EndDistance[i] = PolarToCart(RandomRadius, RandomAlpha)[i] + PolarToCart(Radius, TargetNumberToAlpha(Number))[i];
            }

            for (int i = 0; i < 2; i++)
            {
                EndResult[i] = CartToPolar(EndDistance[0], EndDistance[1])[i];
            }
            EndResult[1] = AlphaToTargetNumber(EndResult[1]);

            return EndResult;
        }
        private static void play() //main game loop
        {
            int Score = 501;
            int Counter = 0;
            Random random = new Random();
            while (Score > 0)
            {
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
                Console.WriteLine("Für einen Wurf in das Bulseye drücken sie die 1.");
                Console.WriteLine("Für einen Wurf in das Eye drücken sie die 2.");
                Console.WriteLine("Für einen Wurf in ein Triple Wert drücken sie die 3.");
                Console.WriteLine("Für einen Wurf in das Doubble Wert drücken sie die 4.");
                Console.WriteLine("Für einen Wurf in das Normalen drücken sie die 5.");

                int TargetRingNumber = Int32.Parse(Console.ReadLine());
                int Radius = 0;

                int RadiusBullsEye = 5;
                int RadiusEye = 10;
                int RadiusTriple = 55;
                int RadiusDouble = 85;
                int RadiusNormalOne = 70;
                int RadiusNormalTow = 38;

                if (TargetRingNumber == 1)
                {
                    double[] FinalNumber = GetFinalNumber(Radius, random.Next(0, 360));
                    if (FinalNumber[0] <= RadiusBullsEye)
                    {
                        Score -= 50;
                        Console.WriteLine("Gratulation du hast das Bulls-EYE getroffen.");
                    }
                    else if (FinalNumber[0] <= RadiusBullsEye)
                    {
                        Score -= 25;
                        Console.WriteLine("Gratulation du hast das EYE getroffen.");
                    }
                    else
                    {
                        Score -= Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + FinalNumber[1] + " getroffen.");
                    }
                }
                else if (TargetRingNumber == 2)
                {
                    double[] FinalNumber = GetFinalNumber(Radius, random.Next(0, 360));
                    if (FinalNumber[0] <= RadiusBullsEye)
                    {
                        Score -= 50;
                        Console.WriteLine("Gratulation du hast das Bulls-EYE getroffen.");
                    }
                    else if (FinalNumber[0] <= RadiusEye)
                    {
                        Score -= 25;
                        Console.WriteLine("Gratulation du hast das EYE getroffen.");
                    }
                    else if (FinalNumber[0] <= RadiusNormalTow)
                    {
                        Score -= Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + FinalNumber[1] + " getroffen.");
                    }
                    else
                    {
                        Score -= 3 * Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + FinalNumber[1] + " tripple getroffen.");
                    }
                }

                else if (TargetRingNumber == 3)
                {
                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    int Number = Int32.Parse(Console.ReadLine());
                    Radius = RadiusEye;

                    double[] FinalNumber = GetFinalNumber(Radius, Number);
                    if (FinalNumber[0] <= RadiusBullsEye)
                    {
                        Score -= 50;
                        Console.WriteLine("Gratulation du hast das Bulls-EYE getroffen.");
                    }
                    else if (FinalNumber[0] <= RadiusEye)
                    {
                        Score -= 25;
                        Console.WriteLine("Gratulation du hast das EYE getroffen.");
                    }
                    else if (FinalNumber[0] <= RadiusNormalTow)
                    {
                        Score -= Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + FinalNumber[1] + " getroffen.");
                    }
                    else if (FinalNumber[0] <= RadiusTriple)
                    {
                        Score -= 3 * Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + 3 * FinalNumber[1] + " getroffen.");
                    }
                    else
                    {
                        Score -= Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + FinalNumber[1] + " getroffen.");
                    }
                }
                else if (TargetRingNumber == 4)
                {
                    Radius = RadiusNormalTow;
                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    int Number = Int32.Parse(Console.ReadLine());

                    double[] FinalNumber = GetFinalNumber(Radius, Number);
                    if (FinalNumber[0] <= RadiusBullsEye)
                    {
                        Score -= 50;
                        Console.WriteLine("Gratulation du hast das Bulls-EYE getroffen.");
                    }
                    else if (FinalNumber[0] <= RadiusEye)
                    {
                        Score -= 25;
                        Console.WriteLine("Gratulation du hast das EYE getroffen.");
                    }
                    else if (FinalNumber[0] <= RadiusNormalTow)
                    {
                        Score -= Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + FinalNumber[1] + " getroffen.");
                    }
                    else if (FinalNumber[0] <= RadiusTriple)
                    {
                        Score -= 3 * Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + 3 * FinalNumber[1] + " tripple getroffen.");
                    }
                    else if (FinalNumber[0] <= RadiusNormalOne)
                    {
                        Score -= Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + FinalNumber[1] + " getroffen.");
                    }
                    else
                    {
                        Console.WriteLine(FinalNumber[1]);
                        Score -= 2 * Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + 2 * FinalNumber[1] + " double getroffen.");
                    }
                }
                else if (TargetRingNumber == 5)
                {
                    Radius = RadiusNormalOne;
                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    int Number = Int32.Parse(Console.ReadLine());

                    double[] FinalNumber = GetFinalNumber(Radius, Number);
                    if (FinalNumber[0] <= RadiusBullsEye)
                    {
                        Score -= 50;
                        Console.WriteLine("Gratulation du hast das Bulls-EYE getroffen.");
                        Console.WriteLine("Dein Score ist " + Score);
                    }
                    else if (FinalNumber[0] <= RadiusEye)
                    {
                        Score -= 25;
                        Console.WriteLine("Gratulation du hast das EYE getroffen.");
                        Console.WriteLine("Dein Score ist " + Score);
                    }
                    else if (FinalNumber[0] <= RadiusNormalTow)
                    {
                        Score -= Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + FinalNumber[1] + " getroffen.");
                        Console.WriteLine("Dein Score ist " + Score);
                    }
                    else if (FinalNumber[0] <= RadiusTriple)
                    {
                        Score -= 3 * Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + 3 * FinalNumber[1] + " tripple getroffen.");
                        Console.WriteLine("Dein Score ist " + Score);
                    }
                    else if (FinalNumber[0] <= RadiusNormalOne)
                    {
                        Score -= Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + FinalNumber[1] + " getroffen.");
                    }
                    else if (FinalNumber[0] <= RadiusDouble)
                    {
                        Score -= 2*Convert.ToInt32(FinalNumber[1]);
                        Console.WriteLine("Gratulation du hast das Nr " + 2*FinalNumber[1] + " getroffen.");
                    }
                    else
                    {
                        Console.WriteLine("Du hast nicht getroffen");                     
                    }
                }
                else
                {
                    Console.WriteLine("Möchten sie mich verarschen.");
                }

                Counter += 1;

                Console.WriteLine("Anzahl deiner Schüsse" + " " +Counter);
                Console.WriteLine("Dein Score ist " + Score);
                
            }
            Console.WriteLine("Deine Punkte (desto tiefer desto besser ;) )");

            if (Score < 0)
            {
                Console.WriteLine(Counter + 10);
            }
            else
            {
                Console.WriteLine(Counter);
            }
        }

        static void Main(string[] args)
        {
            play();
        }
    }
}
