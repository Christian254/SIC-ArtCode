namespace SIC_ArtCode
{
    partial class Ajuste
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
            this.btnDep = new System.Windows.Forms.Button();
            this.btnGasAcum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDep
            // 
            this.btnDep.Location = new System.Drawing.Point(46, 60);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(88, 23);
            this.btnDep.TabIndex = 0;
            this.btnDep.Text = "Depreciacion";
            this.btnDep.UseVisualStyleBackColor = true;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btnGasAcum
            // 
            this.btnGasAcum.Location = new System.Drawing.Point(154, 60);
            this.btnGasAcum.Name = "btnGasAcum";
            this.btnGasAcum.Size = new System.Drawing.Size(117, 23);
            this.btnGasAcum.TabIndex = 1;
            this.btnGasAcum.Text = "Gastos Acumulados";
            this.btnGasAcum.UseVisualStyleBackColor = true;
            this.btnGasAcum.Click += new System.EventHandler(this.btnGasAcum_Click);
            // 
            // Ajuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 157);
            this.Controls.Add(this.btnGasAcum);
            this.Controls.Add(this.btnDep);
            this.MaximizeBox = false;
            this.Name = "Ajuste";
            this.Text = "Ajuste";
            this.Load += new System.EventHandler(this.Ajuste_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDep;
        private System.Windows.Forms.Button btnGasAcum;
    }
}