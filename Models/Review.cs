using System;
using System.ComponentModel.DataAnnotations;
using codefucius_api.Data;

namespace codefucius_api.Models
{
    public class Review : IEntity
    {
        [Key]
        public Guid ID { get; set; }

        public string AuthorName { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime Created { get; set; }
        
        public DateTime Deadline { get; set; }
        
    }
}
