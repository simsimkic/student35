/***********************************************************************
 * Module:  GuestAccountService.cs
 * Purpose: Definition of the Class Service.SecretaryService.GuestAccountService
 ***********************************************************************/

using Repository.UserRepository;
using System;

namespace Service.UserService
{
   public class GuestAccountService
   {
      public void CreateGuestAccount(Model.Roles.GuestAccount guest)
      {
            GuestAccountRepository.getInstance().AddGuest(guest);

      }
      
      public Model.Roles.Patient FromGuestToUser(Model.Roles.GuestAccount gAcc)
      {
         throw new NotImplementedException();
      }
      
      public Repository.UserRepository.GuestAccountRepository guestAccount;
   
   }
}