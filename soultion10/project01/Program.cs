using System;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        static void Calculator()
        {
            bool keepRunning = true; 

            while (keepRunning)
            {
                try
                {
                    Console.Clear(); 
                    Console.WriteLine("Hello In Calculator App...");
                    Console.WriteLine("--------------------------------------------------");

                    Console.Write("Welcome, please Enter First Number: ");
                    int fnum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please Enter Second Number: ");
                    int snum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please Enter An Operation (+, -, *, /): ");
                    char operation = Convert.ToChar(Console.ReadLine());

                    Console.WriteLine("--------------------------------------------------");

                    if (operation == '-')
                    {
                        Console.WriteLine($"{fnum} {operation} {snum} = {fnum - snum}");
                    }
                    else if (operation == '+')
                    {
                        Console.WriteLine($"{fnum} {operation} {snum} = {fnum + snum}");
                    }
                    else if (operation == '*')
                    {
                        Console.WriteLine($"{fnum} {operation} {snum} = {fnum * snum}");
                    }
                    else if (operation == '/')
                    {
                        if (snum != 0)
                        {
                            Console.WriteLine($"{fnum} {operation} {snum} = {(double)fnum / snum}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Input Error: Please enter valid numbers only.");
                }

                // --- 
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Do you want to perform another operation? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response != "y")
                {
                    keepRunning = false;
                    Console.WriteLine("Thank you for using the Calculator. Goodbye!");
                }
            }
        }
    }
}