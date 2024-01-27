// Lester CPS3330 lab2
using static System.Console;
WriteLine("Enter the number you want to compare 2 or 3?");
if (double.TryParse(ReadLine(), out double comnumber))
    if (comnumber == 3)
    {
        WriteLine("Enter the first number:");
        if (double.TryParse(ReadLine(), out double number1))
        {
            WriteLine("Enter the second number:");
            if (double.TryParse(ReadLine(), out double number2))
            {
                WriteLine("Enter the third numbrer:");
                if (double.TryParse(ReadLine(), out double number3))
                {
                    double maximum = U2AS_task5.Class1.FindMaximum(number1, number2, number3);
                    Console.WriteLine($"The maximum of {number1}, {number2}, and {number3} is: {maximum}");
                }
                else
                {
                    WriteLine("Invalid input for the third number. Please enter a valid number.");
                }
            }
            else
            {
                WriteLine("Invalid input for the second number. Please enter a valid number.");
            }
        }
        else
        {
            WriteLine("Invalid input for the first number. Please enter a valid number.");
        }
    }
    else if (comnumber == 2)
    {
        WriteLine("Enter the first number:");
        if (double.TryParse(ReadLine(), out double number1))
        {
            WriteLine("Enter the second number:");
            if (double.TryParse(ReadLine(), out double number2))
            {
                double maximum = U2AS_task5.Class1.FindMaximum(number1, number2);
                Console.WriteLine($"The maximum of {number1}, {number2} is: {maximum}");
            }
            else
            {

                WriteLine("Invalid input for the second number. Please enter a valid number.");
            }
        }
        else
        {
            WriteLine("Invalid input for the first number. Please enter a valid number.");
        }
    }
    else
        WriteLine("Invalid number");