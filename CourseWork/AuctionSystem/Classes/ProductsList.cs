using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace AuctionSystem.Classes
{
    public class ProductsList
    {
        public ArrayList ReturnMainProducts()
        {
            ArrayList pl = new ArrayList();
            String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True;";
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = ConnectionString;
            SqlCommand Command = new SqlCommand("SELECT * FROM ProductView", Connection);
            Connection.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Command;
            da.Fill(dt);
            Command.Connection.Close();
            Command.Connection.Dispose();
            foreach (DataRow row in dt.Rows)
            {
                Classes.Product p = new Product(Convert.ToInt16(row["ID"]), row["Name"].ToString(), row["Details"].ToString(), row["Category"].ToString(), row["EndDate"].ToString(), row["Seller Name"].ToString()+ " " + row["Seller Surname"].ToString(), row["Price"].ToString());
                pl.Add(p);
            }
            return pl;
        }

        public Classes.Product ReturnProduct(int ID)
        {

            String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True;";
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = ConnectionString;
            SqlCommand Command = new SqlCommand("SELECT * FROM ProductView WHERE ID="+ID, Connection);
            Connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Command;
            da.Fill(dt);
            Command.Connection.Close();
            Command.Connection.Dispose();
            DataRow row = dt.Rows[0];
           
                Classes.Product p = new Product(Convert.ToInt16(row["ID"]), row["Name"].ToString(), row["Details"].ToString(), row["Category"].ToString(), row["EndDate"].ToString(), row["Seller Name"].ToString() + " " + row["Seller Surname"].ToString(), row["Price"].ToString());
            
            
            return p;  
            
        }

        public ArrayList ReturnSearchedProducts(String Keyword, int Category)
        {
            ArrayList pl = new ArrayList();
            String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True;";
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = ConnectionString;
            SqlCommand Command = new SqlCommand("SELECT * FROM ProductView WHERE Name LIKE '%" + Keyword + "%' OR Details LIKE '%" + Keyword + "%'", Connection);
            if (Category != 0)
            {
                Command = new SqlCommand("SELECT * FROM ProductView WHERE (Name LIKE '%" + Keyword + "%' OR Details LIKE '%" + Keyword + "%') AND CatagoryID =" + Category, Connection);
            }
            
            Connection.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Command;
            da.Fill(dt);
            Command.Connection.Close();
            Command.Connection.Dispose();
            foreach (DataRow row in dt.Rows)
            {
                Classes.Product p = new Product(Convert.ToInt16(row["ID"]), row["Name"].ToString(), row["Details"].ToString(), row["Category"].ToString(), row["EndDate"].ToString(), row["Seller Name"].ToString() + " " + row["Seller Surname"].ToString(), row["Price"].ToString());
                pl.Add(p);
            }
            return pl;
        }

        }
    }
