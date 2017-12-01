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
    public partial class Depreciacion : Form
    {

        int idC;
        int idCA = 10000;      
        
        public Depreciacion(int id)
        {
            InitializeComponent();
            idC = id;            
        }

        private void Depreciacion_Load(object sender, EventArgs e)
        {
            MySqlCommand nombre = new MySqlCommand("SELECT * FROM cuenta WHERE idcuenta=?idcuenta", BDComun.Conectar());
            nombre.Parameters.AddWithValue("?idcuenta",idC);
            nombre.ExecuteNonQuery();
            MySqlDataReader reader1 = nombre.ExecuteReader();
            if(reader1.Read())
            {
                txtCuenta.Text = reader1.GetValue(1).ToString();
                txtP.Text = reader1.GetValue(3).ToString();
            }            
            BDComun.Conectar().Close();
            txtID.Text = idC.ToString();
            idCA++;
        }

        private void btnCalD_Click(object sender, EventArgs e)
        {
            float saldo = float.Parse(txtP.Text);
            float valorRec = float.Parse(txtL.Text);
            int n = int.Parse(txtN.Text);
            float depreciacion;
            depreciacion = (saldo - valorRec) / n;
            lblCalD.Text = "Depreciación";
            lblValorD.Text = depreciacion.ToString();
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            idCA++;
            float montoGasto=0;
            MySqlCommand gasto = new MySqlCommand("SELECT * FROM cuenta WHERE idcuenta=5000", BDComun.Conectar());
            gasto.ExecuteNonQuery();
            MySqlDataReader sqlDataReader = gasto.ExecuteReader();
            if(sqlDataReader.Read())
            {
                 montoGasto = sqlDataReader.GetFloat(3);
            }            
            string sentencia = @"insert into cuenta(idcuenta, nombre, tipo, saldo, fecha) values(?idcuenta, ?nombre, ?tipo, ?saldo, ?fecha)";
            MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
            comando.Parameters.AddWithValue("?idcuenta", idCA);
            comando.Parameters.AddWithValue("?nombre", "Depreciacion Acumulada "+txtCuenta.Text+" (CA)");
            comando.Parameters.AddWithValue("?tipo", "activo");
            comando.Parameters.AddWithValue("?saldo", -1*float.Parse(lblValorD.Text));
            comando.Parameters.AddWithValue("?fecha", "2017/11/29");
            comando.ExecuteNonQuery();
            BDComun.Conectar().Close();
            MessageBox.Show("Se agregó la cuenta: Depreciación Acumulada " + txtCuenta.Text);                      
            montoGasto += -1 * float.Parse(lblValorD.Text);
            MySqlCommand saldo = new MySqlCommand("UPDATE contables.cuenta SET saldo=?saldo WHERE idcuenta=5000", BDComun.Conectar());
            saldo.Parameters.AddWithValue("?saldo", montoGasto);
            saldo.ExecuteNonQuery();
            BDComun.Conectar().Close();
        }
    }
}
