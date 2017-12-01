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
    public partial class Costeo : Form
    {
        Global nueva = new Global();

        public Costeo()
        {
            InitializeComponent();
        }

        private void Costeo_Load(object sender, EventArgs e)
        {
            nueva.ActualizarServiciosTotal(gridServicios);
        }

        private void gridServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtServicio.Text = gridServicios.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSeleccionarS_Click(object sender, EventArgs e)
        {
            nueva.ActualizarActvidadesTotal(gridActividades, int.Parse(txtServicio.Text));
        }

        private void gridActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtActividad.Text = gridActividades.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSeleccionarA_Click(object sender, EventArgs e)
        {
            nueva.ActualizarRecursos(gridRecuros, int.Parse(txtActividad.Text));
        }

        private void gridRecuros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdRecurso.Text = gridRecuros.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string sentencia;

            sentencia = @"UPDATE recursos SET costo_recurso = ?costoRecurso WHERE idrecursos = ?idrecursos";
            MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
            comando.Parameters.AddWithValue("?costoRecurso", float.Parse(txtCosto.Text.ToString()));
            comando.Parameters.AddWithValue("?idrecursos", int.Parse(txtIdRecurso.Text.ToString()));
            comando.ExecuteNonQuery();
            BDComun.Conectar().Close();
            MessageBox.Show("El costo del recurso ha sido modificado");
            txtCosto.Clear();
        }
    }
}
