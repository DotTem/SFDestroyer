namespace SFDestroyer
{
    partial class SFD_Main
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_LeftSide = new System.Windows.Forms.Panel();
            this.label_curTime = new System.Windows.Forms.Label();
            this.but_Settings = new System.Windows.Forms.Button();
            this.but_FTP = new System.Windows.Forms.Button();
            this.but_Weather = new System.Windows.Forms.Button();
            this.but_First = new System.Windows.Forms.Button();
            this.panel_Upside = new System.Windows.Forms.Panel();
            this.panel_Upper = new System.Windows.Forms.Panel();
            this.label_CloseWindow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer_curTime = new System.Windows.Forms.Timer(this.components);
            this.settingsControlUser = new SFDestroyer.Forms.SettingsControlUser();
            this.weatherControlUser = new SFDestroyer.Forms.WeatherControlUser();
            this.firstControlUser = new SFDestroyer.Forms.firstControlUser();
            this.panel_LeftSide.SuspendLayout();
            this.panel_Upper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_LeftSide
            // 
            this.panel_LeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_LeftSide.Controls.Add(this.label_curTime);
            this.panel_LeftSide.Controls.Add(this.but_Settings);
            this.panel_LeftSide.Controls.Add(this.but_FTP);
            this.panel_LeftSide.Controls.Add(this.but_Weather);
            this.panel_LeftSide.Controls.Add(this.but_First);
            this.panel_LeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_LeftSide.Location = new System.Drawing.Point(0, 0);
            this.panel_LeftSide.Name = "panel_LeftSide";
            this.panel_LeftSide.Size = new System.Drawing.Size(205, 580);
            this.panel_LeftSide.TabIndex = 0;
            // 
            // label_curTime
            // 
            this.label_curTime.AutoSize = true;
            this.label_curTime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_curTime.ForeColor = System.Drawing.SystemColors.Control;
            this.label_curTime.Location = new System.Drawing.Point(-4, 557);
            this.label_curTime.Name = "label_curTime";
            this.label_curTime.Size = new System.Drawing.Size(90, 19);
            this.label_curTime.TabIndex = 4;
            this.label_curTime.Text = "Date Time";
            // 
            // but_Settings
            // 
            this.but_Settings.BackgroundImage = global::SFDestroyer.Properties.Resources.settings_48px;
            this.but_Settings.FlatAppearance.BorderSize = 0;
            this.but_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Settings.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_Settings.ForeColor = System.Drawing.SystemColors.Control;
            this.but_Settings.Location = new System.Drawing.Point(173, 548);
            this.but_Settings.Name = "but_Settings";
            this.but_Settings.Size = new System.Drawing.Size(32, 32);
            this.but_Settings.TabIndex = 3;
            this.but_Settings.UseVisualStyleBackColor = true;
            this.but_Settings.Click += new System.EventHandler(this.but_Settings_Click);
            // 
            // but_FTP
            // 
            this.but_FTP.FlatAppearance.BorderSize = 0;
            this.but_FTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_FTP.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_FTP.ForeColor = System.Drawing.SystemColors.Control;
            this.but_FTP.Location = new System.Drawing.Point(0, 169);
            this.but_FTP.Name = "but_FTP";
            this.but_FTP.Size = new System.Drawing.Size(205, 61);
            this.but_FTP.TabIndex = 2;
            this.but_FTP.Text = "FTP-Client";
            this.but_FTP.UseVisualStyleBackColor = true;
            // 
            // but_Weather
            // 
            this.but_Weather.FlatAppearance.BorderSize = 0;
            this.but_Weather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Weather.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_Weather.ForeColor = System.Drawing.SystemColors.Control;
            this.but_Weather.Location = new System.Drawing.Point(0, 111);
            this.but_Weather.Name = "but_Weather";
            this.but_Weather.Size = new System.Drawing.Size(205, 61);
            this.but_Weather.TabIndex = 1;
            this.but_Weather.Text = "Weather";
            this.but_Weather.UseVisualStyleBackColor = true;
            this.but_Weather.Click += new System.EventHandler(this.but_Weather_Click);
            // 
            // but_First
            // 
            this.but_First.FlatAppearance.BorderSize = 0;
            this.but_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_First.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_First.ForeColor = System.Drawing.SystemColors.Control;
            this.but_First.Location = new System.Drawing.Point(0, 53);
            this.but_First.Name = "but_First";
            this.but_First.Size = new System.Drawing.Size(205, 61);
            this.but_First.TabIndex = 0;
            this.but_First.Text = "SFDestroyer";
            this.but_First.UseVisualStyleBackColor = true;
            this.but_First.Click += new System.EventHandler(this.but_First_Click);
            // 
            // panel_Upside
            // 
            this.panel_Upside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Upside.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Upside.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_Upside.Location = new System.Drawing.Point(205, 18);
            this.panel_Upside.Name = "panel_Upside";
            this.panel_Upside.Size = new System.Drawing.Size(751, 38);
            this.panel_Upside.TabIndex = 1;
            // 
            // panel_Upper
            // 
            this.panel_Upper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel_Upper.Controls.Add(this.label_CloseWindow);
            this.panel_Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Upper.Location = new System.Drawing.Point(205, 0);
            this.panel_Upper.Name = "panel_Upper";
            this.panel_Upper.Size = new System.Drawing.Size(751, 18);
            this.panel_Upper.TabIndex = 2;
            this.panel_Upper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Upper_MouseDown);
            this.panel_Upper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Upper_MouseMove);
            this.panel_Upper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Upper_MouseUp);
            // 
            // label_CloseWindow
            // 
            this.label_CloseWindow.AutoSize = true;
            this.label_CloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_CloseWindow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CloseWindow.Location = new System.Drawing.Point(732, 2);
            this.label_CloseWindow.Name = "label_CloseWindow";
            this.label_CloseWindow.Size = new System.Drawing.Size(16, 16);
            this.label_CloseWindow.TabIndex = 0;
            this.label_CloseWindow.Text = "X";
            this.label_CloseWindow.Click += new System.EventHandler(this.label_CloseWindow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.settingsControlUser);
            this.panel1.Controls.Add(this.weatherControlUser);
            this.panel1.Controls.Add(this.firstControlUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(205, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 527);
            this.panel1.TabIndex = 3;
            // 
            // timer_curTime
            // 
            this.timer_curTime.Tick += new System.EventHandler(this.timer_curTime_Tick);
            // 
            // settingsControlUser
            // 
            this.settingsControlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.settingsControlUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsControlUser.Location = new System.Drawing.Point(0, 0);
            this.settingsControlUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settingsControlUser.Name = "settingsControlUser";
            this.settingsControlUser.Size = new System.Drawing.Size(751, 527);
            this.settingsControlUser.TabIndex = 4;
            // 
            // weatherControlUser
            // 
            this.weatherControlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.weatherControlUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherControlUser.Location = new System.Drawing.Point(0, 0);
            this.weatherControlUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.weatherControlUser.Name = "weatherControlUser";
            this.weatherControlUser.Size = new System.Drawing.Size(751, 527);
            this.weatherControlUser.TabIndex = 3;
            // 
            // firstControlUser
            // 
            this.firstControlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.firstControlUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstControlUser.Location = new System.Drawing.Point(0, 0);
            this.firstControlUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstControlUser.Name = "firstControlUser";
            this.firstControlUser.Size = new System.Drawing.Size(751, 527);
            this.firstControlUser.TabIndex = 2;
            // 
            // SFD_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(956, 580);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Upside);
            this.Controls.Add(this.panel_Upper);
            this.Controls.Add(this.panel_LeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SFD_Main";
            this.Text = "SFDestroyer";
            this.panel_LeftSide.ResumeLayout(false);
            this.panel_LeftSide.PerformLayout();
            this.panel_Upper.ResumeLayout(false);
            this.panel_Upper.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_LeftSide;
        private System.Windows.Forms.Panel panel_Upside;
        private System.Windows.Forms.Panel panel_Upper;
        private System.Windows.Forms.Button but_First;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_CloseWindow;
        private Forms.firstControlUser firstControlUser;
        private System.Windows.Forms.Button but_Weather;
        private Forms.WeatherControlUser weatherControlUser;
        private System.Windows.Forms.Button but_FTP;
        private System.Windows.Forms.Timer timer_curTime;
        private System.Windows.Forms.Button but_Settings;
        private System.Windows.Forms.Label label_curTime;
        private Forms.SettingsControlUser settingsControlUser;
    }
}

