namespace VisualTaskList.Views.TypesViews
{
    partial class TypesView
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            typeAdd = new Button();
            typeList = new ListBox();
            typeUpdate = new Button();
            typeDelete = new Button();
            groupBox2 = new GroupBox();
            typeNotes = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Text = "Types List";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(typeAdd, 0, 1);
            tableLayoutPanel1.Controls.Add(typeList, 0, 0);
            tableLayoutPanel1.Controls.Add(typeUpdate, 0, 2);
            tableLayoutPanel1.Controls.Add(typeDelete, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(256, 327);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // typeAdd
            // 
            typeAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            typeAdd.Font = new Font("Segoe UI", 9F);
            typeAdd.Location = new Point(0, 247);
            typeAdd.Margin = new Padding(0, 1, 0, 1);
            typeAdd.Name = "typeAdd";
            typeAdd.Size = new Size(256, 25);
            typeAdd.TabIndex = 1;
            typeAdd.Text = "Add";
            typeAdd.UseVisualStyleBackColor = true;
            typeAdd.Click += typeAdd_Click;
            // 
            // typeList
            // 
            typeList.BorderStyle = BorderStyle.FixedSingle;
            typeList.Dock = DockStyle.Fill;
            typeList.DrawMode = DrawMode.OwnerDrawFixed;
            typeList.Font = new Font("Segoe UI", 10F);
            typeList.FormattingEnabled = true;
            typeList.IntegralHeight = false;
            typeList.ItemHeight = 15;
            typeList.Location = new Point(0, 0);
            typeList.Margin = new Padding(0);
            typeList.Name = "typeList";
            typeList.Size = new Size(256, 246);
            typeList.TabIndex = 0;
            typeList.DrawItem += typeList_DrawItem;
            typeList.SelectedIndexChanged += TypeList_SelectedIndexChanged;
            // 
            // typeUpdate
            // 
            typeUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            typeUpdate.Font = new Font("Segoe UI", 9F);
            typeUpdate.Location = new Point(0, 274);
            typeUpdate.Margin = new Padding(0, 1, 0, 1);
            typeUpdate.Name = "typeUpdate";
            typeUpdate.Size = new Size(256, 25);
            typeUpdate.TabIndex = 2;
            typeUpdate.Text = "Update";
            typeUpdate.UseVisualStyleBackColor = true;
            typeUpdate.Click += TypeUpdate_Click;
            // 
            // typeDelete
            // 
            typeDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            typeDelete.Font = new Font("Segoe UI", 9F);
            typeDelete.Location = new Point(0, 301);
            typeDelete.Margin = new Padding(0, 1, 0, 1);
            typeDelete.Name = "typeDelete";
            typeDelete.Size = new Size(256, 25);
            typeDelete.TabIndex = 3;
            typeDelete.Text = "Delete";
            typeDelete.UseVisualStyleBackColor = true;
            typeDelete.Click += TypeDelete_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(typeNotes);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(271, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 349);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Type Notes";
            // 
            // typeNotes
            // 
            typeNotes.AcceptsReturn = true;
            typeNotes.AcceptsTab = true;
            typeNotes.BorderStyle = BorderStyle.FixedSingle;
            typeNotes.Dock = DockStyle.Fill;
            typeNotes.Font = new Font("Segoe UI", 9F);
            typeNotes.Location = new Point(3, 19);
            typeNotes.Margin = new Padding(6);
            typeNotes.Multiline = true;
            typeNotes.Name = "typeNotes";
            typeNotes.Size = new Size(391, 327);
            typeNotes.TabIndex = 5;
            typeNotes.Leave += TypeNotes_Leave;
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
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(671, 355);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // TypesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(0);
            Name = "TypesView";
            Size = new Size(671, 355);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader Title;
        private ColumnHeader Color;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button typeAdd;
        private ListBox typeList;
        private Button typeUpdate;
        private Button typeDelete;
        private GroupBox groupBox2;
        private TextBox typeNotes;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
