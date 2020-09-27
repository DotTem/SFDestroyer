namespace SFDestroyer.Forms
{
    partial class SettingsControlUser
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
            this.label_defCity = new System.Windows.Forms.Label();
            this.txtBox_citySet = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_defCity
            // 
            this.label_defCity.AutoSize = true;
            this.label_defCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_defCity.ForeColor = System.Drawing.SystemColors.Control;
            this.label_defCity.Location = new System.Drawing.Point(20, 27);
            this.label_defCity.Name = "label_defCity";
            this.label_defCity.Size = new System.Drawing.Size(107, 21);
            this.label_defCity.TabIndex = 0;
            this.label_defCity.Text = "Default City:";
            // 
            // txtBox_citySet
            // 
            this.txtBox_citySet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_citySet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_citySet.Location = new System.Drawing.Point(133, 27);
            this.txtBox_citySet.Multiline = true;
            this.txtBox_citySet.Name = "txtBox_citySet";
            this.txtBox_citySet.Size = new System.Drawing.Size(186, 21);
            this.txtBox_citySet.TabIndex = 1;
            this.txtBox_citySet.Enter += new System.EventHandler(this.txtBox_citySet_Enter);
            this.txtBox_citySet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_citySet_KeyDown);
            this.txtBox_citySet.Leave += new System.EventHandler(this.txtBox_citySet_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 108);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 20);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // SettingsControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtBox_citySet);
            this.Controls.Add(this.label_defCity);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsControlUser";
            this.Size = new System.Drawing.Size(751, 527);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_defCity;
        private System.Windows.Forms.TextBox txtBox_citySet;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
