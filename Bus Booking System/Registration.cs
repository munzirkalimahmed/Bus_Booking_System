using Bus_Booking_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bus_Booking_System
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            txtName.Text = "";
            txtUsername.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtCnic.Text = string.Empty;
            txtPassword.Text = string.Empty;
            picCustomer.Image = Properties.Resources.icons8_no_image_100;
            img_location = string.Empty;

            btnRegister.Enabled = true;
            txtName.Enabled = true;
            txtUsername.Enabled = true;
            txtCity.Enabled = true;
            txtContact.Enabled = true;
            txtCnic.Enabled = true;
            txtPassword.Enabled = true;
            picCustomer.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        string img_location = String.Empty;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Image Browse Code:
            #region upload image file
            try
            {
                Image imageFile;
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "png files(*.png)|*.png|jpg files(*.jpg)" +
                   "|*.jpg|All files(*.*)|*.*"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageFile = Image.FromFile(dialog.FileName);
                    int imgHeight = imageFile.Height;
                    if (imgHeight > 350)
                        MessageBox.Show("Maximum Image can be 350x350" +
                            " Image", "Image size is too large..!!"
                            , MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    else
                    {
                        img_location = dialog.FileName.ToString();
                        picCustomer.ImageLocation = img_location;
                    }
                }
                dialog.Dispose();    //object destroy
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion
        }

       // DataRow dr;
        Register register = new Register();
        //Register reg = new Register();
        CustomerLogin cust = new CustomerLogin();
       // Register reg = new Register();
        //long RegId = 0;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                 if ((txtName.Text == String.Empty) || (txtUsername.Text == String.Empty) || (txtCity.Text == String.Empty) || (txtContact.Text == String.Empty) ||
                 (txtCnic.Text == string.Empty) || (txtPassword.Text == string.Empty))
                 {
                    MessageBox.Show("Please Fill All fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    txtName.Focus();
                 }
                else
                {
                    byte[] images = null;

                    if (img_location != string.Empty)
                    {
                        FileStream stream =
                            new FileStream(img_location, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        images = brs.ReadBytes((int)stream.Length);

                    }
                    else
                    {
                        Image img = picCustomer.Image;

                        ImageConverter converter = new ImageConverter();
                        images = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    }
                    register.Name = txtName.Text.Trim();
                    register.Username = txtUsername.Text.Trim();
                    register.City = txtCity.Text.Trim();
                    register.Contact = txtContact.Text.Trim();
                    register.Cnic = txtCnic.Text.Trim();
                    register.Password = txtPassword.Text.Trim();
                    register.Image = images;


                    cust.CustUsername = register.Username;
                    cust.CustPassword = register.Password;


                    //for crud operation
                    using (var db = new BBSEntities())
                    {
                        db.Registers.Add(register);
                        db.CustomerLogins.Add(cust);
                        db.SaveChanges();
                    }

                    ClearData();
                    // setDataInGridView();
                    MessageBox.Show("Registration Successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
