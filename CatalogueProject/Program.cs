using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static string TechData;
            //static Catalogue<Technology> TechCatalogue;
            //static string ClothingData;
            //static Catalogue<Clothing> ClothingCatalogue;

            string command = string.Empty;
            //The menu should have:
            // to initiate a response from the user e.g press 1 to start
            while (command != "5")
            {
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("Select a number from the following menu to initiate the following commands: ");
                Console.WriteLine("1.Add a new product to a catalogue");
                
                
                Console.WriteLine("2.Remove a product");
                Console.WriteLine("3.Remove a catalogue");
                Console.WriteLine("4.View a catalogue");
                //Console.WriteLine("1.Create Catalogue");
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        {
                            Console.WriteLine("You have selected to 'Create a Catalogue'.");
                            Console.WriteLine(); ;
                            break;

                        }

                    case "2":
                        {
                            Console.WriteLine("You have selected to 'View your Catalogue'.");
                            Console.WriteLine();
                            Console.WriteLine("1 - View Technology Catalogue");
                            Console.WriteLine("2 - View clothing Catalogue");

                            if (Console.ReadLine() == "1")
                            {
                                techcatalogue.viewCatalogue(techcatalogue.list);
                                break;
                            }
                        }
                    case "3":
                        {
                            Console.WriteLine("You have selected to 'Add a new product to catalogue'.");
                            Console.WriteLine();
                        }
                    case "4":
                        {
                            Console.WriteLine("You have selected to 'remove a product'.");
                            Console.WriteLine();
                        }
                    case "5":
                        {
                            Console.WriteLine("You have selected to 'remove a catalogue'.");
                            Console.WriteLine();
                        }
                }
            }

        }


        ////Create Catalogue(optional)
        ////View a catalogue

        ////Add a new product to a catalogue
        ////Remove a product
        ////Remove a catalogue

    }
}



// note: foreach (var user in users0
// console.writeline($"user {user.key} {user.value.firstman} {user.value.lastname}");