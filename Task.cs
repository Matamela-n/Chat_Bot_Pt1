using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Lock_Chat
{
    public class Task //this class represents a single task that the user creates.
    {
        public int TaskID { get; set; } //the database automatically generates an ID starting from 1.
        public string? Title { get; set; } //gets title of the task
        public string? Description { get; set; }//gets description of the task
        public DateTime? ReminderDate { get; set; }//gets the user's input example the user can say 5.
        public bool IsCompleted { get; set; }//shows whether the task was completed or not.

        public Task() { } //cponstructor is used when we are reading a task's data from the database.

        public Task(string title, string description, DateTime? reminderDate) //this constructor will create a new task with all the info provided by the user.
        {
            Title = title; //store the inputed title
            Description = description;//stores description.
            ReminderDate = reminderDate;
            IsCompleted = false; //New tasks are always incomplete when first created
        }

        public override string ToString() //method is used to convert task so that it is displayed in chat.
        {
            string status = IsCompleted ? "✓ COMPLETED" : "○ PENDING";
            string reminderInfo = ReminderDate.HasValue ? $" | Reminder: {ReminderDate:yyyy-MM-dd}" : "";
            return $"{status} | {Title} - {Description}{reminderInfo}";
        }
    }
}