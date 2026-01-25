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
    public partial class Memberships : Form
    {
        DataconFun Con; 
        public Memberships()
        {
            InitializeComponent();
            Con = new DataconFun();
            ShowMShips();
        }

        private void ShowMShips()
        {
            string Query = "select * from MembershipsTbl";
            MShipList.DataSource = Con.GetData(Query);

        }

        private void ClearField ()
        {
            MNameTb.Text = "";
            MDurationTb.Text = "";
            GoalTb.Text = "";
            CostTb.Text = "";
        }

     

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MNameTb.Text == "" || MDurationTb.Text == "" || GoalTb.Text == "" || CostTb.Text == "" )
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    string MName = MNameTb.Text;
                    int Duration = Convert.ToInt32(MDurationTb.Text);
                    string Goal = GoalTb.Text;
                    int Cost = Convert.ToInt32(CostTb.Text);
                    
                    string Query = "insert into MembershipsTbl values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, MName, Duration,Goal,Cost);
                    Con.setData(Query);
                    ShowMShips();
                    MessageBox.Show("MemberShip Added Successfully");
                    

                    ClearField();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int key = 0;
        private void MShipList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || MShipList.Rows[e.RowIndex].IsNewRow) 
                return;

            if (e.RowIndex >= 0)
            {
                MNameTb.Text = MShipList.Rows[e.RowIndex].Cells["MName"].Value.ToString();
                MDurationTb.Text = MShipList.Rows[e.RowIndex].Cells["MDuration"].Value.ToString();
                GoalTb.Text = MShipList.Rows[e.RowIndex].Cells["MGoal"].Value.ToString();
                CostTb.Text = MShipList.Rows[e.RowIndex].Cells["MCost"].Value.ToString();

            }

            if (MNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(MShipList.Rows[e.RowIndex].Cells["MShipid"].Value.ToString());


            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Select a Membership!");
                    return;
                }

               
                string checkQuery = "SELECT COUNT(*) FROM MembersTbl WHERE MMembership = {0}";
                checkQuery = string.Format(checkQuery, key);
                DataTable dt = Con.GetData(checkQuery);

                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show(
                        "Cannot delete this membership.\nMembers are currently assigned to it.",
                        "Change Membership",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this membership?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    string Query = "DELETE FROM MembershipsTbl WHERE MShipId = {0}";
                    Query = string.Format(Query, key);
                    Con.setData(Query);

                    ShowMShips();
                    ClearField();
                    ShowTempMessage("Membership Deleted Successfully!");
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
                if (MNameTb.Text == "" || MDurationTb.Text == "" || GoalTb.Text == "" || CostTb.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    string MName = MNameTb.Text;
                    int Duration = Convert.ToInt32(MDurationTb.Text);
                    string Goal = GoalTb.Text;
                    int Cost = Convert.ToInt32(CostTb.Text);

                    string Query = " update MembershipsTbl set MName = '{0}', MDuration = {1},MGoal = '{2}',MCost = {3} where MShipid = {4}";
                    Query = string.Format(Query, MName, Duration, Goal, Cost,key);
                    Con.setData(Query);
                    ShowMShips();
                  
                   ShowTempMessage("MemberShip Updated Successfully!");

                    ClearField();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private async void ShowTempMessage(string msg)
        {
            LabelMsg.Text = msg;
            LabelMsg.Visible = true;

            await Task.Delay(2000);

            LabelMsg.Visible = false;
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

        private void MemberShipLbl_Click(object sender, EventArgs e)
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
