using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualTaskList.Views.CategoryViews.Overlays.UpdateCategory
{
    internal interface IUpdateCategory
    {
        /// <summary>
        /// The name of the category to update.
        /// </summary>
        string CategoryName { get; }

        /// <summary>
        /// The short name (abbreviation) of the category to update.
        /// </summary>
        string CategoryShortName { get; }

        /// <summary>
        /// The event triggered when the user click the Update button.
        /// </summary>
        event EventHandler UpdateCategoryEvent;
    }
}
