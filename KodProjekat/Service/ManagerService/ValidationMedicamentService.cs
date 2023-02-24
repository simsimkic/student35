// File:    ValidationMedicamentService.cs
// Created: Thursday, June 11, 2020 6:11:19 PM
// Purpose: Definition of Class ValidationMedicamentService

using Model.Medicaments;
using Repository.ManagerRepository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Service.ManagerService
{
   public class ValidationMedicamentService
   {
        public MedicamentValidationRepository medicamentValidationRepository;
        public MedicamentRepository medicamentRepository;


      

        public ObservableCollection<Medicaments> medicamentsValidation
        {
            get;
            set;

        }



        public ValidationMedicamentService()
        {
            medicamentsValidation = new ObservableCollection<Medicaments>();
            medicamentsValidation = MedicamentValidationRepository.getInstance().GetAllMedicaments();
            
        }




        public bool SendMedicamentOnValidation(Medicaments medicament)
      {
         
            if(MedicamentRepository.getInstance().isMedicamentExists(medicament) || MedicamentValidationRepository.getInstance().isMedicamentExists(medicament))
            {                
                return false;
            }

            medicamentsValidation.Add(medicament);
            MedicamentValidationRepository.getInstance().saveAllMedicaments(medicamentsValidation);

           
            return true;
        }

        public bool AddMedicamentToStorage(Model.Medicaments.Medicaments medicament)
        {
            if (MedicamentIsNotCorrect(medicament))
            {
                ObservableCollection<Medicaments> medicaments = new ObservableCollection<Medicaments>();
                medicaments = MedicamentRepository.getInstance().GetAllMedicaments();
                medicaments.Add(medicament);
                MedicamentRepository.getInstance().saveAllMedicaments(medicaments);
                return true;
            }
            return false;
        }

        public bool MedicamentIsNotCorrect(Medicaments medicament)
        {
            medicamentsValidation = MedicamentValidationRepository.getInstance().GetAllMedicaments();
            foreach (Medicaments currentMedicament in medicamentsValidation)
            {
                if (currentMedicament.Sifra.ToString().Equals(medicament.Sifra))
                {
                    medicamentsValidation.Remove(currentMedicament);
                    MedicamentValidationRepository.getInstance().saveAllMedicaments(medicamentsValidation);
                    return true;
                }
               
            }
            return false;
            
        }










    }
}