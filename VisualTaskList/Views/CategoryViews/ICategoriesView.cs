using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Views.CategoryViews
{
    public interface ICategoriesView
    {
        /// <summary>
        /// The Id of the selected category.
        /// </summary>
        int SelectedCategoryId { get; }

        /// <summary>
        /// The notes for the selected category.
        /// </summary>
        string SelectedCategoryNotes { get; set; }

        /// <summary>
        /// The event triggered when the user click the Add button.
        /// </summary>
        event EventHandler AddCategoryOverlay;

        /// <summary>
        /// The event triggered when the user click the Update button with a selected category.
        /// </summary>
        event EventHandler UpdateCategoryOverlay;

        /// <summary>
        /// The event triggered when the user click the Delete button with a selected category.
        /// </summary>
        event EventHandler DeleteCategoryEvent;

        /// <summary>
        /// The event triggered when the user select a new category in the listBox.
        /// </summary>
        event EventHandler SelectedCategoryChanged;

        /// <summary>
        /// The event triggered when the user leave the note textBox.
        /// </summary>
        event EventHandler NotesCategoryEvent;

        /// <summary>
        /// Populate the categories list in the view.
        /// </summary>
        /// <param name="categoriesList">The list of categories to add to the display.</param>
        void SetCategoriesList(List<CategoryModel> categoriesList);
    }
}
