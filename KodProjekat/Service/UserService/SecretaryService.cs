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
    public class SecretaryService
    {
        public ObservableCollection<Secretary> Sekretari
        {
            get;
            set;

        }

        public SecretaryService()
        {
            Sekretari = new ObservableCollection<Secretary>();
            Sekretari = SecretaryRepository.getInstance().GetAllUsers();
        }

        public void RegisterSecretary(Secretary secretary)
        {
            if (SecretaryRepository.getInstance().secretarExists(secretary))
            {
                MessageBox.Show("vec postoji taj sekretar", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                Sekretari.Add(secretary);
                SecretaryRepository.getInstance().saveAllUsers(Sekretari);
                MessageBox.Show("Sekretar uspesno dodat u bazu", "informacija", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public void ChangeSecretary(Secretary editedSecretary)
        {
            foreach (Secretary currentSecretary in Sekretari) {

                if (currentSecretary.Jmbg.Equals(editedSecretary.Jmbg)) {

                    currentSecretary.PhoneNumber = editedSecretary.PhoneNumber;
                    currentSecretary.Email = editedSecretary.Email;
                    currentSecretary.Username = editedSecretary.Username;
                    currentSecretary.Password = editedSecretary.Password;
                    currentSecretary.City = editedSecretary.City;
                    SecretaryRepository.getInstance().saveAllUsers(Sekretari);
                    MessageBox.Show("Sekretar uspesno izmenjen", "informacija", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                }

            }

            }

        }



    }

