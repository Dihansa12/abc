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
    public partial class ProductManage : Form
    {
        public ProductManage()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductManage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventorydbDataSet4.ProductTbl' table. You can move, or remove it, as needed.
            this.productTblTableAdapter.Fill(this.inventorydbDataSet4.ProductTbl);

        }
    }
}
