using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Order_Page : UserControl
    {
        private BindingList<Order> _orderList = new BindingList<Order>();
        private BindingSource _bindingSource = new BindingSource();

        private int _nextID = 2000;

        public Order_Page()
        {
            InitializeComponent();

            //this.Load += Orders_Load();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _orderList;
            dgvOrders.DataSource = _bindingSource;

            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;

            cmbStatus.Items.AddRange(new string[] { "Pending, Confirmed, Shipped, Cancelled" });
            cmbStatus.SelectedIndex = 0;

            //LoadProducts();
        }

        private void LoadProducts(object sender, EventArgs e)
        {
            string filepath = System.IO.Path.Combine(Application.StartupPath, "Products.csv");
            var products = InventoryService.LoadFromCSV(filepath);

            cmbProduct.Items.Clear();
            foreach (var p in products)
            {
                cmbProduct.Items.Add(p.ProductName);
            }
            if (cmbProduct.Items.Count > 0)
            {
                cmbProduct.SelectedIndex = 0;
            }

        }

        private bool ValidateInputs()
        {
           if (string.IsNullOrWhiteSpace(txtCustomer.Text))
            {
                MessageBox.Show("Please Enter A Customer Name");
                return false;
            }

           if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Please Select A Product");
                return false;
            }

           if (!int.TryParse(txtOrderQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please Enter A Valid Quantity");
                return false;
            }

            return true;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string customer = txtCustomer.Text;
            string product = cmbProduct.SelectedIndex.ToString();
            int quantity = int.Parse(txtOrderQuantity.Text);
            decimal price = GetProductPrice(product);
            decimal total = price * quantity;
            string status = cmbStatus.SelectedIndex.ToString();

            Order newOrder = new Order(_nextID, customer, product, quantity, total, status);
            _orderList.Add(newOrder);
            _nextID++;

            _bindingSource.ResetBindings(false);
            ClearFields();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOrderID.Text, out int id))
            {
                MessageBox.Show("Please select an order from the grid to update");
                return;
            }

            Order order = _orderList.FirstOrDefault(o => o.OrderID == id);

            if (order != null)
            {
                if (!ValidateInputs()) return;

                order.CustomerName = txtCustomer.Text;
                order.ProductName = cmbProduct.SelectedItem.ToString();
                order.Quantity = int.Parse(txtOrderQuantity.Text);
                order.Total = GetProductPrice(order.ProductName) * order.Quantity;
                order.Status = cmbStatus.SelectedIndex.ToString();

                _bindingSource.ResetBindings(false);
                dgvOrders.Refresh();
                ClearFields();
                MessageBox.Show("Order Updated Succesfully");
            }
            else
            {
                MessageBox.Show("Order not found");
            }

        }
    }
}
