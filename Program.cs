using System;

namespace DartGame
{
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
    }
}
