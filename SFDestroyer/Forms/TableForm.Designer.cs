namespace SFDestroyer.Forms
{
    partial class TableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Upper = new System.Windows.Forms.Panel();
            this.label_CloseWindow = new System.Windows.Forms.Label();
            this.list_NT = new System.Windows.Forms.ListView();
            this.fileNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstBox_Dirs = new System.Windows.Forms.ListBox();
            this.but_Del = new System.Windows.Forms.Button();
            this.panel_Upper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Upper
            // 
            this.panel_Upper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel_Upper.Controls.Add(this.label_CloseWindow);
            this.panel_Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Upper.Location = new System.Drawing.Point(0, 0);
            this.panel_Upper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Upper.Name = "panel_Upper";
            this.panel_Upper.Size = new System.Drawing.Size(789, 22);
            this.panel_Upper.TabIndex = 3;
            this.panel_Upper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Upper_MouseDown);
            this.panel_Upper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Upper_MouseMove);
            this.panel_Upper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Upper_MouseUp);
            // 
            // label_CloseWindow
            // 
            this.label_CloseWindow.AutoSize = true;
            this.label_CloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_CloseWindow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CloseWindow.Location = new System.Drawing.Point(766, 2);
            this.label_CloseWindow.Name = "label_CloseWindow";
            this.label_CloseWindow.Size = new System.Drawing.Size(16, 16);
            this.label_CloseWindow.TabIndex = 0;
            this.label_CloseWindow.Text = "X";
            this.label_CloseWindow.Click += new System.EventHandler(this.label_CloseWindow_Click);
            // 
            // list_NT
            // 
            this.list_NT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.list_NT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_NT.CheckBoxes = true;
            this.list_NT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNames,
            this.Type});
            this.list_NT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_NT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.list_NT.HideSelection = false;
            this.list_NT.Location = new System.Drawing.Point(333, 41);
            this.list_NT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list_NT.Name = "list_NT";
            this.list_NT.Size = new System.Drawing.Size(444, 640);
            this.list_NT.TabIndex = 6;
            this.list_NT.UseCompatibleStateImageBehavior = false;
            this.list_NT.View = System.Windows.Forms.View.Details;
            this.list_NT.DoubleClick += new System.EventHandler(this.list_NT_DoubleClick);
            // 
            // fileNames
            // 
            this.fileNames.Tag = "fff";
            this.fileNames.Text = "Name";
            this.fileNames.Width = 353;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 90;
            // 
            // lstBox_Dirs
            // 
            this.lstBox_Dirs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lstBox_Dirs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBox_Dirs.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lstBox_Dirs.FormattingEnabled = true;
            this.lstBox_Dirs.ItemHeight = 16;
            this.lstBox_Dirs.Location = new System.Drawing.Point(12, 87);
            this.lstBox_Dirs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBox_Dirs.Name = "lstBox_Dirs";
            this.lstBox_Dirs.Size = new System.Drawing.Size(315, 594);
            this.lstBox_Dirs.TabIndex = 7;
            this.lstBox_Dirs.DoubleClick += new System.EventHandler(this.lstBox_Dirs_DoubleClick);
            // 
            // but_Del
            // 
            this.but_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.but_Del.FlatAppearance.BorderSize = 0;
            this.but_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Del.Location = new System.Drawing.Point(690, 689);
            this.but_Del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(87, 28);
            this.but_Del.TabIndex = 8;
            this.but_Del.Text = "Delete";
            this.but_Del.UseVisualStyleBackColor = false;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(789, 729);
            this.Controls.Add(this.but_Del);
            this.Controls.Add(this.lstBox_Dirs);
            this.Controls.Add(this.list_NT);
            this.Controls.Add(this.panel_Upper);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.panel_Upper.ResumeLayout(false);
            this.panel_Upper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Upper;
        private System.Windows.Forms.Label label_CloseWindow;
        private System.Windows.Forms.ListView list_NT;
        private System.Windows.Forms.ColumnHeader fileNames;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ListBox lstBox_Dirs;
        private System.Windows.Forms.Button but_Del;
    }
}