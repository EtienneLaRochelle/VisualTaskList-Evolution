using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualTaskList.Views.TypesViews.Overlays.AddType
{
    internal interface IAddType
    {
        /// <summary>
        /// The name of the new type.
        /// </summary>
        string TypeName { get; }

        /// <summary>
        /// The color associated with the new type.
        /// </summary>
        Color TypeColor { get; }

        /// <summary>
        /// The event triggered when the user click the Add button.
        /// </summary>
        event EventHandler AddTypeEvent;
    }
}
