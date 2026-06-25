using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Lock_Chat
{
    public class QuizManager
    {
        private List<QuizQuestion> questions;
        private int currentQuestionIndex;
        private int score;
        private int totalQuestions;
        public bool IsQuizActive { get; private set; }
        public QuizManager()
        {
            questions = new List<QuizQuestion>();
            currentQuestionIndex = 0;
            score = 0;
            IsQuizActive = false;
            InitializeQuestions();
            totalQuestions = questions.Count;
        }
        private void InitializeQuestions()
        {
            questions.Add(new QuizQuestion(1, "What should you do if you receive an email asking for your password?", new List<string> { "Reply with your password", "Delete the email", "Report it as phishing" }, 2, "Never share passwords via email. Always report suspicious emails as phishing.", "Phishing"));
            questions.Add(new QuizQuestion(2, "Which is a strong password?", new List<string> { "password123", "MyP@ssw0rd!", "admin" }, 1, "Strong passwords contain uppercase, lowercase, numbers, and special characters.", "Password Safety"));
            questions.Add(new QuizQuestion(3, "What does 2FA stand for?", new List<string> { "Two-Factor Authentication", "Two-File Access", "Two-Frequency Algorithm" }, 0, "2FA adds an extra layer of security by requiring two verification methods.", "Authentication"));
            questions.Add(new QuizQuestion(4, "True or False: It's safe to click links in emails from unknown senders.", new List<string> { "True", "False" }, 1, "Never click links from unknown senders. They could lead to malicious websites.", "Safe Browsing"));
            questions.Add(new QuizQuestion(5, "What is social engineering?", new List<string> { "Building social media profiles", "Manipulating people to reveal confidential information", "Engineering social networks" }, 1, "Social engineering tricks people into divulging sensitive data.", "Social Engineering"));
            questions.Add(new QuizQuestion(6, "Which of these is a secure browsing practice?", new List<string> { "Use public WiFi for banking", "Check for HTTPS and a padlock icon", "Share passwords with friends" }, 1, "Always look for HTTPS and the padlock icon before entering sensitive data.", "Safe Browsing"));
            questions.Add(new QuizQuestion(7, "True or False: You should use the same password for all accounts.", new List<string> { "True", "False" }, 1, "Using unique passwords for each account prevents widespread compromise if one is breached.", "Password Safety"));
            questions.Add(new QuizQuestion(8, "What is a phishing attack?", new List<string> { "A type of fishing sport", "Fraudulent attempt to obtain sensitive information by disguising as trusted entity", "A network security protocol" }, 1, "Phishing uses deceptive emails or websites to steal credentials.", "Phishing"));
            questions.Add(new QuizQuestion(9, "True or False: It's okay to share your login credentials with your manager.", new List<string> { "True", "False" }, 1, "Never share login credentials. Use proper authorization systems instead.", "Password Safety"));
            questions.Add(new QuizQuestion(10, "What should you do if you suspect your account has been hacked?", new List<string> { "Ignore it", "Change your password immediately and contact support", "Tell your friends" }, 1, "Act quickly by changing your password and notifying the service provider.", "Account Security"));
            questions.Add(new QuizQuestion(11, "True or False: Antivirus software makes you completely immune to all cyber threats.", new List<string> { "True", "False" }, 1, "Antivirus helps but isn't 100% foolproof. Use it with other security practices.", "Malware Protection"));
            questions.Add(new QuizQuestion(12, "What does VPN stand for?", new List<string> { "Virtual Private Network", "Very Private Navigation", "Vital Personal Network" }, 0, "A VPN encrypts your internet connection and masks your IP address.", "Safe Browsing"));
        }
        public void StartQuiz()
        {
            IsQuizActive = true;
            currentQuestionIndex = 0;
            score = 0;
        }
        public QuizQuestion? GetCurrentQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                return questions[currentQuestionIndex];
            }
            return null;
        }
        public string CheckAnswer(int answerIndex)
        {
            if (currentQuestionIndex >= questions.Count)
                return "Quiz ended.";
            QuizQuestion currentQuestion = questions[currentQuestionIndex];
            string result = "";
            if (answerIndex == currentQuestion.CorrectAnswerIndex)
            {
                score++;
                result = "✓ Correct! ";
            }
            else
            {
                result = "✗ Incorrect. ";
            }
            result += $"Explanation: {currentQuestion.Explanation}";
            currentQuestionIndex++;
            return result;
        }
        public bool HasNextQuestion()
        {
            return currentQuestionIndex < questions.Count;
        }
        public string EndQuiz()
        {
            IsQuizActive = false;
            string feedback = "";
            int percentage = (score * 100) / totalQuestions;
            feedback += $"\n╔══════════════════════════════════════╗\n";
            feedback += $"║  QUIZ COMPLETE!                      ║\n";
            feedback += $"╚══════════════════════════════════════╝\n";
            feedback += $"Your Score: {score}/{totalQuestions} ({percentage}%)\n\n";
            if (percentage >= 90)
                feedback += "🏆 Excellent! You're a cybersecurity pro!";
            else if (percentage >= 70)
                feedback += "✓ Great job! You know your cybersecurity!";
            else if (percentage >= 50)
                feedback += "Good effort! Keep learning to stay safe online.";
            else
                feedback += "Keep studying cybersecurity concepts. You'll improve!";
            return feedback;
        }
        public int GetCurrentScore()
        {
            return score;
        }
        public int GetTotalQuestions()
        {
            return totalQuestions;
        }
        public int GetCurrentQuestionNumber()
        {
            return currentQuestionIndex + 1;
        }
    }
}
