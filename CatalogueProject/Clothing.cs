using System;
namespace CatalogueProject
{
	public class Clothing : Products
	{
        public float Size { get => _size; }
        public float _size;

        public Clothing(double price, float size, string name, string description)
        {

            _price = price;
            _size = size;
            _name = name;
            _description = description;
        }


        public static Clothing CreateClothing(double price, float size, string name, string description)
        {
            Clothing Clothes = new Clothing(price, size, name, description);
            return Clothes;

        }

        public override string ToString()
        {
            return $" Clothing Price: {Price}, Clothing Size: {Size},Clothing item: {Name},Clothing description: {Description}";
        }
    }
}

