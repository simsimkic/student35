/***********************************************************************
 * Module:  MedicamentInterface.cs
 * Purpose: Definition of the Interface Repository.ManagerRepository.MedicamentInterface
 ***********************************************************************/

using Model.Medicaments;
using System;
using System.Collections.Generic;

namespace Repository.ManagerRepository
{
   public interface MedicamentInterface
   {
      void SetMedicament(Model.Medicaments.Medicaments medicament);
      
      Model.Medicaments.Medicaments GetMedicament(String IdMedicament);
      
      String DeleteMedicament(String idMedicament);
      
      List<Medicaments> GetAllMedicaments();
      
      Model.Medicaments.Medicaments AddMedicament(Model.Medicaments.Medicaments medicament);
   
   }
}