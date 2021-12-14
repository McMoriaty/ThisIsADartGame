using System;

namespace ThisIsADartGame_v01
{
    class Program
    {
        static void ConventMultiToRadius(int Radius)
        {
            int[] Feldpositionen = new int[6] { 5, 15, 50, 60, 80, 90 };


            for (int i = 0; i < 5; i++)
            {
                if (Radius < Feldpositionen[i])
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(1);
                }
            }
        }
        static void EingabeZuDaten(int ZielZahl,int Radius, string Multi)
        {
            int[] Feld = new int[20] { 6, 13, 4, 18, 1, 20, 5, 12, 9, 14, 11, 8, 16, 7, 19, 3, 17, 2, 15, 10 };

            // Diese For-Schleife findet die genaue Poitsition des angestrebten Feldes in der Variable Feld heraus.
            for (int i = 0; i < Feld.Length; i++)
            {
                if (Feld[i] == ZielZahl)
                {
                    Console.WriteLine(i+1);
                    i = 20;
                }
            }

        }

        static void Main(string[] args)
        {
            //Abfrage über den Bereich den der Benutzer treffen will.
            Console.WriteLine("Für einen Wurf in das Bulseye drücken sie die 1.");
            Console.WriteLine("Für einen Wurf in das Eye drücken sie die 2.");
            Console.WriteLine("Für einen Wurf in ein Triple Wert drücken sie die 3.");
            Console.WriteLine("Für einen Wurf in das Doubble Wert drücken sie die 4.");
            Console.WriteLine("Für einen Wurf in das Normalen drücken sie die 5.");

            int b = Int32.Parse(Console.ReadLine());
            int Radius = 0;
            int Winkel = 0;
            string Multi = "";
            int ZielZahl = 0;


            if (b == 1)
            {
                Radius = 0;
                Winkel = 0;
            }
            else if (b == 2)
            {
                Radius = 0;

            }
            else
            {
                if (b == 3)
                {
                    Multi = "Triple";

                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    ZielZahl = Int32.Parse(Console.ReadLine());

                }
                else if (b == 4)
                {
                    Multi = "Doubble";

                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    ZielZahl = Int32.Parse(Console.ReadLine());

                }
                else if (b == 5)
                {
                    Multi = "Singel";

                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    ZielZahl = Int32.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Möchten sie mich verarschen.");
                }
            }


            ConventMultiToRadius(Radius);
            EingabeZuDaten(ZielZahl,Radius, Multi);

        }
    }
}
