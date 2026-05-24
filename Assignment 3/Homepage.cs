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

            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            _inventorylist = InventoryService.LoadFromCSV(filepath);
        }
        
    }
}
