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
        Global nueva = new Global();
        public Cuentas()
        {
            InitializeComponent();
        }              

        private void VerCuenta_Load(object sender, EventArgs e)
        {
            
            nueva.ActualizarGrid(dataGridView1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BDComun.Conectar();
            MySqlCommand cm = new MySqlCommand("Delete from cuenta where idcuenta=?idcuenta", BDComun.Conectar());
            cm.Parameters.AddWithValue("?idcuenta", int.Parse(txtIdCuentaRmv.Text));
            cm.ExecuteNonQuery();
            MessageBox.Show("ELimando");
            BDComun.Conectar().Close();            
            nueva.ActualizarGrid(dataGridView1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            txtIdCuentaRmv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
