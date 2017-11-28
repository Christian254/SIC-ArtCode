using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; //Hacer referencia de la libreria de SQl
using MySql.Data.MySqlClient;


namespace SIC_ArtCode
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }        

        private void agregarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCuenta nuevaCuenta = new AgregarCuenta();
            nuevaCuenta.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy");
        }

        private void verCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuentas listaCuenta = new Cuentas();
            listaCuenta.ShowDialog();
        }

        private void estadoDeComprobaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comprobacion estadoComprobacion = new Comprobacion();
            estadoComprobacion.ShowDialog();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estadoDeResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            resultado.ShowDialog();                 
        }

        private void estadoDeCapitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capital capital = new Capital();
            capital.ShowDialog();
        }

        private void balanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General general = new General();
            general.ShowDialog();
        }

        private void planillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEmpleado nuevoEmpleado = new AgregarEmpleado();
            nuevoEmpleado.ShowDialog();
        }

        private void verPlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerPlanilla planilla = new VerPlanilla();
            planilla.ShowDialog();
        }

        private void agregarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarServicio servicio = new AgregarServicio();
            servicio.ShowDialog();
        }

        private void agregarActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarActividad actividad = new AgregarActividad();
            actividad.ShowDialog();
        }

        private void agregarRecursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarRecurso recurso = new AgregarRecurso();
            recurso.ShowDialog();
        }
    }
}
