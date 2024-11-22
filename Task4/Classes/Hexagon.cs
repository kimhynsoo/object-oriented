using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorphism
{
    public class Hexagon : Polygon
    {

        double Apothem { get; set; }
        public Hexagon(int numberOfSides, double sideLength, double apothem) : base(numberOfSides, sideLength)
        {
            Apothem = apothem;
        }

        

        public override double GetPerimeter()
        {
            return base.GetPerimeter();
        }

        public override double GetArea()
        {
            return Apothem * GetPerimeter() / 2;
        }






    }
}