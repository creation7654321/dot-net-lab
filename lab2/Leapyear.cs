using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Leapyear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter the year to check leap year ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                
                Console.WriteLine($"The entered year {year} is leap year");
            }
            else
            {
                Console.WriteLine($"The entered year {year} is not a leap year");
            }

        }
    }
}
