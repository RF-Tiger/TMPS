using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace AuctionSystem
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Classes.CategoriesList cl = new Classes.CategoriesList();
           if(!IsPostBack) 
           cl.SetCategoriesToCombo(DropDownList1);

           if (Session["ID"] == null)
           {
               Panel2.Visible = false;
               Panel1.Visible = true;
           }
           else 
           {
               Panel1.Visible = false;
               Panel2.Visible = true;
           }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String Keyword = TextBox1.Text;
            if (Keyword == "Search Keyword...")
            {
                Keyword = "";
            }
            int Category = Convert.ToInt32(DropDownList1.SelectedValue);

            Response.Redirect("search.aspx?Keyword=" + Keyword + "&Category=" + Category);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True;";
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = ConnectionString;
            SqlCommand Command = new SqlCommand("SELECT * FROM Users WHERE Mail='" +TextBox2.Text + "' AND Password = '" + TextBox3.Text + "'", Connection);
            Connection.Open();
            SqlDataReader dr = Command.ExecuteReader();
            if (dr.Read())
            {

                Session["ID"] = dr["ID"];
                Session["Name"] = dr["Name"] + " " + dr["Surname"];
                Panel1.Visible = false;
                Panel2.Visible = true;
                Label2.Text = Session["Name"].ToString();

            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["ID"] = null;
            Panel2.Visible = false;
            Panel1.Visible = true;
        }
    }
}