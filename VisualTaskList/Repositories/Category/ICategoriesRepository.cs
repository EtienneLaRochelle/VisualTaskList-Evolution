using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Repositories.Category
{
    internal interface ICategoriesRepository
    {
        /// <summary>
        /// Add a new category to the database.
        /// </summary>
        void Add(CategoryModel category);

        /// <summary>
        /// Updates a category from the database.
        /// </summary>
        void Update(CategoryModel category);

        /// <summary>
        /// Permanently deletes a category from the database.
        /// <para>
        /// <b>Warning:</b> Reassigns all tasks in this category to 'None' (ID 1) before deletion.
        /// </para>
        /// </summary>
        void Delete(int categoryId);

        /// <summary>
        /// Retrieves a single category by its unique ID.
        /// </summary>
        /// <returns>The found CategoryModel, or null if no match exists.</returns>
        CategoryModel GetById(int categoryId);

        /// <summary>
        /// Retrieves a list of all available categories.
        /// </summary>
        /// <param name="includeNone">If true, includes the system default 'None' (ID 1) category.</param>
        /// <returns>A list of CategoryModel objects.</returns>
        List<CategoryModel> GetAll(bool includeNone = false);
    }
}
