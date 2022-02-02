using System;

namespace Aufgabe_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 8:
            //Benötigt wird ein Programm, das den Benutzer immer wieder auffordert, eine ganze Zahl über die Tastatur einzugeben, bis die eingegebene Zahl 1234 ist. Wenn die PIN richtig eingegeben wurde, soll die Anzahl der falschen Versuche ausgegeben werden.

            //Wählen Sie die passende Schleifenstruktur. Stellen Sie dies in einem PAP dar und erstellen Sie den Quellcode.

            int x = 0;

            int i = -1;

            Console.WriteLine("PIN eingeben: ");
            Convert.ToInt32(Console.ReadLine());

            while (x != 1234)
            {
                i = i + 1;
                Console.WriteLine("PIN ist falsch");
            }
            Console.Write(i);

        }
    }
}
