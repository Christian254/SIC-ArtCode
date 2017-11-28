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
    public partial class EditarEmpleado : Form
    {
        int id;
        int idEliminar;
        float salario;
        float afp;
        float isss;
        float aguinaldo;
        float vacaciones;
        string apellido;
        string nombre;
        string sentencia;
        float insaforp;

        public EditarEmpleado(int idempleado)
        {
            InitializeComponent();
            id = idempleado;
            idEliminar = idempleado;
            aguinaldoBox.Items.Insert(0, "1 año a 3 años");
            aguinaldoBox.Items.Insert(1, "3 años a 10 años");
            aguinaldoBox.Items.Insert(2, "10 años en adelante");
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
            txtIdempleado.Text = id.ToString();
            MySqlCommand cm = new MySqlCommand("SELECT apellido FROM empleado WHERE idempleado=?idempleado", BDComun.Conectar());
            cm.Parameters.AddWithValue("?idempleado", int.Parse(txtIdempleado.Text));
            cm.ExecuteNonQuery();
            MySqlDataReader DR1 = cm.ExecuteReader();
            if (DR1.Read())
            {
                txtApellido.Text = DR1.GetValue(0).ToString();
            }
            BDComun.Conectar().Close();

            MySqlCommand cm1 = new MySqlCommand("SELECT nombre FROM empleado WHERE apellido=?apellido", BDComun.Conectar());
            cm1.Parameters.AddWithValue("?apellido", DR1.GetValue(0).ToString());
            cm1.ExecuteNonQuery();
            MySqlDataReader DR2 = cm1.ExecuteReader();
            if (DR2.Read())
            {
                txtNombre.Text = DR2.GetValue(0).ToString();
            }
            BDComun.Conectar().Close();

            MySqlCommand cm2 = new MySqlCommand("SELECT salario FROM empleado WHERE nombre=?nombre", BDComun.Conectar());
            cm2.Parameters.AddWithValue("?nombre", DR2.GetValue(0).ToString());
            cm2.ExecuteNonQuery();
            MySqlDataReader DR3 = cm2.ExecuteReader();
            if (DR3.Read())
            {
                txtSalario.Text = DR3.GetValue(0).ToString();
                salario = float.Parse(DR3.GetValue(0).ToString());
            }
            BDComun.Conectar().Close();

            if (salario > 3000)
            {
                afp = 195.00f;
            }
            else
            {
                afp = salario * 0.065f;
            }
            txtAfp.Text = afp.ToString();
            if (salario > 1000)
            {
                isss = 30;
            }
            else
            {
                isss = salario * 0.075f;
            }
            txtIsss.Text = isss.ToString();
            vacaciones = (salario / 30) * (1.30f);
            txtVacaciones.Text = vacaciones.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            salario = float.Parse(txtSalario.Text);
            if (salario > 3000)
            {
                afp = 195.00f;
            }
            else
            {
                afp = salario * 0.065f;
            }
            txtAfp.Text = afp.ToString();
            if (salario > 1000)
            {
                isss = 30;
            }
            else
            {
                isss = salario * 0.075f;
            }
            txtIsss.Text = isss.ToString();
            vacaciones = (salario / 30) * (1.30f);
            txtVacaciones.Text = vacaciones.ToString();
            if (aguinaldoBox.SelectedIndex == 0)
            {
                aguinaldo = (salario / 30) * 10;
            }
            if (aguinaldoBox.SelectedIndex == 1)
            {
                aguinaldo = (salario / 30) * 15;
            }
            if (aguinaldoBox.SelectedIndex == 2)
            {
                aguinaldo = (salario / 30) * 18;
            }
            txtAguinaldo.Text = aguinaldo.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlCommand cm = new MySqlCommand("Delete from empleado where idempleado=?idempleado", BDComun.Conectar());
            cm.Parameters.AddWithValue("?idempleado", idEliminar);
            cm.ExecuteNonQuery();
            BDComun.Conectar().Close();

            id = int.Parse(txtIdempleado.Text);
            apellido = txtApellido.Text;
            nombre = txtNombre.Text;
            salario = float.Parse(txtSalario.Text);
            sentencia = @"insert into empleado(idempleado, apellido, nombre, salario, afp, isss, vacaciones, aguinaldo, insaforp) values(?idempleado, ?apellido, ?nombre, ?salario, ?afp, ?isss, ?vacaciones, ?aguinaldo, ?insaforp)";
            MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
            comando.Parameters.AddWithValue("?idempleado", id);
            comando.Parameters.AddWithValue("?apellido", apellido);
            comando.Parameters.AddWithValue("?nombre", nombre);
            comando.Parameters.AddWithValue("?salario", salario);
            if (salario > 3000)
            {
                afp = 195.00f;
            }
            else
            {
                afp = salario * 0.065f;
            }
            comando.Parameters.AddWithValue("?afp", afp);
            if (salario > 1000)
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
            if (aguinaldoBox.SelectedIndex == 0)
            {
                aguinaldo = (salario / 30) * 10;
            }
            if (aguinaldoBox.SelectedIndex == 1)
            {
                aguinaldo = (salario / 30) * 15;
            }
            if (aguinaldoBox.SelectedIndex == 2)
            {
                aguinaldo = (salario / 30) * 18;
            }
            comando.Parameters.AddWithValue("?aguinaldo", aguinaldo);
            if (checkInsaforp.Checked)
            {
                insaforp = salario * 0.01f;
            }
            comando.Parameters.AddWithValue("?insaforp", insaforp);
            comando.ExecuteNonQuery();
            MessageBox.Show("El empleado: " + nombre + " " + apellido + " ha sido editado");
            BDComun.Conectar().Close();
            txtIdempleado.Clear();
            txtIdempleado.Clear();
            txtNombre.Clear();
            txtSalario.Clear();

            var instance = new VerPlanilla();
            instance.actualizar();
        }
    }
}
