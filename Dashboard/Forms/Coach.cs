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
                if (ChNameTb.Text == "" || PhoneTb.Text == "" || ExpTb.Text == "" || PassTb.Text == "" || GenCb.SelectedIndex == -1)
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
                    string Query = "insert into CoachsTbl values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                    Query = string.Format(Query, CName, Gender, DOBTb.Value.Date, Phone, experience, Add, Password);
                    Con.setData(Query);
                    ShowCoach();
                    MessageBox.Show("Coach Added Successfully");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
                  
            
        }

        private void CoachList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChNameTb.Text = CoachList.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}

