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
            this.pic_smooth = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.three = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_smooth)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_goc
            // 
            this.pic_goc.Location = new System.Drawing.Point(35, 54);
            this.pic_goc.Name = "pic_goc";
            this.pic_goc.Size = new System.Drawing.Size(276, 276);
            this.pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_goc.TabIndex = 0;
            this.pic_goc.TabStop = false;
            // 
            // pic_smooth
            // 
            this.pic_smooth.Location = new System.Drawing.Point(35, 393);
            this.pic_smooth.Name = "pic_smooth";
            this.pic_smooth.Size = new System.Drawing.Size(276, 276);
            this.pic_smooth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_smooth.TabIndex = 2;
            this.pic_smooth.TabStop = false;
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
            this.label2.Location = new System.Drawing.Point(32, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Smoothed Pic";
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(491, 54);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(186, 56);
            this.three.TabIndex = 7;
            this.three.Text = "3 x 3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(491, 157);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(186, 56);
            this.five.TabIndex = 8;
            this.five.Text = "5 x 5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(491, 254);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(186, 56);
            this.seven.TabIndex = 9;
            this.seven.Text = "7 x 7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(491, 351);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(186, 56);
            this.nine.TabIndex = 10;
            this.nine.Text = "9 x 9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 681);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.five);
            this.Controls.Add(this.three);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_smooth);
            this.Controls.Add(this.pic_goc);
            this.Name = "Form1";
            this.Text = "Tách ảnh màu R-G-B";
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_smooth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goc;
        private System.Windows.Forms.PictureBox pic_smooth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button nine;
    }
}

