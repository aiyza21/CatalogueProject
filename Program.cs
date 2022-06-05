using System;
using Newtonsoft.Json;

namespace CatalogueProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static List<Products> theCatalog = new List<Products>();
        public static string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Catalogs");
        public static string filePath = Path.Combine(folderPath, "Def_Catalog.json");
        public static string readData = File.ReadAllText(Path.Combine(folderPath, "Def_Catalog.json"));

        static void Main(string[] args)
        {
            Store.Structure();

            theCatalog = JsonConvert.DeserializeObject<List<Products>>(readData);

            Menu.MenuOption();

            Options.Save();
        }

    }
}