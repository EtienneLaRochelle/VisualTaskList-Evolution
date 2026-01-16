using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/* * ======================================================================================
 * LEGACY CODE WARNING (Version 1.0)
 * ======================================================================================
 * This code represents the initial state of the project before refactoring.
 * It contains:
 * - Direct SQL dependencies (no Repository pattern)
 * - Tightly coupled UI logic (no MVP pattern)
 * - Mixed naming conventions
 * * Please refer to the "VisualTaskList" (Version 2.0) folder for the clean, 
 * refactored architecture.
 * ======================================================================================
 */

namespace VisualOrganisationTool
{
    public partial class VisualOrganisationToolInterface : Form
    {
        public SqlConnection Connection = new SqlConnection();
        SqlCommand CurrentView;
        public List<Task> Tasks;
        public List<Task> TasksCurrentList;
        List<Task> passDueTasks;
        List<Cour> Cours;
        List<CubePanel> days;
        TaskModifyPopUp taskModifyPopUP;
        ClassModifyPopUp classModifyPopUP;
        SuspendedMenu suspendedMenu;


        public override void Refresh()
        {
            suspendedMenu = new SuspendedMenu(this);
            suspendedMenu.Refresh();
            taskNotes.Text = "";
            InitiateControls();
            base.Refresh();
        }


        public void InitiateControls() //Remplit les sections
        {
            fillCurrentTask();
            fillPassDue();
            fillTaskClass();
            refreshRadar();
        }


        public void fillCurrentTask()
        {
            Tasks.Clear();
            TasksCurrentList.Clear();
            taskCurrent.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tasks", Connection);
            using (cmd)
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if ((string)reader[6] == "0")
                        {
                            TasksCurrentList.Add(new Task((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (DateTime)reader[4]));
                            taskCurrent.Items.Add(TasksCurrentList.Last().display());
                        }
                        Tasks.Add(new Task((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (DateTime)reader[4]));
                    }
                }
            }
        }


