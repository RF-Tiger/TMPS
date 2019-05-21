using System;
using System.Collections.Generic;
using System.Web;

namespace AuctionSystem.Classes
{
    public class User
    {

        private int ID;
        private String Name;
        private String Surname;
        private String Mail;
        private long Phone;
        private String Adress;
        private String Password;

        public User(int ID, String Name, String Surname, String Mail, long Phone, String Adress, String Password) { 
            this.ID = ID;
            this.Name = Name;
            this.Surname = Surname;
            this.Mail = Mail;
            this.Phone = Phone;
            this.Adress = Adress;
            this.Password = Adress;
        }
        public User()
        {
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


        public String getSurname()
        {
            return Surname;
        }


        public void setSurname(String Surname)
        {
            this.Surname = Surname;
        }


        public String getMail()
        {
            return Mail;
        }


        public void setMail(String Mail)
        {
            this.Mail = Mail;
        }


        public long getPhone()
        {
            return Phone;
        }


        public void setPhone(long Phone)
        {
            this.Phone = Phone;
        }


        public String getAdress()
        {
            return Adress;
        }


        public void setAdress(String Adress)
        {
            this.Adress = Adress;
        }


        public String getPassword()
        {
            return Password;
        }


        public void setPassword(String Password)
        {
            this.Password = Password;
        }
    }
}