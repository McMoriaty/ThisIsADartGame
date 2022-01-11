using System;

namespace DartGame
{
    public class DartGame 
    {
        public override string Name => "Dart";
        public override string Description => "In diesem Spiel geht es um Dart. Sie dürfen einen Pfeil werfen und je nach Anzahl Punkten wird Ihnen Punkte vom Startwert abgezogen.  Ziel dieses Spiel ist es 0 Punkte zu erreichen. Wenn Sie 0 Punkte unterschreiten bekommen sie eine kleine Strafe und das Spiel ist beendet. Je weniger Würfe sie gebraucht haben, desto besser haben Sie abgeschnitten. ";
        public override string Rules => "Sie werfen einen Pfeil auf ein bestimmtes Feld, mit gewisser Wahrscheinlichkeit treffen sie genau dieses Feld oder in einem Kreisförmigen Umfeld ein anderes Feld. Diese Punkte werden Ihnen vom Startwert (501 Punkte) abgezogen. Sie spielen solange bis Sie einen Wert erreichen der kleiner  oder gleich 0 ist. Wenn sie es schaffen 0 Punkte genau zu erreichen ist Ihr Endergebnis gleich der Anzahl Pfeile die Sie geworfen haben, und das Spiel ist beendet. Wenn sie 0 Punkte unterschreiten bekommen Sie 2 mal die Punkte welche Sie unter 0 geworfen haben zu den Anzahl Würfen dazu addiert, und somit ist das Spiel auch hier beendet.";
        public override bool TheHigherTheBetter => false;
        public override int LevelMax => 1;
    }
    class Program
    {
        private int ZielZahlInWinkel(int Zielzahl)
        {
            int[] ScheibenZahl = new int[20] { 6, 13, 4, 18, 1, 20, 5, 12, 9, 14, 11, 8, 16, 7, 19, 3, 17, 2, 15, 10 };
            int[] Winkelmitte = new int[20] { 0, 18, 36, 54, 72, 90, 108, 126, 144, 162, 180, 198, 216, 234, 252, 270, 288, 306, 324, 342 };
            int aby;
            for (int i = 0; i < 19; i++)
            {
                if (Zielzahl == ScheibenZahl[i])
                {



                    i = aby;


                }
            }
            return aby;
        }


        private static Array Genauigkeit(int Radius, int Winkel, int Promille)
        {
            Random WinkelKorrektur = new Random();
            int WinkelKorrekturAnwendung = WinkelKorrektur.Next(0, 15);
            Winkel = Winkel + WinkelKorrekturAnwendung + WinkelKorrekturAnwendung * Promille;



            Random RadiusKorrektur = new Random();
            int RadiusKorrekturAnwendung = RadiusKorrektur.Next(0, 20);
            Radius = Radius + RadiusKorrekturAnwendung + RadiusKorrekturAnwendung * Promille;



            int[] WinkelRadius = new int[2] { Winkel, Radius };
            Console.WriteLine(Radius);
            Console.WriteLine(Winkel);
            return WinkelRadius;
        }

        
        static void Main(string[] args)
        {
            int Score = 501;
            int Counter = 0;
            while (Counter>0)
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
                    int ZielZahl = Int32.Parse(Console.ReadLine());
                    Radius = 55;

                }
                else if (b == 4)
                {
                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    int ZielZahl = Int32.Parse(Console.ReadLine());

                    Radius = 85;
                }
                else if (b == 5)
                {
                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    int ZielZahl = Int32.Parse(Console.ReadLine());

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


                    Console.WriteLine("Wie viel Shots haben Sie intus");
                    Promille = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(Genauigkeit(Radius, Winkel, Promille));

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

