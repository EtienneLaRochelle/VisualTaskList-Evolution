using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using VisualTaskList;
using VisualTaskList.Class;
using VisualTaskList.CustomControls;
using VisualTaskList.Models;
using VisualTaskList.Views.TaskViews;
using VisualTaskList.Views.TypesViews;
using VisualTaskList.Views.CategoryViews;
using static System.Net.Mime.MediaTypeNames;

namespace VisualTaskList
{
    public partial class MainForm : Form, IMainForm
    {
        public ITasksView TasksView => tasksView;
        public ITypesView TypesView => typesView;
        public ICategoriesView CategoriesView => categoriesView;

        public MainForm()
        {
            InitializeComponent();

            ErrorManager.ShowErrorAction = (error, color) =>
            {
                ErrorText.Text = error;
                ErrorText.ForeColor = color;
            };
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            this.ActiveControl = null;
        }


        public void SetLegendLabels(List<TypeModel> types)
        {
            this.cubeCalendar1.LegendPanel.Controls.Clear();
            foreach (TypeModel type in types)
            {
                LegendLabel legendLabel = new LegendLabel(type.Color, type.Name);
                this.cubeCalendar1.LegendPanel.Controls.Add(legendLabel);
            }
        }


        public void SetCubeCalender(List<TaskModel> tasks)
        {
            var today = DateTime.Today;

            var dailyGroups = tasks
                .Select(t => new
                {
                    Task = t,
                    Offset = (int)(t.DueDate.Date - today).TotalDays
                })
                .Where(x => x.Offset >= 0 && x.Offset < CubeCalendar.DayPanelLength)
                .GroupBy(x => x.Offset)
                .ToDictionary(g => g.Key, g => g.ToList());

            for (int i = 0; i < CubeCalendar.DayPanelLength; i++)
            {
                List<Color> colorsForToday = new List<Color>();

                if (dailyGroups.ContainsKey(i))
                {
                    // Extract colors if tasks exist
                    colorsForToday = dailyGroups[i]
                        .Select(x => x.Task.Type?.Color ?? Color.Gray)
                        .ToList();
                }

                this.cubeCalendar1.SetDayColor(i, colorsForToday);
            }
        }

    }
}
    