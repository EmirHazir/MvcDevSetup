using PHS.Lib.ViewModels;
using System.Collections.Generic;

namespace PHS.Lib.Auth.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        //Bu UserId AspNetUser Tablosundaki id Identity ile geliştirilen
        public string UserId { get; set; }  
    }
}
