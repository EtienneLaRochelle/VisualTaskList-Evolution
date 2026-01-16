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
using VisualTaskList.Models;

namespace VisualTaskList.Views.CategoryViews.Overlays.UpdateCategory
{
    public partial class UpdateCategory : Form, IUpdateCategory
    {
        public string CategoryName => categoryName.Text;
        public string CategoryShortName => categoryShortName.Text;
        public event EventHandler UpdateCategoryEvent;

        public UpdateCategory(CategoryModel category)
        {
            InitializeComponent();

            //Initialize the text boxes with the current category values.
            categoryName.Text = category.Name;
            categoryShortName.Text = category.ShortName;
        }


        private void updateCategoryButton_Click(object sender, EventArgs e)
        {
            //Prevent to set an empty name to an existing category.
            if (string.IsNullOrWhiteSpace(categoryName.Text))
            {
                new WarningForm("Please add a name").ShowDialog(this);
                return;
            }

            //Prevent to set an empty abbreviation (short name) to an existing category.
            if (string.IsNullOrWhiteSpace(categoryShortName.Text))
            {
                new WarningForm("Please add an abbreviation (maximum 4 characters)").ShowDialog(this);
                return;
            }

            UpdateCategoryEvent?.Invoke(this, EventArgs.Empty);
        }

    }
}
