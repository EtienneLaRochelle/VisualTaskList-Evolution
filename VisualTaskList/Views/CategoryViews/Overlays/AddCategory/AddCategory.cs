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

namespace VisualTaskList.Views.CategoryViews.Overlays.AddCategory
{
    public partial class AddCategory : Form, IAddCategory
    {
        public string CategoryName => categoryName.Text;
        public string CategoryShortName => categoryShortName.Text;
        public event EventHandler AddCategoryEvent;

        public AddCategory()
        {
            InitializeComponent();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            //Prevent the creation of categories with empty names.
            if (string.IsNullOrWhiteSpace(categoryName.Text))
            {
                new WarningForm("Please add a name").ShowDialog(this);
                return;
            }

            //Prevent the creation of categories with empty short names (abbreviation).
            if (string.IsNullOrWhiteSpace(categoryShortName.Text))
            {
                new WarningForm("Please add an abbreviation (maximum 4 characters)").ShowDialog(this);
                return;
            }

            AddCategoryEvent.Invoke(this, EventArgs.Empty);
        }
    }
}
