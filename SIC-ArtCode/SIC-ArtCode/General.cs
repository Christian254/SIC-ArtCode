using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;

namespace SIC_ArtCode
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            Global global = new Global();
            Document document = new Document();
            document=global.CrearPDF("general");
            global.BalanceGeneralPDF(document);
        }
    }
}
