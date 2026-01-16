namespace VisualTaskList.Views.TypesViews.Overlays.UpdateType
{
    partial class UpdateType
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
            updateTypeButton = new Button();
            typeName = new TextBox();
            selectedColor = new Panel();
            label1 = new Label();
            selectColorButton = new Button();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(updateTypeButton, 0, 2);
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
            tableLayoutPanel1.TabIndex = 6;
            // 
            // updateTypeButton
            // 
            tableLayoutPanel1.SetColumnSpan(updateTypeButton, 2);
            updateTypeButton.Dock = DockStyle.Fill;
            updateTypeButton.Location = new Point(3, 61);
            updateTypeButton.Name = "updateTypeButton";
            updateTypeButton.Size = new Size(274, 30);
            updateTypeButton.TabIndex = 4;
            updateTypeButton.Text = "Update Type";
            updateTypeButton.UseVisualStyleBackColor = true;
            updateTypeButton.Click += UpdateType_Click;
            // 
            // typeName
            // 
            typeName.Dock = DockStyle.Fill;
            typeName.Location = new Point(45, 3);
            typeName.Name = "typeName";
            typeName.Size = new Size(232, 23);
            typeName.TabIndex = 3;
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
            // UpdateType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 94);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateType";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateType";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button updateTypeButton;
        private TextBox typeName;
        private Panel selectedColor;
        private Label label1;
        private Button selectColorButton;
        private ColorDialog colorDialog1;
    }
}