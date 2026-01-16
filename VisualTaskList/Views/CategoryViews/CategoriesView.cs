using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualTaskList.Models;

namespace VisualTaskList.Views.CategoryViews
{
    public partial class CategoriesView : UserControl, ICategoriesView
    {
        public int SelectedCategoryId => categoryList.SelectedValue is int id ? id : -1;
        public string SelectedCategoryNotes { get => categoryNotes.Text; set => categoryNotes.Text = value; }
        public event EventHandler AddCategoryOverlay;
        public event EventHandler UpdateCategoryOverlay;
        public event EventHandler DeleteCategoryEvent;
        public event EventHandler SelectedCategoryChanged;
        public event EventHandler NotesCategoryEvent;

        public CategoriesView()
        {
            InitializeComponent();
        }


        private void categoryAdd_Click(object sender, EventArgs e)
        {
            AddCategoryOverlay?.Invoke(this, EventArgs.Empty);
        }


        private void categoryUpdate_Click(object sender, EventArgs e)
        {
            UpdateCategoryOverlay?.Invoke(this, EventArgs.Empty);
        }


        private void categoryDelete_Click(object sender, EventArgs e)
        {
            DeleteCategoryEvent?.Invoke(this, EventArgs.Empty);
        }


        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCategoryChanged?.Invoke(this, EventArgs.Empty);
        }

        private void categoryNotes_Leave(object sender, EventArgs e)
        {
            NotesCategoryEvent?.Invoke(this, EventArgs.Empty);
        }


        public void SetCategoriesList(List<CategoryModel> categoriesList)
        {
            int selectedIndex = categoryList.SelectedIndex;

            categoryList.DataSource = categoriesList;
            categoryList.DisplayMember = "Title";
            categoryList.ValueMember = "Id";

            // If the last item of the list is removed, select the new last item before it.
            if (selectedIndex > categoryList.Items.Count - 1)
            {
                categoryList.SelectedIndex = categoryList.Items.Count - 1;
            }

            // Restore previous selection if possible
            else if (selectedIndex != 0)
            {
                categoryList.SelectedIndex = selectedIndex;
            }
        }


        /// <summary>
        /// Custom drawing for the category list items (ShortName - Name).
        /// </summary>
        private void categoryList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var category = (CategoryModel)categoryList.Items[e.Index];

            e.DrawBackground();

            Rectangle textBounds = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            Brush textBrush = (e.State.HasFlag(DrawItemState.Selected)) ? Brushes.White : Brushes.Black;

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString($"{category.ShortName} - {category.Name}", e.Font, textBrush, textBounds, format);
            e.DrawFocusRectangle();
        }

    }
}
