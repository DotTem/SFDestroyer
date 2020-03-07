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
            this.panel_LeftSide = new System.Windows.Forms.Panel();
            this.but_First = new System.Windows.Forms.Button();
            this.panel_Upside = new System.Windows.Forms.Panel();
            this.panel_Upper = new System.Windows.Forms.Panel();
            this.label_CloseWindow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firstControlUser1 = new SFDestroyer.Forms.firstControlUser();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_LeftSide.SuspendLayout();
            this.panel_Upper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_LeftSide
            // 
            this.panel_LeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_LeftSide.Controls.Add(this.button1);
            this.panel_LeftSide.Controls.Add(this.but_First);
            this.panel_LeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_LeftSide.Location = new System.Drawing.Point(0, 0);
            this.panel_LeftSide.Name = "panel_LeftSide";
            this.panel_LeftSide.Size = new System.Drawing.Size(205, 580);
            this.panel_LeftSide.TabIndex = 0;
            // 
            // but_First
            // 
            this.but_First.FlatAppearance.BorderSize = 0;
            this.but_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_First.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.panel1.Controls.Add(this.firstControlUser1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(205, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 527);
            this.panel1.TabIndex = 3;
            // 
            // firstControlUser1
            // 
            this.firstControlUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.firstControlUser1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstControlUser1.Location = new System.Drawing.Point(0, 0);
            this.firstControlUser1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstControlUser1.Name = "firstControlUser1";
            this.firstControlUser1.Size = new System.Drawing.Size(751, 527);
            this.firstControlUser1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "SFDestroyer";
            this.button1.UseVisualStyleBackColor = true;
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
        private Forms.firstControlUser firstControlUser1;
        private System.Windows.Forms.Button button1;
    }
}

