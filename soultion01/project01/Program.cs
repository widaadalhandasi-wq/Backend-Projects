namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("please enter first number !");
            int num1= Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("please enter second number !");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( $"Addition: {num1}+{num2}={num1+num2}");

            Console.WriteLine( $"Subtraction: {num1}-{num2}={num1-num2}");

            Console.WriteLine( $"Division: {num1}/{num2}={num1/num2}");

            Console.WriteLine( $"Multiplication: {num1}*{num2}={num1*num2}");






        }
    }
}
