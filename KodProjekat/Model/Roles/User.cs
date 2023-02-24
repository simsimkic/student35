/***********************************************************************
 * Module:  User.cs
 * Purpose: Definition of the Class Model.Roles.User
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.Roles
{
   // public enum TypeOfRole { doctor, patient, manager, secretary }

    public class User : INotifyPropertyChanged
    {
        

      private string username;
      private string password;
      private string name;
      private string surname;
      private DateTime dateOfBirth;
      private string phoneNumber;
      private string email;
        // public TypeOfRole typeOfRole;
      private string jmbg;

      private City city;



        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged("Username"); }

        }

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged("Password"); }

        }



        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; OnPropertyChanged("DateOfBirth"); }

        }


        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }

        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; OnPropertyChanged("Surname"); }

        }


        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; OnPropertyChanged("PhoneNumber"); }

        }

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged("Email"); }

        }


        


        public string Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; OnPropertyChanged("Jmbg"); }

        }












        /// <summary>
        /// Property for City
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public City City
      {
         get
         {
            return city;
         }
         set
         {
            this.city = value;
         }
      }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}