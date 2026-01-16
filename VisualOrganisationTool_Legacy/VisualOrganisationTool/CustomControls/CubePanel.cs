using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualOrganisationTool;

namespace VisualOrganisationTool
{
    public class CubePanel : Panel
    {
        public bool Examen { get; set; }
        public bool PFI { get; set; }
        public bool autre { get; set; }
        public bool today { get; set; }
        public bool TP { get; set; }
        public bool weekend { get; set; }

        public static List<CubePanel> getAllCubes = new List<CubePanel>();

        List<string> multipleDue;

        public DateTime Date { get; set; }

        public string labelText = "day";

        Label labelDate = new Label();

        public CubePanel()
        {
            labelDate.BackColor = Color.Transparent;
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(labelDate);
            multipleDue = new List<string>();
            getAllCubes.Add(this);
        }

        public void fillColor(List<string> toDraw, PaintEventArgs e)
        {
            for (int i = 0; i < toDraw.Count(); i++)
            {
                switch (toDraw[i])
                {
                    case "exam":
                        e.Graphics.FillRectangle(Brushes.Red, 0, this.Height / toDraw.Count() * i, this.Width, this.Height / toDraw.Count());
                        break;
                    case "pfi":
                        e.Graphics.FillRectangle(Brushes.Orange, 0, 0 + this.Height / toDraw.Count() * i, this.Width, this.Height / toDraw.Count());
                        break;
                    case "tp":
                        e.Graphics.FillRectangle(Brushes.Yellow, 0, 0 + this.Height / toDraw.Count() * i, this.Width, this.Height / toDraw.Count());
                        break;
                    case "autre":
                        e.Graphics.FillRectangle(Brushes.LightSalmon, 0, 0 + this.Height / toDraw.Count() * i, this.Width, this.Height / toDraw.Count());
                        break;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (weekend)
            {
                e.Graphics.FillRectangle(Brushes.Gray, 0, 0, this.Width, this.Height);
            }
            if (Examen) { multipleDue.Add("exam"); }
            if (PFI) { multipleDue.Add("pfi"); }
            if (TP) { multipleDue.Add("tp"); }
            if (autre) { multipleDue.Add("autre"); }

            if (multipleDue.Any())
            {
                fillColor(multipleDue, e);
                multipleDue.Clear();
            }

            e.Graphics.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);

            Label labelDate = (Label)this.Controls[0];
            labelDate.Text = labelText;
            int x = (this.Width - labelDate.Width) / 2;
            int y = (this.Height - labelDate.Height) / 2;
            labelDate.Location = new Point(x, y);
        }
    }
}



