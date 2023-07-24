namespace Samples;

/// <summary>
/// This class contains examples of different types of loops in C#.
/// </summary>
public class Example8
{
    public static void Run()
    {
        // For loop example
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("The value of i is: " + i);
        }

        // While loop example
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("The value of j is: " + j);
            j++;
        }

        // Do-while loop example
        int k = 0;
        do
        {
            Console.WriteLine("The value of k is: " + k);
            k++;
        } while (k < 5);

        // Foreach loop example
        int[] myArray = { 1, 2, 3, 4, 5 };
        foreach (int num in myArray)
        {
            Console.WriteLine("The value of num is: " + num);
        }
    }
}