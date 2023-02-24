/***********************************************************************
 * Module:  PatientRepository.cs
 * Purpose: Definition of the Class Repository.UserRepository.PatientRepository
 ***********************************************************************/

using Model.Roles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository.UserRepository
{
    public class PatientRepository : UserRepository<Patient>
    {
        private const String path = @"..\..\Resources\Data\Patients.txt";


        private static PatientRepository instance = null;

        public static PatientRepository getInstance()
        {
            if (instance == null)
            {
                instance = new PatientRepository();
            }
            return instance;
        }



        public ObservableCollection<Patient> Patients
        {
            get;
            set;

        }


        public PatientRepository()
        {
            Patients = new ObservableCollection<Patient>();
            Patients = GetAllUsers();
            /*Patient sekretarNovi = new Patient()
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
               Patients.Add(sekretarNovi);
               saveAllUsers(Patients);
             */


        }

        public ObservableCollection<Patient> GetAllUsers()
        {
            String text = "";
            if (File.Exists(path))
            {
                text = File.ReadAllText(path);
            }
            return JsonConvert.DeserializeObject<ObservableCollection<Patient>>(text);

        }

        public void saveAllUsers(ObservableCollection<Patient> patients)
        {
            string json = JsonConvert.SerializeObject(patients, Formatting.Indented);
            File.WriteAllText(path, json);

        }
    }
}