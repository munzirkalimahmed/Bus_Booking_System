namespace Bus_Booking_System
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCustomerReport = new System.Windows.Forms.Button();
            this.btnCustomerDetails = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboArrival = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDeparture = new System.Windows.Forms.ComboBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustCnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(722, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome Admin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 1036);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bus_Booking_System.Properties.Resources._20210120151022187;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 318);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnCustomerReport);
            this.panel2.Controls.Add(this.btnCustomerDetails);
            this.panel2.Controls.Add(this.btnAddCustomer);
            this.panel2.Location = new System.Drawing.Point(0, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 402);
            this.panel2.TabIndex = 0;
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.BackColor = System.Drawing.Color.Black;
            this.btnCustomerReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerReport.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomerReport.Location = new System.Drawing.Point(3, 311);
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Size = new System.Drawing.Size(288, 66);
            this.btnCustomerReport.TabIndex = 2;
            this.btnCustomerReport.Text = "Customer Report";
            this.btnCustomerReport.UseVisualStyleBackColor = false;
            this.btnCustomerReport.Click += new System.EventHandler(this.btnCustomerReport_Click);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BackColor = System.Drawing.Color.Black;
            this.btnCustomerDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerDetails.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomerDetails.Location = new System.Drawing.Point(3, 225);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(288, 66);
            this.btnCustomerDetails.TabIndex = 1;
            this.btnCustomerDetails.Text = "Customer Details";
            this.btnCustomerDetails.UseVisualStyleBackColor = false;
            this.btnCustomerDetails.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Black;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCustomer.Location = new System.Drawing.Point(0, 141);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(288, 66);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Image = global::Bus_Booking_System.Properties.Resources.icons8_browse_folder_48;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(1239, 359);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(243, 65);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browser";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button9_Click);
            // 
            // picCustomer
            // 
            this.picCustomer.Image = global::Bus_Booking_System.Properties.Resources.icons8_no_image_100;
            this.picCustomer.Location = new System.Drawing.Point(1239, 146);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(243, 197);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCustomer.TabIndex = 17;
            this.picCustomer.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Bus_Booking_System.Properties.Resources.icons8_edit_profile_48;
            this.btnEdit.Location = new System.Drawing.Point(1050, 146);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(174, 136);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Bus_Booking_System.Properties.Resources.icons8_update_user_48;
            this.btnUpdate.Location = new System.Drawing.Point(1050, 298);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 126);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Bus_Booking_System.Properties.Resources.icons8_denied_skin_type_7_48;
            this.btnDelete.Location = new System.Drawing.Point(870, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 126);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Bus_Booking_System.Properties.Resources.icons8_add_user_male_48;
            this.btnAdd.Location = new System.Drawing.Point(870, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 136);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBus
            // 
            this.comboBus.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBus.FormattingEnabled = true;
            this.comboBus.Items.AddRange(new object[] {
            "Daewoo Express",
            "Waraich Express",
            "Faisal Movers"});
            this.comboBus.Location = new System.Drawing.Point(608, 503);
            this.comboBus.Name = "comboBus";
            this.comboBus.Size = new System.Drawing.Size(224, 46);
            this.comboBus.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 38);
            this.label8.TabIndex = 57;
            this.label8.Text = "Bus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(313, 570);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 38);
            this.label7.TabIndex = 56;
            this.label7.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(608, 573);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 35);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // comboArrival
            // 
            this.comboArrival.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboArrival.FormattingEnabled = true;
            this.comboArrival.Items.AddRange(new object[] {
            "Karachi",
            "Lahore",
            "Islamabad",
            "Peshawar"});
            this.comboArrival.Location = new System.Drawing.Point(608, 436);
            this.comboArrival.Name = "comboArrival";
            this.comboArrival.Size = new System.Drawing.Size(224, 46);
            this.comboArrival.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 38);
            this.label6.TabIndex = 53;
            this.label6.Text = "Arrival To";
            // 
            // comboDeparture
            // 
            this.comboDeparture.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDeparture.FormattingEnabled = true;
            this.comboDeparture.Items.AddRange(new object[] {
            "Karachi",
            "Lahore",
            "Islamabad",
            "Peshawar"});
            this.comboDeparture.Location = new System.Drawing.Point(608, 372);
            this.comboDeparture.Name = "comboDeparture";
            this.comboDeparture.Size = new System.Drawing.Size(224, 46);
            this.comboDeparture.TabIndex = 4;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(608, 239);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(224, 44);
            this.txtContact.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 38);
            this.label5.TabIndex = 50;
            this.label5.Text = "Contact no";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 38);
            this.label4.TabIndex = 49;
            this.label4.Text = "Gender";
            // 
            // comboGender
            // 
            this.comboGender.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(608, 171);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(224, 46);
            this.comboGender.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 38);
            this.label3.TabIndex = 47;
            this.label3.Text = "Departure From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 38);
            this.label1.TabIndex = 46;
            this.label1.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(608, 100);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(224, 44);
            this.txtCustomerName.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 38);
            this.label9.TabIndex = 59;
            this.label9.Text = "CNIC";
            // 
            // txtCnic
            // 
            this.txtCnic.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnic.Location = new System.Drawing.Point(608, 309);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(224, 44);
            this.txtCnic.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(313, 640);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 38);
            this.label10.TabIndex = 61;
            this.label10.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(608, 634);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(224, 44);
            this.txtPrice.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1390, -8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 82);
            this.btnLogout.TabIndex = 77;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustName,
            this.CustGender,
            this.CustContact,
            this.CustCnic,
            this.CustDeparture,
            this.CustArrival,
            this.CustDate,
            this.CustBus,
            this.CustPrice});
            this.dgvCustomer.Location = new System.Drawing.Point(320, 692);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 62;
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1162, 346);
            this.dgvCustomer.TabIndex = 78;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.MinimumWidth = 8;
            this.CustomerID.Name = "CustomerID";
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1494, 798);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboArrival);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboDeparture);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picCustomer);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCustomerDetails;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox comboBus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboArrival;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboDeparture;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnLogout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnCustomerReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
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