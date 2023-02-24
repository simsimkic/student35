/***********************************************************************
 * Module:  ReferralService.cs
 * Purpose: Definition of the Class Service.MedicalExeminationAndSurgeryService.ReferralService
 ***********************************************************************/

using Model.PrescriptionAndReferring;
using Service.MedicalExeminationAndSurgeryService;
using System;
using System.Collections.Generic;

namespace Controller.MedicalExeminationAndSurgeryController
{
   public class ReferralController
   {

        public void AddReferral(ReferralToSpecialist r)
        {
            ReferralService referralService = new ReferralService();
            referralService.AddReferral(r);
        }

        /*public Model.PrescriptionAndReferring.ReferralToSpecialist ReferralToSpecialists(Model.PrescriptionAndReferring.ReferralToSpecialist referral)
      {
         throw new NotImplementedException();
      }
      
      public Model.Term.Surgery ReferralToSurgery(Model.Term.Surgery referral)
      {
         throw new NotImplementedException();
      }
      
      public List<Model.Doctor.SpecialistDoctor> AllSpecialistDoctor()
      {
         throw new NotImplementedException();
      }*/
      
      public Service.MedicalExeminationAndSurgeryService.ReferralService referralService;
   
   }
}