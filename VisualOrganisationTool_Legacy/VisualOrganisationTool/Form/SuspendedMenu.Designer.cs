namespace VisualOrganisationTool
{
    partial class SuspendedMenu
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
            this.suspendedUpdate = new System.Windows.Forms.Button();
            this.suspendedDelete = new System.Windows.Forms.Button();
            this.taskSuspended = new System.Windows.Forms.ListBox();
            this.suspendedSend = new System.Windows.Forms.Button();
            this.taskNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // suspendedUpdate
            // 
            this.suspendedUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspendedUpdate.Location = new System.Drawing.Point(7, 266);
            this.suspendedUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.suspendedUpdate.Name = "suspendedUpdate";
            this.suspendedUpdate.Size = new System.Drawing.Size(266, 33);
            this.suspendedUpdate.TabIndex = 64;
            this.suspendedUpdate.Text = "Modify";
            this.suspendedUpdate.UseVisualStyleBackColor = true;
            this.suspendedUpdate.Click += new System.EventHandler(this.suspendedUpdate_Click);
            // 
            // suspendedDelete
            // 
            this.suspendedDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspendedDelete.Location = new System.Drawing.Point(7, 300);
            this.suspendedDelete.Name = "suspendedDelete";
            this.suspendedDelete.Size = new System.Drawing.Size(266, 33);
            this.suspendedDelete.TabIndex = 63;
            this.suspendedDelete.Text = "Delete";
            this.suspendedDelete.UseVisualStyleBackColor = true;
            this.suspendedDelete.Click += new System.EventHandler(this.suspendedDelete_Click);
            // 
            // taskSuspended
            // 
            this.taskSuspended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskSuspended.FormattingEnabled = true;
            this.taskSuspended.ItemHeight = 16;
            this.taskSuspended.Location = new System.Drawing.Point(7, 6);
            this.taskSuspended.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.taskSuspended.Name = "taskSuspended";
            this.taskSuspended.Size = new System.Drawing.Size(266, 260);
            this.taskSuspended.TabIndex = 61;
            this.taskSuspended.SelectedIndexChanged += new System.EventHandler(this.taskSuspended_SelectedIndexChanged);
            // 
            // suspendedSend
            // 
            this.suspendedSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspendedSend.Location = new System.Drawing.Point(7, 334);
            this.suspendedSend.Name = "suspendedSend";
            this.suspendedSend.Size = new System.Drawing.Size(266, 33);
            this.suspendedSend.TabIndex = 65;
            this.suspendedSend.Text = "Send to current";
            this.suspendedSend.UseVisualStyleBackColor = true;
            this.suspendedSend.Click += new System.EventHandler(this.suspendedSend_Click);
            // 
            // taskNotes
            // 
            this.taskNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNotes.Location = new System.Drawing.Point(279, 6);
            this.taskNotes.Multiline = true;
            this.taskNotes.Name = "taskNotes";
            this.taskNotes.Size = new System.Drawing.Size(462, 361);
            this.taskNotes.TabIndex = 0;
            this.taskNotes.Leave += new System.EventHandler(this.taskNotes_LostFocus);
            // 
            // SuspendedMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 373);
            this.Controls.Add(this.taskNotes);
            this.Controls.Add(this.suspendedSend);
            this.Controls.Add(this.suspendedDelete);
            this.Controls.Add(this.suspendedUpdate);
            this.Controls.Add(this.taskSuspended);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuspendedMenu";
            this.Text = "Suspended tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button suspendedUpdate;
        private System.Windows.Forms.Button suspendedDelete;
        private System.Windows.Forms.ListBox taskSuspended;
        private System.Windows.Forms.Button suspendedSend;
        private System.Windows.Forms.TextBox taskNotes;
    }
}