using System;

namespace Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 3:
            //Geben Sie mit Hilfe einer Schleife die Quadrate der Zahlen 1-10 aus, z.B. mit dem Satz "Das Quadrat von 1 ist 1" usw.

            //Wählen Sie die passende Schleifenstruktur. Stellen Sie dies in einem PAP dar und erstellen Sie den Quellcode.

            int x = 1;
            while(x<=10)
            {
                Console.WriteLine(x * x);
                x = x + 1;
            }
        }
    }
}
