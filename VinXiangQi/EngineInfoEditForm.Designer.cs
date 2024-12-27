﻿namespace VinXiangQi
{
    partial class EngineInfoEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngineInfoEditForm));
            this.textBox_engine_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_engine_author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_engine_path = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_engine_name
            // 
            this.textBox_engine_name.Location = new System.Drawing.Point(61, 46);
            this.textBox_engine_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_engine_name.Name = "textBox_engine_name";
            this.textBox_engine_name.Size = new System.Drawing.Size(182, 20);
            this.textBox_engine_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author：";
            // 
            // textBox_engine_author
            // 
            this.textBox_engine_author.Location = new System.Drawing.Point(61, 81);
            this.textBox_engine_author.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_engine_author.Name = "textBox_engine_author";
            this.textBox_engine_author.Size = new System.Drawing.Size(182, 20);
            this.textBox_engine_author.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path：";
            // 
            // textBox_engine_path
            // 
            this.textBox_engine_path.Location = new System.Drawing.Point(61, 118);
            this.textBox_engine_path.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_engine_path.Name = "textBox_engine_path";
            this.textBox_engine_path.Size = new System.Drawing.Size(182, 20);
            this.textBox_engine_path.TabIndex = 4;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(52, 193);
            this.button_confirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(72, 26);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "Done";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(143, 193);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(72, 26);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // EngineInfoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 263);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_engine_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_engine_author);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_engine_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "EngineInfoEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "引擎信息";
            this.Load += new System.EventHandler(this.EngineInfoEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_engine_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_engine_author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_engine_path;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
    }
}