/***********************************************************************
 * Module:  Room.cs
 * Purpose: Definition of the Class Model.Term.Room
 ***********************************************************************/

using Model.ManagerFunctionality;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Model.Term
{
    

    public class Room : INotifyPropertyChanged
    {

      private string nameOfRoom;
      private string typeOfRoom;
      private bool isFree;
        private string renovationPeriod;
      private string split;
      private string merge;
        DateTime startRenovation;
        DateTime endRenovation;

        public Room()
        {
            ListEquipmentsInRoom = new ObservableCollection<Equipment>();
        }

        public ObservableCollection<Equipment> ListEquipmentsInRoom
        {
            get;
            set;

        }

        public ObservableCollection<Equipment> vracanjeListeOpremaUProstoriji()
        {
            return ListEquipmentsInRoom;
        }

        public DateTime StartRenovation
        {
            get { return startRenovation; }
            set { startRenovation = value; OnPropertyChanged("StartRenovation"); }

        }

        public DateTime EndRenovation
        {
            get { return endRenovation; }
            set { endRenovation = value; OnPropertyChanged("EndRenovation"); }

        }


        public string NameOfRoom
        {
            get { return nameOfRoom; }
            set { nameOfRoom = value; OnPropertyChanged("NameOfRoom"); }

        }

        public string TypeOfRoom
        {
            get { return typeOfRoom; }
            set { typeOfRoom = value; OnPropertyChanged("TypeOfRoom"); }

        }

        public bool IsFree
        {
            get { return isFree; }
            set { isFree = value; OnPropertyChanged("IsFree"); }

        }


        public string RenovationPeriod
        {
            get { return renovationPeriod; }
            set { renovationPeriod = value; OnPropertyChanged("RenovationPeriod"); }

        }

        public string Split
        {
            get { return split; }
            set { split = value; OnPropertyChanged("Split"); }

        }

        public string Merge
        {
            get { return merge; }
            set { merge = value; OnPropertyChanged("Merge"); }

        }

        public override string ToString()
        {
            return TypeOfRoom + " " + NameOfRoom;
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