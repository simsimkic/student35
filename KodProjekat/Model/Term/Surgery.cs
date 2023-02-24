/***********************************************************************
 * Module:  Surgery.cs
 * Purpose: Definition of the Class Model.Term.Surgery
 ***********************************************************************/

using Model.Doctor;
using Model.Roles;
using System;
using System.ComponentModel;

namespace Model.Term
{
    public class Surgery : Appoitment, INotifyPropertyChanged
    {
        private Patient patient;


        private GuestAccount guestAccount;



        private Model.Roles.Doctor doctor;

        

        public Patient Patient
        {
            get { return patient; }
            set { patient = value; OnPropertyChanged("Patient"); }

        }

        public GuestAccount GuestAccount
        {
            get { return guestAccount; }
            set { guestAccount = value; OnPropertyChanged("GuestAccount"); }

        }


        public Model.Roles.Doctor Doctor
        {
            get { return doctor; }
            set { doctor = value; OnPropertyChanged("Doctor"); }

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