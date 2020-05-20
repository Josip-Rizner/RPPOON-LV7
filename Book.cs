using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV7
{
    class Book : IItem
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Book(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return "Book: " + this.Name + " " + Environment.NewLine + " -> Price: " + this.Price;
        }
        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
