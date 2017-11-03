using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; //Hacer referencia de la libreria de SQl
using MySql.Data.MySqlClient;


namespace SIC_ArtCode
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }        

        private void agregarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCuenta nuevaCuenta = new AgregarCuenta();
            nuevaCuenta.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void verCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCuenta listaCuenta = new VerCuenta();
            listaCuenta.ShowDialog();
        }
    }
}
