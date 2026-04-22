using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        #region for loop
        {
            //loop statment

            //task 1:

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Please enter number");

            //    int x = Convert.ToInt32(Console.ReadLine());
            //}

            //=================================================================


            //task 2:

            //for (int x = 1; x <= 5; x++)
            //{
            //    for (int i = 0; i <= 5; i++)
            //    {
            //        Console.WriteLine($"{{{x}, {i}}}");
            //    }
            //}


            //task 3:prim number

            //Console.WriteLine("please enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //bool isPrime = true;

            //if (num < 2)
            //{
            //    isPrime = false;
            //}
            //else
            //{

            //    for (int i = 2; i <num; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false; 
            //            break; 
            //        }
            //    }
            //}


            //if (isPrime)
            //{
            //    Console.WriteLine($"{num} is a prime number ");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is not  a prime number");
            //}

        #endregion


            //=================================================================

            #region while loop     

            //task 1:
            //Console.WriteLine("Please Enter any number");
            //  int num = Convert.ToInt32(Console.ReadLine());

            //  while (num != 5) { 

            //      Console.WriteLine("Incorrect Number ");
            //      num = Convert.ToInt32(Console.ReadLine());
            //      Console.WriteLine("Correct Number ");

            //  }


            //task 2:

            //Random random = new Random();
            //int num = 0;


            //while (num != 5)
            //{

            //    num = random.Next(1, 11);

            //    if (num != 5)
            //    {

            //        Console.WriteLine($"Incorrect Number: {num}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Correct Number: {num}! Done.");
            //    }
            //}


            //task 3:

            //int counter = 1;

            //while (counter <= 3)
            //{
            //    Console.WriteLine($"Attempt {counter}: Please Enter any number");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num == 3)
            //    {
            //        Console.WriteLine("Correct Number");
            //    }

            //    counter++;
            //}

            #endregion

            //=================================================================



            #region string

        //task1:

            Console.WriteLine("Enter the word:");
            string word = Console.ReadLine();

            string reversedWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

           
            if (word== reversedWord)
            {
                Console.WriteLine("perfect Well done");
            }
            else
            {
                Console.WriteLine("incorrect word");
            }

            #endregion
        }
    }
}