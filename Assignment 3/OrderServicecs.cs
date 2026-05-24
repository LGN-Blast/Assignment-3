using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class OrderServicecs
    {
        public static void SaveToCSV(string filepath, List<Order> orders)
        {
            
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.WriteLine("OrderID,CustomerName,ProductName,Quantity,Total,Status");

                foreach (var o in orders)
                {
                    string line = $"{o.OrderID},{o.CustomerName},{o.ProductName},{o.Quantity},{o.Total},{o.Status}";
                    writer.WriteLine(line);
                }
            }
        }

        public static List<Order> LoadFromCSV(string filepath)
        {
            List<Order> orders = new List<Order>();

            if (!File.Exists(filepath)) return orders;

            var lines = File.ReadAllLines(filepath).Skip(1);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',').Select(p => p.Trim()).ToArray();

                if (parts.Length >= 6)
                {
                    try
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        string prod = parts[2];
                        int qty = int.Parse(parts[3]);
                        decimal total = decimal.Parse(parts[4]);
                        string status = parts[5];

                        orders.Add(new Order(id, name, prod, qty, total, status));
                    }
                    catch
                    {
                    
                    }
                }
            }
            return orders;
        }
    }
}

