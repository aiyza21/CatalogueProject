using System;
using Newtonsoft.Json;

namespace CatalogueProject
{
    public abstract class Products
    {
        
            public double Price { get; set; } //give a get/setter 
            public string Name { get; set; }
            public string Description { get; set; }
            public double ProductPrice { get; set;}
            public double GST { get { return CalculateTax(ProductPrice); } set { } }
            public double TotalPrice { get { return ProductPrice + CalculateTax(ProductPrice); } set { } }
            public bool is_Movie { get; set; }


        public virtual double CalculateTax(double price)
            {
            return price * 0.1;

            }

        public static double totalGST()
        {
            double totaltax = 0;
            foreach (var item in Program.theCatalog)
            {
                totaltax += CalculateTax(item.ProductPrice);
            }
            return totaltax;
        }

    }
}

