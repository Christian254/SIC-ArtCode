using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIC_ArtCode
{
    public partial class Periodo : Form
    {
        
        
        

        public Periodo()
        {
            InitializeComponent();

        }

        private void Periodo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
                        
        }

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cant = 1;
            DateTime final;

            if (rdbMensual.Checked)
            {
                cant = 30;
            }
            if (rdbBimensual.Checked)
            {
                cant = 60;
            }
            if (rdbTrimestral.Checked)
            {
                cant = 90;
            }
            if (rdbSemestral.Checked)
            {
                cant = 180;
            }
            if (rbdAnual.Checked)
            {
                cant = 360;
            }

            final = dateTimePicker2.Value.AddDays(cant);

            MessageBox.Show("El final del periodo va a ser en :" + final);
        }
    }
}
