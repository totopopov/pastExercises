using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());

            var days = int.Parse(Console.ReadLine());

            var extrawork = int.Parse(Console.ReadLine());

            var houravailable = 0.0;

            houravailable = days * 0.9*8+ days*2* extrawork;

            

            extrawork = (int)houravailable;

            if (extrawork>=hours)
            {
                Console.WriteLine("Yes!{0} hours left.", extrawork - hours);

            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hours-extrawork);
            }
            
                
            

        }
    }
}
