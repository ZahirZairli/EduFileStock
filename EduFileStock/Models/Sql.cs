using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EduFileStock.Models
{
    public class Sql
    {
        public static DataTable Exec(string sorgu)
        {
            string connectionstring = @"Data Source=wdb4.my-hosting-panel.com;Initial Catalog=************; Persist Security Info=True; User Id=*******^^; password=*******";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            SqlCommand srg = new SqlCommand(sorgu, sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter(srg);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqlcon.Close();
            return dt;
        }
    }
}
