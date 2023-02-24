// File:    RenovationService.cs
// Created: Thursday, June 11, 2020 6:15:29 PM
// Purpose: Definition of Class RenovationService

using Model.Term;
using Repository.ManagerRepository;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Service.ManagerService
{
   public class RenovationService
   {
        public Repository.ManagerRepository.RenovationRepository renovationRepository;

        public ObservableCollection<Room> roomsForRenovation
        {
            get;
            set;

        }

        public ObservableCollection<Room> rooms
        {
            get;
            set;

        }

        public RenovationService()
        {
            roomsForRenovation = new ObservableCollection<Room>();
            roomsForRenovation = RenovationRepository.getInstance().GetAllRooms();

            rooms = new ObservableCollection<Room>();
            rooms = RoomRepository.getInstance().GetAllRooms();
        }










        public void SheduleRenovation(Room roomForRenovation)
      {

            if (RenovationRepository.getInstance().roomExist(roomForRenovation.NameOfRoom))
            {
                MessageBox.Show("Zakazujete renoviranje prostorije koja se vec renovira", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                foreach (Room currenRoom in rooms)
                {
                    if (currenRoom.NameOfRoom.Equals(roomForRenovation.NameOfRoom))
                    {
                        currenRoom.TypeOfRoom = roomForRenovation.TypeOfRoom;
                        currenRoom.RenovationPeriod = roomForRenovation.RenovationPeriod;
                        currenRoom.Split = roomForRenovation.Split;
                        currenRoom.IsFree = roomForRenovation.IsFree;
                        currenRoom.Merge = roomForRenovation.Merge;
                        currenRoom.StartRenovation = roomForRenovation.StartRenovation;
                        currenRoom.EndRenovation = roomForRenovation.EndRenovation;
                        

                        roomsForRenovation.Add(currenRoom);

                        RenovationRepository.getInstance().saveAllRooms(roomsForRenovation);
                        RoomRepository.getInstance().saveAllRooms(rooms);

                        MessageBox.Show("Uspeno zakazano renoviranje i izvrsene su izmene za datu prostoriju", "Renoviranje", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;


                    }
                }

            }


        }


       
      
      
      public void EditRenovation(Room room)
      {

            if (RenovationRepository.getInstance().EditRoom(room))
            {
                if (RoomRepository.getInstance().EditRoom(room))
                {
                    MessageBox.Show("Uspesno je izmenjeno renoviranje i izvrsene su izmene za datu prostoriju", "Renoviranje", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
           
        }



        public void deleteRoomFromRenovationList(Room room)
        {

            if (RenovationRepository.getInstance().deleteRoom(room))
            {
                if (RoomRepository.getInstance().EditRoom(room))
                {
                    MessageBox.Show("Uspesno je obrisana prostorija iz renoviranja", "Renoviranje", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }


            
        }

        
   
   }
}