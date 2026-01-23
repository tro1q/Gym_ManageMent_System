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
    public partial class Members : Form
    {
        DataconFun Con;
        public Members()
        {
            InitializeComponent();
            Con = new DataconFun();
            ShowMembers();
            GetCoaches();
            GetMships();
        }

        private void ShowMembers()
        {
           
            string Query = "SELECT* FROM MembersTbl WHERE IsDeleted = 0";
            MembersList.DataSource = Con.GetData(Query);
            if (MembersList.Columns["IsDeleted"] != null)
                MembersList.Columns["IsDeleted"].Visible = false;

        }

        private void Members_Load(object sender, EventArgs e)
        {

        }

        string role = Login.UserRole;
        private void CoachLbl_Click(object sender, EventArgs e)
        {
            if (role == "Coach")
            {
                MessageBox.Show("Access Denied");
                return;
            }
            Coach coach = new Coach();
            coach.Show();
            this.Hide();
        }

        private void MemberLbl_Click(object sender, EventArgs e)
        {
           
            Members members = new Members();
            members.Show();
            this.Hide();
        }

        private void MemberShiplbl_Click(object sender, EventArgs e)
        {
            if (role == "Coach")
            {
                MessageBox.Show("Access Denied");
                return;
            }
            Memberships memberships = new Memberships();
            memberships.Show();
            this.Hide();
        }

        private void RecepLbl_Click(object sender, EventArgs e)
        {
            if (role == "Coach" || role == "Receptionist")
            {
                MessageBox.Show("Access Denied");
                return;
            }
            Receptionist receptionist = new Receptionist();
            receptionist.Show();
            this.Hide();
        }

        private void BillLbl_Click(object sender, EventArgs e)
        {
            if (role == "Coach")
            {
                MessageBox.Show("Access Denied");
                return;
            }
            Bill bill = new Bill();
            bill.Show();
            this.Hide();
        }

     

        private void LogOut_Click(object sender, EventArgs e)
        {
           Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void GetCoaches()
        {
            string Query = "select * from CoachsTbl";
            CoachCb.DisplayMember = Con.GetData(Query).Columns["CName"].ToString();
            CoachCb.ValueMember = Con.GetData(Query).Columns["CId"].ToString();
            CoachCb.DataSource = Con.GetData(Query);
        }

        private void GetMships()
        {
            string Query = "select * from MembershipsTbl";
            MShipCb.DisplayMember = Con.GetData(Query).Columns["MName"].ToString();
            MShipCb.ValueMember = Con.GetData(Query).Columns["MshipId"].ToString();
            MShipCb.DataSource = Con.GetData(Query);
        }

        int key = 0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MNameTb.Text == "" || PhoneTb.Text == "" || CoachCb.SelectedIndex == -1 || GenCb.SelectedIndex == -1 || MShipCb.SelectedIndex == -1 ||
                    StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    string MName = MNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Phone = PhoneTb.Text;
                    string DOB = DOBTb.Value.ToString("yyyy-MM-dd");
                    string MJDate = JDateTb.Value.ToString("yyyy-MM-dd");
                    int MShip = Convert.ToInt32 (MShipCb.SelectedValue.ToString());
                    int Coach = Convert.ToInt32 (CoachCb.SelectedValue.ToString());
                    string Timing = TimingCb.SelectedItem.ToString();
                    string Status = StatusCb.SelectedItem.ToString();

                   
                    string Query = @" INSERT INTO MembersTbl 
                 (MName, MGen, MDOB, MJDate, MMembership, MCoach, MPhone, MTiming, MStatus)  VALUES 
                 ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";

                    Query = string.Format(Query, MName,Gender,DOB,MJDate,MShip,Coach,Phone,Timing,Status);
                    Con.setData(Query);
                  ShowMembers();
                    MessageBox.Show("Member Added Successfully");
                    ClearFields();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            MNameTb.Text = "";
            PhoneTb.Text = "";
            GenCb.SelectedIndex = -1;
            CoachCb.SelectedIndex = -1;
            MShipCb.SelectedIndex = -1;
            TimingCb.SelectedIndex = -1;
            StatusCb.SelectedIndex = -1;
        }

        private void MembersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || MembersList.Rows[e.RowIndex].IsNewRow) 
                return;

            if (e.RowIndex >= 0)
            {
               MNameTb.Text = MembersList.Rows[e.RowIndex].Cells["MName"].Value.ToString();
              GenCb.Text = MembersList.Rows[e.RowIndex].Cells["MGen"].Value.ToString();
                DOBTb.Text = MembersList.Rows[e.RowIndex].Cells["MDOB"].Value.ToString();
                JDateTb.Text = MembersList.Rows[e.RowIndex].Cells["MJDate"].Value.ToString();
                MShipCb.SelectedValue = MembersList.Rows[e.RowIndex].Cells["MMembership"].Value;
                CoachCb.SelectedValue = MembersList.Rows[e.RowIndex].Cells["MCoach"].Value;
                PhoneTb.Text = MembersList.Rows[e.RowIndex].Cells["MPhone"].Value.ToString();
                TimingCb.Text = MembersList.Rows[e.RowIndex].Cells["MTiming"].Value.ToString();
                StatusCb.Text = MembersList.Rows[e.RowIndex].Cells["MStatus"].Value.ToString();
               
            }

            if (MNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(MembersList.Rows[e.RowIndex].Cells["MId"].Value.ToString());


            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MNameTb.Text == "" || PhoneTb.Text == "" || CoachCb.SelectedIndex == -1 || GenCb.SelectedIndex == -1 || MShipCb.SelectedIndex == -1 ||
                    StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    string MName = MNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Phone = PhoneTb.Text;
                    string DOB = DOBTb.Value.ToString("yyyy-MM-dd");
                    string MJDate = JDateTb.Value.ToString("yyyy-MM-dd");
                    int MShip = Convert.ToInt32(MShipCb.SelectedValue.ToString());
                    int Coach = Convert.ToInt32(CoachCb.SelectedValue.ToString());
                    string Timing = TimingCb.SelectedItem.ToString();
                    string Status = StatusCb.SelectedItem.ToString();

 string Query = "update MembersTbl set MName = '{0}',MGen = '{1}',MDOB = '{2}',MJDate = '{3}',MMembership = '{4}',MCoach = '{5}',MPhone = '{6}',MTiming = '{7}',MStatus = '{8}'Where MId = {9}";
                    Query = string.Format(Query, MName, Gender, DOB, MJDate, MShip, Coach, Phone, Timing, Status,key);
                    Con.setData(Query);
                    ShowMembers();
                    MessageBox.Show("Member Updated Successfully");
                    ShowTempMessage("Member Updated Successfully");
                    ClearFields();
                }

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
                    MessageBox.Show("Select a Member");

                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this Receptionist?",
                                          "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                     
                        string Query = $"UPDATE MembersTbl SET IsDeleted = 1 WHERE MId = {key}";
                        Query = string.Format(Query, key);
                        Con.setData(Query);
                        ShowMembers();

                        ShowTempMessage("Member Deleted Successfully");

                        ClearFields();
                    }
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private async void ShowTempMessage(string msg)
        {
            LabelMsg1.Text = msg;
            LabelMsg1.Visible = true;

            await Task.Delay(2000);

            LabelMsg1.Visible = false;
        }

        private void TrackerLbl_Click(object sender, EventArgs e)
        {
            WorkoutTracker tracker = new WorkoutTracker();
            tracker.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
