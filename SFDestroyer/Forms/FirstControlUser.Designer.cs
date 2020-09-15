namespace SFDestroyer.Forms
{
    partial class firstControlUser
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label_From = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.txtB_Path = new System.Windows.Forms.TextBox();
            this.label_Filters = new System.Windows.Forms.Label();
            this.label_Path = new System.Windows.Forms.Label();
            this.but_SelectPath = new SFDestroyer.Classes.RoundButton();
            this.but_Do_1 = new SFDestroyer.Classes.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmvBox_Filter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 149);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(64, 204);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(232, 23);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.BackColor = System.Drawing.Color.Transparent;
            this.label_From.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_From.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_From.Location = new System.Drawing.Point(12, 155);
            this.label_From.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(44, 17);
            this.label_From.TabIndex = 2;
            this.label_From.Text = "From";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_To.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_To.Location = new System.Drawing.Point(35, 210);
            this.label_To.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(24, 17);
            this.label_To.TabIndex = 3;
            this.label_To.Text = "To";
            // 
            // txtB_Path
            // 
            this.txtB_Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtB_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Path.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtB_Path.Location = new System.Drawing.Point(64, 90);
            this.txtB_Path.Name = "txtB_Path";
            this.txtB_Path.ReadOnly = true;
            this.txtB_Path.Size = new System.Drawing.Size(684, 23);
            this.txtB_Path.TabIndex = 8;
            this.txtB_Path.WordWrap = false;
            // 
            // label_Filters
            // 
            this.label_Filters.AutoSize = true;
            this.label_Filters.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Filters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_Filters.Location = new System.Drawing.Point(12, 265);
            this.label_Filters.Name = "label_Filters";
            this.label_Filters.Size = new System.Drawing.Size(54, 17);
            this.label_Filters.TabIndex = 9;
            this.label_Filters.Text = "Filters:";
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.BackColor = System.Drawing.Color.Transparent;
            this.label_Path.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_Path.Location = new System.Drawing.Point(12, 96);
            this.label_Path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(47, 17);
            this.label_Path.TabIndex = 12;
            this.label_Path.Text = "Path:";
            // 
            // but_SelectPath
            // 
            this.but_SelectPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_SelectPath.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_SelectPath.ButtonBorderColor = System.Drawing.Color.Black;
            this.but_SelectPath.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_SelectPath.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_SelectPath.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.but_SelectPath.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_SelectPath.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_SelectPath.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.but_SelectPath.ButtonRoundRadius = 15;
            this.but_SelectPath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_SelectPath.Location = new System.Drawing.Point(669, 119);
            this.but_SelectPath.Name = "but_SelectPath";
            this.but_SelectPath.Size = new System.Drawing.Size(79, 27);
            this.but_SelectPath.TabIndex = 11;
            this.but_SelectPath.Text = "Select";
            this.but_SelectPath.Click += new System.EventHandler(this.but_SelectPath_Click);
            // 
            // but_Do_1
            // 
            this.but_Do_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Do_1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Do_1.ButtonBorderColor = System.Drawing.Color.Black;
            this.but_Do_1.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Do_1.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Do_1.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.but_Do_1.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Do_1.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Do_1.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.but_Do_1.ButtonRoundRadius = 15;
            this.but_Do_1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_Do_1.Location = new System.Drawing.Point(669, 475);
            this.but_Do_1.Name = "but_Do_1";
            this.but_Do_1.Size = new System.Drawing.Size(79, 27);
            this.but_Do_1.TabIndex = 10;
            this.but_Do_1.Text = "Do";
            this.but_Do_1.Click += new System.EventHandler(this.but_Do_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(72, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Coming Soon...";
            // 
            // cmvBox_Filter
            // 
            this.cmvBox_Filter.FormattingEnabled = true;
            this.cmvBox_Filter.Items.AddRange(new object[] {
            "text"});
            this.cmvBox_Filter.Location = new System.Drawing.Point(64, 303);
            this.cmvBox_Filter.Name = "cmvBox_Filter";
            this.cmvBox_Filter.Size = new System.Drawing.Size(121, 24);
            this.cmvBox_Filter.TabIndex = 14;
            // 
            // firstControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.cmvBox_Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Path);
            this.Controls.Add(this.but_SelectPath);
            this.Controls.Add(this.but_Do_1);
            this.Controls.Add(this.label_Filters);
            this.Controls.Add(this.txtB_Path);
            this.Controls.Add(this.label_To);
            this.Controls.Add(this.label_From);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "firstControlUser";
            this.Size = new System.Drawing.Size(751, 527);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.TextBox txtB_Path;
        private System.Windows.Forms.Label label_Filters;
        private Classes.RoundButton but_Do_1;
        private Classes.RoundButton but_SelectPath;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmvBox_Filter;
    }
}
