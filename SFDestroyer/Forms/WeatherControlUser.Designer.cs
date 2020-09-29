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
            this.label_FirstDay = new System.Windows.Forms.Label();
            this.picBox_City = new System.Windows.Forms.PictureBox();
            this.but_curTemp = new System.Windows.Forms.Button();
            this.but_Forecast = new System.Windows.Forms.Button();
            this.panel_Temps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CurWeather)).BeginInit();
            this.panel_forecast.SuspendLayout();
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
            this.label_Temperature.Location = new System.Drawing.Point(562, 180);
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
            this.panel_Temps.Size = new System.Drawing.Size(721, 260);
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
            this.picBox_CurWeather.Location = new System.Drawing.Point(521, 13);
            this.picBox_CurWeather.Name = "picBox_CurWeather";
            this.picBox_CurWeather.Size = new System.Drawing.Size(200, 200);
            this.picBox_CurWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_CurWeather.TabIndex = 4;
            this.picBox_CurWeather.TabStop = false;
            // 
            // panel_forecast
            // 
            this.panel_forecast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel_forecast.Controls.Add(this.label_FirstDay);
            this.panel_forecast.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_forecast.Location = new System.Drawing.Point(12, 120);
            this.panel_forecast.Name = "panel_forecast";
            this.panel_forecast.Size = new System.Drawing.Size(724, 260);
            this.panel_forecast.TabIndex = 8;
            // 
            // label_FirstDay
            // 
            this.label_FirstDay.AutoSize = true;
            this.label_FirstDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_FirstDay.Location = new System.Drawing.Point(294, 120);
            this.label_FirstDay.Name = "label_FirstDay";
            this.label_FirstDay.Size = new System.Drawing.Size(73, 13);
            this.label_FirstDay.TabIndex = 0;
            this.label_FirstDay.Text = "Coming Soon";
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
            this.Size = new System.Drawing.Size(751, 527);
            this.panel_Temps.ResumeLayout(false);
            this.panel_Temps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CurWeather)).EndInit();
            this.panel_forecast.ResumeLayout(false);
            this.panel_forecast.PerformLayout();
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
        private System.Windows.Forms.Label label_FirstDay;
    }
}
