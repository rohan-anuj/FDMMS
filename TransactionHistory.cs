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

namespace WindowsFormsApplication10
{
    public partial class TransactionHistory : Form
    {
        string connectionstring = @"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True";
        public TransactionHistory()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
           
            
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newADD_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from View_All_Bill_Test ", sqlCon);
                DataTable dtb1 = new DataTable();

                sqlDa.Fill(dtb1);
                dgv1.DataSource = dtb1;

            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from FishermanRegistration  ", sqlCon);
                DataTable Da = new DataTable();

                sqlDa.Fill(Da);
                dgv1.DataSource = Da;

            }


        }

        private void textbox_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
