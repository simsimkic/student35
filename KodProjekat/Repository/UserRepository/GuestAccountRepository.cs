/***********************************************************************
 * Module:  GuestAccount.cs
 * Purpose: Definition of the Class Repository.UserRepository.GuestAccount
 ***********************************************************************/

using Model.Roles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace Repository.UserRepository
{

    public class GuestAccountRepository
    { 

      private const String path = @"../../Resources/Data/GostNalozi.txt";

      private static GuestAccountRepository instance = null;

      public static GuestAccountRepository getInstance()
      {
            if (instance == null)
            {
                instance = new GuestAccountRepository();
            }
            return instance;
      }



      public ObservableCollection<GuestAccount> Guests
      {
            get;
            set;

      }


        public GuestAccountRepository()
        {
            Guests = new ObservableCollection<GuestAccount>();
            Guests = GetAllGuests();
          /*  GuestAccount sekretarNovi = new GuestAccount()
            {
                
                Name = "Marko",
                Surname = "Srbljanovic",
                Jmbg = "222222222222",
                PhoneNumber = "076667828",
                


            };
            Guests.Add(sekretarNovi);
            saveAllGuestAccounts(Guests);
            */


        }

        public void AddGuest(Model.Roles.GuestAccount guestAccount)
        {
                if(GuestExists(guestAccount))
                {
                    MessageBox.Show("vec postoji taj lekar", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {
                    Guests.Add(guestAccount);
                    saveAllGuestAccounts(Guests);
                    MessageBox.Show("Lekar uspesno dodat u bazu", "informacija", MessageBoxButton.OK, MessageBoxImage.Information);
                }
        }
        
      
        public Model.Roles.GuestAccount DeleteGuest(Model.Roles.GuestAccount guestAccount)
        {
         throw new NotImplementedException();
        }
      
      public Model.Roles.GuestAccount GetGuest()
      {
         throw new NotImplementedException();
      }

      public bool GuestExists(GuestAccount guest)
      {

        foreach (GuestAccount currentguest in Guests)
        {
            if (currentguest.Jmbg.ToString().Equals(guest.Jmbg.ToString()))
                return true;
        }

        return false;

      }

      public ObservableCollection<GuestAccount> GetAllGuests()
      { 
            String text = "";

            if (File.Exists(path))
                text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ObservableCollection<GuestAccount>>(text);

      }


      public void saveAllGuestAccounts(ObservableCollection<GuestAccount> guests)
      {
            string json = JsonConvert.SerializeObject(guests, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(path, json);
      }

    }
}



















