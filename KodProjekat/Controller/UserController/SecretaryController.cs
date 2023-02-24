using Model.Roles;
using Projekat_upravnik.Service.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_upravnik.Controller.UserController
{
   public class SecretaryController
    {

        public void RegisterSecretary(Secretary secretary)
        {
            SecretaryService servisSekretar = new SecretaryService();
            servisSekretar.RegisterSecretary(secretary);
        }


        public void ChangeSecretary(Secretary secretary)
        {
            SecretaryService servisSekretar = new SecretaryService();
            servisSekretar.ChangeSecretary(secretary);

        }

    }
}
