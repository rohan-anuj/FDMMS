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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = Cmb_fish.SelectedItem.ToString();
            arr[1] = Price.Text;
            arr[2] = Quantity.Text;
            arr[3] = Total.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);
            sub_total.Text = ((Convert.ToInt32(sub_total.Text)) + (Convert.ToInt32(Total.Text))).ToString();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Fuchsia;
            radioButton2.ForeColor = System.Drawing.Color.Purple;
            Cmb_fish.Items.Clear();
            Cmb_fish.Items.Add("Bombil");
            Cmb_fish.Items.Add("Kardi");
            Cmb_fish.Items.Add("Kolim");
            Cmb_fish.Items.Add("Kolbi(sora)");
            Cmb_fish.Items.Add("Vakti");




        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Purple;
            radioButton2.ForeColor = System.Drawing.Color.Fuchsia;
            Cmb_fish.Items.Clear();
            Cmb_fish.Items.Add("Mandeli");
            Cmb_fish.Items.Add("Dhoma");
            Cmb_fish.Items.Add("Sarga(Paplet)");
            Cmb_fish.Items.Add("Kolbi(wet)");
            Cmb_fish.Items.Add("Massa(GolFish)");
            Cmb_fish.Items.Add("Mushi(Shark)");
            Cmb_fish.Items.Add("Shingala(CatFish)");
            Cmb_fish.Items.Add("Tengli(Sardines)");

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quantity.Text = "";
            Price.Text = "";
            Total.Text = "";

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            if (Quantity.Text.Length > 0)
            {
                Total.Text = (Convert.ToInt32(Price.Text) * Convert.ToInt32(Quantity.Text)).ToString();
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Total_KeyPress(object sender, KeyPressEventArgs e)
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

        private void sub_Total_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void NetAmt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Paid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Balance_KeyPress(object sender, KeyPressEventArgs e)
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

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Paid_TextChanged(object sender, EventArgs e)
        {
          if(Paid.Text.Length>0)

            {
                Balance.Text = ((Convert.ToInt32(sub_total.Text)) - (Convert.ToInt32(Paid.Text))).ToString();

            }
         
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                for(int i=0;i<listView1.Items.Count;i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        sub_total.Text=(Convert.ToInt32(sub_total.Text) - Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();





                    }
                }
            }
        }

        private void SName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SId_TextChanged(object sender, EventArgs e)
        {
            if (SId.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Fullname  from FishermanRegistration where NId=@NId", con);
                cmd.Parameters.AddWithValue("@NId", int.Parse(SId.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    SName.Text = da.GetValue(0).ToString();
               }
                con.Close();
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {

                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");

                    
                    SqlCommand command = conn.CreateCommand();

                    conn.Open();

                   command.CommandText = "Insert into Invoice_new (Date, NId, Name,  Sub_total, Paid, Balance) values " +
                                " ( getdate() ,' " + SId.Text + "' , '" + SName.Text + " ', '" + sub_total.Text + "', '" + Paid.Text + "', '" + Balance.Text + "') select scope_identity() ";

                string Invoiceno = command.ExecuteScalar().ToString();

                   foreach (ListViewItem ListItem in listView1.Items)
                    {

                        command.CommandText = "Insert into Trade (MasterId, ItemName, ItemPrice, ItemQtty, ItemTotal ) values   " +
                   " ('" + Invoiceno + "','" + ListItem.SubItems[0].Text + "', '" + ListItem.SubItems[1].Text + "', '" + ListItem.SubItems[2].Text + "' , " + ListItem.SubItems[3].Text + ")";

                        command.ExecuteNonQuery();

                    }
                    conn.Close();
                    MessageBox.Show("Sale Created Successfully, with Invoice # "+Invoiceno);
                   // new Report.PrintInvoiceForm(InvoiceID).Show();



               }
                catch (Exception ee)
                {
                    MessageBox.Show("Sale Not Created, Error!",ee.Message);
               }

            }
            else
            {
                MessageBox.Show("Must Add an Item in the List");
            }

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
          new  Report.Invoiceshow().Show();
        }

        private void Balance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
