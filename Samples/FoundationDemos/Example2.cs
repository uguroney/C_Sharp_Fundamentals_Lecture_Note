namespace Samples;

/// <summary>
/// This class demonstrates the usage of arithmetic, comparison, and logical operators in C#.
/// </summary>
public class Example2
{
    public static void Run()
    {
        // Arithmetic operators
        int a = 10;
        int b = 5;
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));
        Console.WriteLine("a % b = " + (a % b));

        // Comparison operators
        int c = 10;
        int d = 5;
        Console.WriteLine("c > d is " + (c > d));
        Console.WriteLine("c < d is " + (c < d));
        Console.WriteLine("c >= d is " + (c >= d));
        Console.WriteLine("c <= d is " + (c <= d));
        Console.WriteLine("c == d is " + (c == d));
        Console.WriteLine("c != d is " + (c != d));

        // Logical operators
        bool e = true;
        bool f = false;
        Console.WriteLine("e && f is " + (e && f));
        Console.WriteLine("e || f is " + (e || f));
        Console.WriteLine("!e is " + (!e));
    }
}