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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventorydbDataSet2.CustomerTbl' table. You can move, or remove it, as needed.
            this.customerTblTableAdapter.Fill(this.inventorydbDataSet2.CustomerTbl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
              SqlCommand cmd = new SqlCommand("Insert into CustomerTbl_values('"+CustomerIDTb.Text+"','"+CustomerNameTb.Text+"','"+CustomerPhoneTb.Text+"','"+PhoneTb.Text+"')");
            
            try
            { Con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer successfully added");
                Con.Close();
                 populate();
            }
            catch
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
