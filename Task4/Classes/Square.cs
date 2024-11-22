using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorphism
{
    public class Square : Polygon
    {
       public Square(int numberOfSides, double sideLength) : base(numberOfSides, sideLength)
       {
       }

        public override double GetPerimeter()
        {
            return base.GetPerimeter();
        }
        public override double GetArea()
        {
            return SideLength * SideLength;
        }

    }
}