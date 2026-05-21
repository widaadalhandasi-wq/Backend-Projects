using EntityFrameWork2.Data;
using EntityFrameWork2.Models;

namespace EntityFrameWork2
{
    internal class Program
    {
        static void Main(string[] args)

        {

            AppDbContext Context=new AppDbContext();

            //Add Departments:

            Departments Depts01 = new Departments()
            {
                Name = "HR"
            };

            Departments Depts02 = new Departments()
            {
                Name = "FINANCE"
            }; 
            Departments Depts03 = new Departments()
            {
                Name = "PR"
            };

            Context.Departments.Add(Depts01);
            Context.Departments.Add(Depts02);
            Context.Departments.Add(Depts03);
            Context.SaveChanges();

            //Add Students:
            Student Std01 = new Student()
            {
                Name = "Widaad",
                Age = 27,
                Departments = Depts01

            };
            Student Std02 = new Student()
            {
                Name = "Ebtisaam",
                Age = 27,
                Departments = Depts02

            };
            Student Std03 = new Student()
            {
                Name = "Fathya",
                Age = 22,
                Departments = Depts03

            };
            Student Std04 = new Student()
            {
                Name = "Alzahra",
                Age = 20,
                Departments = Depts01

            };
            Student Std05 = new Student()
            {
                Name = "Ahlam",
                Age = 30,
                Departments = Depts02

            };
            Context.Students.Add(Std01);
            Context.Students.Add(Std02);
            Context.Students.Add(Std03);
            Context.Students.Add(Std04);
            Context.Students.Add(Std05);
            Context.SaveChanges();

            Console.WriteLine("========================================");
            Console.WriteLine("Student Name   |   Department Name");
            Console.WriteLine("========================================");

            // Fetch students and read the department name for each student
            var result = Context.Students.Select(s => new
            {
                StudentName = s.Name,
                DepartmentName = s.Departments != null ? s.Departments.Name : "No Department"
            }).ToList();

            // print the result in console
            foreach (var item in result)
            {
                // PadRight(14) is used to set a fixed width so the table appears aligned and neat
                Console.WriteLine($"{item.StudentName? .PadRight(14)} |   {item.DepartmentName}");
            }

        }
    }
}
