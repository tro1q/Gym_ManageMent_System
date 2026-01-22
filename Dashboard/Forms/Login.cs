using Dashboard.DataCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Login : Form
    {
        DataconFun Con;
        public Login()
        {
            InitializeComponent();
            Con = new DataconFun();
        }

        public static int UserId;
        public static string UserRole;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    string Query = "";

                   
                    if (RecepRb.Checked)
                    {
                        Query = @"SELECT * FROM ReceptionistTbl WHERE RecepName = '{0}' COLLATE Latin1_General_CS_AS AND RecepPass = '{1}' COLLATE Latin1_General_CS_AS";
                        Query = string.Format(Query, UNameTb.Text, PasswordTb.Text);

                        DataTable dt = Con.GetData(Query);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Invalid Receptionist!!");
                        }
                        else
                        {
                            UserId = Convert.ToInt32(dt.Rows[0]["ReceptId"]);
                            UserRole = "Receptionist";
                            Members obj = new Members();
                            obj.Show();
                            this.Hide();
                        }
                    }

                  
                    else if (CoachRb.Checked)
                    {
                        Query = @"SELECT * FROM CoachsTbl  WHERE CName = '{0}' COLLATE Latin1_General_CS_AS AND CPass = '{1}' COLLATE Latin1_General_CS_AS";
                        Query = string.Format(Query, UNameTb.Text, PasswordTb.Text);

                        DataTable dt = Con.GetData(Query);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Invalid Coach!!");
                        }
                        else
                        {
                            UserId = Convert.ToInt32(dt.Rows[0]["CId"]);
                           UserRole = "Coach";
                            Members obj = new Members();
                            obj.Show();
                            this.Hide();
                        }
                    }

                    // 🔹 No role selected
                    else
                    {
                        MessageBox.Show("Please select a login role");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AdmLbl_Click(object sender, EventArgs e)
        {

            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
                return;
            }

            try
            {
                string Query = "SELECT * FROM AdminTbl  WHERE AdminName = '{0}' COLLATE Latin1_General_CS_AS AND AdminPass = '{1}' COLLATE Latin1_General_CS_AS";
                Query = string.Format(Query, UNameTb.Text, PasswordTb.Text);

                DataTable dt = Con.GetData(Query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid Admin");
                    return;
                }

                Login.UserId = Convert.ToInt32(dt.Rows[0]["AdminId"]);
                Login.UserRole = "Admin";

               Members obj = new Members();
                obj.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
