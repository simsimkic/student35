// File:    RenovationControler.cs
// Created: Thursday, June 11, 2020 6:07:31 PM
// Purpose: Definition of Class RenovationControler

using Model.Term;
using Service.ManagerService;
using System;

namespace Controller.ManagerController
{
   public class RenovationControler
   {
      public void SheduleRenovation(Room room)
      {
            RenovationService renovationService = new RenovationService();
            renovationService.SheduleRenovation(room);
      }
   
       public void EditRenovation(Room room)
      {
            RenovationService renovationService = new RenovationService();
            renovationService.EditRenovation(room);
        }

        public void deleteRoomFromRenovationList(Room room)
        {
            RenovationService renovationService = new RenovationService();
            renovationService.deleteRoomFromRenovationList(room);
        }

    }
}