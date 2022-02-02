using System;

namespace Aufgabe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 5:
            //Fragen sie den Benutzer nach einer Zahl x und geben Sie alle Zahlen von -x bis x in Zweierschritten nebeneinander aus.
            
            //Wählen Sie die passende Schleifenstruktur. Stellen Sie dies in einem PAP dar und erstellen Sie den Quellcode.

            int x = Convert.ToInt32(Console.ReadLine());

            int i = -x;

            while (i <= x)
            {
                Console.Write(i + "|");
                i += 2;
            }

            //for(int q=-x; q <= x; q+=2)
            //{
            //    Console.WriteLine(q + "|");

            //}
        }
    }
}
