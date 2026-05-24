using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
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

        string filepath = System.IO.Path.Combine(Application.StartupPath, "Products.csv");
        string ordersFilepath = Path.Combine(Application.StartupPath, "Orders.csv");

        public Order_Page()
        {
            InitializeComponent();

            this.Load += Orders_Load;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _orderList;
            dgvOrders.DataSource = _bindingSource;

            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;

            cmbStatus.Items.AddRange(new string[] { "Pending", "Confirmed", "Shipped", "Cancelled" });
            cmbStatus.SelectedIndex = 0;

            LoadProducts();


            var savedOrders = OrderServicecs.LoadFromCSV(ordersFilepath);
            
            foreach (var o in savedOrders)
            {
                _orderList.Add(o);
                if (o.OrderID >= _nextID)
                    _nextID = o.OrderID + 1;
            }
        }

        private void LoadProducts()
        {
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
            dgvOrders.DataSource = _bindingSource;

            if (!ValidateInputs()) return;

            string customer = txtCustomer.Text;
            string product = cmbProduct.SelectedItem.ToString();
            int quantity = int.Parse(txtOrderQuantity.Text);
            decimal price = GetProductPrice(product);
            decimal total = price * quantity;
            string status = cmbStatus.SelectedItem.ToString();

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

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            string searchTerm = txtDeleteOrder.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please Enter an OrderID or Customer Name To Delete");
                return;
            }

            Order orderToDelete = _orderList.FirstOrDefault(o => o.OrderID.ToString() == searchTerm || 
            o.CustomerName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

            if(orderToDelete != null)
            {
                DialogResult result = MessageBox.Show($"Are You Sure You Want To Delete {orderToDelete.CustomerName}'s Order?", 
                    "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _orderList.Remove(orderToDelete);
                    txtDeleteOrder.Clear();
                    MessageBox.Show("Order Deleted Succesfully");
                }
            }
            else
            {
                MessageBox.Show("No Order Found Matching That Customer Name or ID");
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                OrderServicecs.SaveToCSV(ordersFilepath, _orderList.ToList());
                MessageBox.Show("Orders saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Orders" +  ex.Message);
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrders.Rows[e.RowIndex];

                txtOrderID.Text = row.Cells[0].Value.ToString();
                txtCustomer.Text = row.Cells[1].Value.ToString();
                cmbProduct.Text = row.Cells[2].Value.ToString();
                txtOrderQuantity.Text = row.Cells[3].Value.ToString();
                cmbStatus.Text = row.Cells[5].Value.ToString();
            }
        }

        private void txtSearchOrder_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchOrder.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                dgvOrders.DataSource = _bindingSource;
                return;
            }

            var filtered = _orderList
                .Where(o => 
                o.CustomerName.ToLower().Contains(searchText) ||
                o.ProductName.ToLower().Contains(searchText) ||
                o.OrderID.ToString().Contains(searchText) ||
                o.Status.ToLower().Contains(searchText))
                .ToList();

            dgvOrders.DataSource = filtered;
        }

        private decimal GetProductPrice(string productName)
        {
            var products = InventoryService.LoadFromCSV(filepath);

            System.Diagnostics.Debug.WriteLine($"Looking for: '{productName}'");
            System.Diagnostics.Debug.WriteLine($"First product name: '{products[0].ProductName}'");

            var match = products.FirstOrDefault(p => p.ProductName == productName);
            return match != null ? match.ProductPrice : 0m;
        }

        private void ClearFields()
        {
            txtOrderID.Clear();
            txtCustomer.Clear();
            txtOrderQuantity.Clear();
            txtDeleteOrder.Clear();
            cmbProduct.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
        }
           

    }
}
