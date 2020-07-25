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
        bool isSelected = false;

        public firstControlUser()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path.AddEllipse(0, 0, this.but_Do_1.Width + 10, this.but_Do_1.Height);
            Region Button_Region = new Region(Button_Path);
            this.but_Do_1.Region = Button_Region;
        }

        private void but_SelectPath_Click(object sender, EventArgs e)
        {
            //dialog with choosing a dir for start scanning
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.SelectedPath;
                txtB_Path.Text = path;
                isSelected = true;
                MessageBox.Show("Yea");
            }
        }

        private void but_Do_1_Click(object sender, EventArgs e)
        {
            if(isSelected)
            {
                TableForm table = new TableForm(txtB_Path.Text, dateTimePicker1, dateTimePicker2);
                table.Show();
            }
        }
    }
}
