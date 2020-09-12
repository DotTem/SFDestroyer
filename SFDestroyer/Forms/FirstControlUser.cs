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
        bool isSelectedPath = false;

        public firstControlUser()
        {
            InitializeComponent();
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
                TableForm table = new TableForm(txtB_Path.Text, dateTimePicker1, dateTimePicker2);
                table.Show();
            }
        }
    }
}
