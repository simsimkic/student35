/***********************************************************************
 * Module:  TermController.cs
 * Purpose: Definition of the Class Controller.MedicalExeminationAndSurgeryController.TermController
 ***********************************************************************/

using Model.Term;
using Service.MedicalExeminationAndSurgeryService;
using System;

namespace Controller.MedicalExeminationAndSurgeryController
{
   public class TermController
   {
        public void ScheduleTerm(Dto.TermDTO informations)
        {
            termService.ScheduleTerm(informations);

        }

        public void CancelTerm(Appoitment informations)
        {

            termService.CancelTerm(informations);

        }

        public void ChangeTerm(Dto.TermDTO informations)
        {
            termService.ChangeTerm(informations);

        }

        public TermService termService=new TermService();
   
   }
}