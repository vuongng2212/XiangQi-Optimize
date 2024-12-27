namespace VinXiangQi
{
    partial class ImageEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageEditForm));
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_delete_image = new System.Windows.Forms.Button();
            this.listView_images = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_status = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.richTextBox_name = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.ColumnCount = 2;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.Controls.Add(this.pictureBox, 1, 0);
            this.tableLayoutPanel_main.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_main.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 1;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(811, 565);
            this.tableLayoutPanel_main.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(227, 3);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(582, 559);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(221, 559);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture saving settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 452);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 104);
            this.label3.TabIndex = 15;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tips:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_delete_image);
            this.groupBox3.Controls.Add(this.listView_images);
            this.groupBox3.Location = new System.Drawing.Point(7, 190);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(209, 257);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Picture management";
            // 
            // button_delete_image
            // 
            this.button_delete_image.Location = new System.Drawing.Point(4, 219);
            this.button_delete_image.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_delete_image.Name = "button_delete_image";
            this.button_delete_image.Size = new System.Drawing.Size(198, 23);
            this.button_delete_image.TabIndex = 11;
            this.button_delete_image.Text = "Delete";
            this.button_delete_image.UseVisualStyleBackColor = true;
            this.button_delete_image.Click += new System.EventHandler(this.button_delete_image_Click);
            // 
            // listView_images
            // 
            this.listView_images.HideSelection = false;
            this.listView_images.Location = new System.Drawing.Point(4, 21);
            this.listView_images.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView_images.Name = "listView_images";
            this.listView_images.Size = new System.Drawing.Size(201, 194);
            this.listView_images.TabIndex = 12;
            this.listView_images.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_status);
            this.groupBox2.Controls.Add(this.button_reset);
            this.groupBox2.Controls.Add(this.button_save);
            this.groupBox2.Controls.Add(this.richTextBox_name);
            this.groupBox2.Location = new System.Drawing.Point(7, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(207, 164);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current screenshot";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(10, 20);
            this.label_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(179, 26);
            this.label_status.TabIndex = 10;
            this.label_status.Text = "Please click the dot in the upper left \r\ncorner of the crop area";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(12, 99);
            this.button_reset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(190, 23);
            this.button_reset.TabIndex = 9;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 127);
            this.button_save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(190, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Done";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // richTextBox_name
            // 
            this.richTextBox_name.Location = new System.Drawing.Point(10, 53);
            this.richTextBox_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBox_name.Name = "richTextBox_name";
            this.richTextBox_name.Size = new System.Drawing.Size(192, 40);
            this.richTextBox_name.TabIndex = 7;
            this.richTextBox_name.Text = "";
            this.richTextBox_name.TextChanged += new System.EventHandler(this.richTextBox_name_TextChanged);
            // 
            // ImageEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 565);
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ImageEditForm";
            this.Text = "自动点击图片管理";
            this.Load += new System.EventHandler(this.ImageEditForm_Load);
            this.tableLayoutPanel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.RichTextBox richTextBox_name;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ListView listView_images;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_delete_image;
    }
}