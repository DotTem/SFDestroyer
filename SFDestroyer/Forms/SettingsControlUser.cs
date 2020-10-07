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
using System.Net;

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
            string city = txtBox_citySet.Text;

            if(e.KeyCode == Keys.Enter && city != null )
            {
                e.SuppressKeyPress = true;
                try
                {
                    using (WebClient checking = new WebClient { Encoding = Encoding.UTF8 })
                    {
                        checking.Proxy = new WebProxy();
                        checking.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=0ed1773f3181837e871a4af846d38ab1");
                    }
                    Properties.Settings.Default.CitySetDefault = city;
                    MessageBox.Show("City " + '"' + city +'"' + " set to default");
                }
                catch
                {
                    MessageBox.Show("No city with " + '"' + city +'"' + " name");
                }
                
                
            }
        }
    }
}
