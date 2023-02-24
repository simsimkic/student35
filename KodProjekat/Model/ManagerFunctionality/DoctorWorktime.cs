/***********************************************************************
 * Module:  DoctorWorktime.cs
 * Purpose: Definition of the Class Model.ManagerFunctionality.DoctorWorktime
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.ManagerFunctionality
{
   public class DoctorWorktime : INotifyPropertyChanged
    {

        private DateTime _danRada;
        private string _radnoVreme;

        public DoctorWorktime()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        public DateTime DanRada
        {
            get { return _danRada; }
            set { _danRada = value; OnPropertyChanged("DanRada"); }
        }



        public string RadnoVreme
        {
            get { return _radnoVreme; }
            set { _radnoVreme = value; OnPropertyChanged("RadnoVreme"); }
        }














        /* private int startTime;
      private int endTime;
      private DateTime day;
      
      public System.Collections.ArrayList doctor;
      
      /// <summary>
      /// Property for collection of Model.Roles.Doctor
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Doctor
      {
         get
         {
            if (doctor == null)
               doctor = new System.Collections.ArrayList();
            return doctor;
         }
         set
         {
            RemoveAllDoctor();
            if (value != null)
            {
               foreach (Model.Roles.Doctor oDoctor in value)
                  AddDoctor(oDoctor);
            }
         }
      }
      
      /// <summary>
      /// Add a new Model.Roles.Doctor in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddDoctor(Model.Roles.Doctor newDoctor)
      {
         if (newDoctor == null)
            return;
         if (this.doctor == null)
            this.doctor = new System.Collections.ArrayList();
         if (!this.doctor.Contains(newDoctor))
            this.doctor.Add(newDoctor);
      }
      
      /// <summary>
      /// Remove an existing Model.Roles.Doctor from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveDoctor(Model.Roles.Doctor oldDoctor)
      {
         if (oldDoctor == null)
            return;
         if (this.doctor != null)
            if (this.doctor.Contains(oldDoctor))
               this.doctor.Remove(oldDoctor);
      }
      
      /// <summary>
      /// Remove all instances of Model.Roles.Doctor from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllDoctor()
      {
         if (doctor != null)
            doctor.Clear();
      }*/

    }
}