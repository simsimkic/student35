/***********************************************************************
 * Module:  SecretaryRepository.cs
 * Purpose: Definition of the Class Repository.UserRepository.SecretaryRepository
 ***********************************************************************/

using Model.Roles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository.UserRepository
{
   public class SecretaryRepository : UserRepository<Secretary>
   {
      private const String path = @"../../Resources/Data/Sekretari.txt";



        private static SecretaryRepository instance = null;

        public static SecretaryRepository getInstance()
        {
            if (instance == null)
            {
                instance = new SecretaryRepository();
            }
            return instance;
        }

        public ObservableCollection<Secretary> Sekretari
        {
            get;
            set;

        }


        public SecretaryRepository()
        {
            Sekretari = new ObservableCollection<Secretary>();
            
           /* Secretary sekretarNovi = new Secretary()
            {
                Username = "Marko",
                Password = "111111111111",
                Name = "Marko",
                Surname = "Srbljanovic",
                Jmbg = "222222222222",
                PhoneNumber = "076667828",
                Email = "marko@hotmail.rs",
                City = new City("Novi Sad", "21000", "Partizanska 5", new State("Srbija"))


            };
            Sekretari.Add(sekretarNovi);
            saveAllUsers(Sekretari);
            */


        }



        public bool secretarExists(Secretary secretary)
        {

            foreach (Secretary sekretarTrenutni in GetAllUsers())
            {
                if (sekretarTrenutni.Jmbg.ToString().Equals(secretary.Jmbg.ToString()))
                    return true;
            }

            return false;

        }


        public ObservableCollection<Secretary> GetAllUsers()
        {
            String text = "";

            if (File.Exists(path))
                text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ObservableCollection<Secretary>>(text);

        }

        public void saveAllUsers(ObservableCollection<Secretary> users)
        {
            string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(path, json);
        }
    }
}