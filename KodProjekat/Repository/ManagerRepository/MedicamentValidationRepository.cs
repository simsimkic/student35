/***********************************************************************
 * Module:  MedicamentRepository.cs
 * Purpose: Definition of the Class Menadzer.MenagerRepository.MedicamentRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Model.Medicaments;
using Newtonsoft.Json;



namespace Repository.ManagerRepository
{

    public class MedicamentValidationRepository 
    {

        private String path = @"../../Resources/Data/medikamentiValidacija.txt";


        private static MedicamentValidationRepository instance = null;

        public static MedicamentValidationRepository getInstance()
        {
            if (instance == null)
            {
                instance = new MedicamentValidationRepository();
            }
            return instance;
        }

        public ObservableCollection<Medicaments> Medicaments
        {
            get;
            set;

        }

        public MedicamentValidationRepository()
        {
             Medicaments = new ObservableCollection<Medicaments>();
            /* Medicaments.Add(new Medicaments()
             {
                 Ime = "Kodaron",
                 Sifra = "12345",
                 Kolicina = "100",
                 Proizvodjac = "Hemofarm",
                 Sastojci = "salicilati,He,..."

             });

            


             saveAllMedicaments(Medicaments);*/


        }

        public ObservableCollection<Medicaments> GetAllMedicaments()
        {
            String text = "";

            if (File.Exists(path))
                text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ObservableCollection<Medicaments>>(text);
        }


        public void saveAllMedicaments(ObservableCollection<Medicaments> medicaments)
        {
            string json = JsonConvert.SerializeObject(medicaments, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(path, json);
        }


        public bool isMedicamentExists(Medicaments medicament)
        {

            foreach (Medicaments currentMedicament in GetAllMedicaments())
            {
                if (currentMedicament.Sifra.ToString().Equals(medicament.Sifra))
                {
                    return true;
                }

            }
            return false;

        }


    }



    
}