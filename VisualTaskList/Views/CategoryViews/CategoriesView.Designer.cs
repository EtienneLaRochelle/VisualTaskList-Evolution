namespace VisualTaskList.Views.CategoryViews
{
    partial class CategoriesView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            categoryNotes = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            categoryList = new ListBox();
            categoryAdd = new Button();
            categoryUpdate = new Button();
            categoryDelete = new Button();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(671, 355);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(categoryNotes);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(271, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 349);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Category Notes";
            // 
            // categoryNotes
            // 
            categoryNotes.AcceptsReturn = true;
            categoryNotes.AcceptsTab = true;
            categoryNotes.BorderStyle = BorderStyle.FixedSingle;
            categoryNotes.Dock = DockStyle.Fill;
            categoryNotes.Font = new Font("Segoe UI", 9F);
            categoryNotes.Location = new Point(3, 19);
            categoryNotes.Multiline = true;
            categoryNotes.Name = "categoryNotes";
            categoryNotes.Size = new Size(391, 327);
            categoryNotes.TabIndex = 5;
            categoryNotes.Leave += categoryNotes_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 349);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categories List";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(categoryList, 0, 0);
            tableLayoutPanel1.Controls.Add(categoryAdd, 0, 1);
            tableLayoutPanel1.Controls.Add(categoryUpdate, 0, 2);
            tableLayoutPanel1.Controls.Add(categoryDelete, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(256, 327);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // categoryList
            // 
            categoryList.BorderStyle = BorderStyle.FixedSingle;
            categoryList.Dock = DockStyle.Fill;
            categoryList.DrawMode = DrawMode.OwnerDrawFixed;
            categoryList.Font = new Font("Segoe UI", 10F);
            categoryList.FormattingEnabled = true;
            categoryList.IntegralHeight = false;
            categoryList.ItemHeight = 15;
            categoryList.Location = new Point(0, 0);
            categoryList.Margin = new Padding(0);
            categoryList.Name = "categoryList";
            categoryList.Size = new Size(256, 246);
            categoryList.TabIndex = 0;
            categoryList.DrawItem += categoryList_DrawItem;
            categoryList.SelectedIndexChanged += categoryList_SelectedIndexChanged;
            // 
            // categoryAdd
            // 
            categoryAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryAdd.Font = new Font("Segoe UI", 9F);
            categoryAdd.Location = new Point(0, 247);
            categoryAdd.Margin = new Padding(0, 1, 0, 1);
            categoryAdd.Name = "categoryAdd";
            categoryAdd.Size = new Size(256, 25);
            categoryAdd.TabIndex = 1;
            categoryAdd.Text = "Add";
            categoryAdd.UseVisualStyleBackColor = true;
            categoryAdd.Click += categoryAdd_Click;
            // 
            // categoryUpdate
            // 
            categoryUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryUpdate.Font = new Font("Segoe UI", 9F);
            categoryUpdate.Location = new Point(0, 274);
            categoryUpdate.Margin = new Padding(0, 1, 0, 1);
            categoryUpdate.Name = "categoryUpdate";
            categoryUpdate.Size = new Size(256, 25);
            categoryUpdate.TabIndex = 2;
            categoryUpdate.Text = "Update";
            categoryUpdate.UseVisualStyleBackColor = true;
            categoryUpdate.Click += categoryUpdate_Click;
            // 
            // categoryDelete
            // 
            categoryDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryDelete.Font = new Font("Segoe UI", 9F);
            categoryDelete.Location = new Point(0, 301);
            categoryDelete.Margin = new Padding(0, 1, 0, 1);
            categoryDelete.Name = "categoryDelete";
            categoryDelete.Size = new Size(256, 25);
            categoryDelete.TabIndex = 3;
            categoryDelete.Text = "Delete";
            categoryDelete.UseVisualStyleBackColor = true;
            categoryDelete.Click += categoryDelete_Click;
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(0);
            Name = "CategoriesView";
            Size = new Size(671, 355);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private TextBox categoryNotes;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox categoryList;
        private Button categoryAdd;
        private Button categoryUpdate;
        private Button categoryDelete;
    }
}
