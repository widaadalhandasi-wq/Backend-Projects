using System.Xml.Linq;

namespace project01
{

    internal class Program
    {
        #region Abstraction

        /////////////////////////
        /// Scenario 1 /////////
        ///

        //abstract class Animal()
        //{
        //    public abstract void sound();
        //    public abstract void Eat();
        //}

        //class Dog : Animal
        //{
        //    public override void sound()
        //    {
        //        Console.WriteLine("Barking");
        //    }
        //    public override void Eat()
        //    {
        //        Console.WriteLine("Meat");
        //    }

        //}
        /////////////////////////
        /// Scenario 2 /////////
        /// 


        //    abstract class BAnkAccount
        //{
        //    public abstract void Withdraw();
        //}

        //class Saving : BAnkAccount
        //{
        //    public override void Withdraw()
        //    {
        //        Console.WriteLine("Saving ");
        //    }
        //}

        //class Current : BAnkAccount
        //{
        //    public override void Withdraw()
        //    {
        //        Console.WriteLine("Current ");
        //    }
        //}
        #endregion

        #region Array and List

        //     //Array and List:
        //     class student
        //    {
        //        public string Name;
        //        public int Grade;

        //        public void Display()
        //        {
        //            Console.WriteLine($"Name: {Name} , Grade:{Grade}");
        //        }

        //    }
        #endregion

        //----------------------------------------------------------------------------

        #region Declearing object with parent class and interface

        //class
        //class Animal
        //{
        //    public void eat()
        //    {
        //        Console.WriteLine("food");
        //    }

        //}
        //class Cat : Animal
        //{
        //    public void sound()
        //    {
        //        Console.WriteLine("Meawww");
        //    }
        //}

        //interface

        //interface IAnimal
        //{
        //    void eat();
        //}
        //class dog : IAnimal
        //{
        //    public void eat()
        //    {
        //        Console.WriteLine("meat");
        //    }
        //}

        #endregion

        //----------------------------------------------------------------------------


        #region Assosiation function
        //public class Teacher
        //{
        //    public string Name { get; set; }

        //    public void Teach(Student s)
        //    {
        //        Console.WriteLine($"{Name} is teaching {s.Name}");
        //    }
        //}

        //public class Student
        //{
        //    public string Name { get; set; }
        //}



        #endregion
        //----------------------------------------------------------------------------

        #region Aggregation Function
        // //1. Define the Employee Class
        //public class Emp
        //{
        //    public string Name { get; set; }
        //}

        //// 2. Define the Department Class
        //public class Dep
        //{
        //    public string Name { get; set; }
        //    public List<Emp> Emps { get; set; }

        //    // Constructor to initialize the Department name and the List
        //    public Dep(string name)
        //    {
        //        Name = name;
        //        Emps = new List<Emp>();
        //    }
        //}
        #endregion

        //----------------------------------------------------------------------------

        #region Composition
        //public class Room
        //{
        //    public string Name { get; set; }

        //    public Room(string name)
        //    {
        //        Name = name;
        //    }
        //}

        //public class House
        //{
        //    public string Address { get; set; }

        //    // The House "owns" the Rooms
        //    private List<Room> rooms = new List<Room>();

        //    public House(string address)
        //    {
        //        Address = address;

        //        // Composition: The House creates the Rooms
        //        rooms.Add(new Room("Kitchen"));
        //        rooms.Add(new Room("Bedroom"));
        //        rooms.Add(new Room("Setting Room"));
        //    }
        //    public void ShowRooms()
        //    {
        //        Console.WriteLine($"House at {Address}:");
        //        foreach (var r in rooms)
        //        Console.WriteLine($"- {r.Name}");
        //    }
        //}
        #endregion

        static void Main(string[] args)
        {

            #region Abstraction

            ////BAnkAccount s = new Saving();
            ////BAnkAccount c = new Current();

            ////s.Withdraw();
            ////c.Withdraw();
            #endregion
            //----------------------------------------------------------------------------


            #region Array
            //student[] students = new student[2];
            //students[0] = new student();
            //students[0].Name= "Basooom";
            //students[0].Grade = 99;

            //students[1] = new student();
            //students[1].Name = "Widaad";
            //students[1].Grade = 98;

            //foreach (student s in students) {

            //s.Display();    
            //}



            #endregion
            //----------------------------------------------------------------------------


            #region List
            //List<student> StudentList = new List<student>();
            //StudentList.Add(new student { Name="Fathia", Grade=96});
            //StudentList.Add(new student { Name="Malak", Grade=95});
            //StudentList.Add(new student { Name="Maya", Grade=96});

            //foreach (student x in StudentList) { 
            //x.Display();
            //}

            #endregion
            //----------------------------------------------------------------------------


            #region Declearing object with parent class and interface

            //Animal a= new Cat(); 
            //a.eat();

            //IAnimal w = new dog();
            //w.eat();

            #endregion

            #region Assosiation function
            //Teacher T = new Teacher { Name = "Widaad" };    
            //Student s = new Student { Name = "Basoom" };    
            //T.Teach(s);
            #endregion
            //----------------------------------------------------------------------------


            #region Aggregation Function

            //// 1. Create the employee using 'E'
            //Emp E = new Emp { Name = "Widaad" };
            //Emp E2 = new Emp { Name = "Basoom" };

            //// 2. Create the department using 'D'
            //Dep D = new Dep("IT");

            //// 3. Add 'E' to 'D's list (Emps)
            //D.Emps.Add(E);
            //D.Emps.Add(E2);

            //// 4. Print using the correct variable 'D'
            //    Console.WriteLine($"Department Name: {D.Name}");
            //    Console.WriteLine($"Employee Name is :{E.Name}");
            //    Console.WriteLine($"Employee Name is :{E2.Name}");


            #endregion
            //----------------------------------------------------------------------------


            #region Composition

                //House myHouse = new House("123 C# Street");
                //myHouse.ShowRooms();
            
            #endregion
        }
    }
}
