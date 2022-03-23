using System;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl = 5;

            double y = ZahlenQuadrat(zahl);

        }

        static double ZahlenQuadrat(double x)
        {

            double y = x * x;
            return y;
        }
    }
}
