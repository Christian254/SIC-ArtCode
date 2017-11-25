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
        public EditarEmpleado(int idempleado)
        {
            InitializeComponent();
            id = idempleado;
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
            txtIdempleado.Text = id.ToString();
            MySqlCommand cm = new MySqlCommand("SELECT apellido FROM empleado WHERE idempleado=?idempleado", BDComun.Conectar());
            cm.Parameters.AddWithValue("?idempleado", int.Parse(txtIdempleado.Text));
            cm.ExecuteNonQuery();
            MySqlDataAdapter datos = new MySqlDataAdapter(cm);
            txtApellido.Text = datos.ToString();
            BDComun.Conectar().Close();
        }
    }
}
