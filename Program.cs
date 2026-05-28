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
new VoiceGreeting1() { }; //create an object for the voicegreeting class.

AsciiArt2 logo = new AsciiArt2();
 logo.DisplayLogo();

TextGreeting1 hello = new TextGreeting1();
string name = hello.AskName();
hello.Display(name);

ChatBot1 bot = new ChatBot1();
 bot.Start();

Console.ReadLine();
 }
    }
    }

