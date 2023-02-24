/***********************************************************************
 * Module:  Medicaments.cs
 * Purpose: Definition of the Class Model.ManagerFunctionality.Medicaments
 ***********************************************************************/


using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Model.Medicaments
{
    

    public class Medicaments : INotifyPropertyChanged
    {
      private string _ime;
      private string _sifra;
      private string _kolicina;
      private string _proizvodjac;
      private string _sastojci;

       

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public long GetId()
        {
            throw new NotImplementedException();
        }

        public void SetId(long id)
        {
            throw new NotImplementedException();
        }

        public string Ime
        {
            get { return _ime; }
            set { _ime = value; OnPropertyChanged("Ime"); }

        }

        public string Sifra
        {
            get { return _sifra; }
            set { _sifra = value; OnPropertyChanged("Sifra"); }

        }

        public string Kolicina
        {
            get { return _kolicina; }
            set { _kolicina = value; OnPropertyChanged("Kolicina"); }

        }


        public string Proizvodjac
        {
            get { return _proizvodjac; }
            set { _proizvodjac = value; OnPropertyChanged("Proizvodjac"); }

        }

        public string Sastojci
        {
            get { return _sastojci; }
            set { _sastojci = value; OnPropertyChanged("Sastojci"); }

        }

    }
}