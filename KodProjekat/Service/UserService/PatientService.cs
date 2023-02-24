using Model.Roles;
using Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Service.UserService
{
    class PatientService
    {

        public PatientRepository patientRepository = new PatientRepository();

        public void registerPatient(Patient patient) {
            ObservableCollection<Patient> patients = patientRepository.GetAllUsers();

            if (patients == null) {
                patients = new ObservableCollection<Patient>();
            }
            patients.Add(patient);
            patientRepository.saveAllUsers(patients);
        }

        public ObservableCollection<Patient> getAllPatients() {
            return patientRepository.GetAllUsers();
        }

        public Patient PatientExist(string Jmbg)
        {
            foreach (Patient currentPatient in patientRepository.GetAllUsers())
            {
                if (currentPatient.Jmbg.Equals(Jmbg) && currentPatient.Jmbg.Equals(Jmbg))
                    return currentPatient;
            }

            return null; ;

        }

    }
}
