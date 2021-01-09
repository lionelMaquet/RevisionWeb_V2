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
        public string qid;
        public Question question;
        public Subject subject;
        public bool isOwnUserQuestion = false;
        public int SubjectIdOfCurrentAnswer;

        public AnswersModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this._db = db;
        }
        public void OnGet(string qid)
        {
            this.qid = qid;
            SubjectIdOfCurrentAnswer = Helper.getSubjectIdFromQuestionId(_db, int.Parse(qid));
            try
            {
                question = _db.Questions.Where(x => x.Id.ToString() == qid).Include(x => x.Answers).First();
            } catch
            {
                // No question with this id exists
            }

            subject = Helper.getSubjectFromQuestionId(_db,int.Parse(qid));
            if (subject.OwnerUsername == User.Identity.Name)
            {
                isOwnUserQuestion = true;
            }

        }

        public IActionResult OnPost(string qid, string title, string details)
        {
            bool ra = false;
            if (Request.Form["isRightAnswer"] == "on")
            {
                ra = true;
            }

            

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
