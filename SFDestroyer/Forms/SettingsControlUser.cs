using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFDestroyer.Properties;

namespace SFDestroyer.Forms
{
    public partial class SettingsControlUser : UserControl
    {
        public SettingsControlUser()
        {
            InitializeComponent();
        }

        private void txtBox_citySet_Enter(object sender, EventArgs e)
        {
            txtBox_citySet.Clear();
            txtBox_citySet.ForeColor = Color.White;
        }

        private void txtBox_citySet_Leave(object sender, EventArgs e)
        {
            txtBox_citySet.Text = Properties.Settings.Default.CitySetDefault;
            txtBox_citySet.ForeColor = Color.Gray;
        }

        private void txtBox_citySet_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txtBox_citySet.Text != null)
            {
                Properties.Settings.Default.CitySetDefault = txtBox_citySet.Text;
            }
        }
    }
}
