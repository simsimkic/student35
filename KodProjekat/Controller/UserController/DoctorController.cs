using Model.Roles;
using Projekat_upravnik.Service.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_upravnik.Controller.UserController
{
    public class DoctorController
    {
        public void RegisterDoctor(Doctor doctor)
        {
            DoctorService servisDoktor = new DoctorService();
            servisDoktor.RegisterDoctor(doctor);
        }


    }
}
