using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();

            var nights = int.Parse(Console.ReadLine());

            var studio = 0.0;

            var apartament = 0.0;




            switch (month)
            {

                case "May":
                case "October":
                    if (nights>7 && nights <= 14)
                    {
                        studio = 50-0.05*50;
                    }
                    else if (nights > 14)
                    {
                        studio = 50 - 0.3 * 50;
                    }
                    else
                    {
                        studio = 50;
                    }
                    
                    if (nights > 14)
                    {
                        apartament = 65-65*0.1;
                    }
                    else
                    {
                        apartament = 65;
                    }
                   
                    break;
                case "June":
                case "September":
                    if (nights > 14)
                    {
                        studio = 75.2 - 0.2 * 75.2;
                    }
                    else 
                    {
                        studio = 75.2;
                    }

                    if (nights > 14)
                    {
                        apartament = 68.7 - 68.7 * 0.1;
                    }
                    else
                    {
                        apartament = 68.7;
                    }
    
                    break;
                case "July":
                case "August":
                    studio = 76;


                    if (nights > 14)
                    {
                        apartament = 77 - 77 * 0.1;
                    }
                    else
                    {
                        apartament = 77; 
                    }



                    
                    break;

                default:
                    break;
            }

            Console.WriteLine("Apartment: {0:f2} lv.",apartament*nights);
            Console.WriteLine("Studio: {0:f2} lv.",studio*nights);

        }
    }
}
