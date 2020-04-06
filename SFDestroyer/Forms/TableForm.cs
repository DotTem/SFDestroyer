using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFDestroyer.Forms;
using System.IO;

namespace SFDestroyer.Forms
{
    public partial class TableForm : Form
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
            if (MouseDown)
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

        //creating lists for files and directories
        private List<string> allFiles = new List<string>();
        private List<string> tempFiles = new List<string>();
        private List<string> allDirs = new List<string>();

        public TableForm(string path, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2)
        {
            InitializeComponent();
            Scanner(path);

            foreach(string files in allFiles)
            {
                list_NT.Items.Add(files).SubItems.Add(Path.GetExtension(files));
            }
            
            void Scanner(string mainPath)
            {
                //array = files and subdirs in current directory [path]
                string[] files_path = Directory.GetFileSystemEntries(mainPath);
                try
                {
                    foreach (string file in files_path)
                    {
                        //if file
                        if (File.Exists(file))
                        {
                            //checking date file last opened
                            if (dateTimePicker1.Value.Ticks < Convert.ToInt64(File.GetLastWriteTime(file).Ticks) && Convert.ToInt64(File.GetLastWriteTime(file).Ticks) < dateTimePicker2.Value.Ticks)
                            {
                                //add file path to list<>
                                allFiles.Add(file);
                            }
                        }
                        else if (Directory.Exists(file))
                        {
                            Scanner(file);
                        }
                    }
                }
                catch (System.UnauthorizedAccessException)
                {

                }
            }
        }


        private void label_CloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }
       


    }
}
