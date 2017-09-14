using PHS.Lib.Models;
using System.ComponentModel.DataAnnotations;

namespace PHS.Lib.Auth.Models
{
    public class Client : ModelBase
    {
        /// <summary>
        /// Client için açık Id
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Sadece developerin bildiği Id
        /// </summary>
        
        public string ClientSecret { get; set; }

        //Clientin adi
        [MaxLength(150)]
        public string ClientName { get; set; }

        [MaxLength(200)]
        public string ClientDescription { get; set; }

        //Client saniyeleri
        public int RefreshTokenLifespan { get; set; }

        //eğer client https ya da normal bir linkten gelmiyorsa bunun Authorization olayını handle edebilmek için property
        [MaxLength(200)]
        public string AllowedOrigin { get; set; }


        //Bir Clientın  bir Accountu olmalı  one to one
        public virtual Account Account { get; set; }
    }
}
