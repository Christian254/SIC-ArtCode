namespace SIC_ArtCode
{
    partial class Capital
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
            this.btnCapPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCapPDF
            // 
            this.btnCapPDF.Location = new System.Drawing.Point(94, 114);
            this.btnCapPDF.Name = "btnCapPDF";
            this.btnCapPDF.Size = new System.Drawing.Size(147, 23);
            this.btnCapPDF.TabIndex = 0;
            this.btnCapPDF.Text = "Estado Capital PDF";
            this.btnCapPDF.UseVisualStyleBackColor = true;
            this.btnCapPDF.Click += new System.EventHandler(this.btnCapPDF_Click);
            // 
            // Capital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCapPDF);
            this.Name = "Capital";
            this.Text = "Estado Capital";
            this.Load += new System.EventHandler(this.Capital_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapPDF;
    }
}