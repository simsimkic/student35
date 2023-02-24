/***********************************************************************
 * Module:  GuestAccountService.cs
 * Purpose: Definition of the Class Service.SecretaryService.GuestAccountService
 ***********************************************************************/

using Service.UserService;
using System;

namespace Controller.UserController
{
   public class GuestAccountController
   {
      public void CreateGuestAccount(Model.Roles.GuestAccount guest)
      {
            guestAccountService.CreateGuestAccount(guest);
      }
      
      public Model.Roles.Patient FromGuestToUser(Model.Roles.GuestAccount gAcc)
      {
         throw new NotImplementedException();
      }
      
      public GuestAccountService guestAccountService=new GuestAccountService();
   
   }
}