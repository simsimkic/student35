// File:    RoomService.cs
// Created: Thursday, June 11, 2020 6:13:40 PM
// Purpose: Definition of Class RoomService

using Model.ManagerFunctionality;
using Model.Term;
using Repository.ManagerRepository;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Service.ManagerService
{
   public class RoomService
   {

        public Repository.ManagerRepository.RoomRepository roomRepository;
        public Repository.ManagerRepository.EquipmentRepository equipmentRepository;



        public ObservableCollection<Room> Rooms
        {
            get;
            set;

        }

       

        public RoomService()
        {
            Rooms = new ObservableCollection<Room>();
            Rooms = RoomRepository.getInstance().GetAllRooms();

            
        }





        public void NewRoom(Model.Term.Room room)
      {
            //  if (postojiProstorija(room.NameOfRoom))
            if (RoomRepository.getInstance().roomExist(room.NameOfRoom))
            {
                MessageBox.Show("Vec postoji ta prostorija", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Rooms.Add(room);
                RoomRepository.getInstance().saveAllRooms(Rooms);
                MessageBox.Show("Nova prostorija je uspesno dodata", "informacija", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


      
        public void EditTypeOfRoom(Room editRoom)
      {
            foreach (Room trenutnaSoba in Rooms)
            {
                if (trenutnaSoba.NameOfRoom.Equals(editRoom.NameOfRoom))
                {
                    trenutnaSoba.TypeOfRoom = editRoom.TypeOfRoom;
                    RoomRepository.getInstance().saveAllRooms(Rooms);
                    MessageBox.Show("Uspesno ste izmenili tip prostorije", "Izmena", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

            }

            MessageBox.Show("Prostorija kojoj zelite da menjate tip ne postoji", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);

        }
      
      
        public void AddEquipmentInRoom(string typeOfEquipment, string passwordForTypeEquipment, string nameOfRoom)
        {

            if (RoomRepository.getInstance().roomExist(nameOfRoom))
            {

                foreach (Room currentRoom in Rooms)
                {
                    if (currentRoom.NameOfRoom.Equals(nameOfRoom))
                    {
                        if (existTypeOfEquipmentInRoom(currentRoom.ListEquipmentsInRoom, typeOfEquipment))//ako postoji taj tip opreme u prostoriji
                        {

                            foreach (Equipment currenEquipment in currentRoom.ListEquipmentsInRoom)
                            {
                                if (currenEquipment.TipOpreme.Equals(typeOfEquipment))
                                {
                                    currenEquipment.popunjavanjeSifri(passwordForTypeEquipment);
                                    RoomRepository.getInstance().saveAllRooms(Rooms); //cuvamo izmene

                                    MessageBox.Show("U izabranu prostoriju je premestena oprema i dodana je u vec postojeci tip nova sifra", "Greska", MessageBoxButton.OK, MessageBoxImage.Information);
                                    return;
                                }


                            }

                        }
                        else
                        {
                            Equipment opremaNova = new Equipment()
                            {
                                TipOpreme = typeOfEquipment,
                                
                            };
                            opremaNova.popunjavanjeSifri(passwordForTypeEquipment);

                            currentRoom.ListEquipmentsInRoom.Add(opremaNova);
                            RoomRepository.getInstance().saveAllRooms(Rooms); //cuvamo izmene
                            MessageBox.Show("U izabranu prostoriju je premestena oprema i dodana je sa novim tipom", "Informacija", MessageBoxButton.OK, MessageBoxImage.Information);
                            return;

                        }

                    }

                }

            }
            else
            {
                MessageBox.Show("Prostorija koju zelite da dodate opremu ne postoji", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


        public bool existTypeOfEquipmentInRoom(ObservableCollection<Equipment> listEquipmentsInRoom, string typeOfEquiomentForMove)
        {
            foreach (Equipment currenEquipment in listEquipmentsInRoom)
            {
                if (currenEquipment.TipOpreme.Equals(typeOfEquiomentForMove))
                {
                    return true;
                }
            }


            return false;
        }



        public bool TakeEquipmentFromRoom(string typeOfEquipment, string passwordForTypeEquipment, string nameOfRoom)
        {
            foreach (Room currentRoom in Rooms)
            {
                if (currentRoom.NameOfRoom.Equals(nameOfRoom)) //proveravam naziv prostorije
                {
                    if (existTypeOfEquipmentInRoom(currentRoom.ListEquipmentsInRoom, typeOfEquipment))//ako postoji taj tip opreme u prostoriji ulazim da ga nadjem
                    {

                        foreach (Equipment currentEquipment in currentRoom.ListEquipmentsInRoom) //idem opet kroz sve opreme
                        {
                            if (currentEquipment.TipOpreme.Equals(typeOfEquipment)) //nalazim taj tip
                            {

                                if (typeOfEquipmentHaveInputPassword(currentEquipment, passwordForTypeEquipment)) //gledamo da li taj tip opreme sadrzi unetu sifru
                                {
                                    foreach (string sifra in currentEquipment.sifre) //idem kroz sifre te opreme
                                    {
                                        if (sifra.Equals(passwordForTypeEquipment))
                                        {
                                            currentEquipment.sifre.Remove(sifra); //nadjemo je i obrisemo iz listi sifara
                                            currentEquipment.smanjenje_kolicine();

                                            if(currentEquipment.sifre.Count == 0) //ako je za taj tip opreme lista sifri prazna obrisi taj tip opreme
                                            {
                                                foreach(Equipment currentEquipment2 in currentRoom.ListEquipmentsInRoom)
                                                {
                                                    if (currentEquipment2.TipOpreme.Equals(currentEquipment.TipOpreme))
                                                        currentRoom.ListEquipmentsInRoom.Remove(currentEquipment2);
                                                    
                                                       break;
                                                }
                                            }

                                            RoomRepository.getInstance().saveAllRooms(Rooms); //cuvamo izmene

                                            return true;  
                                        }
                                    }
                                }
                                else
                                {
                                    return false;
                                }

                           }

                        }

                    }
                    else
                    {
                        return false;

                    }

                }

            }

            return false;
        }


        public bool typeOfEquipmentHaveInputPassword(Equipment equipment, string passwordOfEquipmentForRemove)
        {
            foreach (string currentPassword in equipment.sifre) 
            {
                if (currentPassword.Equals(passwordOfEquipmentForRemove))
                {
                    return true;
                }
            }

            return false;
        }

        public bool deleteRoom(string nameOfRoom)
        {
            Rooms = RoomRepository.getInstance().GetAllRooms();

            foreach (Room currentRoom in Rooms)
            {
                if (currentRoom.NameOfRoom.Equals(nameOfRoom) && currentRoom.IsFree==true) 
                {
                    Rooms.Remove(currentRoom);
                    RoomRepository.getInstance().saveAllRooms(Rooms);
                    return true;
                }

            }

            return false;

        }

    }
}