/***********************************************************************
 * Module:  State.cs
 * Purpose: Definition of the Class Model.Roles.State
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.Roles
{
   public class State : INotifyPropertyChanged
    {
      private string name;


        public State(string name)
        {
            this.name = name;
        }


        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }

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