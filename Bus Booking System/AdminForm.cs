using Bus_Booking_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace Bus_Booking_System
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            setDataInGridView();

            FillGrid(ChangeType.None, Int64.MinValue);
            AdminTriggerStart();
        }

        private void ClearData()
        {
            txtCustomerName.Text = "";
            comboGender.Text = String.Empty;
            txtContact.Text = string.Empty;
            txtCnic.Text = string.Empty;
            comboDeparture.Text = String.Empty;
            comboArrival.Text = String.Empty;
            comboBus.Text = String.Empty;
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

        public void setDataInGridView()
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
                                CustPrice = cust.CustPrice,
                                CustDate = cust.CustDate,
                            }).ToList();

            dgvCustomer.Rows.Clear();
            dgvCustomer.DataSource = null;

            foreach (var cust in customer)
            {
                int RowIndex = dgvCustomer.Rows.Add();   //Add new Row

                dgvCustomer.Rows[RowIndex].Cells["CustomerID"].Value = cust.CustID;
                dgvCustomer.Rows[RowIndex].Cells["CustName"].Value = cust.CustName;
                dgvCustomer.Rows[RowIndex].Cells["CustGender"].Value = cust.CustGender;
                dgvCustomer.Rows[RowIndex].Cells["CustContact"].Value = cust.CustContact;
                dgvCustomer.Rows[RowIndex].Cells["CustCnic"].Value = cust.CustCnic;
                dgvCustomer.Rows[RowIndex].Cells["CustDeparture"].Value = cust.CustDeparture;
                dgvCustomer.Rows[RowIndex].Cells["CustArrival"].Value = cust.CustArrival;
                dgvCustomer.Rows[RowIndex].Cells["CustBus"].Value = cust.CustBus;
                dgvCustomer.Rows[RowIndex].Cells["CustPrice"].Value = cust.CustPrice;
                dgvCustomer.Rows[RowIndex].Cells["CustDate"].Value = cust.CustDate;
                //dgvStudent.Rows[RowIndex].Cells["DptID"].Value = std.DptID;


            }
            dgvCustomer.Update();
            dgvCustomer.Refresh();
        }


        string img_location = String.Empty;

        private void Form3_Load(object sender, EventArgs e)
        {
            setDataInGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adm = new AdminForm();
            adm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDetails cd = new CustomerDetails();
            cd.Show();
        }



       

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
        Customer cust = new Customer();
        long custId = 0;

        private SqlTableDependency<AdminTrigger> _sqlTableDependency;
        private delegate void UiCallback(ChangeType pChangeType, Int64 Std_SSN);


        private void RegisterForDatabaseEvents()
        {
            try
            {
                _sqlTableDependency = new SqlTableDependency<AdminTrigger>("Data Source=DESKTOP-0HAAVUT;Initial Catalog=BBS;Integrated Security=True", "Admin");
                _sqlTableDependency.OnChanged += OnDatabaseEventChanged;
                _sqlTableDependency.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occur in Triggering the Employee\n It may be internet issue or Enable Server Broker  " + ex.ToString(), "SQL Table Dependency Issue.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void OnDatabaseEventChanged(object sender, RecordChangedEventArgs<AdminTrigger> e)
        {
            try
            {
                if (!IsHandleCreated)
                    this.CreateControl();
                // Debug.WriteLine($"OnDatabaseEventChanged - {e.ChangeType} - {e.Entity.Emp_SSN} - {e.Entity.Emp_Status}- {e.Entity.Desg_Status}- {e.Entity.Status}");
                Invoke(new UiCallback(FillGrid), e.ChangeType, e.Entity.AdmID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "SQL Table Dependency Issue.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void FillGrid(ChangeType pChangeType, long Emp_SSN)
        {
            try
            {
                setDataInGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error," + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            }

        }

        public void AdminTriggerStart()
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        public void AdminTriggerStop()
        {

            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
       

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
                    cust.CustName = txtCustomerName.Text.Trim();
                    cust.CustGender = comboGender.Text.ToString();
                    cust.CustContact = txtContact.Text.Trim();
                    cust.CustCnic = txtCnic.Text.Trim();
                    cust.CustDeparture = comboDeparture.Text.ToString();
                    cust.CustArrival = comboArrival.Text.ToString();
                    cust.CustBus = comboBus.Text.ToString();
                    cust.CustDate = dateTimePicker1.Value;
                    cust.CustPrice = int.Parse(txtPrice.Text.Trim());
                    cust.CustImage = images;



                    //for crud operation
                    using (var db = new BBSEntities())
                    {
                        db.Customers.Add(cust);
                        db.SaveChanges();
                    }

                    ClearData();
                    setDataInGridView();
                    MessageBox.Show("Ticket Book Successfully");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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
                cust.CustName = txtCustomerName.Text.Trim();
                cust.CustGender = comboGender.Text.ToString();
                cust.CustContact = txtContact.Text.Trim();
                cust.CustCnic = txtCnic.Text.Trim();
                cust.CustDeparture = comboDeparture.Text.ToString();
                cust.CustArrival = comboArrival.Text.ToString();
                cust.CustBus = comboBus.Text.ToString();
                cust.CustDate = dateTimePicker1.Value;
                cust.CustPrice = int.Parse(txtPrice.Text.Trim());
                cust.CustImage = images;


                //for crud operation
                using (var db = new BBSEntities())
                {
                    var entry = db.Entry(cust);

                    if (entry.State == EntityState.Detached)
                        db.Customers.Attach(cust);

                    db.Entry(cust).State = EntityState.Modified;
                    db.SaveChanges();
                }

                ClearData();
                setDataInGridView();
                MessageBox.Show("Record Added Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtCustomerName.Enabled = true;
            comboGender.Enabled = true;
            txtContact.Enabled = true;
            txtCnic.Enabled = true;
            comboDeparture.Enabled = true;
            comboArrival.Enabled = true;
            comboBus.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtPrice.Enabled = true;
            picCustomer.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnBrowse.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                
                    using (var db = new BBSEntities())
                    {
                        // cust = db.Customers.Where(x => x.CustID == cust.CustID).First();
                        //cust = cust.CustID;


                        //db.Customers.Add(cust);

                       // db.Entry(custId).State = EntityState.Modified;



                        var entry = db.Entry(cust);

                        if (entry.State == EntityState.Detached)
                            db.Customers.Attach(cust);

                        db.Customers.Remove(cust);
                        db.SaveChanges();
                    
                    ClearData();
                    setDataInGridView();

                    MessageBox.Show("Record Deleted Successfully", "Deleted ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
      

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool i = true;
            if (i)
            {
                i = false;
                RegisterForDatabaseEvents();
            }
        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Details_Report cdr = new Customer_Details_Report();
            cdr.Show();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearData();
            try
            {

                if (e.RowIndex >= 0)
                {
                    custId = long.Parse(dgvCustomer.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString());
                    //load Employee Data
                    using (var db = new BBSEntities())
                    {
                        cust = db.Customers.Where(x => x.CustID == custId).First();
                    }

                    txtCustomerName.Text = dgvCustomer.Rows[e.RowIndex].Cells["CustName"].Value.ToString();
                    comboGender.Text = dgvCustomer.Rows[e.RowIndex].Cells["CustGender"].Value.ToString();
                    txtContact.Text = dgvCustomer.Rows[e.RowIndex].Cells["CustContact"].Value.ToString();
                    txtCnic.Text = dgvCustomer.Rows[e.RowIndex].Cells["CustCnic"].Value.ToString();
                    comboDeparture.Text = dgvCustomer.Rows[e.RowIndex].Cells["CustDeparture"].Value.ToString();
                    comboArrival.Text = dgvCustomer.Rows[e.RowIndex].Cells["CustArrival"].Value.ToString();
                    comboBus.Text = dgvCustomer.Rows[e.RowIndex].Cells["CustBus"].Value.ToString();
                    txtPrice.Text = dgvCustomer.Rows[e.RowIndex].Cells["CustPrice"].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dgvCustomer.Rows[e.RowIndex].Cells["CustDate"].Value.ToString());

                    txtCustomerName.Enabled = false;
                    comboGender.Enabled = false;
                    txtContact.Enabled = false;
                    txtCnic.Enabled = false;
                    comboDeparture.Enabled = false;
                    comboArrival.Enabled = false;
                    comboBus.Enabled = false;
                    txtPrice.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    picCustomer.Enabled = false;
                    btnBrowse.Enabled = false;
                    btnAdd.Enabled = false;

                    Image img = Properties.Resources.icons8_no_image_100;
                    MemoryStream ms = new MemoryStream(cust.CustImage);
                    img = Image.FromStream(ms);
                    picCustomer.Image = img;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class AdminTrigger
    {
        public int AdmID { get; set; }
        public string AdmName { get; set; }
        public string AdmPassword { get; set; }
        public int CustID { get; set; }

        public virtual Customer Customer { get; set; }
    }
   
}
