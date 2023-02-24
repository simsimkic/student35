/***********************************************************************
 * Module:  SurgeryService.cs
 * Purpose: Definition of the Class Service.MedicalExeminationAndSurgeryService.SurgeryService
 ***********************************************************************/

using System;
using Dto;
using Model.Term;
using Repository.MedicalExeminationAndSurgeryRepository;

namespace Service.MedicalExeminationAndSurgeryService
{
   public class SurgeryService : ITermService
   {
      public void ScheduleExamination(TermDTO informations)
      {
            Surgery pregled = new Surgery();
            if (informations is SurgeryGuestDTO)
            {
                SurgeryGuestDTO info = (SurgeryGuestDTO)informations;

                pregled.Doctor = info.SpecialistDoctorAA;
                pregled.GuestAccount = info.GuestPatient;
                pregled.Room = info.Room;
                pregled.DateAndTime = info.Term;
                surgeryRepository.NewSurgery(pregled);
            }
            else if (informations is SurgeryDTO)
            {
                SurgeryDTO info = (SurgeryDTO)informations;

                pregled.Doctor = info.SpecialistDoctorA;
                pregled.Patient = info.Patient;
                pregled.Room = info.Room;
                pregled.DateAndTime = info.Term;
                surgeryRepository.NewSurgery(pregled);

            }
        }
      

        public void CancelExamination(Appoitment informations)
        {
            surgeryRepository.DeleteSurgery((Surgery)informations);
        }


        public void ChangeExamination(TermDTO informations)
        {
            Surgery pregled = new Surgery();
            if (informations is SurgeryGuestDTO)
            {
                SurgeryGuestDTO info = (SurgeryGuestDTO)informations;

                pregled.Doctor = info.SpecialistDoctorAA;
                pregled.GuestAccount = info.GuestPatient;
                pregled.Room = info.Room;
                pregled.DateAndTime = info.Term;
                surgeryRepository.SetSurgery(pregled);
            }
            else if (informations is SurgeryDTO)
            {
                SurgeryDTO info = (SurgeryDTO)informations;

                pregled.Doctor = info.SpecialistDoctorA;
                pregled.Patient = info.Patient;
                pregled.Room = info.Room;
                pregled.DateAndTime = info.Term;
                surgeryRepository.SetSurgery(pregled);

            }
        }

        public SurgeryRepository surgeryRepository=new SurgeryRepository();
   
   }
}