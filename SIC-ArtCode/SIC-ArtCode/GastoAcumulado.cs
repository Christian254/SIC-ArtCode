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
    public partial class GastoAcumulado : Form
    {
        int idCuentaGasto;
        int idCA = 25000;
        public GastoAcumulado(int id)
        {
            InitializeComponent();
            idCuentaGasto = id;
        }

        private void GastoAcumulado_Load(object sender, EventArgs e)
        {
            MySqlCommand nombre = new MySqlCommand("SELECT * FROM cuenta WHERE idcuenta=?idcuenta", BDComun.Conectar());
            nombre.Parameters.AddWithValue("?idcuenta", idCuentaGasto);
            nombre.ExecuteNonQuery();
            MySqlDataReader reader1 = nombre.ExecuteReader();
            if (reader1.Read())
            {
                txtCuenta.Text = reader1.GetString(1);
                txtSaldo.Text = reader1.GetString(3);
            }
            txtId.Text = idCuentaGasto.ToString();
            BDComun.Conectar().Close();
            idCA++;
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            float saldo = float.Parse(txtSaldo.Text);
            float porcentaje = float.Parse(txtPorcentaje.Text);
            float gastoAcum;
            gastoAcum = (porcentaje / 100) * saldo;
            lblGasto.Text = "Gasto Acumulado: ";
            lblValorGasto.Text = gastoAcum.ToString();
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            idCA++;
            idCA++;
            float montoGasto = 0;
            MySqlCommand gasto = new MySqlCommand("SELECT * FROM cuenta WHERE idcuenta=20000", BDComun.Conectar());
            gasto.ExecuteNonQuery();
            MySqlDataReader sqlDataReader = gasto.ExecuteReader();
            if (sqlDataReader.Read())
            {
                montoGasto = sqlDataReader.GetFloat(3);
            }
            string sentencia = @"insert into cuenta(idcuenta, nombre, tipo, saldo, fecha) values(?idcuenta, ?nombre, ?tipo, ?saldo, ?fecha)";
            MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
            comando.Parameters.AddWithValue("?idcuenta", idCA);
            comando.Parameters.AddWithValue("?nombre", "Cuenta Incobrable " + txtCuenta.Text+" (CA)");
            comando.Parameters.AddWithValue("?tipo", "activo");
            comando.Parameters.AddWithValue("?saldo", -1 * float.Parse(lblValorGasto.Text));
            comando.Parameters.AddWithValue("?fecha", "2017/11/29");
            comando.ExecuteNonQuery();
            BDComun.Conectar().Close();
            MessageBox.Show("Se agregó la cuenta: Gasto Acumulado " + txtCuenta.Text);
            montoGasto += -1 * float.Parse(lblValorGasto.Text);
            MySqlCommand saldo = new MySqlCommand("UPDATE contables.cuenta SET saldo=?saldo WHERE idcuenta=20000", BDComun.Conectar());
            saldo.Parameters.AddWithValue("?saldo", montoGasto);
            saldo.ExecuteNonQuery();
            BDComun.Conectar().Close();
        }
    }
}
