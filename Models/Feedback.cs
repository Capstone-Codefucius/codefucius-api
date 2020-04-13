using System;
using System.ComponentModel.DataAnnotations;
using codefucius_api.Data;

namespace codefucius_api.Models
{
    public class Feedback : IEntity
    {
        [Key]
        public Guid ID { get; set; }

        public Guid ReviewID { get; set; }

        public Guid ReviewerName { get; set; }

        public DateTime ReviewDate { get; set; }

        public string LearnedSomething { get; set; }

        public string CouldAskQuestions { get; set; }

        public string QuestionsWereAnswered { get; set; }
    }
}
