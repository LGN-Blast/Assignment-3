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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dashTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dashTimer.Start();
            UpdateDashboard();

            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void UpdateDashboard()
        {
            int totalInventory = 0;
            int lowStockAlerts = 0;

            Inventory inventory = new Inventory();
            inventory.Refresh();

            foreach(DataGridViewRow row in inventory.InventoryGrid.Rows)
            {
                if (row.Cells["Quantity"].Value !=null)
                {
                    int productQuantity;

                    if (int.TryParse(row.Cells["Quantity"].Value.ToString(), out productQuantity))
                    {
                        totalInventory += productQuantity;

                        if (productQuantity < 10)
                        {
                            lowStockAlerts++;
                        }
                    }
                }
            }

            lblTotalInventory.Text = totalInventory.ToString();
            lblLowStock.Text = lowStockAlerts.ToString();
        }
    }
}
