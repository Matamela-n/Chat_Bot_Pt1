using System;

namespace Chat_Bot_Pt1
{
 public class TextGreeting1
  {
public string AskName()
{
 string name;
Console.WriteLine("Please enter your name: ");
            do
            {
  name = Console.ReadLine();
if (string.IsNullOrEmpty(name))
 {
    Console.WriteLine("No name was entered.Please enter yor name:  ");
  }
  } while (string.IsNullOrEmpty(name));
  return name;
}
public void Display(string name)
 {
Console.ForegroundColor = ConsoleColor.DarkYellow;

 Console.WriteLine("******************************************************************");
 Console.WriteLine("********************************************************************");
Console.WriteLine("Hello " + name + "!"+ "Welcome to the Cybersecurity Awareness Bot") ;
Console.WriteLine("******************************************************************");
Console.WriteLine("******************************************************************");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow; //this changes the colour
 Console.WriteLine("****************************************************");
 Console.WriteLine("*         TYPE 'exit' TO QUIT THE CHATBOT.             *");
 Console.WriteLine("****************************************************");
Console.ResetColor();
 Console.ResetColor();          
  }
        
 }
}