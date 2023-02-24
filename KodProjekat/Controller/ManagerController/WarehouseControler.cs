// File:    WarehouseControler.cs
// Created: Thursday, June 11, 2020 6:02:30 PM
// Purpose: Definition of Class WarehouseControler

using Model.ManagerFunctionality;
using Model.Medicaments;
using Service.ManagerService;
using System;

namespace Controller.ManagerController
{
   public class WarehouseControler
   {
        public void AddNewEquipment(Equipment equipment,string idEquipment)
        {
            WarehouseService warehouseService = new WarehouseService();
            warehouseService.AddNewEquipment(equipment, idEquipment);

        }

        public void EditExistingEquipment(Equipment equipmentSelected,string newType, int newQuantity)
        {
            WarehouseService warehouseService = new WarehouseService();
            warehouseService.EditExistingEquipment(equipmentSelected, newType, newQuantity);
        }

        public void DeleteExistingEquipment(Equipment SelectedEquipment)
        {
            WarehouseService warehouseService = new WarehouseService();
            warehouseService.DeleteExistingEquipment(SelectedEquipment);
        }

        public void EditExistingMedicament(Medicaments medicament)
        {
            WarehouseService warehouseService = new WarehouseService();
            warehouseService.EditExistingMedicament(medicament);
        }

        public void DeleteExistingMedicament(Medicaments medicament)
        {
            WarehouseService warehouseService = new WarehouseService();
            warehouseService.DeleteExistingMedicament(medicament);
        }

        public bool DeleteEquipmentPasswordFromType(string typeEquipment,string passwordForTypeEquipment)
        {
            WarehouseService warehouseService = new WarehouseService();
           return warehouseService.DeleteEquipmentPasswordFromType(typeEquipment,passwordForTypeEquipment);
        }

    }
}