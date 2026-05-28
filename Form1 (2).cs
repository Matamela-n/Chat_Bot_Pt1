using Chat_Bot_Pt1;
using ChatBotGUI;
using System.Drawing;
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
                rtbChat.SelectionBackColor = Color.FromArgb(26,16,53);
                rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);

                rtbChat.AppendText("Bot: " + greeting.DisplayGreeting() + "\n\n");

                nameSaved = true;

                txtMessage.Clear();
                return;
            }

           //this is the chatbot now, gives user a response based on their input.
            string response = bot.GetResponse(input);


            rtbChat.SelectionAlignment = HorizontalAlignment.Left;
            rtbChat.SelectionBackColor = Color.FromArgb(26,16,53);
            rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);

            rtbChat.AppendText(" " + response + " \n\n");
            txtMessage.Clear();
            rtbChat.ScrollToCaret(); //allows the user to scroll up and down.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            rtbChat.Clear(); //clears the chat and begins the program again.
            rtbChat.SelectionBackColor = Color.FromArgb(26, 16, 53);
            rtbChat.SelectionColor = Color.FromArgb(221, 214, 254);
            rtbChat.AppendText(
            greeting.WelcomeMessage() + "\n\n");
            nameSaved = false;
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            voice.PlayGreeting(); //this places the voice greeting.
        }
    }
}
