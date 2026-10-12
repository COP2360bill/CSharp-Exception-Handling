using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Robust Division Calculator ---");
        
        // Prompt the user for input
        Console.Write("Enter the numerator: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the denominator: ");
        string input2 = Console.ReadLine();

        try
        {
            // Convert input strings to integers (can trigger FormatException or OverflowException)
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            // Perform the division method
            int result = Divide(num1, num2);

            // Print the result if no exceptions occur
            Console.WriteLine($"Success! Result: {num1} / {num2} = {result}");
        }
        catch (FormatException)
        {
            // Handles invalid string formats (entering letters instead of numbers)
            Console.WriteLine("Error: One or both inputs are not in a valid integer format. Please enter numbers only.");
        }
        catch (OverflowException)
        {
            // Handles numbers that are too large or too small for standard Int32
            Console.WriteLine("Error: The number entered is too large or too small for a standard 32-bit integer.");
            Console.WriteLine("Valid range is from -2,147,483,648 to 2,147,483,648.");
        }
        catch (DivideByZeroException)
        {
            // Handles division by zero
            Console.WriteLine("Error: Attempted to divide by zero. Please provide a non-zero denominator.");
        }
        catch (Exception ex)
        {
            // Catches any other unexpected exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Execution finished.");
        }
    }

    // Helper method to perform division
    static int Divide(int a, int b)
    {
        return a / b;
    }
}
