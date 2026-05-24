using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Checkout : UserControl
    {
        private BindingList<Order> _orderList = new BindingList<Order>();
        private BindingSource _bindingSource = new BindingSource();

        string ordersFilepath = Path.Combine(Application.StartupPath, "Orders.csv");
        public Checkout()
        {
            InitializeComponent();
            this.Load += Checkout_Load1;
        }

        private void Checkout_Load1(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _orderList;
            dgvCheckout.DataSource = _bindingSource;

            dgvCheckout.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckout.MultiSelect = false;

            LoadOrders();
        }


        private void LoadOrders()
        {
            var savedOrders = OrderServicecs.LoadFromCSV(ordersFilepath);

            _orderList.Clear();
            foreach (var o in savedOrders)
            {
                _orderList.Add(o);
            }

            UpdateStatusBar();
        }

        private void dgvCheckout_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCheckout.Rows[e.RowIndex];

                txtFinalOrderID.Text = row.Cells[0].Value.ToString();
                txtFinalCustomer.Text = row.Cells[1].Value.ToString();
                txtFinalProduct.Text = row.Cells[2].Value.ToString();
                txtFinalQuantity.Text = row.Cells[3].Value.ToString();
                txtFinalStatus.Text = row.Cells[5].Value.ToString();
                lblTotal.Text = "$" + row.Cells[4].Value.ToString();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFinalOrderID.Text, out int id))
            {
                MessageBox.Show("Please Select An Order From The Grid To Checkout");
                return;
            }

            Order orderToCheckout = _orderList.FirstOrDefault(o => o.OrderID == id);

            if(orderToCheckout != null)
            {
                DialogResult result = MessageBox.Show($"Confirm Checkout For {orderToCheckout.CustomerName}? " +
                    $"Total: ${orderToCheckout.Total}", "Confirm Checkout", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    _orderList.Remove(orderToCheckout);

                    OrderServicecs.SaveToCSV(ordersFilepath, _orderList.ToList());

                    ClearFields();
                    UpdateStatusBar();
                }
            }
            else
            {
                MessageBox.Show("Order Not Found.");
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtSearchCheckout_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchCheckout.Text.ToLower();

            if(string.IsNullOrEmpty(searchText))
            {
                dgvCheckout.DataSource = _bindingSource;
                return;
            }

            var filtered = _orderList
                .Where(o => 
                o.CustomerName.ToLower().Contains(searchText) ||
                o.ProductName.ToLower().Contains(searchText) ||
                o.OrderID.ToString().Contains(searchText))
                .ToList();

            dgvCheckout.DataSource = filtered;
        }

        private void UpdateStatusBar()
        {
            lblStatusBar.Text = $"{_orderList.Count} Orders Pending Checkout";
        }

        private void ClearFields()
        {
            txtFinalOrderID.Clear();
            txtFinalCustomer.Clear();
            txtFinalProduct.Clear();
            txtFinalQuantity.Clear();
            txtFinalStatus.Clear();
            lblTotal.Text = "$0.00";
        }
    }
}
