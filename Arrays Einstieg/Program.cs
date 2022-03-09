using System;

namespace Arrays_Einstieg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] noten = new int[n];

            Console.WriteLine("Geben sie bitte {0} Noten ein um den Notendurchschnitt zu berechnen:", n);

            double Summe = 0;

            for (int i = 0; i <= noten.Length - 1; i++)
            {
                Console.WriteLine("Geben Sie die {0} Note ein",i+1);
                noten[i] = Convert.ToInt32(Console.ReadLine());
                Summe = Summe + noten[i];
            }

            Console.WriteLine("------------------------------------------------------");
            Console.Write("Der Notendurchschnitt lautet: ");

            Summe = Summe / noten.Length;

            Console.WriteLine(Summe);
        }
    }
}
