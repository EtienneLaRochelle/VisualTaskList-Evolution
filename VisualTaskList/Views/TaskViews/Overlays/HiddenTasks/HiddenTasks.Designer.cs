namespace VisualTaskList.Views.TaskViews.Overlays.HiddenTasks
{
    partial class HiddenTasks
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            showTasksButton = new Button();
            hiddenTasksList = new ListBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hidden Tasks List";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(showTasksButton, 0, 1);
            tableLayoutPanel1.Controls.Add(hiddenTasksList, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(256, 219);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // showTasksButton
            // 
            showTasksButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            showTasksButton.Font = new Font("Segoe UI", 10F);
            showTasksButton.Location = new Point(0, 193);
            showTasksButton.Margin = new Padding(0, 1, 0, 1);
            showTasksButton.Name = "showTasksButton";
            showTasksButton.Size = new Size(256, 25);
            showTasksButton.TabIndex = 2;
            showTasksButton.Text = "Show";
            showTasksButton.UseVisualStyleBackColor = true;
            showTasksButton.Click += showTasksButton_Click;
            // 
            // hiddenTasksList
            // 
            hiddenTasksList.BorderStyle = BorderStyle.FixedSingle;
            hiddenTasksList.DrawMode = DrawMode.OwnerDrawFixed;
            hiddenTasksList.Font = new Font("Segoe UI", 9F);
            hiddenTasksList.FormattingEnabled = true;
            hiddenTasksList.IntegralHeight = false;
            hiddenTasksList.ItemHeight = 15;
            hiddenTasksList.Location = new Point(0, 0);
            hiddenTasksList.Margin = new Padding(0);
            hiddenTasksList.Name = "hiddenTasksList";
            hiddenTasksList.Size = new Size(256, 192);
            hiddenTasksList.TabIndex = 1;
            hiddenTasksList.DrawItem += hiddenTasksList_DrawItem;
            // 
            // HiddenTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(266, 244);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HiddenTasks";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HiddenTasks";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox hiddenTasksList;
        private Button showTasksButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}