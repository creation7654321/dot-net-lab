using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Swap
    {
        public void Swapping()
        { int temp = 0;
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number before swapping is {a} and {b}");

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"The number after swapping is {a} and {b}");


        }
    }
}
