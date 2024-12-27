﻿namespace VinXiangQi
{
    partial class OpenBookSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenBookSettingsForm));
            this.checkBox_use_openbook = new System.Windows.Forms.CheckBox();
            this.comboBox_openbook_mode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_openbook_list = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_open_folder = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_enable_chessdb = new System.Windows.Forms.CheckBox();
            this.numericUpDown_min_time = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min_time)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_use_openbook
            // 
            this.checkBox_use_openbook.AutoSize = true;
            this.checkBox_use_openbook.Location = new System.Drawing.Point(14, 24);
            this.checkBox_use_openbook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_use_openbook.Name = "checkBox_use_openbook";
            this.checkBox_use_openbook.Size = new System.Drawing.Size(96, 17);
            this.checkBox_use_openbook.TabIndex = 0;
            this.checkBox_use_openbook.Text = "Use openbook";
            this.checkBox_use_openbook.UseVisualStyleBackColor = true;
            this.checkBox_use_openbook.CheckedChanged += new System.EventHandler(this.checkBox_use_openbook_CheckedChanged);
            // 
            // comboBox_openbook_mode
            // 
            this.comboBox_openbook_mode.FormattingEnabled = true;
            this.comboBox_openbook_mode.Items.AddRange(new object[] {
            "最高分",
            "随机"});
            this.comboBox_openbook_mode.Location = new System.Drawing.Point(14, 70);
            this.comboBox_openbook_mode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_openbook_mode.Name = "comboBox_openbook_mode";
            this.comboBox_openbook_mode.Size = new System.Drawing.Size(92, 21);
            this.comboBox_openbook_mode.TabIndex = 1;
            this.comboBox_openbook_mode.SelectedIndexChanged += new System.EventHandler(this.comboBox_openbook_mode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DB query mode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_use_openbook);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_openbook_mode);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(119, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open book";
            // 
            // listBox_openbook_list
            // 
            this.listBox_openbook_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_openbook_list.FormattingEnabled = true;
            this.listBox_openbook_list.Location = new System.Drawing.Point(2, 16);
            this.listBox_openbook_list.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox_openbook_list.Name = "listBox_openbook_list";
            this.listBox_openbook_list.Size = new System.Drawing.Size(251, 291);
            this.listBox_openbook_list.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_openbook_list);
            this.groupBox2.Location = new System.Drawing.Point(189, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(255, 310);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current loaded libary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "请把开局库存放在OpenBooks目录";
            // 
            // button_open_folder
            // 
            this.button_open_folder.Location = new System.Drawing.Point(22, 291);
            this.button_open_folder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_open_folder.Name = "button_open_folder";
            this.button_open_folder.Size = new System.Drawing.Size(64, 27);
            this.button_open_folder.TabIndex = 7;
            this.button_open_folder.Text = "Browse";
            this.button_open_folder.UseVisualStyleBackColor = true;
            this.button_open_folder.Click += new System.EventHandler(this.button_open_folder_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(99, 291);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(64, 27);
            this.button_refresh.TabIndex = 8;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_enable_chessdb);
            this.groupBox3.Location = new System.Drawing.Point(9, 120);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(119, 52);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cloud book";
            // 
            // checkBox_enable_chessdb
            // 
            this.checkBox_enable_chessdb.AutoSize = true;
            this.checkBox_enable_chessdb.Location = new System.Drawing.Point(14, 21);
            this.checkBox_enable_chessdb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_enable_chessdb.Name = "checkBox_enable_chessdb";
            this.checkBox_enable_chessdb.Size = new System.Drawing.Size(101, 17);
            this.checkBox_enable_chessdb.TabIndex = 3;
            this.checkBox_enable_chessdb.Text = "Use cloud book";
            this.checkBox_enable_chessdb.UseVisualStyleBackColor = true;
            this.checkBox_enable_chessdb.CheckedChanged += new System.EventHandler(this.checkBox_enable_chessdb_CheckedChanged);
            // 
            // numericUpDown_min_time
            // 
            this.numericUpDown_min_time.DecimalPlaces = 1;
            this.numericUpDown_min_time.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_min_time.Location = new System.Drawing.Point(13, 26);
            this.numericUpDown_min_time.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown_min_time.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_min_time.Name = "numericUpDown_min_time";
            this.numericUpDown_min_time.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown_min_time.TabIndex = 32;
            this.numericUpDown_min_time.TabStop = false;
            this.numericUpDown_min_time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_min_time.ValueChanged += new System.EventHandler(this.numericUpDown_min_time_ValueChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.numericUpDown_min_time);
            this.groupBox8.Location = new System.Drawing.Point(9, 177);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox8.Size = new System.Drawing.Size(118, 52);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Shortest step time of using book ";
            // 
            // OpenBookSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 331);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_open_folder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "OpenBookSettingsForm";
            this.Text = "开局库设置";
            this.Load += new System.EventHandler(this.OpenBookSettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min_time)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_use_openbook;
        private System.Windows.Forms.ComboBox comboBox_openbook_mode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_openbook_list;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_open_folder;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_enable_chessdb;
        private System.Windows.Forms.NumericUpDown numericUpDown_min_time;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}