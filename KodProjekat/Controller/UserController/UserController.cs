/***********************************************************************
 * Module:  UserService.cs
 * Purpose: Definition of the Class Service.UserService.UserService
 ***********************************************************************/

using System;

namespace Controller.UserController
{
   public class UserController
   {
      public Model.Roles.User RegisterUser(Model.Roles.User user)
      {
         throw new NotImplementedException();
      }
      
      public Boolean IsUsernameValid(String username)
      {
         throw new NotImplementedException();
      }
      
      public Boolean IsPasswordValid(String password)
      {
         throw new NotImplementedException();
      }
      
      public void SignIn(String username, String password)
      {
         throw new NotImplementedException();
      }
      
      public Model.Roles.User ChangeUserData(Model.Roles.User user)
      {
         throw new NotImplementedException();
      }
      
      public Model.Roles.User GetRegisterdUser()
      {
         throw new NotImplementedException();
      }
      
      public Service.UserService.UserService userService;
   
   }
}