/***********************************************************************
 * Module:  RoomRepository.cs
 * Purpose: Definition of the Class Menadzer.MenagerService.RoomRepository
 ***********************************************************************/

using Model.Term;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository.ManagerRepository
{
   public class RoomRepository
   {
        private String path = @"../../Resources/Data/prostorije.txt";

        private static RoomRepository instance = null;

        public static RoomRepository getInstance()
        {
            if (instance == null)
            {
                instance = new RoomRepository();
            }
            return instance;
        }

        public ObservableCollection<Room> Rooms
        {
            get;
            set;

        }


        public RoomRepository()
        {
            Rooms = new ObservableCollection<Room>();
            
           /* Rooms.Add(new Room()
            {
                NameOfRoom = "12",
                TypeOfRoom = "Soba za preglede",
                IsFree = true
                

            });

            Rooms.Add(new Room()
            {
                NameOfRoom = "124",
                TypeOfRoom = "Soba za preglede",
                IsFree = true
                

            });

            saveAllRooms(Rooms);*/
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
            Rooms = GetAllRooms();
            foreach (Room currenRoom in Rooms)
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

                    saveAllRooms(Rooms);

                    return true;
                }

            }

            return false;
        }



    }
}