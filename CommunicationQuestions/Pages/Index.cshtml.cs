using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunicationQuestions.Controllers;
using CommunicationQuestions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CommunicationQuestions.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Questionnaire Quiz { get; set; }

        public void OnGetAsync()
        {
            Quiz = HttpContext.Session.Get<Questionnaire>("quiz") ?? new Questionnaire();
            Quiz.SetUpQuiz();
            HttpContext.Session.Set<Questionnaire>("quiz", Quiz);

        }
    }
}
