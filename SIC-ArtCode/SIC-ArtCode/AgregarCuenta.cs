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
            double saldo;
            string nmbCuenta = txtNmbCuenta.Text;
            string sentencia;
            idCuenta = int.Parse(txtIdCuenta.Text);
            saldo = double.Parse(txtSaldo.Text);
            sentencia = @"insert into cuenta(idcuenta, nombre, tipo, saldo) values(?idcuenta, ?nombre, ?tipo, ?saldo)";
            MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
            comando.Parameters.AddWithValue("?idcuenta", idCuenta);
            comando.Parameters.AddWithValue("?nombre", nmbCuenta);
            if (rdbActivo.Checked)
            {
                comando.Parameters.AddWithValue("?tipo", "activo");
            }
            if (rdbPasivo.Checked)
            {
                comando.Parameters.AddWithValue("?tipo", "pasivo");          
            }
            if (rdbCapital.Checked)
            {
                comando.Parameters.AddWithValue("?tipo", "capital");
            }
            comando.Parameters.AddWithValue("?saldo",saldo);
            comando.ExecuteNonQuery();         
            MessageBox.Show("La cuenta: " + nmbCuenta + " ha sido ingresada con exito");                                   
            BDComun.Conectar().Close();
            txtIdCuenta.Clear();
            txtNmbCuenta.Clear();
            txtSaldo.Clear();           
        }
    }
}
