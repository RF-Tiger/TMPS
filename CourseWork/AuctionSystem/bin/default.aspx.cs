using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace AuctionSystem
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {Classes.ProductsList pl = new Classes.ProductsList();
            ArrayList ProList = pl.ReturnMainProducts();
            Literal1.Text = "";
            String a = "";

            foreach (Classes.Product Pro in ProList)
            {

                a += "<div style=\"height: 130px; width: 552px; background-image: url('Themes/images/Product_List_Bg.png'); background-repeat: no-repeat; margin-bottom: 12px;\">";
                a += "<table style=\"width: 100%; height: 128px\"><tr><td style=\"width: 140px\"><div style=\"padding: 17px 6px 17px 17px; width: 117px; height: 96px\"><a href=\"product.aspx?id=" + Pro.getID() + "\">";
                a += "<img src=\"images/product/" + Pro.getID() + ".jpg" + "  \" style=\"margin: auto\" height=\"90\" align=\"middle\" width=\"112\" /></a></div></td><td style=\"width: 297px\" valign=\"top\">";
                a += "<div style=\"padding: 10px 20px 10px 10px; font-size: 14px; color: #015ba7; font-weight: 400;\"><a href=\"product.aspx?id=" + Pro.getID() + "\">" + Pro.getName() + "</a></div>";
                a += "<div style=\"padding: 2px 20px 16px 10px; height: 71px; width: 267px;\"><div style=\"margin-top: auto; margin-bottom: auto\">" + Pro.getDetails() + "</div>";
                a += "</div></td><td style=\"width: 101px\" valign=\"top\"><div style=\"height: 28px; padding-top: 11px; color: #015ba7; font-size: 14px;\" align=\"center\">";
                a += "" + Pro.getPrice() + " USD " + "</div><div style=\"height: 63px; padding-top: 18px;\" align=\"center\">" + Pro.getEndDate() + "</div></td></tr></table></div>";
                Literal1.Text = a;



            }
             
        }
    }
}