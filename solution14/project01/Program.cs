namespace project01
{
    internal class Program
    {
        //Method Ovveriding

        //class Parent
        //{
        //    // Function 1
        //    public virtual void Work()
        //    {
        //        Console.WriteLine("Parent is working");
        //    }

        //    // Function 2
        //    public void Sleep()
        //    {
        //        Console.WriteLine("Parent is sleeping");
        //    }

        //    // Function 3
        //    public virtual void Eat()
        //    {
        //        Console.WriteLine("Parent is eating");
        //    }
        //}

        //class child: Parent
        //{
        //    public override void Work()
        //    {
        //        Console.WriteLine("Child is studying");

        //    }
        //    public override void Eat()
        //    {
        //        Console.WriteLine("Child is eating pizza");
        //    }

        //}

        //static void Main(string[] args)
        //{
        //    child c= new child();
        //    Console.WriteLine("The Child ovveride 2 function from her father which are:");
        //    c.Eat();    
        //    c.Work();

        //}



        //encapsulation :


        class Account
        {
            // متغير خاص لا يمكن الوصول إليه مباشرة من خارج الكلاس
            private double balance;

            // Property للتحكم في قراءة وتعديل الرصيد
            public double Balance
            {
                // ترجع قيمة الرصيد
                get
                {
                    return balance;
                }

                // تعيين قيمة جديدة للرصيد
                set
                {
                    // التحقق أن الرصيد ليس سالباً
                    if (value >= 0)
                    {
                        balance = value;
                    }
                    else
                    {
                        Console.WriteLine("الرصيد لا يمكن أن يكون سالباً");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Account acc = new Account();

            // تعيين قيمة صحيحة
            acc.Balance = 5000;

            // قراءة الرصيد
            Console.WriteLine("الرصيد الحالي: " + acc.Balance);

            // محاولة إدخال قيمة سالبة
            acc.Balance = -1000;

            // الرصيد لن يتغير
            Console.WriteLine("الرصيد بعد المحاولة: " + acc.Balance);
        }
    }




    //Polymorphism
    class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing Shape");
            }
        }

        // class Circle
        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing Circle");
            }
        }

        // class Rectangular
        class Rectangular : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing Rectangular");
            }
        


        
            static void Main(string[] args)
        {
            Shape s1 = new Circle();
            Shape s2 = new Rectangular();

            //same function but differen action
            s1.Draw();
            s2.Draw();
        }
    }
}