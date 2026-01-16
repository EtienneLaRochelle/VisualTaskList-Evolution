namespace VisualTaskList.Views.TaskViews
{
    partial class TasksView
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
            taskList = new ListBox();
            taskAdd = new Button();
            taskUpdate = new Button();
            taskDelete = new Button();
            taskHide = new Button();
            taskNotes = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            showHiddenTasks = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // taskList
            // 
            taskList.BorderStyle = BorderStyle.FixedSingle;
            taskList.Dock = DockStyle.Fill;
            taskList.DrawMode = DrawMode.OwnerDrawFixed;
            taskList.Font = new Font("Segoe UI", 10F);
            taskList.FormattingEnabled = true;
            taskList.IntegralHeight = false;
            taskList.ItemHeight = 15;
            taskList.Location = new Point(0, 0);
            taskList.Margin = new Padding(0);
            taskList.Name = "taskList";
            taskList.Size = new Size(256, 192);
            taskList.TabIndex = 0;
            taskList.DrawItem += taskList_DrawItem;
            taskList.SelectedIndexChanged += taskList_SelectedIndexChanged;
            // 
            // taskAdd
            // 
            taskAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            taskAdd.Font = new Font("Segoe UI", 9F);
            taskAdd.Location = new Point(0, 193);
            taskAdd.Margin = new Padding(0, 1, 0, 1);
            taskAdd.Name = "taskAdd";
            taskAdd.Size = new Size(256, 25);
            taskAdd.TabIndex = 1;
            taskAdd.Text = "Add";
            taskAdd.UseVisualStyleBackColor = true;
            taskAdd.Click += taskAdd_Click;
            // 
            // taskUpdate
            // 
            taskUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            taskUpdate.Font = new Font("Segoe UI", 9F);
            taskUpdate.Location = new Point(0, 220);
            taskUpdate.Margin = new Padding(0, 1, 0, 1);
            taskUpdate.Name = "taskUpdate";
            taskUpdate.Size = new Size(256, 25);
            taskUpdate.TabIndex = 2;
            taskUpdate.Text = "Update";
            taskUpdate.UseVisualStyleBackColor = true;
            taskUpdate.Click += taskUpdate_Click;
            // 
            // taskDelete
            // 
            taskDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            taskDelete.Font = new Font("Segoe UI", 9F);
            taskDelete.Location = new Point(0, 247);
            taskDelete.Margin = new Padding(0, 1, 0, 1);
            taskDelete.Name = "taskDelete";
            taskDelete.Size = new Size(256, 25);
            taskDelete.TabIndex = 3;
            taskDelete.Text = "Delete";
            taskDelete.UseVisualStyleBackColor = true;
            taskDelete.Click += taskDelete_Click;
            // 
            // taskHide
            // 
            taskHide.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            taskHide.Font = new Font("Segoe UI", 9F);
            taskHide.Location = new Point(0, 274);
            taskHide.Margin = new Padding(0, 1, 0, 1);
            taskHide.Name = "taskHide";
            taskHide.Size = new Size(256, 25);
            taskHide.TabIndex = 4;
            taskHide.Text = "Hide";
            taskHide.UseVisualStyleBackColor = true;
            taskHide.Click += taskHide_Click;
            // 
            // taskNotes
            // 
            taskNotes.AcceptsReturn = true;
            taskNotes.AcceptsTab = true;
            taskNotes.BorderStyle = BorderStyle.FixedSingle;
            taskNotes.Dock = DockStyle.Fill;
            taskNotes.Font = new Font("Segoe UI", 9F);
            taskNotes.Location = new Point(3, 19);
            taskNotes.Multiline = true;
            taskNotes.Name = "taskNotes";
            taskNotes.Size = new Size(391, 327);
            taskNotes.TabIndex = 5;
            taskNotes.Leave += taskNotes_Leave;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(taskList, 0, 0);
            tableLayoutPanel1.Controls.Add(taskAdd, 0, 1);
            tableLayoutPanel1.Controls.Add(taskHide, 0, 4);
            tableLayoutPanel1.Controls.Add(taskUpdate, 0, 2);
            tableLayoutPanel1.Controls.Add(taskDelete, 0, 3);
            tableLayoutPanel1.Controls.Add(showHiddenTasks, 0, 5);
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
            // showHiddenTasks
            // 
            showHiddenTasks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            showHiddenTasks.Font = new Font("Segoe UI", 9F);
            showHiddenTasks.Location = new Point(0, 301);
            showHiddenTasks.Margin = new Padding(0, 1, 0, 1);
            showHiddenTasks.Name = "showHiddenTasks";
            showHiddenTasks.Size = new Size(256, 25);
            showHiddenTasks.TabIndex = 5;
            showHiddenTasks.Text = "Show Hidden Tasks";
            showHiddenTasks.UseVisualStyleBackColor = true;
            showHiddenTasks.Click += showHiddenTasks_Click;
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
            groupBox1.Text = "Tasks List";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(taskNotes);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(271, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 349);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task Notes";
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
            tableLayoutPanel2.TabIndex = 9;
            // 
            // TasksView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(0);
            Name = "TasksView";
            Size = new Size(671, 355);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox taskList;
        private Button taskAdd;
        private Button taskUpdate;
        private Button taskDelete;
        private Button taskHide;
        private TextBox taskNotes;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button showHiddenTasks;
    }
}
