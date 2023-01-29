namespace Bus_Booking_System
{
    partial class CustomerDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustCnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustID,
            this.CustName,
            this.CustGender,
            this.CustContact,
            this.CustCnic,
            this.CustDeparture,
            this.CustArrival,
            this.CustDate,
            this.CustBus,
            this.CustPrice});
            this.dgvCustomer.Location = new System.Drawing.Point(341, 118);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 62;
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.Size = new System.Drawing.Size(1085, 578);
            this.dgvCustomer.TabIndex = 2;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // CustID
            // 
            this.CustID.HeaderText = "ID";
            this.CustID.MinimumWidth = 8;
            this.CustID.Name = "CustID";
            // 
            // CustName
            // 
            this.CustName.HeaderText = "Name";
            this.CustName.MinimumWidth = 8;
            this.CustName.Name = "CustName";
            // 
            // CustGender
            // 
            this.CustGender.HeaderText = "Gender";
            this.CustGender.MinimumWidth = 8;
            this.CustGender.Name = "CustGender";
            // 
            // CustContact
            // 
            this.CustContact.HeaderText = "Contact no";
            this.CustContact.MinimumWidth = 8;
            this.CustContact.Name = "CustContact";
            // 
            // CustCnic
            // 
            this.CustCnic.HeaderText = "CNIC";
            this.CustCnic.MinimumWidth = 8;
            this.CustCnic.Name = "CustCnic";
            // 
            // CustDeparture
            // 
            this.CustDeparture.HeaderText = "Departure From";
            this.CustDeparture.MinimumWidth = 8;
            this.CustDeparture.Name = "CustDeparture";
            // 
            // CustArrival
            // 
            this.CustArrival.HeaderText = "Arrival To";
            this.CustArrival.MinimumWidth = 8;
            this.CustArrival.Name = "CustArrival";
            // 
            // CustDate
            // 
            this.CustDate.HeaderText = "Date";
            this.CustDate.MinimumWidth = 8;
            this.CustDate.Name = "CustDate";
            // 
            // CustBus
            // 
            this.CustBus.HeaderText = "Bus";
            this.CustBus.MinimumWidth = 8;
            this.CustBus.Name = "CustBus";
            // 
            // CustPrice
            // 
            this.CustPrice.HeaderText = "Price";
            this.CustPrice.MinimumWidth = 8;
            this.CustPrice.Name = "CustPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Customer";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(576, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 35);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Bus_Booking_System.Properties.Resources._20210120151022187;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 717);
            this.panel1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "Back ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 719);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "CustomerDetails";
            this.Text = "Customer details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustCnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustPrice;
    }
}