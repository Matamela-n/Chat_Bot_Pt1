
using System;
using System.Collections.Generic;

namespace ChatBotGUI
{
    public class ChatBot
    {
        Random random = new Random();

        string pastInterest = ""; 
        string userName = "";
        string rememberedTopic = "";
        string lastTopic = "";

        Dictionary<string, List<string>> responses =
      new Dictionary<string, List<string>>()
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
            }
        };
public void SaveName(string name) //method to save the user's name.
 {
userName = name;
  }

        public string GetResponse(string input)
        {
            string userInput = input.ToLower();
            //sentiment detection

            if (userInput.Contains("worried"))
            {
                return "It's okay to feel worried about cybersecurity. Staying informed is the first step to protecting yourself online.";
            }

            if (userInput.Contains("frustrated"))
            {
                return "Cybersecurity can feel overwhelming sometimes, but small safety habits make a big difference.";
            }

            if (userInput.Contains("curious"))
            {
                return "Curiosity is great in cybersecurity. Learning more helps you stay safe online.";
            }
            if (userInput.Contains("worried"))
            {
                return "It's okay to feel worried about cybersecurity. Staying informed is the first step to protecting yourself online.";
            }

            if (userInput.Contains("frustrated"))
            {
                return "Cybersecurity can feel overwhelming sometimes, but small safety habits make a big difference.";
            }

            if (userInput.Contains("curious"))
            {
                return "Curiosity is great in cybersecurity. Learning more helps you stay safe online.";
            }
            // FOLLOW-UP QUESTIONS

            if (userInput.Contains("tell me more") ||
                userInput.Contains("another tip") ||
                userInput.Contains("explain more"))
            {
                if (lastTopic != "")
                {
                    List<string> possibleResponses =
                        responses[lastTopic];

                    int index =
                        random.Next(possibleResponses.Count);

                    return "Here is another tip about " +
                           lastTopic + ":\n\n" +
                           possibleResponses[index];
                }

                return "Please ask about a cybersecurity topic first.";
            }

            //memory feature
            if (userInput.Contains("interested in privacy"))
            {
                pastInterest = "privacy";

                return "Great! I'll remember that you're interested in privacy. It's an important part of online safety.";
            }

            if (userInput.Contains("interested in phishing"))
            {
                pastInterest = "phishing";

                return "Great! I'll remember that you're interested in phishing awareness.";
            }

//rexall feature
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
  // REMEMBER CURRENT TOPIC
   lastTopic = keyword;

rememberedTopic = keyword;

                    // RANDOM RESPONSE
  List<string> possibleResponses = responses[keyword];

  int index = random.Next(possibleResponses.Count);

return possibleResponses[index];
  }
}

            return "I'm not sure I understand. Can you try rephrasing?";
        }
    }
}
