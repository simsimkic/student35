/***********************************************************************
 * Module:  ITermService.cs
 * Purpose: Definition of the Interface Service.MedicalExeminationAndSurgeryService.ITermService
 ***********************************************************************/

using Dto;
using Model.Term;
using System;

namespace Service.MedicalExeminationAndSurgeryService
{
   public interface ITermService
   {
      void ScheduleExamination(Dto.TermDTO informations);
      
      void CancelExamination(Appoitment informations);
      
     void ChangeExamination(TermDTO informations);
   
   }
}