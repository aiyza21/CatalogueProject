using System;
namespace CatalogueProject
{
	public class Technology : Products
    {
            public Technology(double price, string description, string name)
            {
                _price = price;
                _description = description;
                _name = name;
            }
            public static Technology CreateDescription(string name, double price, string description)
            {
            Technology Tech = new Technology(price, description, name);
                return Tech;

            }

            public static void RemoveDescription()
            {

            }

            public override string ToString()
            {
                return $"Technology Price: {Price}, Description: {Description}";
            }

    }
    

}


