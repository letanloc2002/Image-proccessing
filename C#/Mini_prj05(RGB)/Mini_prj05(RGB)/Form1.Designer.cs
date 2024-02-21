namespace Mini_prj05_RGB_
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
            this.zGHistogram = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_goc
            // 
            this.pic_goc.Location = new System.Drawing.Point(39, 41);
            this.pic_goc.Name = "pic_goc";
            this.pic_goc.Size = new System.Drawing.Size(252, 205);
            this.pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_goc.TabIndex = 0;
            this.pic_goc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình gốc";
            // 
            // zGHistogram
            // 
            this.zGHistogram.Location = new System.Drawing.Point(369, 41);
            this.zGHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zGHistogram.Name = "zGHistogram";
            this.zGHistogram.ScrollGrace = 0D;
            this.zGHistogram.ScrollMaxX = 0D;
            this.zGHistogram.ScrollMaxY = 0D;
            this.zGHistogram.ScrollMaxY2 = 0D;
            this.zGHistogram.ScrollMinX = 0D;
            this.zGHistogram.ScrollMinY = 0D;
            this.zGHistogram.ScrollMinY2 = 0D;
            this.zGHistogram.Size = new System.Drawing.Size(791, 504);
            this.zGHistogram.TabIndex = 2;
            this.zGHistogram.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 583);
            this.Controls.Add(this.zGHistogram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_goc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goc;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zGHistogram;
    }
}

