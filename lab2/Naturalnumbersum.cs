using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
     public class Naturalnumbersum
    {
        public void sumofNat()
        {
            Console.WriteLine("Enter a number to find the sum ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;

            }
            Console.WriteLine($"The sum of the natural number is {sum}");
        }
    }
}
