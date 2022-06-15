using System.Runtime.CompilerServices;
using System.Globalization;
using Loja.Entities;
using Loja.Entities.Enums;

Console.WriteLine("Enter cliente data:");
System.Console.Write("Name: ");
string name = Console.ReadLine();
System.Console.Write("Email: ");
string email = Console.ReadLine();
System.Console.Write("Birth date (DD/MM/YYYY): ");
DateTime brith = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, brith);

System.Console.WriteLine("Enter order data: ");
System.Console.Write("Status: ");

OrderStatus orderstat = Enum.Parse<OrderStatus>(Console.ReadLine());
Order order = new Order(DateTime.Now, orderstat, client);

System.Console.Write("How many items to this order? ");
int x = int.Parse(Console.ReadLine());

for (var i = 0; i < x; i++)
{
    System.Console.WriteLine($"Enter #{i+1} item data:");
    System.Console.Write("Product name: ");
    string pname = Console.ReadLine();
    System.Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    System.Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product p = new Product(pname, price);
    OrderItem item = new OrderItem(quantity, p);

    order.addItem(item);
}

System.Console.WriteLine("");
System.Console.WriteLine("ORDER SUMMARY:");
System.Console.WriteLine(order.ToString());
