using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Dashboard.DataCon
{
     class DataconFun
    {
    private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private string ConStr;
        private SqlDataAdapter sda;

        public DataconFun() {
            //before 
            //ConStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\OOP-2\\GymDB.mdf;" +
            //     "Integrated Security=True";
            //After
            string ConStr =
                ConfigurationManager.ConnectionStrings["GymDB"].ConnectionString;

            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;


        }

        public int setData(string Query)
        {
            int cnt = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }

        //public DataTable GetData(string Query)
        //{
        //    dt = new DataTable();
        //    sda = new SqlDataAdapter(Query, ConStr);
        //    sda.Fill(dt);
        //    return dt;
        //}
        public DataTable GetData(string Query)
        {
            dt = new DataTable();

            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            sda = new SqlDataAdapter(Query, Con);
            sda.Fill(dt);

            Con.Close();
            return dt;
        }

    }
}
