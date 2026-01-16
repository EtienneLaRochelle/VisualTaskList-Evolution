namespace VisualOrganisationTool
{
    partial class TaskModifyPopUp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taskUpdateCancel = new System.Windows.Forms.Button();
            this.taskType = new System.Windows.Forms.ComboBox();
            this.taskClass = new System.Windows.Forms.ComboBox();
            this.taskDay = new System.Windows.Forms.NumericUpDown();
            this.taskYear = new System.Windows.Forms.TextBox();
            this.taskMonth = new System.Windows.Forms.ComboBox();
            this.taskModify = new System.Windows.Forms.Button();
            this.taskName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taskUpdateCancel);
            this.groupBox1.Controls.Add(this.taskType);
            this.groupBox1.Controls.Add(this.taskClass);
            this.groupBox1.Controls.Add(this.taskDay);
            this.groupBox1.Controls.Add(this.taskYear);
            this.groupBox1.Controls.Add(this.taskMonth);
            this.groupBox1.Controls.Add(this.taskModify);
            this.groupBox1.Controls.Add(this.taskName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, -13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 172);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // taskUpdateCancel
            // 
            this.taskUpdateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskUpdateCancel.Location = new System.Drawing.Point(10, 140);
            this.taskUpdateCancel.Name = "taskUpdateCancel";
            this.taskUpdateCancel.Size = new System.Drawing.Size(267, 26);
            this.taskUpdateCancel.TabIndex = 69;
            this.taskUpdateCancel.Text = "Annuler";
            this.taskUpdateCancel.UseVisualStyleBackColor = true;
            this.taskUpdateCancel.Click += new System.EventHandler(this.taskUpdateCancel_Click);
            // 
            // taskType
            // 
            this.taskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskType.FormattingEnabled = true;
            this.taskType.Location = new System.Drawing.Point(54, 64);
            this.taskType.Name = "taskType";
            this.taskType.Size = new System.Drawing.Size(222, 23);
            this.taskType.TabIndex = 68;
            // 
            // taskClass
            // 
            this.taskClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskClass.FormattingEnabled = true;
            this.taskClass.Location = new System.Drawing.Point(54, 39);
            this.taskClass.Name = "taskClass";
            this.taskClass.Size = new System.Drawing.Size(222, 23);
            this.taskClass.TabIndex = 67;
            // 
            // taskDay
            // 
            this.taskDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDay.Location = new System.Drawing.Point(54, 89);
            this.taskDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.taskDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.taskDay.Name = "taskDay";
            this.taskDay.Size = new System.Drawing.Size(71, 21);
            this.taskDay.TabIndex = 63;
            this.taskDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // taskYear
            // 
            this.taskYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskYear.Location = new System.Drawing.Point(205, 88);
            this.taskYear.Name = "taskYear";
            this.taskYear.Size = new System.Drawing.Size(71, 21);
            this.taskYear.TabIndex = 66;
            // 
            // taskMonth
            // 
            this.taskMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskMonth.FormattingEnabled = true;
            this.taskMonth.Location = new System.Drawing.Point(129, 88);
            this.taskMonth.Name = "taskMonth";
            this.taskMonth.Size = new System.Drawing.Size(71, 23);
            this.taskMonth.TabIndex = 63;
            // 
            // taskModify
            // 
            this.taskModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskModify.Location = new System.Drawing.Point(9, 112);
            this.taskModify.Name = "taskModify";
            this.taskModify.Size = new System.Drawing.Size(267, 26);
            this.taskModify.TabIndex = 63;
            this.taskModify.Text = "Modifier";
            this.taskModify.UseVisualStyleBackColor = true;
            this.taskModify.Click += new System.EventHandler(this.taskModify_Click);
            // 
            // taskName
            // 
            this.taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(54, 16);
            this.taskName.Margin = new System.Windows.Forms.Padding(0);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(222, 21);
            this.taskName.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cours:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom:";
            // 
            // TaskModifyPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 157);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskModifyPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify task";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button taskUpdateCancel;
        private System.Windows.Forms.ComboBox taskType;
        private System.Windows.Forms.ComboBox taskClass;
        private System.Windows.Forms.NumericUpDown taskDay;
        private System.Windows.Forms.TextBox taskYear;
        private System.Windows.Forms.ComboBox taskMonth;
        private System.Windows.Forms.Button taskModify;
        private System.Windows.Forms.TextBox taskName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}