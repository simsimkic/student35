/***********************************************************************
 * Module:  Equipment.cs
 * Purpose: Definition of the Class Model.ManagerFunctionality.Equipment
 ***********************************************************************/

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Model.ManagerFunctionality
{
   public class Equipment : INotifyPropertyChanged
    {
      private string _tipOpreme;
      private int _kolicina=0;

        public Equipment()
        {
            sifre = new ObservableCollection<string>();
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public ObservableCollection<string> sifre
        {
            get;
            set;

        }

        public void popunjavanjeSifri(string id)
        {

            if (sadrziSifru(id))
            {
                MessageBox.Show("Vec postoji sifra ove opreme u ovom tipu opreme", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
            else
            {
                sifre.Add(id);
                _kolicina++;
               // MessageBox.Show("Uspeno je dodata nova sifra za dati tip opreme", "Greska", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
            
            
            
        }

        public void smanjenje_kolicine()
        {
            _kolicina--;
            if (_kolicina < 0)
            {
                _kolicina = 0;
            }

        }

        public bool sadrziSifru(string id)
        {
            foreach (string sifra in sifre)
            {
                if (sifra.Equals(id))
                {
                    return true;
                }
            }

            return false;
        }


        public ObservableCollection<string> vracanjeSifri()
        {
            return sifre;
        }

        public string TipOpreme
        {
            get { return _tipOpreme; }
            set { _tipOpreme = value; OnPropertyChanged("TipOpreme"); }

        }


        public int Kolicina
        {
            get { return _kolicina; }
            set { _kolicina = value; OnPropertyChanged("Kolicina"); }

        }


    }
}