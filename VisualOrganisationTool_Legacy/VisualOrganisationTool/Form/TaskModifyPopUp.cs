using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualOrganisationTool
{
    public partial class TaskModifyPopUp : Form
    {
        public TaskModifyPopUp(SqlConnection Connection, Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.Connection = Connection;
        }


        public bool isShown = false;
        SqlConnection Connection;
        Task toUpdate;
        Form mainForm;


        private void taskUpdateCancel_Click(object sender, EventArgs e)
        {
            isShown = false;
            this.Hide();
        }


        public new void ShowDialog(Task toUpdate)
        {
            this.toUpdate = toUpdate;
            taskName.Text = toUpdate.name;
            taskClass.Text = toUpdate.className;
            taskType.Text = toUpdate.type;
            taskType.Items.Clear();
            string[] type = { "Exam", "PFI", "TP" };
            taskType.Items.AddRange(type);
            taskClass.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Class", Connection);
            using (cmd)
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        taskClass.Items.Add($"{reader[2]}");
                    }
                }
            }
            taskMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                taskMonth.Items.Add(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(i));
            }
            taskYear.Text = toUpdate.dueDate.ToString("yyyy");
            taskDay.Text = toUpdate.dueDate.ToString("dd");
            taskMonth.SelectedIndex = int.Parse(DateTime.Today.ToString("MM")) - 1;
            isShown = true;
            base.ShowDialog();
        }

        private void taskModify_Click(object sender, EventArgs e)
        {
            DateTime dueDate = DateTime.ParseExact($"{taskYear.Text.ToString()}-{taskMonth.Text.ToString()}-{taskDay.Value.ToString()}", "yyyy-MMM-d", CultureInfo.CurrentCulture);
            SqlCommand cmd = new SqlCommand($"UPDATE Tasks SET name='{taskName.Text}', Class='{taskClass.Text}', type='{taskType.Text}', Date='{dueDate}' WHERE id={toUpdate.id};", Connection);
            cmd.ExecuteNonQuery();
            mainForm.Refresh();
            isShown = false;
            this.Hide();
        }

        private void taskYear_LostFocus_1(object sender, EventArgs e)
        {
            taskDay.Maximum = DateTime.DaysInMonth(int.Parse(taskYear.Text), (int)taskMonth.SelectedIndex + 1);
        }

        private void taskMonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            taskDay.Maximum = DateTime.DaysInMonth(int.Parse(taskYear.Text), (int)taskMonth.SelectedIndex + 1);
        }


    }
}
