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
        int idServicio;
        int i = 0;

        public AgregarRecurso()
        {
            InitializeComponent();
            nueva.ActualizarServicios(dataGridView1);
        }

        private void AgregarRecurso_Load(object sender, EventArgs e)
        {
            nueva.ActualizarServicios(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idServicio = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()); 

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            MySqlCommand cm = new MySqlCommand("SELECT COUNT(*) FROM actividad WHERE servicio_idservicio=?servicio_idservicio", BDComun.Conectar());
            cm.Parameters.AddWithValue("?servicio_idservicio", idServicio);
            int count = int.Parse(cm.ExecuteScalar().ToString());
            BDComun.Conectar().Close();

            while (i <= count)
            {
                MySqlCommand cm1 = new MySqlCommand("SELECT nombre_actvidad FROM actividad WHERE servicio_idservicio=?servicio_idservicio", BDComun.Conectar());
                cm1.Parameters.AddWithValue("?servicio_idservicio", idServicio);
                cm1.ExecuteNonQuery();
                MySqlDataReader DR = cm1.ExecuteReader();
                if (DR.Read())
                {
                    actividadBox.Items.Insert(0, DR.GetValue(0).ToString());
                }
                BDComun.Conectar().Close();
                i++;
            }
        }
    }
}
