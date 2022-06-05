using System;
using Newtonsoft.Json;

namespace CatalogueProject
{
	public class Options
	{
		public static void DisplayCatlog()
        {
			if (Program.theCatalog.Count == 0)
            {
                Console.WriteLine("There's nothing to display");
                return;
            }

            foreach (Products record in Program.theCatalog)
            {
                Console.WriteLine($"Record#: {Program.theCatalog.IndexOf(record)}");
                Console.WriteLine(record);
            }

            Console.WriteLine($"Total GST of all products = {Products.totalGST():C2}");

        }

        public static void Save()
        {
            string jsonObject = JsonConvert.SerialiseObject(Program.theCatalog.ToArray());
            Console.WriteLine();
            Console.WriteLine("Catalogue updated");
            File.WriteAllText(Program.filePath, jsonObject);
            Program.readData = File.ReadAllText(Path.Combine(Program.folderPath, "Def_Catalog.json"));
        }

        public static void NewBook()
        {
            Console.WriteLine("Enter the details below to add a book to the library:");

            Console.WriteLine("Name of the book: ");
            string? input_name = Console.ReadLine();

            Console.WriteLine("Name of the Author: ");
            string? input_author = Console.ReadLine();

            Console.WriteLine("Add description: ");
            string? input_description = Console.ReadLine();

            Console.WriteLine("Add the price: $ ");
            string? input_price = Console.ReadLine();

            try
            {
                Book NewBook = new Book
                    (
                     name: input_name,
                     author: input_author,
                     description: input_description,
                     price: Convert.ToDouble(input_price)
                    );
                Program.theCatalog.Add(NewBook);
                Options.Save();
            }
            catch
            {
                Console.WriteLine("failed to add");
                Menu.MenuOption();
            }
        }

        public static void NewMovies()
        {
            Console.WriteLine("Enter the details below to add a movie to the gallery:");

            Console.WriteLine("Name of the book: ");
            string? input_name = Console.ReadLine();

            Console.WriteLine("Add rating: ");
            string? input_rating = Console.ReadLine();

            Console.WriteLine("Add description: ");
            string? input_description = Console.ReadLine();

            Console.WriteLine("Add the price: $ ");
            string? input_price = Console.ReadLine();
            try
            {
                Movie NewMovie = new Movie
                    (
                     name: input_name,
                     rating: input_rating,
                     description: input_description,
                     price: Convert.ToDouble(input_price)
                    );
                Program.theCatalog.Add(NewMovie);
                Options.Save();
            }
            catch
            {
                Console.WriteLine("failed to add");
                Menu.MenuOption();
            }
        }

        public static void RemoveProduct(string user_entry)
        {
            if (user_entry == "")
            {
                Menu.MenuOption();
            }

            try
            {
                Console.Clear();
                int entry = Convert.ToInt32(user_entry);
                Program.theCatalog.RemoveAt(entry);
                Console.Clear();
                Console.WriteLine("product removed from catalogue");
                Menu.MenuOption();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid entry");
            }
        }

        public static void DeleteCatalog()
        {
            Console.WriteLine("To Remove product from catalogue, type y");
            string user_entry = Console.ReadLine();

            if (user_entry == "Y")
            {
                Program.theCatalog.Clear();
                Save();
                Program.theCatalog = JsonConvert.DeserializeObject<List<Products>>(Program.readData);
            }
        }
    }
	
}

