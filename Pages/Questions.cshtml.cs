using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RevisionWebV2.Data;
using RevisionWebV2.Data.Models;

namespace RevisionWebV2.Pages
{
    public class QuestionsModel : PageModel
    {
        private ILogger<IndexModel> _logger;
        private ApplicationDbContext _db;
        public bool isOwnUserSubject = false;
        public Subject sub;
        public string sid;

        public QuestionsModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this._db = db;
        }

        public void OnGet(string sid)
        {
            this.sid = sid;
            sub = _db.Subjects.Where(x => x.Id.ToString() == sid).Include(x => x.Questions).First();

            if (sub.OwnerUsername == User.Identity.Name)
            {
                isOwnUserSubject = true;
            }

        }

        public IActionResult OnPost(string sid, string title)
        {

            Question newQuestion = new Question()
            {
                Title = title,
                Answers = new List<Answer>()
            };

            _db.Subjects.Where(x => x.Id.ToString() == sid).Include(s => s.Questions).First().Questions.Add(newQuestion);
            _db.SaveChanges();

            return Redirect($"/answers?qid={newQuestion.Id}");
        }
    }
}
