using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AuctionSystem.Classes
{
    public class CategoriesList
    {
        public void SetCategoriesToCombo(DropDownList dl)
        {
          
            String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True;";
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = ConnectionString;
            SqlCommand Command = new SqlCommand("SELECT * FROM Categories", Connection);
            Connection.Open();
            SqlDataReader DataReader;
            DataReader = Command.ExecuteReader();
            ListItem AllCat = new ListItem();
            AllCat.Value = "0";
           
            dl.DataSource = DataReader;
            dl.DataValueField = "ID";
            dl.DataTextField = "Name";
            AllCat.Text = "All Categories";
            
           
            dl.DataBind();
            dl.Items.Add(AllCat);
            AllCat.Selected = true;
            Command.Connection.Close();
            Command.Connection.Dispose();
        }

        
    }
    
}