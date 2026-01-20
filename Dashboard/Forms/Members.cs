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
            string Query = "Select * from MembersTbl";
            MembersList.DataSource = Con.GetData(Query);
        }

        private void Members_Load(object sender, EventArgs e)
        {

        }

        private void CoachLbl_Click(object sender, EventArgs e)
        {
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
            Application.Exit();
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
