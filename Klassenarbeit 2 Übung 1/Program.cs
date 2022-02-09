using System;

namespace Klassenarbeit_2_Übung_1
{
    class Program
    {
        static bool Main(string[] args)
        {

            double K = 0, K_Zinsen = 0, p = 0;
            int jahre = 0;
            int n = 0;

            Console.WriteLine("Geben Sie ihr Kapital an: ");
            K = Convert.ToDouble(Console.ReadLine());
            K_Zinsen = K;

            Console.WriteLine("Geben Sie ihren Zinssatz an: ");
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben sie ihre Anlagedauer ein: ");
            n = Convert.ToInt32(Console.ReadLine());


            for (n <= 0) 

            {
                n = n - 1;
                K = K + 5%
                jahre++;
            }

            Console.WriteLine("Es dauert etwa {0} Jahre um das Kapital zu verdoppeln", jahre);

        }
    }
}



