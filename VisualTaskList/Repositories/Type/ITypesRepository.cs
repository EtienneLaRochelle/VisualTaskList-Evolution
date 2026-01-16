using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Repositories.Type
{
    internal interface ITypesRepository
    {
        /// <summary>
        /// Add a new type to the database.
        /// </summary>
        void Add(TypeModel type);

        /// <summary>
        /// Updates a type from the database.
        /// </summary>
        void Update(TypeModel type);

        /// <summary>
        /// Permanently deletes a type from the database.
        /// <para>
        /// <b>Warning:</b> Reassigns all tasks with this Type to 'None' (ID 1) before deletion to prevent data loss.
        /// </para>
        /// </summary>
        void Delete(int typeId);

        /// <summary>
        /// Retrieves a single type by its unique ID.
        /// </summary>
        /// <returns>The found TypeModel, or null if no match exists.</returns>
        TypeModel GetById(int typeId);

        /// <summary>
        /// Retrieves a list of types.
        /// </summary>
        /// <param name="includeNone">
        /// If false, returns the list excluding the default (None) type. 
        /// If true, includes the default (None) type.
        /// </param>
        /// <returns>A list of TypeModel objects.</returns>
        List<TypeModel> GetAll(bool includeNone = false);
    }
}
