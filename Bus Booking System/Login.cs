using Bus_Booking_System;
using CrystalDecisions.Shared;
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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bus_Booking_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0HAAVUT;Initial Catalog=BBS;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, userpassword;

            username = txtUsername.Text;
            userpassword = txtPassword.Text;

            try
            {
                if(txtUsername.Text == "admin")
                {
                    String query = "Select * from AdminLogin where AdmUsername = '" + txtUsername.Text + "' AND AdmPassword = '" + txtPassword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        username = txtUsername.Text;
                        userpassword = txtPassword.Text;

                        AdminForm adm = new AdminForm();
                        adm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalide Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();

                        txtUsername.Focus();
                    }
                }
                else
                {

                    String query = "Select * from CustomerLogin where CustUsername = '" + txtUsername.Text + "' AND CustPassword = '" + txtPassword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        username = txtUsername.Text;
                        userpassword = txtPassword.Text;

                        CustomerForm adm = new CustomerForm();
                        adm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalide Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();

                        txtUsername.Focus();
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            hidepassword.Show();
            showpassword.Hide();
            txtPassword.PasswordChar = '*';
        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            showpassword.Show();
            hidepassword.Hide();
            txtPassword.PasswordChar = '\0';
        }
    }
}



        