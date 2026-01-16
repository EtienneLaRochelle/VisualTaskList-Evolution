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
    public partial class ClassMenu : Form
    {
        VisualOrganisationToolInterface mainForm;
        List<Cour> Cours;
        ClassModifyPopUp classModifyPopUP;
        public static SqlConnection Connection;

        public ClassMenu(VisualOrganisationToolInterface mainForm)
        {
            InitializeComponent();
            try
            {
                Connection = mainForm.Connection;
                this.mainForm = mainForm;
                Cours = new List<Cour>();
                classModifyPopUP = new ClassModifyPopUp(Connection,this);
                InitiateControls();
            }
            catch (Exception ex) { Error.Text = ex.Message; };
            Status.Text = mainForm.Connection.State.ToString();
        }


        public void InitiateControls()
        {
            fillCurrentClass();
        }


        public void fillCurrentClass()
        {
            Cours.Clear();
            classCurrent.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Class", mainForm.Connection);
            using (cmd)
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cours.Add(new Cour((int)reader[0], (string)reader[1], (string)reader[2]));
                        classCurrent.Items.Add($"{reader[2]} - {reader[1]}");
                    }
                }
            }
        }


        public override void Refresh()
        {
            InitiateControls();
            mainForm.Refresh();
            base.Refresh();
        }


        private void classAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"INSERT INTO Class(name, short) VALUES(@name, @short);", mainForm.Connection);
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = className.Text;
            cmd.Parameters.Add("@short", SqlDbType.VarChar).Value = classShort.Text;
            cmd.ExecuteNonQuery();
            className.Text = "";
            classShort.Text = "";
            this.Refresh();
        }


        private void classModify_Click(object sender, EventArgs e)
        {
            try
            {
                ClassModifyPopUp modifyPopUp = new ClassModifyPopUp(Connection, this);
                modifyPopUp.ShowDialog(Cours[classCurrent.SelectedIndex]);
            }
            catch (Exception ex) { Error.Text = ex.Message; };
        }


        private void classDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Class WHERE id = @id", mainForm.Connection);
                cmd.Parameters.AddWithValue("@id", $"{Cours[classCurrent.SelectedIndex].id}");
                cmd.ExecuteNonQuery();
                this.Refresh();
            }
            catch (Exception ex) { Error.Text = ex.Message; };
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.ActiveControl = null;
            Connection = null;
            base.OnFormClosing(e);
        }


        private void classNotes_LostFocus(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Class SET notes=@note WHERE id=@id", Connection);
                cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = classNotes.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Cours[classCurrent.SelectedIndex].id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { Error.Text = ex.Message; };
        }


        private void classCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"SELECT notes FROM Class WHERE id={Cours[classCurrent.SelectedIndex].id};", Connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader[0] != null)
                        {
                            classNotes.Text = reader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex) { Error.Text = ex.Message; };
        }
    }
}