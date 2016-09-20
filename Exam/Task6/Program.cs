using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            var numBer = int.Parse(Console.ReadLine());

            //var help = numBer.ToString().Split();
            var rows = numBer/100 + (numBer / 10 -(numBer / 100)*10 );  
            var col = numBer / 100 + numBer % 10;
            var firstNum = numBer / 100;
            var secondNum = (numBer / 10 - (numBer / 100) * 10);
            var thirdNum= numBer % 10;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (numBer%5==0)
                    {
                        numBer = numBer - firstNum;

                    }
                    else if (numBer % 3 == 0)
                    {
                        numBer = numBer - secondNum;
                    }
                    else
                    {
                        numBer = numBer + thirdNum;
                    }

                    Console.Write(numBer+" ");
                }
                Console.WriteLine();
            }


        }
    }
}
