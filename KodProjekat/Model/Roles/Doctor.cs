/***********************************************************************
 * Module:  Doctor.cs
 * Purpose: Definition of the Class Model.Roles.Doctor
 ***********************************************************************/

using Model.ManagerFunctionality;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Model.Roles
{
    public class Doctor : User, INotifyPropertyChanged
    {

        public ObservableCollection<DoctorWorktime> RadnoVremePrikaz
        {
            get;
            set;
        }

        


        public Doctor() {
            RadnoVremePrikaz = new ObservableCollection<DoctorWorktime>();
        }

        
            
        public ObservableCollection<DoctorWorktime> dajRadnoVRemePrikazDoktora()
        {
            return RadnoVremePrikaz;
        }

        public void popunjavanjeRadnoVRemePrikazDoktora(DoctorWorktime prikaz)
        {
            RadnoVremePrikaz.Add(prikaz);
        }


        

      
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public override string ToString()
        {
            return Name+" "+Surname;
        }

    }
}