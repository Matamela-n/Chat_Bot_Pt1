using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Bot_Pt1
{
    public class Program
    {
        static void Main(string[] args)
        {
new VoiceGreeting() { };

AsciiArt logo = new AsciiArt();
 logo.DisplayLogo();

TextGreeting hello = new TextGreeting();
string name = hello.AskName();
hello.Display(name);

ChatBot bot = new ChatBot();
 bot.Start();

Console.ReadLine();
 }
    }
    }

