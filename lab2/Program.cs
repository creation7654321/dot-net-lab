using System;
using lab2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        Largest compare = new Largest();
        compare.largest(1, 10, 3);
        Console.ReadKey();


        OddEven oddEven = new OddEven();
        oddEven.OddEvenfunc(2);
        Console.ReadKey();

        Swap SwapNumb = new Swap();
        SwapNumb.Swapping();
        Console.ReadKey();





    }

   
}