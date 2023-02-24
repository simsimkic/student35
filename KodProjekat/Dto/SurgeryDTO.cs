/***********************************************************************
 * Module:  SurgeryDTO.cs
 * Purpose: Definition of the Class Dto.SurgeryDTO
 ***********************************************************************/

using Model.Doctor;
using Model.Roles;
using System;
using System.ComponentModel;

namespace Dto
{
   public class SurgeryDTO : TermDTO, INotifyPropertyChanged
    {
      private Doctor specialistDoctor;
      private Patient patient;

        public Doctor SpecialistDoctorA
        {
            get { return specialistDoctor; }
            set { specialistDoctor = value; OnPropertyChanged("SpecialistDoctorA"); }

        }
        public Patient Patient
        {
            get { return patient; }
            set { patient = value; OnPropertyChanged("Patient"); }

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