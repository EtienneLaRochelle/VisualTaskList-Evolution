using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualTaskList.CustomControls;
using VisualTaskList.Models;

namespace VisualTaskList.Views.TaskViews.Overlays.AddTask
{
    public partial class AddTask : Form, IAddTask
    {
        public string TaskTitle => taskTitle.Text;
        public int TaskCategoryId => (int)taskCategory.SelectedValue;
        public int TaskTypeId => (int)taskTypeId.SelectedValue;
        public DateTime TaskDueDate => taskDueDate.Value;
        public event EventHandler AddTaskEvent;


        public AddTask()
        {
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            //Prevent the creation of tasks with empty titles.
            if (string.IsNullOrWhiteSpace(taskTitle.Text))
            {
                new WarningForm("Please add a title").ShowDialog(this);
                return;
            }

            //The lists of types and categories are always prepopulated with at least one entry therefore no checks are necessary.

            AddTaskEvent?.Invoke(this, EventArgs.Empty);
        }


        public void SetTypeList(List<TypeModel> typesList)
        {
            taskTypeId.Items.Clear();
            taskTypeId.DataSource = typesList;
            taskTypeId.DisplayMember = "Name";
            taskTypeId.ValueMember = "Id";
            taskTypeId.SelectedIndex = 0;
        }


        public void SetCategoryList(List<CategoryModel> categoriesList)
        {
            taskCategory.Items.Clear();
            taskCategory.DataSource = categoriesList;
            taskCategory.DisplayMember = "Name";
            taskCategory.ValueMember = "Id";
            taskCategory.SelectedIndex = 0;
        }

    }
}
