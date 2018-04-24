using System;
namespace CommunicationQuestions.Models
{
    public class Question
    {
        public Question(string aQuestionString, string bQuestionString, ATCEEnum aResult, ATCEEnum bResult)
        {
            AQuestionString = aQuestionString;
            BQuestionString = bQuestionString;
            AResult = aResult;
            BResult = bResult;
        }

        public string AQuestionString { get; set; }

        public string BQuestionString { get; set; }

        public ATCEEnum AResult { get; set; }

        public ATCEEnum BResult { get; set; }

        public ABEnum? Selection { get; set; }

        public ATCEEnum Result { get => Selection == ABEnum.A ? AResult : BResult; }
    }
}
