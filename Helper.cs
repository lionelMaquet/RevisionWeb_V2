
using Microsoft.EntityFrameworkCore;
using RevisionWebV2.Data;
using RevisionWebV2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisionWeb
{
    static public class Helper
    {
        // NOT TESTED

        static public Subject getSubjecFromQuestionId(ApplicationDbContext db, int questionId)
        {
            Subject sub = db.Subjects.First(x => x.Questions.Count(x => x.Id == questionId) > 0);
            return sub;
        }
        static public int getSubjectIdFromQuestionId(ApplicationDbContext db,int questionId)
        {
            int sid = db.Subjects.First(x => x.Questions.Count(x => x.Id == questionId) > 0).Id;
            return sid;
        }
        /*
        static public int getUserIdFromSubjectId(ApplicationDbContext db, int subjectId)
        {
            int uid = db.Users.First(x => x.Subjects.Count(x => x.Id == subjectId) > 0).Id;
            return uid;
        }
        */
        /*
        static public int getUserIdFromQuestionId(ApplicationDbContext db, int questionId)
        {
            int sid = getSubjectIdFromQuestionId(db, questionId);
            int uid = getUserIdFromSubjectId(db, sid);
            return uid;
        }
        */

        static public void FlushDb(ApplicationDbContext db)
        {
            
            db.Subjects.RemoveRange(db.Subjects);
            db.Questions.RemoveRange(db.Questions);
            db.Answers.RemoveRange(db.Answers);
            db.SaveChanges();
        }



    }
}
