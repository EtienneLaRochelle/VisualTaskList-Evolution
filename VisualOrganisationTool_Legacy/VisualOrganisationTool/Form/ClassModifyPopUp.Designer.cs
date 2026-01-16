namespace VisualOrganisationTool
{
    partial class ClassModifyPopUp
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
            this.classShort = new System.Windows.Forms.TextBox();
            this.classUpdateCancel = new System.Windows.Forms.Button();
            this.classModify = new System.Windows.Forms.Button();
            this.className = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classShort);
            this.groupBox1.Controls.Add(this.classUpdateCancel);
            this.groupBox1.Controls.Add(this.classModify);
            this.groupBox1.Controls.Add(this.className);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, -13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // classShort
            // 
            this.classShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classShort.Location = new System.Drawing.Point(92, 40);
            this.classShort.Margin = new System.Windows.Forms.Padding(0);
            this.classShort.MaxLength = 4;
            this.classShort.Name = "classShort";
            this.classShort.Size = new System.Drawing.Size(184, 21);
            this.classShort.TabIndex = 71;
            // 
            // classUpdateCancel
            // 
            this.classUpdateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classUpdateCancel.Location = new System.Drawing.Point(9, 90);
            this.classUpdateCancel.Name = "classUpdateCancel";
            this.classUpdateCancel.Size = new System.Drawing.Size(267, 26);
            this.classUpdateCancel.TabIndex = 69;
            this.classUpdateCancel.Text = "Annuler";
            this.classUpdateCancel.UseVisualStyleBackColor = true;
            this.classUpdateCancel.Click += new System.EventHandler(this.classUpdateCancel_Click);
            // 
            // classModify
            // 
            this.classModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classModify.Location = new System.Drawing.Point(9, 64);
            this.classModify.Name = "classModify";
            this.classModify.Size = new System.Drawing.Size(267, 26);
            this.classModify.TabIndex = 63;
            this.classModify.Text = "Modifier";
            this.classModify.UseVisualStyleBackColor = true;
            this.classModify.Click += new System.EventHandler(this.classModify_Click);
            // 
            // className
            // 
            this.className.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.className.Location = new System.Drawing.Point(54, 16);
            this.className.Margin = new System.Windows.Forms.Padding(0);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(222, 21);
            this.className.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forme courte:";
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
            // ClassModifyPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 106);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassModifyPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify class";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox classShort;
        private System.Windows.Forms.Button classUpdateCancel;
        private System.Windows.Forms.Button classModify;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}