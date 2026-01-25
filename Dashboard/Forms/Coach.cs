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
using System.Xml.Linq;

namespace Dashboard
{
    public partial class Coach : Form
    {
        DataconFun Con;
        public Coach()
        {
            InitializeComponent();
            Con = new DataconFun();
            ShowCoach();
        }

        private void Coach_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShowCoach()
        {
            string Query = "select * from CoachsTbl";
            CoachList.DataSource = Con.GetData(Query);

        }

       
        private void SaveBtn_Click(object sender, EventArgs e)
        {

           

            try
            {
                if (ChNameTb.Text == "" || PhoneTb.Text == "" ||
                    ExpTb.Text == "" || PassTb.Text == "" ||
                    AddTb.Text == "" || GenCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Information");
                    return;
                }

                string CName = ChNameTb.Text;
                string Gender = GenCb.SelectedItem.ToString();
                string Phone = PhoneTb.Text;
                int experience = Convert.ToInt32(ExpTb.Text);
                string Add = AddTb.Text;
                string Password = PassTb.Text;
                string dob = DOBTb.Value.ToString("yyyy-MM-dd");

              
                string QueryUser = $@"
            INSERT INTO UserTbl (Username, Password, Role) 
            OUTPUT INSERTED.UserId
            VALUES ('{CName}', '{Password}', 'Coach')";

                DataTable dtUser = Con.GetData(QueryUser);

                if (dtUser.Rows.Count == 0 || dtUser.Rows[0]["UserId"] == DBNull.Value)
                {
                    MessageBox.Show("Error creating User account.");
                    return;
                }

                int userId = Convert.ToInt32(dtUser.Rows[0]["UserId"]);

             
                string QueryCoach = $@"
            INSERT INTO CoachsTbl (CName, CGen, CDOB, CPhone, CExperience, CAddress, UserId)
            VALUES ('{CName}', '{Gender}', '{dob}', '{Phone}', {experience}, '{Add}', {userId})";

                Con.setData(QueryCoach);

                ShowCoach();
                ClearFields();
                MessageBox.Show("Coach Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void CoachList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        int key = 0;
        private void CoachList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || CoachList.Rows[e.RowIndex].IsNewRow) return;

            key = Convert.ToInt32(CoachList.Rows[e.RowIndex].Cells["CId"].Value);

            ChNameTb.Text = CoachList.Rows[e.RowIndex].Cells["CName"].Value.ToString();
            GenCb.SelectedItem = CoachList.Rows[e.RowIndex].Cells["CGen"].Value.ToString();
            DOBTb.Value = Convert.ToDateTime(CoachList.Rows[e.RowIndex].Cells["CDOB"].Value);
            PhoneTb.Text = CoachList.Rows[e.RowIndex].Cells["CPhone"].Value.ToString();
            ExpTb.Text = CoachList.Rows[e.RowIndex].Cells["CExperience"].Value.ToString();
            AddTb.Text = CoachList.Rows[e.RowIndex].Cells["CAddress"].Value.ToString();

            DataTable dtUser = Con.GetData($"SELECT Password FROM UserTbl WHERE UserId = (SELECT UserId FROM CoachsTbl WHERE CId={key})");
            if (dtUser.Rows.Count > 0)
                PassTb.Text = dtUser.Rows[0]["Password"].ToString();
            else
                PassTb.Clear();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Select a Coach");
                    return;
                }

             
                DataTable dtUser = Con.GetData($"SELECT UserId FROM CoachsTbl WHERE CId={key}");
                if (dtUser.Rows.Count == 0)
                {
                    MessageBox.Show("Coach not found!");
                    return;
                }
                int userId = Convert.ToInt32(dtUser.Rows[0]["UserId"]);

           
                DialogResult result = MessageBox.Show("Are you sure you want to delete this coach?",
                                                      "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                   
                    string Query = $"DELETE FROM UserTbl WHERE UserId={userId}";
                    Con.setData(Query);

                    ShowCoach();
                    ShowTempMessage("Coach Deleted Successfully");
                    ClearFields();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }



        private void EditBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (ChNameTb.Text == "" || PhoneTb.Text == "" || ExpTb.Text == "" || PassTb.Text == "" || AddTb.Text == "" || GenCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Information");
                    return;
                }

                string CName = ChNameTb.Text;
                string Gender = GenCb.SelectedItem.ToString();
                string Phone = PhoneTb.Text;
                int experience = Convert.ToInt32(ExpTb.Text);
                string Add = AddTb.Text;
                string Password = PassTb.Text;
                string dob = DOBTb.Value.ToString("yyyy-MM-dd");

               
                DataTable dtUser = Con.GetData($"SELECT UserId FROM CoachsTbl WHERE CId={key}");
                if (dtUser.Rows.Count == 0)
                {
                    MessageBox.Show("Coach not found!");
                    return;
                }
                int userId = Convert.ToInt32(dtUser.Rows[0]["UserId"]);

             
                string QueryCoach = $"UPDATE CoachsTbl SET CName='{CName}', CGen='{Gender}', CDOB='{dob}', CPhone='{Phone}', CExperience={experience}, CAddress='{Add}' WHERE CId={key}";
                Con.setData(QueryCoach);

                string QueryUser = $"UPDATE UserTbl SET Username='{CName}', Password='{Password}' WHERE UserId={userId}";
                Con.setData(QueryUser);

                ShowCoach();
                ClearFields();
                MessageBox.Show("Coach Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void ClearFields()
        {
            ChNameTb.Text = "";
            GenCb.SelectedIndex = -1;
            DOBTb.Value = DateTime.Now;
            PhoneTb.Text = "";
            ExpTb.Text = "";
            AddTb.Text = "";
            PassTb.Text = "";
            key = 0;
        }
        private async void ShowTempMessage(string msg)
        {
            LabelMsg.Text = msg;
            LabelMsg.Visible = true;

            await Task.Delay(2000);

            LabelMsg.Visible = false;
        }

        private void MemberLbl_Click(object sender, EventArgs e)
        {
            Members Obj = new Members();
            Obj.Show();
            this.Hide();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        string role = Login.UserRole;
        private void CoachLabel_Click(object sender, EventArgs e)
        {
            if (role == "Coach")
            {
                MessageBox.Show("Access Denied");
                return;
            }
            Coach Obj = new Coach();
            Obj.Show();
            this.Hide();
        }

        private void MemberLbl_Click_1(object sender, EventArgs e)
        {
           
            Members Obj = new Members();
            Obj.Show();
            this.Hide();
        }

        private void MemberShipLbl_Click(object sender, EventArgs e)
        {
            if (role == "Coach")
            {
                MessageBox.Show("Access Denied");
                return;
            }
            Memberships Obj = new Memberships();
            Obj.Show();
            this.Hide();
        }

        private void RecepLbl_Click(object sender, EventArgs e)
        {
            if (role == "Coach" || role == "Receptionist")
            {
                MessageBox.Show("Access Denied");
                return;
            }
            Receptionist Obj = new Receptionist();
            Obj.Show();
            this.Hide();
        }

        private void BillLbl_Click(object sender, EventArgs e)
        {
            if (role == "Coach")
            {
                MessageBox.Show("Access Denied");
                return;
            }
            Bill Obj = new Bill();
            Obj.Show();
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }

}

