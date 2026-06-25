using System;
using System.Collections.Generic;
using System.Linq;
namespace Secure_Lock_Chat
{
public class TaskManager
{
private Database db;
public TaskManager(Database database)
{
db = database;
}
public bool AddNewTask(string title, string description, int daysUntilReminder)
{
if (string.IsNullOrWhiteSpace(title))
return false;
DateTime? reminderDate = daysUntilReminder > 0 ? DateTime.Now.AddDays(daysUntilReminder) : (DateTime?)null;
Task newTask = new Task(title, description, reminderDate);
return db.AddTask(newTask);
}
public List<Task> RetrieveAllTasks()
{
return db.GetAllTasks();
}
public List<Task> GetPendingTasks()
{
return db.GetAllTasks().Where(t => !t.IsCompleted).ToList();
}
public List<Task> GetCompletedTasks()
{
return db.GetAllTasks().Where(t => t.IsCompleted).ToList();
}
public bool MarkTaskComplete(int taskID)
{
return db.CompleteTask(taskID);
}
public bool CompleteTaskByTitle(string title)
{
var tasks = RetrieveAllTasks();
var task = tasks.FirstOrDefault(t => t.Title != null && t.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
if (task != null)
{
return MarkTaskComplete(task.TaskID);
}
return false;
}
public bool RemoveTask(int taskID) //this method is used to delete a task from database by using its ID.
{
return db.DeleteTask(taskID);
}
public bool RemoveTaskByTitle(string title)
{
var tasks = RetrieveAllTasks();
 var task = tasks.FirstOrDefault(t => t.Title != null && t.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
 if (task != null)
{
return RemoveTask(task.TaskID);
}
return false;
}
public string FormatTasksForDisplay(List<Task> tasks)
{
if (tasks.Count == 0) //if there are no tasks it displays a messaged
return "You don't have any tasks yet. Would you like to add one?";
string output = "\n╔══════════════════════════════════════╗\n";
output += "║  YOUR CYBERSECURITY TASKS            ║\n";
output += "╚══════════════════════════════════════╝\n";
int count = 1; //this goes through each task and adds it to the output.
foreach (var task in tasks)
{
string status = task.IsCompleted ? "✓" : "○";
string reminderInfo = task.ReminderDate.HasValue ? $" | Reminder: {task.ReminderDate:MM/dd/yyyy}" : "";
output += $"\n{count}. {status} {task.Title}\n   {task.Description}{reminderInfo}\n";
count++;
}
return output;
}
public int GetTaskCount() //gets total of all the tasks whether completed or pending.
{
return RetrieveAllTasks().Count;
}
public int GetPendingTaskCount()//this methid will return the number of pendinging tasks. 
{
return GetPendingTasks().Count;
}
}
}
