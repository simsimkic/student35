using Model.Roles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Service.UserService;

namespace WpfApp1.Controller.UserController
{
    class PatientController
    {
        public PatientService patientService = new PatientService();

        public void registerPatient(Patient patient){
            if (patient == null) {
                return;
            }
            patientService.registerPatient(patient);
            
}
        public ObservableCollection<Patient> getAllPatients() {
            return patientService.getAllPatients();
        }

        public Patient PatientExist(string jmbg)
        {
            return patientService.PatientExist(jmbg);

        }
    }
}
