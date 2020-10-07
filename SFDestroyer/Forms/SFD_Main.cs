using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SFDestroyer.Forms;
using System.Net;

namespace SFDestroyer
{
    public partial class SFD_Main : Form
    {

        #region Moving
        //coords of mouse
        private int mouseX = 0;
        private int mouseY = 0;
        //is mouse down
        private bool MouseDown = false;
        private void panel_Upper_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
        }

        private void panel_Upper_MouseMove(object sender, MouseEventArgs e)
        {
            if(MouseDown)
            {

                //set variables = panel center
                mouseX = MousePosition.X - ActiveForm.Width / 2;
                mouseY = MousePosition.Y - panel_Upper.Size.Height / 2;
                //set window on variables coords
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel_Upper_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }
        #endregion

        public SFD_Main()
        {
            InitializeComponent();
            //timer for date\time label
            timer_curTime.Interval = 500;
            timer_curTime.Enabled = true;
            timer_curTime.Start();

            but_First_Click(Owner, null);

        }

        private void but_First_Click(object sender, EventArgs e)
        {
            firstControlUser.BringToFront();
            but_First.BackColor = Color.FromArgb(50, 50, 50);
            but_Weather.BackColor = Color.FromArgb(64, 64, 64);
            but_Settings.BackColor = Color.FromArgb(64, 64, 64);
            but_FTP.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void label_CloseWindow_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Close();
        }

        private void but_Weather_Click(object sender, EventArgs e)
        {
            WeatherControlUser.BringToFront();
            but_First.BackColor = Color.FromArgb(64, 64, 64);
            but_Weather.BackColor = Color.FromArgb(50, 50, 50);
            but_Settings.BackColor = Color.FromArgb(64, 64, 64);
            but_FTP.BackColor = Color.FromArgb(64, 64, 64);

        }

        private void timer_curTime_Tick(object sender, EventArgs e)
        {
            label_curTime.Text = DateTime.Now.ToString();
        }

        private void but_Settings_Click(object sender, EventArgs e)
        {
            SettingsControlUser.BringToFront();
            but_First.BackColor = Color.FromArgb(64, 64, 64);
            but_Weather.BackColor = Color.FromArgb(64,64,64);
            but_Settings.BackColor = Color.FromArgb(50, 50, 50);
            but_FTP.BackColor = Color.FromArgb(64, 64, 64);
            
        }

        private void but_FTP_Click(object sender, EventArgs e)
        {
            FtpControlUser.BringToFront();
            but_First.BackColor = Color.FromArgb(64, 64, 64);
            but_Weather.BackColor = Color.FromArgb(64, 64, 64);
            but_Settings.BackColor = Color.FromArgb(64, 64, 64);
            but_FTP.BackColor = Color.FromArgb(50, 50, 50);
        }
    }
}
