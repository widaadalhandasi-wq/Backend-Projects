using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace project01
{
    #region SOLID Principles Implementation

    // Interface Segregation & Open/Closed Principle
    public interface IMessage
    {
        void Send();
    }

    public class Email : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Email Sent successfully.");
        }
    }

    public class SMS : IMessage
    {
        public void Send()
        {
            Console.WriteLine("SMS Sent successfully.");
        }
    }

    // Dependency Inversion Principle
    public class Notification
    {
        private readonly IMessage _message;

        // Constructor Injection
        public Notification(IMessage m)
        {
            _message = m;
        }

        public void Notify()
        {
            _message.Send();
        }
    }
    #endregion

    internal class Program
    {
        // Only one Main method is allowed. 
        // We use "async Task Main" to allow 'await' inside it.
        static async Task Main(string[] args)
        {
            // --- 1. Testing SOLID Principles ---
            Console.WriteLine("--- Testing SOLID Logic ---");

            IMessage email = new Email();
            Notification n1 = new Notification(email);
            n1.Notify();

            IMessage sms = new SMS();
            Notification n2 = new Notification(sms);
            n2.Notify();

            Console.WriteLine();

            // --- 2. Testing Async Logic ---
            Console.WriteLine("--- Testing Async Logic ---");
            Console.WriteLine("Hello before method");

            // This waits for the 2 seconds delay without freezing the execution thread
            string num = await GetNumber();

            Console.WriteLine(num);
            Console.WriteLine("Hello after method");
        }

        #region Async Methods
        static async Task<string> GetNumber()
        {
            // Simulates an I/O operation (like fetching from a database)
            await Task.Delay(2000);
            return "Hello from async method (Task completed)";
        }
        #endregion
    }
}