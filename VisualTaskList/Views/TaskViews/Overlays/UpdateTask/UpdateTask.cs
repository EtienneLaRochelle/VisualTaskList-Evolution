using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualTaskList.Models;
using VisualTaskList.CustomControls;

namespace VisualTaskList.Views.TaskViews.Overlays.UpdateTask
{
    public partial class UpdateTask : Form, IUpdateTask
    {
        public string TaskTitle => taskTitle.Text;
        public int TaskCategoryId => (int)taskCategory.SelectedValue;
        public int TaskTypeId => (int)taskTypeId.SelectedValue;
        internal int _selectedTypeId;
        internal int _selectedCategoryId;
        public DateTime TaskDueDate => taskDueDate.Value;
        public event EventHandler UpdateTaskEvent;

        public UpdateTask(TaskModel task)
        {
            InitializeComponent();
            taskTitle.Text = task.Title;
            _selectedTypeId = task.TypeId;
            _selectedCategoryId = task.CategoryId;
            taskDueDate.Value = task.DueDate;
        }


        private void updateTaskButton_Click(object sender, EventArgs e)
        {
            //Prevent to set an empty task title to an existing task.  
            if (string.IsNullOrWhiteSpace(taskTitle.Text))
            {
                new WarningForm("Please add a title").ShowDialog(this);
                return;
            }

            //The lists of types and categories are always prepopulated with at least one entry therefore no checks are necessary.

            UpdateTaskEvent?.Invoke(this, EventArgs.Empty);
        }


        public void SetTypeList(List<TypeModel> typesList)
        {
            taskTypeId.Items.Clear();
            taskTypeId.DataSource = typesList;
            taskTypeId.DisplayMember = "Name";
            taskTypeId.ValueMember = "Id";
            taskTypeId.SelectedValue = _selectedTypeId;
        }


        public void SetCategoryList(List<CategoryModel> categoriesList)
        {
            taskCategory.Items.Clear();
            taskCategory.DataSource = categoriesList;
            taskCategory.DisplayMember = "Name";
            taskCategory.ValueMember = "Id";
            taskCategory.SelectedValue = _selectedCategoryId;
        }

    }
}
