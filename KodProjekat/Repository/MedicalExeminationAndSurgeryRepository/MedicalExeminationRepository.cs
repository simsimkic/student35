/***********************************************************************
 * Module:  MedicalExeminationRepository.cs
 * Purpose: Definition of the Class Repository.MedicalExeminationAndSurgeryRepository.MedicalExeminationRepository
 ***********************************************************************/

using Model.Roles;
using Model.Term;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace Repository.MedicalExeminationAndSurgeryRepository
{


   public class MedicalExeminationRepository
   {

        private const String path = @"../../Resources/Data/MedicalExamination.txt";

        private static MedicalExeminationRepository instance = null;

        public static MedicalExeminationRepository getInstance()
        {
            if (instance == null)
            {
                instance = new MedicalExeminationRepository();
            }
            return instance;
        }

        public ObservableCollection<MedicalExamination> Examinations
        {
            get;
            set;

        }


        public MedicalExeminationRepository()
        {
             Examinations = new ObservableCollection<MedicalExamination>();
              Examinations = GetAllMedicalExemination();
           /*  Doctor doctorNovi = new Doctor()
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

            Patient pacijent = new Patient()
            {

                Username = "Marko",
                Password = "111111111111",
                Name = "Milos",
                Surname = "Markovic",
                Jmbg = "111111111111",
                PhoneNumber = "076667828",
                Email = "marko@hotmail.rs",
                City = new City("Novi Sad", "21000", "Partizanska 2", new State("Srbija"))



            };
            DateTime darum = new DateTime(2020, 4, 10);
            TimeSpan vreme = new TimeSpan(3, 30, 0);
            //string vreme = "11:00-11:30";
            darum += vreme;
            
          ///  Room soba = new Room() { NazivProstorije = "211", TipProstorije = "pregled" };
            MedicalExamination pregled = new MedicalExamination() { Doctor = doctorNovi, Patient = pacijent, DateAndTime=darum};
            Examinations.Add(pregled);
            saveAllMedicalExaminations(Examinations);
            */


        }



        public ObservableCollection<MedicalExamination> GetMExeminationDoctor(Doctor doctor)
      {
            ObservableCollection<MedicalExamination> retVal = new ObservableCollection<MedicalExamination>();
            foreach(MedicalExamination current in Examinations)
            {
                if (current.Doctor.Jmbg.Equals(doctor.Jmbg)) {
                    retVal.Add(current);

                }

            }

            return retVal;
      }
      
      public void SetMedicalExemination(Model.Term.MedicalExamination editedExemination)
      {
            foreach (MedicalExamination currentExamination in Examinations)
            {
                if (currentExamination.DateAndTime.Equals(editedExemination.DateAndTime) && currentExamination.Room.ToString().Equals(editedExemination.Room.ToString()))
                {
                    currentExamination.Doctor = editedExemination.Doctor;
                    currentExamination.Patient = editedExemination.Patient;
                    currentExamination.GuestAccount = editedExemination.GuestAccount;
                    currentExamination.Emergency = editedExemination.Emergency;

                    saveAllMedicalExaminations(Examinations);
                    MessageBox.Show("Termin je uspesno izmenjen", "informacija", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                }
            }
        }
      
      public ObservableCollection<MedicalExamination> GetAllMedicalExemination()
      {
            String text = "";

            if (File.Exists(path))
                text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ObservableCollection<MedicalExamination>>(text);

        }

        public void NewMedicalExemination(Model.Term.MedicalExamination medicalExemination)
        {
            if (MExaminationExists(medicalExemination))
            {
                MessageBox.Show("Već je zakazan taj termin", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                Examinations.Add(medicalExemination);
                saveAllMedicalExaminations(Examinations);
                MessageBox.Show("Pregled je uspesno zakazan", "informacija", MessageBoxButton.OK, MessageBoxImage.Information);
            }
          
        }


        public bool MExaminationExists(MedicalExamination mExamination)
        {

            foreach (MedicalExamination currentExamination in Examinations)
            {
                if (currentExamination.DateAndTime.Equals(mExamination.DateAndTime) && currentExamination.Room.ToString().Equals(mExamination.Room.ToString()))//dodati uslov za sobu
                    return true;
            }

            return false;

        }

        public void DeleteMedicalExamination(Model.Term.MedicalExamination medicalExamination)
      {
            foreach (MedicalExamination currentExamination in Examinations)
            {
                if (currentExamination.DateAndTime.Equals(medicalExamination.DateAndTime) && currentExamination.Room.ToString().Equals(medicalExamination.Room.ToString()))
                {
                    Examinations.Remove(currentExamination);
                    saveAllMedicalExaminations(Examinations);
                    MessageBox.Show("Pregled je uspesno obrisan", "informacija", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                }
            }
        }
      
      public Model.Term.MedicalExamination GetMExeminationPatient(ObservableCollection<MedicalExamination> jmbg)
      {
         throw new NotImplementedException();
      }

      public void saveAllMedicalExaminations(ObservableCollection<MedicalExamination> users)
      {
            string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(path, json);
      }

    }
}