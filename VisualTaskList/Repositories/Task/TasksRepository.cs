using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Repositories.Task
{
    public class TasksRepository : ITasksRepository
    {
        private string ConnectionString;

        public TasksRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }


        public TaskModel GetById(int id)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                @"SELECT t.Id, t.Title, t.CategoryId, t.TypeId, t.Notes, t.DueDate, t.IsHidden, 
                  ty.Name, ty.Color, c.Name, c.ShortName
                  FROM Tasks t 
                  LEFT JOIN Types ty ON t.TypeId = ty.Id 
                  LEFT JOIN Categories c ON t.CategoryId = c.Id
                  WHERE t.Id = @id;";
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();
            if(reader.Read())
            {
                return TranslateSelectToModel(reader);
            }

            return null;
        }


        public List<TaskModel> GetAll(bool showHidden = false)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText =
                @"SELECT t.Id, t.Title, t.CategoryId, t.TypeId, t.Notes, t.DueDate, t.IsHidden, 
                  ty.Name, ty.Color, c.Name, c.ShortName
                  FROM Tasks t 
                  LEFT JOIN Types ty ON t.TypeId = ty.Id 
                  LEFT JOIN Categories c ON t.CategoryId = c.Id
                  WHERE t.IsHidden = @isHidden
                  ORDER BY t.DueDate ASC;";
            command.Parameters.AddWithValue("@isHidden", showHidden == true ? 1 : 0);

            List<TaskModel> tasks = new List<TaskModel>();

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                TaskModel task = TranslateSelectToModel(reader);
                tasks.Add(task);
            }

            return tasks;
        }


        public void Add(TaskModel task)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Tasks (Title, CategoryId, TypeId, DueDate, IsHidden) VALUES (@title, @categoryId, @typeId, @dueDate, 0)";
            command.Parameters.AddWithValue("@title", task.Title);
            command.Parameters.AddWithValue("@categoryId", task.CategoryId);
            command.Parameters.AddWithValue("@typeId", task.TypeId);
            command.Parameters.AddWithValue("@dueDate", task.DueDate.ToString("yyyy-MM-dd HH:mm:ss"));
            command.ExecuteNonQuery();
        }


        public void Update(TaskModel task)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "UPDATE Tasks set Title = @title, CategoryId = @categoryId, TypeId = @typeId, Notes = @notes, DueDate = @dueDate, IsHidden = @isHidden WHERE Id = @id;";
            command.Parameters.AddWithValue("@id", task.Id);
            command.Parameters.AddWithValue("@title", task.Title);
            command.Parameters.AddWithValue("@categoryId", task.CategoryId);
            command.Parameters.AddWithValue("@typeId", task.TypeId);
            command.Parameters.AddWithValue("@notes", task.Notes);
            command.Parameters.AddWithValue("@dueDate", task.DueDate.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@isHidden", task.IsHidden ? 1:0);
            command.ExecuteNonQuery();
        }


        public void Delete(int id)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Tasks WHERE Id = @id;";
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }


        private TaskModel TranslateSelectToModel(SqliteDataReader reader)
        {
            TaskModel task = new TaskModel();
            task.Id = reader.GetInt32(0);
            task.Title = reader.GetString(1);
            task.CategoryId = reader.GetInt32(2);
            task.TypeId = reader.GetInt32(3);
            task.Notes = reader.IsDBNull(4) ? "" : reader.GetString(4);
            task.DueDate = DateTime.Parse(reader.GetString(5));
            task.IsHidden = reader.GetInt32(6) == 1;

            //--Type and Category Handling--

            //If the type is missing (Null), Initialize the Type to the default values
            task.Type = new TypeModel();
            if (reader.IsDBNull(3))
            {
                task.Type.Name = "None";
                task.Type.Color = Color.Gray;
            }
            else
            {
                task.Type.Id = reader.GetInt32(3);
                task.Type.Name = reader.GetString(7);
                task.Type.Color = ColorTranslator.FromHtml(reader.GetString(8));
            }

            //If the category is missing (Null), Initialize the Category to the default values
            task.Category = new CategoryModel();
            if (reader.IsDBNull(2))
            {
                task.Category.Name = "None";
                task.Category.ShortName = "NONE";
            }
            else
            {
                task.Category.Id = reader.GetInt32(2);
                task.Category.Name = reader.GetString(9);
                task.Category.ShortName = reader.GetString(10);
            }
            return task;
        }

    }
}