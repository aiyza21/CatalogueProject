using System;
using Newtonsoft.Json;

namespace CatalogueProject
{
    public class Menu
    {
        public static void MenuOption()
        {
            Console.WriteLine();
            Console.WriteLine("-----MENU-----");
            Console.WriteLine("Select a number from the following menu to initiate the following commands: ");
            Console.WriteLine("1.Add a new product to a catalogue");
            Console.WriteLine("2.Delete product from catalogue");
            Console.WriteLine("3.View a catalogue");
            Console.WriteLine("4.Save and exit");
            Console.WriteLine();
            Console.WriteLine("Press any number 1-4 to pick an option");
            string user_input = Console.ReadLine();

            switch (user_input)
            {

                case "1":
                    {
                        AddProduct();
                        MenuOption();
                        break;
                    }
                case "2":
                    {
                        RemoveProduct();
                        MenuOption();
                        break;
                    }
                case "3":
                    {
                        Options.DisplayCatlog();
                        break;

                    }

                case "4":
                    {
                        break;
                    }

            }
        }

        public static void AddProduct()

        {
            Console.WriteLine("===== Add New Product =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Add Movie");
            Console.WriteLine("3. Exit");
            string user_entry = Console.ReadLine();

            switch (user_entry)
            {

                case "1":
                    {
                        Console.Clear();
                        Options.NewBook();
                        return;
                        break;
                    }
                case "2":
                    {

                        Console.Clear();
                        Options.NewMovies();
                        return;
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        return;
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        return;
                        break;
                    }
            }

        }

        public static void RemoveProduct()
        {

        }
    }
}


