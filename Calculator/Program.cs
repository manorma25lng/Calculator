using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            bool doAgain = true;

            while (doAgain)


            {
                Console.WriteLine("\n===== Simple Calculator =====");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                Console.Write("Select an operation (1-4): ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid selection. Please enter a number between 1 and 4.");
                    continue;
                }

                Console.Write("Enter the first number: ");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.Write("Enter the second number: ");
                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }         

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        break;
                }

                Console.Write("\nDo you want to calculate again? (yes/no): ");
                string userResponse = Console.ReadLine().ToLower();
                if (userResponse != "yes")
                {
                    doAgain = false;
                    
                    Console.WriteLine("Thank you for using the calculator!");
                }
            }
        }
    }
}
