namespace Samples;

/// <summary>
/// Contains examples of if statements and switch statements.
/// </summary>
public class Example7
{
    public static void Run()
    {
        // If statement example
        int myInt = 10;
        if (myInt > 5)
        {
            Console.WriteLine("My integer is greater than 5.");
        }

        // If-else statement example
        int myInt2 = 3;
        if (myInt2 > 5)
        {
            Console.WriteLine("My integer is greater than 5.");
        }
        else
        {
            Console.WriteLine("My integer is less than or equal to 5.");
        }

        // If-else if-else statement example
        int myInt3 = 7;
        if (myInt3 > 10)
        {
            Console.WriteLine("My integer is greater than 10.");
        }
        else if (myInt3 > 5)
        {
            Console.WriteLine("My integer is greater than 5 but less than or equal to 10.");
        }
        else
        {
            Console.WriteLine("My integer is less than or equal to 5.");
        }

        // Ternary operator example
        int myInt4 = 8;
        string message = (myInt4 > 5) ? "My integer is greater than 5." : "My integer is less than or equal to 5.";
        Console.WriteLine(message);

        // Switch statement example
        int myInt5 = 2;
        switch (myInt5)
        {
            case 1:
                Console.WriteLine("My integer is 1.");
                break;
            case 2:
                Console.WriteLine("My integer is 2.");
                break;
            case 3:
                Console.WriteLine("My integer is 3.");
                break;
            default:
                Console.WriteLine("My integer is not 1, 2, or 3.");
                break;
        }
    }
}