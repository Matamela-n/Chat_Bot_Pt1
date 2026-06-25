using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Lock_Chat
{
    public class ActivityLogEntry //this will help a user see what the chatbot has done for them.
    {
        public DateTime Timestamp { get; set; }//this gets the exact date and time of when an action happened.
        public string? ActionType { get; set; }//this shows the type of action that was performed.
        public string? Description { get; set; } //this gets a detailed description of what happened.
        public ActivityLogEntry() { } //create a constructor for an empty log entry.
        public ActivityLogEntry(string actionType, string description) //this automatically sets the current timestamp when entry happens.
        {
            Timestamp = DateTime.Now;
            ActionType = actionType;
            Description = description;
        }
        public override string ToString()
        {
            return $"[{Timestamp:HH:mm:ss}] {ActionType}: {Description}";
        }
    }
    public class ActivityLog
    {
        private List<ActivityLogEntry> entries; //list which stores all the activity log entries.
        private int maxEntries = 10;//these are the max entries!!!
        public ActivityLog()
        {
            entries = new List<ActivityLogEntry>();
        }
        public void AddEntry(string actionType, string description)
        {
            entries.Add(new ActivityLogEntry(actionType, description));
            if (entries.Count > maxEntries)
            {
                entries.RemoveAt(0);
            }
        }
        public string GetActivityLog()
        {
            if (entries.Count == 0) //if there are no entries,the below message will appear.
                return "No activity yet.";
            string output = "\n╔══════════════════════════════════════╗\n";
            output += "║  ACTIVITY LOG                        ║\n";
            output += "╚══════════════════════════════════════╝\n";
            int count = 1;
            foreach (var entry in entries.OrderByDescending(e => e.Timestamp))
            {
                output += $"\n{count}. {entry}\n";
                count++;
            }
            return output;
        }
        public void ClearLog()//this clears the activity log
        {
            entries.Clear();
        }
        public int GetEntryCount()//method is used to return how many entries are currently in log.
        {
            return entries.Count;
        }
    }
}
