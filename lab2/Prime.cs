using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Prime
    {
        public void CheckPrime()
        {
            Console.WriteLine("Enter a number");
            int p = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= p; i++)
            {
                if(p % i == 0)
                {
                    count++;
                }
            }
            if(count ==2)
            {
                Console.WriteLine($"The number {p} is prime number");
            }
            else
            {
                Console.WriteLine($"The number {p} is not prime number");
            }
        }

    }
}
