/***********************************************************************
 * Module:  SpecialistDoctor.cs
 * Purpose: Definition of the Class Model.Doctor.SpecialistDoctor
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.Doctor
{
   public class SpecialistDoctor : Roles.Doctor, INotifyPropertyChanged
    {
        private string _ime;

            public string SpecialistName
        {
            get { return _ime; }
            set { _ime = value; OnPropertyChanged("SpecialistName"); }
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