using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Repositories.Type
{
    public class TypesRepository : ITypesRepository
    {
        private string ConnectionString;

        public TypesRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }


        public TypeModel GetById(int id)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Types WHERE Id = @id;";
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                TypeModel type = new TypeModel();
                type.Id = reader.GetInt32(0);
                type.Name = reader.GetString(1);
                type.Notes = reader.IsDBNull(2) ? "" : reader.GetString(2);
                type.Color = ColorTranslator.FromHtml(reader.GetString(3));
                return type;
            }

            return null;
        }


        public List<TypeModel> GetAll(bool includeNone = false)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            if (includeNone)
            {
                command.CommandText = $"SELECT * FROM Types";
            }
            else
            {
                command.CommandText = $"SELECT * FROM Types WHERE Id != 1";
            }

            List<TypeModel> types = new List<TypeModel>();

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                TypeModel type = new TypeModel();
                type.Id = reader.GetInt32(0);
                type.Name = reader.GetString(1);
                type.Notes = reader.IsDBNull(2) ? "" : reader.GetString(2);
                type.Color = ColorTranslator.FromHtml(reader.GetString(3));
                types.Add(type);
            }

            return types;
        }


        public void Add(TypeModel type)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Types (Name, Color) VALUES (@name, @color)";
            command.Parameters.AddWithValue("@name", type.Name);
            command.Parameters.AddWithValue("@color", ColorTranslator.ToHtml(type.Color));
            command.ExecuteNonQuery();
        }


        public void Update(TypeModel type)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "UPDATE Types set Name = @name, Notes = @notes, Color = @color WHERE Id = @id;";
            command.Parameters.AddWithValue("@id", type.Id);
            command.Parameters.AddWithValue("@name", type.Name);
            command.Parameters.AddWithValue("@notes", type.Notes);
            command.Parameters.AddWithValue("@color", (ColorTranslator.ToHtml(type.Color)));
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

            using(var transaction = connection.BeginTransaction())
            {
                try
                {
                    string updateQuery = "UPDATE Tasks SET TypeId = 1 WHERE TypeId = @id";
                    using (var cmd = new SqliteCommand(updateQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    string deleteQuery = "DELETE FROM Types WHERE Id = @id;";
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
