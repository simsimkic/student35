/***********************************************************************
 * Module:  TermController.cs
 * Purpose: Definition of the Class Controller.MedicalExeminationAndSurgeryController.TermController
 ***********************************************************************/

using Dto;
using Model.Term;
using System;

namespace Service.MedicalExeminationAndSurgeryService
{
   public class TermService
   {
        public void ScheduleTerm(Dto.TermDTO informations)
        {
            if (informations.TypeOfIntervention.Equals("pregled"))
            {
                iTermService = new MedicalExaminationService();
                iTermService.ScheduleExamination(informations);
            }
            else if (informations.TypeOfIntervention.Equals("operacija"))
            {
               iTermService = new SurgeryService();
               iTermService.ScheduleExamination(informations);

            }

        }

        public void CancelTerm(Appoitment informations)
        {
            if (informations is MedicalExamination)
            {
                iTermService = new MedicalExaminationService();
                iTermService.CancelExamination(informations);
            }else if (informations is Surgery)
            {
                iTermService = new SurgeryService();
                iTermService.CancelExamination(informations);
            }
        }

        public void ChangeTerm(TermDTO informations)
        {
            if (informations.TypeOfIntervention.Equals("pregled") || informations.TypeOfIntervention.Equals("hitanslučaj"))
            {
                iTermService = new MedicalExaminationService();
                iTermService.ChangeExamination(informations);
            }
            else if (informations.TypeOfIntervention.Equals("operacija"))
            {
                iTermService = new SurgeryService();
                iTermService.ChangeExamination(informations);

            }


        }
      
      public ITermService iTermService;
   
   }
}