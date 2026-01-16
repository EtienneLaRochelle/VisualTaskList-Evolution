using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Repositories.Category
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private string ConnectionString;

        public CategoriesRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }


        public CategoryModel GetById(int id)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = @"SELECT * FROM Categories WHERE Id = @id";
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                CategoryModel category = new CategoryModel();
                category.Id = reader.GetInt32(0);
                category.Name = reader.GetString(1);
                category.ShortName = reader.GetString(2);
                category.Notes = reader.IsDBNull(3) ? "" : reader.GetString(3);
                return category;
            }

            return null;
        }


        public List<CategoryModel> GetAll(bool includeNone = false)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            if (includeNone)
            {
                command.CommandText = @"SELECT * FROM Categories;";
            }
            else
            {
                command.CommandText = @"SELECT * FROM Categories WHERE Id != 1;";
            }

            List<CategoryModel> categories = new List<CategoryModel>();

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                CategoryModel category = new CategoryModel();
                category.Id = reader.GetInt32(0);
                category.Name = reader.GetString(1);
                category.ShortName = reader.GetString(2);
                category.Notes = reader.IsDBNull(3) ? "" : reader.GetString(3);
                categories.Add(category);
            }

            return categories;
        }


        public void Add(CategoryModel category)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Categories (Name, ShortName) VALUES (@name, @shortName)";
            command.Parameters.AddWithValue("@name", category.Name);
            command.Parameters.AddWithValue("@shortName", category.ShortName.ToUpper());
            command.ExecuteNonQuery();
        }


        public void Update(CategoryModel category)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "UPDATE Categories SET Name = @name, ShortName = @shortName, Notes = @notes WHERE Id = @id;";
            command.Parameters.AddWithValue("@id", category.Id);
            command.Parameters.AddWithValue("@name", category.Name);
            command.Parameters.AddWithValue("@shortName", category.ShortName.ToUpper());
            command.Parameters.AddWithValue("@notes", category.Notes);
            command.ExecuteNonQuery();
        }


        public void Delete(int id)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            // Safety Check: Prevent deletion of the default (None) category.
            if (id == 1)
            {
                return;
            }

            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    string updateQuery = "UPDATE Tasks SET CategoryId = 1 WHERE CategoryId = @id";
                    using (var cmd = new SqliteCommand(updateQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    string deleteQuery = "DELETE FROM Categories WHERE Id = @id;";
                    using (var cmd = new SqliteCommand(deleteQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    // Rollback changes if either step fails
                    transaction.Rollback();
                    return;
                }
            }
        }

    }
}
