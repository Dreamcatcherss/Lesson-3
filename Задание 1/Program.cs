using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            int sum = 0;

            sum = x += y - x++ * z;

            Console.WriteLine(sum);

            sum = z = x-- - y * 5;

            Console.WriteLine(sum);

            sum = y /= x + 5 % z;

            Console.WriteLine(sum);

            sum = z = x++ + y * 5;

            Console.WriteLine(sum);

            sum = x = y - x++ * z;

            Console.WriteLine(sum);
          

            Console.ReadKey();
            

        }
    }
}
