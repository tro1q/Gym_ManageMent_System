using Dashboard.DataCon;
using Dashboard.Forms;
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

        private void GetMembers()
        {
            

            DataTable dtMembers = Con.GetData("select * from MembersTbl WHERE IsDeleted = 0");
            MemberCb.DisplayMember = "MName";
            MemberCb.ValueMember = "MId";
            MemberCb.DataSource = dtMembers;


        }


        private void ClearFields()
        {
            AmountTb.Text = "";
            MemberCb.SelectedIndex = -1;
        }

        private bool BillDone = false;
       

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
                   
                    string BDate = BDateTb.Value.ToString("yyyy-MM-dd"); 

                    string Amount = AmountTb.Text;
                    string Query = "INSERT INTO FinanceTbl (Agent, Member, BPeriod, BDate, BAmount) " +
                                        "VALUES ({0}, {1}, '{2}', '{3}', {4})";

                    Query = string.Format(Query, Agent, Member, Period, BDate, Amount);
                    Con.setData(Query);

                    MessageBox.Show("Bill Added Successfully");
                   // ClearFields();
                    ShowBills();
                    BillDone = true;

                    DataTable dt = Con.GetData($"SELECT * FROM MembersTbl WHERE MId = {Member}");
                    if (dt.Rows.Count > 0)
                    {
                        string memberName = dt.Rows[0]["MName"].ToString();
                        string memberPhone = dt.Rows[0]["MPhone"].ToString();
                        string memberGender = dt.Rows[0]["MGen"].ToString();
                        string memberDOB = Convert.ToDateTime(dt.Rows[0]["MDOB"]).ToShortDateString();

                        billContent = "";
                        billContent += "====== Gym Bill ======\n";
                        billContent += $"Member Name: {memberName}\n";
                        billContent += $"Gender: {memberGender}\n";
                        billContent += $"DOB: {memberDOB}\n";
                        billContent += $"Phone: {memberPhone}\n";
                        billContent += $"Billing Period: {Period}\n";
                        billContent += $"Billing Date: {BDate}\n";
                        billContent += $"Amount: {Amount}\n";
                        billContent += "-------------------------\n";
                        billContent += "Thank you for your payment!";
                    }
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
        private PrintDocument printDocument = new PrintDocument();
        private string billContent = "";

       


        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
           
            Font font = new Font("Arial", 12, FontStyle.Regular);
            float startX = 50;
            float startY = 50;
            float lineHeight = font.GetHeight(e.Graphics) + 5;

           
            string[] lines = billContent.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                e.Graphics.DrawString(lines[i], font, Brushes.Black, startX, startY + (i * lineHeight));
            }
        }


        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (!BillDone)
            {
                MessageBox.Show("Please click Add before printing the bill!");
                return;
            }

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) =>
            {
                Font font = new Font("Arial", 12);
                float startX = 50;
                float startY = 50;
                float lineHeight = font.GetHeight(ev.Graphics) + 5;

                string[] lines = billContent.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    ev.Graphics.DrawString(lines[i], font, Brushes.Black, startX, startY + (i * lineHeight));
                }
            };

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
            BillDone = false;
            ClearFields();
        }

        private void TrackerLbl_Click(object sender, EventArgs e)
        {
            WorkoutTracker tracker = new WorkoutTracker();
            tracker.Show();
            this.Hide();
        }
    }
}
