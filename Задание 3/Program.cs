using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {

            const double pi = 3.14;
            double r = 15;
            double areaOfCircle = 0;

            areaOfCircle = pi * (Math.Pow(r,2));

            Console.WriteLine(areaOfCircle);

            Console.ReadKey();

        
            
            
        }
    }
}
