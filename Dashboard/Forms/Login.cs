using Dashboard.DataCon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            //  if (UNameTb.Text == "" || PasswordTb.Text == "")
            //  {
            //      MessageBox.Show("Missing Information!!");
            //  }
            //  else
            //  {
            //      try
            //      {
            //          string Query = "";


            //          if (RecepRb.Checked)
            //          {

            //              //  Query = @"SELECT * FROM ReceptionistTbl WHERE RecepName = '{0}' COLLATE Latin1_General_CS_AS AND RecepPass = '{1}' COLLATE Latin1_General_CS_AS";

            //              Query = @"SELECT * FROM UserTbl 
            //WHERE Username='{0}' AND Password='{1}' AND Role='Coach'";





            //              Query = string.Format(Query, UNameTb.Text, PasswordTb.Text);

            //              DataTable dt = Con.GetData(Query);



            //              if (dt.Rows.Count == 0)
            //              {
            //                  MessageBox.Show("Invalid Receptionist!!");
            //              }
            //              else
            //              {
            //                  Login.UserId = Convert.ToInt32(dt.Rows[0]["UserId"]);
            //                  Login.UserRole = dt.Rows[0]["Role"].ToString();
            //                 // UserRole = "Receptionist";
            //                  Members obj = new Members();
            //                  obj.Show();
            //                  this.Hide();
            //              }
            //          }


            //          else if (CoachRb.Checked)
            //          {
            //              //Query = @"SELECT * FROM CoachsTbl  WHERE CName = '{0}' COLLATE Latin1_General_CS_AS AND CPass = '{1}' COLLATE Latin1_General_CS_AS";
            //              //Query = string.Format(Query, UNameTb.Text, PasswordTb.Text);

            //              Query = @"SELECT * FROM UserTbl WHERE Username = '{0}' AND Password = '{1}' AND Role='Coach'";
            //              Query = string.Format(Query, UNameTb.Text, PasswordTb.Text);

            //              DataTable dt = Con.GetData(Query);

            //              if (dt.Rows.Count == 0)
            //              {
            //                  MessageBox.Show("Invalid Coach!!");
            //              }
            //              else
            //              {
            //                  // UserId = Convert.ToInt32(dt.Rows[0]["CId"]);
            //                  //UserRole = "Coach";

            //                  Login.UserId = Convert.ToInt32(dt.Rows[0]["UserId"]);
            //                  Login.UserRole = dt.Rows[0]["Role"].ToString();


            //                  Members obj = new Members();
            //                  obj.Show();
            //                  this.Hide();
            //              }
            //          }

            //          else
            //          {
            //              MessageBox.Show("Please select a login role");
            //          }
            //      }
            //      catch (Exception Ex)
            //      {
            //          MessageBox.Show(Ex.Message);
            //      }
            //  }


            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
                return;
            }

            try
            {
                string role = "";

                if (RecepRb.Checked)
                    role = "Receptionist";
                else if (CoachRb.Checked)
                    role = "Coach";
                else
                {
                    MessageBox.Show("Please select a login role");
                    return;
                }

                string query = @"SELECT UserId, Role 
                         FROM UserTbl 
                         WHERE Username='{0}' AND Password='{1}' AND Role='{2}'";

                query = string.Format(query, UNameTb.Text, PasswordTb.Text, role);

                DataTable dt = Con.GetData(query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid Username or Password!");
                }
                else
                {
                    Login.UserId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                    Login.UserRole = dt.Rows[0]["Role"].ToString();

                    Members obj = new Members();   // or role-based form
                    obj.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                //string Query = "SELECT * FROM AdminTbl  WHERE AdminName = '{0}' COLLATE Latin1_General_CS_AS AND AdminPass = '{1}' COLLATE Latin1_General_CS_AS";

              string  Query = @"SELECT * FROM UserTbl 
          WHERE Username='{0}' AND Password='{1}' AND Role='Admin'";


                Query = string.Format(Query, UNameTb.Text, PasswordTb.Text);

                DataTable dt = Con.GetData(Query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid Admin");
                    return;
                }

                //Login.UserId = Convert.ToInt32(dt.Rows[0]["AdminId"]);
                //Login.UserRole = "Admin";

                Login.UserId = Convert.ToInt32(dt.Rows[0]["UserId"]);
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
