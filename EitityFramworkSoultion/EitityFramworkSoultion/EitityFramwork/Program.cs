using System;
using System.Linq;

namespace EitityFramwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext db = new AppDbContext();
            student s1 = new student();
            courses c1 = new courses();
            Passport passport = new Passport();
            Department department = new Department();

            //CRUD PROPERTIES
            {
                // 1. CREATE (إضافة)
                Console.WriteLine("--- Add New Student ---");
                Console.Write("Enter Student Name: ");
                s1.name = Console.ReadLine();
                Console.Write("Enter Student Age: ");
                s1.age = Convert.ToInt32(Console.ReadLine());

                db.Students.Add(s1);
                db.SaveChanges();
                Console.WriteLine("Student Added Successfully!");

                // سطر مضاف: لإيقاف الشاشة لترى نجاح الإضافة
                Console.WriteLine("Press any key to show all students...");
                Console.ReadKey();

                // 2. READ (عرض البيانات)
                Console.WriteLine("\n--- All Students ---");
                var students = db.Students.ToList();
                foreach (var s in students)
                {
                    Console.WriteLine($"ID: {s.id}, Name: {s.name}, Age: {s.age}");
                }

                // سطر مضاف: لإيقاف الشاشة لكي تتمكن من رؤية وقراءة الطلاب المعروضين
                Console.WriteLine("Press any key to proceed to Update...");
                Console.ReadKey();

                // 3. UPDATE (تعديل)
                Console.WriteLine("\n--- Update Student Age ---");
                Console.Write("Enter Student ID to update: ");
                int updateId = Convert.ToInt32(Console.ReadLine());
                var studentToUpdate = db.Students.Find(updateId);

                if (studentToUpdate != null)
                {
                    Console.Write("Enter New Age: ");
                    studentToUpdate.age = Convert.ToInt32(Console.ReadLine());
                    db.SaveChanges();
                    Console.WriteLine("Updated!");
                }
                else
                {
                    Console.WriteLine("Student not found!");
                }

                // سطر مضاف: لإيقاف الشاشة لرؤية نتيجة التعديل
                Console.WriteLine("Press any key to proceed to Delete...");
                Console.ReadKey();

                // 4. DELETE (حذف)
                Console.WriteLine("\n--- Delete Student ---");
                Console.Write("Enter Student ID to delete: ");
                int deleteId = Convert.ToInt32(Console.ReadLine());
                var studentToDelete = db.Students.Find(deleteId);

                if (studentToDelete != null)
                {
                    db.Students.Remove(studentToDelete);
                    db.SaveChanges();
                    Console.WriteLine("Deleted!");
                }
                else
                {
                    Console.WriteLine("Student not found!");
                }

                // سطر مضاف: لمنع الكونسول من الإغلاق فوراً في نهاية البرنامج
                Console.WriteLine("\nProgram finished. Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}