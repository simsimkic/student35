/***********************************************************************
 * Module:  ReferralToSpecialist.cs
 * Purpose: Definition of the Class Model.PrescriptionAndReferring.ReferralToSpecialist
 ***********************************************************************/

using Model.Doctor;
using Model.Roles;
using System;
using System.ComponentModel;

namespace Model.PrescriptionAndReferring
{
   public class ReferralToSpecialist : INotifyPropertyChanged
    {
        private Patient patient;
        private string date;
        private SpecialistDoctor sDoctor;
        //public Model.Roles.Doctor doctor;


        //public Model.Term.DateAndTimeOfTerm dateAndTimeOfTerm;

        public Patient Patient1
        {
            get { return patient; }
            set { patient = value; OnPropertyChanged("Patient1"); }

        }

        public SpecialistDoctor specialistDoctor
        {
            get { return sDoctor; }
            set { sDoctor = value; OnPropertyChanged("specialistDoctor"); }

        }

        public string Date
        {
            get { return date; }
            set { date = value; OnPropertyChanged("Date"); }

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