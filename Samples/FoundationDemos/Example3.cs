namespace Samples;

/// <summary>
/// This class contains examples of arithmetic operations and operator precedence in C#.
/// </summary>
public class Example3
{
    public static void Run()
    {
        int a = 10;
        int b = 5;
        int c = 2;

        int result1 = a + b * c;
        Console.WriteLine("a + b * c = " + result1);

        int result2 = (a + b) * c;
        Console.WriteLine("(a + b) * c = " + result2);

        int result3 = a / b * c;
        Console.WriteLine("a / b * c = " + result3);

        int result4 = a % b + c;
        Console.WriteLine("a % b + c = " + result4);

        int result5 = a + b++ * c;
        Console.WriteLine("a + b++ * c = " + result5);
        Console.WriteLine("b after increment = " + b);

        int result6 = a + ++b * c;
        Console.WriteLine("a + ++b * c = " + result6);
        Console.WriteLine("b after increment = " + b);


        int squarePerimeter = 17;
        double squareSide = squarePerimeter / 4.0; double squareArea = squareSide * squareSide;
        Console.WriteLine(squareSide); Console.WriteLine(squareArea);
   

        Console.WriteLine(a + b);
        Console.WriteLine(a + (b++));  
        Console.WriteLine(a + b);      
        Console.WriteLine(a + (++b));  
        Console.WriteLine(a + b);
        Console.WriteLine(14 / a);
        Console.WriteLine(14 % a);

        int one = 1;
        int zero = 0;

        try{
        Console.WriteLine(one / zero); 
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        
        double dMinusOne = -1.0;
        double dZero = 0.0;
        try{
        Console.WriteLine(dMinusOne / dZero); 
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}