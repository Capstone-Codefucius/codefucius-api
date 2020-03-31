using System;
using System.ComponentModel.DataAnnotations;

namespace codefucius_api.Models
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }

        public string name { get; set; }
    }
}
