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

        private void button1_Click(object sender, EventArgs e) //Login Click Event
        {
            string username = Userbox.Text.Trim();
            string password = Passbox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) //Empty Fields Check
            {
                MessageBox.Show("Please enter your username and password.", "SYRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (UserService.Login(username, password)) //Login Check
            {
                MessageBox.Show($"Welcome, {username}","SYRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 dashboard = new Form1();

                this.Hide();

                dashboard.ShowDialog();

                Userbox.Clear();
                Passbox.Clear();

                this.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "SYRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Passbox.Clear();
                Passbox.Focus();
            }
        }
    }
}
