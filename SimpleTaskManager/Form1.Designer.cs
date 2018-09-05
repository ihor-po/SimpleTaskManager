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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mf_cb_fin = new System.Windows.Forms.CheckBox();
            this.mf_cb_plan = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mf_tb_procName = new System.Windows.Forms.TextBox();
            this.mf_goBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mf_dp_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mf_dp_time = new System.Windows.Forms.DateTimePicker();
            this.mf_tb_procParam = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mf_lv
            // 
            this.mf_lv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mf_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "PID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя процесса";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Приоритет";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Взаимодействие";
            this.columnHeader5.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mf_cb_fin);
            this.groupBox1.Controls.Add(this.mf_cb_plan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mf_tb_procName);
            this.groupBox1.Controls.Add(this.mf_goBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mf_dp_date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mf_dp_time);
            this.groupBox1.Controls.Add(this.mf_tb_procParam);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 421);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(732, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запланрировать запуск";
            // 
            // mf_cb_fin
            // 
            this.mf_cb_fin.AutoSize = true;
            this.mf_cb_fin.Location = new System.Drawing.Point(384, 87);
            this.mf_cb_fin.Name = "mf_cb_fin";
            this.mf_cb_fin.Size = new System.Drawing.Size(99, 20);
            this.mf_cb_fin.TabIndex = 12;
            this.mf_cb_fin.Text = "Завершить";
            this.mf_cb_fin.UseVisualStyleBackColor = true;
            // 
            // mf_cb_plan
            // 
            this.mf_cb_plan.AutoSize = true;
            this.mf_cb_plan.Location = new System.Drawing.Point(83, 87);
            this.mf_cb_plan.Name = "mf_cb_plan";
            this.mf_cb_plan.Size = new System.Drawing.Size(130, 20);
            this.mf_cb_plan.TabIndex = 11;
            this.mf_cb_plan.Text = "Запланировать";
            this.mf_cb_plan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Процесс";
            // 
            // mf_tb_procName
            // 
            this.mf_tb_procName.Location = new System.Drawing.Point(83, 58);
            this.mf_tb_procName.Name = "mf_tb_procName";
            this.mf_tb_procName.Size = new System.Drawing.Size(206, 22);
            this.mf_tb_procName.TabIndex = 9;
            // 
            // mf_goBtn
            // 
            this.mf_goBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mf_goBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mf_goBtn.Location = new System.Drawing.Point(639, 23);
            this.mf_goBtn.Name = "mf_goBtn";
            this.mf_goBtn.Size = new System.Drawing.Size(84, 82);
            this.mf_goBtn.TabIndex = 8;
            this.mf_goBtn.Text = "GO";
            this.mf_goBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Время запуска";
            // 
            // mf_dp_date
            // 
            this.mf_dp_date.Enabled = false;
            this.mf_dp_date.Location = new System.Drawing.Point(116, 24);
            this.mf_dp_date.Name = "mf_dp_date";
            this.mf_dp_date.Size = new System.Drawing.Size(200, 22);
            this.mf_dp_date.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата запуска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Параметры";
            // 
            // mf_dp_time
            // 
            this.mf_dp_time.Enabled = false;
            this.mf_dp_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mf_dp_time.Location = new System.Drawing.Point(430, 24);
            this.mf_dp_time.Name = "mf_dp_time";
            this.mf_dp_time.ShowUpDown = true;
            this.mf_dp_time.Size = new System.Drawing.Size(200, 22);
            this.mf_dp_time.TabIndex = 3;
            // 
            // mf_tb_procParam
            // 
            this.mf_tb_procParam.Location = new System.Drawing.Point(384, 58);
            this.mf_tb_procParam.Name = "mf_tb_procParam";
            this.mf_tb_procParam.Size = new System.Drawing.Size(246, 22);
            this.mf_tb_procParam.TabIndex = 0;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 536);
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
        private System.Windows.Forms.TextBox mf_tb_procParam;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DateTimePicker mf_dp_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker mf_dp_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mf_tb_procName;
        private System.Windows.Forms.Button mf_goBtn;
        private System.Windows.Forms.CheckBox mf_cb_fin;
        private System.Windows.Forms.CheckBox mf_cb_plan;
    }
}

