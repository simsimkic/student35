/***********************************************************************
 * Module:  MedicalRecord.cs
 * Purpose: Definition of the Class Model.Doctor.MedicalRecord
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class MedicalRecord
   {
      private string id;
      private string name;
      private string surname;
      private string jmbg;
      private DateTime dateOfBirth;
      private string contactNumber;
      private string email;
      
      public Model.Roles.City city;
      
      /// <summary>
      /// Property for Model.Roles.City
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Model.Roles.City City
      {
         get
         {
            return city;
         }
         set
         {
            this.city = value;
         }
      }
      public Model.Roles.State state;
      
      /// <summary>
      /// Property for Model.Roles.State
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Model.Roles.State State
      {
         get
         {
            return state;
         }
         set
         {
            this.state = value;
         }
      }
      public Model.Term.MedicalExamination medicalExamination;
      public MedicalHistory medicalHistory;
      public Teraphy teraphy;
      
      /// <summary>
      /// Property for Teraphy
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Teraphy Teraphy
      {
         get
         {
            return teraphy;
         }
         set
         {
            this.teraphy = value;
         }
      }
      public Model.Roles.Patient patient;
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