using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal static class InventoryService
    {
        public static List<Product> LoadFromCSV(string filepath)
        {
            List<Product> products = new List<Product>();

            if (!File.Exists(filepath)) return products;

            var lines = File.ReadAllLines(filepath).Skip(1);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 4)
                {
                    try
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        string brand = parts[2];
                        decimal price = decimal.Parse(parts[3]) / 100m;
                        int quantity = 0;

                        products.Add(new Product(id, name, brand, price, quantity));
                    }
                    catch { }
                }
            }
            return products;
        }
        public static void SaveToCSV(string filepath, List<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.WriteLine("ProductID, ProductName, ProductBrand, Price, Quantity");

                foreach (var p in products)
                {
                    string line = $"{p.ProductID}, {p.ProductName}, {p.ProductPrice}, {p.ProductBrand}, {p.ProductQuantity}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}
