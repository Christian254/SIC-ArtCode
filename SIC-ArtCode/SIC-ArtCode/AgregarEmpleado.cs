using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;    
using MySql.Data.MySqlClient;

namespace SIC_ArtCode
{
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void aguinaldo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addEmpleado_Click(object sender, EventArgs e)
        {
            int idEmpleado;
            string apellidoEmpleado;
            string nombreEmpleado;
            float salario;
            float afp;
            float isss;
            float vacaciones;
            int indexAguinaldo;
            float aguinaldo = 0;
            float insaforp = 0;
            string sentencia;

            if(string.IsNullOrWhiteSpace(txtidempleado.Text) || string.IsNullOrWhiteSpace(txtapellido.Text) || string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(txtsalario.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos para agregar una cuenta");
            }

            else
            {
                idEmpleado = int.Parse(txtidempleado.Text);
                apellidoEmpleado = txtapellido.Text;
                nombreEmpleado = txtnombre.Text;
                salario = float.Parse(txtsalario.Text);
                sentencia = @"insert into empleado(idempleado, apellido, nombre, salario, afp, isss, vacaciones, aguinaldo, insaforp) values(?idempleado, ?apellido, ?nombre, ?salario, ?afp, ?isss, ?vacaciones, ?aguinaldo, ?insaforp)";
                MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
                comando.Parameters.AddWithValue("?idempleado", idEmpleado);
                comando.Parameters.AddWithValue("?apellido", apellidoEmpleado);
                comando.Parameters.AddWithValue("?nombre", nombreEmpleado);
                comando.Parameters.AddWithValue("?salario", salario);
                if (salario > 3000)
                {
                    afp = 195;
                }
                else
                {
                    afp = salario * 0.065f;
                }
                comando.Parameters.AddWithValue("?afp", afp);
                if(salario > 1000)
                {
                    isss = 30;
                }
                else
                {
                    isss = salario * 0.075f;
                }
                comando.Parameters.AddWithValue("?isss", isss);
                vacaciones = (salario / 30) * (1.30f);
                comando.Parameters.AddWithValue("?vacaciones", vacaciones);
                if (aguinaldoBox.SelectedIndex == 1)
                {
                    aguinaldo = (salario / 30) * 10;
                }
                if(aguinaldoBox.SelectedIndex == 2)
                {
                    aguinaldo = (salario / 30) * 15;
                }
                if(aguinaldoBox.SelectedIndex == 3)
                {
                    aguinaldo = (salario / 30) * 18;
                }
                comando.Parameters.AddWithValue("?aguinaldo", aguinaldo);
                if (rbdInsaforp.Checked)
                {
                    insaforp = salario * 0.01f;
                }
                comando.Parameters.AddWithValue("?insaforp", insaforp);
                comando.ExecuteNonQuery();
                MessageBox.Show("El empleado: " + nombreEmpleado + " " + apellidoEmpleado + " ha sido agregado");
                BDComun.Conectar().Close();
                txtidempleado.Clear();
                txtapellido.Clear();
                txtnombre.Clear();
                txtsalario.Clear();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
