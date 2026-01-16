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
    public partial class ErrorText : UserControl
    {
        public string Text { get => ErrorCode.Text; set => ErrorCode.Text = value; }
        public Color ForeColor { get => ErrorCode.ForeColor; set => ErrorCode.ForeColor = value; }
        public ErrorText()
        {
            InitializeComponent();
        }
    }
}
