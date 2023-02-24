using Model.Roles;
using Projekat_upravnik.Service.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_upravnik.Controller.UserController
{
   public class ManagerController
    {

        public bool RegisterManager(Manager manager)
        {
            ManagerService managerService = new ManagerService();
           return managerService.RegisterManager(manager);
        }

        public Manager getManager(string usernameOfManager)
        {
            ManagerService managerService = new ManagerService();
            return managerService.getManager(usernameOfManager);
        }

        public bool editManager(Manager currentManager)
        {
            ManagerService managerService = new ManagerService();
            return managerService.editManager(currentManager);
        }

        public bool isUsernameAndPasswordValid(string username, string password)
        {
            ManagerService managerService = new ManagerService();
            return managerService.isUsernameAndPasswordValid(username, password);
        }
    }
}
