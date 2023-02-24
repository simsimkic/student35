/***********************************************************************
 * Module:  DateAndTimeOfTerm.cs
 * Purpose: Definition of the Class Model.Term.DateAndTimeOfTerm
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.Term
{
   public class DateAndTimeOfTerm : INotifyPropertyChanged
    {
      private DateTime dateOfTerm;
      private string timeOfTerm;

        public string TimeOfTerm
        {
            get { return timeOfTerm; }
            set { timeOfTerm = value; OnPropertyChanged("TimeOfTerm"); }

        }



        public DateTime DateOfTerm
        {
            get { return dateOfTerm; }
            set { dateOfTerm = value; OnPropertyChanged("DateOfTerm"); }

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