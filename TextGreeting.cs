using System;

namespace ChatBotGUI
{
    public class TextGreeting
    {
        public string Name { get; set; } = ""; //stores the name which was entered.

        public string WelcomeMessage() //shows the welcome message and prompts user to enter their name.
        {
            return "Hello! Welcome to the Secure Lock's Cybersecurity Assitant Bot.\n\n "+ "where Smart Security Starts Here! \n\n " + "Please enter your name to begin.";
        }

        public void SaveName(string name) //this saves their name from their first input.
        {
            Name = name;
        }

        public string DisplayGreeting()
        {
            return "Hello " + Name + "\nYou can ask me about the following topics: scams, privacy, phishing, passwords, malware, wifi and backup";

        }
    }
}