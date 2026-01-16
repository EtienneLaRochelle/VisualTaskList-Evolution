using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Repositories.Task
{
    internal interface ITasksRepository
    {
        /// <summary>
        /// Add a new task to the database.
        /// </summary>
        void Add(TaskModel task);

        /// <summary>
        /// Updates a task from the database.
        /// </summary>
        void Update(TaskModel task);

        /// <summary>
        /// Permanently deletes a task from the database.
        /// </summary>
        void Delete(int taskId);

        /// <summary>
        /// Retrieves a single task by its unique ID.
        /// </summary>
        /// <returns>The found TaskModel, or null if no match exists.</returns>
        TaskModel GetById(int taskId);

        /// <summary>
        /// Retrieves a list of tasks based on their <b>hidden</b> status.
        /// </summary>
        /// <param name="showHidden">
        /// If false, returns only <b>Active</b> tasks. 
        /// If true, returns only <b>Hidden</b> tasks.
        /// </param>
        /// <returns>A list of TaskModel objects.</returns>
        List<TaskModel> GetAll(bool showHidden = false);
    }
}
