
using System;
using System.Drawing;


namespace Chat_Bot_Pt1
{
    public class AsciiArt
    {
  public void DisplayLogo() 
  { //this is the start of the constructor
   ascii();

}//end of the constructor

private void ascii()
 {
  string[] logo = {
"::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::",
"::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::",
"::                                                                        ::",
"::                                                                        ::",
"::                                                                        ::",
"::     ________  _______   ________  ___  ___  ________  _______          ::",
"::    |\\   ____\\|\\  ___ \\ |\\   ____\\|\\  \\|\\  \\|\\   __  \\|\\  ___ \\         ::",
"::    \\ \\  \\___|\\ \\   __/|\\ \\  \\___|\\ \\  \\\\  \\ \\  \\|\\  \\ \\   __/|        ::",
"::     \\ \\_____  \\ \\  \\_|/_\\ \\  \\    \\ \\  \\\\  \\ \\   _  _\\ \\  \\_|/__      ::",
"::      \\|____|\\  \\ \\  \\_|\\ \\ \\  \\____\\ \\  \\\\  \\ \\  \\\\  \\\\ \\  \\_|\\ \\     ::",
"::        ____\\_\\  \\ \\_______\\ \\_______\\ \\_______\\ \\__\\\\ _\\\\ \\_______\\    ::",
"::       |\\_________\\|_______|\\|_______|\\|_______|\\|__|\\|__|\\|_______|    ::",
"::       \\|_________|                                                     ::",
"::                                                                        ::",
"::                                                                        ::",
"::     ___       ________  ________  ___  __                              ::",
"::    |\\  \\     |\\   __  \\|\\   ____\\|\\  \\|\\  \\                            ::",
"::    \\ \\  \\    \\ \\  \\|\\  \\ \\  \\___|\\ \\  \\/  /|_                          ::",
"::     \\ \\  \\    \\ \\  \\\\\\  \\ \\  \\    \\ \\   ___  \\                         ::",
"::      \\ \\  \\____\\ \\  \\\\\\  \\ \\  \\____\\ \\  \\\\ \\  \\                        ::",
"::       \\ \\_______\\ \\_______\\ \\_______\\ \\__\\\\ \\__\\                       ::",
"::        \\|_______|\\|_______|\\|_______|\\|__| \\|__|                       ::",
"::                                                                        ::",
"::                                                                        ::",
"::                                                                        ::",
"::                                                                        ::",
"::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::",
"::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::"
 };

ConsoleColor[] gradient = { //this array of colours will create the gradient.
ConsoleColor.DarkRed,
ConsoleColor.Red,
ConsoleColor.Yellow,
 ConsoleColor.Green,
ConsoleColor.Cyan,
 ConsoleColor.Blue,
ConsoleColor.Magenta
 };

int colorIndex = 0;
foreach (string line in logo)//loops through each line.
 {
 foreach (char c in line) //this will loop through each character in the lines
 {
   Console.ForegroundColor = gradient[colorIndex % gradient.Length];
  Console.Write(c);
 colorIndex++;
 }
 Console.WriteLine();
     }
Console.ResetColor();
 }
}
 }
   

