using System;
using System.Collections.Generic;

namespace QuizzApp.Web.Models
{
    public class QuizzQuestion
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }

        public List<QuizzAnswer> Answers { get; set; }
    }
}
