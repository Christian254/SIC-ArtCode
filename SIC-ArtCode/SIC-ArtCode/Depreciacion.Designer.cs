namespace SIC_ArtCode
{
    partial class Depreciacion
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
            this.lblP = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.lblL = new System.Windows.Forms.Label();
            this.txtL = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnCalD = new System.Windows.Forms.Button();
            this.lblCalD = new System.Windows.Forms.Label();
            this.lblValorD = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.idCuenta = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(62, 112);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(14, 13);
            this.lblP.TabIndex = 0;
            this.lblP.Text = "P";
            // 
            // txtP
            // 
            this.txtP.Enabled = false;
            this.txtP.Location = new System.Drawing.Point(118, 105);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(112, 20);
            this.txtP.TabIndex = 1;
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(63, 162);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(13, 13);
            this.lblL.TabIndex = 2;
            this.lblL.Text = "L";
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(118, 162);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(112, 20);
            this.txtL.TabIndex = 3;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(63, 203);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 4;
            this.lblN.Text = "N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(118, 203);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(112, 20);
            this.txtN.TabIndex = 5;
            // 
            // btnCalD
            // 
            this.btnCalD.Location = new System.Drawing.Point(32, 252);
            this.btnCalD.Name = "btnCalD";
            this.btnCalD.Size = new System.Drawing.Size(121, 23);
            this.btnCalD.TabIndex = 6;
            this.btnCalD.Text = "Calcular Depreciación";
            this.btnCalD.UseVisualStyleBackColor = true;
            this.btnCalD.Click += new System.EventHandler(this.btnCalD_Click);
            // 
            // lblCalD
            // 
            this.lblCalD.AutoSize = true;
            this.lblCalD.Location = new System.Drawing.Point(47, 290);
            this.lblCalD.Name = "lblCalD";
            this.lblCalD.Size = new System.Drawing.Size(0, 13);
            this.lblCalD.TabIndex = 7;
            // 
            // lblValorD
            // 
            this.lblValorD.AutoSize = true;
            this.lblValorD.Location = new System.Drawing.Point(143, 290);
            this.lblValorD.Name = "lblValorD";
            this.lblValorD.Size = new System.Drawing.Size(0, 13);
            this.lblValorD.TabIndex = 8;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(62, 55);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(41, 13);
            this.lblCuenta.TabIndex = 9;
            this.lblCuenta.Text = "Cuenta";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Enabled = false;
            this.txtCuenta.Location = new System.Drawing.Point(118, 55);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(112, 20);
            this.txtCuenta.TabIndex = 10;
            // 
            // idCuenta
            // 
            this.idCuenta.AutoSize = true;
            this.idCuenta.Location = new System.Drawing.Point(59, 18);
            this.idCuenta.Name = "idCuenta";
            this.idCuenta.Size = new System.Drawing.Size(55, 13);
            this.idCuenta.TabIndex = 11;
            this.idCuenta.Text = "ID Cuenta";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(118, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(112, 20);
            this.txtID.TabIndex = 12;
            // 
            // btnCA
            // 
            this.btnCA.Location = new System.Drawing.Point(186, 252);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(95, 22);
            this.btnCA.TabIndex = 13;
            this.btnCA.Text = "Agregar CA";
            this.btnCA.UseVisualStyleBackColor = true;
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // Depreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 346);
            this.Controls.Add(this.btnCA);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.idCuenta);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.lblValorD);
            this.Controls.Add(this.lblCalD);
            this.Controls.Add(this.btnCalD);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.lblP);
            this.MaximizeBox = false;
            this.Name = "Depreciacion";
            this.Text = "Depreciación";
            this.Load += new System.EventHandler(this.Depreciacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnCalD;
        private System.Windows.Forms.Label lblCalD;
        private System.Windows.Forms.Label lblValorD;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label idCuenta;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCA;
    }
}