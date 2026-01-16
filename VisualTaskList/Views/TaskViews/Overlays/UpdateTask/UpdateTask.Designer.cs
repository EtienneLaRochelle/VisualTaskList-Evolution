namespace VisualTaskList.Views.TaskViews.Overlays.UpdateTask
{
    partial class UpdateTask
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            taskTitle = new TextBox();
            taskCategory = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            taskDueDate = new DateTimePicker();
            taskTypeId = new ComboBox();
            updateTaskButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(taskTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(taskCategory, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(taskDueDate, 1, 3);
            tableLayoutPanel1.Controls.Add(taskTypeId, 1, 2);
            tableLayoutPanel1.Controls.Add(updateTaskButton, 0, 4);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(400, 150);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Title:";
            // 
            // taskTitle
            // 
            taskTitle.Dock = DockStyle.Fill;
            taskTitle.Location = new Point(67, 3);
            taskTitle.Name = "taskTitle";
            taskTitle.Size = new Size(330, 23);
            taskTitle.TabIndex = 1;
            // 
            // taskCategory
            // 
            taskCategory.Dock = DockStyle.Fill;
            taskCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            taskCategory.FormattingEnabled = true;
            taskCategory.Location = new Point(67, 32);
            taskCategory.Name = "taskCategory";
            taskCategory.Size = new Size(330, 23);
            taskCategory.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 94);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Due date:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 65);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Type";
            // 
            // taskDueDate
            // 
            taskDueDate.Dock = DockStyle.Fill;
            taskDueDate.Location = new Point(67, 90);
            taskDueDate.Name = "taskDueDate";
            taskDueDate.Size = new Size(330, 23);
            taskDueDate.TabIndex = 0;
            // 
            // taskTypeId
            // 
            taskTypeId.Dock = DockStyle.Fill;
            taskTypeId.DropDownStyle = ComboBoxStyle.DropDownList;
            taskTypeId.FormattingEnabled = true;
            taskTypeId.Location = new Point(67, 61);
            taskTypeId.Name = "taskTypeId";
            taskTypeId.Size = new Size(330, 23);
            taskTypeId.TabIndex = 3;
            // 
            // updateTaskButton
            // 
            tableLayoutPanel1.SetColumnSpan(updateTaskButton, 2);
            updateTaskButton.Dock = DockStyle.Fill;
            updateTaskButton.Location = new Point(3, 119);
            updateTaskButton.Name = "updateTaskButton";
            updateTaskButton.Size = new Size(394, 28);
            updateTaskButton.TabIndex = 8;
            updateTaskButton.Text = "Update";
            updateTaskButton.UseVisualStyleBackColor = true;
            updateTaskButton.Click += updateTaskButton_Click;
            // 
            // UpdateTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 150);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateTask";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateTask";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox taskTitle;
        private ComboBox taskCategory;
        private Label label4;
        private Label label2;
        private Label label3;
        private DateTimePicker taskDueDate;
        private ComboBox taskTypeId;
        private Button updateTaskButton;
    }
}