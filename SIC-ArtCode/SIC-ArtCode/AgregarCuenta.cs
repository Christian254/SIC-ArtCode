﻿using System;
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
            DateTime fechaHoy = DateTime.Today;
            string fecha = fechaHoy.ToString("s");
            txtFecha.Text = fecha.Substring(0,10);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {            
            int idCuenta;
            float saldo;
            string nmbCuenta = txtNmbCuenta.Text;
            string sentencia, fech=txtFecha.Text;
            

            if (string.IsNullOrWhiteSpace(txtIdCuenta.Text) || string.IsNullOrWhiteSpace(txtNmbCuenta.Text) || string.IsNullOrWhiteSpace(txtSaldo.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos para agregar una cuenta");
            }
            else
            {
                idCuenta = int.Parse(txtIdCuenta.Text);
                saldo = float.Parse(txtSaldo.Text);
                fech = txtFecha.Text;
                sentencia = @"insert into cuenta(idcuenta, nombre, tipo, saldo, fecha) values(?idcuenta, ?nombre, ?tipo, ?saldo, ?fecha)";
                
                MySqlCommand comando = new MySqlCommand(sentencia, BDComun.Conectar());
                comando.Parameters.AddWithValue("?idcuenta", idCuenta);
                comando.Parameters.AddWithValue("?nombre", nmbCuenta);
                if (rdbActivo.Checked)
                {
                    comando.Parameters.AddWithValue("?tipo", "activo");
                }                   
                    comando.Parameters.AddWithValue("?fecha", fech);

                if (rdbPasivo.Checked)
                {
                    comando.Parameters.AddWithValue("?tipo", "pasivo");
                }
                if (rdbCapital.Checked)
                {
                    comando.Parameters.AddWithValue("?tipo", "capital");
                }
                if (rdbResultado.Checked)
                {
                    comando.Parameters.AddWithValue("?tipo", "resultado");
                }

                comando.Parameters.AddWithValue("?saldo", saldo);
                comando.ExecuteNonQuery();
                MessageBox.Show("La cuenta: " + nmbCuenta + " ha sido ingresada con exito");
                BDComun.Conectar().Close();
                txtIdCuenta.Clear();
                txtNmbCuenta.Clear();
                txtSaldo.Clear();
            }
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {





        }

        private void AgregarCuenta_Load(object sender, EventArgs e)
        {





        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void grpTipo_Enter(object sender, EventArgs e)
        {

        }
    }
    //Prueba
}
