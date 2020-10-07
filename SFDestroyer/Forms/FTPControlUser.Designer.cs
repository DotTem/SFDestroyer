namespace SFDestroyer.Forms
{
    partial class FTPControlUser
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
            this.label_Adress = new System.Windows.Forms.Label();
            this.txtB_Adress = new System.Windows.Forms.TextBox();
            this.txtB_Port = new System.Windows.Forms.TextBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.txtB_Console = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_Adress.Location = new System.Drawing.Point(3, 7);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(72, 19);
            this.label_Adress.TabIndex = 0;
            this.label_Adress.Text = "Adress:";
            // 
            // txtB_Adress
            // 
            this.txtB_Adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtB_Adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Adress.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtB_Adress.Location = new System.Drawing.Point(81, 7);
            this.txtB_Adress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtB_Adress.Name = "txtB_Adress";
            this.txtB_Adress.ReadOnly = true;
            this.txtB_Adress.Size = new System.Drawing.Size(121, 23);
            this.txtB_Adress.TabIndex = 9;
            this.txtB_Adress.Text = "255.255.255.255";
            this.txtB_Adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB_Adress.WordWrap = false;
            // 
            // txtB_Port
            // 
            this.txtB_Port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtB_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Port.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtB_Port.Location = new System.Drawing.Point(268, 8);
            this.txtB_Port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtB_Port.Name = "txtB_Port";
            this.txtB_Port.ReadOnly = true;
            this.txtB_Port.Size = new System.Drawing.Size(48, 23);
            this.txtB_Port.TabIndex = 10;
            this.txtB_Port.Text = "27015";
            this.txtB_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB_Port.WordWrap = false;
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_Port.Location = new System.Drawing.Point(208, 7);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(54, 19);
            this.label_Port.TabIndex = 11;
            this.label_Port.Text = "Port:";
            // 
            // txtB_Console
            // 
            this.txtB_Console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtB_Console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Console.ForeColor = System.Drawing.SystemColors.Control;
            this.txtB_Console.Location = new System.Drawing.Point(0, 477);
            this.txtB_Console.Multiline = true;
            this.txtB_Console.Name = "txtB_Console";
            this.txtB_Console.Size = new System.Drawing.Size(885, 134);
            this.txtB_Console.TabIndex = 12;
            // 
            // FTPControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.txtB_Console);
            this.Controls.Add(this.label_Port);
            this.Controls.Add(this.txtB_Port);
            this.Controls.Add(this.txtB_Adress);
            this.Controls.Add(this.label_Adress);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FTPControlUser";
            this.Size = new System.Drawing.Size(885, 614);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.TextBox txtB_Adress;
        private System.Windows.Forms.TextBox txtB_Port;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.TextBox txtB_Console;
    }
}
