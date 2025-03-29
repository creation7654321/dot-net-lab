using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Arraysum
    {  
        public void sum_of_array()
        {
            Console.WriteLine("Enter the size of your array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[size];
            int sumofarray = 0;
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the {i + 1} element");
                number[i] = Convert.ToInt32( Console.ReadLine() );
                sumofarray += number[i];
            }

            Console.WriteLine($"The sum of arrays you entered is {sumofarray}.");  

        }
    }
}
