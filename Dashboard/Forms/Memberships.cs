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
    public partial class Memberships : Form
    {
        DataconFun Con; //Funtions Con
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

            if (e.RowIndex < 0 || MShipList.Rows[e.RowIndex].IsNewRow) //Empty row error handling
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
                    MessageBox.Show("Select a MemberShip!!");

                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this MemberShip?",
                                          "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                       
                        string Query = "delete from MembershipsTbl where MShipid = {0}";
                        Query = string.Format(Query, key);
                        Con.setData(Query);
                       ShowMShips();
                       ShowTempMessage(" MemberShip Deleted !");
                        ClearField();
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
                   // MessageBox.Show("MemberShip Updated!!");
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
    }
}
