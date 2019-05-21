using System;
using System.Collections.Generic;
using System.Web;

namespace AuctionSystem.Classes
{
    public class Bidding
    {
        private int Accural;
        private String Date;

        int getAccural()
        {
            return Accural;
        }


        public String getDate()
        {
            return Date;
        }


        public void setAccural(int Accural)
        {
            this.Accural = Accural;
        }

        public void setDate(String Date)
        {
            this.Date = Date;
        }
    }
}