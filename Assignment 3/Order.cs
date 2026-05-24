using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int Quantity {  get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }

        public Order(int orderID, string customerName, string productName, int quantity, decimal total, string status)
        {
            OrderID = orderID;
            CustomerName = customerName;
            ProductName = productName;
            Quantity = quantity;
            Total = total;
            Status = status;
        }
    }
}
