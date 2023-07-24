namespace Samples;

/// <summary>
/// This class contains an example of using the null-coalescing operator.
/// </summary>
public class Example14
{
    public static void Run()
    {
        // Null-coalescing operator example
        int? x = null;
        int y = x ?? 10;

        Console.WriteLine("y is: " + y);

        string s = null;
        string t = s ?? "default";

        Console.WriteLine("t is: " + t);
    }
}