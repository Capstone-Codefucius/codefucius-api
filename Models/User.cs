using codefucius_api.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace codefucius_api.Models
{
    public class User : IEntity
    {
        [Key]
        public Guid ID { get; set; }

        public string name { get; set; }
        public string role { get; set; }
    }
}
