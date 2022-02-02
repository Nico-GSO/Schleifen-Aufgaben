using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {


            int x=0;

            int i = -1;

            Console.WriteLine("PIN eingeben: ");
            Convert.ToInt32(Console.ReadLine());

            while (x != 1234)
            {
                i = i + 1;
                Console.WriteLine("PIN ist falsch");
            }




        }
    }
}



