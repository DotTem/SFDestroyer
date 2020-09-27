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
using System.Threading;
using System.Drawing.Text;

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
                mouseX = MousePosition.X - ActiveForm.Size.Width / 2;
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


        //creating list for temporary files
        private List<string> tempFiles = new List<string>();
        private List<string> tempDirs = new List<string>();
        //creating lists for files and directories
        private List<string> allFiles = new List<string>();
        private List<string> allDirs = new List<string>();
        //Timer
        private int timerSeconds = 0;

        public TableForm()
        {
            
        }

        public TableForm(string path, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2, string[] filter)
        {
            InitializeComponent();

            txtBox_Console.Text += ("Started scanning...");
            //Start of Timer(Time passed)
            timeDoing.Enabled = true;
            timeDoing.Start();

            ScannerAsync();

            async void ScannerAsync()
            {
                await Task.Run(() => Scanner(path));

                txtBox_Console.Text += ("\r\nEnded scanning. Starting visualization...");
                
                //Adding files to List<>
                foreach (string filetemp in tempFiles)
                {
                    
                        allFiles.Add(filetemp);
                }
                //Adding file names to listBox
                foreach (string files in allFiles)
                {
                    //if using filter
                    if (filter.Length > 0 && (Path.GetExtension(files) == filter[0] || Path.GetExtension(files) == filter[1]))
                        list_NT.Items.Add(Path.GetFileName(files)).SubItems.Add(Path.GetExtension(files));
                    //if no filter
                    else if (filter.Length == 0)
                        list_NT.Items.Add(Path.GetFileName(files)).SubItems.Add(Path.GetExtension(files));

                }
                //Adding dir names to listbox
                foreach(string dirs in allDirs)
                {
                    lstBox_Dirs.Items.Add(Path.GetFileName(dirs));
                }

                timeDoing.Stop();

                txtBox_Console.Text += ("\r\nEnded visualization. Done!");
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
                                tempFiles.Add(file);
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
                                //Clearing list of temp files
                                tempFiles.Clear();
                            }
                            //Adding files in lst_NT if their count <= 5
                            if(tempFiles.Count <= 5 && tempFiles.Count != 0)
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
                catch (Exception) 
                {
                    
                }
            }
        }


        private void label_CloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Double click on file
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
            //Open explorer with selected file
            Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + textfile));
        }

        //Double click on dir
        private void lstBox_Dirs_DoubleClick(object sender, EventArgs e)
        {
            string textdir = allDirs[lstBox_Dirs.SelectedIndex];
            //Open explorer with selected dir
            Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + textdir));
        }

        private void but_Del_Click(object sender, EventArgs e)
        {
            //Delete file from file system
            File.Delete(allFiles[list_NT.SelectedIndices[0]]);
            //Delete file path from list<>
            allFiles.RemoveAt(list_NT.SelectedIndices[0]);

            //Updating listview
            list_NT.Items.Clear();
            foreach (string file in allFiles)
            {
                list_NT.Items.Add(Path.GetFileName(file)).SubItems.Add(Path.GetExtension(file));
            }
        }

        private void timeDoing_Tick(object sender, EventArgs e)
        {
            timerSeconds++;
            TimeSpan span = TimeSpan.FromMinutes(timerSeconds);
            label_Timer.Text = span.ToString(@"hh\:mm");
        }

    }
}
