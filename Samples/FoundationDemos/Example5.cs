
namespace Samples;

/// <summary>
/// This class contains examples of string manipulation in C#.
/// </summary>
public class Example5
{
    public static void Run()
    {
          // String conversion example
            int myInt = 123;
            string myString = myInt.ToString();
            Console.WriteLine("My string value is: " + myString);

            // String concatenation example
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("My full name is: " + fullName);

            // String interpolation example
            int age = 30;
            string message = $"My name is {fullName} and I am {age} years old.";
            Console.WriteLine(message);

            // String length example
            string myString2 = "Hello, world!";
            int length = myString2.Length;
            Console.WriteLine("My string length is: " + length);

            // String indexing example
            char myChar = myString2[1];
            Console.WriteLine("My second character is: " + myChar);

            // String substring example
            string mySubstring = myString2.Substring(7, 5);
            Console.WriteLine("My substring is: " + mySubstring);

            // String replace example
            string myString3 = "Hello, world!";
            string myString4 = myString3.Replace("world", "C#");
            Console.WriteLine("My replaced string is: " + myString4);

            // String comparison example
            string myString5 = "Hello, world!";
            string myString6 = "hello, world!";
            bool isEqual = myString5.Equals(myString6, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("My strings are equal: " + isEqual);
    }
}