namespace SIC_ArtCode
{
    partial class Periodo
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdbSemestral = new System.Windows.Forms.RadioButton();
            this.rdbTrimestral = new System.Windows.Forms.RadioButton();
            this.rdbBimensual = new System.Windows.Forms.RadioButton();
            this.rdbMensual = new System.Windows.Forms.RadioButton();
            this.rbdAnual = new System.Windows.Forms.RadioButton();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de inicio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(281, 79);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rbdAnual);
            this.grpTipo.Controls.Add(this.rdbSemestral);
            this.grpTipo.Controls.Add(this.rdbTrimestral);
            this.grpTipo.Controls.Add(this.rdbBimensual);
            this.grpTipo.Controls.Add(this.rdbMensual);
            this.grpTipo.Location = new System.Drawing.Point(36, 48);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(200, 187);
            this.grpTipo.TabIndex = 8;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "TipoCuenta";
            // 
            // rdbSemestral
            // 
            this.rdbSemestral.AutoSize = true;
            this.rdbSemestral.Location = new System.Drawing.Point(17, 105);
            this.rdbSemestral.Name = "rdbSemestral";
            this.rdbSemestral.Size = new System.Drawing.Size(83, 17);
            this.rdbSemestral.TabIndex = 3;
            this.rdbSemestral.Text = "4. Semestral";
            this.rdbSemestral.UseVisualStyleBackColor = true;
            // 
            // rdbTrimestral
            // 
            this.rdbTrimestral.AutoSize = true;
            this.rdbTrimestral.Location = new System.Drawing.Point(17, 82);
            this.rdbTrimestral.Name = "rdbTrimestral";
            this.rdbTrimestral.Size = new System.Drawing.Size(82, 17);
            this.rdbTrimestral.TabIndex = 2;
            this.rdbTrimestral.Text = "3. Trimestral";
            this.rdbTrimestral.UseVisualStyleBackColor = true;
            // 
            // rdbBimensual
            // 
            this.rdbBimensual.AutoSize = true;
            this.rdbBimensual.Location = new System.Drawing.Point(17, 55);
            this.rdbBimensual.Name = "rdbBimensual";
            this.rdbBimensual.Size = new System.Drawing.Size(85, 17);
            this.rdbBimensual.TabIndex = 1;
            this.rdbBimensual.Text = "2. Bimensual";
            this.rdbBimensual.UseVisualStyleBackColor = true;
            // 
            // rdbMensual
            // 
            this.rdbMensual.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.rdbMensual.AutoSize = true;
            this.rdbMensual.Checked = true;
            this.rdbMensual.Location = new System.Drawing.Point(17, 32);
            this.rdbMensual.Name = "rdbMensual";
            this.rdbMensual.Size = new System.Drawing.Size(77, 17);
            this.rdbMensual.TabIndex = 0;
            this.rdbMensual.TabStop = true;
            this.rdbMensual.Text = "1. Mensual";
            this.rdbMensual.UseVisualStyleBackColor = true;
            this.rdbMensual.CheckedChanged += new System.EventHandler(this.rdbActivo_CheckedChanged);
            // 
            // rbdAnual
            // 
            this.rbdAnual.AutoSize = true;
            this.rbdAnual.Location = new System.Drawing.Point(17, 129);
            this.rbdAnual.Name = "rbdAnual";
            this.rbdAnual.Size = new System.Drawing.Size(64, 17);
            this.rbdAnual.TabIndex = 4;
            this.rbdAnual.TabStop = true;
            this.rbdAnual.Text = "5. Anual";
            this.rbdAnual.UseVisualStyleBackColor = true;
            // 
            // Periodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 257);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Periodo";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Periodo_Load);
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdbSemestral;
        private System.Windows.Forms.RadioButton rdbTrimestral;
        private System.Windows.Forms.RadioButton rdbBimensual;
        private System.Windows.Forms.RadioButton rdbMensual;
        private System.Windows.Forms.RadioButton rbdAnual;
    }
}