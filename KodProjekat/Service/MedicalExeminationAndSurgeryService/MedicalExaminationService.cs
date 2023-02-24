/***********************************************************************
 * Module:  ExaminationService.cs
 * Purpose: Definition of the Class Service.SecretaryService.ExaminationService
 ***********************************************************************/

using System;
using Dto;
using Repository.MedicalExeminationAndSurgeryRepository;
using Model.Term;

namespace Service.MedicalExeminationAndSurgeryService
{
   public class MedicalExaminationService : ITermService
   {
      public void ScheduleExamination(TermDTO informations)
      {
            MedicalExamination pregled = new MedicalExamination();
            if (informations is MedicalExaminationGuestDTO)
            {
                MedicalExaminationGuestDTO info = (MedicalExaminationGuestDTO)informations;
               
                pregled.Doctor = info.DoctorAA;
                pregled.GuestAccount = info.GuestPatient;
                pregled.Room = info.Room;
                pregled.DateAndTime = info.Term;
                medicalExeminationRepository.NewMedicalExemination(pregled);
            }
            else if(informations is MedicalExaminationDTO)
            {
                MedicalExaminationDTO info = (MedicalExaminationDTO)informations;

                pregled.Doctor = info.DoctorA;
                pregled.Patient = info.Patient;
                pregled.Room = info.Room;
                pregled.DateAndTime = info.Term;
                medicalExeminationRepository.NewMedicalExemination(pregled);
                
            }
         
           
      }
      
      public void CancelExamination(Appoitment informations)
      {
            medicalExeminationRepository.DeleteMedicalExamination((MedicalExamination)informations);
      }
      
      public void ChangeExamination(TermDTO informations)
      {
            MedicalExamination pregled = new MedicalExamination();
            if (informations.TypeOfIntervention.Equals("hitanslučaj"))
            {
                pregled.Emergency = true;
            }
            if (informations is MedicalExaminationGuestDTO)
            {
                MedicalExaminationGuestDTO info = (MedicalExaminationGuestDTO)informations;

                pregled.Doctor = info.DoctorAA;
                pregled.GuestAccount = info.GuestPatient;
                pregled.Room = info.Room;
                pregled.DateAndTime = info.Term;
                medicalExeminationRepository.SetMedicalExemination(pregled);
            }
            else if (informations is MedicalExaminationDTO)
            {
                MedicalExaminationDTO info = (MedicalExaminationDTO)informations;

                pregled.Doctor = info.DoctorA;
                pregled.Patient = info.Patient;
                pregled.Room = info.Room;
                pregled.DateAndTime = info.Term;
                medicalExeminationRepository.SetMedicalExemination(pregled);

            }
        }
      
      public MedicalExeminationRepository medicalExeminationRepository=new MedicalExeminationRepository();
   
   }
}