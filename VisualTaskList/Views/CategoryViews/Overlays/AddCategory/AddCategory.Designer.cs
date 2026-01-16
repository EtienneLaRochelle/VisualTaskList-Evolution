namespace VisualTaskList.Views.CategoryViews.Overlays.AddCategory
{
    partial class AddCategory
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
            categoryShortName = new TextBox();
            label1 = new Label();
            categoryName = new TextBox();
            label2 = new Label();
            addCategoryButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(categoryShortName, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(categoryName, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(addCategoryButton, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(292, 92);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // categoryShortName
            // 
            categoryShortName.CharacterCasing = CharacterCasing.Upper;
            categoryShortName.Dock = DockStyle.Left;
            categoryShortName.Location = new Point(87, 32);
            categoryShortName.MaxLength = 4;
            categoryShortName.Name = "categoryShortName";
            categoryShortName.Size = new Size(202, 23);
            categoryShortName.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // categoryName
            // 
            categoryName.Dock = DockStyle.Left;
            categoryName.Location = new Point(87, 3);
            categoryName.Name = "categoryName";
            categoryName.Size = new Size(202, 23);
            categoryName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 5;
            label2.Text = "Abbreviation:";
            // 
            // addCategoryButton
            // 
            tableLayoutPanel1.SetColumnSpan(addCategoryButton, 2);
            addCategoryButton.Dock = DockStyle.Left;
            addCategoryButton.Location = new Point(3, 61);
            addCategoryButton.Name = "addCategoryButton";
            addCategoryButton.Size = new Size(286, 28);
            addCategoryButton.TabIndex = 8;
            addCategoryButton.Text = "Add\r\n";
            addCategoryButton.UseVisualStyleBackColor = true;
            addCategoryButton.Click += addCategoryButton_Click;
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 92);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCategory";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox categoryName;
        private Label label2;
        private Button addCategoryButton;
        private TextBox categoryShortName;
    }
}