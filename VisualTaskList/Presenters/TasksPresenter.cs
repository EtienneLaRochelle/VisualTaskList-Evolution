using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Class;
using VisualTaskList.Models;
using VisualTaskList.Repositories.Task;
using VisualTaskList.Repositories.Type;
using VisualTaskList.Repositories.Category;
using VisualTaskList.Views.TaskViews;
using VisualTaskList.Views.TaskViews.Overlays.AddTask;
using VisualTaskList.Views.TaskViews.Overlays.HiddenTasks;
using VisualTaskList.Views.TaskViews.Overlays.UpdateTask;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VisualTaskList.Presenters
{
    /// <summary>
    /// The "Presenter" for the Tasks View.
    /// Acts as the middleman between the UI (View) and the Data Layer (Repository).
    /// It handles all business logic, such as filtering tasks and formatting data for the UI,
    /// keeping the View "dumb" and strictly focused on display.
    /// </summary>
    internal class TasksPresenter
    {
        private readonly ITasksView _view;
        private readonly ITasksRepository _repository;
        private readonly ITypesRepository _typesRepository;
        private readonly IMainForm _form;
        private readonly ICategoriesRepository _categoriesRepository;

        public TasksPresenter(ITasksView view, IMainForm form, ITasksRepository repository, ITypesRepository typesRepository, ICategoriesRepository categoriesRepository)
        {
            _view = view;
            _repository = repository;
            _form = form;
            _typesRepository = typesRepository;
            _categoriesRepository = categoriesRepository;

            _view.AddTaskOverlay += OnAddTaskOverlay;
            _view.UpdateTaskOverlay += OnUpdateTaskOverlay;
            _view.ShowHiddenTasksOverlay += OnShowHiddenTasksOverlay;
            _view.DeleteTaskEvent += OnDeleteTaskEvent;
            _view.HideTaskEvent += OnHideTaskEvent;
            _view.NotesTaskEvent += OnNotesTaskEvent;
            _view.SelectedTaskChanged += OnSelectedTaskChanged;

            LoadAllTasks();
        }


        public void LoadAllTasks()
        {
            try
            {
                List<TaskModel> tasks = _repository.GetAll();
                List<TaskModel> hiddentasks = _repository.GetAll(true);
                _view.SetTasksList(tasks);
                tasks.AddRange(hiddentasks);
                _form.SetCubeCalender(tasks);
            }
            catch(Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnAddTaskOverlay(object? sender, EventArgs e)
        {
            try
            {
                IAddTask addView = new AddTask();
                addView.SetTypeList(_typesRepository.GetAll(true));
                addView.SetCategoryList(_categoriesRepository.GetAll(true));
                addView.AddTaskEvent += (s, args) =>
                {
                    TaskModel task = new TaskModel
                    {
                        Title = addView.TaskTitle,
                        CategoryId = addView.TaskCategoryId,
                        TypeId = addView.TaskTypeId,
                        DueDate = addView.TaskDueDate,
                        Notes = "",
                        IsHidden = false
                    };
                    _repository.Add(task);
                    LoadAllTasks();
                };
                ((Form)addView).ShowDialog();
            }
            catch(Exception error)
            {
                ErrorManager.Show(error.Message);
            }

        }


        private void OnUpdateTaskOverlay(object? sender, EventArgs e)
        {
            TaskModel task = _repository.GetById(_view.SelectedTaskId);
            if (task == null)
            {
                ErrorManager.Show("Message: Please select a task to update.", Color.Green);
                return;
            }

            try
            {
                IUpdateTask updateView = new UpdateTask(task);
                updateView.SetTypeList(_typesRepository.GetAll(true));
                updateView.SetCategoryList(_categoriesRepository.GetAll(true));
                updateView.UpdateTaskEvent += (s, args) =>
                {
                    task.Title = updateView.TaskTitle;
                    task.CategoryId = updateView.TaskCategoryId;
                    task.TypeId = updateView.TaskTypeId;
                    task.DueDate = updateView.TaskDueDate;
                    _repository.Update(task);
                    LoadAllTasks();
                    ((Form)updateView).Close();
                };
                ((Form)updateView).ShowDialog();
            }
            catch(Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnShowHiddenTasksOverlay(object? sender, EventArgs e)
        {
            try
            {
                IHiddenTasks hiddenTasksView = new HiddenTasks();
                hiddenTasksView.SetTasksList(_repository.GetAll(true));
                hiddenTasksView.ShowTaskEvent += (s, args) =>
                {
                    TaskModel task = _repository.GetById(hiddenTasksView.SelectedTaskId);
                    if (task != null)
                    {
                        task.IsHidden = false;
                        _repository.Update(task);
                        hiddenTasksView.SetTasksList(_repository.GetAll(true));
                        LoadAllTasks();
                    }
                };
                ((Form)hiddenTasksView).ShowDialog();
            }
            catch(Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnDeleteTaskEvent(object? sender, EventArgs e)
        {
            TaskModel task = _repository.GetById(_view.SelectedTaskId);
            if (task == null)
            {
                ErrorManager.Show("Message: Please select a task to delete.", Color.Green);
                return;
            }

            try
            {
                _repository.Delete(task.Id);
                LoadAllTasks();
            }
            catch(Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnHideTaskEvent(object? sender, EventArgs e)
        {
            TaskModel task = _repository.GetById(_view.SelectedTaskId);
            if (task == null)
            {
                ErrorManager.Show("Message: Please select a task to hide.", Color.Green);
                return;
            }

            try
            {
                task.IsHidden = true;
                _repository.Update(task);
                LoadAllTasks();
            }
            catch(Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnNotesTaskEvent(object? sender, EventArgs e)
        {
            try
            {
                TaskModel task = _repository.GetById(_view.SelectedTaskId);

                if(task == null)
                {
                    return;
                }

                task.Notes = _view.SelectedTaskNotes;
                _repository.Update(task);
            }
            catch(Exception error)
            {
                ErrorManager.Show(error.Message);
            }

        }


        private void OnSelectedTaskChanged(object? sender, EventArgs e)
        {
            try
            {
                int id = _view.SelectedTaskId;

                TaskModel task = _repository.GetById(id);
                if (task != null)
                {
                    _view.SelectedTaskNotes = task.Notes;
                    return;
                }
            }
            catch (Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }

    }
}
