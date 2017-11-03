namespace SIC_ArtCode
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.estadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeComprobaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.estadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCuentaToolStripMenuItem,
            this.verCuentasToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // agregarCuentaToolStripMenuItem
            // 
            this.agregarCuentaToolStripMenuItem.Name = "agregarCuentaToolStripMenuItem";
            this.agregarCuentaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.agregarCuentaToolStripMenuItem.Text = "Agregar Cuenta";
            this.agregarCuentaToolStripMenuItem.Click += new System.EventHandler(this.agregarCuentaToolStripMenuItem_Click);
            // 
            // verCuentasToolStripMenuItem
            // 
            this.verCuentasToolStripMenuItem.Name = "verCuentasToolStripMenuItem";
            this.verCuentasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.verCuentasToolStripMenuItem.Text = "Ver Cuentas";
            this.verCuentasToolStripMenuItem.Click += new System.EventHandler(this.verCuentasToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "ARTCODE S.A";
            // 
            // estadosToolStripMenuItem
            // 
            this.estadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoDeComprobaciónToolStripMenuItem});
            this.estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            this.estadosToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.estadosToolStripMenuItem.Text = "Estados Financieros";
            // 
            // estadoDeComprobaciónToolStripMenuItem
            // 
            this.estadoDeComprobaciónToolStripMenuItem.Name = "estadoDeComprobaciónToolStripMenuItem";
            this.estadoDeComprobaciónToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.estadoDeComprobaciónToolStripMenuItem.Text = "Estado de Comprobación";
            this.estadoDeComprobaciónToolStripMenuItem.Click += new System.EventHandler(this.estadoDeComprobaciónToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sistema Contable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCuentasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem estadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeComprobaciónToolStripMenuItem;
    }
}

