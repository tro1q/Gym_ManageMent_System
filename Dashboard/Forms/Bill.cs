using Dashboard.DataCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Bill : Form
    {
        DataconFun Con;
        public Bill()
        {
            InitializeComponent();
            Con = new DataconFun();
            ShowBills();
            GetMembers();
        }

        private void ShowBills()
        {
            string Query = "select * from FinanceTbl";
            BillingList.DataSource = Con.GetData(Query);

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void GetMembers()
        {
            string Query = "select * from MembersTbl";
            MemberCb.DisplayMember = Con.GetData(Query).Columns["MName"].ToString();
            MemberCb.ValueMember = Con.GetData(Query).Columns["MId"].ToString();
            MemberCb.DataSource = Con.GetData(Query);
        }

      
        private void ClearFields()
        {
            AmountTb.Text = "";
            MemberCb.SelectedIndex = -1;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MemberCb.Text == "" || AmountTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    int Agent = Login.UserId;
                    string Member = MemberCb.SelectedValue.ToString();
                    string Period = PeriodTb.Value.Month.ToString() + "-" + PeriodTb.Value.Date.Year;
                    string BDate = BDateTb.Value.Date.ToString();
                    string Amount = AmountTb.Text;
                    string Query = "INSERT INTO FinanceTbl (Agent, Member, BPeriod, BDate, BAmount) " +
                                        "VALUES ({0}, {1}, '{2}', '{3}', {4})";

                    Query = string.Format(Query, Agent, Member, Period, BDate, Amount);
                    Con.setData(Query);

                    MessageBox.Show("Bill Added Successfully");
                   // ClearFields();
                    ShowBills();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            MemberCb.SelectedIndex = -1;

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
        //private PrintDocument printDocument = new PrintDocument();
        //private string billContent = ""; // This will hold the text/content of the bill

        //private DataTable GetMemberDetails(int memberId)
        //{
        //    string query = $"SELECT * FROM MembersTbl WHERE MId = {memberId}";
        //    return Con.GetData(query);
        //}


        //private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    // Font and starting position
        //    Font font = new Font("Arial", 12, FontStyle.Regular);
        //    float startX = 50;
        //    float startY = 50;
        //    float lineHeight = font.GetHeight(e.Graphics) + 5;

        //    // Draw the bill line by line
        //    string[] lines = billContent.Split('\n');
        //    for (int i = 0; i < lines.Length; i++)
        //    {
        //        e.Graphics.DrawString(lines[i], font, Brushes.Black, startX, startY + (i * lineHeight));
        //    }
        //}


        private void PrintBtn_Click(object sender, EventArgs e)
        {
          
        }
    }
}
