using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueProject
{
    public abstract class Products
    {
        
            public double Price { get => _price; } //give a get/setter 
            public string Name { get => _name; }
            public string Description { get => _description; }
            public string _description;
            public double _price;
            public string _name;

            public virtual double CalculateTax()
            {
                return _price + (_price * 10 / 100);

            }
        

    }
}

