namespace Dashboard
{
    partial class Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MemberCb = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BillPanel = new System.Windows.Forms.Panel();
            this.BillingList = new System.Windows.Forms.DataGridView();
            this.BDateTb = new System.Windows.Forms.DateTimePicker();
            this.PeriodTb = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.TrackerLbl = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Label();
            this.BillLbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.MemberShipLbl = new System.Windows.Forms.Label();
            this.RecepLbl = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MemberLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CoachLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.BillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillingList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.MemberCb);
            this.panel5.Controls.Add(this.AddBtn);
            this.panel5.Controls.Add(this.PrintBtn);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.BillPanel);
            this.panel5.Controls.Add(this.BDateTb);
            this.panel5.Controls.Add(this.PeriodTb);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.AmountTb);
            this.panel5.Controls.Add(this.CancelBtn);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(130, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1033, 671);
            this.panel5.TabIndex = 9;
            // 
            // MemberCb
            // 
            this.MemberCb.FormattingEnabled = true;
            this.MemberCb.Location = new System.Drawing.Point(221, 154);
            this.MemberCb.Name = "MemberCb";
            this.MemberCb.Size = new System.Drawing.Size(197, 28);
            this.MemberCb.TabIndex = 46;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.AddBtn.Location = new System.Drawing.Point(221, 497);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 36);
            this.AddBtn.TabIndex = 45;
            this.AddBtn.Text = "Confirm";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.PrintBtn.Location = new System.Drawing.Point(295, 592);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(109, 36);
            this.PrintBtn.TabIndex = 44;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(219, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(217, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Billing Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(728, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Billing List";
            // 
            // BillPanel
            // 
            this.BillPanel.Controls.Add(this.BillingList);
            this.BillPanel.Location = new System.Drawing.Point(539, 107);
            this.BillPanel.Name = "BillPanel";
            this.BillPanel.Size = new System.Drawing.Size(481, 471);
            this.BillPanel.TabIndex = 40;
            // 
            // BillingList
            // 
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            this.BillingList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillingList.BackgroundColor = System.Drawing.Color.SeaShell;
            this.BillingList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BillingList.GridColor = System.Drawing.Color.Sienna;
            this.BillingList.Location = new System.Drawing.Point(0, 0);
            this.BillingList.Name = "BillingList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillingList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BillingList.RowHeadersWidth = 51;
            this.BillingList.Size = new System.Drawing.Size(481, 471);
            this.BillingList.TabIndex = 1;
            // 
            // BDateTb
            // 
            this.BDateTb.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BDateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDateTb.Location = new System.Drawing.Point(221, 327);
            this.BDateTb.Name = "BDateTb";
            this.BDateTb.Size = new System.Drawing.Size(252, 23);
            this.BDateTb.TabIndex = 39;
            // 
            // PeriodTb
            // 
            this.PeriodTb.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PeriodTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeriodTb.Location = new System.Drawing.Point(221, 238);
            this.PeriodTb.Name = "PeriodTb";
            this.PeriodTb.Size = new System.Drawing.Size(252, 23);
            this.PeriodTb.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(217, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Period";
            // 
            // AmountTb
            // 
            this.AmountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTb.Location = new System.Drawing.Point(221, 440);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(217, 26);
            this.AmountTb.TabIndex = 25;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Crimson;
            this.CancelBtn.Location = new System.Drawing.Point(377, 497);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(109, 36);
            this.CancelBtn.TabIndex = 19;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(217, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Member";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(494, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "Manage Billing";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.TrackerLbl);
            this.panel2.Controls.Add(this.LogOut);
            this.panel2.Controls.Add(this.BillLbl);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.MemberShipLbl);
            this.panel2.Controls.Add(this.RecepLbl);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.MemberLbl);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.CoachLbl);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 671);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::Dashboard.Properties.Resources.pic_1;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox7.Location = new System.Drawing.Point(22, 549);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(46, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 79;
            this.pictureBox7.TabStop = false;
            // 
            // TrackerLbl
            // 
            this.TrackerLbl.AutoSize = true;
            this.TrackerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.TrackerLbl.ForeColor = System.Drawing.Color.Black;
            this.TrackerLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TrackerLbl.Location = new System.Drawing.Point(74, 563);
            this.TrackerLbl.Name = "TrackerLbl";
            this.TrackerLbl.Size = new System.Drawing.Size(107, 24);
            this.TrackerLbl.TabIndex = 78;
            this.TrackerLbl.Text = "Attendence";
            this.TrackerLbl.Click += new System.EventHandler(this.TrackerLbl_Click);
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.Red;
            this.LogOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogOut.Location = new System.Drawing.Point(51, 626);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(89, 24);
            this.LogOut.TabIndex = 72;
            this.LogOut.Text = "Logout";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // BillLbl
            // 
            this.BillLbl.AutoSize = true;
            this.BillLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.BillLbl.ForeColor = System.Drawing.Color.Black;
            this.BillLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BillLbl.Location = new System.Drawing.Point(80, 488);
            this.BillLbl.Name = "BillLbl";
            this.BillLbl.Size = new System.Drawing.Size(60, 24);
            this.BillLbl.TabIndex = 52;
            this.BillLbl.Text = "Billing";
            this.BillLbl.Click += new System.EventHandler(this.BillLbl_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Dashboard.Properties.Resources.pic_1;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox5.Location = new System.Drawing.Point(23, 474);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 56;
            this.pictureBox5.TabStop = false;
            // 
            // MemberShipLbl
            // 
            this.MemberShipLbl.AutoSize = true;
            this.MemberShipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.MemberShipLbl.ForeColor = System.Drawing.Color.Black;
            this.MemberShipLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MemberShipLbl.Location = new System.Drawing.Point(68, 313);
            this.MemberShipLbl.Name = "MemberShipLbl";
            this.MemberShipLbl.Size = new System.Drawing.Size(116, 24);
            this.MemberShipLbl.TabIndex = 50;
            this.MemberShipLbl.Text = "Membership";
            this.MemberShipLbl.Click += new System.EventHandler(this.MemberShipLbl_Click);
            // 
            // RecepLbl
            // 
            this.RecepLbl.AutoSize = true;
            this.RecepLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.RecepLbl.ForeColor = System.Drawing.Color.Black;
            this.RecepLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RecepLbl.Location = new System.Drawing.Point(69, 399);
            this.RecepLbl.Name = "RecepLbl";
            this.RecepLbl.Size = new System.Drawing.Size(115, 24);
            this.RecepLbl.TabIndex = 51;
            this.RecepLbl.Text = "Reciptionists";
            this.RecepLbl.Click += new System.EventHandler(this.RecepLbl_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Dashboard.Properties.Resources.pic_1;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox6.Location = new System.Drawing.Point(17, 380);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 57;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Dashboard.Properties.Resources.pic_1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(17, 301);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // MemberLbl
            // 
            this.MemberLbl.AutoSize = true;
            this.MemberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.MemberLbl.ForeColor = System.Drawing.Color.Black;
            this.MemberLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MemberLbl.Location = new System.Drawing.Point(80, 223);
            this.MemberLbl.Name = "MemberLbl";
            this.MemberLbl.Size = new System.Drawing.Size(90, 24);
            this.MemberLbl.TabIndex = 49;
            this.MemberLbl.Text = "Members";
            this.MemberLbl.Click += new System.EventHandler(this.MemberLbl_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Dashboard.Properties.Resources.pic_1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(17, 222);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // CoachLbl
            // 
            this.CoachLbl.AutoSize = true;
            this.CoachLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.CoachLbl.ForeColor = System.Drawing.Color.Black;
            this.CoachLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CoachLbl.Location = new System.Drawing.Point(80, 158);
            this.CoachLbl.Name = "CoachLbl";
            this.CoachLbl.Size = new System.Drawing.Size(65, 24);
            this.CoachLbl.TabIndex = 48;
            this.CoachLbl.Text = "Coach";
            this.CoachLbl.Click += new System.EventHandler(this.CoachLbl_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Dashboard.Properties.Resources.pic_1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(17, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(74, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(56, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(55, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 100);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.dumbbell;
            this.pictureBox1.Location = new System.Drawing.Point(39, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(37, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 693);
            this.panel1.TabIndex = 8;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 713);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.BillPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BillingList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker BDateTb;
        private System.Windows.Forms.DateTimePicker PeriodTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BillPanel;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label BillLbl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label MemberShipLbl;
        private System.Windows.Forms.Label RecepLbl;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label MemberLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label CoachLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView BillingList;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox MemberCb;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label TrackerLbl;
    }
}