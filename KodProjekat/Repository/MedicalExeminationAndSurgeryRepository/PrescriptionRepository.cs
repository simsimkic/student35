/***********************************************************************
 * Module:  PrescriptionRepository.cs
 * Purpose: Definition of the Class Repository.MedicalExeminationAndSurgeryRepository.PrescriptionRepository
 ***********************************************************************/

using Model.Medicaments;
using Model.PrescriptionAndReferring;
using Model.Roles;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository.MedicalExeminationAndSurgeryRepository
{
   public class PrescriptionRepository
   {
        private const String path = @"../../Resources/Data/Prescription.txt";

        private static PrescriptionRepository instance = null;

        public static PrescriptionRepository getInstance()
        {
            if (instance == null)
            {
                instance = new PrescriptionRepository();
            }
            return instance;
        }

        public ObservableCollection<Prescription> prescription
        {
            get;
            set;

        }

        public PrescriptionRepository()
        {
            prescription = new ObservableCollection<Prescription>();
            /*Patient patient = new Patient()
            {
                Username = "Marko",
                Password = "111111111111",
                Name = "Marko",
                Surname = "Jovanovic",
                Jmbg = "111111111111",
                PhoneNumber = "076667828",
                Email = "marko@hotmail.rs",
                City = new City("Novi Sad", "21000", "Partizanska 2", new State("Srbija"))
            };

            Medicaments med = new Medicaments()
            {
                Ime = "Nebilet 5mg",
                Kolicina = "2"
            };

            

            Prescription p = new Prescription() { Patient1 = patient, Medicament = med, Date="24.06.2020." };
            prescription.Add(p);
            saveAllPrescriptions(prescription);*/
        }

        /*public Model.PrescriptionAndReferring.Prescription GetPrescription(Model.PrescriptionAndReferring.Prescription prescription)
        {
            throw new NotImplementedException();
        }*/


        public ObservableCollection<Prescription> GetAllPrescription()
        {
            String text = "";

            if (File.Exists(path))
                text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ObservableCollection<Prescription>>(text);
        }

        /*public Model.PrescriptionAndReferring.Prescription SetPrescription(Model.PrescriptionAndReferring.Prescription prescription)
        {
            throw new NotImplementedException();
        } 
      
      public Model.PrescriptionAndReferring.Prescription DeletePrescription(Model.PrescriptionAndReferring.Prescription prescription)
      {
         throw new NotImplementedException();
      }
      
      public Model.PrescriptionAndReferring.Prescription NewPrescription(Model.PrescriptionAndReferring.Prescription prescription)
      {
         throw new NotImplementedException();
      }*/

      public void saveAllPrescriptions(ObservableCollection<Prescription> users)
      {
         string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);

         File.WriteAllText(path, json);
      }
   
   }
}