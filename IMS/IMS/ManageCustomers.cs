using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace IMS
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        static string connectionString = "";
        SqlConnection Con = new SqlConnection(connectionString);

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            this.customerTblTableAdapter.Fill(this.inventorydbDataSet2.CustomerTbl);
        }

        void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                CustomerGD.DataSource = ds.Tables[0]; 
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerIDTb.Text) ||
                string.IsNullOrWhiteSpace(CustomerNameTb.Text) ||
                string.IsNullOrWhiteSpace(CustomerPhoneTb.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO CustomerTbl (CustomerID, CustomerName, CustomerPhone) VALUES (@id, @name, @phone)";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@id", CustomerIDTb.Text);
            cmd.Parameters.AddWithValue("@name", CustomerNameTb.Text);
            cmd.Parameters.AddWithValue("@phone", CustomerPhoneTb.Text);

            try
            {
                Con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer successfully added");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
