using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using GSMNLib;
using SFDestroyer.Classes;

namespace SFDestroyer.Forms
{
    public partial class ReviewsControlUser : UserControl
    {

        public ReviewsControlUser()
        {
            InitializeComponent();
        }

        private void but_addPanel_Click(object sender, EventArgs e)
        {
            ReviewsLib.CreateForm(panel_Films);
        }

        private void but_removeFilm_Click(object sender, EventArgs e)
        {
            ReviewsLib.removeFilm(ReviewsLib.panelsList, 2);
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            ReviewsLib.UpdateParentPanel(panel_Films);
        }
    }
}
