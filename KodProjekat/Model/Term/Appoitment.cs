/***********************************************************************
 * Module:  Appoitment.cs
 * Purpose: Definition of the Class Model.Term.Appoitment
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.Term
{
   public class Appoitment: INotifyPropertyChanged
    {
      private Room room;
      private DateTime dateAndTimeOfTerm;

        public Room Room
        {
            get { return room; }
            set { room = value; OnPropertyChanged("Password"); }

        }



        public DateTime DateAndTime
        {
            get { return dateAndTimeOfTerm; }
            set { dateAndTimeOfTerm = value; OnPropertyChanged("DateOfBirth"); }

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