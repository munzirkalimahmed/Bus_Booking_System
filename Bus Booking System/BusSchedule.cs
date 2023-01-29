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
    public partial class BusSchedule : Form
    {
        public BusSchedule()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

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

        private void FaisalMovers_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaisalMovers fm = new FaisalMovers();
            fm.Show();
        }

        private void btnWaraichExpress_Click(object sender, EventArgs e)
        {
            this.Hide();
            WaraichExpress we = new WaraichExpress();
            we.Show();
        }
    }
}
