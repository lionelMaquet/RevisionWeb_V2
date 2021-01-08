using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RevisionWebV2.Data.Models
{
    public class Answer
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public bool IsRightAnswer { get; set; }
        public string Details { get; set; } // Details about why it's the wrong or right answer. Facultative.
    }
}
