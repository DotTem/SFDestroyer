namespace SFDestroyer.Forms
{
    partial class ReviewsControlUser
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Films = new System.Windows.Forms.Panel();
            this.panel_Review = new System.Windows.Forms.Panel();
            this.but_Update = new SFDestroyer.Classes.RoundButton();
            this.but_removeFilm = new SFDestroyer.Classes.RoundButton();
            this.but_addPanel = new SFDestroyer.Classes.RoundButton();
            this.panel_Review.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Films
            // 
            this.panel_Films.AutoScroll = true;
            this.panel_Films.AutoScrollMinSize = new System.Drawing.Size(200, 200);
            this.panel_Films.Location = new System.Drawing.Point(0, 0);
            this.panel_Films.Name = "panel_Films";
            this.panel_Films.Size = new System.Drawing.Size(635, 614);
            this.panel_Films.TabIndex = 0;
            // 
            // panel_Review
            // 
            this.panel_Review.Controls.Add(this.but_Update);
            this.panel_Review.Controls.Add(this.but_removeFilm);
            this.panel_Review.Controls.Add(this.but_addPanel);
            this.panel_Review.Location = new System.Drawing.Point(635, 0);
            this.panel_Review.Name = "panel_Review";
            this.panel_Review.Size = new System.Drawing.Size(253, 614);
            this.panel_Review.TabIndex = 1;
            // 
            // but_Update
            // 
            this.but_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Update.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Update.ButtonBorderColor = System.Drawing.Color.Black;
            this.but_Update.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Update.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Update.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.but_Update.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Update.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Update.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.but_Update.ButtonRoundRadius = 15;
            this.but_Update.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_Update.Location = new System.Drawing.Point(171, 585);
            this.but_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Update.Name = "but_Update";
            this.but_Update.Size = new System.Drawing.Size(79, 27);
            this.but_Update.TabIndex = 13;
            this.but_Update.Text = "Update";
            this.but_Update.Click += new System.EventHandler(this.but_Update_Click);
            // 
            // but_removeFilm
            // 
            this.but_removeFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_removeFilm.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_removeFilm.ButtonBorderColor = System.Drawing.Color.Black;
            this.but_removeFilm.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_removeFilm.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_removeFilm.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.but_removeFilm.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_removeFilm.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_removeFilm.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.but_removeFilm.ButtonRoundRadius = 15;
            this.but_removeFilm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_removeFilm.Location = new System.Drawing.Point(6, 585);
            this.but_removeFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_removeFilm.Name = "but_removeFilm";
            this.but_removeFilm.Size = new System.Drawing.Size(79, 27);
            this.but_removeFilm.TabIndex = 12;
            this.but_removeFilm.Text = "Remove";
            this.but_removeFilm.Click += new System.EventHandler(this.but_removeFilm_Click);
            // 
            // but_addPanel
            // 
            this.but_addPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_addPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_addPanel.ButtonBorderColor = System.Drawing.Color.Black;
            this.but_addPanel.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_addPanel.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_addPanel.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.but_addPanel.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_addPanel.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_addPanel.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.but_addPanel.ButtonRoundRadius = 15;
            this.but_addPanel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_addPanel.Location = new System.Drawing.Point(6, 554);
            this.but_addPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_addPanel.Name = "but_addPanel";
            this.but_addPanel.Size = new System.Drawing.Size(79, 27);
            this.but_addPanel.TabIndex = 11;
            this.but_addPanel.Text = "Add";
            this.but_addPanel.Click += new System.EventHandler(this.but_addPanel_Click);
            // 
            // ReviewsControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.panel_Review);
            this.Controls.Add(this.panel_Films);
            this.Name = "ReviewsControlUser";
            this.Size = new System.Drawing.Size(888, 614);
            this.panel_Review.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel_Review;
        private Classes.RoundButton but_removeFilm;
        private Classes.RoundButton but_addPanel;
        public System.Windows.Forms.Panel panel_Films;
        private Classes.RoundButton but_Update;
    }
}
