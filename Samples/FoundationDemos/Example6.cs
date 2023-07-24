namespace Samples;

/// <summary>
/// This class contains examples of using the Console class to output text, read input, format output, change text color, and clear the console.
/// </summary>
public class Example6
{
    public static void Run()
    {
        // Console output example
        Console.WriteLine("Hello, world!");

        // Console input example
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");

        // Console formatting example
        int myInt = 123;
        double myDouble = 3.14;
        Console.WriteLine("My integer value is: {0}", myInt);
        Console.WriteLine("My double value is: {0:F2}", myDouble);

        // Console color example
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This text is red.");
        Console.ResetColor();

        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b); Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        Console.Write("f = ");
        double f = double.Parse(Console.ReadLine()); Console.WriteLine("{0} * {1} / {2} = {3}",
                a, b, f, a * b / f);

        // Console clear example
        Console.Clear();
    }
}