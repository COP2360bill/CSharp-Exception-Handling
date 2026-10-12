{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Division Calculator ===");

        Console.Write("10: ");
        string input1 = Console.ReadLine() ?? "";

        Console.Write("2: ");
        string input2 = Console.ReadLine() ?? "";

        Divide(input1, input2);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void Divide(string num1, string num2)
    {
        try
        {
            // Convert input strings to integers
            int number1 = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);

            // Perform division
            int result = number1 / number2;

            // Display the result
            Console.WriteLine($"Result: {number1} / {number2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine(
                "Error: Invalid input. Please enter valid integers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine(
                "Error: Cannot divide by zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine(
                "Error: The number is too large or too small for an integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"An unexpected error occurred: {ex.Message}");
        }
    }
}