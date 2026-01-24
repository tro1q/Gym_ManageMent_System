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

                // 1️⃣ Insert coach
                string QueryCoach = @"INSERT INTO CoachsTbl
        (CName, CGen, CDOB, CPhone, CExperience, CAddress)
        VALUES ('{0}','{1}','{2}','{3}',{4},'{5}')";

                QueryCoach = string.Format(QueryCoach, CName, Gender, dob, Phone, experience, Add);
                Con.setData(QueryCoach);

                // 2️⃣ Get coach ID
                DataTable dt = Con.GetData("SELECT MAX(CId) AS LastId FROM CoachsTbl");
                int CoachId = Convert.ToInt32(dt.Rows[0]["LastId"]);

                // 3️⃣ Insert login
                string QueryUser = @"INSERT INTO UserTbl
        (Username, Password, Role, StaffId)
        VALUES ('{0}','{1}','Coach',{2})";

                QueryUser = string.Format(QueryUser, CName, Password, CoachId);
                Con.setData(QueryUser);

                // 4️⃣ Refresh
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
            //        if (e.RowIndex < 0 || CoachList.Rows[e.RowIndex].IsNewRow) 
            //            return;

            //        if (e.RowIndex >= 0)
            //        {
            //            ChNameTb.Text = CoachList.Rows[e.RowIndex].Cells["CName"].Value.ToString();
            //            GenCb.SelectedItem = CoachList.Rows[e.RowIndex].Cells["CGen"].Value.ToString();
            //            DOBTb.Value = Convert.ToDateTime(CoachList.Rows[e.RowIndex].Cells["CDOB"].Value);
            //            PhoneTb.Text = CoachList.Rows[e.RowIndex].Cells["CPhone"].Value.ToString();
            //            ExpTb.Text = CoachList.Rows[e.RowIndex].Cells["CExperience"].Value.ToString();
            //            AddTb.Text = CoachList.Rows[e.RowIndex].Cells["CAddress"].Value.ToString();
            //            // PassTb.Text = CoachList.Rows[e.RowIndex].Cells["CPass"].Value.ToString();

            //            DataTable dtUser = Con.GetData(
            //$"SELECT Password FROM UserTbl WHERE StaffId={key} AND Role='Coach'");

            //            if (dtUser.Rows.Count > 0)
            //                PassTb.Text = dtUser.Rows[0]["Password"].ToString();
            //        }

            //        if (ChNameTb.Text == "")
            //        {
            //            key = 0;
            //        }
            //        else
            //        {
            //            key = Convert.ToInt32(CoachList.Rows[e.RowIndex].Cells["CId"].Value.ToString());


            //        }
            //        

            if (e.RowIndex < 0 || CoachList.Rows[e.RowIndex].IsNewRow)
                return;

            // 1️⃣ Get CoachId FIRST
            key = Convert.ToInt32(CoachList.Rows[e.RowIndex].Cells["CId"].Value);

            // 2️⃣ Load coach info
            ChNameTb.Text = CoachList.Rows[e.RowIndex].Cells["CName"].Value.ToString();
            GenCb.SelectedItem = CoachList.Rows[e.RowIndex].Cells["CGen"].Value.ToString();
            DOBTb.Value = Convert.ToDateTime(CoachList.Rows[e.RowIndex].Cells["CDOB"].Value);
            PhoneTb.Text = CoachList.Rows[e.RowIndex].Cells["CPhone"].Value.ToString();
            ExpTb.Text = CoachList.Rows[e.RowIndex].Cells["CExperience"].Value.ToString();
            AddTb.Text = CoachList.Rows[e.RowIndex].Cells["CAddress"].Value.ToString();

            // 3️⃣ Load password from UserTbl
            DataTable dtUser = Con.GetData(
                $"SELECT Password FROM UserTbl WHERE StaffId={key} AND Role='Coach'"
            );

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

                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this coach?",
                                          "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                       
                        string Query = "delete from CoachsTbl where CId = {0}";
                        Query = string.Format(Query, key);
                        Con.setData(Query);
                        ShowCoach();
                        
                        ShowTempMessage("Coach Deleted Successfully");

                        ClearFields();
                    }
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

                }
                else
                {
                    string CName = ChNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Phone = PhoneTb.Text;
                    int experience = Convert.ToInt32(ExpTb.Text);
                    string Add = AddTb.Text;
                    string Password = PassTb.Text;
                    //string Query = "update CoachsTbl set CName = '{0}',CGen = '{1}',CDOB = '{2}',CPhone = '{3}',CExperience = '{4}',CAddress = '{5}',CPass = '{6}' where CID = {7}";
                    //Query = string.Format(Query, CName, Gender, DOBTb.Value.Date, Phone, experience, Add, Password,key);
                    //Con.setData(Query);

                    // Update personal info
                    string QueryCoach = "UPDATE CoachsTbl SET CName='{0}', CGen='{1}', CDOB='{2}', CPhone='{3}', CExperience={4}, CAddress='{5}' WHERE CId={6}";
                    QueryCoach = string.Format(QueryCoach, CName, Gender, DOBTb.Value.ToString("yyyy-MM-dd"), Phone, experience, Add, key);
                    Con.setData(QueryCoach);

                    // Update user info
                    string QueryUser = "UPDATE UserTbl SET Username='{0}', Password='{1}' WHERE StaffId={2} AND Role='Coach'";
                    QueryUser = string.Format(QueryUser, CName, Password, key);
                    Con.setData(QueryUser);


                    ShowCoach();
                    MessageBox.Show("Coach Updated Successfully");
                    ShowTempMessage("Coach Updated!!");
                    ClearFields();

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
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

