// File:    RoomControler.cs
// Created: Thursday, June 11, 2020 6:03:31 PM
// Purpose: Definition of Class RoomControler

using Model.ManagerFunctionality;
using Model.Term;
using Service.ManagerService;
using System;

namespace Controller.ManagerController
{
   public class RoomControler
   {
      public void NewRoom(Room room)
      {
            RoomService roomService = new RoomService();
            roomService.NewRoom(room);
      }
      
      public void EditTypeOfRoom(Room room)
      {
            RoomService roomService = new RoomService();
            roomService.EditTypeOfRoom(room);
        }

        public bool TakeEquipmentFromRoom(string typeOfEquipment, string passwordForTypeEquipment, string nameOfRoom)
        {
            RoomService roomService = new RoomService();
            return roomService.TakeEquipmentFromRoom(typeOfEquipment, passwordForTypeEquipment, nameOfRoom);
        }

        public void AddEquipmentInRoom(string typeOfEquipment,string passwordForTypeEquipment,string nameOfRoom)
        {
            RoomService roomService = new RoomService();
            roomService.AddEquipmentInRoom(typeOfEquipment,passwordForTypeEquipment,nameOfRoom);
        }

        public bool deleteRoom( string nameOfRoom)
        {
            RoomService roomService = new RoomService();
            return roomService.deleteRoom(nameOfRoom);
        }

    }
}