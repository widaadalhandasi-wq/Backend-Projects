namespace project01
{
    internal class Program
    {
        //class, object, properties...
        //class Car
        //{
        //    public string Name;
        //    public string Color;
        //    public int Model_year;

        //    private int temp;
        //    public int speed
        //    {

        //        get { return temp; }
        //        set
        //        {
        //            if (value > 0)
        //                temp = value;
        //            else
        //            {
        //                Console.WriteLine("Speed must be grater than zero");
        //                temp = 0;
        //            }
        //        }
        //    }
        //    public void Drive()
        //    {
        //        Console.WriteLine("car is moving");

        //    }

        //    static void Main(string[] args)
        //    {
        //        Car myCar = new Car();
        //        myCar.Name = "Honda Acord";
        //        myCar.Color = "Black";
        //        myCar.Model_year = 1998;
        //        Console.WriteLine("Enter speed value:");
        //        int speed=Convert.ToInt32(Console.ReadLine());
        //        myCar.speed=speed;
        //        myCar.Drive();
        //        Console.WriteLine("Name: " + myCar.Name);
        //        Console.WriteLine("Color: " +myCar.Color);
        //        Console.WriteLine("Model-Year: " +myCar.Model_year);
        //        Console.WriteLine("Final Speed: " +myCar.speed);

        //    }

            //---------------------------------------------------------------------------------------------------------------------

            //Constructor

            public class Product
    {
        public string Name;
        public double Price;

        // This is the Constructor
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Console.WriteLine("Product initialized.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Item: {Name} | Price: {Price:C}");
        }
    }


    
        static void Main()
        {
            // The constructor is called here using the 'new' keyword
            Product myItem = new Product("Laptop", 850.50);

            myItem.DisplayInfo();
        }
    }

}

    
