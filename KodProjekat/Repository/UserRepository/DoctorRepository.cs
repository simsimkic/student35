/***********************************************************************
 * Module:  DoctorRepository.cs
 * Purpose: Definition of the Class Repository.UserRepository.DoctorRepository
 ***********************************************************************/

using Model.Roles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository.UserRepository
{
    public class DoctorRepository : UserRepository<Doctor>
   {
      private const String path = @"../../Resources/Data/doktori.txt";


        private static DoctorRepository instance = null;

        public static DoctorRepository getInstance()
        {
            if (instance == null)
            {
                instance = new DoctorRepository();
            }
            return instance;
        }

        public ObservableCollection<Doctor> Lekari
        {
            get;
            set;

        }


        public DoctorRepository()
        {
          /*  Lekari = new ObservableCollection<Doctor>();
            Doctor doctorNovi = new Doctor()
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
            Lekari.Add(doctorNovi);
            saveAllUsers(Lekari);*/



        }

        public ObservableCollection<Doctor> GetAllUsers()
        {
            String text= "";

            if (File.Exists(path))
                text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ObservableCollection<Doctor>>(text);
            
        }

        public void saveAllUsers(ObservableCollection<Doctor> users)
        {
            string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(path, json);
        }


        public bool doctorExists(Doctor doctorUneti)
        {

            foreach (Doctor doctorTrenutni in GetAllUsers())
            {
                if (doctorTrenutni.Jmbg.ToString().Equals(doctorUneti.Jmbg.ToString()))
                    return true;
            }

            return false;


        }


        public Doctor getDoctorByID(string id)
        {

            foreach (Doctor doctorTrenutni in GetAllUsers())
            {
                if (doctorTrenutni.Jmbg.ToString().Equals(id))
                    return doctorTrenutni;
                
            }

            return null;
        }
    }
}