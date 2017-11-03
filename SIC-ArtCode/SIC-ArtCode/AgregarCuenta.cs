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
    public partial class AgregarCuenta : Form
    {
        public AgregarCuenta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idCuenta;       
            string nmbCuenta = txtNmbCuenta.Text;
            string sentencia;
            idCuenta = int.Parse(txtIdCuenta.Text);
            sentencia = @"insert into cuenta(idcuenta, nombre) values(?idcuenta, ?nombre)";
            MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
            comando.Parameters.AddWithValue("?idcuenta", idCuenta);
            comando.Parameters.AddWithValue("?nombre", nmbCuenta);
            comando.ExecuteNonQuery();
            MessageBox.Show("La cuenta: "+nmbCuenta+" ha sido ingresada con exito");
            BDComun.Conectar().Close();

        }
    }
}
