using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RevisionWebV2.Data;

namespace RevisionWebV2.Pages
{
    public class UsersModel : PageModel
    {
        private readonly ILogger<SubjectsModel> _logger;
        private readonly ApplicationDbContext _db;
        public List<IdentityUser> users = new List<IdentityUser>();
        public UsersModel(ILogger<SubjectsModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this._db = db;
        }
        public void OnGet()
        {
            foreach (IdentityUser u in _db.Users)
            {
                users.Add(u);
            }
        }
    }
}
