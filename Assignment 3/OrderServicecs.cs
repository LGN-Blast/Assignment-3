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
                writer.WriteLine("OrderID, CustomerName, ProductName, Quantity, Total, Status");

                foreach(o in orders)
                {
                    string line = $"{o.Order}"
                }

            }
        }
    }
}
