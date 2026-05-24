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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowScreen(UserControl newScreen)
        {
            foreach (Control ctrl in panel2.Controls)
            {
                ctrl.Dispose();
            }


            panel2.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            panel2.Controls.Add(newScreen);
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
           ShowScreen(new Dashboard());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowScreen(new Inventory());
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ShowScreen(new Checkout());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowScreen(new Order_Page());
        }

        private void btnDash_MouseEnter(object sender, EventArgs e)
        {
            btnDash.BackColor = Color.Gainsboro;
        }

        private void btnDash_MouseLeave(object sender, EventArgs e)
        {
            btnDash.BackColor = Color.White;
        }

        private void btnInventory_MouseEnter(object sender, EventArgs e)
        {
            btnInventory.BackColor = Color.Gainsboro;
        }

        private void btnInventory_MouseLeave(object sender, EventArgs e)
        {
            btnInventory.BackColor = Color.White;
        }

        private void btnOrder_MouseEnter(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.Gainsboro;
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.White;
        }

        private void btnSetting_MouseEnter(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.Gainsboro;
        }

        private void btnSetting_MouseLeave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.White;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Red;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           ShowScreen(new Dashboard());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to logout?", "SYRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

}
    }
