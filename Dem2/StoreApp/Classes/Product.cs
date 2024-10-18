using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    internal class Product
    {
        public string Name{get; set;}
        public double Price;
        private int Stock;

        public Product(int stock)
        {
            Stock = stock;
        }

        public Product(string name, double price, int stock)
        {
            this.Name = name;
            Price = price;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Stock : {Stock}";

        }

        public void IncreaseStock(int quantity)
        {
            Stock += quantity;
        }

        public void DecreaseStock(int quantity){
            Stock -= quantity;
        }

        
    }
}