using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string('-', size * 3) + "*"+ new string('-', i-1)
                    + "*"+ new string('-', 2 * size - 1 - i));
            }
            for (int i = 1; i <= size / 2; i++)
            {
                Console.WriteLine(new string('*', size * 3 + 1) + new string('-', size - 1)
                    + "*" + new string('-', size - 1));
            }
            for (int i = 0; i < size / 2; i++)
            {
                //var help=((i == size - 1)):
                Console.WriteLine(new string('-', size * 3 -i) + "*" 
                    + new string(((i== size / 2-1) ? '*' : '-'), size - 1+2*i) 
                    + "*" + new string('-', size - 1-i));
            }
        }
    }
}
