/***********************************************************************
 * Module:  MedicalExaminationDTO.cs
 * Purpose: Definition of the Class Dto.MedicalExaminationDTO
 ***********************************************************************/

using Model.Roles;
using System;
using System.ComponentModel;

namespace Dto
{
   public class MedicalExaminationDTO : TermDTO, INotifyPropertyChanged
    {
      private Doctor doctor;
      private Patient patient;


        public Doctor DoctorA
        {
            get { return doctor; }
            set { doctor = value; OnPropertyChanged("DoctorAA"); }

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