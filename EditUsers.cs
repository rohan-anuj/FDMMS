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
    public partial class EditUsers : Form
    {
        public EditUsers()
        {
            InitializeComponent();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Username_OnValueChanged(object sender, EventArgs e)
        {
            if (Username.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Password from Loginfmma where Username=@Username", con);
                cmd.Parameters.AddWithValue("@Username", Username.Text);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    MessageBox.Show("This User already exists");
                    Password.Text = da.GetValue(0).ToString();
                }
                con.Close();
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Enter UserName & Password To Add ");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Loginfmma values('" + Username.Text + "','" + Password.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("User ADDED Sucessfully");
                    Username.Text = string.Empty;
                    Password.Text = string.Empty;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void newDelete_Click(object sender, EventArgs e)
        {
            if (DUsername.Text == "")
            {
                MessageBox.Show("Enter Valid Username To delete ");
            }
            else
            {
                DialogResult Dialog = MessageBox.Show("Do you really want to delete account?", "Exit", MessageBoxButtons.YesNo);
                if (Dialog == DialogResult.Yes)
                {
                    try
                    {


                        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from Loginfmma where Username='" + DUsername.Text + "'";
                        cmd.ExecuteNonQuery();
                        int i = cmd.ExecuteNonQuery();
                        con.Close();


                        MessageBox.Show("Supplier Deleted Sucessfully");
                        DUsername.Text = string.Empty;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                }

                else if (Dialog == DialogResult.No)
                {
                    MessageBox.Show("Good Decision");
                }

            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void newClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newUpdate_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" & Password.Text == "")
            {
                MessageBox.Show("Enter UserName & Password To Update ");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EV7AOKOG;Initial Catalog=Appfmma;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Loginfmma set Username ='" + newusername.Text + "' where Username='" + Username.Text + "'";
                    cmd.CommandText = "update loginfmma set Password='" + newpassword.Text + "' where Password='" + Password.Text + "'";



                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Data Updated sucessfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is an error encountered", ex.Message);

                }
            }
        }
    }
}
