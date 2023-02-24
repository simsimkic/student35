/***********************************************************************
 * Module:  City.cs
 * Purpose: Definition of the Class Model.Roles.City
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.Roles
{
   public class City : INotifyPropertyChanged
    {
      private string nameOfCity;
      private string postCode;
      private string adress;
      
      private State state;

        public City(string nameOfCity, string postCode, string adress, State state)
        {
            this.nameOfCity = nameOfCity;
            this.postCode = postCode;
            this.adress = adress;
            State = state;
         
        }


        public string NameOfCity
        {
            get { return nameOfCity; }
            set { nameOfCity = value; OnPropertyChanged("NameOfCity"); }

        }


        public string PostCode
        {
            get { return postCode; }
            set { postCode = value; OnPropertyChanged("PostCode"); }

        }


        public string Adress
        {
            get { return adress; }
            set { adress = value; OnPropertyChanged("Adress"); }

        }


        /// <summary>
        /// Property for State
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public State State
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}