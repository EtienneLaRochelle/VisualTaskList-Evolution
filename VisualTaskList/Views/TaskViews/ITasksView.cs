using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Views.TaskViews
{
    public interface ITasksView
    {
        /// <summary>
        /// The Id of the selected task.
        /// </summary>
        int SelectedTaskId { get; }

        /// <summary>
        /// The notes for the selected task.
        /// </summary>
        string SelectedTaskNotes { get; set; }

        /// <summary>
        /// The event triggered when the user click the Add button.
        /// </summary>
        event EventHandler AddTaskOverlay;

        /// <summary>
        /// The event triggered when the user click the Update button with a selected task.
        /// </summary>
        event EventHandler UpdateTaskOverlay;

        /// <summary>
        /// The event triggered when the user click the show hidden tasks button.
        /// </summary>
        event EventHandler ShowHiddenTasksOverlay;

        /// <summary>
        /// The event triggered when the user click the Delete button with a selected task.
        /// </summary>
        event EventHandler DeleteTaskEvent;

        /// <summary>
        /// The event triggered when the user click the Hide button with a selected task.
        /// </summary>
        event EventHandler HideTaskEvent;

        /// <summary>
        /// The event triggered when the user leave the note textBox.
        /// </summary>
        event EventHandler NotesTaskEvent;

        /// <summary>
        /// The event triggered when the user select a new task in the listBox.
        /// </summary>
        event EventHandler SelectedTaskChanged;

        /// <summary>
        /// Populate the tasks list in the view.
        /// </summary>
        /// <param name="tasksList">The list of tasks to add to the display.</param>
        void SetTasksList(List<TaskModel> tasksList);
    }
}
