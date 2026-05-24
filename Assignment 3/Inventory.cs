using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Inventory : UserControl
    {
        private BindingList<Product> _inventorylist = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();
        string filepath = Path.Combine(Application.StartupPath, "Products.csv");
        public Inventory()
        {
            InitializeComponent();
            this.Load += Inventory_Load;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int newId = _inventorylist.Count + 1000;
            string name = txtName.Text;
            string brand = txtBrand.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);

            Product newProduct = new Product(newId, name, brand, price, quantity);
            _inventorylist.Add(newProduct);

            _bindingSource.ResetBindings(false);

            ClearFields();


        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            var tempData = InventoryService.LoadFromCSV(filepath);
            _inventorylist.Clear();

            foreach (var item in tempData)
            {
                _inventorylist.Add(item);
            }

            _bindingSource.DataSource = _inventorylist;
            dgvInventory.DataSource = _bindingSource;

            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;
        }

        private bool ValidateInputs()
        {
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Product Name contains invalid characters.");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.");
                return false;
            }

            return true;
        }
        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int idToUpdate))
            {
                MessageBox.Show("Please select a product from the grid to update.");
                return;
            }
            var productToUpdate = _inventorylist.FirstOrDefault(p => p.ProductID == idToUpdate);

            if (productToUpdate != null)
            {
                if (ValidateInputs())
                {
                    productToUpdate.ProductName = txtName.Text;
                    productToUpdate.ProductBrand = txtBrand.Text;
                    productToUpdate.ProductPrice = decimal.Parse(txtPrice.Text);
                    productToUpdate.ProductQuantity = int.Parse(txtQuantity.Text);

                    _bindingSource.ResetBindings(false);
                    dgvInventory.Refresh();

                    ClearFields();
                    MessageBox.Show("Product updated successfully in the list.");
                }
            }
            else
            {
                MessageBox.Show("Product ID not found in inventory.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = filepath;

                List<Product> listToSave = _inventorylist.ToList();

                InventoryService.SaveToCSV(path, listToSave);

                MessageBox.Show("Changes Saved Succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Data: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string searchTerm = txtDelete.Text.Trim();

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
                    txtDelete.Clear();
                    MessageBox.Show("Product deleted succesfully");
                }
            }
            else
            {
                MessageBox.Show("No product found matching  that ID or Name.");
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtBrand.Text = row.Cells[2].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
                txtQuantity.Text = row.Cells[4].Value.ToString();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           string searchText = txtSearch.Text.ToLower();

            var filteredList = _inventorylist
                .Where(p =>
                    (p.ProductName?.ToLower().Contains(searchText) ?? false) ||
                    (p.ProductBrand?.ToLower().Contains(searchText) ?? false) ||
                    p.ProductID.ToString().Contains(searchText)
                )
                .ToList();

            dgvInventory.DataSource = filteredList;
        }

    }

}


















