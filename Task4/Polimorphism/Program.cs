using Polimorphism;


Square square = new Square(4, 1.5);
Console.WriteLine("Square Perimeter is "+square.GetPerimeter());

Console.WriteLine("Square Area is " +square.GetArea());

Hexagon hexagon = new Hexagon(6, 1.5, 1.5);
Console.WriteLine("Hexagon Perimeter is "+hexagon.GetPerimeter());
Console.WriteLine("Hexagon Area is " +hexagon.GetArea());