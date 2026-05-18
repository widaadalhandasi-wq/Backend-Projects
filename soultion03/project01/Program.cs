using System.ComponentModel.DataAnnotations;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region loop statment
            //C# Practice Tasks
            ///Task 1 – Day Name Printer

            //Console.WriteLine("Enter a number (1-7): ");
            //int day = Convert.ToInt32(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:

            //        if (!(day >= 1 && day <= 7))
            //        {
            //            Console.WriteLine("Invalid day number");
            //        }
            //        break;
            //}
            //=======================================================================================================================================================

            //Task 2 – Multiplication Table


            //Console.WriteLine("Enter a number to see its multiplication table: ");

            //// Converting user input to an integer
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"\nMultiplication Table for {number}:");
            //Console.WriteLine("------------------------------");

            //// For loop running exactly 10 iterations (from 1 to 10)
            //for (int i = 1; i <= 10; i++)
            //{
            //    // Calculating the result
            //    int result = number * i;

            //    // Printing in the format: 5 x 3 = 15
            //    Console.WriteLine($"{number} x {i} = {result}");
            //}

            //=======================================================================================================================================================
            //Task 3: Countdown Timer (C#)

            //Console.WriteLine("Enter a positive number to start the countdown: ");
            //int count = Convert.ToInt32(Console.ReadLine());

            //// Check if the number is positive
            //if (count > 0)
            //{
            //    // While loop runs as long as count is 1 or greater
            //    while (count >= 1)
            //    {
            //        Console.WriteLine(count);

            //        // Decrease the number by 1 in each step
            //        count--;
            //    }

            //    Console.WriteLine("Go!");
            //}
            //else
            //{
            //    // This executes if the number is 0 or negative
            //    Console.WriteLine("Please enter a positive number");
            //}


            //=======================================================================================================================================================


            //Task 4 – Season Detector with Month Validation

            //Console.WriteLine("Enter a month number (1–12): ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //switch (month)
            //{
            //    // Grouping multiple cases for Winter
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Winter");
            //        break;

            //    // Grouping multiple cases for Spring
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Spring");
            //        break;

            //    // Grouping multiple cases for Summer
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Summer");
            //        break;

            //    // Grouping multiple cases for Autumn
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Autumn");
            //        break;

            //    // Default handle for numbers < 1 or > 12
            //    default:
            //        Console.WriteLine("Invalid month number");
            //        break;
            //}


            //=======================================================================================================================================================

            //Task 5 – Sum of Even and Odd Numbers

            //Console.WriteLine("Enter a positive integer (N): ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //// Accumulators initialized to 0
            //int evenSum = 0;
            //int oddSum = 0;

            //if (n > 0)
            //{
            //    // Loop from 1 up to and including N
            //    for (int i = 1; i <= n; i++)
            //    {
            //        // Check if the number is even
            //        if (i % 2 == 0)
            //        {
            //            evenSum += i; // Add current number to even total
            //        }
            //        else
            //        {
            //            oddSum += i;  // Add current number to odd total
            //        }
            //    }

            //    Console.WriteLine($"\nResults for numbers from 1 to {n}:");
            //    Console.WriteLine("----------------------------------");
            //    Console.WriteLine($"Total sum of even numbers: {evenSum}");
            //    Console.WriteLine($"Total sum of odd numbers:  {oddSum}");
            //    Console.WriteLine("----------------------------------");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a number greater than 0.");
            //}


            //=======================================================================================================================================================

            //Task 6 – Password Retry System

            //string correctPassword = "1234";
            //int attempts = 0;
            //int maxAttempts = 3;

            //while (attempts < maxAttempts)
            //{
            //    Console.WriteLine("Enter your password: ");
            //    string? input = Console.ReadLine();
            //    attempts++; 

            //    if (input == correctPassword)
            //    {
            //        Console.WriteLine("Access Granted");
            //        break; 
            //    }
            //    else
            //    {
            //        if (attempts == maxAttempts)
            //        {
            //            Console.WriteLine("Account Locked");
            //        }
            //        else
            //        {

            //            int remaining = maxAttempts - attempts;
            //            Console.WriteLine($"Wrong password, try again. Attempts remain: {remaining}");
            //        }
            //    }
            //}


            //=======================================================================================================================================================

            //Task 7 – Simple Calculator

            //bool keepRunning = true;

            //// استخدام while loop لتكرار البرنامج بالكامل
            //while (keepRunning)
            //{
            //    Console.WriteLine("\n--- Simple Calculator ---");
            //    Console.Write("Enter first number: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    double num2 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter operator (+, -, *, /) or type 'exit' to quit: ");
            //    string op = Console.ReadLine()!.ToLower();

            //    // التحقق من رغبة المستخدم في الخروج
            //    if (op == "exit")
            //    {
            //        keepRunning = false;
            //        Console.WriteLine("Exiting calculator. Goodbye!");
            //        break;
            //    }

            //    // استخدام switch لتحديد العملية الحسابية
            //    switch (op)
            //    {
            //        case "+":
            //            Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
            //            break;
            //        case "-":
            //            Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
            //            break;
            //        case "*":
            //            Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
            //            break;
            //        case "/":
            //            // التحقق من القسمة على صفر باستخدام NOT (!)
            //            if (num2 != 0)
            //            {
            //                Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: Cannot divide by zero.");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invalid operator! Please use +, -, *, or /.");
            //            break;
            //    }
            //}

            //=======================================================================================================================================================

            //Task 8 – Prime Number Checker in a Range

            //Console.Write("Enter the start of the range: ");
            //int start = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the end of the range: ");
            //int end = Convert.ToInt32(Console.ReadLine());

            //bool foundAnyPrime = false; 

            //Console.WriteLine($"\nPrime numbers between {start} and {end}:");


            //for (int num = start; num <= end; num++)
            //{
            //    if (num < 2) continue; 

            //    bool isPrime = true; 


            //    for (int i = 2; i < num; i++)
            //    {
            //        if (num % i == 0) 
            //        {
            //            isPrime = false;
            //            break; 
            //        }
            //    }


            //    if (isPrime)
            //    {
            //        Console.Write(num + " ");
            //        foundAnyPrime = true;
            //    }
            //}


            //if (!foundAnyPrime)
            //{
            //    Console.WriteLine("No prime numbers found");
            //}
            //else
            //{
            //    Console.WriteLine("\nDone!");
            //}

            //=======================================================================================================================================================
            //Task 9 – Student Grade Report

            //Console.Write("Enter the number of students (N): ");
            //int n = Convert.ToInt32(Console.ReadLine());


            //int excellentCount = 0, veryGoodCount = 0, goodCount = 0, passCount = 0, failCount = 0;


            //int highest = -1; 
            //int lowest = 101; 

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"Enter score for student {i} (0-100): ");
            //    int score = Convert.ToInt32(Console.ReadLine());


            //    if (score > highest) highest = score;
            //    if (score < lowest) lowest = score;


            //    int key = score / 10;

            //    switch (key)
            //    {
            //        case 10:
            //        case 9:
            //            Console.WriteLine("Grade: Excellent");
            //            excellentCount++;
            //            break;
            //        case 8:
            //            Console.WriteLine("Grade: Very Good");
            //            veryGoodCount++;
            //            break;
            //        case 7:
            //            Console.WriteLine("Grade: Good");
            //            goodCount++;
            //            break;
            //        case 6:
            //            Console.WriteLine("Grade: Pass");
            //            passCount++;
            //            break;
            //        default:
            //            Console.WriteLine("Grade: Fail");
            //            failCount++;
            //            break;
            //    }
            //}

            ////print final result
            //Console.WriteLine("\n--- Grade Report ---");
            //Console.WriteLine($"Excellent: {excellentCount}");
            //Console.WriteLine($"Very Good: {veryGoodCount}");
            //Console.WriteLine($"Good:      {goodCount}");
            //Console.WriteLine($"Pass:      {passCount}");
            //Console.WriteLine($"Fail:      {failCount}");
            //Console.WriteLine("--------------------");
            //Console.WriteLine($"Highest Score: {highest}");
            //Console.WriteLine($"Lowest Score:  {lowest}");

            //=======================================================================================================================================================
            //Task 10 – Mini Banking System

          
            string correctPin = "9999";
            double balance = 5000;
            int pinAttempts = 0;
            bool isAuthenticated = false;

          
            string[] transTypes = new string[100]; 
            double[] transAmounts = new double[100]; 
            int transIndex = 0;

            // (Login)
            while (pinAttempts < 3)
            {
                Console.Write("Enter PIN: ");
                string inputPin = Console.ReadLine()!;
                pinAttempts++;

                if (inputPin == correctPin)
                {
                    isAuthenticated = true;
                    break;
                }
                else
                {
                    if (pinAttempts == 3) Console.WriteLine("Card Blocked");
                    else Console.WriteLine($"Wrong PIN. Remaining attempts: {3 - pinAttempts}");
                }
            }

            // (Menu)
            if (isAuthenticated)
            {
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("\n--- Mini Bank Menu ---");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Exit");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine()!;

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine($"Current Balance: {balance}");
                            break;

                        case "2": // (Deposit)
                            Console.Write("Enter deposit amount: ");
                            double dAmount = Convert.ToDouble(Console.ReadLine());

                           
                            if (dAmount > 0 && dAmount <= 10000)
                            {
                                balance += dAmount;
                               
                                transTypes[transIndex] = "Deposit";
                                transAmounts[transIndex] = dAmount;
                                transIndex++;
                                Console.WriteLine("Deposit successful.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid deposit amount (Must be 1-10000).");
                            }
                            break;

                        case "3": // (Withdraw)
                            Console.Write("Enter withdrawal amount: ");
                            double wAmount = Convert.ToDouble(Console.ReadLine());

                 
                            if (wAmount > 0 && wAmount <= balance)
                            {
                                balance -= wAmount;
                         
                                transTypes[transIndex] = "Withdrawal";
                                transAmounts[transIndex] = wAmount;
                                transIndex++;
                                Console.WriteLine("Withdrawal successful.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount or insufficient balance.");
                            }
                            break;

                        case "4":
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid option, please try again.");
                            break;
                    }
                }
                       //(Transaction Log)
                Console.WriteLine("\n--- Session Transaction Summary ---");
                if (transIndex == 0)
                {
                    Console.WriteLine("No transactions made.");
                }
                else
                {
                    for (int i = 0; i < transIndex; i++)
                    {
                        Console.WriteLine($"{i + 1}. {transTypes[i]}: {transAmounts[i]}");
                    }
                }
                Console.WriteLine("Thank you for using our system!");
            }
            #endregion





        }
    }

}
