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
    public partial class AgregarServicio : Form
    {
        public AgregarServicio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idServicio;
            string nombreServicio;
            string sentencia;
            float costo = 0f;

            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos para agregar un servicio");
            }
            else
            {
                idServicio = int.Parse(txtId.Text);
                nombreServicio = txtNombre.Text;

                sentencia = @"insert into servicio(idservicio, nombre_servicio, costo_total) values(?idservicio, ?nombre_servicio, ?costo_total)";
                MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
                comando.Parameters.AddWithValue("?idservicio", idServicio);
                comando.Parameters.AddWithValue("?nombre_servicio", nombreServicio);
                comando.Parameters.AddWithValue("?costo_total", costo);
                comando.ExecuteNonQuery();
                MessageBox.Show("El servicio " + nombreServicio + " ha sido agregado");
                BDComun.Conectar().Close();
                txtId.Clear();
                txtNombre.Clear();
            }
        }

        private void AgregarServicio_Load(object sender, EventArgs e)
        {

        }
    }
}
