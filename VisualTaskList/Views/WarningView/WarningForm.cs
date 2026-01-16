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
    public partial class WarningForm : Form
    {
        /// <summary>
        /// Create a warning form with a specified message.
        /// </summary>
        public WarningForm(string message)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            WarningMessage.Text = message;
            this.Icon = SystemIcons.Warning;
        }

        /// <summary>
        /// Close the warning form when the Ok button is clicked.
        /// </summary>
        private void closeWarning_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
