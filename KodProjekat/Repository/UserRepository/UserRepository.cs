// File:    UserRepository.cs
// Created: Wednesday, June 10, 2020 8:46:34 PM
// Purpose: Definition of Interface UserRepository

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Repository.UserRepository
{
   public interface UserRepository<T>
   {
      void saveAllUsers(ObservableCollection<T> users);

        //  T GetRegisteredUser(String username);

        // void SetRegisteredUser(Model.Roles.User registeredUser);

        // Boolean NewRegisteredUser(Model.Roles.User newUser);

        ObservableCollection<T> GetAllUsers();
   
   }
}