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
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdbResultado = new System.Windows.Forms.RadioButton();
            this.rdbCapital = new System.Windows.Forms.RadioButton();
            this.rdbPasivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.grpTipo.SuspendLayout();
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
            this.btnAgregar.Location = new System.Drawing.Point(162, 304);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Cuenta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rdbResultado);
            this.grpTipo.Controls.Add(this.rdbCapital);
            this.grpTipo.Controls.Add(this.rdbPasivo);
            this.grpTipo.Controls.Add(this.rdbActivo);
            this.grpTipo.Location = new System.Drawing.Point(56, 153);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(200, 131);
            this.grpTipo.TabIndex = 5;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo de Periodo";
            this.grpTipo.Enter += new System.EventHandler(this.grpTipo_Enter);
            // 
            // rdbResultado
            // 
            this.rdbResultado.AutoSize = true;
            this.rdbResultado.Location = new System.Drawing.Point(17, 105);
            this.rdbResultado.Name = "rdbResultado";
            this.rdbResultado.Size = new System.Drawing.Size(85, 17);
            this.rdbResultado.TabIndex = 3;
            this.rdbResultado.Text = "4. Resultado";
            this.rdbResultado.UseVisualStyleBackColor = true;
            // 
            // rdbCapital
            // 
            this.rdbCapital.AutoSize = true;
            this.rdbCapital.Location = new System.Drawing.Point(17, 82);
            this.rdbCapital.Name = "rdbCapital";
            this.rdbCapital.Size = new System.Drawing.Size(69, 17);
            this.rdbCapital.TabIndex = 2;
            this.rdbCapital.Text = "3. Capital";
            this.rdbCapital.UseVisualStyleBackColor = true;
            // 
            // rdbPasivo
            // 
            this.rdbPasivo.AutoSize = true;
            this.rdbPasivo.Location = new System.Drawing.Point(17, 55);
            this.rdbPasivo.Name = "rdbPasivo";
            this.rdbPasivo.Size = new System.Drawing.Size(69, 17);
            this.rdbPasivo.TabIndex = 1;
            this.rdbPasivo.Text = "2. Pasivo";
            this.rdbPasivo.UseVisualStyleBackColor = true;
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Checked = true;
            this.rdbActivo.Location = new System.Drawing.Point(17, 32);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(67, 17);
            this.rdbActivo.TabIndex = 0;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "1. Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(293, 153);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(296, 185);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 7;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(293, 212);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(296, 235);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 9;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // AgregarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 388);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIdCuenta);
            this.Controls.Add(this.lblIdCuenta);
            this.Controls.Add(this.txtNmbCuenta);
            this.Controls.Add(this.lblNmbCuenta);
            this.MaximizeBox = false;
            this.Name = "AgregarCuenta";
            this.Text = "Agregar Cuenta";
            this.Load += new System.EventHandler(this.AgregarCuenta_Load);
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNmbCuenta;
        private System.Windows.Forms.TextBox txtNmbCuenta;
        private System.Windows.Forms.Label lblIdCuenta;
        private System.Windows.Forms.TextBox txtIdCuenta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdbCapital;
        private System.Windows.Forms.RadioButton rdbPasivo;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.RadioButton rdbResultado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
    }
}