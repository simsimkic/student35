/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Purpose: Definition of the Class Service.MedicalExeminationAndSurgeryService.MedicalRecordService
 ***********************************************************************/

using System;

namespace Service.MedicalExeminationAndSurgeryService
{
   public class MedicalRecordService
   {
      public Model.Doctor.MedicalRecord UpdateMedicalRecord(Model.Doctor.MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Model.Doctor.MedicalRecord AddMedicalRecord(Model.Doctor.MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Model.Doctor.MedicalRecord FindMedicalRecord(Model.Doctor.MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public System.Collections.ArrayList medicalRecordRepository;
      
      /// <summary>
      /// Property for collection of Repository.MedicalExeminationAndSurgeryRepository.MedicalRecordRepository
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList MedicalRecordRepository
      {
         get
         {
            if (medicalRecordRepository == null)
               medicalRecordRepository = new System.Collections.ArrayList();
            return medicalRecordRepository;
         }
         set
         {
            RemoveAllMedicalRecordRepository();
            if (value != null)
            {
               foreach (Repository.MedicalExeminationAndSurgeryRepository.MedicalRecordRepository oMedicalRecordRepository in value)
                  AddMedicalRecordRepository(oMedicalRecordRepository);
            }
         }
      }
      
      /// <summary>
      /// Add a new Repository.MedicalExeminationAndSurgeryRepository.MedicalRecordRepository in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddMedicalRecordRepository(Repository.MedicalExeminationAndSurgeryRepository.MedicalRecordRepository newMedicalRecordRepository)
      {
         if (newMedicalRecordRepository == null)
            return;
         if (this.medicalRecordRepository == null)
            this.medicalRecordRepository = new System.Collections.ArrayList();
         if (!this.medicalRecordRepository.Contains(newMedicalRecordRepository))
            this.medicalRecordRepository.Add(newMedicalRecordRepository);
      }
      
      /// <summary>
      /// Remove an existing Repository.MedicalExeminationAndSurgeryRepository.MedicalRecordRepository from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveMedicalRecordRepository(Repository.MedicalExeminationAndSurgeryRepository.MedicalRecordRepository oldMedicalRecordRepository)
      {
         if (oldMedicalRecordRepository == null)
            return;
         if (this.medicalRecordRepository != null)
            if (this.medicalRecordRepository.Contains(oldMedicalRecordRepository))
               this.medicalRecordRepository.Remove(oldMedicalRecordRepository);
      }
      
      /// <summary>
      /// Remove all instances of Repository.MedicalExeminationAndSurgeryRepository.MedicalRecordRepository from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllMedicalRecordRepository()
      {
         if (medicalRecordRepository != null)
            medicalRecordRepository.Clear();
      }
   
   }
}