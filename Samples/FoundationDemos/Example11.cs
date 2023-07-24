namespace Samples;

/// <summary>
/// This class contains examples of different types of methods in C#.
/// </summary>
public class Example11
{
    public static void Run()
    {
        // Method call example
        int result = AddNumbers(2, 3);
        Console.WriteLine("The result of adding 2 and 3 is: " + result);

        // Method overload example
        int result2 = AddNumbers(2, 3, 4);
        Console.WriteLine("The result of adding 2, 3, and 4 is: " + result2);
        // Void method call example
        PrintMessage("Hello, world!");

        // Void method with parameters example
        PrintSum(2, 3);

        // Recursive method call example
        int result3 = Factorial(5);
        Console.WriteLine("The factorial of 5 is: " + result3);

        // Pass by value example
        int x = 5;
        Console.WriteLine("Before calling PassByValue method, x = " + x);
        PassByValue(x);
        Console.WriteLine("After calling PassByValue method, x = " + x);

        // Pass by reference example
        int y = 5;
        Console.WriteLine("Before calling PassByRef method, y = " + y);
        PassByRef(ref y);
        Console.WriteLine("After calling PassByRef method, y = " + y);

        // Out method call example
        bool success = DivideNumbers(10, 2, out int result4);
        if (success)
        {
            Console.WriteLine("The result of dividing 10 by 2 is: " + result4);
        }
        else
        {
            Console.WriteLine("Division failed.");
        }

        // Params method call example
        int result5 = SumNumbers(1, 2, 3, 4, 5);
        Console.WriteLine("The sum of 1, 2, 3, 4, and 5 is: " + result5);

        // Yield method call example
        foreach (int number in GetNumbers())
        {
            Console.WriteLine(number);
        }

    }

    // Method definition example
    static int AddNumbers(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    // Method overload definition example
    static int AddNumbers(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }

    // Void method definition example
    static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    // Void method with parameters definition example
    static void PrintSum(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("The sum of " + a + " and " + b + " is: " + sum);
    }
    // Recursive method definition example
    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    // Pass by value method definition example
    static void PassByValue(int a)
    {
        a = 10;
        Console.WriteLine("Inside PassByValue method, a = " + a);
    }

    // Pass by reference method definition example
    static void PassByRef(ref int b)
    {
        b = 10;
        Console.WriteLine("Inside PassByRef method, b = " + b);
    }

    // Out method definition example
    static bool DivideNumbers(int a, int b, out int result)
    {
        if (b == 0)
        {
            result = 0;
            return false;
        }
        else
        {
            result = a / b;
            return true;
        }
    }

    // Params method definition example
    static int SumNumbers(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    // Yield method definition example
    static IEnumerable<int> GetNumbers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
        yield return 4;
        yield return 5;
    }
}