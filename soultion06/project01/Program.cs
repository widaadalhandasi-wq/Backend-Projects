<<<<<<< HEAD
﻿namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array

            // Task1:

            //Enter five number that use array, and print that number by using for loop.

            //int[] numbers01 = { 10, 20, 30, 40, 50 };
            //for (int i = 0; i < numbers01.Length; i++)
            //{

            //    Console.WriteLine(numbers01[i]);

            //}

            //======================================================================

            // Task2:Enter five number that use array, and print that number by using foreach.

            //int[] numbers02 = { 60, 70, 80, 90, 100 };
            //foreach (int i in numbers02)
            //{
            //    Console.WriteLine(i);
            //}

            //======================================================================

            // Task3:"Write a program that asks the user to input 5 numbers, stores them in an array, and then prints them."


            //int[] numbers03 = new int[5];
            //for (int i = 0; i < numbers03.Length; i++)
            //{
            //    Console.WriteLine("Please Enter A Number: ");
            //    numbers03[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine("===================================");
            //foreach (int i in numbers03)
            //{
            //    Console.WriteLine(i);
            //}

            //======================================================================

            // Task4:"Write a program that asks the user to input 5 numbers and then calculates their sum."

            //int[] numbers04= new int[5];
            //int sum = 0;

            //for (int i = 0; i < numbers04.Length; i++)
            //{
            //    Console.WriteLine("Please Enter A Number: ");
            //    numbers04[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += numbers04[i];
            //}
            //Console.WriteLine($"\nThe total sum of the numbers is: {sum}");

            //======================================================================

            // Task5:"Write a program that inputs 5 numbers into an array and finds the maximum value."

            //int[] numbers06 = new int[5];
            //int max = 0;
            //for (int i = 0; i < numbers06.Length; i++)
            //{
            //    Console.WriteLine($"Please Enter Number {i + 1}: ");
            //    numbers06[i] = Convert.ToInt32(Console.ReadLine());
            //    max=Math.Max(max, numbers06[i]);
            //}
            //Console.WriteLine($"\nMax = {max}");


            //======================================================================

            //Task6:"Write a program that inputs 5 numbers into an array and finds the minimum value."

            //int[] numbers07 = new int[5];
            //int min = int.MaxValue;
            //for (int i = 0; i < numbers07.Length; i++)
            //{
            //    Console.WriteLine($"Please Enter Number {i + 1}: ");
            //    numbers07[i] = Convert.ToInt32(Console.ReadLine());
            //    min = Math.Min(min, numbers07[i]);
            //}
            //Console.WriteLine($"\nMin = {min}");

            //======================================================================

            //Task7:"Write a program that asks the user to input 10 numbers and then prints only the even numbers."

            //int[] numbers08= new int[10];

            //    for (int i = 0; i < numbers08.Length; i++)
            //    {
            //        Console.WriteLine($"Please Enter Number {i + 1}: ");
            //        numbers08[i] = Convert.ToInt32(Console.ReadLine());

            //    }

            //    Console.WriteLine("\nThe Even numbers are:");
            //    for (int i = 0; i < numbers08.Length; i++)
            //    {
            //    if (numbers08[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers08[i]);
            //    }
            //    }

            //======================================================================

            //Task8:"Write a program that asks the user to input 5 numbers and then calculates their average."

            //int[] numbers08 = new int[5];
            //double sum = 0;
            //for (int i = 0; i < numbers08.Length; i++)
            //{
            //    Console.WriteLine($"Please Enter Number {i + 1}: ");
            //    numbers08[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += numbers08[i];
            //}
            //double average = sum / numbers08.Length;

            //Console.WriteLine($"\nAverage = {average}");

            //======================================================================

            //Task9:"Write a program that creates an array of 5 numbers and then reverses their order."

            //int[] numbers09 = new int[5];

            //for (int i = 0; i < numbers09.Length; i++)
            //{
            //    Console.WriteLine($"Please Enter Number {i + 1}: ");
            //    numbers09[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Array.Reverse(numbers09);

            //Console.WriteLine("\nThe reversed array is:");


            //for (int i = 0; i < numbers09.Length; i++)
            //{
            //    Console.WriteLine(numbers09[i]);
            //}
            //======================================================================

            //Task10:"Write a program that searches for a number within an array. If found, print its index; otherwise, print 'Number not found'."
           
            int[] numbers10 = { 10, 20, 30, 40, 50 }; 

            Console.Write("Enter the number you want to search for: ");
            int searchItem = Convert.ToInt32(Console.ReadLine());

            bool isFound = false; 

            for (int i = 0; i < numbers10.Length; i++)
            {
                if (numbers10[i] == searchItem)
                {
                    Console.WriteLine($"Number found at index {i}");
                    isFound = true; 
                    break; 
                }
            }

           
            if (!isFound) 
            {
                Console.WriteLine("Number not found");
            }

            #endregion

        }
    }
