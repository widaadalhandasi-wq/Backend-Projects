<<<<<<< HEAD
﻿using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Multidimentional Array

            //Console.WriteLine("enter number of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number of columns");
            //int cols = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("========================================");

            //int[,] numbers = new int[rows, cols];


            //for (int i = 0; i < rows; i++)
            //{
            //    for (int w = 0; w < cols; w++)
            //    {
            //        Console.WriteLine($"enter element for ({i},{w})");
            //        numbers[i, w] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("\nelement is :");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int w = 0; w < cols; w++)
            //    {
            //        Console.WriteLine($"The value of ({i},{w})={numbers[i, w]}");

            //    }
            //}

            #endregion


            #region Jagged Array

            //int[][] numbers01 =
            //{
            //    new int[]{10,20,30},
            //    new int[]{40,50},
            //    new int[]{60,70,80,90},
            //};

            //Console.WriteLine(numbers01[0][2]);

            #endregion



            #region Assignment

            //Student Management System Using Arrays (C#) -Assignment

            ///Part 1 – Student Names (One Dimensional Array)
            //Create an array that stores 5 student names. Ask the user to enter the names, store them in the
            //array, and print them using a loop:

            string[] Students = new string[5];

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Enter The name of Students {i + 1}: ");

                Students[i] = Console.ReadLine();


            }
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"The Students names are {i + 1}: {Students[i]} ");
            }


            Console.WriteLine("------------------------------------------------------");

            // Part 2 – Student Grades(Multi-Dimensional Array)
            //Create a 2D array for grades: 5 students and 3 subjects(Math, Science, English).Ask the user to
            //enter the grades for each student and store them.

            int[,] grades = new int[5, 3];
            string[] subjects = { "Math", "Science", "English" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter The Grades for Student {i + 1}: ");


                for (int w = 0; w < 3; w++)
                {
                    Console.Write($"Enter grade for {subjects[w]}: ");
                    grades[i, w] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }



            // Part 3 – Display Student Grades
            ////Print the grades in a table format showing each student and their grades.

            Console.WriteLine("Student\tMath\tScience\tEnglish");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}\t");
                for (int w = 0; w < 3; w++)
                {
                    Console.Write($"{grades[i, w]}\t");
                }
                Console.WriteLine();
            }



            // Part 4 – Calculate Student Average
            // Calculate and display the average grade for each student.

            Console.WriteLine("\n--- Final Student Report ---");
            Console.WriteLine("Name\t\tMath\tScience\tEnglish\tAverage");
            Console.WriteLine("------------------------------------------------------------");

            for (int i = 0; i < 5; i++)
            {
                int totalSum = 0;


                Console.Write($"{Students[i]}\t\t");

                for (int w = 0; w < 3; w++)
                {

                    Console.Write($"{grades[i, w]}\t");
                    totalSum += grades[i, w];
                }

                // Calculate the average

                double average = (double)totalSum / 3;


                Console.WriteLine($"{average}");
            }

            Console.WriteLine("------------------------------------------------------------");

            // Part 5 – Jagged Array
            //Create a jagged array where each student can have a different number of subjects. Display the
            //number of subjects and grades for each student.

            int[][] jaggedGrades = new int[5][];

            for (int i = 0; i < jaggedGrades.Length; i++)
            {
                Console.Write($"How many subjects does Student {i + 1} have? ");
                int subCount = Convert.ToInt32(Console.ReadLine());

                jaggedGrades[i] = new int[subCount];

                for (int j = 0; j < subCount; j++)
                {
                    Console.Write($"  Enter grade for subject {j + 1}: ");
                    jaggedGrades[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //  Display the data
            Console.WriteLine("\n--- Jagged Array Student Report ---");
            for (int i = 0; i < jaggedGrades.Length; i++)
            {
                Console.Write($"Student {i + 1} ({jaggedGrades[i].Length} subjects): ");

                for (int j = 0; j < jaggedGrades[i].Length; j++)
                {
                    Console.Write(jaggedGrades[i][j] + " ");
                }
                Console.WriteLine();

            }

            //  Part 6 – Search for Student
            //Ask the user to enter a student name.If found, print the index of the student.If not found, display a
            //message saying the student was not found.

            Console.WriteLine("\n------------------------------------------------------");
            Console.Write("Enter the name of the student you want to search for: ");
            string searchName = Console.ReadLine();

            bool isFound = false;

            for (int i = 0; i < Students.Length; i++)
            {

                if (Students[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Student '{searchName}' was found at index: {i}");
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"The student '{searchName}' was not found in the system.");
            }


            //  Part 7 – Find Highest Grade
            //Search through all grades and display the highest grade in the system.

            int highestGrade = grades[0, 0];
            for (int i = 0; i < 5; i++) 
            {
                for (int w = 0; w < 3; w++) 
                {               
                    if (grades[i, w] > highestGrade)
                    {
                        highestGrade = grades[i, w];
                    }
                }
            }

            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine($"The highest grade recorded in the system is: {highestGrade}");


            Console.WriteLine("\n------------------------------------------------------");



            // Bonus Tasks(Optional)
            //1.Sort students alphabetically.
            Array.Sort(Students);

            Console.WriteLine("\nSorted Students:");
            foreach (string name in Students)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("------------------------------------------------------------");

            //2.Find the student with the highest average.

            double bestAvg = 0;
            string topStudent = "";

            for (int i = 0; i < 5; i++)
            {
                int sum = 0;

                for (int j = 0; j < 3; j++)
                {
                    sum += grades[i, j];
                }

                double avg = (double)sum / 3;

                if (avg > bestAvg)
                {
                    bestAvg = avg;
                    topStudent = Students[i];
                }
            }
            Console.WriteLine($"\nTop Student: {topStudent} with the highest average: {bestAvg}");
            Console.WriteLine("------------------------------------------------------------");

            //3.Count how many students passed(grade >= 50).

            int passed = 0;

            for (int i = 0; i < 5; i++)
            {
                bool ok = true;

                for (int j = 0; j < 3; j++)
                {
                    if (grades[i, j] < 50)
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok)
                {
                    passed++;
                }
            }

            Console.WriteLine("\nPassed Students: " + passed);


            #endregion
        }
    }
}
        

    

=======
﻿using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Multidimentional Array

            //Console.WriteLine("enter number of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number of columns");
            //int cols = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("========================================");

            //int[,] numbers = new int[rows, cols];


            //for (int i = 0; i < rows; i++)
            //{
            //    for (int w = 0; w < cols; w++)
            //    {
            //        Console.WriteLine($"enter element for ({i},{w})");
            //        numbers[i, w] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("\nelement is :");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int w = 0; w < cols; w++)
            //    {
            //        Console.WriteLine($"The value of ({i},{w})={numbers[i, w]}");

            //    }
            //}

            #endregion


            #region Jagged Array

            //int[][] numbers01 =
            //{
            //    new int[]{10,20,30},
            //    new int[]{40,50},
            //    new int[]{60,70,80,90},
            //};

            //Console.WriteLine(numbers01[0][2]);

            #endregion



            #region Assignment

            //Student Management System Using Arrays (C#) -Assignment

            ///Part 1 – Student Names (One Dimensional Array)
            //Create an array that stores 5 student names. Ask the user to enter the names, store them in the
            //array, and print them using a loop:

            string[] Students = new string[5];

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Enter The name of Students {i + 1}: ");

                Students[i] = Console.ReadLine();


            }
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"The Students names are {i + 1}: {Students[i]} ");
            }


            Console.WriteLine("------------------------------------------------------");

            // Part 2 – Student Grades(Multi-Dimensional Array)
            //Create a 2D array for grades: 5 students and 3 subjects(Math, Science, English).Ask the user to
            //enter the grades for each student and store them.

            int[,] grades = new int[5, 3];
            string[] subjects = { "Math", "Science", "English" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter The Grades for Student {i + 1}: ");


                for (int w = 0; w < 3; w++)
                {
                    Console.Write($"Enter grade for {subjects[w]}: ");
                    grades[i, w] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }



            // Part 3 – Display Student Grades
            ////Print the grades in a table format showing each student and their grades.

            Console.WriteLine("Student\tMath\tScience\tEnglish");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}\t");
                for (int w = 0; w < 3; w++)
                {
                    Console.Write($"{grades[i, w]}\t");
                }
                Console.WriteLine();
            }



            // Part 4 – Calculate Student Average
            // Calculate and display the average grade for each student.

            Console.WriteLine("\n--- Final Student Report ---");
            Console.WriteLine("Name\t\tMath\tScience\tEnglish\tAverage");
            Console.WriteLine("------------------------------------------------------------");

            for (int i = 0; i < 5; i++)
            {
                int totalSum = 0;


                Console.Write($"{Students[i]}\t\t");

                for (int w = 0; w < 3; w++)
                {

                    Console.Write($"{grades[i, w]}\t");
                    totalSum += grades[i, w];
                }

                // Calculate the average

                double average = (double)totalSum / 3;


                Console.WriteLine($"{average:F2}");
            }

            Console.WriteLine("------------------------------------------------------------");

            // Part 5 – Jagged Array
            //Create a jagged array where each student can have a different number of subjects. Display the
            //number of subjects and grades for each student.

            int[][] jaggedGrades = new int[5][];

            for (int i = 0; i < jaggedGrades.Length; i++)
            {
                Console.Write($"How many subjects does Student {i + 1} have? ");
                int subCount = Convert.ToInt32(Console.ReadLine());

                jaggedGrades[i] = new int[subCount];

                for (int j = 0; j < subCount; j++)
                {
                    Console.Write($"  Enter grade for subject {j + 1}: ");
                    jaggedGrades[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //  Display the data
            Console.WriteLine("\n--- Jagged Array Student Report ---");
            for (int i = 0; i < jaggedGrades.Length; i++)
            {
                Console.Write($"Student {i + 1} ({jaggedGrades[i].Length} subjects): ");

                for (int j = 0; j < jaggedGrades[i].Length; j++)
                {
                    Console.Write(jaggedGrades[i][j] + " ");
                }
                Console.WriteLine();

            }

            //  Part 6 – Search for Student
            //Ask the user to enter a student name.If found, print the index of the student.If not found, display a
            //message saying the student was not found.

            Console.WriteLine("\n------------------------------------------------------");
            Console.Write("Enter the name of the student you want to search for: ");
            string searchName = Console.ReadLine();

            bool isFound = false;

            for (int i = 0; i < Students.Length; i++)
            {

                if (Students[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Student '{searchName}' was found at index: {i}");
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"The student '{searchName}' was not found in the system.");
            }


            //  Part 7 – Find Highest Grade
            //Search through all grades and display the highest grade in the system.

            int highestGrade = grades[0, 0];
            for (int i = 0; i < 5; i++) 
            {
                for (int w = 0; w < 3; w++) 
                {               
                    if (grades[i, w] > highestGrade)
                    {
                        highestGrade = grades[i, w];
                    }
                }
            }

            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine($"The highest grade recorded in the system is: {highestGrade}");


            Console.WriteLine("\n------------------------------------------------------");



            // Bonus Tasks(Optional)
            //1.Sort students alphabetically.
            Array.Sort(Students);

            Console.WriteLine("\nSorted Students:");
            foreach (string name in Students)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("------------------------------------------------------------");

            //2.Find the student with the highest average.

            double bestAvg = 0;
            string topStudent = "";

            for (int i = 0; i < 5; i++)
            {
                int sum = 0;

                for (int j = 0; j < 3; j++)
                {
                    sum += grades[i, j];
                }

                double avg = (double)sum / 3;

                if (avg > bestAvg)
                {
                    bestAvg = avg;
                    topStudent = Students[i];
                }
            }
            Console.WriteLine($"\nTop Student: {topStudent} with the highest average: {bestAvg:F2}");
            Console.WriteLine("------------------------------------------------------------");

            //3.Count how many students passed(grade >= 50).

            int passed = 0;

            for (int i = 0; i < 5; i++)
            {
                bool ok = true;

                for (int j = 0; j < 3; j++)
                {
                    if (grades[i, j] < 50)
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok)
                {
                    passed++;
                }
            }

            Console.WriteLine("\nPassed Students: " + passed);


            #endregion
        }
    }
}
        

    

>>>>>>> 841c075925cb6227d979a0b25f92d31880cd5bb7
