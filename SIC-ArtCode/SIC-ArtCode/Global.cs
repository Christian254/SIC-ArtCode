using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SIC_ArtCode
{
    public class Global
    {
        Font fuente = new Font(Font.FontFamily.HELVETICA, 14, Font.BOLD);
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
        public Document CrearPDF()
        {
            Font fuente = new Font(Font.FontFamily.TIMES_ROMAN ,16, Font.ITALIC,BaseColor.BLACK);
            Document doc = new Document(PageSize.LETTER);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }
            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);                
                doc.Open();
                doc.Add(new Paragraph("ArtCode S.A", fuente));               
                
            }
            return doc;
        }
        public void CatalogoCuentasPDF(Document documento, DataGridView grid)
        {
            PdfPTable table = new PdfPTable(grid.ColumnCount);            
            Paragraph paragraph = new Paragraph("Catalogo de Cuentas",fuente);
            paragraph.Alignment = Element.ALIGN_CENTER;            
            documento.Add(paragraph);
            table.DefaultCell.Padding = 3;            
            int i,j;
            for(i=0;i<grid.ColumnCount;i++)
            {
                table.AddCell(grid.Columns[i].HeaderText);
            }
            for(i=0;i<grid.RowCount;i++)
            {
                
                for(j=0; j<grid.ColumnCount; j++)
                {
                    if (grid[j, i].Value != null)
                    {                        
                        table.AddCell(new Phrase(grid[j, i].Value.ToString()));
                    }
                }
                table.CompleteRow();
            }
            documento.Add(new Chunk(""));
            documento.Add(new Chunk(""));
            documento.Add(table);
            documento.Close();
        }
        public void EstadoResultado(Document document)
        {
            Paragraph paragraph = new Paragraph("Estado Resultado",fuente);
            paragraph.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph);            
            string ingreso, nombre, tipo;
            double sumatoria=0;
            MySqlCommand cm = new MySqlCommand("Select * from cuenta where tipo=?tipo", BDComun.Conectar());
            cm.Parameters.AddWithValue("?tipo", "resultado");
            MySqlDataReader reader = cm.ExecuteReader();
            tipo = "Ingresos";
            Paragraph tip = new Paragraph(tipo, fuente);
            document.Add(tip);
            while (reader.Read())
            {
                if (reader.GetDouble("saldo") > 0)
                {
                    document.Add(new Chunk(" "));
                    nombre = reader.GetString("nombre");
                    ingreso = reader.GetString("saldo");
                    Paragraph ing = new Paragraph(ingreso);
                    Paragraph nmb = new Paragraph(nombre);
                    ing.Alignment = Element.ALIGN_CENTER;
                    nmb.Alignment = Element.ALIGN_LEFT;
                    document.Add(nmb);
                    document.Add(ing);
                    document.Add(new Chunk(" "));
                }
            }
            BDComun.Conectar().Close();
            MySqlCommand cm1 = new MySqlCommand("Select * from cuenta where tipo=?tipo", BDComun.Conectar());
            cm1.Parameters.AddWithValue("?tipo", "resultado");
            MySqlDataReader reader1 = cm1.ExecuteReader();
            tipo = "Egresos";
            Paragraph tip1 = new Paragraph(tipo, fuente);
            document.Add(tip1);            
            while (reader1.Read())
            {
                sumatoria += reader1.GetDouble("saldo");
                if(reader1.GetDouble("saldo") < 0)
                {
                    document.Add(new Chunk(" "));
                    nombre = reader1.GetString("nombre");
                    ingreso = reader1.GetString("saldo");
                    Paragraph ing = new Paragraph(ingreso);
                    Paragraph nmb = new Paragraph(nombre);
                    ing.Alignment = Element.ALIGN_RIGHT;
                    nmb.Alignment = Element.ALIGN_LEFT;
                    document.Add(nmb);
                    document.Add(ing);
                    document.Add(new Chunk(" "));              
                }
            }
            Paragraph suma = new Paragraph(sumatoria.ToString(),fuente);
            Paragraph utilidades = new Paragraph("utilidades",fuente);
            suma.Alignment = Element.ALIGN_RIGHT;
            utilidades.Alignment = Element.ALIGN_LEFT;
            document.Add(utilidades);
            document.Add(suma);
            document.Close();
            BDComun.Conectar().Close();
        }

    }
}
