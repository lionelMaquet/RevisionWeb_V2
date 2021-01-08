using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RevisionWebV2.Data.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
