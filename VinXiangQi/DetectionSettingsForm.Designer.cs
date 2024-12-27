namespace VinXiangQi
{
    partial class DetectionSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetectionSettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_detection_confirm = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_detection_interval = new System.Windows.Forms.NumericUpDown();
            this.button_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_detection_confirm)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_detection_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_detection_confirm);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(128, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "No identification confirmations";
            // 
            // numericUpDown_detection_confirm
            // 
            this.numericUpDown_detection_confirm.Location = new System.Drawing.Point(4, 29);
            this.numericUpDown_detection_confirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown_detection_confirm.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_detection_confirm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_detection_confirm.Name = "numericUpDown_detection_confirm";
            this.numericUpDown_detection_confirm.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown_detection_confirm.TabIndex = 0;
            this.numericUpDown_detection_confirm.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_detection_confirm.ValueChanged += new System.EventHandler(this.numericUpDown_detection_confirm_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDown_detection_interval);
            this.groupBox2.Location = new System.Drawing.Point(9, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(128, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recognition interval";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(94, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ms";
            // 
            // numericUpDown_detection_interval
            // 
            this.numericUpDown_detection_interval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_detection_interval.Location = new System.Drawing.Point(17, 21);
            this.numericUpDown_detection_interval.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown_detection_interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_detection_interval.Name = "numericUpDown_detection_interval";
            this.numericUpDown_detection_interval.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_detection_interval.TabIndex = 1;
            this.numericUpDown_detection_interval.Value = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.numericUpDown_detection_interval.ValueChanged += new System.EventHandler(this.numericUpDown_detection_interval_ValueChanged);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(166, 199);
            this.button_save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(94, 28);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Done";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 117);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // DetectionSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DetectionSettingsForm";
            this.Text = "高级识别设置";
            this.Load += new System.EventHandler(this.DetectionSettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_detection_confirm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_detection_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_detection_confirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_detection_interval;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label2;
    }
}