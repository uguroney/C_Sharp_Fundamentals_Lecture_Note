namespace Samples;

/// <summary>
/// This class contains examples of different types of arrays in C#.
/// </summary>
public class Example9
{
    public static void Run()
    {
        // Single-dimensional array example
        int[] myArray = new int[5];
        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;
        myArray[3] = 4;
        myArray[4] = 5;
        Console.WriteLine("The value of the third element in myArray is: " + myArray[2]);

        // Multi-dimensional array example
        int[,] myMultiArray = new int[2, 3];
        myMultiArray[0, 0] = 1;
        myMultiArray[0, 1] = 2;
        myMultiArray[0, 2] = 3;
        myMultiArray[1, 0] = 4;
        myMultiArray[1, 1] = 5;
        myMultiArray[1, 2] = 6;
        Console.WriteLine("The value of the second element in the first row of myMultiArray is: " + myMultiArray[0, 1]);

        // Jagged array example
        int[][] myJaggedArray = new int[3][];
        myJaggedArray[0] = new int[] { 1, 2 };
        myJaggedArray[1] = new int[] { 3, 4, 5 };
        myJaggedArray[2] = new int[] { 6, 7, 8, 9 };
        Console.WriteLine("The value of the second element in the first row of myJaggedArray is: " + myJaggedArray[0][1]);

        // Array length example
        Console.WriteLine("The length of myArray is: " + myArray.Length);

        // Array sorting example
        int[] mySortedArray = myArray.OrderBy(x => x).ToArray();
        Console.WriteLine("The sorted values of myArray are: " + string.Join(", ", mySortedArray));

        // Array searching example
        int index = Array.IndexOf(myArray, 3);
        Console.WriteLine("The index of the value 3 in myArray is: " + index);
    }
}