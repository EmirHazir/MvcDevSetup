using PHS.Lib.Auth.Models;
using PSH.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSH.DAL.Auth.Context
{
     public class ContextAuth : ContextBase, IContextBase, IContextAuth
    {
        public ContextAuth() : base()
        { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Accounts", "Auth");
            modelBuilder.Entity<Client>().ToTable("Clients", "Auth");
            modelBuilder.Entity<RefreshToken>().ToTable("RefreshTokens", "Auth");

            base.OnModelCreating(modelBuilder);
        }
    }
}
