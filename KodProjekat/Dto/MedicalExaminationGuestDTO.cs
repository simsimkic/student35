/***********************************************************************
 * Module:  MedicalExaminationGuestDTO.cs
 * Purpose: Definition of the Class Dto.MedicalExaminationGuestDTO
 ***********************************************************************/

using Model.Roles;
using Model.Term;
using System;
using System.ComponentModel;

namespace Dto
{
   public class MedicalExaminationGuestDTO : TermDTO, INotifyPropertyChanged
    {
      private Doctor doctor;
      private GuestAccount guestPatient;

        public Doctor DoctorAA
        {
            get { return doctor; }
            set { doctor = value; OnPropertyChanged("DoctorAA"); }

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