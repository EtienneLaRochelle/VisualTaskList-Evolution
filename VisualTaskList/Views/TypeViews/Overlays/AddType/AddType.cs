using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualTaskList.CustomControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VisualTaskList.Views.TypesViews.Overlays.AddType
{
    public partial class AddType : Form, IAddType
    {
        public string TypeName => typeName.Text;
        public Color TypeColor => selectedColor.BackColor;
        public event EventHandler AddTypeEvent;

        public AddType()
        {
            InitializeComponent();
        }


        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                selectedColor.BackColor = colorDialog.Color;
            }
        }


        private void AddType_Click(object sender, EventArgs e)
        {
            //Prevent the creation of types with empty names.
            if (string.IsNullOrWhiteSpace(typeName.Text))
            {
                new WarningForm("Please add a name").ShowDialog(this);
                return;
            }

            //No restrictions on color selection, as the default color is already set.
            //The user may create multiple types with the same color if they wish.

            AddTypeEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
