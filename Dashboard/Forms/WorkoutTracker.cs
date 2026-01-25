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

namespace Dashboard.Forms
{
    public partial class WorkoutTracker : Form
    {
        DataconFun Con;
        public WorkoutTracker()
        {
            InitializeComponent();
            Con = new DataconFun();
            LoadTrackerGrid();

            timer1.Interval = 1000; 
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }




        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            LoadTrackerGrid(SearchTb.Text);
        }


        private void ActiveBtn_Click(object sender, EventArgs e)
        {
            if (MembersDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a member to start workout!");
                return;
            }

            int memberId = Convert.ToInt32(MembersDGV.SelectedRows[0].Cells["MId"].Value);

           
            DataTable checkActive = Con.GetData($"SELECT * FROM TrackerTbl WHERE MemberId={memberId} AND Status='Active'");
            if (checkActive.Rows.Count > 0)
            {
                MessageBox.Show("This member is already active!");
                return;
            }

           
            DataTable dt = Con.GetData($"SELECT MDuration FROM MembershipsTbl WHERE MShipId=(SELECT MMembership FROM MembersTbl WHERE MId={memberId})");
            int duration = Convert.ToInt32(dt.Rows[0][0]);

            
            string query = $@"INSERT INTO TrackerTbl (MemberId, StartTime, Status, Duration)
        VALUES ({memberId}, '{DateTime.Now}', 'Active', {duration})";

            Con.setData(query);
            LoadTrackerGrid();

        }

        private void InactiveBtn_Click(object sender, EventArgs e)
        {

            if (MembersDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a member to end workout!");
                return;
            }

           
            DataGridViewRow row = MembersDGV.SelectedRows[0];
            if (row.Cells["SessionId"].Value == DBNull.Value)
            {
                MessageBox.Show("This member does not have an active session!");
                return;
            }

            int sessionId = Convert.ToInt32(row.Cells["SessionId"].Value);

            string query = $@"
                UPDATE TrackerTbl
                SET EndTime='{DateTime.Now}', Status='Finished'
                WHERE SessionId={sessionId}";

            Con.setData(query);
            LoadTrackerGrid();
        }


        private void LoadTrackerGrid(string search = "")
        {
            string query = @" SELECT  m.MId, m.MName, ms.MName AS PackageName, t.SessionId, t.StartTime, ISNULL(t.Status, 'Inactive') AS Status,
        t.Duration FROM MembersTbl m JOIN MembershipsTbl ms ON m.MMembership = ms.MShipId LEFT JOIN TrackerTbl t 
        ON m.MId = t.MemberId AND t.Status='Active' WHERE m.IsDeleted = 0"; 


            if (!string.IsNullOrWhiteSpace(search))
            {
                query += $" AND m.MName LIKE '%{search}%'";
            }

            MembersDGV.DataSource = Con.GetData(query);
        }


 


        private void timer1_Tick_1(object sender, EventArgs e)
        {

            try
            {
              
                timer1.Stop();

               
                DataTable dt = Con.GetData(@" SELECT t.SessionId, t.MemberId, t.StartTime, t.Duration, m.MName
           FROM TrackerTbl t JOIN MembersTbl m ON t.MemberId = m.MId WHERE t.Status='Active'");

                foreach (DataRow row in dt.Rows)
                {
                    int sessionId = Convert.ToInt32(row["SessionId"]);
                    string memberName = row["MName"].ToString();
                    DateTime startTime = Convert.ToDateTime(row["StartTime"]);
                    int durationHours = Convert.ToInt32(row["Duration"]);

                    DateTime endTime = startTime.AddHours(durationHours); 

                    if (DateTime.Now >= endTime)
                    {
                        
                        string query = $"UPDATE TrackerTbl SET EndTime='{DateTime.Now}', Status='Finished' WHERE SessionId={sessionId}";
                        Con.setData(query);

                       
                        MessageBox.Show($"Member {memberName} has completed their workout time!", "Workout Finished");

                        
                        LoadTrackerGrid();
                    }
                }

               
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Start(); 
            }

        }

        private void CoachLbl_Click(object sender, EventArgs e)
        {
            Coach coach = new Coach();
            coach.Show();
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
            Memberships memberships = new Memberships();
            memberships.Show();
            this.Hide();
        }

        private void RecepLbl_Click(object sender, EventArgs e)
        {
            Receptionist receptionist = new Receptionist();
            receptionist.Show();
            this.Hide();
        }

        private void BillLbl_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
