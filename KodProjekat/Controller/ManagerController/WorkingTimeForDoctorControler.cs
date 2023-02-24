// File:    WorkingTimeForDoctorControler.cs
// Created: Thursday, June 11, 2020 6:04:38 PM
// Purpose: Definition of Class WorkingTimeForDoctorControler

using Model.ManagerFunctionality;
using Service.ManagerService;
using System;

namespace Controller.ManagerController
{
   public class WorkingTimeForDoctorControler
   {
        public WorkingTimeForDoctorService workingTimeForDoctorService; 

        public void DetermineDoktorWorkTime(DoctorWorktime workTimeForDoctor, string idSelectedDoctor) //Metoda za dodavanje
      {
            workingTimeForDoctorService = new WorkingTimeForDoctorService();
            workingTimeForDoctorService.DetermineDoktorWorkTime(workTimeForDoctor, idSelectedDoctor);
      }


        public void EditDoktorWorkTime(DoctorWorktime NewWorkTimeForDoctor, string idSelectedDoctor,DoctorWorktime selectedDay) //Metoda za izmenu
        {
            workingTimeForDoctorService = new WorkingTimeForDoctorService();
            workingTimeForDoctorService.EditDoktorWorkTime(NewWorkTimeForDoctor, idSelectedDoctor, selectedDay);
        }

        public void DeleteDoktorWorkTime(DoctorWorktime workTimeForDoctor, string idSelectedDoctor) //Metoda za brisanje
        {
            workingTimeForDoctorService = new WorkingTimeForDoctorService();
            workingTimeForDoctorService.DeleteDoktorWorkTime(workTimeForDoctor, idSelectedDoctor);
        }

    }
}