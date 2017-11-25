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

using System.Diagnostics;  


namespace SIC_ArtCode
{
    public partial class VerPlanilla : Form
    {
        Global nueva = new Global();
        public VerPlanilla()
        {
            InitializeComponent();
        }

        private void VerPlanilla_Load(object sender, EventArgs e)
        {
            nueva.ActualizarEmpleados(dataGridView1);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            document = nueva.CrearPDF("general");
            nueva.PlanillaPDF(document, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEliminarE.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BDComun.Conectar();
            MySqlCommand cm = new MySqlCommand("Delete from empleado where idempleado=?idempleado", BDComun.Conectar());
            cm.Parameters.AddWithValue("?idempleado", int.Parse(txtEliminarE.Text));
            cm.ExecuteNonQuery();
            MessageBox.Show("Eliminado");
            BDComun.Conectar().Close();
            nueva.ActualizarEmpleados(dataGridView1);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarEmpleado editarEmpleado = new EditarEmpleado(int.Parse(txtEliminarE.Text));
            editarEmpleado.ShowDialog();
        }
    }
}
