using System;
using System.Collections.Generic;
using System.Web;

namespace AuctionSystem.Classes
{
    public class Product
    {
        private int ID;
        private String Name;
        private String Details;
        private String CategoryName;
        private String EndDate;
        private String SellerName;
        private String Price;

        public Product(int ID, String Name, String Details, String CategoryName, String EndDate, String SellerName, String Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Details = Details;
            this.CategoryName = CategoryName;
            this.EndDate = EndDate;
            this.SellerName =  SellerName;
            this.Price = Price;
        }
        public Product()
        {
        }
        public int getID()
        {
            return ID;
        }

        public String getName()
        {
            return Name;
        }

        public String getDetails()
        {
            return Details;
        }

        public String getCategoryName()
        {
            return CategoryName;
        }

        public String getEndDate()
        {
            return EndDate;
        }

        public String getSellerName()
        {
            return SellerName;
        }

        public String getPrice()
        {
            return Price;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public void setName(String Name)
        {
            this.Name = Name;
        }

        public void setDetails(String Details)
        {
            this.Details = Details;
        }

        public void setCategoryName(String CategoryName)
        {
            this.CategoryName = CategoryName;
        }

        public void setEndDate(String EndDate)
        {
            this.EndDate = EndDate;
        }

        public void setSellerName(String SellerName)
        {
            this.SellerName = SellerName;
        }

        public void setPrice(String Price)
        {
            this.Price = Price;
        }
    }
}