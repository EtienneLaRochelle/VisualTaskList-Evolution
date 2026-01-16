namespace VisualOrganisationTool
{
    partial class VisualOrganisationToolInterface
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taskType = new System.Windows.Forms.ComboBox();
            this.taskClass = new System.Windows.Forms.ComboBox();
            this.taskDay = new System.Windows.Forms.NumericUpDown();
            this.taskYear = new System.Windows.Forms.TextBox();
            this.taskMonth = new System.Windows.Forms.ComboBox();
            this.taskAdd = new System.Windows.Forms.Button();
            this.taskName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.suspendTask = new System.Windows.Forms.Button();
            this.taskUpdate = new System.Windows.Forms.Button();
            this.taskDelete = new System.Windows.Forms.Button();
            this.taskCurrent = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.taskNotes = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.nextDue = new System.Windows.Forms.ListBox();
            this.nextDueDays = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteAllDue = new System.Windows.Forms.Button();
            this.passDue = new System.Windows.Forms.ListBox();
            this.suspendedShow = new System.Windows.Forms.Button();
            this.classShow = new System.Windows.Forms.Button();
            this.day2 = new VisualOrganisationTool.CubePanel();
            this.day3 = new VisualOrganisationTool.CubePanel();
            this.day14 = new VisualOrganisationTool.CubePanel();
            this.day7 = new VisualOrganisationTool.CubePanel();
            this.day8 = new VisualOrganisationTool.CubePanel();
            this.day10 = new VisualOrganisationTool.CubePanel();
            this.day1 = new VisualOrganisationTool.CubePanel();
            this.day13 = new VisualOrganisationTool.CubePanel();
            this.day9 = new VisualOrganisationTool.CubePanel();
            this.day6 = new VisualOrganisationTool.CubePanel();
            this.day12 = new VisualOrganisationTool.CubePanel();
            this.day11 = new VisualOrganisationTool.CubePanel();
            this.day5 = new VisualOrganisationTool.CubePanel();
            this.day4 = new VisualOrganisationTool.CubePanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDay)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taskType);
            this.groupBox1.Controls.Add(this.taskClass);
            this.groupBox1.Controls.Add(this.taskDay);
            this.groupBox1.Controls.Add(this.taskYear);
            this.groupBox1.Controls.Add(this.taskMonth);
            this.groupBox1.Controls.Add(this.taskAdd);
            this.groupBox1.Controls.Add(this.taskName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New task:";
            // 
            // taskType
            // 
            this.taskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskType.FormattingEnabled = true;
            this.taskType.Location = new System.Drawing.Point(54, 64);
            this.taskType.Name = "taskType";
            this.taskType.Size = new System.Drawing.Size(222, 24);
            this.taskType.TabIndex = 68;
            // 
            // taskClass
            // 
            this.taskClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskClass.FormattingEnabled = true;
            this.taskClass.Location = new System.Drawing.Point(54, 39);
            this.taskClass.Name = "taskClass";
            this.taskClass.Size = new System.Drawing.Size(222, 24);
            this.taskClass.TabIndex = 67;
            // 
            // taskDay
            // 
            this.taskDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.taskDay.Size = new System.Drawing.Size(71, 22);
            this.taskDay.TabIndex = 63;
            this.taskDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // taskYear
            // 
            this.taskYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskYear.Location = new System.Drawing.Point(205, 88);
            this.taskYear.Name = "taskYear";
            this.taskYear.Size = new System.Drawing.Size(71, 22);
            this.taskYear.TabIndex = 66;
            this.taskYear.Leave += new System.EventHandler(this.taskYear_LostFocus);
            // 
            // taskMonth
            // 
            this.taskMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskMonth.FormattingEnabled = true;
            this.taskMonth.Location = new System.Drawing.Point(129, 88);
            this.taskMonth.Name = "taskMonth";
            this.taskMonth.Size = new System.Drawing.Size(71, 24);
            this.taskMonth.TabIndex = 63;
            this.taskMonth.SelectedIndexChanged += new System.EventHandler(this.taskMonth_SelectedIndexChanged);
            // 
            // taskAdd
            // 
            this.taskAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskAdd.Location = new System.Drawing.Point(6, 112);
            this.taskAdd.Name = "taskAdd";
            this.taskAdd.Size = new System.Drawing.Size(270, 26);
            this.taskAdd.TabIndex = 63;
            this.taskAdd.Text = "Add";
            this.taskAdd.UseVisualStyleBackColor = true;
            this.taskAdd.Click += new System.EventHandler(this.taskAdd_Click);
            // 
            // taskName
            // 
            this.taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(54, 16);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(222, 22);
            this.taskName.TabIndex = 3;
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
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.suspendTask);
            this.groupBox2.Controls.Add(this.taskUpdate);
            this.groupBox2.Controls.Add(this.taskDelete);
            this.groupBox2.Controls.Add(this.taskCurrent);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(302, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 360);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current tasks:";
            // 
            // suspendTask
            // 
            this.suspendTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspendTask.Location = new System.Drawing.Point(6, 315);
            this.suspendTask.Name = "suspendTask";
            this.suspendTask.Size = new System.Drawing.Size(266, 33);
            this.suspendTask.TabIndex = 65;
            this.suspendTask.Text = "Suspend";
            this.suspendTask.UseVisualStyleBackColor = true;
            this.suspendTask.Click += new System.EventHandler(this.suspendTask_Click);
            // 
            // taskUpdate
            // 
            this.taskUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskUpdate.Location = new System.Drawing.Point(6, 247);
            this.taskUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.taskUpdate.Name = "taskUpdate";
            this.taskUpdate.Size = new System.Drawing.Size(266, 33);
            this.taskUpdate.TabIndex = 64;
            this.taskUpdate.Text = "Modify";
            this.taskUpdate.UseVisualStyleBackColor = true;
            this.taskUpdate.Click += new System.EventHandler(this.taskUpdate_Click);
            // 
            // taskDelete
            // 
            this.taskDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDelete.Location = new System.Drawing.Point(6, 281);
            this.taskDelete.Name = "taskDelete";
            this.taskDelete.Size = new System.Drawing.Size(266, 33);
            this.taskDelete.TabIndex = 63;
            this.taskDelete.Text = "Delete";
            this.taskDelete.UseVisualStyleBackColor = true;
            this.taskDelete.Click += new System.EventHandler(this.taskDelete_Click);
            // 
            // taskCurrent
            // 
            this.taskCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskCurrent.FormattingEnabled = true;
            this.taskCurrent.ItemHeight = 16;
            this.taskCurrent.Location = new System.Drawing.Point(6, 16);
            this.taskCurrent.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.taskCurrent.Name = "taskCurrent";
            this.taskCurrent.Size = new System.Drawing.Size(266, 228);
            this.taskCurrent.TabIndex = 61;
            this.taskCurrent.SelectedIndexChanged += new System.EventHandler(this.taskCurrent_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(932, 560);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 60;
            this.label15.Text = "Status:";
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(978, 557);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(76, 20);
            this.Status.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 560);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Errors:";
            // 
            // Error
            // 
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(62, 557);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(858, 20);
            this.Error.TabIndex = 57;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.day2);
            this.groupBox4.Controls.Add(this.day3);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.day14);
            this.groupBox4.Controls.Add(this.day7);
            this.groupBox4.Controls.Add(this.day8);
            this.groupBox4.Controls.Add(this.day10);
            this.groupBox4.Controls.Add(this.day1);
            this.groupBox4.Controls.Add(this.day13);
            this.groupBox4.Controls.Add(this.day9);
            this.groupBox4.Controls.Add(this.day6);
            this.groupBox4.Controls.Add(this.day12);
            this.groupBox4.Controls.Add(this.day11);
            this.groupBox4.Controls.Add(this.day5);
            this.groupBox4.Controls.Add(this.day4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 432);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1048, 124);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Next 14 days:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSalmon;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(389, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 93;
            this.label10.Text = "  ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(244, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 15);
            this.label12.TabIndex = 92;
            this.label12.Text = "  ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Gray;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(94, 98);
            this.label19.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 15);
            this.label19.TabIndex = 91;
            this.label19.Text = "  ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 96);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label18.Size = new System.Drawing.Size(82, 17);
            this.label18.TabIndex = 90;
            this.label18.Text = "Weekend:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Yellow;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(307, 98);
            this.label16.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 15);
            this.label16.TabIndex = 88;
            this.label16.Text = "  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(179, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 15);
            this.label11.TabIndex = 85;
            this.label11.Text = "  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(330, 96);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 83;
            this.label9.Text = "Autre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(267, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "TP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 81;
            this.label7.Text = "PFI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 96);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 80;
            this.label6.Text = "Exam:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.taskNotes);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(588, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(472, 360);
            this.groupBox6.TabIndex = 67;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Task notes:";
            // 
            // taskNotes
            // 
            this.taskNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNotes.Location = new System.Drawing.Point(4, 20);
            this.taskNotes.Multiline = true;
            this.taskNotes.Name = "taskNotes";
            this.taskNotes.Size = new System.Drawing.Size(462, 332);
            this.taskNotes.TabIndex = 0;
            this.taskNotes.Leave += new System.EventHandler(this.taskNotes_LostFocus);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.nextDue);
            this.groupBox8.Controls.Add(this.nextDueDays);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.deleteAllDue);
            this.groupBox8.Controls.Add(this.passDue);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(12, 150);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(286, 212);
            this.groupBox8.TabIndex = 69;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Next due:";
            // 
            // nextDue
            // 
            this.nextDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDue.FormattingEnabled = true;
            this.nextDue.ItemHeight = 16;
            this.nextDue.Location = new System.Drawing.Point(11, 42);
            this.nextDue.Name = "nextDue";
            this.nextDue.Size = new System.Drawing.Size(265, 36);
            this.nextDue.TabIndex = 65;
            // 
            // nextDueDays
            // 
            this.nextDueDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDueDays.Location = new System.Drawing.Point(69, 17);
            this.nextDueDays.Name = "nextDueDays";
            this.nextDueDays.Size = new System.Drawing.Size(49, 22);
            this.nextDueDays.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 67;
            this.label14.Text = "Days left:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 66;
            this.label1.Text = "Pass due:";
            // 
            // deleteAllDue
            // 
            this.deleteAllDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAllDue.Location = new System.Drawing.Point(9, 171);
            this.deleteAllDue.Margin = new System.Windows.Forms.Padding(0);
            this.deleteAllDue.Name = "deleteAllDue";
            this.deleteAllDue.Size = new System.Drawing.Size(268, 33);
            this.deleteAllDue.TabIndex = 65;
            this.deleteAllDue.Text = "Delete All";
            this.deleteAllDue.UseVisualStyleBackColor = true;
            this.deleteAllDue.Click += new System.EventHandler(this.deleteAllDue_Click);
            // 
            // passDue
            // 
            this.passDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passDue.FormattingEnabled = true;
            this.passDue.ItemHeight = 16;
            this.passDue.Location = new System.Drawing.Point(10, 99);
            this.passDue.Name = "passDue";
            this.passDue.Size = new System.Drawing.Size(266, 68);
            this.passDue.TabIndex = 65;
            // 
            // suspendedShow
            // 
            this.suspendedShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspendedShow.Location = new System.Drawing.Point(12, 369);
            this.suspendedShow.Margin = new System.Windows.Forms.Padding(0);
            this.suspendedShow.Name = "suspendedShow";
            this.suspendedShow.Size = new System.Drawing.Size(1048, 28);
            this.suspendedShow.TabIndex = 70;
            this.suspendedShow.Text = "Show suspended tasks";
            this.suspendedShow.UseVisualStyleBackColor = true;
            this.suspendedShow.Click += new System.EventHandler(this.suspendedShow_Click);
            // 
            // classShow
            // 
            this.classShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classShow.Location = new System.Drawing.Point(12, 400);
            this.classShow.Margin = new System.Windows.Forms.Padding(0);
            this.classShow.Name = "classShow";
            this.classShow.Size = new System.Drawing.Size(1048, 28);
            this.classShow.TabIndex = 71;
            this.classShow.Text = "Show class";
            this.classShow.UseVisualStyleBackColor = true;
            this.classShow.Click += new System.EventHandler(this.classShow_Click);
            // 
            // day2
            // 
            this.day2.autre = false;
            this.day2.BackColor = System.Drawing.Color.White;
            this.day2.Date = new System.DateTime(((long)(0)));
            this.day2.Examen = false;
            this.day2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2.ForeColor = System.Drawing.Color.Black;
            this.day2.Location = new System.Drawing.Point(88, 19);
            this.day2.Name = "day2";
            this.day2.PFI = false;
            this.day2.Size = new System.Drawing.Size(74, 74);
            this.day2.TabIndex = 70;
            this.day2.today = false;
            this.day2.TP = false;
            this.day2.weekend = false;
            // 
            // day3
            // 
            this.day3.autre = false;
            this.day3.BackColor = System.Drawing.Color.White;
            this.day3.Date = new System.DateTime(((long)(0)));
            this.day3.Examen = false;
            this.day3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day3.ForeColor = System.Drawing.Color.Black;
            this.day3.Location = new System.Drawing.Point(161, 19);
            this.day3.Name = "day3";
            this.day3.PFI = false;
            this.day3.Size = new System.Drawing.Size(74, 74);
            this.day3.TabIndex = 70;
            this.day3.today = false;
            this.day3.TP = false;
            this.day3.weekend = false;
            // 
            // day14
            // 
            this.day14.autre = false;
            this.day14.BackColor = System.Drawing.Color.White;
            this.day14.Date = new System.DateTime(((long)(0)));
            this.day14.Examen = false;
            this.day14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day14.ForeColor = System.Drawing.Color.Black;
            this.day14.Location = new System.Drawing.Point(964, 19);
            this.day14.Name = "day14";
            this.day14.PFI = false;
            this.day14.Size = new System.Drawing.Size(74, 74);
            this.day14.TabIndex = 79;
            this.day14.today = false;
            this.day14.TP = false;
            this.day14.weekend = false;
            // 
            // day7
            // 
            this.day7.autre = false;
            this.day7.BackColor = System.Drawing.Color.White;
            this.day7.Date = new System.DateTime(((long)(0)));
            this.day7.Examen = false;
            this.day7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day7.ForeColor = System.Drawing.Color.Black;
            this.day7.Location = new System.Drawing.Point(453, 19);
            this.day7.Name = "day7";
            this.day7.PFI = false;
            this.day7.Size = new System.Drawing.Size(74, 74);
            this.day7.TabIndex = 72;
            this.day7.today = false;
            this.day7.TP = false;
            this.day7.weekend = false;
            // 
            // day8
            // 
            this.day8.autre = false;
            this.day8.BackColor = System.Drawing.Color.White;
            this.day8.Date = new System.DateTime(((long)(0)));
            this.day8.Examen = false;
            this.day8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day8.ForeColor = System.Drawing.Color.Black;
            this.day8.Location = new System.Drawing.Point(526, 19);
            this.day8.Name = "day8";
            this.day8.PFI = false;
            this.day8.Size = new System.Drawing.Size(74, 74);
            this.day8.TabIndex = 73;
            this.day8.today = false;
            this.day8.TP = false;
            this.day8.weekend = false;
            // 
            // day10
            // 
            this.day10.autre = false;
            this.day10.BackColor = System.Drawing.Color.White;
            this.day10.Date = new System.DateTime(((long)(0)));
            this.day10.Examen = false;
            this.day10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day10.ForeColor = System.Drawing.Color.Black;
            this.day10.Location = new System.Drawing.Point(672, 19);
            this.day10.Name = "day10";
            this.day10.PFI = false;
            this.day10.Size = new System.Drawing.Size(74, 74);
            this.day10.TabIndex = 75;
            this.day10.today = false;
            this.day10.TP = false;
            this.day10.weekend = false;
            // 
            // day1
            // 
            this.day1.autre = false;
            this.day1.BackColor = System.Drawing.Color.White;
            this.day1.Date = new System.DateTime(((long)(0)));
            this.day1.Examen = false;
            this.day1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1.ForeColor = System.Drawing.Color.Black;
            this.day1.Location = new System.Drawing.Point(15, 19);
            this.day1.Name = "day1";
            this.day1.PFI = false;
            this.day1.Size = new System.Drawing.Size(74, 74);
            this.day1.TabIndex = 65;
            this.day1.today = false;
            this.day1.TP = false;
            this.day1.weekend = false;
            // 
            // day13
            // 
            this.day13.autre = false;
            this.day13.BackColor = System.Drawing.Color.White;
            this.day13.Date = new System.DateTime(((long)(0)));
            this.day13.Examen = false;
            this.day13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day13.ForeColor = System.Drawing.Color.Black;
            this.day13.Location = new System.Drawing.Point(891, 19);
            this.day13.Name = "day13";
            this.day13.PFI = false;
            this.day13.Size = new System.Drawing.Size(74, 74);
            this.day13.TabIndex = 78;
            this.day13.today = false;
            this.day13.TP = false;
            this.day13.weekend = false;
            // 
            // day9
            // 
            this.day9.autre = false;
            this.day9.BackColor = System.Drawing.Color.White;
            this.day9.Date = new System.DateTime(((long)(0)));
            this.day9.Examen = false;
            this.day9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day9.ForeColor = System.Drawing.Color.Black;
            this.day9.Location = new System.Drawing.Point(599, 19);
            this.day9.Name = "day9";
            this.day9.PFI = false;
            this.day9.Size = new System.Drawing.Size(74, 74);
            this.day9.TabIndex = 74;
            this.day9.today = false;
            this.day9.TP = false;
            this.day9.weekend = false;
            // 
            // day6
            // 
            this.day6.autre = false;
            this.day6.BackColor = System.Drawing.Color.White;
            this.day6.Date = new System.DateTime(((long)(0)));
            this.day6.Examen = false;
            this.day6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day6.ForeColor = System.Drawing.Color.Black;
            this.day6.Location = new System.Drawing.Point(380, 19);
            this.day6.Name = "day6";
            this.day6.PFI = false;
            this.day6.Size = new System.Drawing.Size(74, 74);
            this.day6.TabIndex = 70;
            this.day6.today = false;
            this.day6.TP = false;
            this.day6.weekend = false;
            // 
            // day12
            // 
            this.day12.autre = false;
            this.day12.BackColor = System.Drawing.Color.White;
            this.day12.Date = new System.DateTime(((long)(0)));
            this.day12.Examen = false;
            this.day12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day12.ForeColor = System.Drawing.Color.Black;
            this.day12.Location = new System.Drawing.Point(818, 19);
            this.day12.Name = "day12";
            this.day12.PFI = false;
            this.day12.Size = new System.Drawing.Size(74, 74);
            this.day12.TabIndex = 77;
            this.day12.today = false;
            this.day12.TP = false;
            this.day12.weekend = false;
            // 
            // day11
            // 
            this.day11.autre = false;
            this.day11.BackColor = System.Drawing.Color.White;
            this.day11.Date = new System.DateTime(((long)(0)));
            this.day11.Examen = false;
            this.day11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day11.ForeColor = System.Drawing.Color.Black;
            this.day11.Location = new System.Drawing.Point(745, 19);
            this.day11.Name = "day11";
            this.day11.PFI = false;
            this.day11.Size = new System.Drawing.Size(74, 74);
            this.day11.TabIndex = 76;
            this.day11.today = false;
            this.day11.TP = false;
            this.day11.weekend = false;
            // 
            // day5
            // 
            this.day5.autre = false;
            this.day5.BackColor = System.Drawing.Color.White;
            this.day5.Date = new System.DateTime(((long)(0)));
            this.day5.Examen = false;
            this.day5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day5.ForeColor = System.Drawing.Color.Black;
            this.day5.Location = new System.Drawing.Point(307, 19);
            this.day5.Name = "day5";
            this.day5.PFI = false;
            this.day5.Size = new System.Drawing.Size(74, 74);
            this.day5.TabIndex = 69;
            this.day5.today = false;
            this.day5.TP = false;
            this.day5.weekend = false;
            // 
            // day4
            // 
            this.day4.autre = false;
            this.day4.BackColor = System.Drawing.Color.White;
            this.day4.Date = new System.DateTime(((long)(0)));
            this.day4.Examen = false;
            this.day4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day4.ForeColor = System.Drawing.Color.Black;
            this.day4.Location = new System.Drawing.Point(234, 19);
            this.day4.Name = "day4";
            this.day4.PFI = false;
            this.day4.Size = new System.Drawing.Size(74, 74);
            this.day4.TabIndex = 68;
            this.day4.today = false;
            this.day4.TP = false;
            this.day4.weekend = false;
            // 
            // VisualOrganisationToolInterface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1070, 587);
            this.Controls.Add(this.classShow);
            this.Controls.Add(this.suspendedShow);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VisualOrganisationToolInterface";
            this.Text = "VisualOrganisationTool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taskName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox taskCurrent;
        private System.Windows.Forms.Button taskAdd;
        private System.Windows.Forms.ComboBox taskMonth;
        private System.Windows.Forms.NumericUpDown taskDay;
        private System.Windows.Forms.TextBox taskYear;
        private System.Windows.Forms.Button taskDelete;
        private System.Windows.Forms.ComboBox taskClass;
        private System.Windows.Forms.ComboBox taskType;
        private System.Windows.Forms.GroupBox groupBox4;
        private CubePanel day4;
        private CubePanel day5;
        private CubePanel day6;
        private CubePanel day7;
        private CubePanel day14;
        private CubePanel day8;
        private CubePanel day10;
        private CubePanel day13;
        private CubePanel day9;
        private CubePanel day12;
        private CubePanel day11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button taskUpdate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox taskNotes;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button deleteAllDue;
        private System.Windows.Forms.ListBox passDue;
        private System.Windows.Forms.ListBox nextDue;
        private System.Windows.Forms.TextBox nextDueDays;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private CubePanel day2;
        private CubePanel day3;
        private CubePanel day1;
        private System.Windows.Forms.Button suspendedShow;
        private System.Windows.Forms.Button classShow;
        private System.Windows.Forms.Button suspendTask;
        public System.Windows.Forms.TextBox Error;
        public System.Windows.Forms.TextBox Status;
    }
}

