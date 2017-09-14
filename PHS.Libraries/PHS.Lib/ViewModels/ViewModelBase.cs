using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace PHS.Lib.ViewModels
{
    public abstract class ViewModelBase
    {
        [Key]
        [JsonProperty(PropertyName ="_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
