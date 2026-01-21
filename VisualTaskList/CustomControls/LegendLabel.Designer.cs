namespace VisualTaskList.CustomControls
{
    partial class LegendLabel
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Color = new Panel();
            Label = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(Color, 0, 0);
            tableLayoutPanel1.Controls.Add(Label, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(63, 20);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Color
            // 
            Color.BackColor = SystemColors.AppWorkspace;
            Color.BorderStyle = BorderStyle.FixedSingle;
            Color.Dock = DockStyle.Left;
            Color.Location = new Point(0, 0);
            Color.Margin = new Padding(0);
            Color.Name = "Color";
            Color.Size = new Size(20, 20);
            Color.TabIndex = 0;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.BackColor = SystemColors.Control;
            Label.Dock = DockStyle.Fill;
            Label.Font = new Font("Segoe UI", 9.5F);
            Label.Location = new Point(20, 0);
            Label.Margin = new Padding(0);
            Label.Name = "Label";
            Label.Size = new Size(43, 20);
            Label.TabIndex = 1;
            Label.Text = "label1";
            Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LegendLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            Controls.Add(tableLayoutPanel1);
            Name = "LegendLabel";
            Size = new Size(66, 23);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel Color;
        private Label Label;
    }
}
