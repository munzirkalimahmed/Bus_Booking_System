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
    public partial class WaraichExpress : Form
    {
        public WaraichExpress()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cust = new CustomerForm();
            cust.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusSchedule bs = new BusSchedule();
            bs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaisalMovers fm = new FaisalMovers();
            fm.Show();
        }
    }
}
