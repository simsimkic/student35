/***********************************************************************
 * Module:  EquipmentRepository.cs
 * Purpose: Definition of the Class Menadzer.MenagerRepository.EquipmentRepository
 ***********************************************************************/

using Model.ManagerFunctionality;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository.ManagerRepository
{
   public class EquipmentRepository
   {
      private String path = @"../../Resources/Data/oprema.txt";

        private static EquipmentRepository instance = null;

        public static EquipmentRepository getInstance()
        {
            if (instance == null)
            {
                instance = new EquipmentRepository();
            }
            return instance;
        }

        public ObservableCollection<Equipment> Equipments
        {
            get;
            set;

        }


        public EquipmentRepository()
        {
            /*Equipments = new ObservableCollection<Equipment>();

            Equipments.Add(new Equipment()
            {
                TipOpreme = "stolice",
                Kolicina = "3"

            });

            foreach (Equipment opremaPoredjenja1 in Equipments)
            {
                if (opremaPoredjenja1.TipOpreme.ToString().Equals("stolice"))
                {
                    opremaPoredjenja1.popunjavanjeSifri("22222");
                    opremaPoredjenja1.popunjavanjeSifri("33333");
                    opremaPoredjenja1.popunjavanjeSifri("44444");
                }
            }
            saveAllEquipments(Equipments);*/


        }


        public ObservableCollection<Equipment> GetAllEquipments()
        {
            String text = "";

            if (File.Exists(path))
                text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ObservableCollection<Equipment>>(text);
        }


        public void saveAllEquipments(ObservableCollection<Equipment> equipments)
        {
            string json = JsonConvert.SerializeObject(equipments, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(path, json);
        }


        public bool typeEquimpmentExists(string typeOfEquipment)
        {
            foreach (Equipment curentEquipment in GetAllEquipments())
            {
                if (curentEquipment.TipOpreme.ToString().Equals(typeOfEquipment))
                    return true;
            }

            return false;

        }


        public Equipment GetEquipmentByType(String typeEquipment, ObservableCollection<Equipment> equipments )
      {
            foreach (Equipment curentEquipment in equipments)
            {
                if (curentEquipment.TipOpreme.ToString().Equals(typeEquipment))
                    return curentEquipment;
            }

            return null;
        }


        public ObservableCollection<string> returnPasswordsOfEquipmentByType(string typeOfEquipment)
        {

            foreach (Equipment equipment in GetAllEquipments())
            {
                if (equipment.TipOpreme.ToString().Equals(typeOfEquipment))
                {
                    return equipment.vracanjeSifri();

                }

            }
            return null;

        }

      
      
      
      
      
   
   }
}