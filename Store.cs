using System;
using System.IO;
using Newtonsoft.Json;

namespace CatalogueProject
{
	public class Store
	{
		private static string _truePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProjectCatalog");
		public static string TruePath { get => _truePath; }


		public static void Structure()
        {
			if (!Directory.Exists(TruePath))
            {
                Console.WriteLine("Creating Catalogue folder");
                Directory.CreateDirectory(TruePath);
                Console.WriteLine("creating ", Path.Combine(TruePath, "Stored_Data.json"));
                File.Create(Path.Combine(TruePath, "Stored_Data.json")).Close();
                File.WriteAllText(Path.Combine(TruePath, "Stored_Data.json"), "{}");
            }
            else
            {
                Console.WriteLine("Data stored.");
            }
        }

        public static string[] CatalogFiles = new string[] { };

        public static void CollectCatalogs()
        {
            CatalogFiles = Directory.GetFiles(TruePath, "*.json");
            Console.WriteLine($"getting files from path");
            foreach (var file in CatalogFiles)
            {
                Console.WriteLine(file);
                Console.WriteLine(Path.GetFileName(file));
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }
        }

        public static string CatalogName(int fileIndex)
        {
            return Path.GetFileNameWithoutExtension(Store.CatalogFiles[fileIndex]);
        }
    }
}
	


