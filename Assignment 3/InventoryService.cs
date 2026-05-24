using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class InventoryService
    {
        public static List<Product> LoadFromCSV(string filePath)
        {
            List<Product> products = new List<Product>();

            if (!File.Exists(filePath)) return products;

            var lines = File.ReadAllLines(filePath).Skip(1);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',').Select(p=> p.Trim()).ToArray();

                if (parts.Length >= 5)
                {
                    try
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        string brand = parts[2];
                        decimal price = decimal.Parse(parts[3]) / 100m;
                        int quantity = int.Parse(parts[4]);

                        products.Add(new Product(id, name, brand, price, quantity));
                    }
                    catch (Exception ex) 
                    {
                        System.Diagnostics.Debug.WriteLine($"Skipping bad row: {line} | {ex.Message}");
                    }
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
                    string line = $"{p.ProductID}, {p.ProductName},{p.ProductBrand},{p.ProductPrice * 100},{p.ProductQuantity}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}
