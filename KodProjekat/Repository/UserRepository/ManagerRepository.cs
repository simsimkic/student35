/***********************************************************************
 * Module:  ManagerRepository.cs
 * Purpose: Definition of the Class Repository.UserRepository.ManagerRepository
 ***********************************************************************/

using Model.Roles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository.UserRepository
{
   public class ManagerRepository : UserRepository<Manager>
    {
        private const String path = @"../../Resources/Data/menageri.txt";


        private static ManagerRepository instance = null;

        public static ManagerRepository getInstance()
        {
            if (instance == null)
            {
                instance = new ManagerRepository();
            }
            return instance;
        }

        public ObservableCollection<Manager> Managers
        {
            get;
            set;

        }


        public ManagerRepository()
        {
            Managers = new ObservableCollection<Manager>();
           /* Manager manager = new Manager()
              {
                  Username = "Stefan Zec",
                  Password = "1103998800010",
                  Name = "Stefan",
                  Surname = "Zec",
                  Jmbg = "1103998800010",
                  PhoneNumber = "0643863668",
                  Email = "stefanzec@hotmail.rs",
                  City = new City("Novi Sad", "21000", "Partizanska 2", new State("Srbija"))


              };
              Managers.Add(manager);
              saveAllUsers(Managers);*/



        }

        public ObservableCollection<Manager> GetAllUsers()
        {
            String text = "";

            if (File.Exists(path))
                text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ObservableCollection<Manager>>(text);

        }

        public void saveAllUsers(ObservableCollection<Manager> managers)
        {
            string json = JsonConvert.SerializeObject(managers, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(path, json);
        }


        public bool managerExists(Manager manager)
        {

            foreach (Manager currentManager in GetAllUsers())
            {
                if (currentManager.Username.ToString().Equals(manager.Username.ToString()) )
                    return true;
            }

            return false;


        }

        public Manager getManagerByID(string usernameOfManager)
        {

            foreach (Manager currentManager in GetAllUsers())
            {
                if (currentManager.Username.ToString().Equals(usernameOfManager))
                    return currentManager;
            }

            return null;


        }

        public bool registerManager(Manager manager)
        {
            Managers = GetAllUsers();
            Managers.Add(manager);
            saveAllUsers(Managers);
            return true;
        }



        public bool editManager(Manager manager)
        {
            Managers = GetAllUsers();
            foreach (Manager currentManager in Managers)
            {
                if (currentManager.Username.ToString().Equals(manager.Username.ToString()) )

                 
                currentManager.PhoneNumber=manager.PhoneNumber;
                currentManager.City.NameOfCity= manager.City.NameOfCity;               
                currentManager.City.PostCode=manager.City.PostCode;
                currentManager.City.Adress= manager.City.Adress;
                currentManager.City.State.Name= manager.City.State.Name;               
                currentManager.Email= manager.Email;
                

                saveAllUsers(Managers);
                return true;
            }

            return false;


        }
    }
}