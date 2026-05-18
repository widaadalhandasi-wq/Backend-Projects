using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> stds = new List<Student>()
        {
            new Student { Name = "ebtesam", Age = 27 },
            new Student { Name = "doodah", Age = 27 },
            new Student { Name = "fatahia", Age = 50 },
            new Student { Name = "malak", Age = 90 },
            new Student { Name = "ahlam", Age = 100 }
        };

        Console.WriteLine("================ MAIN LINQ COMMANDS ================\n");

        // ------------- 1- Where (تصفية البيانات بناءً على شرط معين) --------------------/
        Console.WriteLine("--- 1- Where (Students older than 75): ---");
        var result1 = stds.Where(x => x.Age > 75);
        foreach (var s in result1)
        {
            Console.WriteLine($"Name: {s.Name}, Age: {s.Age}");
        }
        Console.WriteLine();


        ////// ------------- 2- Where + Select (تصفية البيانات واختيار عمود أو خاصية معينة فقط) --------------------/
        Console.WriteLine("--- 2- Where + Select (Names of students older than 50): ---");
        var result2 = stds.Where(x => x.Age > 50).Select(x => x.Name);
        foreach (var name in result2)
        {
            // هنا name هو string مباشرة وليس Student، لذلك نطبع المتغير نفسه بدون كتابة name.Name
            Console.WriteLine(name);
        }
        Console.WriteLine();


        //// ------------------- 3- Select (اختيار خصائص معينة من الجدول، هنا اخترنا الأسماء فقط) -------------------/
        Console.WriteLine("--- 3- Select (All student names): ---");
        var result3 = stds.Select(x => x.Name);
        foreach (var name in result3)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();


        //// ------------------- 4- OrderBy (ترتيب البيانات تصاعدياً A-Z) --------------------/
        Console.WriteLine("--- 4- OrderBy (Ascending by Name): ---");
        var result4 = stds.OrderBy(x => x.Name);
        foreach (var s in result4)
        {
            Console.WriteLine($"Name: {s.Name}, Age: {s.Age}");
        }
        Console.WriteLine();


        //// ------------------- 5- OrderByDescending (ترتيب البيانات تنازلياً من الأكبر للأصغر) -------------------/
        Console.WriteLine("--- 5- OrderByDescending (Descending by Age): ---");
        var result5 = stds.OrderByDescending(x => x.Age);
        foreach (var s in result5)
        {
            Console.WriteLine($"Age: {s.Age}, Name: {s.Name}");
        }
        Console.WriteLine();


        //// ------------------- 6- FirstOrDefault (إحضار أول عنصر يطابق الشرط، وإذا لم يجده يعيد null) ----------------------/
        Console.WriteLine("--- 6- FirstOrDefault (Search for student with Age = 1): ---");
        var student = stds.FirstOrDefault(x => x.Age == 1);

        // لأن النتيجة عنصر واحد فقط وليس قائمة، نستخدم شرط if للتأكد من وجوده بدلاً من foreach
        if (student != null)
        {
            Console.WriteLine($"Found: {student.Name}");
        }
        else
        {
            Console.WriteLine("No student found with this age (Null).");
        }
        Console.WriteLine();


        //// ---------------------- 7- Count (حساب عدد العناصر الإجمالي أو بناءً على شرط) -------------------------/
        Console.WriteLine("--- 7- Count: ---");
        int total = stds.Count(); // لحساب كل العناصر في القائمة
        int totalFiltered = stds.Count(x => x.Age > 50); // لحساب العناصر التي تطابق الشرط فقط

        Console.WriteLine($"Total number of students: {total}");
        Console.WriteLine($"Number of students older than 50: {totalFiltered}");
        Console.WriteLine();


        //// ------------------- 8- Any (لفحص وجود أي عنصر يطابق الشرط، وتعيد true أو false) ----------------------------/
        Console.WriteLine("--- 8- Any (Check condition): ---");
        bool found = stds.Any(x => x.Age > 60);
        Console.WriteLine($"Is there any student older than 60? {found}");

        Console.WriteLine("\n==================================================");
    }
}