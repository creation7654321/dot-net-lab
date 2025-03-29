using System;
using lab2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Enter your name");
        string name =  Console.ReadLine();
        Console.WriteLine($" Your name is {name} for sure");
        Console.ReadKey();

        Console.Clear();
        Largest compare = new Largest();
        compare.largest(1, 10, 3);
        Console.ReadKey();

        Console.Clear();
        OddEven oddEven = new OddEven();
        oddEven.OddEvenfunc(2);
        Console.ReadKey();
        
        Console.Clear();
        Swap SwapNumb = new Swap();
        SwapNumb.Swapping();
        Console.ReadKey();

        Console.Clear();
        Naturalnumbersum sum = new Naturalnumbersum();
        sum.sumofNat();
        Console.ReadKey();

        Console.Clear();
        Leapyear lyear = new Leapyear();
        lyear.CheckLeapYear();
        Console.ReadKey();

        Console.Clear();
        Arraysum array_sum = new Arraysum();
        array_sum.sum_of_array();
        Console.ReadKey();


        Console.Clear();
        Factorial f = new Factorial();
        f.Fact();
        Console.ReadKey();


        Console.Clear();
        Prime pnum = new Prime();
        pnum.CheckPrime();
        Console.ReadKey();




    }

   
}