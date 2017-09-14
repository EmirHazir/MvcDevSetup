using PHS.Lib.Models;
using System.Collections.Generic;

namespace PHS.Lib.Auth.Models
{
    public class Account : ModelBase
    {
        //Bu UserId AspNetUser Tablosundaki id Identity ile geliştirilen
        public string UserId { get; set; }

        //Diğer clientlerin numaralarını listeler
        public virtual ICollection<Client> Clients { get; set; } = new List<Client>();


    }
}
