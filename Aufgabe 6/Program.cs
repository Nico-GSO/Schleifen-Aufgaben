using System;

namespace Aufgabe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 6:
            //Ein Auswahlmenü wird so lange angezeigt, wie der Benutzer nicht den Wert 0 für Beenden eingegeben hat.

            //Wählen Sie die passende Schleifenstruktur. Stellen Sie dies in einem PAP dar und erstellen Sie den Quellcode.

            int eingabe = 0;

            do
            {
                Console.WriteLine("Menü");
                Console.WriteLine("Um das Programm zu beenden müssen sie 0 eingeben.");
                eingabe = Convert.ToInt32(Console.ReadLine());
            } while (eingabe!=0);
        }
    }
}
