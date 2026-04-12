using System;
using System.IO;
using System.Media;

namespace Chat_Bot_Pt1
{
public class VoiceGreeting
{
string path = AppDomain.CurrentDomain.BaseDirectory; //auto path.
 public VoiceGreeting() //create a constructor
  { 
hello(); //call the method whic will play the audio
  }
 private void hello() //this is the method which will play the audio
  {
  string fullpath = path.Replace(@"bin\Debug\", "");
  string joined_path = fullpath + "VoiceGreeting.wav";

  try
{
  SoundPlayer recording = new SoundPlayer(joined_path);
 recording.Load();
recording.PlaySync();
 }
catch (Exception m)
{
Console.WriteLine("The audio file that you are trying to play cannot be found. Please try again!" + m.Message);
}
}
    }
    }
      
 
