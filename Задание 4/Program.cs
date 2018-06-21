using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double R = 12.25;
            double h = 10.12;
            double V = 0;
            double S = 0;

            V = pi * (Math.Pow(R,2)) * h;

            Console.Write("Объем цилиндра равен ");
            Console.WriteLine(V);

            S =  2 * pi * (Math.Pow(R, 2)) * (R + h);

            Console.Write("Площадь цилиндра равна ");
            Console.WriteLine(S);


            Console.ReadKey();
               
        
        }
    }
}
