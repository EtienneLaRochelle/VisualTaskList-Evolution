using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualTaskList.Models;

namespace VisualTaskList.Views.TaskViews
{
    public partial class TasksView : UserControl, ITasksView
    {
        public int SelectedTaskId => taskList.SelectedValue is int id ? id : -1;
        public string SelectedTaskNotes { get => taskNotes.Text; set => taskNotes.Text = value; }
        public event EventHandler AddTaskOverlay;
        public event EventHandler UpdateTaskOverlay;
        public event EventHandler DeleteTaskEvent;
        public event EventHandler HideTaskEvent;
        public event EventHandler NotesTaskEvent;
        public event EventHandler SelectedTaskChanged;
        public event EventHandler ShowHiddenTasksOverlay;

        public TasksView()
        {
            InitializeComponent();
        }


        private void taskAdd_Click(object sender, EventArgs e)
        {
            AddTaskOverlay?.Invoke(this, EventArgs.Empty);
        }


        private void taskUpdate_Click(object sender, EventArgs e)
        {
            UpdateTaskOverlay?.Invoke(this, EventArgs.Empty);
        }


        private void showHiddenTasks_Click(object sender, EventArgs e)
        {
            ShowHiddenTasksOverlay?.Invoke(this, EventArgs.Empty);
        }


        private void taskDelete_Click(object sender, EventArgs e)
        {
            DeleteTaskEvent?.Invoke(this, EventArgs.Empty);
        }


        private void taskHide_Click(object sender, EventArgs e)
        {
            HideTaskEvent?.Invoke(this, EventArgs.Empty);
        }


        private void taskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTaskChanged?.Invoke(this, EventArgs.Empty);
        }


        private void taskNotes_Leave(object sender, EventArgs e)
        {
            NotesTaskEvent?.Invoke(this, EventArgs.Empty);
        }


        public void SetTasksList(List<TaskModel> tasksList)
        {
            int selectedIndex = taskList.SelectedIndex;

            taskList.DataSource = tasksList;
            taskList.DisplayMember = "Title";
            taskList.ValueMember = "Id";

            // Stop displaying notes if there are no tasks
            if (tasksList.Count() == 0)
            {
                taskNotes.Text = "";
                return;
            }

            // If the last item of the list is removed, select the new last item before it.
            if (selectedIndex > taskList.Items.Count - 1)
            {
                taskList.SelectedIndex = taskList.Items.Count - 1;
            }

            // Restore previous selection if possible
            else if (selectedIndex != 0)
            {
                taskList.SelectedIndex = selectedIndex;
            }

            UpdateListWidth(tasksList);
        }


        /// <summary>
        /// Custom drawing for the task list items (Category ShortName - Title - DueDate).
        /// </summary>
        private void taskList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var task = (TaskModel)taskList.Items[e.Index];

            e.DrawBackground();

            Rectangle textBounds = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            Brush textBrush = (e.State.HasFlag(DrawItemState.Selected)) ? Brushes.White : Brushes.Black;

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString($"{task.Category.ShortName} - {task.Title} - {task.DueDate.ToString("dd MMM")}", e.Font, textBrush, textBounds, format);
            e.DrawFocusRectangle();
        }


        private void UpdateListWidth(List<TaskModel> tasks)
        {
            taskList.HorizontalScrollbar = true;
            int maxPixelWidth = 0;

            using (Graphics g = taskList.CreateGraphics())
            {
                foreach (var task in tasks)
                {
                    string fullText = $"{task.Category.ShortName} - {task.Title} - {task.DueDate.ToString("dd MMM")}";
                    int itemWidth = (int)g.MeasureString(fullText, taskList.Font).Width;
                    if (itemWidth > maxPixelWidth)
                    {
                        maxPixelWidth = itemWidth;
                    }
                }
            }

            taskList.HorizontalExtent = maxPixelWidth + 10;
        }

    }
}
