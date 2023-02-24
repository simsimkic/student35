/***********************************************************************
 * Module:  SurgeryGuestDTO.cs
 * Purpose: Definition of the Class Dto.SurgeryGuestDTO
 ***********************************************************************/

using Model.Doctor;
using Model.Roles;
using System;
using System.ComponentModel;

namespace Dto
{
   public class SurgeryGuestDTO : TermDTO, INotifyPropertyChanged
    {
      private Doctor specialistDoctor;
        private GuestAccount guestPatient;

        public Doctor SpecialistDoctorAA
        {
            get { return specialistDoctor; }
            set { specialistDoctor = value; OnPropertyChanged("SpecialistDoctorAA"); }

        }

        public GuestAccount GuestPatient
        {
            get { return guestPatient; }
            set { guestPatient = value; OnPropertyChanged("GuestPatient"); }

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