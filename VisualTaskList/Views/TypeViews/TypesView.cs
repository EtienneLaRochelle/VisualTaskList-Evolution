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

namespace VisualTaskList.Views.TypesViews
{
    public partial class TypesView : UserControl, ITypesView
    {
        public int SelectedTypeId => typeList.SelectedValue is int id ? id : -1;
        public string SelectedTypeNotes { get => typeNotes.Text; set => typeNotes.Text = value; }
        public event EventHandler AddTypeOverlay;
        public event EventHandler UpdateTypeOverlay;
        public event EventHandler DeleteTypeEvent;
        public event EventHandler NotesTypeEvent;
        public event EventHandler SelectedTypeChanged;

        public TypesView()
        {
            InitializeComponent();
        }


        private void typeAdd_Click(object sender, EventArgs e)
        {
            AddTypeOverlay?.Invoke(this, EventArgs.Empty);
        }


        private void TypeUpdate_Click(object sender, EventArgs e)
        {
            UpdateTypeOverlay?.Invoke(this, EventArgs.Empty);
        }


        private void TypeDelete_Click(object sender, EventArgs e)
        {
            DeleteTypeEvent?.Invoke(this, EventArgs.Empty);
        }


        private void TypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTypeChanged?.Invoke(this, EventArgs.Empty);
        }


        private void TypeNotes_Leave(object sender, EventArgs e)
        {
            NotesTypeEvent?.Invoke(this, EventArgs.Empty);
        }


        public void SetTypesList(List<TypeModel> TypesList)
        {
            int selectedIndex = typeList.SelectedIndex;

            typeList.DataSource = TypesList;
            typeList.DisplayMember = "Name";
            typeList.ValueMember = "Id";

            // If the last item of the list is removed, select the new last item before it.
            if (selectedIndex > typeList.Items.Count - 1)
            {
                typeList.SelectedIndex = typeList.Items.Count - 1;
            }

            // Restore previous selection if possible
            else if (selectedIndex != 0)
            {
                typeList.SelectedIndex = selectedIndex;
            }

            UpdateListWidth(TypesList);
        }


        /// <summary>
        /// Custom drawing for the type list items ((Color Rectangle) - Name).
        /// </summary>
        private void typeList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var type = (TypeModel)typeList.Items[e.Index];

            e.DrawBackground();

            int squareSize = 12;
            int verticalOffset = (e.Bounds.Height - squareSize) / 2;
            Rectangle colorSquare = new Rectangle(e.Bounds.X + 5, e.Bounds.Y + verticalOffset, squareSize, squareSize);

            using (SolidBrush brush = new SolidBrush(type.Color))
            {
                e.Graphics.FillRectangle(brush, colorSquare);
                e.Graphics.DrawRectangle(Pens.Black, colorSquare);
            }

            Rectangle textBounds = new Rectangle(e.Bounds.X + 25, e.Bounds.Y, e.Bounds.Width - 25, e.Bounds.Height);
            Brush textBrush = (e.State.HasFlag(DrawItemState.Selected)) ? Brushes.White : Brushes.Black;

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(type.Name, e.Font, textBrush, textBounds, format);
            e.DrawFocusRectangle();
        }


        private void UpdateListWidth(List<TypeModel> types)
        {
            typeList.HorizontalScrollbar = true;
            int maxPixelWidth = 0;

            using (Graphics g = typeList.CreateGraphics())
            {
                foreach (var type in types)
                {
                    string fullText = $"{type.Name}";
                    int itemWidth = (int)g.MeasureString(fullText, typeList.Font).Width;
                    if (itemWidth > maxPixelWidth)
                    {
                        maxPixelWidth = itemWidth;
                    }
                }
            }

            typeList.HorizontalExtent = maxPixelWidth + 10;
        }
    }
}
