using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SFDestroyer.Forms
{
    public partial class firstControlUser : UserControl
    {
        //creating lists for files and directories
        private List<string> allFiles = new List<string>();
        private List<string> allDirs = new List<string>();
        private string output = "";

        public firstControlUser()
        {
            InitializeComponent();
        }

        private void but_Do_1_Click(object sender, EventArgs e)
        {
            allFiles.Clear();
            allDirs.Clear();
            output = "";
            list_NT.Items.Clear();

            //dialog with choosing a dir for start scanning
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.SelectedPath;

                Scanner(path);

                //add items in listview
                foreach (string file in allFiles)
                {
                    list_NT.Items.Add(Path.GetFileNameWithoutExtension(file)).SubItems.Add(Path.GetExtension(file));
                }
                MessageBox.Show("Yea");
            }
        }

        private void Scanner(string path)
        {
            //array = files and subdirs in current directory [path]
            string[] files_path = Directory.GetFileSystemEntries(path);
            try
            {
                foreach(string file in files_path)
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
            catch(System.UnauthorizedAccessException)
            {

            }
                
        }
    }
}
