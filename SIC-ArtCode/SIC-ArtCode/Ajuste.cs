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
    public partial class Ajuste : Form
    {
        int id;
        public Ajuste(int idCuenta)
        {
            InitializeComponent();
            id = idCuenta;            
        }

        private void Ajuste_Load(object sender, EventArgs e)
        {

        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            Depreciacion depreciacion = new Depreciacion(id);
            depreciacion.ShowDialog();
        }
    }
}
