using ClassPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        MathOperations mathOperation = new MathOperations();
        int addvalue = mathOperation.Add(10, 4);
        double addedvalue = mathOperation.Add(17.53, 11.54);
        int product = mathOperation.Multiply(5, 4);
        double decimal_product = mathOperation.Multiply(10.02, 25.5);
        Console.WriteLine($"The int type add value is {addvalue}");
        Console.WriteLine($"The doubleint type add value is {addedvalue}");
        Console.WriteLine($"The multiply type add value is {product}");
        Console.WriteLine($"The doublemultiply type add value is {decimal_product}");

        Console.ReadKey();
        Console.Clear();

        MathOperation inheritance = new MathOperation();
        double add = inheritance.Add(10.5, 2);
        double sub = inheritance.Subtract(8.2, 4);
        double mul = inheritance.Multiply(12.6, 5);
        double div = inheritance.Divide(35, 3.5);
        Console.WriteLine($"Add = {add}, Subtract = {sub}, Multiply = {mul}, Divide = {div}");

        Console.ReadKey();
        Console.Clear();

        Palindrome checkingPalindrome = new Palindrome();
        checkingPalindrome.checkPalindrome();

        Console.ReadKey();
        Console.Clear();

    }
}