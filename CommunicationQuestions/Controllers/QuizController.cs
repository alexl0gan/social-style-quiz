using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunicationQuestions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CommunicationQuestions.Controllers
{
    public class QuizController : Controller
    {
        private AppDbContext _db;

        public QuizController(AppDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public IActionResult Reset()
        {
            var quiz = new Questionnaire();
            quiz.SetUpQuiz();
            HttpContext.Session.Set<Questionnaire>("quiz", quiz);
            return RedirectToPage("/Index");
        }

        [HttpPost]
        public IActionResult Submit()
        {
            var quiz = HttpContext.Session.Get<Questionnaire>("quiz");
            var form = Request?.Form?.ToList();
            if (form.Any())
            {
                for (int i = 0; i < form.Count(); i++)
                {
                    if (form[i].Key != "_RequestValidationToken")
                    {
                        if (Enum.TryParse(typeof(ABEnum), form[i].Value.FirstOrDefault(), out object result))
                        {
                            quiz.Questions[i].Selection = (ABEnum)result;
                        }
                    }
                }

                quiz.Completed = true;

                quiz.ACount = quiz.Questions.Select(q => q.Result).Count(r => r == ATCEEnum.A);
                quiz.CCount = quiz.Questions.Select(q => q.Result).Count(r => r == ATCEEnum.C);
                quiz.ECount = quiz.Questions.Select(q => q.Result).Count(r => r == ATCEEnum.E);
                quiz.TCount = quiz.Questions.Select(q => q.Result).Count(r => r == ATCEEnum.T);

                if (quiz.ACount >= quiz.TCount && quiz.CCount >= quiz.ECount)
                {
                    quiz.QuizAnswer = TypeEnum.Analytical;
                }
                else if (quiz.TCount >= quiz.ACount && quiz.CCount >= quiz.ECount)
                {
                    quiz.QuizAnswer = TypeEnum.Driving;
                }
                else if (quiz.TCount >= quiz.ACount && quiz.ECount >= quiz.CCount)
                {
                    quiz.QuizAnswer = TypeEnum.Expressive;
                }
                else if (quiz.ACount >= quiz.TCount && quiz.ECount >= quiz.CCount)
                {
                    quiz.QuizAnswer = TypeEnum.Amiable;
                }

                HttpContext.Session.Set<Questionnaire>("quiz", quiz);
            }

            return RedirectToPage("/Index");
        }
    }
}
