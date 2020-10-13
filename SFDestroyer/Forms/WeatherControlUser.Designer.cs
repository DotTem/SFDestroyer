namespace SFDestroyer.Forms
{
    partial class WeatherControlUser
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
            this.txtBox_City = new System.Windows.Forms.TextBox();
            this.label_curCity = new System.Windows.Forms.Label();
            this.label_Temperature = new System.Windows.Forms.Label();
            this.label_curTemperature = new System.Windows.Forms.Label();
            this.label_curWeather = new System.Windows.Forms.Label();
            this.panel_Temps = new System.Windows.Forms.Panel();
            this.label_Feel = new System.Windows.Forms.Label();
            this.picBox_CurWeather = new System.Windows.Forms.PictureBox();
            this.panel_forecast = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFifth = new System.Windows.Forms.GroupBox();
            this.label_F_TempFifth = new System.Windows.Forms.Label();
            this.picBox_F_4 = new System.Windows.Forms.PictureBox();
            this.gbFourth = new System.Windows.Forms.GroupBox();
            this.label_F_TempFourth = new System.Windows.Forms.Label();
            this.picBox_F_3 = new System.Windows.Forms.PictureBox();
            this.gbThird = new System.Windows.Forms.GroupBox();
            this.label_F_TempThird = new System.Windows.Forms.Label();
            this.picBox_F_2 = new System.Windows.Forms.PictureBox();
            this.label_F_TempTomorrow = new System.Windows.Forms.Label();
            this.picBox_F_1 = new System.Windows.Forms.PictureBox();
            this.label_F_TempToday = new System.Windows.Forms.Label();
            this.picBox_F_Today = new System.Windows.Forms.PictureBox();
            this.picBox_City = new System.Windows.Forms.PictureBox();
            this.but_curTemp = new System.Windows.Forms.Button();
            this.but_Forecast = new System.Windows.Forms.Button();
            this.panel_Temps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CurWeather)).BeginInit();
            this.panel_forecast.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbFifth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_F_4)).BeginInit();
            this.gbFourth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_F_3)).BeginInit();
            this.gbThird.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_F_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_F_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_F_Today)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_City)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_City
            // 
            this.txtBox_City.AcceptsReturn = true;
            this.txtBox_City.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_City.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_City.ForeColor = System.Drawing.SystemColors.Control;
            this.txtBox_City.Location = new System.Drawing.Point(57, 27);
            this.txtBox_City.Name = "txtBox_City";
            this.txtBox_City.Size = new System.Drawing.Size(395, 16);
            this.txtBox_City.TabIndex = 1;
            this.txtBox_City.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_City_KeyDown);
            // 
            // label_curCity
            // 
            this.label_curCity.AutoSize = true;
            this.label_curCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label_curCity.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_curCity.ForeColor = System.Drawing.SystemColors.Control;
            this.label_curCity.Location = new System.Drawing.Point(8, 13);
            this.label_curCity.Name = "label_curCity";
            this.label_curCity.Size = new System.Drawing.Size(34, 24);
            this.label_curCity.TabIndex = 2;
            this.label_curCity.Text = "--";
            // 
            // label_Temperature
            // 
            this.label_Temperature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Temperature.AutoSize = true;
            this.label_Temperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label_Temperature.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Temperature.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Temperature.Location = new System.Drawing.Point(711, 181);
            this.label_Temperature.Name = "label_Temperature";
            this.label_Temperature.Size = new System.Drawing.Size(90, 32);
            this.label_Temperature.TabIndex = 3;
            this.label_Temperature.Text = "--/--";
            // 
            // label_curTemperature
            // 
            this.label_curTemperature.AutoSize = true;
            this.label_curTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label_curTemperature.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_curTemperature.ForeColor = System.Drawing.SystemColors.Control;
            this.label_curTemperature.Location = new System.Drawing.Point(-9, 37);
            this.label_curTemperature.Name = "label_curTemperature";
            this.label_curTemperature.Size = new System.Drawing.Size(153, 112);
            this.label_curTemperature.TabIndex = 6;
            this.label_curTemperature.Text = "--";
            // 
            // label_curWeather
            // 
            this.label_curWeather.AutoSize = true;
            this.label_curWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label_curWeather.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_curWeather.ForeColor = System.Drawing.SystemColors.Control;
            this.label_curWeather.Location = new System.Drawing.Point(6, 152);
            this.label_curWeather.Name = "label_curWeather";
            this.label_curWeather.Size = new System.Drawing.Size(45, 32);
            this.label_curWeather.TabIndex = 7;
            this.label_curWeather.Text = "--";
            // 
            // panel_Temps
            // 
            this.panel_Temps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel_Temps.Controls.Add(this.label_Feel);
            this.panel_Temps.Controls.Add(this.label_Temperature);
            this.panel_Temps.Controls.Add(this.label_curTemperature);
            this.panel_Temps.Controls.Add(this.label_curWeather);
            this.panel_Temps.Controls.Add(this.picBox_CurWeather);
            this.panel_Temps.Controls.Add(this.label_curCity);
            this.panel_Temps.Location = new System.Drawing.Point(12, 120);
            this.panel_Temps.Name = "panel_Temps";
            this.panel_Temps.Size = new System.Drawing.Size(864, 430);
            this.panel_Temps.TabIndex = 8;
            // 
            // label_Feel
            // 
            this.label_Feel.AutoSize = true;
            this.label_Feel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Feel.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Feel.Location = new System.Drawing.Point(6, 227);
            this.label_Feel.Name = "label_Feel";
            this.label_Feel.Size = new System.Drawing.Size(90, 32);
            this.label_Feel.TabIndex = 8;
            this.label_Feel.Text = "Feel:";
            // 
            // picBox_CurWeather
            // 
            this.picBox_CurWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.picBox_CurWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBox_CurWeather.InitialImage = null;
            this.picBox_CurWeather.Location = new System.Drawing.Point(643, 13);
            this.picBox_CurWeather.Name = "picBox_CurWeather";
            this.picBox_CurWeather.Size = new System.Drawing.Size(200, 200);
            this.picBox_CurWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_CurWeather.TabIndex = 4;
            this.picBox_CurWeather.TabStop = false;
            // 
            // panel_forecast
            // 
            this.panel_forecast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel_forecast.Controls.Add(this.label_F_TempTomorrow);
            this.panel_forecast.Controls.Add(this.panel1);
            this.panel_forecast.Controls.Add(this.picBox_F_1);
            this.panel_forecast.Controls.Add(this.gbFifth);
            this.panel_forecast.Controls.Add(this.gbFourth);
            this.panel_forecast.Controls.Add(this.gbThird);
            this.panel_forecast.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_forecast.Location = new System.Drawing.Point(12, 120);
            this.panel_forecast.Name = "panel_forecast";
            this.panel_forecast.Size = new System.Drawing.Size(864, 430);
            this.panel_forecast.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label_F_TempToday);
            this.panel1.Controls.Add(this.picBox_F_Today);
            this.panel1.Location = new System.Drawing.Point(15, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 380);
            this.panel1.TabIndex = 11;
            // 
            // gbFifth
            // 
            this.gbFifth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gbFifth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbFifth.Controls.Add(this.label_F_TempFifth);
            this.gbFifth.Controls.Add(this.picBox_F_4);
            this.gbFifth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFifth.ForeColor = System.Drawing.SystemColors.Control;
            this.gbFifth.Location = new System.Drawing.Point(679, 37);
            this.gbFifth.Name = "gbFifth";
            this.gbFifth.Size = new System.Drawing.Size(159, 380);
            this.gbFifth.TabIndex = 15;
            this.gbFifth.TabStop = false;
            this.gbFifth.Text = "Today";
            // 
            // label_F_TempFifth
            // 
            this.label_F_TempFifth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_F_TempFifth.AutoSize = true;
            this.label_F_TempFifth.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_F_TempFifth.Location = new System.Drawing.Point(24, 179);
            this.label_F_TempFifth.Name = "label_F_TempFifth";
            this.label_F_TempFifth.Size = new System.Drawing.Size(90, 32);
            this.label_F_TempFifth.TabIndex = 5;
            this.label_F_TempFifth.Text = "--/--";
            this.label_F_TempFifth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_F_4
            // 
            this.picBox_F_4.Location = new System.Drawing.Point(0, 26);
            this.picBox_F_4.Name = "picBox_F_4";
            this.picBox_F_4.Size = new System.Drawing.Size(161, 150);
            this.picBox_F_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_F_4.TabIndex = 4;
            this.picBox_F_4.TabStop = false;
            // 
            // gbFourth
            // 
            this.gbFourth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gbFourth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbFourth.Controls.Add(this.label_F_TempFourth);
            this.gbFourth.Controls.Add(this.picBox_F_3);
            this.gbFourth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFourth.ForeColor = System.Drawing.SystemColors.Control;
            this.gbFourth.Location = new System.Drawing.Point(513, 37);
            this.gbFourth.Name = "gbFourth";
            this.gbFourth.Size = new System.Drawing.Size(159, 380);
            this.gbFourth.TabIndex = 14;
            this.gbFourth.TabStop = false;
            this.gbFourth.Text = "Today";
            // 
            // label_F_TempFourth
            // 
            this.label_F_TempFourth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_F_TempFourth.AutoSize = true;
            this.label_F_TempFourth.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_F_TempFourth.Location = new System.Drawing.Point(24, 179);
            this.label_F_TempFourth.Name = "label_F_TempFourth";
            this.label_F_TempFourth.Size = new System.Drawing.Size(90, 32);
            this.label_F_TempFourth.TabIndex = 4;
            this.label_F_TempFourth.Text = "--/--";
            this.label_F_TempFourth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_F_3
            // 
            this.picBox_F_3.Location = new System.Drawing.Point(0, 26);
            this.picBox_F_3.Name = "picBox_F_3";
            this.picBox_F_3.Size = new System.Drawing.Size(160, 150);
            this.picBox_F_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_F_3.TabIndex = 3;
            this.picBox_F_3.TabStop = false;
            // 
            // gbThird
            // 
            this.gbThird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gbThird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbThird.Controls.Add(this.label_F_TempThird);
            this.gbThird.Controls.Add(this.picBox_F_2);
            this.gbThird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbThird.ForeColor = System.Drawing.SystemColors.Control;
            this.gbThird.Location = new System.Drawing.Point(346, 37);
            this.gbThird.Name = "gbThird";
            this.gbThird.Size = new System.Drawing.Size(161, 380);
            this.gbThird.TabIndex = 13;
            this.gbThird.TabStop = false;
            this.gbThird.Text = "Today";
            // 
            // label_F_TempThird
            // 
            this.label_F_TempThird.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_F_TempThird.AutoSize = true;
            this.label_F_TempThird.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_F_TempThird.Location = new System.Drawing.Point(24, 179);
            this.label_F_TempThird.Name = "label_F_TempThird";
            this.label_F_TempThird.Size = new System.Drawing.Size(90, 32);
            this.label_F_TempThird.TabIndex = 3;
            this.label_F_TempThird.Text = "--/--";
            this.label_F_TempThird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_F_2
            // 
            this.picBox_F_2.Location = new System.Drawing.Point(0, 26);
            this.picBox_F_2.Name = "picBox_F_2";
            this.picBox_F_2.Size = new System.Drawing.Size(161, 150);
            this.picBox_F_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_F_2.TabIndex = 2;
            this.picBox_F_2.TabStop = false;
            // 
            // label_F_TempTomorrow
            // 
            this.label_F_TempTomorrow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_F_TempTomorrow.AutoSize = true;
            this.label_F_TempTomorrow.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_F_TempTomorrow.ForeColor = System.Drawing.SystemColors.Control;
            this.label_F_TempTomorrow.Location = new System.Drawing.Point(214, 216);
            this.label_F_TempTomorrow.Name = "label_F_TempTomorrow";
            this.label_F_TempTomorrow.Size = new System.Drawing.Size(90, 32);
            this.label_F_TempTomorrow.TabIndex = 2;
            this.label_F_TempTomorrow.Text = "--/--";
            this.label_F_TempTomorrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_F_1
            // 
            this.picBox_F_1.Location = new System.Drawing.Point(180, 63);
            this.picBox_F_1.Name = "picBox_F_1";
            this.picBox_F_1.Size = new System.Drawing.Size(160, 150);
            this.picBox_F_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_F_1.TabIndex = 1;
            this.picBox_F_1.TabStop = false;
            // 
            // label_F_TempToday
            // 
            this.label_F_TempToday.AutoSize = true;
            this.label_F_TempToday.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_F_TempToday.ForeColor = System.Drawing.SystemColors.Control;
            this.label_F_TempToday.Location = new System.Drawing.Point(24, 179);
            this.label_F_TempToday.Name = "label_F_TempToday";
            this.label_F_TempToday.Size = new System.Drawing.Size(90, 32);
            this.label_F_TempToday.TabIndex = 1;
            this.label_F_TempToday.Text = "--/--";
            this.label_F_TempToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_F_Today
            // 
            this.picBox_F_Today.Location = new System.Drawing.Point(0, 26);
            this.picBox_F_Today.Name = "picBox_F_Today";
            this.picBox_F_Today.Size = new System.Drawing.Size(159, 150);
            this.picBox_F_Today.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_F_Today.TabIndex = 0;
            this.picBox_F_Today.TabStop = false;
            // 
            // picBox_City
            // 
            this.picBox_City.Image = global::SFDestroyer.Properties.Resources.city_50px1;
            this.picBox_City.Location = new System.Drawing.Point(24, 15);
            this.picBox_City.Name = "picBox_City";
            this.picBox_City.Size = new System.Drawing.Size(28, 28);
            this.picBox_City.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_City.TabIndex = 0;
            this.picBox_City.TabStop = false;
            // 
            // but_curTemp
            // 
            this.but_curTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.but_curTemp.FlatAppearance.BorderSize = 0;
            this.but_curTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_curTemp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_curTemp.ForeColor = System.Drawing.SystemColors.Control;
            this.but_curTemp.Location = new System.Drawing.Point(112, 98);
            this.but_curTemp.Name = "but_curTemp";
            this.but_curTemp.Size = new System.Drawing.Size(74, 22);
            this.but_curTemp.TabIndex = 9;
            this.but_curTemp.Text = "Current";
            this.but_curTemp.UseVisualStyleBackColor = false;
            this.but_curTemp.Click += new System.EventHandler(this.but_curTemp_Click);
            // 
            // but_Forecast
            // 
            this.but_Forecast.FlatAppearance.BorderSize = 0;
            this.but_Forecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Forecast.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_Forecast.ForeColor = System.Drawing.SystemColors.Control;
            this.but_Forecast.Location = new System.Drawing.Point(186, 98);
            this.but_Forecast.Name = "but_Forecast";
            this.but_Forecast.Size = new System.Drawing.Size(74, 22);
            this.but_Forecast.TabIndex = 10;
            this.but_Forecast.Text = "Forecast";
            this.but_Forecast.UseVisualStyleBackColor = true;
            this.but_Forecast.Click += new System.EventHandler(this.but_Forecast_Click);
            // 
            // WeatherControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.panel_forecast);
            this.Controls.Add(this.but_Forecast);
            this.Controls.Add(this.but_curTemp);
            this.Controls.Add(this.panel_Temps);
            this.Controls.Add(this.txtBox_City);
            this.Controls.Add(this.picBox_City);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WeatherControlUser";
            this.Size = new System.Drawing.Size(888, 614);
            this.panel_Temps.ResumeLayout(false);
            this.panel_Temps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CurWeather)).EndInit();
            this.panel_forecast.ResumeLayout(false);
            this.panel_forecast.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbFifth.ResumeLayout(false);
            this.gbFifth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_F_4)).EndInit();
            this.gbFourth.ResumeLayout(false);
            this.gbFourth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_F_3)).EndInit();
            this.gbThird.ResumeLayout(false);
            this.gbThird.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_F_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_F_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_F_Today)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_City)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_City;
        private System.Windows.Forms.TextBox txtBox_City;
        private System.Windows.Forms.Label label_curCity;
        private System.Windows.Forms.Label label_Temperature;
        private System.Windows.Forms.PictureBox picBox_CurWeather;
        private System.Windows.Forms.Label label_curTemperature;
        private System.Windows.Forms.Label label_curWeather;
        private System.Windows.Forms.Panel panel_Temps;
        private System.Windows.Forms.Button but_curTemp;
        private System.Windows.Forms.Button but_Forecast;
        private System.Windows.Forms.Panel panel_forecast;
        private System.Windows.Forms.Label label_Feel;
        private System.Windows.Forms.PictureBox picBox_F_3;
        private System.Windows.Forms.PictureBox picBox_F_2;
        private System.Windows.Forms.PictureBox picBox_F_1;
        private System.Windows.Forms.PictureBox picBox_F_Today;
        private System.Windows.Forms.PictureBox picBox_F_4;
        private System.Windows.Forms.GroupBox gbFifth;
        private System.Windows.Forms.GroupBox gbFourth;
        private System.Windows.Forms.GroupBox gbThird;
        private System.Windows.Forms.Label label_F_TempFifth;
        private System.Windows.Forms.Label label_F_TempFourth;
        private System.Windows.Forms.Label label_F_TempThird;
        private System.Windows.Forms.Label label_F_TempTomorrow;
        private System.Windows.Forms.Label label_F_TempToday;
        private System.Windows.Forms.Panel panel1;
    }
}
