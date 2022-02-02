using System;

namespace Aufgabe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 4:
            //Zählen Sie mit einer Schleife von 100 bis 10 in Zehnerschritten und geben Sie die Zahlen nebeneinander aus.

            //Wählen Sie die passende Schleifenstruktur. Stellen Sie dies in einem PAP dar und erstellen Sie den Quellcode.

            int x = 100;
            while(x>=10)
            {
                Console.Write(x);
                x = x - 10;
            }
        }
    }
}
