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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventorydbDataSet3.CategoriesTbl' table. You can move, or remove it, as needed.
            this.categoriesTblTableAdapter.Fill(this.inventorydbDataSet3.CategoriesTbl);

        }
    }
}
