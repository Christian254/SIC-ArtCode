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
    public partial class Modificar : Form
    {
        int idCuenta;
        public Modificar(int id)
        {
            InitializeComponent();
            idCuenta = id;
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            MySqlCommand cuenta = new MySqlCommand("SELECT * FROM cuenta WHERE idcuenta=?idcuenta", BDComun.Conectar());
            cuenta.Parameters.AddWithValue("?idcuenta", idCuenta);
            cuenta.ExecuteNonQuery();
            MySqlDataReader reader1 = cuenta.ExecuteReader();
            if (reader1.Read())
            {
                txtCuenta.Text = reader1.GetValue(1).ToString();
                txtTipo.Text = reader1.GetString(2);
                txtSaldo.Text = reader1.GetValue(3).ToString();
            }
            txtID.Text = idCuenta.ToString();
            BDComun.Conectar().Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            float saldo = float.Parse(txtSaldo.Text);
            float monto = float.Parse(txtValor.Text);
            if(String.Compare(txtTipo.Text,"activo")==0)
            {
                saldo += monto; 
            }
            else
            {
                saldo -= monto;
            }
            txtSaldo.Text = saldo.ToString();
            MySqlCommand update = new MySqlCommand("UPDATE contables.cuenta SET saldo=?saldo WHERE idcuenta=?idcuenta", BDComun.Conectar());
            update.Parameters.AddWithValue("?idcuenta", idCuenta);
            update.Parameters.AddWithValue("?saldo", saldo);
            update.ExecuteNonQuery();
            BDComun.Conectar().Close();
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            float saldo = float.Parse(txtSaldo.Text);
            float monto = float.Parse(txtValor.Text);
            if (String.Compare(txtTipo.Text, "activo") != 0)
            {
                saldo += monto;
            }
            else
            {
                saldo -= monto;
            }
            txtSaldo.Text = saldo.ToString();
            MySqlCommand update = new MySqlCommand("UPDATE contables.cuenta SET saldo=?saldo WHERE idcuenta=?idcuenta", BDComun.Conectar());
            update.Parameters.AddWithValue("?idcuenta", idCuenta);
            update.Parameters.AddWithValue("?saldo", saldo);
            update.ExecuteNonQuery();
            BDComun.Conectar().Close();
        }
    }
}
