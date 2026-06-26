using System;
using System.Collections.Generic;
namespace Secure_Lock_Chat
{
    public class NLPHelper//this provids NPL to detect what the user wants to do.
    {
        private List<string> taskKeywords = new List<string> { "task", "todo", "add", "create", "set", "reminder", "remind" };
        private List<string> quizKeywords = new List<string> { "quiz", "trivia", "test", "question", "exam", "challenge" };
        private List<string> activityKeywords = new List<string> { "activity", "log", "history", "what have you done", "show me", "recent", "actions" };
        private List<string> completeKeywords = new List<string> { "complete", "done", "finish", "mark complete", "finished" };
        private List<string> deleteKeywords = new List<string> { "delete", "remove", "remove task", "clear" };
        private List<string> showKeywords = new List<string> { "show", "display", "list", "view", "see" };
        public string DetectIntent(string userInput)//detects the user's intent by looking for keywords in their answer.
        {
            string input = userInput.ToLower();
            if (ContainsKeywords(input, taskKeywords) && ContainsKeywords(input, new List<string> { "task", "reminder", "add", "create", "set" }))
                return "TASK";
            if (ContainsKeywords(input, quizKeywords))//this checks for keyword and if it matches.
                return "QUIZ";
            if (ContainsKeywords(input, activityKeywords))
                return "ACTIVITY_LOG";
            if (ContainsKeywords(input, completeKeywords) && ContainsKeywords(input, taskKeywords))
                return "COMPLETE_TASK";
            if (ContainsKeywords(input, deleteKeywords) && ContainsKeywords(input, taskKeywords))
                return "DELETE_TASK";
            if (ContainsKeywords(input, showKeywords) && ContainsKeywords(input, taskKeywords))
                return "SHOW_TASKS";
            return "GENERAL_CHAT";
        }
        public string ExtractTaskTitle(string userInput)//this extracts task titlr from user.
        {
            string input = userInput.ToLower();
            string[] taskIndicators = { "add task", "create task", "new task", "task:", "task -" };
            foreach (var indicator in taskIndicators) //finds a task indicator and extracts a text after it.
            {
                if (input.Contains(indicator))
                {
                    int index = input.IndexOf(indicator) + indicator.Length;
                    string title = userInput.Substring(index).Trim();
                    if (title.Length > 3)
                        return title;
                }
            }
            return userInput;
        }
        public string ExtractReminderDays(string userInput)//this method is used to get the reminder duration from the user
        {
            string input = userInput.ToLower();
            if (input.Contains("tomorrow"))
                return "1";
            if (input.Contains("day") || input.Contains("1 day"))
                return "1";
            if (input.Contains("week"))
                return "7";
            if (input.Contains("2 week"))
                return "14";
            if (input.Contains("month"))
                return "30";
            return "0";
        }
        public bool IsTaskRequest(string userInput)
        {
            return DetectIntent(userInput) == "TASK";
        }
        public bool IsQuizRequest(string userInput)
        {
            return DetectIntent(userInput) == "QUIZ";
        }
        public bool IsActivityLogRequest(string userInput)
        {
            return DetectIntent(userInput) == "ACTIVITY_LOG";
        }
        public bool IsCompleteTaskRequest(string userInput)
        {
            return DetectIntent(userInput) == "COMPLETE_TASK";
        }
        public bool IsDeleteTaskRequest(string userInput)
        {
            return DetectIntent(userInput) == "DELETE_TASK";
        }
        public bool IsShowTasksRequest(string userInput)
        {
            return DetectIntent(userInput) == "SHOW_TASKS";
        }
        private bool ContainsKeywords(string input, List<string> keywords)
        {
            foreach (var keyword in keywords)
            {
                if (input.Contains(keyword))
                    return true;
            }
            return false;
        }
        public string ImproveResponse(string userInput, string intent)
        {
            string input = userInput.ToLower();
            if (intent == "TASK")
            {
                if (input.Contains("password"))
                    return "I see this is about password security. Let's add this as a task!";
                if (input.Contains("2fa") || input.Contains("two-factor"))
                    return "Two-factor authentication is crucial! Let's create this task.";
                if (input.Contains("privacy"))
                    return "Privacy is important. Adding this to your task list.";
            }
            if (intent == "QUIZ")
                return "Great! Let's test your cybersecurity knowledge!";
            if (intent == "ACTIVITY_LOG")
                return "Let me show you what we've accomplished together.";
            return "";
        }
    }//end of nlp class
}//end of namespace 