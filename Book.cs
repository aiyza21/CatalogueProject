using System;
using Newtonsoft.Json;

namespace CatalogueProject
{
    public class Book : Products
    {
        public string BookAuthor { get; set; }

        public Book( string name,string author,string description,double price)
        {
            Name = name;
            BookAuthor = author;
            Description = description;
            Price = price;
            is_Movie = false;
        }

            public override string ToString()
            {
                return $"Book detail = Title: {Name} Author {BookAuthor}, Description: {Description}, Price: {Price}";
            }

    }
    

}


