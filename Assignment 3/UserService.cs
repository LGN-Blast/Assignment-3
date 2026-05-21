using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    internal class UserService
    {
        private static readonly string filePath = "users.csv";

        public static bool Login(string username, string password)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("users.csv not found.");
                return false;
            }

            var lines = File.ReadAllLines(filePath).Skip(1);

            foreach (var line in lines)
            {
                string[] data = line.Split(',');

                if (data.Length >= 2)
                {
                    string storedUsername = data[0].Trim();
                    string storedPassword = data[1].Trim();

                    if (storedUsername.Equals(username, StringComparison.OrdinalIgnoreCase) && storedPassword == password)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

    }
}
