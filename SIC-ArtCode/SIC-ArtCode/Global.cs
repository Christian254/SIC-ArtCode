﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIC_ArtCode
{
    public class Global
    {
        public void ActualizarGrid(DataGridView grid) //funcion para actualizar el grid
        {
            MySqlCommand cm = new MySqlCommand("SELECT * FROM cuenta", BDComun.Conectar());
            MySqlDataAdapter datos = new MySqlDataAdapter(cm);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            grid.DataSource = tabla;
            BDComun.Conectar().Close();
        }
        public double sumatoriaCuentas(string tipo)
        {            
            double sumatoria = 0;
            MySqlCommand cm = new MySqlCommand("Select * from cuenta where tipo=?tipo", BDComun.Conectar());
            cm.Parameters.AddWithValue("?tipo", tipo);
            MySqlDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                sumatoria += reader.GetDouble("saldo");                
            }            
            return sumatoria;
        }


    }
}
