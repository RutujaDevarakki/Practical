using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{

    public class TestPractical
    {
        public void Calculateage()
        {
                  
            int year;
            
            Console.WriteLine("Input the Birth Year of the candidate : ");
            year = Convert.ToInt32(Console.ReadLine());
            if (year <= 0 )
            {
                Console.WriteLine("the voting eligibility year will 0.");
            }
            else
            {
                int currentyear = 2022;
                int age = currentyear - year;
                if (age >= 18)
                {
                    Console.WriteLine("Year of voting will be 2022");

                }
                else
                {
                    Console.WriteLine("Year of voting will be {0}" , year+18);
                }
            }

        }

    }
}

