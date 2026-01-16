using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Views.CategoryViews.Overlays.AddCategory
{
    internal interface IAddCategory
    {
        /// <summary>
        /// The name of the new category.
        /// </summary>
        string CategoryName { get; }

        /// <summary>
        /// The short name (abbreviation) of the new category.
        /// </summary>
        string CategoryShortName { get; }

        /// <summary>
        /// The event triggered when the user click the Add button.
        /// </summary>
        event EventHandler AddCategoryEvent;
    }
}
