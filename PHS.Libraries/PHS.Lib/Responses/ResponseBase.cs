using Newtonsoft.Json;
using System;
using System.Net;

namespace PHS.Lib.Responses
{
    public abstract class ResponseBase
    {
        [JsonProperty(PropertyName ="_id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        public int ResponseCode { get; set; }

        public string ResponseCodeValur { get; set; }

        public string Message { get; set; }

        [JsonProperty("_timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
