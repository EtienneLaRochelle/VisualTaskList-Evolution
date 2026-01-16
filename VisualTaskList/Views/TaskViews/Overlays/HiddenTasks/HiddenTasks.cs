using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualTaskList.Models;

namespace VisualTaskList.Views.TaskViews.Overlays.HiddenTasks
{
    public partial class HiddenTasks : Form, IHiddenTasks
    {
        public int SelectedTaskId => hiddenTasksList.SelectedValue is int id ? id : -1;
        public event EventHandler ShowTaskEvent;

        public HiddenTasks()
        {
            InitializeComponent();
        }


        private void showTasksButton_Click(object sender, EventArgs e)
        {
            ShowTaskEvent?.Invoke(this, EventArgs.Empty);
        }


        public void SetTasksList(List<TaskModel> tasksList)
        {
            int selectedIndex = hiddenTasksList.SelectedIndex;

            hiddenTasksList.DataSource = tasksList;
            hiddenTasksList.DisplayMember = "Title";
            hiddenTasksList.ValueMember = "Id";

            // If the last item of the list is removed, select the new last item before it.
            if (selectedIndex > hiddenTasksList.Items.Count - 1)
            {
                hiddenTasksList.SelectedIndex = hiddenTasksList.Items.Count - 1;
            }

            // Restore previous selection if possible
            else if (selectedIndex != 0)
            {
                hiddenTasksList.SelectedIndex = selectedIndex;
            }
        }


        /// <summary>
        /// Custom drawing for the hidden task list items (Category ShortName - Title - DueDate).
        /// </summary>
        private void hiddenTasksList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var task = (TaskModel)hiddenTasksList.Items[e.Index];

            e.DrawBackground();

            Rectangle textBounds = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            Brush textBrush = (e.State.HasFlag(DrawItemState.Selected)) ? Brushes.White : Brushes.Black;

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString($"{task.Category.ShortName} - {task.Title} - {task.DueDate.ToString("dd MMM")}", e.Font, textBrush, textBounds, format);
            e.DrawFocusRectangle();
        }

    }
}
