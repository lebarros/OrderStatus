using System;
using OrderStatus.Entities.Enums;
using OrderStatus.Entities;
using System.Globalization;

namespace OrderStatus {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("e-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            Status status = Enum.Parse<Status>(Console.ReadLine());
            DateTime currentTime = DateTime.Now;
            Client client = new Client(name, email, birth);

            Order order = new Order(currentTime, status, client);
            
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++) {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                string itemName = Console.ReadLine();
                Console.Write("Product Price: ");
                double prodPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtde = int.Parse(Console.ReadLine());

                Product prod = new Product(itemName,prodPrice);
                OrderItem ord = new OrderItem(qtde, prodPrice, prod);

                order.AddItem(ord);
            }
            Console.WriteLine();
            Console.WriteLine(order.ToString());
            Console.WriteLine("Total Price: $"+order.total());

            

        }
    }
}
