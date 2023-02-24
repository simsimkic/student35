/***********************************************************************
 * Module:  ReferralService.cs
 * Purpose: Definition of the Class Service.MedicalExeminationAndSurgeryService.ReferralService
 ***********************************************************************/

using Model.Doctor;
using Model.PrescriptionAndReferring;
using Repository.MedicalExeminationAndSurgeryRepository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Service.MedicalExeminationAndSurgeryService
{
   public class ReferralService
   {
        public ObservableCollection<ReferralToSpecialist> referral
        {
            get;
            set;
        }

        public ReferralService()
        {
            referral = new ObservableCollection<ReferralToSpecialist>();
            referral = ReferralRepository.getInstance().GetAllReferral();
        }

        public void AddReferral(ReferralToSpecialist r)
        {
            referral.Add(r);
            MessageBox.Show("Uspesno ste izdali uput", "Dodato", MessageBoxButton.OK, MessageBoxImage.Information);
            ReferralRepository.getInstance().saveAllReferrals(referral);
        }

        /*public Model.PrescriptionAndReferring.ReferralToSpecialist ReferralToSpecialists(Model.PrescriptionAndReferring.ReferralToSpecialist referral)
      {
         throw new NotImplementedException();
      }
      
      public Model.Term.Surgery ReferralToSurgery(Model.Term.Surgery referral)
      {
         throw new NotImplementedException();
      }
      
      public List<SpecialistDoctor> AllSpecialistDoctor()
      {
         throw new NotImplementedException();
      }*/
      
      public Repository.MedicalExeminationAndSurgeryRepository.ReferralRepository referralRepository;
   
   }
}