        public void fillTaskClass()
        {
            taskClass.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Class", Connection);
            using (cmd)
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cours.Add(new Cour((int) reader[0], (string)reader[1], (string)reader[2]));
                        taskClass.Items.Add($"{reader[2]} - {reader[1]}");
                    }
                }
            }
        }


        public void fillPassDue()
        {
            nextDueDays.Text = "";
            nextDue.Items.Clear();
            passDue.Items.Clear();
            if (Tasks.Count > 0)
            {

                for (int i = 0; i < Tasks.Count; i++)
                {
                    DateTime nextDueDate = Tasks[0].dueDate;
                    if (Tasks[i].dueDate <= nextDueDate && (Tasks[i].dueDate - DateTime.Now).Days >= 0)
                    {
                        nextDueDays.Text = ((Tasks[i].dueDate - DateTime.Now).Days+1).ToString();
                        nextDue.Items.Add(Tasks[i].display());
                    }
                }
            }
            for (int i = 0; i < Tasks.Count; i++)
            {
                if ((Tasks[i].dueDate - DateTime.Now).Days < 0)
                {
                    passDueTasks.Add(Tasks[i]);
                    passDue.Items.Add(Tasks[i].display());
                }
            }
        }


        public void refreshRadar()
        {
            days = new List<CubePanel>() { day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13, day14 };
            for (int i = 0; i < 14; i++)
            {
                days[i].labelText = DateTime.Now.AddDays(i).ToString("dd");
                days[i].Examen = false;
                days[i].PFI = false;
                days[i].TP = false;
                days[i].autre = false;
                if(i == 0)
                {
                    days[i].ForeColor = Color.MediumSeaGreen;
                }
                else if (days[i].labelText == "01")
                {
                    Font newMonthFont = new Font($"{days[i].Font}", 16);
                    days[i].Font = new Font(newMonthFont, FontStyle.Bold);
                }
                if (DateTime.Now.AddDays(i).DayOfWeek == DayOfWeek.Saturday || DateTime.Today.AddDays(i).DayOfWeek == DayOfWeek.Sunday)
                {
                    days[i].weekend = true;
                }
                foreach (Task task in Tasks)
                {
                    if (task.dueDate.ToString("yyyy MM dd") == DateTime.Now.AddDays(i).ToString("yyyy MM dd"))
                    {
                        switch (task.type)
                        {
                            case "Exam":
                                days[i].Examen = true;
                                break;
                            case "PFI":
                                days[i].PFI = true;
                                break;
                            case "TP":
                                days[i].TP = true;
                                break;
                            default:
                                days[i].autre = true;
                                break;
                        }
                    }
                }
            }
        }


        public VisualOrganisationToolInterface()
        {
            InitializeComponent();
            try
            {
                string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=VisualOrganisationTool;Integrated Security=True;";
                Tasks = new List<Task>();
                TasksCurrentList = new List<Task>();
                Cours = new List<Cour>();

                passDueTasks = new List<Task>();
                Connection = new SqlConnection(ConnectionString);
                Connection.Open();
                taskModifyPopUP = new TaskModifyPopUp(Connection,this);
                classModifyPopUP = new ClassModifyPopUp(Connection, this);
                for (int i = 1; i <= 12; i++)
                {
                    taskMonth.Items.Add(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(i));
                }
                taskYear.Text = DateTime.Today.ToString("yyyy");
                taskDay.Value = DateTime.Today.Day;
                taskMonth.SelectedIndex = int.Parse(DateTime.Today.ToString("MM"))-1;
                string[] type = {"Exam", "PFI", "TP"};
                taskType.Items.AddRange(type);
                InitiateControls();
                suspendedMenu = new SuspendedMenu(this);
            }
            catch (Exception ex) { Error.Text = ex.Message; };
            Status.Text = Connection.State.ToString();
        }


        private void taskAdd_Click(object sender, EventArgs e)
        {
            DateTime dueDate = DateTime.ParseExact($"{taskYear.Text.ToString()}-{taskMonth.Text.ToString()}-{taskDay.Value.ToString()}", "yyyy-MMM-d", CultureInfo.CurrentCulture);
            SqlCommand cmd = new SqlCommand("INSERT INTO Tasks(name, Class,Type, Date) VALUES(@name, @class, @type, @dueDate);", Connection);
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = taskName.Text;
            if(taskClass.SelectedIndex == -1)
            {
                cmd.Parameters.Add("@class", SqlDbType.VarChar).Value = taskClass.Text;
            }
            else
            {
                cmd.Parameters.Add("@class", SqlDbType.VarChar).Value = Cours[taskClass.SelectedIndex].shortName;
            }
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = taskType.Text;
            cmd.Parameters.Add("@dueDate", SqlDbType.Date).Value = dueDate;
            cmd.ExecuteNonQuery();
            taskName.Text = "";
            taskClass.Text = "";
            taskType.Text = "";
            this.Refresh();
        }


        private void taskDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Tasks WHERE id = @id", Connection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = TasksCurrentList[taskCurrent.SelectedIndex].id;
                cmd.ExecuteNonQuery();
                taskNotes.Text = "";
                this.Refresh();
            }
            catch (Exception ex) { Error.Text = ex.Message; };
        }


        private void taskUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                TaskModifyPopUp modifyPopUp = new TaskModifyPopUp(Connection, this);
                modifyPopUp.ShowDialog(TasksCurrentList[taskCurrent.SelectedIndex]);
            }
            catch (Exception ex) { Error.Text = ex.Message; };
        }


        private void taskCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                SqlCommand cmd = new SqlCommand($"SELECT notes FROM tasks WHERE id=@id;", Connection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = TasksCurrentList[taskCurrent.SelectedIndex].id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                        if (reader[0] != null)
                            taskNotes.Text = reader[0].ToString();
            }
            catch (Exception ex) { Error.Text = ex.Message; };
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.ActiveControl = null;
            Connection = null;
            base.OnFormClosing(e);
        }


        private void taskNotes_LostFocus(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"UPDATE Tasks SET notes=@notes WHERE id=@id", Connection);
                cmd.Parameters.Add("@notes", SqlDbType.VarChar).Value = taskNotes.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = TasksCurrentList[taskCurrent.SelectedIndex].id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { Error.Text = ex.Message; };
        }


        private void deleteAllDue_Click(object sender, EventArgs e)
        {
            foreach(Task task in passDueTasks)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Tasks WHERE id = @id", Connection);
                cmd.Parameters.AddWithValue("@id", $"{task.id}");
                cmd.ExecuteNonQuery();
            }
            this.Refresh();
        }


        private void taskYear_LostFocus(object sender, EventArgs e)
        {
            taskDay.Maximum = DateTime.DaysInMonth(int.Parse(taskYear.Text), (int)taskMonth.SelectedIndex + 1);
        }


        private void taskMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            taskDay.Maximum = DateTime.DaysInMonth(int.Parse(taskYear.Text), (int)taskMonth.SelectedIndex + 1);
        }


        private void classShow_Click(object sender, EventArgs e)
        {
            ClassMenu classMenu = new ClassMenu(this);
            classMenu.ShowDialog();
        }

        private void suspendedShow_Click(object sender, EventArgs e)
        {
            suspendedMenu.ShowDialog();
        }

        private void suspendTask_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"UPDATE tasks SET Suspended=1 WHERE id=@id;", Connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = TasksCurrentList[taskCurrent.SelectedIndex].id;
            cmd.ExecuteNonQuery();
            Refresh();
            suspendedMenu.Refresh();
        }
    }

}
