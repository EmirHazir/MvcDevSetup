using AutoMapper;
using PSH.DAL;
using System;

namespace PHS.Service
{
    public abstract class ServiceBase : IServiceBase, IDisposable
    {
        protected IMapper _mapper;
        protected IUOWBase _uow;

        public ServiceBase(IMapper mapper, IUOWBase uow)
        {
            _mapper = mapper;
            _uow = uow;
        }

        protected abstract void InitializeAutoMapper();

        public virtual void Dispose()
        {
            _uow.Dispose();
        }
    }
}
