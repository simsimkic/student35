/***********************************************************************
 * Module:  User.cs
 * Purpose: Definition of the Class Model.Roles.User
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.Roles
{
   public class GuestAccount : INotifyPropertyChanged
    {
      private string name;
      private string surname;
      private string phoneNumber;
      private string jmbg;

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


        public string Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; OnPropertyChanged("Jmbg"); }

        }

        public override string ToString()
        {
            return Name + " " + Surname+" "+Jmbg;
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