namespace VisualOrganisationTool
{
    partial class ClassMenu
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.classDelete = new System.Windows.Forms.Button();
            this.classModify = new System.Windows.Forms.Button();
            this.classCurrent = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.classShort = new System.Windows.Forms.TextBox();
            this.classAdd = new System.Windows.Forms.Button();
            this.className = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.classNotes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.classDelete);
            this.groupBox3.Controls.Add(this.classModify);
            this.groupBox3.Controls.Add(this.classCurrent);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 102);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 191);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class:";
            // 
            // classDelete
            // 
            this.classDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDelete.Location = new System.Drawing.Point(4, 161);
            this.classDelete.Margin = new System.Windows.Forms.Padding(0);
            this.classDelete.Name = "classDelete";
            this.classDelete.Size = new System.Drawing.Size(272, 26);
            this.classDelete.TabIndex = 65;
            this.classDelete.Text = "Delete";
            this.classDelete.UseVisualStyleBackColor = true;
            this.classDelete.Click += new System.EventHandler(this.classDelete_Click);
            // 
            // classModify
            // 
            this.classModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classModify.Location = new System.Drawing.Point(4, 135);
            this.classModify.Margin = new System.Windows.Forms.Padding(0);
            this.classModify.Name = "classModify";
            this.classModify.Size = new System.Drawing.Size(272, 26);
            this.classModify.TabIndex = 65;
            this.classModify.Text = "Modify";
            this.classModify.UseVisualStyleBackColor = true;
            this.classModify.Click += new System.EventHandler(this.classModify_Click);
            // 
            // classCurrent
            // 
            this.classCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCurrent.FormattingEnabled = true;
            this.classCurrent.Location = new System.Drawing.Point(4, 20);
            this.classCurrent.Name = "classCurrent";
            this.classCurrent.Size = new System.Drawing.Size(272, 108);
            this.classCurrent.TabIndex = 61;
            this.classCurrent.SelectedIndexChanged += new System.EventHandler(this.classCurrent_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.classShort);
            this.groupBox5.Controls.Add(this.classAdd);
            this.groupBox5.Controls.Add(this.className);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 96);
            this.groupBox5.TabIndex = 67;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "New class:";
            // 
            // classShort
            // 
            this.classShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classShort.Location = new System.Drawing.Point(86, 40);
            this.classShort.MaxLength = 4;
            this.classShort.Name = "classShort";
            this.classShort.Size = new System.Drawing.Size(190, 20);
            this.classShort.TabIndex = 64;
            // 
            // classAdd
            // 
            this.classAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classAdd.Location = new System.Drawing.Point(9, 63);
            this.classAdd.Name = "classAdd";
            this.classAdd.Size = new System.Drawing.Size(267, 26);
            this.classAdd.TabIndex = 63;
            this.classAdd.Text = "Add";
            this.classAdd.UseVisualStyleBackColor = true;
            this.classAdd.Click += new System.EventHandler(this.classAdd_Click);
            // 
            // className
            // 
            this.className.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.className.Location = new System.Drawing.Point(54, 16);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(222, 20);
            this.className.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 43);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "Short name:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 19);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 15);
            this.label20.TabIndex = 1;
            this.label20.Text = "Name:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.classNotes);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(301, 3);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(472, 290);
            this.groupBox7.TabIndex = 69;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Class notes:";
            // 
            // classNotes
            // 
            this.classNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNotes.Location = new System.Drawing.Point(6, 20);
            this.classNotes.Multiline = true;
            this.classNotes.Name = "classNotes";
            this.classNotes.Size = new System.Drawing.Size(460, 266);
            this.classNotes.TabIndex = 0;
            this.classNotes.Leave += new System.EventHandler(this.classNotes_LostFocus);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(651, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 73;
            this.label15.Text = "Status:";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(697, 295);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(76, 20);
            this.Status.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Errors:";
            // 
            // Error
            // 
            this.Error.Location = new System.Drawing.Point(56, 295);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(589, 20);
            this.Error.TabIndex = 70;
            // 
            // ClassMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 326);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClassMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class";
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button classDelete;
        private System.Windows.Forms.Button classModify;
        private System.Windows.Forms.ListBox classCurrent;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox classShort;
        private System.Windows.Forms.Button classAdd;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox classNotes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Error;
    }
}