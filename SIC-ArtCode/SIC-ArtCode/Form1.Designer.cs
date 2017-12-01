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
            this.estadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeComprobaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeResultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeCapitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costeoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRecursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.verCosteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.estadosToolStripMenuItem,
            this.planillaToolStripMenuItem,
            this.costeoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(651, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCuentaToolStripMenuItem,
            this.verCuentasToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // agregarCuentaToolStripMenuItem
            // 
            this.agregarCuentaToolStripMenuItem.Name = "agregarCuentaToolStripMenuItem";
            this.agregarCuentaToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.agregarCuentaToolStripMenuItem.Text = "Agregar Cuenta";
            this.agregarCuentaToolStripMenuItem.Click += new System.EventHandler(this.agregarCuentaToolStripMenuItem_Click);
            // 
            // verCuentasToolStripMenuItem
            // 
            this.verCuentasToolStripMenuItem.Name = "verCuentasToolStripMenuItem";
            this.verCuentasToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.verCuentasToolStripMenuItem.Text = "Ver Cuentas";
            this.verCuentasToolStripMenuItem.Click += new System.EventHandler(this.verCuentasToolStripMenuItem_Click);
            // 
            // estadosToolStripMenuItem
            // 
            this.estadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoDeComprobaciónToolStripMenuItem,
            this.estadoDeResultadoToolStripMenuItem,
            this.estadoDeCapitalToolStripMenuItem,
            this.balanceGeneralToolStripMenuItem});
            this.estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            this.estadosToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.estadosToolStripMenuItem.Text = "Estados Financieros";
            this.estadosToolStripMenuItem.Click += new System.EventHandler(this.estadosToolStripMenuItem_Click);
            // 
            // estadoDeComprobaciónToolStripMenuItem
            // 
            this.estadoDeComprobaciónToolStripMenuItem.Name = "estadoDeComprobaciónToolStripMenuItem";
            this.estadoDeComprobaciónToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.estadoDeComprobaciónToolStripMenuItem.Text = "Estado de Comprobación";
            this.estadoDeComprobaciónToolStripMenuItem.Click += new System.EventHandler(this.estadoDeComprobaciónToolStripMenuItem_Click);
            // 
            // estadoDeResultadoToolStripMenuItem
            // 
            this.estadoDeResultadoToolStripMenuItem.Name = "estadoDeResultadoToolStripMenuItem";
            this.estadoDeResultadoToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.estadoDeResultadoToolStripMenuItem.Text = "Estado de Resultado";
            this.estadoDeResultadoToolStripMenuItem.Click += new System.EventHandler(this.estadoDeResultadoToolStripMenuItem_Click);
            // 
            // estadoDeCapitalToolStripMenuItem
            // 
            this.estadoDeCapitalToolStripMenuItem.Name = "estadoDeCapitalToolStripMenuItem";
            this.estadoDeCapitalToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.estadoDeCapitalToolStripMenuItem.Text = "Estado de Capital";
            this.estadoDeCapitalToolStripMenuItem.Click += new System.EventHandler(this.estadoDeCapitalToolStripMenuItem_Click);
            // 
            // balanceGeneralToolStripMenuItem
            // 
            this.balanceGeneralToolStripMenuItem.Name = "balanceGeneralToolStripMenuItem";
            this.balanceGeneralToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.balanceGeneralToolStripMenuItem.Text = "Balance General";
            this.balanceGeneralToolStripMenuItem.Click += new System.EventHandler(this.balanceGeneralToolStripMenuItem_Click);
            // 
            // planillaToolStripMenuItem
            // 
            this.planillaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEmpleadoToolStripMenuItem,
            this.verPlanillaToolStripMenuItem});
            this.planillaToolStripMenuItem.Name = "planillaToolStripMenuItem";
            this.planillaToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.planillaToolStripMenuItem.Text = "Planilla";
            this.planillaToolStripMenuItem.Click += new System.EventHandler(this.planillaToolStripMenuItem_Click);
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            this.agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            this.agregarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            this.agregarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadoToolStripMenuItem_Click);
            // 
            // verPlanillaToolStripMenuItem
            // 
            this.verPlanillaToolStripMenuItem.Name = "verPlanillaToolStripMenuItem";
            this.verPlanillaToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.verPlanillaToolStripMenuItem.Text = "Ver Planilla";
            this.verPlanillaToolStripMenuItem.Click += new System.EventHandler(this.verPlanillaToolStripMenuItem_Click);
            // 
            // costeoToolStripMenuItem
            // 
            this.costeoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarServicioToolStripMenuItem,
            this.agregarActividadToolStripMenuItem,
            this.agregarRecursoToolStripMenuItem,
            this.verCosteoToolStripMenuItem});
            this.costeoToolStripMenuItem.Name = "costeoToolStripMenuItem";
            this.costeoToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.costeoToolStripMenuItem.Text = "Costeo";
            // 
            // agregarServicioToolStripMenuItem
            // 
            this.agregarServicioToolStripMenuItem.Name = "agregarServicioToolStripMenuItem";
            this.agregarServicioToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.agregarServicioToolStripMenuItem.Text = "Agregar servicio";
            this.agregarServicioToolStripMenuItem.Click += new System.EventHandler(this.agregarServicioToolStripMenuItem_Click);
            // 
            // agregarActividadToolStripMenuItem
            // 
            this.agregarActividadToolStripMenuItem.Name = "agregarActividadToolStripMenuItem";
            this.agregarActividadToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.agregarActividadToolStripMenuItem.Text = "Agregar actividad";
            this.agregarActividadToolStripMenuItem.Click += new System.EventHandler(this.agregarActividadToolStripMenuItem_Click);
            // 
            // agregarRecursoToolStripMenuItem
            // 
            this.agregarRecursoToolStripMenuItem.Name = "agregarRecursoToolStripMenuItem";
            this.agregarRecursoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.agregarRecursoToolStripMenuItem.Text = "Agregar recurso";
            this.agregarRecursoToolStripMenuItem.Click += new System.EventHandler(this.agregarRecursoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "ARTCODE S.A";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(299, 200);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 17);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "label2";
            // 
            // verCosteoToolStripMenuItem
            // 
            this.verCosteoToolStripMenuItem.Name = "verCosteoToolStripMenuItem";
            this.verCosteoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.verCosteoToolStripMenuItem.Text = "Ver costeo";
            this.verCosteoToolStripMenuItem.Click += new System.EventHandler(this.verCosteoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 366);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem estadoDeResultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeCapitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPlanillaToolStripMenuItem;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ToolStripMenuItem costeoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRecursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCosteoToolStripMenuItem;
    }
}

