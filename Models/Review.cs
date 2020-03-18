using System;
using System.ComponentModel.DataAnnotations;

namespace codefucius_api.Models
{
    public class Review
    {
        [Key]
        public Guid ID { get; set; }

        public Guid AuthorID { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime Created { get; set; }
        
        public DateTime Deadline { get; set; }
        
    }
}
