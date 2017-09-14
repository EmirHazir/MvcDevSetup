using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PHS.Lib.Models
{
    //Bu base model scaffol olmayacak propertylerini verdik
    public abstract class ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(false)]
        [JsonProperty(PropertyName ="_id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonProperty(PropertyName = "_time=Stamp")]
        [ScaffoldColumn(false)]
        public DateTime TimeStamp { get; set; } = DateTime.UtcNow;


    }
}
