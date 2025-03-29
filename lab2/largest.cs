using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Largest
    {
        public void largest(int a, int b , int c)
        {
            if(a > b && a > c)
            {
                Console.WriteLine($"Largest number is {a}");
            }
            else if(b > c)
            {
                Console.WriteLine($"Largest number is {b}");
            }
            else
            {
                Console.WriteLine($"Largest number is {c}");
            }
        }
    }
}
