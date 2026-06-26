using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Lock_Chat
{
    public class QuizQuestion
    {
        public int QuestionID { get; set; }//this is the actual question.
        public string? QuestionText { get; set; }//shows users a set of 3 chooices to choose from.
        public List<string>? Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public string? Explanation { get; set; }//this explains why the answer is correct.
        public string? Category { get; set; }//shows the topics
        public QuizQuestion() { }//creates an empty quiz question.
        public QuizQuestion(int id, string questionText, List<string> options, int correctIndex, string explanation, string category)//create a constructor which will create a question with the following details.
        {
            QuestionID = id;
            QuestionText = questionText;
            Options = options;
            CorrectAnswerIndex = correctIndex;
            Explanation = explanation;
            Category = category;
        }
    }//end of quiz class.
}//end of namespace

