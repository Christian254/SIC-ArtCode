﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SIC_ArtCode
{
    public partial class Capital : Form
    {
        public Capital()
        {
            InitializeComponent();
        }

        private void btnCapPDF_Click(object sender, EventArgs e)
        {
            Global global = new Global();
            Document document = new Document();
            document = global.CrearPDF("");
            global.EstadoCapitalPDF(document);

        }

        private void Capital_Load(object sender, EventArgs e)
        {

        }
    }
}
