using PHS.Lib.Auth.Models;
using PSH.DAL.Auth.Context;
using PSH.DAL.Repo;

namespace PSH.DAL.Auth.Repos
{
    public class RepoAccounts : RepoGeneric<Account>
    {
        public RepoAccounts(IContextAuth context) : base(context)
        {
        }

        public override void Insert(Account entity)
        {

            base.Insert(entity);
        }
    }
}
