using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualTaskList.Class
{
    public static class InitDatabase
    {
        /// <summary>
        /// Initializes the SQLite database schema if it does not exist.
        /// It also seeds the database with default "None" values (ID 1) for Categories and Types
        /// to ensure the application is immediately usable without manual setup.
        /// </summary>
        public static void Initialize(string connectionString)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using (var transaction = connection.BeginTransaction())
            {
                string CreateTypesTable =
                    "CREATE TABLE IF NOT EXISTS Types (\n" +
                        "Id INTEGER PRIMARY KEY AUTOINCREMENT, \n" +
                        "Name TEXT NOT NULL,\n" +
                        "Notes TEXT DEFAULT null,\n" +
                        "Color TEXT NOT NULL\n" +
                    ");";
                using (var cmd = new SqliteCommand(CreateTypesTable, connection, transaction))
                {
                    cmd.ExecuteNonQuery();
                }

                string CreateDefaultType = $"INSERT OR IGNORE INTO Types (Id, Name, Color) VALUES (1, 'None', '{ColorTranslator.ToHtml(Color.LightGray)}');";
                using (var cmd = new SqliteCommand(CreateDefaultType, connection, transaction))
                {
                    cmd.ExecuteNonQuery();
                }


                string CreateCategoryTable =
                "CREATE TABLE IF NOT EXISTS Categories (\n" +
                    "Id INTEGER PRIMARY KEY AUTOINCREMENT, \n" +
                    "Name TEXT NOT NULL,\n" +
                    "ShortName TEXT NOT NULL CHECK(length(ShortName) <= 4),\n" +
                    "Notes TEXT DEFAULT null\n" +
                ");";
                using (var cmd = new SqliteCommand(CreateCategoryTable, connection, transaction))
                {
                    cmd.ExecuteNonQuery();
                }

                string CreateDefaultCategory = $"INSERT OR IGNORE INTO Categories (Id, Name, ShortName) VALUES (1, 'None', 'NONE');";
                using (var cmd = new SqliteCommand(CreateDefaultCategory, connection, transaction))
                {
                    cmd.ExecuteNonQuery();
                }


                string CreateTasksTable =
                    "CREATE TABLE IF NOT EXISTS Tasks (\n" +
                        "Id INTEGER PRIMARY KEY AUTOINCREMENT, \n" +
                        "Title TEXT NOT NULL,\n" +
                        "CategoryId INTEGER DEFAULT 1,\n" +
                        "TypeId INTEGER DEFAULT 1,\n" +
                        "Notes TEXT DEFAULT null,\n" +
                        "DueDate TEXT,\n" +
                        "IsHidden INTEGER DEFAULT 0,\n" +
                        "FOREIGN KEY(TypeId) REFERENCES Types(Id)\n" +
                    ");";
                using (var cmd = new SqliteCommand(CreateTasksTable, connection, transaction))
                {
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
        }

    }
}
