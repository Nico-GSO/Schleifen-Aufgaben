using System;

namespace Hotel_Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe;
            bool richtig = false;
            bool richtig2 = false;
            string nachname;
            short zimmernummer;
            short[] zimmernummern = { 45, 23, 3, 32 };
            string[] vornamen = { "John", "Paul", "Geroge", "Ringo" };
            string[] nachnamen = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] übernachtungen = { 1, 4, 12, 3 };
            double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };



            Console.WriteLine("Bitte geben Sie ihren Nachnamen oder ihre Zimmernummer ein:");


            eingabe = Console.ReadLine();
            if (Int16.TryParse(eingabe, out zimmernummer))
            {
                richtig2 = GetData(richtig);
            }



            else
            {


            }





           










        }
        static bool GetData(string nachname, string[] nachnamen, string[] vornamen, short[] übernachtungen, double[] rechnungsbetrag, bool richtig, string eingabe)
        {
            if (eingabe == nachnamen)
            {
                richtig = true;
            }



            else if (eingabe == zimmernummern)
            {
                richtig = true;
            }



            else
            {
                Console.WriteLine("Ihre Eingabe ist falsch.");
                richtig = false;
            }





            return richtig;
        }



        static bool GetData(short zimmernummer, short[] zimmernummern, string[] nachnamen, string[] vornamen, short[] übernachtungen, double[] rechnungsbetrag, bool richtig)
        {

            for (int i = 0; i == zimmernummer; i++)
            {
                if (i == zimmernummer)
                {
                    
                    
                    Console.WriteLine("{0} {1} {2} {3} {4}", zimmernummern[i], vornamen[i], nachnamen[i], übernachtungen[i], rechnungsbetrag[i]);
                }
            }

           




            return richtig;



        }
    }
}
