using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace VisualOrganisationTool
{
    public partial class SuspendedMenu : Form
    {
        VisualOrganisationToolInterface mainForm;
        List<Task> Tasks;
        ClassModifyPopUp classModifyPopUP;
        public static SqlConnection Connection;
        public SuspendedMenu(VisualOrganisationToolInterface mainForm)
        {
            InitializeComponent();
            try
            {
                Connection = mainForm.Connection;
                this.mainForm = mainForm;
                Tasks = new List<Task>();
                InitiateControls();
            }
            catch (Exception ex) { mainForm.Error.Text = ex.Message; };
            mainForm.Status.Text = mainForm.Connection.State.ToString();
        }

        public override void Refresh()
        {
            taskNotes.Text = "";
            InitiateControls();
            base.Refresh();
        }

        public void InitiateControls()
        {
            fillCurrentTask();
        }

        public void fillCurrentTask()
        {
            Tasks.Clear();
            taskSuspended.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tasks WHERE suspended = 1;", Connection);
            using (cmd)
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tasks.Add(new Task((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (DateTime)reader[4]));
                        taskSuspended.Items.Add(Tasks.Last().display());
                    }
                }
            }
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
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Tasks[taskSuspended.SelectedIndex].id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { mainForm.Error.Text = ex.Message; };
        }




        private void taskSuspended_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"SELECT notes FROM tasks WHERE id=@id;", Connection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Tasks[taskSuspended.SelectedIndex].id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader[0] != null)
                        {
                            taskNotes.Text = reader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex) { mainForm.Error.Text = ex.Message; };
        }

        private void suspendedSend_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"UPDATE tasks SET Suspended=0 WHERE id=@id;", Connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Tasks[taskSuspended.SelectedIndex].id;
            cmd.ExecuteNonQuery();
            Refresh();
            mainForm.Refresh();
        }

        private void suspendedDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Tasks WHERE id = @id", Connection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Tasks[taskSuspended.SelectedIndex].id;
                cmd.ExecuteNonQuery();
                taskNotes.Text = "";
                this.Refresh();
            }
            catch (Exception ex) { mainForm.Error.Text = ex.Message; };
        }

        private void suspendedUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                TaskModifyPopUp modifyPopUp = new TaskModifyPopUp(Connection, this);
                modifyPopUp.ShowDialog(Tasks[taskSuspended.SelectedIndex]);
                mainForm.Refresh();
            }
            catch (Exception ex) { mainForm.Error.Text = ex.Message; };
        }
    }
}
