using System;

namespace Methoden_implementieren_und_aufrufen
{
    class Program
    {
        static void Main(string[] args)
        {
            int durchlauf = 0;
            string text;


            bool richtig = true;
            do
            {
                richtig = true;
                Console.WriteLine("Geben sie bitte die Anzahl der Durchläufe ein:");
                durchlauf = Convert.ToInt32(Console.ReadLine());
                if (durchlauf < 1 | durchlauf > 1000 )
                {
                    richtig = false;
                    Console.WriteLine("Bitte geben sie eine gültige Eingabe ein. Bitte drücken sie eine beliebige Taste um es erneut zu versuchen:");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (richtig == false);



            bool richtig2 = true;
            do
            {
                richtig2 = true;
                Console.WriteLine("Geben sie bitte ihren Text ein:");
                text = Console.ReadLine();
                if (durchlauf < 1 | durchlauf > 1000)
                {
                    richtig2 = false;
                    Console.WriteLine("Bitte geben sie eine gültige Eingabe ein. Bitte drücken sie eine beliebige Taste um es erneut zu versuchen:");
                    Console.ReadKey();
                    Console.Clear();
                }


            } while (richtig2 == false);



            int anzahl = 0;
            anzahl = ausgabeTextMalX(durchlauf, text);

            Console.Write("\nAnzahl der Buchstaben: {0}", anzahl);

        }

        static int ausgabeTextMalX(int durchlauf,string text)
        {

            for (int i = 0; i < durchlauf ; i++)
            {
                Console.WriteLine(text);
            }

            Console.WriteLine();

            return text.Length*durchlauf;



        }

        
    }
}
