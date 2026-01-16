using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTaskList.Models;

namespace VisualTaskList.Views.TypesViews
{
    public interface ITypesView
    {
        /// <summary>
        /// The Id of the selected type.
        /// </summary>
        int SelectedTypeId { get; }

        /// <summary>
        /// The notes for the selected type.
        /// </summary>
        string SelectedTypeNotes { get; set; }

        /// <summary>
        /// The event triggered when the user click the Add button.
        /// </summary>
        event EventHandler AddTypeOverlay;

        /// <summary>
        /// The event triggered when the user click the Update button with a selected type.
        /// </summary>
        event EventHandler UpdateTypeOverlay;

        /// <summary>
        /// The event triggered when the user click the Delete button with a selected type.
        /// </summary>
        event EventHandler DeleteTypeEvent;

        /// <summary>
        /// The event triggered when the user leave the note textBox.
        /// </summary>
        event EventHandler NotesTypeEvent;

        /// <summary>
        /// The event triggered when the user select a new type in the listBox.
        /// </summary>
        event EventHandler SelectedTypeChanged;

        /// <summary>
        /// Populate the types list in the view.
        /// </summary>
        /// <param name="typesList">The list of types to add to the display.</param>
        void SetTypesList(List<TypeModel> typesList);
    }
}
