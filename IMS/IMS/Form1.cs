using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string Username = "Admin";
            string Password = "1234";
            if (Username.Equals(Username)&& Password.Equals(Password)
            {
                MessageBox.Show("Login Successfully");
                ManageUsers fff = new ManageUsers();
                this.Hide();
                fff.Show();
            }

            else
            {
                MessageBox.Show("Invalid username or password");
        }
        }
    }
}
    