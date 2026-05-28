using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Chat_Bot_Pt1
{
    public class VoiceGreeting
    {
  public VoiceGreeting()
        {

 }

 public void PlayGreeting() //this is the method which will play the audio
{
  string audioPath = Path.Combine(Application.StartupPath, "VoiceGreeting.wav");
 try
 {
 SoundPlayer player = new SoundPlayer(audioPath);
 player.Load();//loads the audio
  player.PlaySync(); //plays the audio until it is finished.
  }
 catch (Exception m) //this will show an error message if the audio file is not found.
 {
  MessageBox.Show("The audio file that you are trying to play cannot be found. Please try again!" + m.Message);
    }
     }
        }
    }

