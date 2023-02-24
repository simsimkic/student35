using Model.Roles;
using Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_upravnik.Service.UserService
{
    public class ManagerService
    {




        public bool RegisterManager(Manager manager)
        {
            if (ManagerRepository.getInstance().managerExists(manager))
                return false;


            return ManagerRepository.getInstance().registerManager(manager);


        }


        public Manager getManager(string usernameOfManager)
        {
            return ManagerRepository.getInstance().getManagerByID(usernameOfManager);
        }


        public bool editManager(Manager currentManager)
        {

            return ManagerRepository.getInstance().editManager(currentManager);
        }

        public bool isUsernameAndPasswordValid(string username, string password)
        {

            ObservableCollection<Manager> Managers= ManagerRepository.getInstance().GetAllUsers();

            foreach (Manager currentManager in Managers)
            {
                if (currentManager.Username.ToString().Equals(username) && currentManager.Password.ToString().Equals(password))
                                 
                return true;
            }

            return false;

        }


    }
 }


    

