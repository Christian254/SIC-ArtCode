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
    public partial class Cuentas : Form
    {
        public Cuentas()
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BDComun.Conectar();
            MySqlCommand cm = new MySqlCommand("Delete from cuenta where idcuenta=?idcuenta", BDComun.Conectar());
            cm.Parameters.AddWithValue("?idcuenta", int.Parse(txtIdCuentaRmv.Text));
            cm.ExecuteNonQuery();
            MessageBox.Show("ELimando");
            BDComun.Conectar().Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            txtIdCuentaRmv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
