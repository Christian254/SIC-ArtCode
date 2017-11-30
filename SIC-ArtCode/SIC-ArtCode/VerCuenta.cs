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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SIC_ArtCode
{
    public partial class Cuentas : Form
    {
        Global nueva = new Global();
        public Cuentas()
        {
            InitializeComponent();
            nueva.ActualizarGrid(dataGridView1);
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
            MessageBox.Show("ELiminado");
            BDComun.Conectar().Close();            
            nueva.ActualizarGrid(dataGridView1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            txtIdCuentaRmv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            document = nueva.CrearPDF("general");
            nueva.CatalogoCuentasPDF(document, dataGridView1);

        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {
            Ajuste ajuste = new Ajuste(int.Parse(txtIdCuentaRmv.Text));
            ajuste.ShowDialog();
            nueva.ActualizarGrid(dataGridView1);
        }
    }
}
