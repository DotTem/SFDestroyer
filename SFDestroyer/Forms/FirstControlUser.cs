﻿using System;
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
        private string[] filtersText = { ".txt", ".pdf" };
        private string[] filterVideo = { ".mp4", ".avi" };
        private string[] filterImage = { ".jpg", ".jpeg", ".png" };
        private string[] filterSelf = { };

        bool isSelectedPath = false;

        public firstControlUser()
        {
            InitializeComponent();
            foreach(string filter in Properties.Settings.Default.FilterSelf)
            {
                treeFilt.Nodes.Add(filter);
            }
        }

        private void but_SelectPath_Click(object sender, EventArgs e)
        {
            //dialog with choosing a dir for start scanning
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.SelectedPath;
                txtB_Path.Text = path;
                isSelectedPath = true;
            }
        }

        private void but_Do_1_Click(object sender, EventArgs e)
        {
            if(isSelectedPath)
            {
                switch(cmvBox_Filter.SelectedIndex)
                {
                    case 0:
                        TableForm tableText = new TableForm(txtB_Path.Text, dateTimePicker1, dateTimePicker2, filtersText);
                        tableText.Show();
                        break;
                    case 1:
                        TableForm tableVideo = new TableForm(txtB_Path.Text, dateTimePicker1, dateTimePicker2, filterVideo);
                        tableVideo.Show();
                        break;
                    case 2:
                        TableForm tableImage = new TableForm(txtB_Path.Text, dateTimePicker1, dateTimePicker2, filterImage);
                        tableImage.Show();
                        break;
                    case -1:
                        TableForm tableDefault = new TableForm(txtB_Path.Text, dateTimePicker1, dateTimePicker2);
                        tableDefault.Show();
                        break;
                        
                }
            }
        }
    }
}
