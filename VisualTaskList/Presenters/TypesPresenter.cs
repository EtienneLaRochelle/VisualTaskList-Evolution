using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Class;
using VisualTaskList.Models;
using VisualTaskList.Repositories.Task;
using VisualTaskList.Repositories.Type;
using VisualTaskList.Views.TypesViews;
using VisualTaskList.Views.TypesViews.Overlays.AddType;
using VisualTaskList.Views.TypesViews.Overlays.UpdateType;

namespace VisualTaskList.Presenters
{
    /// <summary>
    /// The "Presenter" for the Types View.
    /// Acts as the middleman between the UI (View) and the Data Layer (Repository).
    /// It handles all business logic, such as filtering types and formatting data for the UI,
    /// keeping the View "dumb" and strictly focused on display.
    /// </summary>
    internal class TypesPresenter
    {
        private readonly ITypesView _view;
        private readonly ITypesRepository _repository;
        private readonly ITasksRepository _tasksRepository;
        private readonly IMainForm _form;

        public TypesPresenter(ITypesView view, IMainForm form, ITypesRepository repository, ITasksRepository tasksRepository)
        {
            _view = view;
            _repository = repository;
            _form = form;
            _tasksRepository = tasksRepository;

            _view.AddTypeOverlay += OnAddTypeOverlay;
            _view.UpdateTypeOverlay += OnUpdateTypeOverlay;
            _view.DeleteTypeEvent += OnDeleteTypeEvent;
            _view.NotesTypeEvent += OnNotesTypeEvent;
            _view.SelectedTypeChanged += OnSelectedTypeChanged;

            LoadAllTypes();
        }


        private void LoadAllTypes()
        {
            try
            {
                var types = _repository.GetAll();
                _view.SetTypesList(types);
                _form.SetLegendLabels(types);

                List<TaskModel> tasks = _tasksRepository.GetAll();
                List<TaskModel> hiddentasks = _tasksRepository.GetAll(true);
                tasks.AddRange(hiddentasks);
                _form.SetCubeCalender(tasks);
            }
            catch (Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnAddTypeOverlay(object sender, EventArgs e)
        {
            try
            {
                IAddType addView = new AddType();
                addView.AddTypeEvent += (s, args) =>
                {
                    TypeModel type = new TypeModel();
                    type.Name = addView.TypeName;
                    type.Color = addView.TypeColor;
                    _repository.Add(type);
                    LoadAllTypes();
                    ((Form)addView).Close();
                };
                ((Form)addView).ShowDialog();
            }
            catch(Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnUpdateTypeOverlay(object sender, EventArgs e)
        {
            TypeModel type = _repository.GetById(_view.SelectedTypeId);
            if (type == null)
            {
                ErrorManager.Show("Message: Please select a type to update.", Color.Green);
                return;
            }

            try
            {
                IUpdateType updateView = new UpdateType(type);
                updateView.UpdateTypeEvent += (s, args) =>
                {
                    type.Name = updateView.TypeName;
                    type.Color = updateView.TypeColor;
                    _repository.Update(type);
                    LoadAllTypes();
                    ((Form)updateView).Close();
                };
                ((Form)updateView).ShowDialog();
            }
            catch(Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnDeleteTypeEvent(object? sender, EventArgs e)
        {
            TypeModel type = _repository.GetById(_view.SelectedTypeId);
            if (type == null)
            {
                ErrorManager.Show("Message: Please select a type to delete.", Color.Green);
                return;
            }

            try
            {
                _repository.Delete(type.Id);
                LoadAllTypes();
            }
            catch (Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnNotesTypeEvent(object? sender, EventArgs e)
        {
            try
            {
                TypeModel type = _repository.GetById(_view.SelectedTypeId);
                if (type == null)
                {
                    return;
                }

                type.Notes = _view.SelectedTypeNotes;
                _repository.Update(type);
            }
            catch (Exception error)
            {
                ErrorManager.Show(error.Message);
            }

        }


        private void OnSelectedTypeChanged(object? sender, EventArgs e)
        {
            try
            {
                int id = _view.SelectedTypeId;

                if (id == -1)
                {
                    _view.SelectedTypeNotes = "";
                    return;
                }

                TypeModel type = _repository.GetById(id);
                if (type != null)
                {
                    _view.SelectedTypeNotes = _repository.GetById(_view.SelectedTypeId).Notes;
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
