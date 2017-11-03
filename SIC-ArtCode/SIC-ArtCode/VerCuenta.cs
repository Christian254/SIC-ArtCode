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
    public partial class VerCuenta : Form
    {
        public VerCuenta()
        {
            InitializeComponent();
        }              

        private void VerCuenta_Load(object sender, EventArgs e)
        {
            MySqlCommand cm = new MySqlCommand("SELECT * FROM cuenta", BDComun.Conectar());
            MySqlDataAdapter datos = new MySqlDataAdapter(cm);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            dataGridView1.DataSource = tabla;
            BDComun.Conectar().Close();
        }
    }
}
