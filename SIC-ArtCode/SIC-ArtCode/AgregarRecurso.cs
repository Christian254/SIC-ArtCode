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
    public partial class AgregarRecurso : Form
    {

        Global nueva = new Global();
        //int idServicio;
        //int i = 0;

        public AgregarRecurso()
        {
            InitializeComponent();
            nueva.ActualizarServicios(dataGridView2);
        }

        private void AgregarRecurso_Load(object sender, EventArgs e)
        {
            nueva.ActualizarServicios(dataGridView2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdServicio.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            nueva.ActualizarActvidades(dataGridView1, int.Parse(txtIdServicio.Text.ToString()));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdActividad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string sentencia;


            sentencia = @"insert into recursos(idrecursos, nombre_recursos, costo_recurso, actividad_idactividad) values(?idrecursos, ?nombre_recursos, ?costo_recurso, ?actividad_idactividad)";
            MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
            comando.Parameters.AddWithValue("?idrecursos", int.Parse(txtId.Text.ToString()));
            comando.Parameters.AddWithValue("?nombre_recursos", txtNombre.Text.ToString());
            comando.Parameters.AddWithValue("?costo_recurso", float.Parse(txtCosto.Text.ToString()));
            comando.Parameters.AddWithValue("?actividad_idactividad", int.Parse(txtIdActividad.Text.ToString()));
            comando.ExecuteNonQuery();
            MessageBox.Show("El recurso " + txtNombre.Text.ToString() + " ha sido agregado, con un costo de: " + txtCosto.Text.ToString());
            BDComun.Conectar().Close();
            txtId.Clear();
            txtNombre.Clear();

            nueva.sumaActividad(float.Parse(txtCosto.Text.ToString()), int.Parse(txtIdActividad.Text.ToString()));
            nueva.sumaServicio(float.Parse(txtCosto.Text.ToString()), int.Parse(txtIdServicio.Text.ToString()));
        }
    }
}
