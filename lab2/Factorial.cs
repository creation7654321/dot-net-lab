using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Factorial
    {
        public void Fact()
        {
            Console.WriteLine("Enter the number to find factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            if(num < 0)
            {
                Console.WriteLine("Factorial is not defined for number less than 0");
            }
            else
            {
                for(int i = 1; i <= num; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine($"The factorial of {num} is {fact}");
            }


        }
    }
}
