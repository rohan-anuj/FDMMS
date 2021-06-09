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
using Bunifu.Framework.UI;



namespace WindowsFormsApplication10
{
    public partial class FormSupplierRegistration : Form
    {
        public FormSupplierRegistration()
        {
            InitializeComponent();
        }

        private void FormSupplierRegistration_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            if (Contactnumber.Text.Length >= 11)
            {
                MessageBox.Show("Only 10 Numbers");
                Contactnumber.Text = String.Format(Contactnumber.Text, Contactnumber.Text.Length - 1);
            }
        }

        private void Bunifu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonZ1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void Supplierkeypress(object sender, EventArgs e)
        {
            
        
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
   
            if (panel2.Width == 0)
            {
                panel2.Width = 441;
               

            }
            else if(panel2.Width == 441)
            {
                panel2.Width = 0;

            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if(Sid.Text.Length>=5)
            {
                MessageBox.Show("Only 4 Number");
                Sid.Text = String.Format(Sid.Text, Sid.Text.Length - 1);
            }
            if (Sid.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
               cmd.CommandText = "select Fullname from FishermanRegistration where NId=@NId";
               // cmd.CommandText = "select Address from FishermanRegistration where NId=@NId";
               // cmd.CommandText = "select Mobilenumber from FishermanRegistration where NId=@NId";
                

                cmd.Parameters.AddWithValue("@NId",int.Parse(Sid.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    MessageBox.Show("This User already exists");
                
                    Sname.Text = da.GetValue(0).ToString();
                   // Address.Text= da.GetValue(0).ToString();
                    //Contactnumber.Text = da.GetValue(0).ToString();
                    


                }
                con.Close();
            
            }
        }

        private void bunifukeypress(object sender, KeyPressEventArgs e)
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
            

            if (System.Text.RegularExpressions.Regex.IsMatch(Sid.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Sid.Text = Sid.Text.Remove(Sid.Text.Length - 1);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Sid.Text == "")
            {
                MessageBox.Show("Please Enter Records for Registration of supplier");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into FishermanRegistration values('" + Sid.Text + "','" + Sname.Text + "','" + Address.Text + "','" + Contactnumber.Text + "',getdate())";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Supplier Registration Sucessfully");
                    Sname.Text = string.Empty;
                    Address.Text = string.Empty;
                    Sid.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }



        }


        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (Sid.Text == "")
            {
                MessageBox.Show("Please enter Id Of Supplier To Delete");
            }
            else
            {
                DialogResult Dialog = MessageBox.Show("Do you really want to delete Supplier", "Delete", MessageBoxButtons.YesNo);
                if (Dialog == DialogResult.Yes)
                {
                    try
                    {



                        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from FishermanRegistration where NId='" + Sid.Text + "'";
                        cmd.ExecuteNonQuery();
                        int i = cmd.ExecuteNonQuery();
                        con.Close();


                        MessageBox.Show("Supplier Deleted Sucessfully");
                        Sname.Text = string.Empty;
                        Address.Text = string.Empty;
                        Sid.Text = string.Empty;
                        Contactnumber.Text = string.Empty;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                }
                else if (Dialog == DialogResult.No)
                {
                    MessageBox.Show("The Supplier hasn't deleted");
                }
            }


        }

        private void View_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (Contactnumber2.Text == "" & Address2.Text == "")
            {
                MessageBox.Show("Enter Records to Update data");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update FishermanRegistration set Address='" + Address2.Text + "',Mobilenumber='" + Contactnumber2.Text + "',DateOfRegistration=getdate() where NId='" + Sid.Text + "'";
                    // cmd.CommandText = "update FishermanRegistration set Fullname ='" + Sname2.Text + "' where Fullname='" + Sname.Text + "'";
                    //cmd.CommandText = "update FishermanRegistration set Address='" + Address2.Text + "' where Address='" + Address.Text + "'";
                    //cmd.CommandText = "update FishermanRegistration set Mobilenumber='" + Contactnumber2.Text + "' where Mobilenumber='" + Contactnumber.Text + "'";
                    //cmd.CommandText = "update FishermanRegistration set DateOfRegistration=getdate()";



                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Data Updated sucessfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton26_Click_1(object sender, EventArgs e)
        {
           
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuTextbox1_OnTextChange_1(object sender, EventArgs e)
        {

        }

        private void Contactnumber2_OnValueChanged(object sender, EventArgs e)
        {
            if (Contactnumber2.Text.Length >= 11)
            {
                MessageBox.Show("Only 10 Numbers");
                Contactnumber2.Text = String.Format(Contactnumber2.Text, Contactnumber2.Text.Length - 1);
            }
        }

        private void Contactnumber2_Keyprss(object sender, KeyPressEventArgs e)
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
