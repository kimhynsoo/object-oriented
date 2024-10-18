//Hyeonsu KIM  A24586

using Car_Info.Classes;

Car c1= new Car();
Console.WriteLine("Enter car model, year, start km, end km, fuel consumption and travel time:");
Console.WriteLine("Model:");
c1.Model = Console.ReadLine();
Console.WriteLine("Year:");
c1.Year = int.Parse(Console.ReadLine());
Console.WriteLine("Start km:");
c1.StartKm = double.Parse(Console.ReadLine());
Console.WriteLine("End km:");
c1.EndKm = double.Parse(Console.ReadLine());
Console.WriteLine("Fuel consumption:");
c1.FuelConsumption = double.Parse(Console.ReadLine());
Console.WriteLine("Travel time:");
c1.TravelTime = double.Parse(Console.ReadLine());

Console.WriteLine($"Trip length: {c1.GetTripLength().ToString("F2")}km");
Console.WriteLine($"Speed: {c1.GetSpeed().ToString("F2")}km/h");
Console.WriteLine($"Fuel Efficiency: {c1.GetFuelEfficiency().ToString("F2")}L per 100km");
Console.WriteLine("Car classification:");
c1.ClassifyCar();

