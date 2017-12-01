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
            /* Agregando Cuenta Resultado Gasto Por Depreciacion  */
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy");
            string sentencia = @"insert into cuenta(idcuenta, nombre, tipo, saldo, fecha) values(?idcuenta, ?nombre, ?tipo, ?saldo, ?fecha)";
            MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
            comando.Parameters.AddWithValue("?idcuenta", 5000);
            comando.Parameters.AddWithValue("?nombre", "Gasto Por Depreciacion");
            comando.Parameters.AddWithValue("?tipo", "resultado");
            comando.Parameters.AddWithValue("?saldo", 0);
            comando.Parameters.AddWithValue("?fecha", "2017/11/29");
            comando.ExecuteNonQuery();
            BDComun.Conectar().Close();
            /* Agregando Cuenta Resultado Gasto Acumulado */
            string sentencia1 = @"insert into cuenta(idcuenta, nombre, tipo, saldo, fecha) values(?idcuenta, ?nombre, ?tipo, ?saldo, ?fecha)";
            MySqlCommand comando1 = new MySqlCommand(sentencia1, BDComun.Conectar());
            comando1.Parameters.AddWithValue("?idcuenta", 20000);
            comando1.Parameters.AddWithValue("?nombre", "Gasto Acumulado");
            comando1.Parameters.AddWithValue("?tipo", "resultado");
            comando1.Parameters.AddWithValue("?saldo", 0);
            comando1.Parameters.AddWithValue("?fecha", "2017/11/29");
            comando1.ExecuteNonQuery();
            BDComun.Conectar().Close();
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

        private void periodoContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Periodo periodo = new Periodo();
            periodo.ShowDialog();
        }
    }
}
