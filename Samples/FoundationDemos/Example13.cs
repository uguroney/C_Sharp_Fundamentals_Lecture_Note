namespace Samples;

/// <summary>
/// Contains examples of exception handling in C#.
/// </summary>
public class Example13
{
    public static void Run()
    {
        try
        {
            // Exception handling example
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("The fourth number is: " + numbers[3]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("The program has finished executing.");
        }

        try
        {
            // Throw keyword example
            int age = -1;
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            }
            Console.WriteLine("Age is: " + age);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("The program has finished executing.");
        }

        try
            {
                // Multiple catch and catch with when example
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine("The fourth number is: " + numbers[3]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An index out of range error occurred: " + ex.Message);
            }
            catch (Exception ex) when (ex.Message.Contains("fourth"))
            {
                Console.WriteLine("A fourth element error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("The program has finished executing.");
            }
    }
}