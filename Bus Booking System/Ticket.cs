using Bus_Booking_System.Model;
using Bus_Booking_System.Reports;
using System;
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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cust = new CustomerForm();
            cust.Show();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {
                TicketReport ticketReport = new TicketReport();
                BBSEntities db = new BBSEntities();
                var data = (from customer in db.Customers
                            select new
                            {
                                CustID = customer.CustID,
                                CustName = customer.CustName,
                                CustContact = customer.CustContact,
                                CustDeparture = customer.CustDeparture,
                                CustArrival = customer.CustArrival,
                                CustDate = customer.CustDate,
                                CustBus = customer.CustBus,
                                CustPrice = customer.CustPrice,

                            }).ToList();

                ticketReport.Database.Tables["Customer"].SetDataSource(data);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = ticketReport;
                crystalReportViewer1.Update();
                crystalReportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
