using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CommunicationQuestions.Models
{
    public class Questionnaire
    {
        public int Id { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();

        public int ACount { get; set; } = 0;

        public int TCount { get; set; } = 0;

        public int CCount { get; set; } = 0;

        public int ECount { get; set; } = 0;

        public bool Completed { get; set; } = false;

        public TypeEnum? QuizAnswer { get; set; }

        public void SetUpQuiz()
        {
            if (!Questions.Any())
            {
                // 1. question
                Questions.Add(new Question("I tend to tell people what is on my mind.", "I tend to keep things to myself.", ATCEEnum.T, ATCEEnum.A));

                // 2. question
                Questions.Add(new Question("I see myself as cool and guarded with others.", "I see myself as warm and friendly with others.", ATCEEnum.C, ATCEEnum.E));

                // 3. question
                Questions.Add(new Question("I tend to show my emotions to others.", "I tend to keep my emotions inside.", ATCEEnum.E, ATCEEnum.C));

                // 4. question
                Questions.Add(new Question("I see myself as fast-paced.", "I see myself as slow-paced.", ATCEEnum.T, ATCEEnum.A));

                // 5. question
                Questions.Add(new Question("I see myself as a risk taker in most situations.", "I view myself as one who avoids or minimises risk in most situations.", ATCEEnum.T, ATCEEnum.A));

                // 6. question
                Questions.Add(new Question("I see myself as playful and fun-loving.", "I see myself as serious and thoughtful.", ATCEEnum.E, ATCEEnum.C));

                // 7. question
                Questions.Add(new Question("I tend to wait for others to initiate interactions with me.", "I tend to initiate interactions.", ATCEEnum.A, ATCEEnum.T));

                // 8. question
                Questions.Add(new Question("I tend to talk in terms of opinions.", "I tend to talk in terms of facts.", ATCEEnum.E, ATCEEnum.C));

                // 9. question
                Questions.Add(new Question("I tend to like to work with others.", "I tend to like to work alone.", ATCEEnum.E, ATCEEnum.C));

                // 10. question
                Questions.Add(new Question("I tend to take charge of a situation.", "I tend to remain in the background.", ATCEEnum.T, ATCEEnum.A));

                // 11. question
                Questions.Add(new Question("I see myself as open and direct.", "I see myself as quiet and moderate.", ATCEEnum.T, ATCEEnum.A));

                // 12. question
                Questions.Add(new Question("I tend to focus on the outcome or results.", "I tend to focus on the process or the method.", ATCEEnum.T, ATCEEnum.A));

                // 13. question
                Questions.Add(new Question("I tend to be more interested in how people feel.", "I tend to be more interested in what people think.", ATCEEnum.E, ATCEEnum.C));

                // 14. question
                Questions.Add(new Question("I tend to be casual and informal in my dealings with others.", "I tend to be businesslike and formal in my dealings with people.", ATCEEnum.E, ATCEEnum.C));

                // 15. question
                Questions.Add(new Question("I tend to avoid personal involvement with people.", "I tend to deal with people in a more personal way.", ATCEEnum.C, ATCEEnum.E));

                // 16. question
                Questions.Add(new Question("I tend to confront conflict head-on.", "I tend to avoid conflict and confrontation.", ATCEEnum.T, ATCEEnum.A));

                // 17. question
                Questions.Add(new Question("I tend to get inpatient with others.", "I see myself as patient with others.", ATCEEnum.T, ATCEEnum.A));

                // 18. question
                Questions.Add(new Question("I tend to have a lot of interaction with others.", "I tend to have limited interaction with others.", ATCEEnum.E, ATCEEnum.C));

                // 19. question
                Questions.Add(new Question("I tend to be more task orientated.", "I tend to be more relationship orientated.", ATCEEnum.C, ATCEEnum.E));

                // 20. question
                Questions.Add(new Question("I tend to be standoffish and aloof with others.", "I tend to be open and disclosing with others.", ATCEEnum.C, ATCEEnum.E));

                // 21. question
                Questions.Add(new Question("I see myself as more competitive with others.", "I see myself as more cooperative in dealing with others.", ATCEEnum.T, ATCEEnum.A));

                // 22. question
                Questions.Add(new Question("I see myself as more reserved in dealing with others.", "I see myself as more forceful with other people.", ATCEEnum.A, ATCEEnum.T));

                // 23. question
                Questions.Add(new Question("I tend to be indifferent to the feelings of others.", "I tend to get involved with the feelings of others.", ATCEEnum.C, ATCEEnum.E));

                // 24. question
                Questions.Add(new Question("I tend to make quick decisions.", "I tend to take longer in making decisions.", ATCEEnum.T, ATCEEnum.A));

                // 25. question
                Questions.Add(new Question("I see myself as easygoing and tolerant.", "I see myself as requiring of myself and others.", ATCEEnum.E, ATCEEnum.C));

                // 26. question
                Questions.Add(new Question("I tend to follow the lead of others.", "I tend to direct the actions of others.", ATCEEnum.A, ATCEEnum.T));

                // 27. question
                Questions.Add(new Question("I tend to be a cautious and measured communicator.", "I tend to be an impulsive and dramatic communicator.", ATCEEnum.C, ATCEEnum.E));

                // 28. question
                Questions.Add(new Question("I tend to keep my opinions and thoughts to myself.", "I tend to readily share my opinions and ideas.", ATCEEnum.A, ATCEEnum.T));

                // 29. question
                Questions.Add(new Question("I tend to want to do things my way when I work with others.", "I tend to be accepting when I work with other people.", ATCEEnum.T, ATCEEnum.A));

                // 30. question
                Questions.Add(new Question("I tend to share my personal feelings with others.", "I tend to keep my personal feelings to myself.", ATCEEnum.E, ATCEEnum.C));
            }
        }
    }
}
