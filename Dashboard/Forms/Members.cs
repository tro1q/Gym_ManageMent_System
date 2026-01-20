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
        public Members()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
