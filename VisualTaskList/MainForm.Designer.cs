namespace VisualTaskList
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            tasksView = new VisualTaskList.Views.TaskViews.TasksView();
            tabPage1 = new TabPage();
            typesView = new VisualTaskList.Views.TypesViews.TypesView();
            tabPage2 = new TabPage();
            categoriesView = new VisualTaskList.Views.CategoryViews.CategoriesView();
            cubeCalendar1 = new VisualTaskList.CustomControls.CubeCalendar();
            tableLayoutPanel1 = new TableLayoutPanel();
            ErrorText = new VisualTaskList.CustomControls.ErrorText();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(855, 354);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Transparent;
            tabPage3.Controls.Add(tasksView);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(847, 326);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tasks";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tasksView
            // 
            tasksView.BackColor = Color.Transparent;
            tasksView.Dock = DockStyle.Fill;
            tasksView.Location = new Point(0, 0);
            tasksView.Margin = new Padding(0);
            tasksView.Name = "tasksView";
            tasksView.SelectedTaskNotes = "";
            tasksView.Size = new Size(847, 326);
            tasksView.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(typesView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(847, 326);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Types";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // typesView
            // 
            typesView.Dock = DockStyle.Fill;
            typesView.Location = new Point(0, 0);
            typesView.Margin = new Padding(0);
            typesView.Name = "typesView";
            typesView.SelectedTypeNotes = "";
            typesView.Size = new Size(847, 326);
            typesView.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(categoriesView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(847, 326);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "Categories";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // categoriesView
            // 
            categoriesView.Dock = DockStyle.Fill;
            categoriesView.Location = new Point(0, 0);
            categoriesView.Margin = new Padding(0);
            categoriesView.Name = "categoriesView";
            categoriesView.SelectedCategoryNotes = "";
            categoriesView.Size = new Size(847, 326);
            categoriesView.TabIndex = 0;
            // 
            // cubeCalendar1
            // 
            cubeCalendar1.AutoSize = true;
            cubeCalendar1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cubeCalendar1.Dock = DockStyle.Left;
            cubeCalendar1.Location = new Point(6, 363);
            cubeCalendar1.Margin = new Padding(6, 3, 6, 3);
            cubeCalendar1.Name = "cubeCalendar1";
            cubeCalendar1.Size = new Size(849, 82);
            cubeCalendar1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ErrorText, 0, 2);
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(cubeCalendar1, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(861, 483);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // ErrorText
            // 
            ErrorText.Dock = DockStyle.Top;
            ErrorText.Location = new Point(6, 451);
            ErrorText.Margin = new Padding(6, 3, 6, 3);
            ErrorText.Name = "ErrorText";
            ErrorText.Size = new Size(849, 29);
            ErrorText.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(861, 483);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "VisualTaskList";
            FormClosing += MainForm_Closing;
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private Views.TaskViews.TasksView tasksView1;
        private TabPage tabPage3;
        private Views.TaskViews.TasksView tasksView2;
        private Views.TaskViews.TasksView tasksView;
        private CustomControls.CubeCalendar cubeCalendar1;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.ErrorText ErrorText;
        private TabPage tabPage1;
        private Views.TypesViews.TypesView typesView;
        private TabPage tabPage2;
        private Views.CategoryViews.CategoriesView categoriesView;
    }
}
