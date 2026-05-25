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
    public partial class Dashboard : UserControl
    {
        private List<Product> _inventorylist = new List<Product>();
        string filepath = Path.Combine(Application.StartupPath, "Products.csv");

        private BindingList<Order> _orderList = new BindingList<Order>();
        private BindingSource _bindingSource = new BindingSource();
        string ordersFilepath = Path.Combine(Application.StartupPath, "Orders.csv");

        public Dashboard()
        {
            InitializeComponent();
            this.Load += DashChanges;
            this.Load += DashDGV_Load;
        }

        private void DashDGV_Load(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _orderList;
            dgvHomepage.DataSource = _bindingSource;

            dgvHomepage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHomepage.MultiSelect = false;

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
        }


        private void dashTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dashTimer.Start();

            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            _inventorylist = InventoryService.LoadFromCSV(filepath);

            lblTotalInventory.Text = _inventorylist.Sum(p => p.ProductQuantity).ToString();
            lblLowStock.Text = _inventorylist.Count(p => p.ProductQuantity < 5).ToString();
            lblTotalStockValue.Text = _inventorylist.Sum(p => p.ProductPrice * p.ProductQuantity).ToString("C");

        }

        private void DashChanges(object sender, EventArgs e)
        {
            if (!this.Visible) return;

            _inventorylist = InventoryService.LoadFromCSV(filepath);

            lblTotalInventory.Text = _inventorylist.Sum(p => p.ProductQuantity).ToString();
            lblLowStock.Text = _inventorylist.Count(p => p.ProductQuantity < 5).ToString();
            lblTotalStockValue.Text = _inventorylist.Sum(p => p.ProductPrice * p.ProductQuantity).ToString("C");

        }

        private void txtSearchHome_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchHome.Text.ToLower();

            if(string.IsNullOrEmpty(searchText))
            {
                dgvHomepage.DataSource = _bindingSource;
            }

            var filtered = _orderList
                .Where(o => o.CustomerName.ToLower().Contains(searchText) ||
                o.ProductName.ToLower().Contains(searchText) ||
                o.OrderID.ToString().Contains(searchText))
                .ToList();

            dgvHomepage.DataSource = filtered;
        }
    }
}
