namespace Tachmau_Prj03
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
            this.pic_red = new System.Windows.Forms.PictureBox();
            this.pic_green = new System.Windows.Forms.PictureBox();
            this.pic_blue = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_goc
            // 
            this.pic_goc.Location = new System.Drawing.Point(35, 54);
            this.pic_goc.Name = "pic_goc";
            this.pic_goc.Size = new System.Drawing.Size(276, 183);
            this.pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_goc.TabIndex = 0;
            this.pic_goc.TabStop = false;
            // 
            // pic_red
            // 
            this.pic_red.Location = new System.Drawing.Point(365, 54);
            this.pic_red.Name = "pic_red";
            this.pic_red.Size = new System.Drawing.Size(276, 183);
            this.pic_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_red.TabIndex = 2;
            this.pic_red.TabStop = false;
            // 
            // pic_green
            // 
            this.pic_green.Location = new System.Drawing.Point(35, 288);
            this.pic_green.Name = "pic_green";
            this.pic_green.Size = new System.Drawing.Size(276, 183);
            this.pic_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_green.TabIndex = 3;
            this.pic_green.TabStop = false;
            // 
            // pic_blue
            // 
            this.pic_blue.Location = new System.Drawing.Point(365, 288);
            this.pic_blue.Name = "pic_blue";
            this.pic_blue.Size = new System.Drawing.Size(276, 183);
            this.pic_blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_blue.TabIndex = 4;
            this.pic_blue.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hình gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "RED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "GREEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "BLUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 527);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_blue);
            this.Controls.Add(this.pic_green);
            this.Controls.Add(this.pic_red);
            this.Controls.Add(this.pic_goc);
            this.Name = "Form1";
            this.Text = "Tách ảnh màu R-G-B";
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goc;
        private System.Windows.Forms.PictureBox pic_red;
        private System.Windows.Forms.PictureBox pic_green;
        private System.Windows.Forms.PictureBox pic_blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

