using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;



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

            foreach(string filetemp in tempFiles)
            {
                allFiles.Add(filetemp);
            }

            foreach(string files in allFiles)
            {
                list_NT.Items.Add(Path.GetFileName(files)).SubItems.Add(Path.GetExtension(files));
            }
            
            void Scanner(string mainPath)
            {
                //array = files and subdirs in current directory [path]
                string[] files_path = Directory.GetFileSystemEntries(mainPath);
                int file_count = 0;

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
                                tempFiles.Add(file);
                                file_count++;
                            }
                        }
                        //if dir
                        else if (Directory.Exists(file))
                        {
                            Scanner(file);
                            //Adding dirs names in listbox
                            if (tempFiles.Count > 5)
                            {
                                int position = 0;

                                // Find position of last "\"
                                for (int counter = file.Length - 1; counter != 0; counter--)
                                {
                                    if (file[counter].ToString(CultureInfo.InvariantCulture) == "\\")
                                    {

                                        position = counter;
                                        break;
                                    }
                                }
                                //add dir path to list<>
                                allDirs.Add(file);
                                //add dir name to listbox
                                lstBox_Dirs.Items.Add(Path.GetFileName(file));
                                //Clearing list of temp files
                                tempFiles.Clear();
                            }
                            else if(tempFiles.Count <= 5 && tempFiles.Count != 0)
                            {
                                foreach(string name in tempFiles)
                                {
                                    allFiles.Add(name);
                                }
                                tempFiles.Clear();
                            }
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

        private void list_NT_DoubleClick(object sender, EventArgs e)
        {
            //Return selected index
            string textfile = allFiles[list_NT.SelectedIndices[0]];
            int position = 0;

            // Find position of last "\"
            for (int counter = textfile.Length - 1; counter != 0; counter--)
            {
                if (textfile[counter].ToString(CultureInfo.InvariantCulture) == "\\")
                {

                    position = counter;
                    break;
                }
            }
            //Start explorer.exe
            Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + textfile));
        }

        private void lstBox_Dirs_DoubleClick(object sender, EventArgs e)
        {
            string textdir = allDirs[lstBox_Dirs.SelectedIndex];

            Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + textdir));
        }

        private void but_Del_Click(object sender, EventArgs e)
        {
            File.Delete(allFiles[list_NT.SelectedIndices[0]]);
            allFiles.RemoveAt(list_NT.SelectedIndices[0]);
            list_NT.Items.Clear();

            foreach (string file in allFiles)
            {
                list_NT.Items.Add(Path.GetFileName(file)).SubItems.Add(Path.GetExtension(file));
            }
        }


    }
}
