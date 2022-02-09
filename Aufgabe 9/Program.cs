using System;

namespace Aufgabe_9
{
    class Program
    {
        static void Main(string[] args)
        {



            double K = 0;
            double Zinssatz = 0;
            int n = 0;
            double Bilanz;
            double Zinsen;
            double K_Zinsen;

            Console.WriteLine("Geben Sie ihr Kapital an: ");
            K = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie ihren Zinssatz an: ");
            Zinssatz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben sie ihre Anlagedauer ein: ");
            n = Convert.ToInt32(Console.ReadLine());

            string sHöhe = "Höhe", sBreite = "Breite";
            float fHöhe = 32.346F, fBreite = 15.193F;

            Console.WriteLine("{0,10}{1,10}\n", sHöhe, sBreite);
            Console.WriteLine("{0,10:F1}{1,10:F1}", fHöhe, fBreite);



            for (int i=1; i<=n ;i++ )

            {
                
                Zinsen = K * (Zinssatz / 100);
                Bilanz = K + Zinsen;
                K_Zinsen
            }


        }
    }
}
