using EnumComposition.Entities;
using EnumComposition.Entities.Enums;

namespace EnumComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth date: dd/MM/YYYY ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data: ");
            Console.WriteLine("Enter status: ");
            DateTime moment = DateTime.Now;
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(moment, status, client);
            Console.WriteLine("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());
            for(int i = 0; i < items; i++)
            {
                Console.WriteLine("Product name: ");
                string productname = Console.ReadLine();
                Console.WriteLine("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productname,price);
                OrderItem orderItem = new OrderItem(quantity,price,product);
                order.AddItem(orderItem);
            }
            Console.WriteLine(order);

        }
    }
}   