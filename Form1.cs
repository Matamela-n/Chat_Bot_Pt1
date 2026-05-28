using Chat_Bot_Pt1;
using ChatBotGUI;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Secure_Lock_Chat
{
    public partial class Form1 : Form
    {
        private ChatBot bot; //this creates the chat bot object.

        private TextGreeting greeting = new TextGreeting();

        VoiceGreeting voice = new VoiceGreeting();

        bool nameSaved = false;
        public Form1()
        {
            InitializeComponent();
            voice.PlayGreeting();
            bot = new ChatBot();
            greeting = new TextGreeting();

            rtbChat.AppendText(greeting.WelcomeMessage() + "");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            rtbChat.SelectionBackColor = Color.FromArgb(37, 211, 102);
            rtbChat.SelectionColor = Color.White;

            rtbChat.AppendText(" " + input + " \n\n");

            // FIRST INPUT = USER NAME
            if (!nameSaved)
            {
                greeting.SaveName(input);

                bot.SaveName(greeting.Name);

                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionBackColor = Color.Cyan;
                rtbChat.SelectionColor = Color.White;

                rtbChat.AppendText("Bot: " + greeting.DisplayGreeting() + "\n\n");

                nameSaved = true;

                txtMessage.Clear();
                return;
            }

            // NORMAL CHATBOT RESPONSE
            string response = bot.GetResponse(input);


            rtbChat.SelectionAlignment = HorizontalAlignment.Left;
            rtbChat.SelectionBackColor = Color.Black;
            rtbChat.SelectionColor = Color.White;

            rtbChat.AppendText(" " + response + " \n\n");
            txtMessage.Clear();
            rtbChat.ScrollToCaret();
        }

private void btnClear_Click(object sender, EventArgs e)
{
rtbChat.Clear();
rtbChat.AppendText(
greeting.WelcomeMessage() + "\n\n");
}
  }
}
