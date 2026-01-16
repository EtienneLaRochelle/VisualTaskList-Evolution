namespace VisualTaskList.Views.TypesViews.Overlays.AddType
{
    partial class AddType
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
            selectColorButton = new Button();
            colorDialog = new ColorDialog();
            selectedColor = new Panel();
            label1 = new Label();
            typeName = new TextBox();
            addTypeButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // selectColorButton
            // 
            selectColorButton.Dock = DockStyle.Fill;
            selectColorButton.Location = new Point(45, 32);
            selectColorButton.Name = "selectColorButton";
            selectColorButton.Size = new Size(232, 23);
            selectColorButton.TabIndex = 0;
            selectColorButton.Text = "Select color";
            selectColorButton.UseVisualStyleBackColor = true;
            selectColorButton.Click += SelectColorButton_Click;
            // 
            // selectedColor
            // 
            selectedColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectedColor.BackColor = Color.White;
            selectedColor.BorderStyle = BorderStyle.FixedSingle;
            selectedColor.Location = new Point(3, 32);
            selectedColor.Name = "selectedColor";
            selectedColor.Size = new Size(36, 23);
            selectedColor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(42, 29);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // typeName
            // 
            typeName.Dock = DockStyle.Fill;
            typeName.Location = new Point(45, 3);
            typeName.Name = "typeName";
            typeName.Size = new Size(232, 23);
            typeName.TabIndex = 3;
            // 
            // addTypeButton
            // 
            tableLayoutPanel1.SetColumnSpan(addTypeButton, 2);
            addTypeButton.Dock = DockStyle.Fill;
            addTypeButton.Location = new Point(3, 61);
            addTypeButton.Name = "addTypeButton";
            addTypeButton.Size = new Size(274, 30);
            addTypeButton.TabIndex = 4;
            addTypeButton.Text = "Add Type";
            addTypeButton.UseVisualStyleBackColor = true;
            addTypeButton.Click += AddType_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(addTypeButton, 0, 2);
            tableLayoutPanel1.Controls.Add(typeName, 1, 0);
            tableLayoutPanel1.Controls.Add(selectedColor, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(selectColorButton, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(280, 93);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // AddType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(280, 93);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddType";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddType";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ColorDialog colorDialog;
        private TextBox textBox1;
        private Button selectColorButton;
        private Panel selectedColor;
        private Label label1;
        private TextBox typeName;
        private Button addTypeButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}