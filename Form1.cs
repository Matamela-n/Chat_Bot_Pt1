using Chat_Bot_Pt1;
using ChatBotGUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Secure_Lock_Chat
{
    public partial class Form1 : Form
    {
        //these are object declarations for the text greeting, voice greeting and voice greeting.
        private ChatBot bot;

        private TextGreeting greeting = new TextGreeting();

        VoiceGreeting voice = new VoiceGreeting();

        bool nameSaved = false; //this will check if a user has entered a name.

        // PART 3: Task Management
        private Database? dbConnection;
        private TaskManager taskManager;
        private bool awaitingTaskTitle = false;
        private bool awaitingTaskDescription = false;
        private bool awaitingReminderDays = false;
        private string pendingTaskTitle = "";
        private string pendingTaskDescription = "";

        // PART 4: Quiz & Activity Log
        private QuizManager quizManager;
        private ActivityLog activityLog;
        private bool isQuizActive = false;

        // TASK 3: NLP Helper
        private NLPHelper nlpHelper;

        public Form1()
        {
            InitializeComponent();
          

            bot = new ChatBot();//this will create a new instance of the chatbot.
            greeting = new TextGreeting(); //creates a new instance of the text greeting

            rtbChat.SelectionAlignment = HorizontalAlignment.Left; //when tha app starts the app will display the welcome message with the following colours.
            rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
            rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
            rtbChat.AppendText(greeting.WelcomeMessage() + "");

            rtbChat.Font = new Font("Consolas", 11F, FontStyle.Regular); //this sets fonts and sizes for all the controls.
            txtMessage.Font = new Font("Consolas", 10F, FontStyle.Regular);
            btnSend.Font = new Font("Consolas", 9F, FontStyle.Bold);
            btnVoice.Font = new Font("Consolas", 9F, FontStyle.Bold);
            btnClear.Font = new Font("Consolas", 9F, FontStyle.Bold);
            btnExit.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblTitle.Font = new Font("Consolas", 36F, FontStyle.Bold);

           
            


            // PART 3: Initialize Database & Task Manager
            try
            {
                dbConnection = new Database("Matamela22.");
                if (dbConnection.TestConnection())
                {
                    taskManager = new TaskManager(dbConnection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }

            // PART 4: Initialize Quiz & Activity Log
            quizManager = new QuizManager();
            activityLog = new ActivityLog();
            activityLog.AddEntry("System", "Chatbot started");

            // TASK 3: Initialize NLP Helper
            nlpHelper = new NLPHelper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//this will close the application successfully when the user presses the 'exit' button.
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                return;
            }

            // USER MESSAGE
            rtbChat.SelectionAlignment = HorizontalAlignment.Right;
            rtbChat.SelectionBackColor = Color.FromArgb(13, 13, 26);
            rtbChat.SelectionColor = Color.FromArgb(245, 243, 255);

            rtbChat.AppendText(" " + input + " \n\n");

            // FIRST INPUT = USER NAME
            if (!nameSaved)
            {
                greeting.SaveName(input); //this saves the name entered by the user in the greeting.

                bot.SaveName(greeting.Name); //then it passes it to the chatbot.

                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);

                rtbChat.AppendText("Bot: " + greeting.DisplayGreeting() + "\n\n");

                nameSaved = true;

                txtMessage.Clear();
                return;
            }

            // TASK 3: Use NLP to detect intent
            string intent = nlpHelper.DetectIntent(input);

            // PART 4: Check if quiz is active
            if (isQuizActive)
            {
                HandleQuizAnswer(input);
                txtMessage.Clear();
                rtbChat.ScrollToCaret();
                return;
            }

            // PART 3 & TASK 3: Check if user wants to manage tasks (with NLP)
            if (intent == "TASK" || awaitingTaskTitle || awaitingTaskDescription || awaitingReminderDays)
            {
                HandleTaskRequest(input);
                txtMessage.Clear();
                rtbChat.ScrollToCaret();
                return;
            }

            // PART 4 & TASK 3: Check if user wants to start quiz (with NLP)
            if (intent == "QUIZ")
            {
                HandleQuizStart();
                txtMessage.Clear();
                rtbChat.ScrollToCaret();
                return;
            }

            // PART 4 & TASK 3: Check if user wants activity log (with NLP)
            if (intent == "ACTIVITY_LOG")
            {
                string log = activityLog.GetActivityLog();
                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                rtbChat.AppendText("Bot: " + log + " \n\n");
                txtMessage.Clear();
                rtbChat.ScrollToCaret();
                return;
            }

            //this is the chatbot now, gives user a response based on their input.
            string response = bot.GetResponse(input);

            rtbChat.SelectionAlignment = HorizontalAlignment.Left;
            rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
            rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);

            rtbChat.AppendText(" " + response + " \n\n");
            txtMessage.Clear();
            rtbChat.ScrollToCaret(); //allows the user to scroll up and down.
        }

        // PART 3: Handle Task Requests
        private void HandleTaskRequest(string userInput)
        {
            string input = userInput.ToLower();

            if (awaitingTaskTitle)
            {
                pendingTaskTitle = userInput;
                awaitingTaskTitle = false;
                awaitingTaskDescription = true;
                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                rtbChat.AppendText("Bot: Great! Now describe this task in detail. \n\n");
                return;
            }

            if (awaitingTaskDescription)
            {
                pendingTaskDescription = userInput;
                awaitingTaskDescription = false;
                awaitingReminderDays = true;
                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                rtbChat.AppendText("Bot: Perfect! In how many days should I remind you? (0 for no reminder) \n\n");
                return;
            }

            if (awaitingReminderDays)
            {
                awaitingReminderDays = false;
                if (int.TryParse(userInput, out int days) && days >= 0)
                {
                    bool success = taskManager.AddNewTask(pendingTaskTitle, pendingTaskDescription, days);
                    if (success)
                    {
                        string reminderMsg = days > 0 ? $"I'll remind you in {days} days." : "No reminder set.";
                        rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                        rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                        rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                        rtbChat.AppendText($"Bot: ✓ Task '{pendingTaskTitle}' added! {reminderMsg} \n\n");
                        activityLog.AddEntry("Task", $"Added: {pendingTaskTitle}");
                    }
                    pendingTaskTitle = "";
                    pendingTaskDescription = "";
                }
                else
                {
                    rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                    rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                    rtbChat.SelectionColor = Color.FromArgb(255, 100, 100);
                    rtbChat.AppendText("Bot: Please enter a valid number. \n\n");
                    awaitingReminderDays = true;
                }
                return;
            }

            if (input.Contains("add") && input.Contains("task"))
            {
                awaitingTaskTitle = true;
                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                rtbChat.AppendText("Bot: I'll help you add a task! What's the title? \n\n");
            }
            else if (input.Contains("show") && input.Contains("task"))
            {
                List<Task> allTasks = taskManager.RetrieveAllTasks();
                string taskList = taskManager.FormatTasksForDisplay(allTasks);
                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                rtbChat.AppendText("Bot: " + taskList + " \n\n");
            }
            else if (input.Contains("complete") && input.Contains("task"))
            {
                List<Task> pending = taskManager.GetPendingTasks();
                if (pending.Count == 0)
                {
                    rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                    rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                    rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                    rtbChat.AppendText("Bot: No pending tasks! \n\n");
                }
                else
                {
                    var matchingTask = pending.FirstOrDefault(t => t.Title != null && t.Title.Contains(userInput, StringComparison.OrdinalIgnoreCase));
                    if (matchingTask != null)
                    {
                        taskManager.MarkTaskComplete(matchingTask.TaskID);
                        rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                        rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                        rtbChat.SelectionColor = Color.FromArgb(0, 255, 100);
                        rtbChat.AppendText($"Bot: ✓ Task '{matchingTask.Title}' completed! \n\n");
                        activityLog.AddEntry("Task", $"Completed: {matchingTask.Title}");
                    }
                }
            }
            else if (input.Contains("delete") && input.Contains("task"))
            {
                List<Task> allTasks = taskManager.RetrieveAllTasks();
                if (allTasks.Count > 0)
                {
                    var taskToDelete = allTasks.FirstOrDefault(t => t.Title != null && t.Title.Contains(userInput, StringComparison.OrdinalIgnoreCase));
                    if (taskToDelete != null)
                    {
                        taskManager.RemoveTask(taskToDelete.TaskID);
                        rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                        rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                        rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                        rtbChat.AppendText($"Bot: ✓ Task '{taskToDelete.Title}' deleted. \n\n");
                        activityLog.AddEntry("Task", $"Deleted: {taskToDelete.Title}");
                    }
                }
            }
        }

        // PART 4: Handle Quiz Start
        private void HandleQuizStart()
        {
            if (isQuizActive)
            {
                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                rtbChat.AppendText("Bot: Quiz already in progress! Answer the current question. \n\n");
                return;
            }
            quizManager.StartQuiz();
            isQuizActive = true;
            activityLog.AddEntry("Quiz", "Quiz started");
            DisplayNextQuestion();
        }

        // PART 4: Display Next Question
        private void DisplayNextQuestion()
        {
            if (quizManager.HasNextQuestion())
            {
                QuizQuestion? question = quizManager.GetCurrentQuestion();
                if (question == null) return;
                string questionDisplay = $"\n[Question {quizManager.GetCurrentQuestionNumber()}/{quizManager.GetTotalQuestions()}]\n";
                questionDisplay += $"{question.QuestionText}\n\n";
                if (question.Options != null)
                {
                    for (int i = 0; i < question.Options.Count; i++)
                    {
                        questionDisplay += $"{i + 1}. {question.Options[i]}\n";
                    }
                }
                questionDisplay += "\nReply with the number of your answer (1, 2, 3, etc.)";
                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                rtbChat.AppendText("Bot: " + questionDisplay + " \n\n");
            }
            else
            {
                string finalScore = quizManager.EndQuiz();
                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                rtbChat.AppendText("Bot: " + finalScore + " \n\n");
                isQuizActive = false;
                activityLog.AddEntry("Quiz", $"Quiz completed. Score: {quizManager.GetCurrentScore()}/{quizManager.GetTotalQuestions()}");
            }
        }

        // PART 4: Handle Quiz Answer
        private void HandleQuizAnswer(string userInput)
        {
            if (int.TryParse(userInput, out int answerChoice))
            {
                answerChoice--;
                string feedback = quizManager.CheckAnswer(answerChoice);
                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
                rtbChat.AppendText("Bot: " + feedback + " \n\n");
                if (quizManager.HasNextQuestion())
                {
                    rtbChat.AppendText("Bot: Next question coming...\n\n");
                    DisplayNextQuestion();
                }
                else
                {
                    string finalScore = quizManager.EndQuiz();
                    rtbChat.AppendText("Bot: " + finalScore + " \n\n");
                    isQuizActive = false;
                    activityLog.AddEntry("Quiz", $"Quiz completed. Score: {quizManager.GetCurrentScore()}/{quizManager.GetTotalQuestions()}");
                }
            }
            else
            {
                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
                rtbChat.SelectionColor = Color.FromArgb(255, 100, 100);
                rtbChat.AppendText("Bot: Please enter the number (1, 2, 3, etc.) of your answer. \n\n");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            rtbChat.Clear(); //clears the chat and begins the program again.
            rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
            rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
            rtbChat.AppendText(
            greeting.WelcomeMessage() + "\n\n");
            nameSaved = false;
            awaitingTaskTitle = false;
            awaitingTaskDescription = false;
            awaitingReminderDays = false;
            isQuizActive = false;
            pendingTaskTitle = "";
            pendingTaskDescription = "";
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            voice.PlayGreeting(); //this places the voice greeting.
        }


    }
}
