using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Views.TaskViews.Overlays.AddTask
{
    internal interface IAddTask
    {
        /// <summary>
        /// The title of the task to add.
        /// </summary>
        string TaskTitle { get; }

        /// <summary>
        /// The Id of the category to add the task to.
        /// </summary>
        int TaskCategoryId { get; }

        /// <summary>
        /// The Id of the type to add the task to.
        /// </summary>
        int TaskTypeId { get; }

        /// <summary>
        /// The due date of the task to add.
        /// </summary>
        DateTime TaskDueDate { get; }

        /// <summary>
        /// The event triggered when the user click the Add button.
        /// </summary>
        event EventHandler AddTaskEvent;

        /// <summary>
        /// Populate the types list to allow the selection of a type for the new task.
        /// </summary>
        /// <param name="typesList">The list of existing types.</param>
        void SetTypeList(List<TypeModel> typesList);

        /// <summary>
        /// Populate the categories list to allow the selection of a category for the new task.
        /// </summary>
        /// <param name="categoriesList">The list of existing categories.</param>
        void SetCategoryList(List<CategoryModel> categoriesList);
    }
}
