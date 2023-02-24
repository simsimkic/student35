// File:    ValidationMedicamentControler.cs
// Created: Thursday, June 11, 2020 5:54:09 PM
// Purpose: Definition of Class ValidationMedicamentControler

using Model.Medicaments;
using Service.ManagerService;
using System;
using System.Collections.Generic;

namespace Controller.ManagerController
{
   public class ValidationMedicamentControler
   {
        public bool SendMedicamentOnValidation(Model.Medicaments.Medicaments medicament)
        {
            ValidationMedicamentService validationMedicamentService = new ValidationMedicamentService();
            return validationMedicamentService.SendMedicamentOnValidation(medicament);
        }

        public bool AddMedicamentToStorage(Model.Medicaments.Medicaments medicament)
        {
            ValidationMedicamentService validationMedicamentService = new ValidationMedicamentService();
            return validationMedicamentService.AddMedicamentToStorage(medicament);
        }

        public bool MedicamentIsNotCorrect(Medicaments medicament)
        {
            ValidationMedicamentService validationMedicamentService = new ValidationMedicamentService();
            return validationMedicamentService.MedicamentIsNotCorrect(medicament);
        }
    }
}