namespace XLA_prj02
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
            this.img_hinhhienthi = new Emgu.CV.UI.ImageBox();
            this.lb_hinhhienthi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_hinhhienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // img_hinhhienthi
            // 
            this.img_hinhhienthi.Location = new System.Drawing.Point(83, 69);
            this.img_hinhhienthi.Name = "img_hinhhienthi";
            this.img_hinhhienthi.Size = new System.Drawing.Size(279, 229);
            this.img_hinhhienthi.TabIndex = 2;
            this.img_hinhhienthi.TabStop = false;
            // 
            // lb_hinhhienthi
            // 
            this.lb_hinhhienthi.AutoSize = true;
            this.lb_hinhhienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hinhhienthi.Location = new System.Drawing.Point(80, 28);
            this.lb_hinhhienthi.Name = "lb_hinhhienthi";
            this.lb_hinhhienthi.Size = new System.Drawing.Size(119, 25);
            this.lb_hinhhienthi.TabIndex = 3;
            this.lb_hinhhienthi.Text = "Hình hiển thị";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 558);
            this.Controls.Add(this.lb_hinhhienthi);
            this.Controls.Add(this.img_hinhhienthi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.img_hinhhienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox img_hinhhienthi;
        private System.Windows.Forms.Label lb_hinhhienthi;
    }
}

