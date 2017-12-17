namespace SIC_ArtCode
{
    partial class Costeo
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
            this.gridServicios = new System.Windows.Forms.DataGridView();
            this.gridActividades = new System.Windows.Forms.DataGridView();
            this.gridRecuros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSeleccionarS = new System.Windows.Forms.Button();
            this.btnSeleccionarA = new System.Windows.Forms.Button();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtIdRecurso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecuros)).BeginInit();
            this.SuspendLayout();
            // 
            // gridServicios
            // 
            this.gridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServicios.Location = new System.Drawing.Point(47, 78);
            this.gridServicios.Name = "gridServicios";
            this.gridServicios.RowTemplate.Height = 24;
            this.gridServicios.Size = new System.Drawing.Size(436, 280);
            this.gridServicios.TabIndex = 0;
            this.gridServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridServicios_CellContentClick);
            // 
            // gridActividades
            // 
            this.gridActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActividades.Location = new System.Drawing.Point(703, 78);
            this.gridActividades.Name = "gridActividades";
            this.gridActividades.RowTemplate.Height = 24;
            this.gridActividades.Size = new System.Drawing.Size(447, 280);
            this.gridActividades.TabIndex = 1;
            this.gridActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridActividades_CellContentClick);
            // 
            // gridRecuros
            // 
            this.gridRecuros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRecuros.Location = new System.Drawing.Point(362, 483);
            this.gridRecuros.Name = "gridRecuros";
            this.gridRecuros.RowTemplate.Height = 24;
            this.gridRecuros.Size = new System.Drawing.Size(455, 221);
            this.gridRecuros.TabIndex = 2;
            this.gridRecuros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRecuros_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Servicios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(884, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Actividades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recursos";
            // 
            // btnSeleccionarS
            // 
            this.btnSeleccionarS.Location = new System.Drawing.Point(47, 387);
            this.btnSeleccionarS.Name = "btnSeleccionarS";
            this.btnSeleccionarS.Size = new System.Drawing.Size(148, 27);
            this.btnSeleccionarS.TabIndex = 6;
            this.btnSeleccionarS.Text = "Seleccionar Servicio";
            this.btnSeleccionarS.UseVisualStyleBackColor = true;
            this.btnSeleccionarS.Click += new System.EventHandler(this.btnSeleccionarS_Click);
            // 
            // btnSeleccionarA
            // 
            this.btnSeleccionarA.Location = new System.Drawing.Point(703, 390);
            this.btnSeleccionarA.Name = "btnSeleccionarA";
            this.btnSeleccionarA.Size = new System.Drawing.Size(166, 28);
            this.btnSeleccionarA.TabIndex = 7;
            this.btnSeleccionarA.Text = "Seleccionar Actividad";
            this.btnSeleccionarA.UseVisualStyleBackColor = true;
            this.btnSeleccionarA.Click += new System.EventHandler(this.btnSeleccionarA_Click);
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(236, 387);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(100, 22);
            this.txtServicio.TabIndex = 8;
            this.txtServicio.Visible = false;
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(920, 390);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(100, 22);
            this.txtActividad.TabIndex = 9;
            this.txtActividad.Visible = false;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(845, 629);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 22);
            this.txtCosto.TabIndex = 10;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(845, 667);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 37);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar Costo";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtIdRecurso
            // 
            this.txtIdRecurso.Location = new System.Drawing.Point(845, 593);
            this.txtIdRecurso.Name = "txtIdRecurso";
            this.txtIdRecurso.Size = new System.Drawing.Size(100, 22);
            this.txtIdRecurso.TabIndex = 12;
            this.txtIdRecurso.Visible = false;
            // 
            // Costeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 729);
            this.Controls.Add(this.txtIdRecurso);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.btnSeleccionarA);
            this.Controls.Add(this.btnSeleccionarS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridRecuros);
            this.Controls.Add(this.gridActividades);
            this.Controls.Add(this.gridServicios);
            this.Name = "Costeo";
            this.Text = "Costeo";
            this.Load += new System.EventHandler(this.Costeo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecuros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridServicios;
        private System.Windows.Forms.DataGridView gridActividades;
        private System.Windows.Forms.DataGridView gridRecuros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSeleccionarS;
        private System.Windows.Forms.Button btnSeleccionarA;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtIdRecurso;
    }
}