/***********************************************************************
 * Module:  MedicamentRepository.cs
 * Purpose: Definition of the Class Menadzer.MenagerRepository.MedicamentRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Model.Medicaments;
using Newtonsoft.Json;

namespace Repository.ManagerRepository
{
   public class MedicamentRepository 
   {
      private String path = @"../../Resources/Data/medikamentiMagacin.txt";


        private static MedicamentRepository instance = null;

        public static MedicamentRepository getInstance()
        {
            if (instance == null)
            {
                instance = new MedicamentRepository();
            }
            return instance;
        }

        public ObservableCollection<Medicaments> Medicaments
        {
            get;
            set;

        }

        public MedicamentRepository()
        {
           /* Medicaments = new ObservableCollection<Medicaments>();
            Medicaments.Add(new Medicaments()
            {
                Ime = "Paracetamol",
                Sifra = "112ff",
                Kolicina = "200",
                Proizvodjac = "Hemofarm",
                Sastojci = "opijum,skrobova kiselina..."

            });

            Medicaments.Add(new Medicaments()
            {
                Ime = "Brufen",
                Sifra = "111aa",
                Kolicina = "200",
                Proizvodjac = "Hemofarm",
                Sastojci = "E212,opijum,..."

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