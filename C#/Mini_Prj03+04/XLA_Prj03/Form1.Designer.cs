namespace XLA_Prj03
{
    partial class Form1
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
            this.pic_lightness = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_average = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_luminance = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_nhiphan = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vScrollBarnhiphan = new System.Windows.Forms.VScrollBar();
            this.lbnguong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_average)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_luminance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nhiphan)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_goc
            // 
            this.pic_goc.Location = new System.Drawing.Point(40, 48);
            this.pic_goc.Name = "pic_goc";
            this.pic_goc.Size = new System.Drawing.Size(276, 183);
            this.pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_goc.TabIndex = 0;
            this.pic_goc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ảnh gốc";
            // 
            // pic_lightness
            // 
            this.pic_lightness.Location = new System.Drawing.Point(372, 48);
            this.pic_lightness.Name = "pic_lightness";
            this.pic_lightness.Size = new System.Drawing.Size(276, 183);
            this.pic_lightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_lightness.TabIndex = 2;
            this.pic_lightness.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "lightness";
            // 
            // pic_average
            // 
            this.pic_average.Location = new System.Drawing.Point(40, 298);
            this.pic_average.Name = "pic_average";
            this.pic_average.Size = new System.Drawing.Size(276, 183);
            this.pic_average.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_average.TabIndex = 4;
            this.pic_average.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "average";
            // 
            // pic_luminance
            // 
            this.pic_luminance.Location = new System.Drawing.Point(372, 298);
            this.pic_luminance.Name = "pic_luminance";
            this.pic_luminance.Size = new System.Drawing.Size(276, 183);
            this.pic_luminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_luminance.TabIndex = 6;
            this.pic_luminance.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "luminance";
            // 
            // pic_nhiphan
            // 
            this.pic_nhiphan.Location = new System.Drawing.Point(670, 48);
            this.pic_nhiphan.Name = "pic_nhiphan";
            this.pic_nhiphan.Size = new System.Drawing.Size(276, 183);
            this.pic_nhiphan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_nhiphan.TabIndex = 8;
            this.pic_nhiphan.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "nhi phan";
            // 
            // vScrollBarnhiphan
            // 
            this.vScrollBarnhiphan.Location = new System.Drawing.Point(949, 48);
            this.vScrollBarnhiphan.Maximum = 255;
            this.vScrollBarnhiphan.Name = "vScrollBarnhiphan";
            this.vScrollBarnhiphan.Size = new System.Drawing.Size(23, 183);
            this.vScrollBarnhiphan.TabIndex = 10;
            this.vScrollBarnhiphan.ValueChanged += new System.EventHandler(this.vScrollBarnhiphan_ValueChanged);
            // 
            // lbnguong
            // 
            this.lbnguong.AutoSize = true;
            this.lbnguong.Location = new System.Drawing.Point(946, 13);
            this.lbnguong.Name = "lbnguong";
            this.lbnguong.Size = new System.Drawing.Size(57, 16);
            this.lbnguong.TabIndex = 11;
            this.lbnguong.Text = "nhi phan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 531);
            this.Controls.Add(this.lbnguong);
            this.Controls.Add(this.vScrollBarnhiphan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic_nhiphan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pic_luminance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_average);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_lightness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_goc);
            this.Name = "Form1";
            this.Text = "Chuyển ảnh RGB sang Grayscale";
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_average)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_luminance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nhiphan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_lightness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_average;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_luminance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_nhiphan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.VScrollBar vScrollBarnhiphan;
        private System.Windows.Forms.Label lbnguong;
    }
}

