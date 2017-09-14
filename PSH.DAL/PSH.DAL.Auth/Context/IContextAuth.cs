using System.Data.Entity;
using PHS.Lib.Auth.Models;
using PSH.DAL.Contexts;

namespace PSH.DAL.Auth.Context
{
    public interface IContextAuth : IContextBase
    {
        DbSet<Account> Accounts { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}