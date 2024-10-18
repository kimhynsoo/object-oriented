using StoreApp.Classes;
using System.Text.Json;

Product p1 = new Product(30);
p1.Name = "Cookies";
p1.Price = 5.32;

Console.WriteLine(p1);

p1.IncreaseStock(10);
Console.WriteLine(p1);

p1.DecreaseStock(10);
Console.WriteLine(p1);

String jsonProduct = JsonSerializer.Serialize(p1);
Console.WriteLine($"JSON Product: {jsonProduct}");
File.WriteAllText("product.json", jsonProduct);

Customer c1 = new Customer()
{
    Id = 1,
    Name = "Mary",
    City = "Madrid"
};

Customer c2 = new Customer()
{
    Id = 2,
    Name = "Martin",
    City = "Zlin"
};

List<Customer> list = new List<Customer>();
list.Add(c1);
list.Add(c2);

string jsonCustomers = JsonSerializer.Serialize(list);
Console.WriteLine($"JSON Customer list : {jsonCustomers}");
File.WriteAllText("customers.json",jsonCustomers);