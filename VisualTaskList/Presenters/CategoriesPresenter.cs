using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Class;
using VisualTaskList.Models;
using VisualTaskList.Repositories.Task;
using VisualTaskList.Repositories.Type;
using VisualTaskList.Repositories.Category;
using VisualTaskList.Views.CategoryViews;
using VisualTaskList.Views.CategoryViews.Overlays.AddCategory;
using VisualTaskList.Views.CategoryViews.Overlays.UpdateCategory;

namespace VisualTaskList.Presenters
{
    /// <summary>
    /// The "Presenter" for the Categories View.
    /// Acts as the middleman between the UI (View) and the Data Layer (Repository).
    /// It handles all business logic, such as filtering categories and formatting data for the UI,
    /// keeping the View "dumb" and strictly focused on display.
    /// </summary>
    internal class CategoriesPresenter
    {
        private readonly ICategoriesView _view;
        private readonly ICategoriesRepository _repository;
        private readonly IMainForm _form;
        public event EventHandler CategoryUpdated;

        public CategoriesPresenter(ICategoriesView view, IMainForm form, ICategoriesRepository repository)
        {
            _view = view;
            _form = form;
            _repository = repository;

            _view.AddCategoryOverlay += OnAddCategoryOverlay;
            _view.UpdateCategoryOverlay += OnUpdateCategoryOverlay;
            _view.DeleteCategoryEvent += OnDeleteCategoryEvent;
            _view.NotesCategoryEvent += OnNotesCategoryEvent;
            _view.SelectedCategoryChanged += OnSelectedCategoryChanged;

            LoadAllCategories();
        }


        private void LoadAllCategories()
        {
            try
            {
                var categories = _repository.GetAll();
                _view.SetCategoriesList(categories);
            }
            catch (Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnAddCategoryOverlay(object sender, EventArgs e)
        {
            try
            {
                IAddCategory addView = new AddCategory();
                addView.AddCategoryEvent += (s, args) =>
                {
                    CategoryModel category = new CategoryModel();
                    category.Name = addView.CategoryName;
                    category.ShortName = addView.CategoryShortName;
                    _repository.Add(category);
                    LoadAllCategories();
                    ((Form)addView).Close();
                };
                ((Form)addView).ShowDialog();
            }
            catch (Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnUpdateCategoryOverlay(object sender, EventArgs e)
        {
            CategoryModel category = _repository.GetById(_view.SelectedCategoryId);
            if (category == null)
            {
                ErrorManager.Show("Message: Please select a category to update.", Color.Green);
                return;
            }

            try
            {
                IUpdateCategory updateView = new UpdateCategory(category);
                updateView.UpdateCategoryEvent += (s, args) =>
                {
                    category.Name = updateView.CategoryName;
                    category.ShortName = updateView.CategoryShortName;
                    _repository.Update(category);
                    LoadAllCategories();
                    CategoryUpdated?.Invoke(this, EventArgs.Empty);
                    ((Form)updateView).Close();
                };
                ((Form)updateView).ShowDialog();
            }
            catch (Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnDeleteCategoryEvent(object? sender, EventArgs e)
        {
            CategoryModel category = _repository.GetById(_view.SelectedCategoryId);
            if (category == null)
            {
                ErrorManager.Show("Message: Please select a category to delete.", Color.Green);
                return;
            }

            try
            {
                _repository.Delete(category.Id);
                LoadAllCategories();
            }
            catch (Exception error)
            {
                ErrorManager.Show(error.Message);
            }
        }


        private void OnNotesCategoryEvent(object? sender, EventArgs e)
        {
            try
            {
                CategoryModel category = _repository.GetById(_view.SelectedCategoryId);
                if (category == null)
                {
                    return;
                }

                category.Notes = _view.SelectedCategoryNotes;
                _repository.Update(category);
            }
            catch (Exception error)
            {
                ErrorManager.Show(error.Message);
            }

        }


        private void OnSelectedCategoryChanged(object? sender, EventArgs e)
        {
            try
            {
                int id = _view.SelectedCategoryId;
                if (id == -1)
                {
                    _view.SelectedCategoryNotes = "";
                    return;
                }

                CategoryModel category = _repository.GetById(id);
                if (category != null)
                {
                    _view.SelectedCategoryNotes = _repository.GetById(_view.SelectedCategoryId).Notes;
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
