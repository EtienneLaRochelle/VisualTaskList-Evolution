using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualTaskList.Class;
using VisualTaskList.CustomControls;
using VisualTaskList.Models;

namespace VisualTaskList.Views.TypesViews.Overlays.UpdateType
{
    public partial class UpdateType : Form, IUpdateType
    {
        public string TypeName => typeName.Text;
        public Color TypeColor => selectedColor.BackColor;
        public event EventHandler UpdateTypeEvent;

        public UpdateType(TypeModel type)
        {
            InitializeComponent();
            typeName.Text = type.Name;
            selectedColor.BackColor = type.Color;
        }


        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                selectedColor.BackColor = colorDialog1.Color;
            }
        }


        private void UpdateType_Click(object sender, EventArgs e)
        {
            //Prevent to set an empty name to an existing type.
            if (string.IsNullOrWhiteSpace(typeName.Text))
            {
                new WarningForm("Please add a name").ShowDialog(this);
                return;
            }

            //No restrictions on color selection, as the default color is already set.
            //The user may create multiple types with the same color if they wish.

            UpdateTypeEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}