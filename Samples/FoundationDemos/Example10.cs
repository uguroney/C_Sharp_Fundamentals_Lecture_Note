namespace Samples;

/// <summary>
/// Provides examples for converting decimal, binary, and hexadecimal numbers.
/// </summary>
public class Example10
{
    public static void Run()
    {
        // Decimal to binary example
        int decimalNumber = 10;
        string binaryNumber = Convert.ToString(decimalNumber, 2);
        Console.WriteLine("The binary representation of " + decimalNumber + " is: " + binaryNumber);

        // Binary to decimal example
        string binaryNumber2 = "1010";
        int decimalNumber2 = Convert.ToInt32(binaryNumber2, 2);
        Console.WriteLine("The decimal representation of " + binaryNumber2 + " is: " + decimalNumber2);

        // Decimal to hexadecimal example
        int decimalNumber3 = 255;
        string hexadecimalNumber = decimalNumber3.ToString("X");
        Console.WriteLine("The hexadecimal representation of " + decimalNumber3 + " is: " + hexadecimalNumber);

        // Hexadecimal to decimal example
        string hexadecimalNumber2 = "FF";
        int decimalNumber4 = int.Parse(hexadecimalNumber2, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("The decimal representation of " + hexadecimalNumber2 + " is: " + decimalNumber4);

    }
}