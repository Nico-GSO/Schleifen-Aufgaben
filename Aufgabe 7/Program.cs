using System;

namespace Aufgabe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 7:
            //Schreiben Sie ein Programm, dass zu einer Zahl n jeweils die Summe der Zahlen von 0 bis n ausgibt.

            //Wählen Sie die passende Schleifenstruktur. Stellen Sie dies in einem PAP dar und erstellen Sie den Quellcode.

            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int summe = 0;


            for(int i =0; i<=n;i++)
            {
                summe = summe + i;
                Console.WriteLine(summe);
            }
        }
    }
}
