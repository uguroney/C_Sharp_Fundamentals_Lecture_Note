namespace Samples;

/// <summary>
/// This class contains examples of boxing, unboxing, and type casting in C#.
/// </summary>
public class Example4
{
    public static void Run()
    {
            // Boxing example
            int myInt = 123;
            object myObject = myInt; // Boxing
            Console.WriteLine("My object value is: " + myObject);

            // Unboxing example
            int myInt2 = (int)myObject; // Unboxing
            Console.WriteLine("My integer value is: " + myInt2);

            // Type casting example
            double myDouble = 3.14;
            int myInt3 = (int)myDouble; // Explicit type casting
            Console.WriteLine("My integer value is: " + myInt3);

            // Implicit type casting example
            int myInt4 = 123;
            double myDouble2 = myInt4; // Implicit type casting
            Console.WriteLine("My double value is: " + myDouble2);
    }
}