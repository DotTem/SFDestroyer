using SFDestroyer.Forms;
using System;
using System.Activities;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SFDestroyer.Classes
{
    class ReviewsLib
    {
        //global
        public static Panel parPanel = new Panel();
        public static List<Panel> panelsList = new List<Panel>();
        public static int? selectedFilm;
        //for interaction
        //CreateForm
        public static Form addingFilmForm = new Form();
        public static Panel panel_Upper = new Panel();
        public static TextBox txtBox_filmName = new TextBox();
        public static TextBox txtBox_description = new TextBox();
        public static Label label_CloseWindow = new Label();
        public static PictureBox pb_chosenPic = new PictureBox();
        public static Label label_filmName = new Label();
        public static Label label_filmDescription = new Label();
        public static NumericUpDown numeric_rating = new NumericUpDown();
        public static Label label_rating = new Label();
        public static RoundButton but_addFilms = new RoundButton();

        public static void CreateForm(Panel parentPanel)
        {
            #region Form 

            parPanel = parentPanel;


            addingFilmForm.Size = new Size(587, 307);

            panel_Upper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pb_chosenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numeric_rating)).BeginInit();
            addingFilmForm.SuspendLayout();
            // 
            // txtBox_filmName
            // 
            txtBox_filmName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            txtBox_filmName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtBox_filmName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            txtBox_filmName.ForeColor = System.Drawing.SystemColors.Window;
            txtBox_filmName.Location = new System.Drawing.Point(149, 52);
            txtBox_filmName.Name = "txtBox_filmName";
            txtBox_filmName.Size = new System.Drawing.Size(426, 25);
            txtBox_filmName.TabIndex = 1;
            addingFilmForm.Controls.Add(txtBox_filmName);
            // 
            // txtBox_description
            // 
            txtBox_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            txtBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtBox_description.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            txtBox_description.ForeColor = System.Drawing.SystemColors.Window;
            txtBox_description.Location = new System.Drawing.Point(149, 112);
            txtBox_description.Multiline = true;
            txtBox_description.Name = "txtBox_description";
            txtBox_description.Size = new System.Drawing.Size(426, 165);
            txtBox_description.TabIndex = 2;
            addingFilmForm.Controls.Add(txtBox_description);
            // 
            // panel_Upper
            // 
            panel_Upper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            panel_Upper.Controls.Add(label_CloseWindow);
            panel_Upper.Dock = System.Windows.Forms.DockStyle.Top;
            panel_Upper.Location = new System.Drawing.Point(0, 0);
            panel_Upper.Name = "panel_Upper";
            panel_Upper.Size = new System.Drawing.Size(587, 18);
            panel_Upper.TabIndex = 3;
            addingFilmForm.Controls.Add(panel_Upper);
            // 
            // label_CloseWindow
            // 
            label_CloseWindow.AutoSize = true;
            label_CloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            label_CloseWindow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_CloseWindow.Image = global::SFDestroyer.Properties.Resources.close_window_24px;
            label_CloseWindow.Location = new System.Drawing.Point(570, 1);
            label_CloseWindow.Name = "label_CloseWindow";
            label_CloseWindow.Size = new System.Drawing.Size(16, 16);
            label_CloseWindow.TabIndex = 0;
            label_CloseWindow.Text = "  ";
            label_CloseWindow.Click += new EventHandler(Label_CloseWindow_Click);
            addingFilmForm.Controls.Add(label_CloseWindow);
            // 
            // pb_chosenPic
            // 
            pb_chosenPic.Location = new System.Drawing.Point(12, 52);
            pb_chosenPic.Name = "pb_chosenPic";
            pb_chosenPic.Image = Properties.Resources.plus_math_24px;
            pb_chosenPic.Size = new System.Drawing.Size(100, 100);
            pb_chosenPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pb_chosenPic.BorderStyle = BorderStyle.FixedSingle;
            pb_chosenPic.TabIndex = 0;
            pb_chosenPic.TabStop = false;
            pb_chosenPic.Click += new EventHandler(picBox_MouseClick);
            addingFilmForm.Controls.Add(pb_chosenPic);
            // 
            // label_filmName
            // 
            label_filmName.AutoSize = true;
            label_filmName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_filmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            label_filmName.Location = new System.Drawing.Point(146, 34);
            label_filmName.Name = "label_filmName";
            label_filmName.Size = new System.Drawing.Size(77, 15);
            label_filmName.TabIndex = 4;
            label_filmName.Text = "Film name:";
            addingFilmForm.Controls.Add(label_filmName);
            // 
            // label_filmDescription
            // 
            label_filmDescription.AutoSize = true;
            label_filmDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_filmDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            label_filmDescription.Location = new System.Drawing.Point(146, 94);
            label_filmDescription.Name = "label_filmDescription";
            label_filmDescription.Size = new System.Drawing.Size(84, 15);
            label_filmDescription.TabIndex = 5;
            label_filmDescription.Text = "Description";
            addingFilmForm.Controls.Add(label_filmDescription);
            // 
            // numeric_rating
            // 
            numeric_rating.Anchor = System.Windows.Forms.AnchorStyles.None;
            numeric_rating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            numeric_rating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            numeric_rating.ForeColor = System.Drawing.SystemColors.Window;
            numeric_rating.Location = new System.Drawing.Point(105, 286);
            numeric_rating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            numeric_rating.Name = "numeric_rating";
            numeric_rating.Size = new System.Drawing.Size(38, 16);
            numeric_rating.TabIndex = 6;
            numeric_rating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            addingFilmForm.Controls.Add(numeric_rating);
            // 
            // label_rating
            // 
            label_rating.AutoSize = true;
            label_rating.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_rating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            label_rating.Location = new System.Drawing.Point(56, 285);
            label_rating.Name = "label1";
            label_rating.Size = new System.Drawing.Size(56, 15);
            label_rating.TabIndex = 7;
            label_rating.Text = "Rating:";
            addingFilmForm.Controls.Add(label_rating);
            // 
            // but_addFilms
            // 
            but_addFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            but_addFilms.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            but_addFilms.ButtonBorderColor = System.Drawing.Color.Black;
            but_addFilms.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            but_addFilms.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            but_addFilms.ButtonHighlightForeColor = System.Drawing.Color.Black;
            but_addFilms.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            but_addFilms.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            but_addFilms.ButtonPressedForeColor = System.Drawing.Color.Black;
            but_addFilms.ButtonRoundRadius = 15;
            but_addFilms.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            but_addFilms.Location = new System.Drawing.Point(496, 275);
            but_addFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            but_addFilms.Name = "but_addFilms";
            but_addFilms.Size = new System.Drawing.Size(79, 27);
            but_addFilms.TabIndex = 12;
            but_addFilms.Text = "Add";
            but_addFilms.Click += new System.EventHandler(but_addFilms_Click);
            addingFilmForm.Controls.Add(but_addFilms);
            // 
            // AddingFilm
            // 
            addingFilmForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            addingFilmForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            addingFilmForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            addingFilmForm.ClientSize = new System.Drawing.Size(587, 307);
            addingFilmForm.Controls.Add(but_addFilms);
            addingFilmForm.Controls.Add(label_rating);
            addingFilmForm.Controls.Add(numeric_rating);
            addingFilmForm.Controls.Add(label_filmDescription);
            addingFilmForm.Controls.Add(label_filmName);
            addingFilmForm.Controls.Add(panel_Upper);
            addingFilmForm.Controls.Add(txtBox_description);
            addingFilmForm.Controls.Add(txtBox_filmName);
            addingFilmForm.Controls.Add(pb_chosenPic);
            addingFilmForm.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addingFilmForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            addingFilmForm.Name = "AddingFilm";
            addingFilmForm.Text = "AddingFilm";
            panel_Upper.ResumeLayout(false);
            panel_Upper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pb_chosenPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numeric_rating)).EndInit();
            addingFilmForm.ResumeLayout(false);
            addingFilmForm.PerformLayout();

            addingFilmForm.Show();
            

            #endregion

            

            /*Динамическое добавление и удаление контрола Panel со своими контролами.
            Необходимо реализовать динамическое добавление панелей на форму со своими элементами внутри (к примеру label).

            1. Создаем форму и кидаем 2 кнопки. Один Button отвечает за добавление, второй настроим на удаление.



            2. создадим массив panel и label.

            Panel[] pan = new Panel[5];
            Label[] lb = new Label[5];
            Их прописать после этой строчки

            public partial class Form1 : Form
            {
            должно получиться так

            public partial class Form1 : Form
            {
            Panel[] pan = new Panel[5];
            Label[] lb = new Label[5];
            ......
            3. пропишем следующий код для динамического добавления контролов на нашу форму

            private void button1_Click(object sender, EventArgs e)
            {

            int j = 0;
            for (int i = 0; i < pan.Length; i++)
            {
            //создаем динамически панель
            pan[i] = new System.Windows.Forms.Panel();
            pan[i].Location = new System.Drawing.Point(101, 50 + i * 30);
            pan[i].Name = "paneld" + i.ToString();
            pan[i].Size = new System.Drawing.Size(75, 23);
            pan[i].BorderStyle = BorderStyle.FixedSingle;
            pan[i].TabIndex = i;
            //создаем динамически label
            lb[j] = new System.Windows.Forms.Label();
            lb[j].Location = new System.Drawing.Point(5, 5);
            lb[j].Name = "labeld" + j.ToString();
            lb[j].Text = "labeld" + j.ToString();

            //привязываем панель к форме
            Controls.Add(pan[i]);
            //привязываем label к панели
            pan[i].Controls.Add(lb[j]);
            j++;
            }
            }
            4. Прописать следующий код для удаления контрола из формы и всех связанных с ним

            private void button2_Click(object sender, EventArgs e)
            {
            //удаляем label из контролов
            pan[1].Controls.Remove(lb[1]);
            //освобождаем память для label
            lb[1].Dispose();
            //то же для панели
            Controls.Remove(pan[1]);
            pan[1].Dispose();
            }*/
        }

        private static void Label_CloseWindow_Click(object sender, EventArgs e)
        {
            ClosingForm();
        }

        public static void addFilmToList(List<Panel> panels)
        {
            //Panel
            Panel panel = new Panel();
            panel.Name = ("panelFilm" + panels.Count.ToString());
            panel.Size = new Size(parPanel.Width, 121);
            panel.MouseMove += new MouseEventHandler(Panel_MouseMove);
            panel.MouseLeave += new EventHandler(Panel_MouseLeave);
            panel.MouseClick += new MouseEventHandler(Panel_MouseClick);
            //PictureBox
            PictureBox picBox = new PictureBox();
            picBox.Name = ("picBox" + panels.Count.ToString());
            picBox.Size = new Size(panel.Height, panel.Height);
            picBox.Location = new Point(0, 0);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.Image = pb_chosenPic.Image;
            picBox.MouseMove += new MouseEventHandler(Panel_MouseMove);
            picBox.MouseLeave += new EventHandler(Panel_MouseLeave);
            //Rating (stars)
            for (int starCount = 1; starCount <= 10; starCount++)
            {
                PictureBox star = new PictureBox();
                star.Image = starCount > (10 - numeric_rating.Value) ? Properties.Resources.star_filled_48px : Properties.Resources.star_48px;
                star.Size = new Size(20, 20);
                star.SizeMode = PictureBoxSizeMode.StretchImage;
                star.Location = new Point(panel.Width - star.Width * starCount, panel.Height - star.Height);
                star.MouseMove += new MouseEventHandler(Panel_MouseMove);
                star.MouseLeave += new EventHandler(Panel_MouseLeave);

                panel.Controls.Add(star);
            }
            //Labels
            Label name = new Label();
            name.Text = txtBox_filmName.Text;
            name.ForeColor = Color.White;
            name.Location = new Point(picBox.Location.X + picBox.Width + 20, picBox.Location.Y);
            name.Font = new Font("Consolas", 15.75f);
            name.AutoSize = true;
            name.MouseMove += new MouseEventHandler(Panel_MouseMove);
            name.MouseLeave += new EventHandler(Panel_MouseLeave);
            name.MouseClick += new MouseEventHandler(Panel_MouseClick);

            Label description = new Label();
            description.Text = txtBox_description.Text;
            description.ForeColor = Color.White;
            description.AutoSize = true;
            description.Location = new Point(picBox.Location.X + picBox.Width + 20, name.Location.Y + name.Height);
            description.Font = new Font("Consolas", 9.75f);
            description.MouseMove += new MouseEventHandler(Panel_MouseMove);
            description.MouseLeave += new EventHandler(Panel_MouseLeave);
            description.MouseClick += new MouseEventHandler(Panel_MouseClick);

            //Adding controls to panel
            panel.Controls.Add(name);
            panel.Controls.Add(description);
            panel.Controls.Add(picBox);
            //Adding panel to parent panel
            panels.Add(panel);

            ClosingForm();
        }

        /// <summary>
        /// The method needs for init doing when form is closing (Cross\Add Buttons)
        /// </summary>
        public static void ClosingForm()
        {
            addingFilmForm.Hide();
            foreach (Control control in addingFilmForm.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Text = String.Empty;
                else if (control is PictureBox)
                {
                    (control as PictureBox).SizeMode = PictureBoxSizeMode.CenterImage;
                    (control as PictureBox).Image = Properties.Resources.plus_math_24px;
                }
            }
            
        }

        public static void removeFilm(List<Panel> panels, int removeFilmNumber)
        {
            try
            {
                if (selectedFilm != null)
                {
                    //MessageBox
                    DialogResult deleting = System.Windows.Forms.MessageBox.Show(
                        "Do you really want to delete " + panelsList[(int)selectedFilm].Controls[10].Text, 
                        "Message", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Information);

                    if(deleting == DialogResult.Yes)
                    {
                        //deleting from List<>
                        panels.RemoveAt((int)selectedFilm);
                        UpdateParentPanel(parPanel);
                    }
                }
            }
            catch { }
        }
        public static void UpdateParentPanel(Panel parentPanel)
        {
            int controlsCount = 0;

            parentPanel.Controls.Clear();
            foreach(Panel panel in panelsList)
            {
                panel.Location = new Point(0, 121 * controlsCount);
                parentPanel.Controls.Add(panel);
                controlsCount++;
            }
        }

        #region Events
        //Panel
        private static void but_addFilms_Click(object sender, EventArgs e)
        {
            //Creating Panel and its controls
            addFilmToList(panelsList);
            //Clearing and adding controls (panels) on parent panel
            UpdateParentPanel(parPanel);
            //Hiding Form
            addingFilmForm.Hide();
            but_addFilms.Click -= new System.EventHandler(but_addFilms_Click);
        }

        private static void Panel_MouseMove(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                ((Panel)sender).BackColor = Color.FromArgb(80, 80, 80);
            }
            else
            {
                ((Control)sender).Parent.BackColor = Color.FromArgb(80, 80, 80);
            }
                
        }

        private static void Panel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                ((Panel)sender).BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                ((Control)sender).Parent.BackColor = Color.FromArgb(50, 50, 50);
            }
        }

        private static void Panel_MouseClick(object sender, EventArgs e)
        {
            if((Control)sender is Panel)
            {
                //finding index of selected panel
                selectedFilm = ((Panel)sender).Parent.Controls.IndexOf((Panel)sender);

                foreach(Control control in ((Panel)sender).Parent.Controls)
                {
                    (control as Panel).BorderStyle = BorderStyle.None;
                }
                ((Panel)sender).BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                //finding index of selected panel
                selectedFilm = ((Control)sender).Parent.Parent.Controls.IndexOf(((Control)sender).Parent);

                foreach (Control control in ((Control)sender).Parent.Parent.Controls)
                {
                    (control as Panel).BorderStyle = BorderStyle.None;
                }
                (((Control)sender).Parent as Panel).BorderStyle = BorderStyle.FixedSingle;
            }
  
        }
        //Form
        private static void picBox_MouseClick(object sender, EventArgs e)
        {
            using (OpenFileDialog pic_choosing = new OpenFileDialog())
            {
                pic_choosing.InitialDirectory = "C:\\";
                pic_choosing.Filter = "Picture files (.jpg, .png, ...|*.jpg; *.png)";
                pic_choosing.RestoreDirectory = true;

                if (pic_choosing.ShowDialog() == DialogResult.OK)
                {
                    ((PictureBox)sender).SizeMode = PictureBoxSizeMode.StretchImage;
                    ((PictureBox)sender).Image = Bitmap.FromFile(pic_choosing.FileName);
                }
            }
            pb_chosenPic.Click -= new EventHandler(picBox_MouseClick);
        }

        #endregion
    }
}
