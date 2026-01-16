using VisualTaskList.Class;
using VisualTaskList.Presenters;
using VisualTaskList.Repositories.Task;
using VisualTaskList.Repositories.Type;
using VisualTaskList.Repositories.Category;

namespace VisualTaskList
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            string ConnectionString = "Data Source=VisualTaskList.db;";

            InitDatabase.Initialize(ConnectionString);
            TasksRepository taskRepository = new TasksRepository(ConnectionString);
            TypesRepository typeRepository = new TypesRepository(ConnectionString);
            CategoriesRepository categoryRepository = new CategoriesRepository(ConnectionString);

            MainForm mainForm = new MainForm();

            TasksPresenter tasksPresenter = new TasksPresenter(mainForm.TasksView, mainForm, taskRepository, typeRepository, categoryRepository);
            TypesPresenter typesPresenter = new TypesPresenter(mainForm.TypesView, mainForm, typeRepository, taskRepository);
            CategoriesPresenter categoriesPresenter = new CategoriesPresenter(mainForm.CategoriesView, mainForm, categoryRepository);

            categoriesPresenter.CategoryUpdated += (s, e) => tasksPresenter.LoadAllTasks();

            Application.Run(mainForm);
        }
    }
}