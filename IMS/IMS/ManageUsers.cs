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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        static string connectionstring = "";
        SqlConnection con=new SqlConnection(connectionstring);

    
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

     void populate()
     {
     try
     {
         Con.Open();
         string MyQuery= "select* from UserTbl";
         SqlDataAdapter da=new SqlDataAdapter (MyQuery,Con);
         SqlCommanBuilder builder=new SqlCommandBuilder (da);
         var ds=new DataSet();
         da.Fill (ds);
         UserGD.DataSource=ds.Tables[0];
         Con.Close();


        
     }
        catch
     {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into UserTbl_values('"+unameTb.Text+"','"+fnameTb.Text+"','"+PasswordTb.Text+"','"+PhoneTb.Text+"')");
            
            try
            { Con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully added");
                Con.Close();
                 populate();
            }
            catch
            { 
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventorydbDataSet1.UserTbl' table. You can move, or remove it, as needed.
            this.userTblTableAdapter.Fill(this.inventorydbDataSet1.UserTbl);

        }

        private void UserGD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           unameTb.Text=UserGD.SelectedRows[0].Cells[0].Value.ToString();
            fnameTb.Text=UserGD.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text=UserGD.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text=UserGD.SelectedRows[0].Cells[3].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(PhoneTb.Text == "")
            {
                MessageBox.Show("Enter The Users Phone Number");

            }
            else
            {

            }
            Con.Open();
            string myQeury ="delete from UserTbl where UPhone='"+PhoneTb.Text+"'";
            SqlCommand cmd=new SqlCommand (myQeury, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Successfully Deleted");
            Con.Close();
            populate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("update UserTbl set Uname'" +unameTb.Text+"',Ufullname='"+fnameTb.Text+"',Upassword='"+PasswordTb.Text+"'where Uphone'"+PhoneTb.Text,Con);
            
            try
            { Con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully Updated");
                Con.Close();
                 populate();
            }
            catch
            { 
        }
    }
}
