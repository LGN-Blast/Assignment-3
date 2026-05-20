using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

            int newId = _inventorylist.Count + 1000;
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
            IDBox.Clear();
            Namebox.Clear();
            Brandbox.Clear();
            Pricebox.Clear();
            Quantitybox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDBox.Text, out int idToUpdate))
            {
                MessageBox.Show("Please select a product from the grid to update.");
                return;
            }
            var productToUpdate = _inventorylist.FirstOrDefault(p => p.ProductID == idToUpdate);

            if (productToUpdate != null)
            {
                if (ValidateInputs())
                {
                    productToUpdate.ProductName = Namebox.Text;
                    productToUpdate.ProductBrand = Brandbox.Text;
                    productToUpdate.ProductPrice = decimal.Parse(Pricebox.Text);
                    productToUpdate.ProductQuantity = int.Parse(Quantitybox.Text);

                    _bindingSource.ResetBindings(false);
                    dataGridView1.Refresh();

                    ClearFields();
                    MessageBox.Show("Product updated successfully in the list.");
                }
            }
            else
            {
                MessageBox.Show("Product ID not found in inventory.");
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = filepath;

                List<Product> listToSave = _inventorylist.ToList();

                InventoryService.SaveToCSV(path, listToSave);

                MessageBox.Show("Changes Saved Succesfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Saving Data: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchTerm = DeleteBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please Enter a Product ID or Name to Delete");
                return;
            }

            Product productToDelete = _inventorylist.FirstOrDefault(p =>
            p.ProductID.ToString() == searchTerm ||
            p.ProductName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

            if (productToDelete != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {productToDelete.ProductName}?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _inventorylist.Remove(productToDelete);
                    DeleteBox.Clear();
                    MessageBox.Show("Product deleted succesfully");
                }
            }
            else
            {
                MessageBox.Show("No product found matching  that ID or Name.");
            }
        }

    }
   }




















