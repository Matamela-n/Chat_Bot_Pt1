
using System;
using System.Collections.Generic;


namespace ChatBotGUI
{
    public class ChatBot
    {
        Random random = new Random(); //this is used to give random responses.

        string pastInterest = ""; 
        string userName = "";
        string rememberedTopic = "";
        string lastTopic = "";
        //this is a dictionary which stores the topics and responses.
        Dictionary<string, List<string>> responses = new Dictionary<string, List<string>>()
        {
            {
     "password",
                new List<string>()
                {
     "Use strong and unique passwords for every account.",
                    "Avoid using personal information in passwords.",
                    "Use a mix of uppercase letters, numbers and symbols."
                }
            },

            {
                "phishing",
                new List<string>()
                {
                    "Be cautious of suspicious emails asking for personal information.",
                    "Never click unknown links from emails or messages.",
                    "Scammers often pretend to be trusted organisations."
                }
            },

            {
                "privacy",
                new List<string>()
                {
                    "Review your privacy settings regularly.",
                    "Avoid sharing sensitive information online.",
                    "Use two-factor authentication for extra protection."
                }
            },

            {
                "scam",
                new List<string>()
                {
                    "Online scams often create urgency to trick victims.",
                    "Never send money to unknown people online.",
                    "Verify websites and sellers before making payments."
                }
            },
          {
    "malware",
    new List<string>()
    {
        "Install reputable antivirus software to protect against malware.",
        "Never download software from untrusted websites.",
        "Keep your operating system updated to patch security vulnerabilities."
    }
},

{
    "wifi",
    new List<string>()
    {
        "Avoid using public WiFi for sensitive transactions.",
        "Always use a VPN when connecting to public networks.",
        "Ensure your home WiFi uses WPA3 encryption."
    }
},

{
    "backup",
    new List<string>()
    {
        "Always back up important data regularly.",
        "Use the 3-2-1 rule: 3 copies, 2 different media, 1 offsite.",
        "Test your backups regularly to ensure they work."
    }
}
        };



public void SaveName(string name) //method to save the user's name for their personalised responses..
 {
userName = name;
  }


 public string GetResponse(string input)
        {
 string userInput = input.ToLower();

//sentiment detection responds empathetically and provides a tip.
    if (userInput.Contains("worried"))
  {
  return "It's okay to feel worried about cybersecurity. Staying informed is the first step.\n\nTip: "+ responses["scam"][random.Next(responses["scam"].Count)];
   }
        
 if (userInput.Contains("frustrated"))
            {
return "Cybersecurity can feel overwhelming, but small habits make a big difference.\n\nTip: " + responses["privacy"][random.Next(responses["privacy"].Count)];
  }
if (userInput.Contains("curious"))
{
 return "Curiosity is great in cybersecurity!\n\nTip: " + responses["phishing"][random.Next(responses["phishing"].Count)];
            
 }
  
//this are follow up questions which will give the user more info on the topic they asked about.
if (userInput.Contains("tell me more") ||
 userInput.Contains("another tip") ||
  userInput.Contains("explain more"))
    {
  if (lastTopic != "")
    {
  List<string> possibleResponses =responses[lastTopic];
int index = random.Next(possibleResponses.Count);

return "Here is another tip about " + lastTopic + ":\n\n" + possibleResponses[index];
    }
return "Please ask about a cybersecurity topic first.";
 }


 //this is a memory feature and it stores the user's favourite topic.
if (userInput.Contains("interested in password"))
  {
 pastInterest = "password";
   return "Great! I'll remember that you're interested in password safety.\n\n" +  "Tip: " + responses["password"][random.Next(responses["password"].Count)];
            }

   if (userInput.Contains("interested in scam"))
    {
    pastInterest = "scam";
    return "Great! I'll remember that you're interested in scam awareness.\n\n" + "Tip: " + responses["scam"][random.Next(responses["scam"].Count)];}

if (userInput.Contains("interested in phishing"))
 {
 pastInterest = "phishing";
    return "Great! I'll remember that you're interested in phishing awareness.\n\n" + "Tip: " + responses["phishing"][random.Next(responses["phishing"].Count)];
            }

if (userInput.Contains("interested in privacy"))
  {
  pastInterest = "privacy";
 return "Great! I'll remember that you're interested in privacy.\n\n" + "Tip: " + responses["privacy"][random.Next(responses["privacy"].Count)];
  }
    if (userInput.Contains("interested in malware"))
   {
    pastInterest = "malware";
    return "Great! I'll remember you're interested in malware protection.\n\n" + "Tip: " + responses["malware"][random.Next(responses["malware"].Count)];
     }

    if (userInput.Contains("interested in wifi"))
     {
     pastInterest = "wifi";
     return "Great! I'll remember you're interested in WiFi security.\n\n" + "Tip: " + responses["wifi"][random.Next(responses["wifi"].Count)];
            }

    if (userInput.Contains("interested in backup"))
            {
  pastInterest = "backup";
     return "Great! I'll remember you're interested in data backups.\n\n" +  "Tip: " + responses["backup"][random.Next(responses["backup"].Count)];
      }
 
    
    //recall feature- this will remind the user of their previous topic.
      if (userInput.Contains("remind me"))
{
if (pastInterest != "")
{
 return "Earlier you mentioned being interested in " + pastInterest + ". You should continue learning about it to stay cyber safe.";
  }
 else
 {
return "I do not remember any interests yet.";
 }
 }


 //keyword recognition

foreach (var keyword in responses.Keys)
{
 if (userInput.Contains(keyword))
  {
  
   lastTopic = keyword; //this remembers the last topic the user was talking about.

rememberedTopic = keyword;

 //gives user a random response based on the matched keyword.
  List<string> possibleResponses = responses[keyword];

  int index = random.Next(possibleResponses.Count);

return possibleResponses[index];
  }
}

  return "I'm not sure I understand. Can you try rephrasing?";
        }
    }
}
