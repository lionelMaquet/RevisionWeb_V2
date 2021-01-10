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
    public class PlayModel : PageModel
    {
        private ILogger<IndexModel> _logger;
        private ApplicationDbContext _db;
        private string qid;
        int SubjectIdOfCurrentAnswer;
        Question question;
        Subject subject;
        bool isOwnUserQuestion;

        public PlayModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this._db = db;
        }
        public void OnGet(string qid)
        {
            this.qid = qid;
            try
            {
                question = _db.Questions.Where(x => x.Id.ToString() == qid).Include(x => x.Answers).First();
            }
            catch
            {
                // No question with this id exists
            }

            subject = Helper.getSubjectFromQuestionId(_db, int.Parse(qid));
            SubjectIdOfCurrentAnswer = subject.Id;

            if (subject.OwnerUsername == User.Identity.Name)
            {
                isOwnUserQuestion = true;
            }

        }
    }
}
