using System;
using Bus_Booking_System.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Bus_Booking_System
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
            setDataInGridView();
        }

         public void setDataInGridView()
        {
            var db = new BBSEntities();
            var customer = (from cust in db.Customers
                            //join adm in db.Admins
                            //on cust.CustID equals adm.CustID
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

                dgvCustomer.Rows[RowIndex].Cells["CustID"].Value = cust.CustID;
                dgvCustomer.Rows[RowIndex].Cells["CustName"].Value = cust.CustName;
                dgvCustomer.Rows[RowIndex].Cells["CustGender"].Value = cust.CustGender;
                dgvCustomer.Rows[RowIndex].Cells["CustContact"].Value = cust.CustContact;
                dgvCustomer.Rows[RowIndex].Cells["CustCnic"].Value = cust.CustContact;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adm = new AdminForm();
            adm.Show();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
