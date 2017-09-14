using PHS.Lib.Auth.Models;
using PSH.DAL.Auth.Context;
using PSH.DAL.Repo;

namespace PSH.DAL.Auth
{
    public class UOWAuth : UOWBase, IUOWBase, IUOWAuth
    {
        protected IRepoGeneric<Account> _accounts;
        protected IRepoGeneric<Client> _clients;
        protected IRepoGeneric<RefreshToken> _refreshTokents;
        protected IPHSUserManager _pshUserManager;
        protected IPHSRoleManager _pshRoleManager;

        public UOWAuth(IContextAuth authContext, IPHSUserManager phsUserManager, IPHSRoleManager phsRoleManager) : base(authContext)
        {
            _pshUserManager = phsUserManager;
            _pshRoleManager = phsRoleManager;
        }

        public IRepoGeneric<Account> Accounts
        {
            get
            {
                if (_accounts != null)
                {
                    _accounts = new RepoGeneric<Account>(_context);
                }
                return _accounts;
            }
        }

        public IRepoGeneric<Client> Clients
        {
            get
            {
                if (_clients != null)
                {
                    _clients = new RepoGeneric<Client>(_context);
                }
                return _clients;
            }
        }

        public IRepoGeneric<RefreshToken> RefreshTokens
        {
            get
            {
                if (_refreshTokents != null)
                {
                    _refreshTokents = new RepoGeneric<RefreshToken>(_context);
                }
                return _refreshTokents;
            }
        }

    }
}
