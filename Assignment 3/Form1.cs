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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowScreen(new Dashboard());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowScreen(new Inventory());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowScreen(new Checkout());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
