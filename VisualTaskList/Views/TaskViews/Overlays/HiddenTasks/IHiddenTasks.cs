using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Views.TaskViews.Overlays.HiddenTasks
{
    internal interface IHiddenTasks
    {
        /// <summary>
        /// The Id of the selected task.
        /// </summary>
        int SelectedTaskId { get; }

        /// <summary>
        /// The event triggered when the user click the Show button with a selected task.
        /// </summary>
        event EventHandler ShowTaskEvent;

        /// <summary>
        /// Populate the tasks list with all the hidden tasks.
        /// </summary>
        /// <param name="tasksList">The list of all the hidden tasks.</param>
        void SetTasksList(List<TaskModel> tasksList);
    }
}
