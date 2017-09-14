
using PHS.Lib.Models;
using PSH.DAL.Contexts;
using PSH.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSH.DAL
{
    public abstract class UOWBase : IDisposable, IUOWBase
    {
        protected IContextBase _context;
        private bool _disposed = false;
        public UOWBase(IContextBase context )
        {
            _context = context;
        }

        public virtual bool Save()
        {
            if (_context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public async virtual Task<bool> SaveAsync()
        {
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
