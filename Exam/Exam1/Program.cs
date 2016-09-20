using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            var workdays = int.Parse(Console.ReadLine());

            var money = double.Parse(Console.ReadLine());

            var kurs = double.Parse(Console.ReadLine());



            Console.WriteLine("{0:f2}",(workdays*money*14.5*0.75*kurs)/365); //
 
Conflict resolved, peace is restored. now world war 3. Tradegy avoided. branch testing.
        }
    }
}
