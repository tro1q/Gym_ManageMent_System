namespace Dashboard.Forms
{
    partial class WorkoutTracker
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Label();
            this.BillLbl = new System.Windows.Forms.Label();
            this.MemberShipLbl = new System.Windows.Forms.Label();
            this.RecepLbl = new System.Windows.Forms.Label();
            this.MemberLbl = new System.Windows.Forms.Label();
            this.CoachLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.InactiveBtn = new System.Windows.Forms.Button();
            this.ActiveBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MembersDGV = new System.Windows.Forms.DataGridView();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MembersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 730);
            this.panel1.TabIndex = 9;
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.Red;
            this.LogOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogOut.Location = new System.Drawing.Point(63, 639);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(89, 24);
            this.LogOut.TabIndex = 80;
            this.LogOut.Text = "Logout";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // BillLbl
            // 
            this.BillLbl.AutoSize = true;
            this.BillLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.BillLbl.ForeColor = System.Drawing.Color.Black;
            this.BillLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BillLbl.Location = new System.Drawing.Point(92, 510);
            this.BillLbl.Name = "BillLbl";
            this.BillLbl.Size = new System.Drawing.Size(60, 24);
            this.BillLbl.TabIndex = 79;
            this.BillLbl.Text = "Billing";
            this.BillLbl.Click += new System.EventHandler(this.BillLbl_Click);
            // 
            // MemberShipLbl
            // 
            this.MemberShipLbl.AutoSize = true;
            this.MemberShipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.MemberShipLbl.ForeColor = System.Drawing.Color.Black;
            this.MemberShipLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MemberShipLbl.Location = new System.Drawing.Point(80, 335);
            this.MemberShipLbl.Name = "MemberShipLbl";
            this.MemberShipLbl.Size = new System.Drawing.Size(116, 24);
            this.MemberShipLbl.TabIndex = 77;
            this.MemberShipLbl.Text = "Membership";
            this.MemberShipLbl.Click += new System.EventHandler(this.MemberShipLbl_Click);
            // 
            // RecepLbl
            // 
            this.RecepLbl.AutoSize = true;
            this.RecepLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.RecepLbl.ForeColor = System.Drawing.Color.Black;
            this.RecepLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RecepLbl.Location = new System.Drawing.Point(81, 421);
            this.RecepLbl.Name = "RecepLbl";
            this.RecepLbl.Size = new System.Drawing.Size(115, 24);
            this.RecepLbl.TabIndex = 78;
            this.RecepLbl.Text = "Reciptionists";
            this.RecepLbl.Click += new System.EventHandler(this.RecepLbl_Click);
            // 
            // MemberLbl
            // 
            this.MemberLbl.AutoSize = true;
            this.MemberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.MemberLbl.ForeColor = System.Drawing.Color.Black;
            this.MemberLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MemberLbl.Location = new System.Drawing.Point(92, 245);
            this.MemberLbl.Name = "MemberLbl";
            this.MemberLbl.Size = new System.Drawing.Size(90, 24);
            this.MemberLbl.TabIndex = 76;
            this.MemberLbl.Text = "Members";
            this.MemberLbl.Click += new System.EventHandler(this.MemberLbl_Click);
            // 
            // CoachLbl
            // 
            this.CoachLbl.AutoSize = true;
            this.CoachLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.CoachLbl.ForeColor = System.Drawing.Color.Black;
            this.CoachLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CoachLbl.Location = new System.Drawing.Point(92, 165);
            this.CoachLbl.Name = "CoachLbl";
            this.CoachLbl.Size = new System.Drawing.Size(65, 24);
            this.CoachLbl.TabIndex = 75;
            this.CoachLbl.Text = "Coach";
            this.CoachLbl.Click += new System.EventHandler(this.CoachLbl_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(15, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 100);
            this.panel3.TabIndex = 74;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.LogOut);
            this.panel2.Controls.Add(this.CoachLbl);
            this.panel2.Controls.Add(this.BillLbl);
            this.panel2.Controls.Add(this.MemberLbl);
            this.panel2.Controls.Add(this.MemberShipLbl);
            this.panel2.Controls.Add(this.RecepLbl);
            this.panel2.Location = new System.Drawing.Point(74, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 730);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Dashboard.Properties.Resources.pic_1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(28, 493);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Dashboard.Properties.Resources.pic_1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(29, 406);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Dashboard.Properties.Resources.pic_1;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox5.Location = new System.Drawing.Point(28, 320);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Dashboard.Properties.Resources.pic_1;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox6.Location = new System.Drawing.Point(29, 236);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 58;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox7.BackgroundImage = global::Dashboard.Properties.Resources.pic_1;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox7.Location = new System.Drawing.Point(28, 154);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(46, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 59;
            this.pictureBox7.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Linen;
            this.panel4.Controls.Add(this.InactiveBtn);
            this.panel4.Controls.Add(this.ActiveBtn);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.SearchLbl);
            this.panel4.Controls.Add(this.SearchTb);
            this.panel4.Location = new System.Drawing.Point(313, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 713);
            this.panel4.TabIndex = 11;
            // 
            // InactiveBtn
            // 
            this.InactiveBtn.Location = new System.Drawing.Point(683, 117);
            this.InactiveBtn.Name = "InactiveBtn";
            this.InactiveBtn.Size = new System.Drawing.Size(119, 36);
            this.InactiveBtn.TabIndex = 4;
            this.InactiveBtn.Text = "Inactive";
            this.InactiveBtn.UseVisualStyleBackColor = true;
            this.InactiveBtn.Click += new System.EventHandler(this.InactiveBtn_Click);
            // 
            // ActiveBtn
            // 
            this.ActiveBtn.Location = new System.Drawing.Point(683, 40);
            this.ActiveBtn.Name = "ActiveBtn";
            this.ActiveBtn.Size = new System.Drawing.Size(119, 36);
            this.ActiveBtn.TabIndex = 3;
            this.ActiveBtn.Text = "Active";
            this.ActiveBtn.UseVisualStyleBackColor = true;
            this.ActiveBtn.Click += new System.EventHandler(this.ActiveBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.MembersDGV);
            this.panel5.Location = new System.Drawing.Point(12, 228);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(958, 475);
            this.panel5.TabIndex = 2;
            // 
            // MembersDGV
            // 
            this.MembersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MembersDGV.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MembersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MembersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembersDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembersDGV.Location = new System.Drawing.Point(0, 0);
            this.MembersDGV.Name = "MembersDGV";
            this.MembersDGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MembersDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MembersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembersDGV.Size = new System.Drawing.Size(958, 475);
            this.MembersDGV.TabIndex = 0;
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(25, 33);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(81, 13);
            this.SearchLbl.TabIndex = 1;
            this.SearchLbl.Text = "Search member";
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(28, 49);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(249, 20);
            this.SearchTb.TabIndex = 0;
            this.SearchTb.TextChanged += new System.EventHandler(this.SearchTb_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // WorkoutTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 733);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WorkoutTracker";
            this.Text = "WorkoutTracker";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MembersDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Label BillLbl;
        private System.Windows.Forms.Label MemberShipLbl;
        private System.Windows.Forms.Label RecepLbl;
        private System.Windows.Forms.Label MemberLbl;
        private System.Windows.Forms.Label CoachLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView MembersDGV;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Button InactiveBtn;
        private System.Windows.Forms.Button ActiveBtn;
        private System.Windows.Forms.Timer timer1;
    }
}