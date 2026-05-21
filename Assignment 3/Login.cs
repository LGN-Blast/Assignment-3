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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Passbox.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Userbox.Text.Trim();
            string password = Passbox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password.", "SYRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (UserService.Login(username, password))
            {
                MessageBox.Show($"Welcome,{username}");

                Form1 dashboard = new Form1();

                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");

                Passbox.Clear();
                Passbox.Focus();
            }
        }
    }
}
