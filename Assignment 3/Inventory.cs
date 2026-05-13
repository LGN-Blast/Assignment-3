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
    public partial class Inventory : UserControl
    {
        private BindingList<Product> _inventorylist = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();
        string filepath = "H:/Programming/Assignment 3/Assignment 3/product.csv";
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load_1(object sender, EventArgs e)
        {
            var tempData = InventoryService.LoadFromCSV(filepath);
            _inventorylist.Clear();

            foreach (var item in tempData)
            {
                _inventorylist.Add(item);
            }
           
            dataGridView1.DataSource = _inventorylist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int newId = _inventoryList.Count + 1000;
            string name = Namebox.Text;
            string brand = Brandbox.Text;
            decimal price = decimal.Parse(Pricebox.Text);
            int quantity = int.Parse(Quantitybox.Text);

            Product newProduct = new Product(newId, name, brand, price, quantity);
            _inventorylist.Add(newProduct);

            _bindingSource.ResetBindings(false);

            ClearFields();
        }

        private bool ValidateInputs()
        {
            if (!Regex.IsMatch(Namebox.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Product Name contains invalid characters.");
                return false;
            }

            if (!decimal.TryParse(Pricebox.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return false;
            }

            if (!int.TryParse(Quantitybox.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.");
                return false;
            }

            return true;
        }
        private void ClearFields()
        {
            txtID.Clear();
            Namebox.Clear();
            Brandbox.Clear();
            Pricebox.Clear();
            Quantitybox.Clear();
        }

    }
}




















