namespace VisualTaskList.CustomControls
{
    partial class WarningForm
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
            WarningMessage = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            closeWarning = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // WarningMessage
            // 
            WarningMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WarningMessage.AutoSize = true;
            WarningMessage.BackColor = Color.Transparent;
            WarningMessage.Font = new Font("Segoe UI", 11F);
            WarningMessage.ForeColor = Color.Red;
            WarningMessage.Location = new Point(20, 20);
            WarningMessage.Margin = new Padding(20);
            WarningMessage.Name = "WarningMessage";
            WarningMessage.Size = new Size(160, 20);
            WarningMessage.TabIndex = 0;
            WarningMessage.Text = "label1";
            WarningMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(WarningMessage, 0, 0);
            tableLayoutPanel1.Controls.Add(closeWarning, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(200, 89);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // closeWarning
            // 
            closeWarning.Dock = DockStyle.Top;
            closeWarning.Location = new Point(3, 63);
            closeWarning.Name = "closeWarning";
            closeWarning.Size = new Size(194, 23);
            closeWarning.TabIndex = 1;
            closeWarning.Text = "Ok";
            closeWarning.UseVisualStyleBackColor = true;
            closeWarning.Click += closeWarning_Click;
            // 
            // WarningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(200, 89);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WarningForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Warning";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WarningMessage;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button closeWarning;
    }
}