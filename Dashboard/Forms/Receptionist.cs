using Dashboard.DataCon;
using Dashboard.Forms;
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
    public partial class Receptionist : Form
    {
        DataconFun Con;
        public Receptionist()
        {
            InitializeComponent();
            Con = new DataconFun();
            ShowReceptionist();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowReceptionist()
        {
            string Query = "select * from ReceptionistTbl";
            RecepList.DataSource = Con.GetData(Query);

        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (RecepNameTb.Text == "" || RecepAddTb.Text == "" || PhoneTb.Text == "" || GenCb.SelectedIndex == -1 || PasswordTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                    return;
                }

                string RName = RecepNameTb.Text;
                string Gender = GenCb.SelectedItem.ToString();
                string Phone = PhoneTb.Text;
                string Add = RecepAddTb.Text;
                string Password = PasswordTb.Text;
                string dob = RecepDOBTb.Value.ToString("yyyy-MM-dd");

              
                string Query1 = @"INSERT INTO ReceptionistTbl (RecepName, RecepGen, RecepDOB, RecepAdd, RecepPhone)
                                        VALUES ('{0}','{1}','{2}','{3}','{4}')";
                  Query1 = string.Format(Query1, RName, Gender, dob, Add, Phone);
                   Con.setData(Query1);


                 DataTable dt = Con.GetData("SELECT TOP 1 ReceptId FROM ReceptionistTbl ORDER BY ReceptId DESC");
                 int staffId = Convert.ToInt32(dt.Rows[0]["ReceptId"]);


                 string Query2 = @"INSERT INTO UserTbl (Username, Password, Role, StaffId) VALUES ('{0}','{1}','Receptionist',{2})";
                  Query2 = string.Format(Query2, RName, Password, staffId);
                   Con.setData(Query2);



                ShowReceptionist();
                MessageBox.Show("Receptionist Updated Successfully!");
                ClearFields();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Select a Receptionist");

                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this Receptionist?",
                                          "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        

                        
                        string Query1 = $"DELETE FROM UserTbl WHERE StaffId={key} AND Role='Receptionist'";
                        Con.setData(Query1);

                        string Query2 = $"DELETE FROM ReceptionistTbl WHERE ReceptId={key}";
                        Con.setData(Query2);



                        ShowReceptionist();

                        ShowTempMessage("Receptionist Deleted Successfully");

                        ClearFields();
                    }
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            

            try
            {
               
                if (RecepNameTb.Text == "" || RecepAddTb.Text == "" || PhoneTb.Text == "" || GenCb.SelectedIndex == -1 || PasswordTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                    return;
                }

               
                string RName = RecepNameTb.Text;
                string Gender = GenCb.SelectedItem.ToString();
                string Phone = PhoneTb.Text;
                string Add = RecepAddTb.Text;
                string Password = PasswordTb.Text;
                string dob = RecepDOBTb.Value.ToString("yyyy-MM-dd");

                
                string Query1 = "INSERT INTO ReceptionistTbl (RecepName, RecepGen, RecepDOB, RecepAdd, RecepPhone) " +
                                "VALUES ('{0}','{1}','{2}','{3}','{4}')";
                Query1 = string.Format(Query1, RName, Gender, dob, Add, Phone);
                Con.setData(Query1);

               
                DataTable dt = Con.GetData("SELECT TOP 1 ReceptId FROM ReceptionistTbl ORDER BY ReceptId DESC");
                int staffId = Convert.ToInt32(dt.Rows[0]["ReceptId"]);

               
                string Query2 = "INSERT INTO UserTbl (Username, Password, Role, StaffId) " +
                                "VALUES ('{0}','{1}','Receptionist',{2})";
                Query2 = string.Format(Query2, RName, Password, staffId);
                Con.setData(Query2);

               
                ShowReceptionist();
                MessageBox.Show("Receptionist Added Successfully");
                ClearFields();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void ClearFields()
        {
            RecepNameTb.Text = "";
            GenCb.SelectedIndex = -1;
            PhoneTb.Text = "";
            RecepAddTb.Text = "";
            PasswordTb.Text = "";
        }

        private async void ShowTempMessage(string msg)
        {
            LabelMsg.Text = msg;
            LabelMsg.Visible = true;

            await Task.Delay(2000);

            LabelMsg.Visible = false;
        }

        int key = 0;
        private void RecepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (e.RowIndex < 0 || RecepList.Rows[e.RowIndex].IsNewRow)
                return;

            
            key = Convert.ToInt32(RecepList.Rows[e.RowIndex].Cells["ReceptId"].Value);

            
            RecepNameTb.Text = RecepList.Rows[e.RowIndex].Cells["RecepName"].Value.ToString();
            GenCb.SelectedItem = RecepList.Rows[e.RowIndex].Cells["RecepGen"].Value.ToString();
            RecepDOBTb.Text = RecepList.Rows[e.RowIndex].Cells["RecepDOB"].Value.ToString();
            RecepAddTb.Text = RecepList.Rows[e.RowIndex].Cells["RecepAdd"].Value.ToString();
            PhoneTb.Text = RecepList.Rows[e.RowIndex].Cells["RecepPhone"].Value.ToString();

           
            DataTable dtUser = Con.GetData(
                $"SELECT Password FROM UserTbl WHERE StaffId={key} AND Role='Receptionist'"
            );

            if (dtUser.Rows.Count > 0)
                PasswordTb.Text = dtUser.Rows[0]["Password"].ToString();
            else
                PasswordTb.Text = "";
        }


        string role = Login.UserRole;
        private void CoachLabel_Click(object sender, EventArgs e)
        {
           
            if(role == "Coach")
            {
                MessageBox.Show("Access Denied");
                return;
            }
            Coach Obj = new Coach();
            Obj.Show();
            this.Hide();
        }

        private void MemberLbl_Click(object sender, EventArgs e)
        {
            Members obj = new Members();
            obj.Show();
            this.Hide();
        }

        private void MemberShipLbl_Click(object sender, EventArgs e)
        {
            Memberships obj = new Memberships();
            obj.Show();
            this.Hide();
        }

        private void RecepLbl_Click(object sender, EventArgs e)
        {
            if (role == "Coach" || role == "Receptionist")
            {
                MessageBox.Show("Access Denied");
                return;
            }
            Receptionist obj = new Receptionist();
            obj.Show();
            this.Hide();
        }

        private void BillLbl_Click(object sender, EventArgs e)
        {
            if (role == "Coach")
            {
                MessageBox.Show("Access Denied");
                return;
            }
            Bill obj = new Bill();
            obj.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void TrackerLbl_Click(object sender, EventArgs e)
        {
            WorkoutTracker tracker = new WorkoutTracker();
            tracker.Show();
            this.Hide();
        }
    }
}
