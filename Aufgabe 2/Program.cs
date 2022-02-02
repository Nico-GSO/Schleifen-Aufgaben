using System;

namespace Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 2:
            //Hans soll 50 Mal schreiben: "Ich muss immer meine Hausaufgaben machen".

            //Wählen Sie die passende Schleifenstruktur. Stellen Sie dies in einem PAP dar und erstellen Sie den Quellcode.

            int x = 50;
            do
            {
                Console.WriteLine("Ich muss immer meine Hausaufgaben machen");
                x = x - 1;
            }
            while (x >= 0);
        }
    }
}
