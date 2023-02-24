/***********************************************************************
 * Module:  Prescription.cs
 * Purpose: Definition of the Class Model.PrescriptionAndReferring.Prescription
 ***********************************************************************/

using Model.Roles;
using System;
using System.ComponentModel;

namespace Model.PrescriptionAndReferring
{
   public class Prescription : INotifyPropertyChanged
    {
      private Patient patient;

      private string date;
      private Model.Medicaments.Medicaments medicaments;

        private string _therapy;
        //public Model.Roles.Doctor doctor;


        //public Model.Term.DateAndTimeOfTerm dateAndTimeOfTerm;

        public Patient Patient1
        {
            get { return patient; }
            set { patient = value; OnPropertyChanged("Patient1"); }

        }

        public Model.Medicaments.Medicaments Medicament
        {
            get { return medicaments; }
            set { medicaments = value; OnPropertyChanged("Medicament"); }

        }

        public string Therapy
        {
            get { return _therapy; }
            set { _therapy = value; OnPropertyChanged("Therapy"); }

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