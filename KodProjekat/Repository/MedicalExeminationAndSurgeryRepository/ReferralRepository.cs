/***********************************************************************
 * Module:  ReferralRepository.cs
 * Purpose: Definition of the Class Repository.MedicalExeminationAndSurgeryRepository.ReferralRepository
 ***********************************************************************/

using Model.Doctor;
using Model.PrescriptionAndReferring;
using Model.Roles;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository.MedicalExeminationAndSurgeryRepository
{
   public class ReferralRepository
   {

        private const String path = @"../../Resources/Data/ReferralToSpecialist.txt";

        private static ReferralRepository instance = null;

        public static ReferralRepository getInstance()
        {
            if (instance == null)
            {
                instance = new ReferralRepository();
            }
            return instance;
        }

        public ObservableCollection<ReferralToSpecialist> referral
        {
            get;
            set;

        }

        public ReferralRepository()
        {
            referral = new ObservableCollection<ReferralToSpecialist>();
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

            SpecialistDoctor sdoctor = new SpecialistDoctor()
            {
                SpecialistName = "dr spec Jovan Jovanovic"
            };



            ReferralToSpecialist p = new ReferralToSpecialist() { Patient1 = patient, specialistDoctor = sdoctor, Date = "24.06.2020." };
            referral.Add(p);
            saveAllReferrals(referral);*/
        }

        /*public Model.Doctor.SpecialistDoctor GetAllSpecialists(Model.Doctor.SpecialistDoctor specialist)
      {
         throw new NotImplementedException();
      }*/

        public ObservableCollection<ReferralToSpecialist> GetAllReferral()
        {
            String text = "";

            if (File.Exists(path))
                text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ObservableCollection<ReferralToSpecialist>>(text);
        }

        public void saveAllReferrals(ObservableCollection<ReferralToSpecialist> users)
        {
            string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(path, json);
        }



    }
}