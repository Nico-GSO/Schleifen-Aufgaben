using System;

namespace Klassenarbeit_2_Übung_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double K = 0;
            double Zinssatz = 0;
            int jahre = 0;
            double Bilanz = 0;
            double Zinsen = 0;
            double K_Zinsen = 0;



            Console.WriteLine("Geben Sie ihr Kapital an: ");
            K = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Geben Sie ihren Zinssatz an: ");
            Zinssatz = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Geben sie ihre Anlagedauer ein: ");
            jahre = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine($"{"Jahr",4} {"Guthaben",10} {"Zinsen",8} {"K.Zinsen",10} {"Bilanz",8}");





            for (int i = 1; i <= 45; i++)



            {
                Console.Write("-");
            }
            Console.WriteLine();





            for (int i = 1; i <= jahre; i++)



            {
                Zinsen = K * (Zinssatz / 100);
                Bilanz = K + Zinsen;
                K_Zinsen = K_Zinsen + Zinsen;



                Console.WriteLine($"{i,4} {K,10:F2} {Zinsen,8:F2} {K_Zinsen,10:F2} {Bilanz,8:F2}");



                K = K + Zinsen;


                if (i == jahre - 1)
                {
                    Console.WriteLine("---------------------------------------------");
                }


                //2. Lösungsart
                //while (i == jahre - 1)
                //{
                //    Console.WriteLine("---------------------------------------------");
                //    break;
                //}

            }
        }
    }
}



