using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuctionSystem
{
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = 1002;
            ID = Convert.ToInt16(Request.QueryString["id"]);
            Classes.ProductsList pl = new Classes.ProductsList();
            Classes.Product pro = pl.ReturnProduct(ID);

            Literal1.Text = "";
            String a = "";

            a+="<div style=\"background-position: top; height: auto; width: 552px; background-image: url('Themes/images/Product_Detail_Bg.PNG'); background-repeat: no-repeat; margin-bottom: 8px;\">";
            a+="<table style=\"width: 100%; height: auto\"><tr><td style=\"width: 140px\" valign=\"top\"><div style=\"padding: 17px 6px 17px 17px; width: 117px; height: 96px\"><a href=\"images/product/" +pro.getID() + ".jpg" + "\">";
            a+="<img src=\"images/product/" +pro.getID() + ".jpg" + "\" style=\"margin: auto\" height=\"90\" align=\"middle\" width=\"112\" /></a></div></td><td style=\"width: 297px\" valign=\"top\"><div style=\"padding: 10px 20px 10px 10px; font-size: 14px;"; 
            a+="color: #015ba7; font-weight: 400;\"><a href=\"#asd\">"+pro.getName()+"</a></div><div style=\"padding: 2px 20px 16px 10px; height: auto; width: 267px;\"><div style=\"margin-top: auto; margin-bottom: auto\">";
            a+=pro.getDetails()+"</div></div></td><td style=\"width: 101px\" valign=\"top\"><div style=\"height: 28px; padding-top: 11px; color: #015ba7; font-size: 14px;\" align=\"center\">"+pro.getPrice()+"</div>";
            a+="<div style=\"height: 63px; padding-top: 18px;\" align=\"center\">"+pro.getEndDate()+"</div></td></tr></table></div>";

            Literal1.Text = a;


        }
    }
}