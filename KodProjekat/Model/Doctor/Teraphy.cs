/***********************************************************************
 * Module:  Teraphy.cs
 * Purpose: Definition of the Class Model.Doctor.Teraphy
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class Teraphy
   {
      public System.Collections.ArrayList medicaments;
      
      /// <summary>
      /// Property for collection of Model.Medicaments.Medicaments
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Medicaments
      {
         get
         {
            if (medicaments == null)
               medicaments = new System.Collections.ArrayList();
            return medicaments;
         }
         set
         {
            RemoveAllMedicaments();
            if (value != null)
            {
               foreach (Model.Medicaments.Medicaments oMedicaments in value)
                  AddMedicaments(oMedicaments);
            }
         }
      }
      
      /// <summary>
      /// Add a new Model.Medicaments.Medicaments in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddMedicaments(Model.Medicaments.Medicaments newMedicaments)
      {
         if (newMedicaments == null)
            return;
         if (this.medicaments == null)
            this.medicaments = new System.Collections.ArrayList();
         if (!this.medicaments.Contains(newMedicaments))
            this.medicaments.Add(newMedicaments);
      }
      
      /// <summary>
      /// Remove an existing Model.Medicaments.Medicaments from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveMedicaments(Model.Medicaments.Medicaments oldMedicaments)
      {
         if (oldMedicaments == null)
            return;
         if (this.medicaments != null)
            if (this.medicaments.Contains(oldMedicaments))
               this.medicaments.Remove(oldMedicaments);
      }
      
      /// <summary>
      /// Remove all instances of Model.Medicaments.Medicaments from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllMedicaments()
      {
         if (medicaments != null)
            medicaments.Clear();
      }
   
   }
}