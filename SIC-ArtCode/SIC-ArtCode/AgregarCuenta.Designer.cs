namespace SIC_ArtCode
{
    partial class AgregarCuenta
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
            this.lblNmbCuenta = new System.Windows.Forms.Label();
            this.txtNmbCuenta = new System.Windows.Forms.TextBox();
            this.lblIdCuenta = new System.Windows.Forms.Label();
            this.txtIdCuenta = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNmbCuenta
            // 
            this.lblNmbCuenta.AutoSize = true;
            this.lblNmbCuenta.Location = new System.Drawing.Point(53, 106);
            this.lblNmbCuenta.Name = "lblNmbCuenta";
            this.lblNmbCuenta.Size = new System.Drawing.Size(110, 13);
            this.lblNmbCuenta.TabIndex = 0;
            this.lblNmbCuenta.Text = "Nombre de la Cuenta:";
            // 
            // txtNmbCuenta
            // 
            this.txtNmbCuenta.Location = new System.Drawing.Point(195, 99);
            this.txtNmbCuenta.Name = "txtNmbCuenta";
            this.txtNmbCuenta.Size = new System.Drawing.Size(134, 20);
            this.txtNmbCuenta.TabIndex = 1;
            // 
            // lblIdCuenta
            // 
            this.lblIdCuenta.AutoSize = true;
            this.lblIdCuenta.Location = new System.Drawing.Point(53, 50);
            this.lblIdCuenta.Name = "lblIdCuenta";
            this.lblIdCuenta.Size = new System.Drawing.Size(79, 13);
            this.lblIdCuenta.TabIndex = 2;
            this.lblIdCuenta.Text = "Id de la Cuenta";
            // 
            // txtIdCuenta
            // 
            this.txtIdCuenta.Location = new System.Drawing.Point(195, 43);
            this.txtIdCuenta.Name = "txtIdCuenta";
            this.txtIdCuenta.Size = new System.Drawing.Size(134, 20);
            this.txtIdCuenta.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(167, 182);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Cuenta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AgregarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 262);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIdCuenta);
            this.Controls.Add(this.lblIdCuenta);
            this.Controls.Add(this.txtNmbCuenta);
            this.Controls.Add(this.lblNmbCuenta);
            this.MaximizeBox = false;
            this.Name = "AgregarCuenta";
            this.Text = "Agregar Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNmbCuenta;
        private System.Windows.Forms.TextBox txtNmbCuenta;
        private System.Windows.Forms.Label lblIdCuenta;
        private System.Windows.Forms.TextBox txtIdCuenta;
        private System.Windows.Forms.Button btnAgregar;
    }
}