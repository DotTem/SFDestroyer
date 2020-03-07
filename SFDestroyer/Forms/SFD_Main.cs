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

namespace SFDestroyer
{
    public partial class SFD_Main : Form
    {
        

        #region Moving
        //coords of nouse
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
                mouseX = MousePosition.X - SFD_Main.ActiveForm.Size.Width / 2;
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
            
            firstControlUser1.BringToFront();
        }

        private void but_First_Click(object sender, EventArgs e)
        {
            firstControlUser1.BringToFront();

       /*     //if file date later than dateTimePicker date
            if (Convert.ToInt64(File.GetLastAccessTime("F:/Visual Studio/Source/Repos/SortingInFolder/Personal.sln").Ticks) > Convert.ToInt64(dateTimePicker1.Value.Ticks))
            {
                label1.Text = "YAAAAA"; 
            }
            else
            {
                label1.Text = "No";
            }*/
        }

        private void label_CloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
