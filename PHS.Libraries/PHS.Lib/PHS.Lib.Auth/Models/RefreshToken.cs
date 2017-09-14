
using PHS.Lib.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace PHS.Lib.Auth.Models
{
    public class RefreshToken : ModelBase
    {
        public string HashedId { get; set; }

        [MaxLength(50)]
        public string Subject { get; set; }

        public string ClientId { get; set; }

        public DateTime IssuedUTC { get; set; }

        public DateTime ExpiresUTC { get; set; }

        public string ProtectedTicket { get; set; }
    }
}
