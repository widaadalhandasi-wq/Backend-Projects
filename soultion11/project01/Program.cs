using System;
using System.Collections.Generic;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region Stack
            //Stack<int> numbers = new Stack<int>();// generic
            //numbers.Push(1);
            //numbers.Push(2);
            //numbers.Push(3);
            //numbers.Push(4);
            //numbers.Pop();
            //Console.WriteLine(numbers.Peek()); //4|







            //#endregion


            //#region Queue
            //Queue<string> names = new Queue<string>();

            //names.Enqueue("Yahia");
            //names.Enqueue("Ahmed");
            //names.Enqueue("Salem");

            //Console.WriteLine(names.Peek());


            //#endregion


            //#region Dictionary

            //Dictionary<string, int> StudentData = new Dictionary<string, int>();

            //StudentData.Add("Ali", 20);
            //StudentData.Add("Mohammed", 25);
            //try
            //{
            //    Console.WriteLine($"Ali is " + StudentData["Ali"] + " years old");
            //}
            //catch (Exception ex) { Console.WriteLine(ex.ToString()); }


            //try
            //{
            //    StudentData["Ali"] = 33;
            //    Console.WriteLine("Ali's age has been update");
            //}
            //catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            //try
            //{
            //    StudentData.Remove("Ali");
            //    Console.WriteLine("Ali has been deleted");
            //}
            //catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            //try
            //{
            //    Console.WriteLine(StudentData.ContainsKey("Ali"));
            //}

            //catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            //#endregion


            //#region Task1
            //Stack<string> names = new Stack<string>();
            //string choice = "";

            //while (choice != "5")
            //{
            //    Console.WriteLine("\n--- Select an Option ---");
            //    Console.WriteLine("1. Add 5 Strings");
            //    Console.WriteLine("2. print All Elements");
            //    Console.WriteLine("3. Delete Last Element");
            //    Console.WriteLine("4. Show All Elements");
            //    Console.WriteLine("5. Exit");
            //    Console.Write("Enter your choice: ");

            //    choice = Console.ReadLine();

            //    // 1- Add 5 Strings
            //    if (choice == "1")
            //    {
            //        for (int i = 1; i <= 5; i++)
            //        {
            //            Console.Write($"Enter name {i}: ");
            //            string name = Console.ReadLine();
            //            names.Push(name);
            //        }
            //        Console.WriteLine("Added 5 names to the stack.");
            //    }

            //    // 2-Show All Elements (foreach)
            //    else if (choice == "2")
            //    {
            //        if (names.Count > 0)
            //        {
            //            Console.WriteLine("The names in the stack are:");
            //            foreach (string name in names)
            //            {
            //                Console.WriteLine("- " + name);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("The stack is empty!");
            //        }
            //    }

            //    // 3- Delete Last Element 
            //    else if (choice == "3")
            //    {
            //        if (names.Count > 0)
            //        {

            //            string lastAdded = names.Peek();
            //            Console.WriteLine("The last element added is: " + lastAdded);


            //        }
            //        else
            //        {
            //            Console.WriteLine("The stack is empty!");
            //        }
            //    }
            //    // 4-Show All Elements
            //    else if (choice == "4")
            //    {
            //        if (names.Count > 0)
            //        {
            //            Console.WriteLine("Displaying all elements:");
            //            foreach (string n in names)
            //            {
            //                Console.WriteLine("- " + n);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Stack is empty.");
            //        }
            //    }

            //    // 5-Exit
            //    else if (choice == "5")
            //    {
            //        Console.WriteLine("Exiting program... Goodbye!");
            //    }


            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please choose a number from 1 to 5.");
            //    }
            //}

            //#endregion



        }
    }
}

      
    
