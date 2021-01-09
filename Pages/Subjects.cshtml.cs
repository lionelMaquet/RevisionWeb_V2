using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RevisionWebV2.Data;
using RevisionWebV2.Data.Models;

namespace RevisionWebV2.Pages
{
    public class SubjectsModel : PageModel
    {
        private readonly ILogger<SubjectsModel> _logger;
        private readonly ApplicationDbContext _db;
        public List<Subject> subjects = new List<Subject>();
        public bool isOwnSubjectOwner;

        public SubjectsModel(ILogger<SubjectsModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this._db = db;

        }

        public void OnGet(string username)
        {
            
            subjects = _db.Subjects.Where(x => x.OwnerUsername == username).ToList();
            if (username == User.Identity.Name)
            {
                isOwnSubjectOwner = true;
            }
        }

        public IActionResult OnPost(string title)
        {

            Subject newSubject = new Subject()
            {
                OwnerUsername = User.Identity.Name,
                Title = title,
                Questions = new List<Question>()
            };

            _db.Subjects.Add(newSubject);
            _db.SaveChanges();


            return Redirect($"/questions?sid={newSubject.Id}"); // Goes to new subject after insert
        }
    }
}
