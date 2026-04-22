#nullable disable
namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //control statment

            #region control statment
            //task1:Positive, Negative, or Zero (


            //Console.WriteLine("Please Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num > 0)
            //{
            //    Console.WriteLine("positive");
            //}
            //else if (num < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("Zero");
            //}



            //task2:Even or Odd 

            //Console.WriteLine("Please Enter a number");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("Even Number");
            //}
            //else
            //{
            //    Console.WriteLine("Odd Number");

            //}


            //task3:Student Grade System 

            //Console.WriteLine("Please enter a student score");
            //int score = Convert.ToInt32(Console.ReadLine());

            //if (score >= 90 && score <= 100)
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else if (score >= 75)
            //{
            //    Console.WriteLine("Very Good");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (score >= 50)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else if (score <= 0)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Score");
            //}


            // Task 4 – Simple Login System

            //Console.WriteLine("Enter username: ");
            //string username = Console.ReadLine();

            //Console.WriteLine("Enter password: ");
            //string password = Console.ReadLine();

            //if (username == "admin" && password == "1234")
            //{
            //    Console.WriteLine("Login Successful");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Username or Password");
            //}


            // Task 5 – Simple ATM System

            int balance = 1000;

            Console.Write("Enter withdrawal amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Invalid Amount");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal Successful");
                Console.WriteLine("Remaining Balance: " + balance);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
            #endregion

    }
}
    

