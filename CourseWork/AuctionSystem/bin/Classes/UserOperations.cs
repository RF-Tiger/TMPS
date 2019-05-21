using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace AuctionSystem.Classes
{
    public class UserOperations
    {

        public void DoLogin(String Mail, String Password)
        {

            String ConnectionString = "Data Source=Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True;";
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = ConnectionString;
            SqlCommand Command = new SqlCommand("SELECT * FROM ProductView WHERE Mail='" + Mail+"' AND Password = '"+Password+"'", Connection);
            Connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Command;
            da.Fill(dt);
            Command.Connection.Close();
            Command.Connection.Dispose();
            if (dt.Rows.Count != 0)
            {
                DataRow row = dt.Rows[0];

            }
            

            

        }


    }
    
  
}