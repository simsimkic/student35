/***********************************************************************
 * Module:  ReferralAndPrescriptionService.cs
 * Purpose: Definition of the Class Service.MedicalExeminationAndSurgeryService.ReferralAndPrescriptionService
 ***********************************************************************/

using Model.PrescriptionAndReferring;
using Service.MedicalExeminationAndSurgeryService;
using System;

namespace Controller.MedicalExeminationAndSurgeryController
{
   public class PrescriptionController
   {
        public void AddPrescription(Prescription p)
        {
            PrescriptionService prescriptionService = new PrescriptionService();
            prescriptionService.AddPrescription(p);
        }
        /*public Model.PrescriptionAndReferring.Prescription AddPrescription(Model.PrescriptionAndReferring.Prescription prescription)
        {
           throw new NotImplementedException();
        }

        public Service.MedicalExeminationAndSurgeryService.PrescriptionService prescriptionService;*/

    }
}