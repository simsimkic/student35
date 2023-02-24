/***********************************************************************
 * Module:  Secretary.cs
 * Purpose: Definition of the Class Model.Roles.Secretary
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.Roles
{
   public class Secretary : User, INotifyPropertyChanged
    {
            
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