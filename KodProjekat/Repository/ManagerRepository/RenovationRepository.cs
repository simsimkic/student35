/***********************************************************************
 * Module:  RenovationRepository.cs
 * Purpose: Definition of the Class Menadzer.MenagerRepository.RenovationRepository
 ***********************************************************************/

using Model.Term;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository.ManagerRepository
{
   public class RenovationRepository
   {
        private String path = @"../../Resources/Data/renoviranje.txt";

        private static RenovationRepository instance = null;

        public static RenovationRepository getInstance()
        {
            if (instance == null)
            {
                instance = new RenovationRepository();
            }
            return instance;
        }

        public ObservableCollection<Room> renovationRooms
        {
            get;
            set;

        }


        public RenovationRepository()
        {
            renovationRooms = new ObservableCollection<Room>();

           /* renovationRooms.Add(new Room()
            {
                NameOfRoom = "12",
                TypeOfRoom = "Soba za preglede",
                IsFree = false,
                StartRenovation = new DateTime(2019,8,18),
                EndRenovation = new DateTime(2019, 9, 22),
                RenovationPeriod = "18.08.2019-22.09.2019",
                 Split = "De",
                 Merge = "Ne",

             });

            

             saveAllRooms(renovationRooms);*/
        }


        public ObservableCollection<Room> GetAllRooms()
        {
            String text = "";

            if (File.Exists(path))
                text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ObservableCollection<Room>>(text);
        }


        public void saveAllRooms(ObservableCollection<Room> rooms)
        {
            string json = JsonConvert.SerializeObject(rooms, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(path, json);
        }

        public bool roomExist(string nameOfRoom)
        {

            foreach (Room currenRoom in GetAllRooms())
            {
                if (currenRoom.NameOfRoom.Equals(nameOfRoom))
                {
                    return true;
                }

            }

            return false;
        }


        public bool EditRoom(Room room)
        {
            renovationRooms = GetAllRooms();
            foreach (Room currenRoom in renovationRooms)
            {
                if (currenRoom.NameOfRoom.Equals(room.NameOfRoom))
                {
                    currenRoom.TypeOfRoom = room.TypeOfRoom;
                    currenRoom.RenovationPeriod = room.RenovationPeriod;
                    currenRoom.Split = room.Split;
                    currenRoom.IsFree = room.IsFree;
                    currenRoom.Merge = room.Merge;
                    currenRoom.StartRenovation = room.StartRenovation;
                    currenRoom.EndRenovation = room.EndRenovation;


                    saveAllRooms(renovationRooms);
                    return true;
                }

            }

            return false;
        }

        public bool deleteRoom(Room room)
        {
            renovationRooms = GetAllRooms();
            foreach (Room currenRoom in renovationRooms)
            {
                if (currenRoom.NameOfRoom.Equals(room.NameOfRoom))
                {
                    renovationRooms.Remove(currenRoom);

                    saveAllRooms(renovationRooms);
                    return true;
                }

            }

            return false;
        }

    }
}