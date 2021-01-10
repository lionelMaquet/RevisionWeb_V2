using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RevisionWeb;
using RevisionWebV2.Data;
using RevisionWebV2.Data.Models;

namespace RevisionWebV2.Pages
{
    public class AnswersModel : PageModel
    {
        private ILogger<IndexModel> _logger;
        private ApplicationDbContext _db;

        public Question question;
        public Subject subject;

        public string qid;
        public int SubjectIdOfCurrentAnswer;
        public int score;
        public int nextId;
        public int previousId;

        public bool isOwnUserQuestion = false;
        public bool shouldShowForm = true;

        public AnswersModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this._db = db;
        }
        public void OnGet(string qid)
        {
            this.qid = qid;
            subject = Helper.getSubjectFromQuestionId(_db, int.Parse(qid));

            try { question = _db.Questions.Where(x => x.Id.ToString() == qid).Include(x => x.Answers).First(); } 
            catch { /* No question with this id exists */ }

            isOwnUserQuestion = subject.OwnerUsername == User.Identity.Name;

            List<int> qids = new List<int>();
            subject.Questions.ForEach(x => qids.Add(x.Id));

            int currentId = qids.FindIndex(x => x == int.Parse(qid));
            previousId = currentId == 0 ? qids[qids.Count - 1] : qids[(currentId - 1)];
            nextId = qids[(currentId + 1) % qids.Count];
        }

        public IActionResult OnPost(string qid, string title, string details)
        {
            bool ra = Request.Form["isRightAnswer"] == "on";

            _db.Questions.Where(x => x.Id.ToString() == qid).Include(s => s.Answers).First().Answers.Add(new Answer()
            {
                Title = title,
                Details = details,
                IsRightAnswer = ra
            });
            _db.SaveChanges();

            return Redirect("/answers?qid=" + qid);
        }
    }
}
