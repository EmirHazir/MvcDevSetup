using AutoMapper;
using PHS.Lib.Auth.Models;
using PHS.Lib.Auth.ViewModels;
using PSH.DAL.Auth;
using System.Threading.Tasks;

namespace PHS.Service.Auth
{
    public class ServiceAuth : ServiceBase
    {
        public ServiceAuth(IMapper mapper, IUOWAuth uow) : base(mapper, uow)
        {
        }

        protected override void InitializeAutoMapper()
        {
            _mapper = new MapperConfiguration(s =>
            {
                
            }).CreateMapper();
        }

        public virtual async Task<AccountViewModel> CreateAccountAsync(Account account)
        {
            (_uow as IUOWAuth).Accounts.Insert(account);
            if (await _uow.SaveAsync())
            {
                var viewModel = _mapper.Map<AccountViewModel>(account);
                return viewModel;
            }
            return null;
        }

        public virtual async Task GetAccountAsync()
        {

        }

        public virtual async Task UpdateAccountAsync()
        {

        }
    }
}
