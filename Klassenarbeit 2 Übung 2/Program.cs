using System;

namespace Klassenarbeit_2_Übung_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1:

            //Zeile 9:  Die Konsole gibt aus "Bitte geben Sie die Anzahl der Durchläufe an".

            //Zeile 10: Benutzer wird aufgefordert die Anzahl der Durchläufe einzugeben (es wird auf eine Eingabe durch den Benutzer gewartet).

            //Zeile 12: Schleifenkopf. Zeile 14 wird so oft wiederholt bis der Zähler "i" die vom Benutzer angegebene Anzahl an Durchläufen überschreitet.

            //Zeile 14: Die Konsole gibt den Text "Durchlauf: " aus und gibt dahinter zusätzlich den Wert der Variable i an. Der Wert der Variable wird 10 Leerstellen nach rechts verschoben ausgegeben.




            //Aufgabe 2:

            for (int kk = 4; kk >= -4; kk = kk - 2) 
            {
                Console.Write(kk);
            }

            //Ausgabe: "420-2-4"




            for (short zaehler = 50; zaehler <= 100; zaehler -= -10) 
            {
                Console.WriteLine(zaehler);
            }

            //Ausgabe: 50
            //         60
            //         70
            //         80
            //         90
            //         100  



            double zahl = 1;
            do 
            {
                Console.WriteLine(zahl);
                zahl = zahl + 1.5; 
            }
            while (zahl < 6);

            //Ausgabe: 1
            //         2.5
            //         4
            //         5.5





            //Aufgabe 3

            double Schritt = 0;
            double Kabellänge = 0;

            Console.WriteLine("Bitte geben sie eine Schrittgröße:");
            Schritt= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben sie einen letzen Abstand:");
            Kabellänge = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{"Meter", 7}{"Widerstand", 14}");

            for (double i = Schritt; i <= Kabellänge + 0.00000001; i+= Schritt)
            {
                double Widerstand = 0.017 * (i / 0.068);
                Console.WriteLine($"{i,6:F2}m{Widerstand,11:F2}Ohm");
            }




            //Aufgabe 4:

            int Alter = 0;

            Console.WriteLine("Geben sie bitte Ihr Alter ein:");
            Alter = Convert.ToInt16(Console.ReadLine());


            while (Alter <= 0 || Alter >= 120)
            {
                Console.WriteLine("Bitte tätigen Sie eine gültige Eingabe an.");
                Alter = Convert.ToInt16(Console.ReadLine());
            }

            if (Alter < 18)
                Console.WriteLine("Download verweigert. Der Download steht nur volljährigen Personen zur Verfügung.");

            else
                Console.WriteLine("Download wird gestartet.");




            //Aufgabe 5:

            int Alter2 = 0;

            Console.WriteLine("Bitte geben sie die Anzahl der Jahre ihrer Firmenzugehörigkeit ein:");
            Alter2 = Convert.ToInt16(Console.ReadLine());

            while (Alter2 == 0)
            {
                Console.WriteLine("Bitte geben sie die Anzahl der Jahre ihrer Firmenzugehörigkeit ein:");
                Alter2 = Convert.ToInt16(Console.ReadLine());
            }

            if (Alter2 == 20)
                Console.WriteLine("Herzlichen Glückwunsch zum 20-jährigen Dienstjubiläum.");

            if (Alter2 == 40)
                Console.WriteLine("Herzlichen Dank für 40 Jahre Energie, Einsatz und Teamgeist.");
        }
    }
}
