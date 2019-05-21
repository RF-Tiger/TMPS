using System;
using System.Collections.Generic;
using System.Web;

namespace AuctionSystem.Classes
{
    public class Category
    {
        private int ID;
        private String Name;

        public Category(int ID, String Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public int getID()
        {
            return ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public String getName()
        {
            return Name;
        }

        public void setName(String Name)
        {
            this.Name = Name;
        }

    }
}