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
            static void EingabeZuDaten(int Radius, string Multi)
            {
                int[] Feld = new int[20] { 6, 13...};
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Für einen Wurf in das Bulseye drücken sie die 1.");
                Console.WriteLine("Für einen Wurf in das Eye drücken sie die 2.");
                Console.WriteLine("Für einen Wurf in ein Triple Wert drücken sie die 3.");
                Console.WriteLine("Für einen Wurf in das Doubble Wert drücken sie die 4.");
                Console.WriteLine("Für einen Wurf in das Normalen drücken sie die 5.");

                int b = Int32.Parse(Console.ReadLine());
                int Radius = 0;
                int Winkel = 0;


                if (b == 1)
                {
                    Radius = 0;
                    Winkel = 0;
                }
                else if (b == 2)
                {
                    Radius = 0;

                }
                else if (b == 3)
                {
                    string Multi = "Triple";

                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    int ZielZahl = Int32.Parse(Console.ReadLine());

                }
                else if (b == 4)
                {
                    string Multi = "Doubble";

                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    int ZielZahl = Int32.Parse(Console.ReadLine());

                }
                else if (b == 5)
                {
                    string Multi = "Singel";

                    Console.WriteLine("Geben sie die Zahl zwischen 1-20 ein welche sie treffen wollen!");
                    int ZielZahl = Int32.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Möchten sie mich verarschen.");
                }


                ConventMultiToRadius(Radius);
            }
        }
    }
