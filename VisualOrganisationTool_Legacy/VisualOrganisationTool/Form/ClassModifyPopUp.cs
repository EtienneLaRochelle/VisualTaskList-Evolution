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

namespace VisualOrganisationTool
{
    public partial class ClassModifyPopUp : Form
    {
        public bool isShown = false;
        SqlConnection Connection;
        Cour toUpdate;
        Form mainForm;

        public ClassModifyPopUp(SqlConnection Connection, Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.Connection = Connection;
        }


        private void classUpdateCancel_Click(object sender, EventArgs e)
        {
            isShown = false;
            this.Close();
        }


        public new void ShowDialog(Cour toUpdate)
        {
            this.toUpdate = toUpdate;
            className.Text = toUpdate.name;
            classShort.Text = toUpdate.shortName;
            isShown = true;
            base.ShowDialog();
        }


        private void classModify_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"UPDATE Tasks SET class='{classShort.Text}' WHERE class='{toUpdate.shortName}';", Connection);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand($"UPDATE Class SET name='{className.Text}', short='{classShort.Text}' WHERE id={toUpdate.id};", Connection);
            cmd.ExecuteNonQuery();
            mainForm.Refresh();
            isShown = false;
            this.Close();
        }
    }
}
