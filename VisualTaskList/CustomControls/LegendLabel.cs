using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTaskList.CustomControls
{
    /// <summary>
    /// Create a legend label composed of a colored square and a text label.
    /// </summary>
    public partial class LegendLabel : UserControl
    {
        public LegendLabel(Color color, string text)
        {
            InitializeComponent();
            Color.BackColor = color;
            Label.Text = text;
        }
    }
}