=======
﻿namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array

            // Task1:

            //Enter five number that use array, and print that number by using for loop.

            //int[] numbers01 = { 10, 20, 30, 40, 50 };
            //for (int i = 0; i < numbers01.Length; i++)
            //{

            //    Console.WriteLine(numbers01[i]);

            //}

            //======================================================================

            // Task2:Enter five number that use array, and print that number by using foreach.

            //int[] numbers02 = { 60, 70, 80, 90, 100 };
            //foreach (int i in numbers02)
            //{
            //    Console.WriteLine(i);
            //}

            //======================================================================

            // Task3:"Write a program that asks the user to input 5 numbers, stores them in an array, and then prints them."


            //int[] numbers03 = new int[5];
            //for (int i = 0; i < numbers03.Length; i++)
            //{
            //    Console.WriteLine("Please Enter A Number: ");
            //    numbers03[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine("===================================");
            //foreach (int i in numbers03)
            //{
            //    Console.WriteLine(i);
            //}

            //======================================================================

            // Task4:"Write a program that asks the user to input 5 numbers and then calculates their sum."

            //int[] numbers04= new int[5];
            //int sum = 0;

            //for (int i = 0; i < numbers04.Length; i++)
            //{
            //    Console.WriteLine("Please Enter A Number: ");
            //    numbers04[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += numbers04[i];
            //}
            //Console.WriteLine($"\nThe total sum of the numbers is: {sum}");

            //======================================================================

            // Task5:"Write a program that inputs 5 numbers into an array and finds the maximum value."

            //int[] numbers06 = new int[5];
            //int max = 0;
            //for (int i = 0; i < numbers06.Length; i++)
            //{
            //    Console.WriteLine($"Please Enter Number {i + 1}: ");
            //    numbers06[i] = Convert.ToInt32(Console.ReadLine());
            //    max=Math.Max(max, numbers06[i]);
            //}
            //Console.WriteLine($"\nMax = {max}");


            //======================================================================

            //Task6:"Write a program that inputs 5 numbers into an array and finds the minimum value."

            //int[] numbers07 = new int[5];
            //int min = int.MaxValue;
            //for (int i = 0; i < numbers07.Length; i++)
            //{
            //    Console.WriteLine($"Please Enter Number {i + 1}: ");
            //    numbers07[i] = Convert.ToInt32(Console.ReadLine());
            //    min = Math.Min(min, numbers07[i]);
            //}
            //Console.WriteLine($"\nMin = {min}");

            //======================================================================

            //Task7:"Write a program that asks the user to input 10 numbers and then prints only the even numbers."

            //int[] numbers08= new int[10];

            //    for (int i = 0; i < numbers08.Length; i++)
            //    {
            //        Console.WriteLine($"Please Enter Number {i + 1}: ");
            //        numbers08[i] = Convert.ToInt32(Console.ReadLine());

            //    }

            //    Console.WriteLine("\nThe Even numbers are:");
            //    for (int i = 0; i < numbers08.Length; i++)
            //    {
            //    if (numbers08[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers08[i]);
            //    }
            //    }

            //======================================================================

            //Task8:"Write a program that asks the user to input 5 numbers and then calculates their average."

            //int[] numbers08 = new int[5];
            //double sum = 0;
            //for (int i = 0; i < numbers08.Length; i++)
            //{
            //    Console.WriteLine($"Please Enter Number {i + 1}: ");
            //    numbers08[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += numbers08[i];
            //}
            //double average = sum / numbers08.Length;

            //Console.WriteLine($"\nAverage = {average}");

            //======================================================================

            //Task9:"Write a program that creates an array of 5 numbers and then reverses their order."

            //int[] numbers09 = new int[5];

            //for (int i = 0; i < numbers09.Length; i++)
            //{
            //    Console.WriteLine($"Please Enter Number {i + 1}: ");
            //    numbers09[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Array.Reverse(numbers09);

            //Console.WriteLine("\nThe reversed array is:");


            //for (int i = 0; i < numbers09.Length; i++)
            //{
            //    Console.WriteLine(numbers09[i]);
            //}
            //======================================================================

            //Task10:"Write a program that searches for a number within an array. If found, print its index; otherwise, print 'Number not found'."
           
            int[] numbers10 = { 10, 20, 30, 40, 50 }; 

            Console.Write("Enter the number you want to search for: ");
            int searchItem = Convert.ToInt32(Console.ReadLine());

            bool isFound = false; 

            for (int i = 0; i < numbers10.Length; i++)
            {
                if (numbers10[i] == searchItem)
                {
                    Console.WriteLine($"Number found at index {i}");
                    isFound = true; 
                    break; 
                }
            }

           
            if (!isFound) 
            {
                Console.WriteLine("Number not found");
            }

            #endregion

        }
    }
>>>>>>> 841c075925cb6227d979a0b25f92d31880cd5bb7
}