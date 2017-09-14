using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PSH.DAL.Auth.Context
{
    //user rolleri
    public class PHSRoleManager : RoleManager<IdentityRole>, IPHSRoleManager
    {
        public PHSRoleManager(IRoleStore<IdentityRole, string> store) : base(store)
        {
        }
    }
}
