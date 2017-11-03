using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIC_ArtCode
{
    public partial class Comprobacion : Form
    {
        public double recursos = 0, participaciones = 0, resultado=0;
        Global nuevo = new Global();        
        public Comprobacion()
        {
            InitializeComponent();
        }

        private void Comprobacion_Load(object sender, EventArgs e)
        {
            double sumaAct = nuevo.sumatoriaCuentas("activo");
            double sumaPas = nuevo.sumatoriaCuentas("pasivo");
            double sumaCap = nuevo.sumatoriaCuentas("capital");
            double sumaRes = nuevo.sumatoriaCuentas("resultado");
            recursos = nuevo.sumatoriaCuentas("activo");
            participaciones = nuevo.sumatoriaCuentas("pasivo") + nuevo.sumatoriaCuentas("capital")+nuevo.sumatoriaCuentas("resultado");
            this.label1.Text=sumaAct.ToString();
            this.label2.Text = sumaPas.ToString();
            this.label3.Text = sumaCap.ToString();
            this.label7.Text = sumaRes.ToString();
           
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            this.label4.Text = recursos.ToString();
            this.label5.Text = participaciones.ToString();
            this.label6.Text = "=";
            if (recursos == participaciones)
                MessageBox.Show("Recursos igual a Participaciones", "Verificación", MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Recursos distintos a Participaciones", "Verificación", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
