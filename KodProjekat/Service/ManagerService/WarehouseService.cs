// File:    WarehouseService.cs
// Created: Thursday, June 11, 2020 6:12:27 PM
// Purpose: Definition of Class WarehouseService

using Model.ManagerFunctionality;
using Model.Medicaments;
using Repository.ManagerRepository;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Service.ManagerService
{
   public class WarehouseService
   {

        public Repository.ManagerRepository.EquipmentRepository equipmentRepository;
        public Repository.ManagerRepository.MedicamentRepository medicamentRepository;

        public ObservableCollection<Equipment> Equipments
        {
            get;
            set;

        }

        public ObservableCollection<Medicaments> Medicaments
        {
            get;
            set;

        }

        public WarehouseService()
        {
            Equipments = new ObservableCollection<Equipment>();
            Equipments = EquipmentRepository.getInstance().GetAllEquipments();

            Medicaments = new ObservableCollection<Medicaments>();
            Medicaments = MedicamentRepository.getInstance().GetAllMedicaments();

        }







        public void AddNewEquipment(Equipment equipment, string idEquipment)
      {
            if (EquipmentRepository.getInstance().typeEquimpmentExists(equipment.TipOpreme)) //ovde sam radio dodavanje ako vec postoji taj tip opreme
            {

                
                 Equipment backEquipment = EquipmentRepository.getInstance().GetEquipmentByType(equipment.TipOpreme,Equipments);//vratio sam opremu koju sam nasao


                if (passwordAllreadyExistsInThisTypeOfEquipment(backEquipment, idEquipment))
                {
                    MessageBox.Show("vec postoji taj tip opreme sa tom sifrom", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {
                    backEquipment.popunjavanjeSifri(idEquipment);
                     MessageBox.Show("Dodali ste u vec postojeci tip opremu sa novom sifrom", "Dodato", MessageBoxButton.OK, MessageBoxImage.Information);

                }



            }
            else //ovde sam radio dodavanje ako ne postoji taj tip opreme
            {
                equipment.popunjavanjeSifri(idEquipment);
                Equipments.Add(equipment);
                MessageBox.Show("Dodali ste u u novi tip opreme novu sifru opreme", "Dodato", MessageBoxButton.OK, MessageBoxImage.Information);

            }

            EquipmentRepository.getInstance().saveAllEquipments(Equipments);


        }

        

        public bool passwordAllreadyExistsInThisTypeOfEquipment(Equipment equipment, string passwordIn)
        {
            foreach (string password in equipment.vracanjeSifri())
            {
                if (password.ToString().Equals(passwordIn))
                {
                    return true;
                }
            }

            return false;
        }




        public void EditExistingEquipment(Equipment equipmentSelected, string newType, int newQuantity)
      {

            foreach (Equipment equipment in Equipments)
            {
                if (equipment.TipOpreme.ToString().Equals(equipmentSelected.TipOpreme)
                    && equipment.Kolicina==equipmentSelected.Kolicina)
                {
                    equipment.TipOpreme = newType;
                    equipment.Kolicina = newQuantity;
                    EquipmentRepository.getInstance().saveAllEquipments(Equipments);
                    MessageBox.Show("Uspesna izmena", "Izmena", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                }

            }




        }
      
      public void DeleteExistingEquipment(Equipment SelectedEquipment)
      {
            for (int i = 0; i < Equipments.Count; i++)
            {
                Equipment equipment = Equipments[i];
                if (equipment.TipOpreme.ToString().Equals(SelectedEquipment.TipOpreme.ToString()))
                {
                    Equipments.Remove(equipment);
                    EquipmentRepository.getInstance().saveAllEquipments(Equipments);
                    MessageBox.Show("Uspesno brisanje izabranog tipa opreme", "Izmena", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                }
            }
        }
      
      public void EditExistingMedicament(Medicaments medicamentEdited)
      {
            foreach (Medicaments medicamentCurrent in Medicaments)
            {
                if (medicamentCurrent.Sifra.ToString().Equals(medicamentEdited.Sifra))
                {

                    medicamentCurrent.Ime = medicamentEdited.Ime;
                    medicamentCurrent.Kolicina = medicamentEdited.Kolicina;
                    medicamentCurrent.Proizvodjac = medicamentEdited.Proizvodjac;
                    medicamentCurrent.Sastojci = medicamentEdited.Sastojci;

                    MessageBox.Show("Uspesna izmena leka", "Izmena", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                }

            }

            MedicamentRepository.getInstance().saveAllMedicaments(Medicaments);
        }
      
      public void DeleteExistingMedicament(Model.Medicaments.Medicaments selectedMedicament)
      {
            foreach (Medicaments medicamentCurrent in Medicaments)
            {
                if (medicamentCurrent.Sifra.ToString().Equals(selectedMedicament.Sifra))
                {

                    Medicaments.Remove(medicamentCurrent);

                    MessageBox.Show("Uspesno brisanje leka", "Izmena", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                }

            }

            MedicamentRepository.getInstance().saveAllMedicaments(Medicaments);
        }


        internal bool DeleteEquipmentPasswordFromType(string typeEquipment, string passwordForTypeEquipment)
        {
            if (EquipmentRepository.getInstance().typeEquimpmentExists(typeEquipment)) //proverimo da li postoji taj tip u tabeli
            {
                foreach (Equipment curentEquipment in Equipments) //idemo opet kroz svu opremu ako postoji
                {
                    if (curentEquipment.TipOpreme.Equals(typeEquipment)) //nadjemo taj tip
                    {

                        foreach (string currentPassword in curentEquipment.sifre) //idemo kroz sve njegove sifre
                        {
                            if (currentPassword.Equals(passwordForTypeEquipment))  //ako je ista kao unesena
                            {
                                curentEquipment.sifre.Remove(currentPassword); //obrisi je
                                curentEquipment.smanjenje_kolicine(); 

                                EquipmentRepository.getInstance().saveAllEquipments(Equipments); //sacuvaj izmene

                                MessageBox.Show("Obrisana je sifra za taj tip opreme u magacinu ", "Informacija", MessageBoxButton.OK, MessageBoxImage.Information);
                                return true;

                            }

                        }


                    }
                }
            }
            else
            {
                MessageBox.Show("Ne postoji taj tip opreme u magacinu", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            
            return false;
        }


       
   
   }
}