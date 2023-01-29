using System;
using Bus_Booking_System.Model;
using Bus_Booking_System.Reports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Booking_System
{
    public partial class Customer_Details_Report : Form
    {
        public Customer_Details_Report()
        {
            InitializeComponent();
        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerReport CustomerdetailsReport = new CustomerReport();
                BBSEntities db = new BBSEntities();
                var data = (from cust in db.Customers
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

                CustomerdetailsReport.Database.Tables["Customer"].SetDataSource(data);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = CustomerdetailsReport;
                crystalReportViewer1.Update();
                crystalReportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm cust = new AdminForm();
            cust.Show();
        }
    }
}
