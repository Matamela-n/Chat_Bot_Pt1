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
        public int QuestionID { get; set; }
        public string? QuestionText { get; set; }
        public List<string>? Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public string? Explanation { get; set; }
        public string? Category { get; set; }
        public QuizQuestion() { }
        public QuizQuestion(int id, string questionText, List<string> options, int correctIndex, string explanation, string category)
        {
            QuestionID = id;
            QuestionText = questionText;
            Options = options;
            CorrectAnswerIndex = correctIndex;
            Explanation = explanation;
            Category = category;
        }
    }
}

