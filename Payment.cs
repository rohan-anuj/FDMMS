using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Invoiceno_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Invoiceno.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Invoice_new where Invoiceno=@Invoiceno", con);
                cmd.Parameters.AddWithValue("@Invoiceno", int.Parse(Invoiceno.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    SName.Text = (dr["Name"].ToString());
                    SId.Text = (dr["NId"].ToString());
                    sub_total.Text = (dr["Sub_Total"].ToString());
                    Paid.Text = (dr["Paid"].ToString());
                    Balance.Text = (dr["Balance"].ToString());

                }
                else
                {
                    SName.Text = "";

                    SId.Text = "";
                    sub_total.Text = "";
                    Paid.Text = "";
                    Balance.Text = "";
                    MessageBox.Show("No Records found enter valid Id");


                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("Do you really want to Make changes in Payment", "Settlement", MessageBoxButtons.YesNo);
            if (Dialog == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Invoice_new set Balance='" + NewBalance.Text + "',Date=getdate() where Invoiceno='" + Invoiceno.Text + "'";



                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Payment Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (Dialog == DialogResult.No)
            {
                MessageBox.Show("The Settlement Has been stopped with InvoiceId", Invoiceno.Text);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fullpaid_TextChanged(object sender, EventArgs e)
        {
            if (Fullpaid.Text.Length > 0)

            {
               NewBalance.Text = ((Convert.ToInt32(Balance.Text)) - (Convert.ToInt32(Fullpaid.Text))).ToString();

            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            new Report.Invoiceshow().Show();
        }

        private void Invoiceno_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void SId_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Sub_Total(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Paid_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Balance_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void FullPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void NewBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
