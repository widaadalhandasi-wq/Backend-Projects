using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SimpleECommerce
{
    // 1. Product Structure
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString() => $"ID: {Id} | Name: {Name} | Price: {Price:C} | Stock: {Quantity}";
    }

    class Program
    {
        // 2. Data Storage
        static List<Product> products = new List<Product>();
        static List<Product> cart = new List<Product>();
        static Stack<string> orderHistory = new Stack<string>(); //  Track orders using Stack
        const string FilePath = "inventory.txt";

        static void Main(string[] args)
        {
            // 10. File Handling: Load data on startup
            LoadData();

            bool running = true;
            while (running)
            {
                // 3. Menu System
                Console.WriteLine("\n--- E-Commerce Menu ---");
                Console.WriteLine("1. Add Product\n2. View All Products\n3. Search Product\n4. Add to Cart\n5. View Cart\n6. Checkout\n7. Exit");
                Console.Write("Select an option: ");
                string input = Console.ReadLine();

                // 8. Exception Handling
                try
                {
                    switch (input)
                    {
                        case "1": AddProduct(); break;
                        case "2": ViewProducts(); break;
                        case "3": SearchMenu(); break;
                        case "4": AddToCartFlow(); break;
                        case "5":
                            Console.WriteLine("\n--- Your Cart ---");
                            DisplayCartRecursive(0); // 7. Recursion
                            break;
                        case "6": Checkout(); break;
                        case "7": SaveData(); running = false; break;
                        default: Console.WriteLine("Invalid choice."); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        // 4. Methods: AddProduct
        static void AddProduct()
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            //  Validation 
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Error: Name cannot be empty!");
                return; // Stop the method execution
            }

            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    Console.WriteLine("Error: Name must contain letters and spaces only!");
                    return;
                }
            }

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            int id;
            if (products.Count > 0)
            {
                id = products.Max(p => p.Id) + 1;
            }
            else
            {
                id = 1;
            }
            products.Add(new Product { Id = id, Name = name, Price = price, Quantity = qty });
        }

        //ViewProducts()
        static void ViewProducts()
        {
            Console.WriteLine("\n--- Inventory ---");
            if (products.Count == 0) Console.WriteLine("Inventory is empty.");
            products.ForEach(p => Console.WriteLine(p));
        }

        //SearchProduct(int id)
        static void SearchMenu()
        {
            Console.Write("Search by (1) ID or (2) Name? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Enter ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                // 6. Use 'out' parameter
                if (TryGetProduct(id, out Product p)) Console.WriteLine(p);
                else Console.WriteLine("Product not found.");
            }
            else
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                SearchProduct(name); // 5. Method Overloading
            }
        }

        //  Method Overloading (Search by ID)
        static bool TryGetProduct(int id, out Product product)
        {
            product = products.Find(p => p.Id == id);
            return product != null;
        }

        //  Method Overloading (Search by Name)
        static void SearchProduct(string name)
        {
            var results = products.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
            if (results.Count > 0) results.ForEach(p => Console.WriteLine(p));
            else Console.WriteLine("No products match that name.");
        }

        //AddToCart(int productId, int quantity
        static void AddToCartFlow()
        {
            Console.Write("Enter Product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            AddToCart(id, qty);
        }

        static void AddToCart(int productId, int quantity)
        {
            if (TryGetProduct(productId, out Product p))
            {
                if (p.Quantity >= quantity)
                {
                    // 6. Use 'ref' to update quantity
                    UpdateStock(ref p, -quantity);
                    cart.Add(new Product { Id = p.Id, Name = p.Name, Price = p.Price, Quantity = quantity });
                    Console.WriteLine("Added to cart!");
                }
                else throw new Exception("Insufficient stock available!");
            }
            else throw new Exception("Product ID not found!");
        }

        static void UpdateStock(ref Product p, int change)
        {
            p.Quantity += change;
        }

        // 7. Recursion instead of loops
        static void DisplayCartRecursive(int index)
        {
            if (index >= cart.Count) return;
            // 9. String Interpolation
            Console.WriteLine($"- {cart[index].Name} | Qty: {cart[index].Quantity} | Subtotal: {cart[index].Price * cart[index].Quantity:C}");
            DisplayCartRecursive(index + 1);
        }

        static void Checkout()
        {
            if (cart.Count == 0) { Console.WriteLine("Your cart is empty."); return; }

            double total = cart.Sum(p => p.Price * p.Quantity);

            // Bonus: Discount System
            if (total > 100)
            {
                Console.WriteLine("10% discount applied for orders over $100!");
                total *= 0.9;
            }

            Console.WriteLine($"Total Amount: {total:C}");
            orderHistory.Push($"Order: {DateTime.Now} - Total: {total:C}");
            cart.Clear();
            Console.WriteLine("Checkout successful!");
        }

        // 10. File Handling 
        static void SaveData()
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                foreach (var p in products)
                {
                    sw.WriteLine($"{p.Id},{p.Name},{p.Price},{p.Quantity}");
                }
            }
            Console.WriteLine("Data saved to file.");
        }

        static void LoadData()
        {
            if (!File.Exists(FilePath)) return;
            using (StreamReader sr = new StreamReader(FilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    products.Add(new Product
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Price = double.Parse(parts[2]),
                        Quantity = int.Parse(parts[3])
                    });
                }
            }
        }
    }
}