using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace PSH.DAL.Auth.Context
{
    //Identity ile oynamaca
    public class PHSUserManager : UserManager<IdentityUser>, IPHSUserManager, IDisposable
    {
        public PHSUserManager(IUserStore<IdentityUser> store) : base(store)
        {
            UserValidator = new UserValidator<IdentityUser>(this)
            {
                AllowOnlyAlphanumericUserNames = true,
                RequireUniqueEmail = false
            };
        }
    }
}
