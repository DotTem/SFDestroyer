﻿namespace SFDestroyer.Forms
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
            this.but_Do_1 = new System.Windows.Forms.Button();
            this.list_NT = new System.Windows.Forms.ListView();
            this.fileNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 30);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dateTimePicker2.Location = new System.Drawing.Point(34, 87);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(232, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.BackColor = System.Drawing.Color.Transparent;
            this.label_From.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_From.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_From.Location = new System.Drawing.Point(4, 0);
            this.label_From.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(52, 21);
            this.label_From.TabIndex = 2;
            this.label_From.Text = "From";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_To.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_To.Location = new System.Drawing.Point(4, 58);
            this.label_To.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(30, 21);
            this.label_To.TabIndex = 3;
            this.label_To.Text = "To";
            // 
            // but_Do_1
            // 
            this.but_Do_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Do_1.FlatAppearance.BorderSize = 0;
            this.but_Do_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Do_1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_Do_1.Location = new System.Drawing.Point(633, 480);
            this.but_Do_1.Margin = new System.Windows.Forms.Padding(4);
            this.but_Do_1.Name = "but_Do_1";
            this.but_Do_1.Size = new System.Drawing.Size(118, 47);
            this.but_Do_1.TabIndex = 4;
            this.but_Do_1.Text = "Do";
            this.but_Do_1.UseVisualStyleBackColor = false;
            this.but_Do_1.Click += new System.EventHandler(this.but_Do_1_Click);
            // 
            // list_NT
            // 
            this.list_NT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.list_NT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_NT.CheckBoxes = true;
            this.list_NT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNames,
            this.Type});
            this.list_NT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.list_NT.HideSelection = false;
            this.list_NT.Location = new System.Drawing.Point(370, 30);
            this.list_NT.Name = "list_NT";
            this.list_NT.Size = new System.Drawing.Size(381, 443);
            this.list_NT.TabIndex = 5;
            this.list_NT.UseCompatibleStateImageBehavior = false;
            this.list_NT.View = System.Windows.Forms.View.Details;
            // 
            // fileNames
            // 
            this.fileNames.Tag = "fff";
            this.fileNames.Text = "Name";
            this.fileNames.Width = 319;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 61;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(151, 501);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(475, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Value = 46;
            // 
            // firstControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.list_NT);
            this.Controls.Add(this.but_Do_1);
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
        private System.Windows.Forms.Button but_Do_1;
        private System.Windows.Forms.ListView list_NT;
        private System.Windows.Forms.ColumnHeader fileNames;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
