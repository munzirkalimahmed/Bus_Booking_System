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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cust = new CustomerForm();
            cust.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusSchedule bs = new BusSchedule();
            bs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactAdmin cd = new ContactAdmin();
            cd.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

         private void ClearData()
         {
             txtCustomerName.Text = "";
             comboGender.Text = string.Empty;
             txtContact.Text = string.Empty;
             txtCnic.Text = string.Empty;
             comboDeparture.Text = string.Empty;
             comboArrival.Text = string.Empty;
             comboBus.Text = string.Empty;
             txtPrice.Text = string.Empty;
             dateTimePicker1.Value = DateTime.Now;
             picCustomer.Image = Properties.Resources.icons8_no_image_100;
             img_location = string.Empty;

            btnAdd.Enabled = true;
            txtCustomerName.Enabled = true;
            comboGender.Enabled = true;
            txtContact.Enabled = true;
            txtCnic.Enabled = true;
            comboDeparture.Enabled = true;
            comboArrival.Enabled = true;
            comboBus.Enabled = true;
            txtPrice.Enabled = true;
            dateTimePicker1.Enabled = true;
            picCustomer.Enabled = true;
        }
        

       /* public void setDataInGridView()
        {
            var db = new BBSEntities();
            var customer = (from cust in db.Customers
                           select new
                           {
                               CustID = cust.CustID,
                               CustName = cust.CustName,
                               CustGender = cust.CustGender,
                               CustContact = cust.CustContact,
                               CustCnic = cust.CustCnic,
                               CustDeparture = cust.CustDeparture,
                               CustArrival = cust.CustArrival,
                               CustBus = cust.CustBus,
                               CustDate = cust.CustDate,
                           }).ToList();

            dgvCustomer.Rows.Clear();
            dgvCustomer.DataSource = null;

            foreach (var cust in customer)
            {
                int RowIndex = dgvCustomer.Rows.Add();   //Add new Row

                //dgvCustomer.Rows[RowIndex].Cells["CustID"].Value = cust.CustID;
                dgvCustomer.Rows[RowIndex].Cells["CustName"].Value = cust.CustName;
                dgvCustomer.Rows[RowIndex].Cells["CustGender"].Value = cust.CustGender;
                dgvCustomer.Rows[RowIndex].Cells["CustContact"].Value = cust.CustContact;
                dgvCustomer.Rows[RowIndex].Cells["CustCnic"].Value = cust.CustContact;
                dgvCustomer.Rows[RowIndex].Cells["CustDeparture"].Value = cust.CustDeparture;
                dgvCustomer.Rows[RowIndex].Cells["CustArrival"].Value = cust.CustArrival;
                dgvCustomer.Rows[RowIndex].Cells["CustBus"].Value = cust.CustBus;
                dgvCustomer.Rows[RowIndex].Cells["CustDate"].Value = cust.CustDate;
                //dgvStudent.Rows[RowIndex].Cells["DptID"].Value = std.DptID;


            }
            dgvCustomer.Update();
            dgvCustomer.Refresh();
        }
       */
        string img_location = String.Empty;
        private void button9_Click(object sender, EventArgs e)
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

        DataRow dr;
        Customer customer = new Customer();
        CustomerLogin custlogin = new CustomerLogin();
        long custId = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
           try
            {
                if ((txtCustomerName.Text == String.Empty) || (comboGender.Text == String.Empty) || (txtContact.Text == String.Empty) || (txtCnic.Text == String.Empty) ||
                      (comboDeparture.Text == string.Empty) || (comboArrival.Text == string.Empty) || (comboBus.Text == string.Empty) || (txtPrice.Text == string.Empty))
                {
                    MessageBox.Show("Please Fill All fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerName.Focus();
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
                    customer.CustName = txtCustomerName.Text.Trim();
                    customer.CustGender = comboGender.Text.ToString();
                    customer.CustContact = txtContact.Text.Trim();
                    customer.CustCnic = txtCnic.Text.Trim();
                    customer.CustDeparture = comboDeparture.Text.ToString();
                    customer.CustArrival = comboArrival.Text.ToString();
                    customer.CustBus = comboBus.Text.ToString();
                    customer.CustPrice = int.Parse(txtPrice.Text.Trim());
                    customer.CustDate = dateTimePicker1.Value;
                    customer.CustImage = images;
                   // customer.CustLoginID = custlogin.CustLoginID;

                    using (var db = new BBSEntities())

                    {
                        db.Customers.Add(customer);
                        db.SaveChanges();
                    }

                    ClearData();
                    // setDataInGridView();
                    MessageBox.Show("Ticket Book Successfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       /* private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearData();
            try
            {
                if (e.RowIndex >= 0)
                {
                    custId = long.Parse(dgvCustomer.Rows[e.RowIndex].Cells["CustID"].Value.ToString());
                    //load Employee Data
                    using (var db = new BBSEntities())
                    {
                        customer = db.Customers.Where(x => x.CustID == custId).First();
                    }

                    txtCustomerName.Text = dgvCustomer.Rows[e.RowIndex].Cells["CustName"].Value.ToString();
                    comboGender.SelectedValue = dgvCustomer.Rows[e.RowIndex].Cells["CustGender"].Value.ToString();
                    txtContact.Text = dgvCustomer.Rows[e.RowIndex].Cells["CustContact"].Value.ToString();
                    txtCnic.Text = dgvCustomer.Rows[e.RowIndex].Cells["CustCnic"].Value.ToString();
                    comboDeparture.SelectedValue = dgvCustomer.Rows[e.RowIndex].Cells["CustDeparture"].Value.ToString();
                    comboArrival.SelectedValue = dgvCustomer.Rows[e.RowIndex].Cells["CustArrival"].Value.ToString();
                    comboBus.SelectedValue = dgvCustomer.Rows[e.RowIndex].Cells["CustBus"].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dgvCustomer.Rows[e.RowIndex].Cells["CustDate"].Value.ToString());

                    txtCustomerName.Enabled = false;
                    comboGender.Enabled = false;
                    txtContact.Enabled = false;
                    txtCnic.Enabled = false;
                    comboDeparture.Enabled = false;
                    comboArrival.Enabled = false;
                    comboBus.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    picCustomer.Enabled = false;
                    btnBrowse.Enabled = false;
                    btnAdd.Enabled = false;


                    Image img = Properties.Resources.icons8_no_image_100;
                    MemoryStream ms = new MemoryStream(customer.CustImage);
                    img = Image.FromStream(ms);
                    picCustomer.Image = img;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       */

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //setDataInGridView();
        }

        private void btnPrintTicket_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ticket tic = new Ticket();
            tic.Show();
        }
    }
}
