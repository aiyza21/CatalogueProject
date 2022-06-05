using System;
using Newtonsoft.Json;

namespace CatalogueProject
{
	public class Movie : Products
	{
        public string MovieRating { get; set; }

        public Movie (double price, string rating, string name, string description)
        {

            Name = name;
            MovieRating = rating;
            Description = description;
            Price = price;
            is_Movie = true;
        }


        public override string ToString()
        {
            return $"Movie detail = Title: {Name}, Rating {MovieRating}, Description: {Description}, Price: {Price}";
        }

    }
}

