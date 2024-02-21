namespace Mini_prj05
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
            this.components = new System.ComponentModel.Container();
            this.pic_goc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_xam = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zGHistogram = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_xam)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_goc
            // 
            this.pic_goc.Location = new System.Drawing.Point(42, 48);
            this.pic_goc.Name = "pic_goc";
            this.pic_goc.Size = new System.Drawing.Size(263, 179);
            this.pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_goc.TabIndex = 0;
            this.pic_goc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình Gốc";
            // 
            // pic_xam
            // 
            this.pic_xam.Location = new System.Drawing.Point(42, 306);
            this.pic_xam.Name = "pic_xam";
            this.pic_xam.Size = new System.Drawing.Size(263, 179);
            this.pic_xam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_xam.TabIndex = 2;
            this.pic_xam.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hình Xám";
            // 
            // zGHistogram
            // 
            this.zGHistogram.Location = new System.Drawing.Point(361, 48);
            this.zGHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zGHistogram.Name = "zGHistogram";
            this.zGHistogram.ScrollGrace = 0D;
            this.zGHistogram.ScrollMaxX = 0D;
            this.zGHistogram.ScrollMaxY = 0D;
            this.zGHistogram.ScrollMaxY2 = 0D;
            this.zGHistogram.ScrollMinX = 0D;
            this.zGHistogram.ScrollMinY = 0D;
            this.zGHistogram.ScrollMinY2 = 0D;
            this.zGHistogram.Size = new System.Drawing.Size(709, 485);
            this.zGHistogram.TabIndex = 4;
            this.zGHistogram.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 558);
            this.Controls.Add(this.zGHistogram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_xam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_goc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_xam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_xam;
        private System.Windows.Forms.Label label2;
        private ZedGraph.ZedGraphControl zGHistogram;
    }
}

