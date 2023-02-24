/***********************************************************************
 * Module:  Explanation.cs
 * Purpose: Definition of the Class Model.Medicaments.Explanation
 ***********************************************************************/

using System;

namespace Model.Medicaments
{
   public class Explanation
   {
      private string reason;
      
      public Model.Roles.Doctor doctor;
      
      /// <summary>
      /// Property for Model.Roles.Doctor
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Model.Roles.Doctor Doctor
      {
         get
         {
            return doctor;
         }
         set
         {
            this.doctor = value;
         }
      }
   
   }
}