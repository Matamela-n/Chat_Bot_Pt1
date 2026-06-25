using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Secure_Lock_Chat
{
    public class Database
    {
        private string connectionString = "Server=localhost;Database=SecureLockAssistantDB;Uid=root;Pwd=Matamela22.;";
        public Database(string password = "")
        {
            if (!string.IsNullOrEmpty(password))
            {
                connectionString = $"Server=localhost;Database=SecureLockAssistantDB;Uid=root;Pwd={password};";
            }
        }
        public bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
                return false;
            }
        }
        public bool AddTask(Task task)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO tasks (Title, Description, ReminderDate, IsCompleted) VALUES (@Title, @Description, @ReminderDate, @IsCompleted)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Title", task.Title ?? "");
                        cmd.Parameters.AddWithValue("@Description", task.Description ?? "");
                        cmd.Parameters.AddWithValue("@ReminderDate", task.ReminderDate ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding task: {ex.Message}");
                return false;
            }
        }
        public List<Task> GetAllTasks()
        {
            List<Task> tasks = new List<Task>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM tasks ORDER BY TaskID DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Task task = new Task()
                                {
                                    TaskID = (int)reader["TaskID"],
                                    Title = reader["Title"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    ReminderDate = reader["ReminderDate"] != DBNull.Value ? (DateTime?)reader["ReminderDate"] : null,
                                    IsCompleted = (bool)reader["IsCompleted"]
                                };
                                tasks.Add(task);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving tasks: {ex.Message}");
            }
            return tasks;
        }
        public bool CompleteTask(int taskID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE tasks SET IsCompleted = TRUE WHERE TaskID = @TaskID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TaskID", taskID);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error completing task: {ex.Message}");
                return false;
            }
        }
        public bool DeleteTask(int taskID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM tasks WHERE TaskID = @TaskID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TaskID", taskID);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting task: {ex.Message}");
                return false;
            }
        }
        public bool UpdateTask(Task task)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE tasks SET Title = @Title, Description = @Description, ReminderDate = @ReminderDate, IsCompleted = @IsCompleted WHERE TaskID = @TaskID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
  cmd.Parameters.AddWithValue("@Title", task.Title ?? "");
  cmd.Parameters.AddWithValue("@Description", task.Description ?? "");
   cmd.Parameters.AddWithValue("@ReminderDate", task.ReminderDate ?? (object)DBNull.Value);
cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);
cmd.Parameters.AddWithValue("@TaskID", task.TaskID);
int result = cmd.ExecuteNonQuery();
  return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating task: {ex.Message}");
                return false;
            }
        }
    }
}