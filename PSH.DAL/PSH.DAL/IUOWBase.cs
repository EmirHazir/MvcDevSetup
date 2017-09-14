using System;
using System.Threading.Tasks;

namespace PSH.DAL
{
    public interface IUOWBase : IDisposable
    {
        bool Save();
        Task<bool> SaveAsync();
    }
}