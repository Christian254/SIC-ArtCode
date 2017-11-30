using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIC_ArtCode
{
    public partial class AgregarActividad : Form
    {


        Global nueva = new Global();
        public AgregarActividad()
        {
            InitializeComponent();
            nueva.ActualizarServicios(dataGridView1);
        }

       

        private void AgregarActividad_Load(object sender, EventArgs e)
        {
            nueva.ActualizarServicios(dataGridView1);

            /*int i = 0;                        
            
            MySqlCommand cm = new MySqlCommand("SELECT COUNT(*) FROM servicio", BDComun.Conectar());
            int count = int.Parse(cm.ExecuteScalar().ToString());
            BDComun.Conectar().Close();

            while (i <= count){
                MySqlCommand cm1 = new MySqlCommand("SELECT nombre_servicio FROM servicio WHERE idservicio=?idservicio", BDComun.Conectar());
                cm1.Parameters.AddWithValue("?idservicio", i);
                cm1.ExecuteNonQuery();
                MySqlDataReader DR = cm1.ExecuteReader();
                if (DR.Read())
                {
                    comboBoxServicio.Items.Insert(index: 0, item: DR.GetValue(0).ToString());
                }
                BDComun.Conectar().Close();
                i++;
            } */


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtservicioId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idActividad;
            string nombreActividad;
            string sentencia; 
            float costo = 0f;
             

            if(String.IsNullOrEmpty(txtservicioId.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos para agregar una actividad");
            }
            else
            {
                idActividad = int.Parse(txtId.Text);
                nombreActividad = txtNombre.Text; 
                //idServicio = comboBoxServicio.SelectedIndex;
                //prueba = comboBoxServicio.SelectedText;
                /*ySqlCommand cm1 = new MySqlCommand("SELECT idservicio FROM servicio WHERE nombre_servicio=?nombre_servicio", BDComun.Conectar());
                cm1.Parameters.AddWithValue("?nombre_servicio", prueba);
                cm1.ExecuteNonQuery();
                MySqlDataReader DR = cm1.ExecuteReader();
                if (DR.Read())
                {
                    idServicio = int.Parse(DR.GetValue(0).ToString());
                }
                BDComun.Conectar().Close(); */
                






                sentencia = @"insert into actividad(idactividad, nombre_actvidad, costo_actividad, servicio_idservicio) values(?idactividad, ?nombre_actvidad, ?costo_actividad, ?servicio_idservicio)";
                MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
                comando.Parameters.AddWithValue("?idactividad", idActividad);
                comando.Parameters.AddWithValue("?nombre_actvidad", nombreActividad);
                comando.Parameters.AddWithValue("?costo_actividad", costo);
                comando.Parameters.AddWithValue("?servicio_idservicio", int.Parse(txtservicioId.Text.ToString()));
                comando.ExecuteNonQuery();
                MessageBox.Show("La actividad " + nombreActividad + " ha sido agregada");
                BDComun.Conectar().Close();
                txtId.Clear();
                txtNombre.Clear();
            } 
        }

        
    }
}
