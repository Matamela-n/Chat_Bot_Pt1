using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Threading; //import this in order to use thread.sleep

namespace Chat_Bot_Pt1
{
public class ChatBot
{

public void TypeWriter(string message)
        {
foreach (char c in message)
{
Console.Write(c);
Thread.Sleep(40);
 }
 Console.WriteLine();
        }

string[] keyword = //create arrays for the keywords and responses.
         {
"how are you",
"purpose",
"topics",
"phishing",
"password",
"safe browsing"
};


string[] response =
{
  "I'm good",
  "I am a Cybersecurity Awareness Bot and my purpose is to educate you about online safety",
"You can ask me about phishing, passwords and safe browsing",
"Beware of any unknown emails or messages that you may receive especially if they ask for your personal info. Always check if the sender id verified and legit.",
"Ensure you use a strong and unique password!!!",
"Use updated browsers, avoid unsafe websites and enable security features like HTTPS and ad blockers."
 };

 public void Start()
 {
   bool run = true;
while (run) //loop will keep the chatbot running until the user says 'exit'
{
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("\nAsk away: ");
Console.ResetColor();
string input = Console.ReadLine().ToLower().Trim();
 if (input == "exit")
{
 run = false;
 TypeWriter("Goodbye! Stay safe online :)");
}
 else
 {
Response(input); //call response method to check the keyword in order to get the corresponding response.
  }
  }
  }

public void Response(string input) //create a method that will provide a response after user input.
 {

Console.ForegroundColor = ConsoleColor.White;
string userInput = input.ToLower().Trim(); //this changes the input to lowercase.

 for(int i =0; i< keyword.Length; i++) //for loop will loop through all the keywords in the array tom find a match.
            {
if (userInput.Contains(keyword[i]))
 {
TypeWriter("Secure Lock Bot: " + response[i]); //this will display the relevant response.
   return;
 }
 }
TypeWriter("I don't understand what you are asking. Can you ask again?");
}
    }
}