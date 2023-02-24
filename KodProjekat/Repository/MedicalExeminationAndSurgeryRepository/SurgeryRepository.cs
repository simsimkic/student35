/***********************************************************************
 * Module:  SurgeryRepository.cs
 * Purpose: Definition of the Class Repository.MedicalExeminationAndSurgeryRepository.SurgeryRepository
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
   public class SurgeryRepository
   {
        private const String path = @"../../Resources/Data/Surgery.txt";

        private static SurgeryRepository instance = null;

        public static SurgeryRepository getInstance()
        {
            if (instance == null)
            {
                instance = new SurgeryRepository();
            }
            return instance;
        }

        public ObservableCollection<Surgery> Surgeries
        {
            get;
            set;

        }

        public SurgeryRepository()
        {
            Surgeries = new ObservableCollection<Surgery>();
            Surgeries = GetAllSurgeries();

        }


        public ObservableCollection<Surgery> GetSurgeryDoctor(Doctor doctor)
        {
            ObservableCollection<Surgery> retVal = new ObservableCollection<Surgery>();
            foreach (Surgery current in Surgeries)
            {
                if (current.Doctor.Jmbg.Equals(doctor.Jmbg))
                {
                    retVal.Add(current);

                }

            }

            return retVal;
        }

        public void SetSurgery(Model.Term.Surgery editedSurgery)
      {
          
         
                foreach (Surgery currentSurgery in Surgeries)
                {
                    if (currentSurgery.DateAndTime.Equals(editedSurgery.DateAndTime) && currentSurgery.Room.ToString().Equals(editedSurgery.Room.ToString()))
                    {
                    currentSurgery.Doctor = editedSurgery.Doctor;
                    currentSurgery.Patient = editedSurgery.Patient;
                    currentSurgery.GuestAccount = editedSurgery.GuestAccount;
                        

                        saveAllSurgeries(Surgeries);
                        MessageBox.Show("Termin je uspesno izmenjen", "informacija", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    }
                }
           
        }

        public void NewSurgery(Surgery surgery)
        {
            if (SurgeryExists(surgery))
            {
                MessageBox.Show("Već je zakazan taj termin", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                Surgeries.Add(surgery);
                saveAllSurgeries(Surgeries);
                MessageBox.Show("Operacija je uspesno zakazana", "informacija", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }


        public bool SurgeryExists(Surgery surgery)
        {

            foreach (Surgery currentSurgery in Surgeries)
            {
                if (currentSurgery.DateAndTime.Equals(surgery.DateAndTime) && currentSurgery.Room.ToString().Equals(surgery.Room.ToString()))
                    return true;
            }

            return false;

        }

        public void DeleteSurgery(Model.Term.Surgery surgery)
        {
                   foreach (Surgery currentSurgery in Surgeries)
                {
                    if (currentSurgery.DateAndTime.Equals(surgery.DateAndTime) && currentSurgery.Room.ToString().Equals(surgery.Room.ToString()))
                    {
                        Surgeries.Remove(currentSurgery);
                        saveAllSurgeries(Surgeries);
                        MessageBox.Show("Operacija je obrisana", "informacija", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    }
                }
        }
      
     

        public void saveAllSurgeries(ObservableCollection<Surgery> users)
        {
            string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(path, json);
        }


        public ObservableCollection<Surgery> GetAllSurgeries()
        {
            String text = "";

            if (File.Exists(path))
                text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ObservableCollection<Surgery>>(text);

        }
    }
}