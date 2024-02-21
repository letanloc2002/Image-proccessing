namespace Mini_Prj07
{
    partial class prj07
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
            this.pic_goc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_hue = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_saturation = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_intensity = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_hsi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_intensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hsi)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_goc
            // 
            this.pic_goc.Location = new System.Drawing.Point(53, 52);
            this.pic_goc.Name = "pic_goc";
            this.pic_goc.Size = new System.Drawing.Size(273, 211);
            this.pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_goc.TabIndex = 0;
            this.pic_goc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình Gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kênh X";
            // 
            // pic_hue
            // 
            this.pic_hue.Location = new System.Drawing.Point(56, 306);
            this.pic_hue.Name = "pic_hue";
            this.pic_hue.Size = new System.Drawing.Size(273, 211);
            this.pic_hue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_hue.TabIndex = 2;
            this.pic_hue.TabStop = false;
            this.pic_hue.Click += new System.EventHandler(this.pic_hue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kênh Y";
            // 
            // pic_saturation
            // 
            this.pic_saturation.Location = new System.Drawing.Point(335, 306);
            this.pic_saturation.Name = "pic_saturation";
            this.pic_saturation.Size = new System.Drawing.Size(273, 211);
            this.pic_saturation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_saturation.TabIndex = 4;
            this.pic_saturation.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kênh Z";
            // 
            // pic_intensity
            // 
            this.pic_intensity.Location = new System.Drawing.Point(614, 306);
            this.pic_intensity.Name = "pic_intensity";
            this.pic_intensity.Size = new System.Drawing.Size(273, 211);
            this.pic_intensity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_intensity.TabIndex = 6;
            this.pic_intensity.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(893, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kênh XYZ";
            // 
            // pic_hsi
            // 
            this.pic_hsi.Location = new System.Drawing.Point(893, 306);
            this.pic_hsi.Name = "pic_hsi";
            this.pic_hsi.Size = new System.Drawing.Size(273, 211);
            this.pic_hsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_hsi.TabIndex = 8;
            this.pic_hsi.TabStop = false;
            // 
            // prj07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 552);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic_hsi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pic_intensity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_saturation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_hue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_goc);
            this.Name = "prj07";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_intensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hsi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_hue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_saturation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_intensity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_hsi;
    }
}

