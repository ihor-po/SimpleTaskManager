namespace SimpleTaskManager
{
    partial class main_form
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
            this.mf_lv = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mf_process = new System.Diagnostics.Process();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mf_lv
            // 
            this.mf_lv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mf_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.mf_lv.Dock = System.Windows.Forms.DockStyle.Top;
            this.mf_lv.FullRowSelect = true;
            this.mf_lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mf_lv.Location = new System.Drawing.Point(0, 0);
            this.mf_lv.Margin = new System.Windows.Forms.Padding(4);
            this.mf_lv.Name = "mf_lv";
            this.mf_lv.Size = new System.Drawing.Size(732, 413);
            this.mf_lv.TabIndex = 0;
            this.mf_lv.UseCompatibleStateImageBehavior = false;
            this.mf_lv.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 597);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(732, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Командна строка";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(4, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(724, 22);
            this.textBox1.TabIndex = 0;
            // 
            // mf_process
            // 
            this.mf_process.StartInfo.Domain = "";
            this.mf_process.StartInfo.LoadUserProfile = false;
            this.mf_process.StartInfo.Password = null;
            this.mf_process.StartInfo.StandardErrorEncoding = null;
            this.mf_process.StartInfo.StandardOutputEncoding = null;
            this.mf_process.StartInfo.UserName = "";
            this.mf_process.SynchronizingObject = this;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя процесса";
            this.columnHeader2.Width = 605;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mf_lv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "main_form";
            this.Text = "Простой таск менеджер";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView mf_lv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Diagnostics.Process mf_process;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

