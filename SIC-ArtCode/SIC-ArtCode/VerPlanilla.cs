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
            nueva.PlanillaPDF(dataGridView1);
        }
    }
}
