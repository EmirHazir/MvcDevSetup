using Newtonsoft.Json;
using PHS.Lib.Models;
using PHS.Lib.ViewModels;

namespace PHS.Lib.Auth.ViewModels
{
    public class AccessToken : ViewModelBase
    {
        [JsonProperty(PropertyName ="access_token")]
        public string Token { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName ="expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty(PropertyName ="refresh_token")]
        public string RedreshToken { get; set; }

        [JsonProperty(PropertyName ="as:client_id")]
        public string AsClientId { get; set; }

        [JsonProperty(PropertyName =".issued")]
        public string Issued { get; set; }

        [JsonProperty(PropertyName =".expires")]
        public string Expries { get; set; }
    }
}
