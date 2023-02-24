/***********************************************************************
 * Module:  ReferralAndPrescriptionService.cs
 * Purpose: Definition of the Class Service.MedicalExeminationAndSurgeryService.ReferralAndPrescriptionService
 ***********************************************************************/

using Model.PrescriptionAndReferring;
using Repository.MedicalExeminationAndSurgeryRepository;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Service.MedicalExeminationAndSurgeryService
{
   public class PrescriptionService
   {
        public ObservableCollection<Prescription> prescription
        {
            get;
            set;
        }

        public PrescriptionService()
        {
            prescription = new ObservableCollection<Prescription>();
            prescription = PrescriptionRepository.getInstance().GetAllPrescription();
        }

        public void AddPrescription(Prescription p)
        {
            prescription.Add(p);
            MessageBox.Show("Uspesno ste izdali recept", "Dodato", MessageBoxButton.OK, MessageBoxImage.Information);
            PrescriptionRepository.getInstance().saveAllPrescriptions(prescription);
        }

      /*public Model.PrescriptionAndReferring.Prescription AddPrescription(Model.PrescriptionAndReferring.Prescription prescription)
      {
         throw new NotImplementedException();
      }*/
      
      //public Repository.MedicalExeminationAndSurgeryRepository.PrescriptionRepository prescriptionRepository;
   
   }
}