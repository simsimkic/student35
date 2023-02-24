using Model.Roles;
using Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projekat_upravnik.Service.UserService
{
   public class DoctorService
    {
        public ObservableCollection<Doctor> Lekari
        {
            get;
            set;

        }

        public DoctorService()
        {
           Lekari = new ObservableCollection<Doctor>();
           Lekari= DoctorRepository.getInstance().GetAllUsers();
        }

        public void RegisterDoctor(Doctor doctor)
        {
            if (DoctorRepository.getInstance().doctorExists(doctor))
            {
                MessageBox.Show("vec postoji taj lekar", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                Lekari.Add(doctor);
                DoctorRepository.getInstance().saveAllUsers(Lekari);
                MessageBox.Show("Lekar uspesno dodat u bazu", "informacija", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

       


    }
}
