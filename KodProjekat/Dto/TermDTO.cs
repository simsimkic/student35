/***********************************************************************
 * Module:  TermDTO.cs
 * Purpose: Definition of the Class Dto.TermDTO
 ***********************************************************************/

using Model.Term;
using System;
using System.ComponentModel;

namespace Dto
{
   public class TermDTO : INotifyPropertyChanged
    {
      private Room room;
      private DateTime term;
      private string typeOfIntervention;

        public Room Room
        {
            get { return room; }
            set { room = value; OnPropertyChanged("Room"); }

        }

        public DateTime Term
        {
            get { return term; }
            set { term = value; OnPropertyChanged("Term"); }

        }

        public string TypeOfIntervention
        { 
            get { return typeOfIntervention; }
            set { typeOfIntervention = value; OnPropertyChanged("TypeOfIntervention"); }

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