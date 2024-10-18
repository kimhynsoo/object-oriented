/* Demo 1 : Imperative Programming 
 We want to calculate the amount to pay for a product, 
 given its unit price, the quantity, discount rate and tax rate.
*/

Console.WriteLine("Enter the product name: ");
string productName = Console.ReadLine();

Console.WriteLine("Enter the unit price: ");
double unitPrice = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the quantity: ");
int quantity = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the discount rate: ");
int discountRate = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the tax rate: ");
int taxRate = int.Parse(Console.ReadLine());

double amountToPay = unitPrice * quantity * (1 - discountRate / 100.0) * (1 + taxRate / 100.0);


Console.WriteLine($"The amount to pay for {quantity} {productName} is {amountToPay:C2}.");

