using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualTaskList.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace VisualTaskList.CustomControls
{
    public partial class CubeCalendar : UserControl
    {
        public FlowLayoutPanel LegendPanel;
        public const int DayPanelLength = 14;

        public CubeCalendar()
        {
            InitializeComponent();
            LegendPanel = LegendLayout;
            DateTime today = DateTime.Now;
            Label todayCube = (Label)DayPanel.GetControlFromPosition(0, 0);
            todayCube.Text = today.Day.ToString();
            todayCube.Font = new Font(todayCube.Font, FontStyle.Bold);
            for (int i = 1; i < DayPanelLength; i++)
            {
                DateTime day = today.AddDays(i);
                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                {
                    ((Label)DayPanel.GetControlFromPosition(i, 0)).BackColor = Color.DarkGray;
                }
                ((Label)DayPanel.GetControlFromPosition(i, 0)).Text = day.Day.ToString();
            }
        }


        /// <summary>
        /// Dynamically renders a "Heat Map" representation of tasks for a specific day.
        /// Instead of using standard controls, this method uses GDI+ to generate a custom Bitmap in memory.
        /// It mathematically calculates the pixel height of each color block to visualize multiple task types stacked on a single date.
        /// </summary>
        public void SetDayColor(int dayOffset, List<Color> colors)
        {
            if (dayOffset >= 0 && dayOffset < DayPanel.ColumnCount)
            {
                Label dayLabel = (Label)DayPanel.GetControlFromPosition(dayOffset, 0);

                //Reset the background image if it exists.
                if (dayLabel.BackgroundImage != null)
                {
                    dayLabel.BackgroundImage.Dispose();
                    dayLabel.BackgroundImage = null;
                }

                //Color weekends in darkGray if they are no tasks for the day.
                if (colors == null || colors.Count == 0)
                {
                    if(DateTime.Today.AddDays(dayOffset).DayOfWeek == DayOfWeek.Saturday || DateTime.Today.AddDays(dayOffset).DayOfWeek == DayOfWeek.Sunday)
                    {
                        dayLabel.BackColor = Color.DarkGray;
                    }
                    else
                    {
                        dayLabel.BackColor = Color.White;
                    }
                    return;
                }

                int w = dayLabel.Width;
                int h = dayLabel.Height;

                Bitmap dynamicBitmap = new Bitmap(w, h);

                using (Graphics g = Graphics.FromImage(dynamicBitmap))
                {
                    //Fill the background with black to create separator lines between color blocks.

                    // EXPLANATION: Drawing lines with a single pixel thickness often results in rendering artifacts (blurring).
                    // SOLUTION: We fill the entire background with black first, then draw the colored blocks on top with a 1-pixel gap.
                    // This ensures crisp, pixel-perfect separator lines regardless of the display scaling.

                    g.Clear(Color.Black);
                    for (int i = 0; i < colors.Count; i++)
                    {
                        int topY = (int) ((float) h * i / colors.Count);
                        int bottomY = (int) ((float) h * (i + 1) / colors.Count);
                        int blockHeight = bottomY - topY;

                        //prevent the black separator line to appear under the last block
                        if (i < colors.Count - 1)
                        {
                            blockHeight -= 1;
                        }

                        using (SolidBrush brush = new SolidBrush(colors[i]))
                        {
                            g.FillRectangle(brush, 0, topY, w, blockHeight);
                        }
                    }
                }

                dayLabel.BackgroundImage = dynamicBitmap;
                dayLabel.BackgroundImageLayout = ImageLayout.Center;
                dayLabel.BackColor = Color.Transparent;
            }
        }

    }
}
