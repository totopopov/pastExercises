using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var doctors = 7;         
            var trpatients = 0;
            var untrpatients = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i%3==0 && untrpatients>trpatients)
                {
                    doctors++;
                }
                var patients = int.Parse(Console.ReadLine());

                if (doctors>=patients)
                {
                    trpatients += patients;
                }
                else
                {
                    trpatients += doctors;
                    untrpatients = untrpatients+(patients - doctors);
                }
            }


            Console.WriteLine("Treated patients: {0}.",trpatients);
            Console.WriteLine("Untreated patients: {0}.", untrpatients);

        }
    }
}
