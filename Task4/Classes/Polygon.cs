using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorphism
{
    public abstract class Polygon
    {
        public int NumberOfSides { get;  set; }
        public double SideLength { get;  set; }
        public virtual double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public abstract double GetArea();
        
        

        protected Polygon(int numberOfSides, double sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }
        
    }
}