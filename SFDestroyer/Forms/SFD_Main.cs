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

namespace SFDestroyer
{
    public partial class SFD_Main : Form
    {
        Color mainColor = Color.FromArgb(64, 64, 64);
        Color cuColor = Color.FromArgb(50, 50, 50);
        
        #region Moving
        //coords of mouse
        private int mouseX = 0;
        private int mouseY = 0;
        //is mouse down
        bool MouseDown = false;
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
            but_First_Click(Owner, null);
        }

        private void but_First_Click(object sender, EventArgs e)
        {
            firstControlUser.BringToFront();
            but_First.BackColor = cuColor;
            but_Weather.BackColor = mainColor;
        }

        private void label_CloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_Weather_Click(object sender, EventArgs e)
        {
            weatherControlUser.BringToFront();
            but_First.BackColor = mainColor;
            but_Weather.BackColor = cuColor;
        }
    }
}
