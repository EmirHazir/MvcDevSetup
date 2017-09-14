using PHS.Lib.Auth.Models;
using PSH.DAL.Repo;
using System;

namespace PSH.DAL.Auth
{
    public interface IUOWAuth : IUOWBase, IDisposable
    {
        IRepoGeneric<Account> Accounts { get; }
        IRepoGeneric<Client> Clients { get; }
        IRepoGeneric<RefreshToken> RefreshTokens { get; }
    }
}