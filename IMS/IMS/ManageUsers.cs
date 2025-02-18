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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        static string connectionstring = ""; 
        SqlConnection con = new SqlConnection(connectionstring);

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                con.Open();
                string MyQuery = "SELECT * FROM UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                UserGD.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(unameTb.Text) || string.IsNullOrWhiteSpace(fnameTb.Text) ||
                string.IsNullOrWhiteSpace(PasswordTb.Text) || string.IsNullOrWhiteSpace(PhoneTb.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string query = "INSERT INTO UserTbl (Uname, Ufullname, Upassword, Uphone) VALUES (@uname, @fname, @pass, @phone)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@uname", unameTb.Text);
            cmd.Parameters.AddWithValue("@fname", fnameTb.Text);
            cmd.Parameters.AddWithValue("@pass", PasswordTb.Text);
            cmd.Parameters.AddWithValue("@phone", PhoneTb.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully added");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            this.userTblTableAdapter.Fill(this.inventorydbDataSet1.UserTbl);
        }

        private void UserGD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserGD.SelectedRows.Count > 0)
            {
                unameTb.Text = UserGD.SelectedRows[0].Cells[0].Value?.ToString();
                fnameTb.Text = UserGD.SelectedRows[0].Cells[1].Value?.ToString();
                PasswordTb.Text = UserGD.SelectedRows[0].Cells[2].Value?.ToString();
                PhoneTb.Text = UserGD.SelectedRows[0].Cells[3].Value?.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PhoneTb.Text))
            {
                MessageBox.Show("Enter the user's phone number.");
                return;
            }

            string myQuery = "DELETE FROM UserTbl WHERE UPhone = @phone";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            cmd.Parameters.AddWithValue("@phone", PhoneTb.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully deleted");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PhoneTb.Text) || string.IsNullOrWhiteSpace(unameTb.Text) ||
                string.IsNullOrWhiteSpace(fnameTb.Text) || string.IsNullOrWhiteSpace(PasswordTb.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string query = "UPDATE UserTbl SET Uname = @uname, Ufullname = @fname, Upassword = @pass WHERE Uphone = @phone";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@uname", unameTb.Text);
            cmd.Parameters.AddWithValue("@fname", fnameTb.Text);
            cmd.Parameters.AddWithValue("@pass", PasswordTb.Text);
            cmd.Parameters.AddWithValue("@phone", PhoneTb.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully updated");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
