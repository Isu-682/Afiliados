using ExcelDataReader;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afiliados
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpFecha.Visible = false;
        }

        private void dgvTablaAfiliados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chboxFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFecha.Visible = chboxFecha.Checked;
        }
                

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfExcel = new OpenFileDialog();
            opfExcel.Filter = "Archivos de Excel|*.xls;*.xlsx";

            if (opfExcel.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = opfExcel.FileName;
                tbRutaExcel.Text = rutaArchivo;

                tbRutaExcel.Enabled = false;
                btnCargar.Text = "Cargando...";

                try
                {
                    
                    DataTable tabla = await Task.Run(() => CargarExcel(rutaArchivo));                                        
                    dgvTablaAfiliados.DataSource = tabla;
                    MessageBox.Show("Archivo cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar Excel: " + ex.Message);
                }
                finally
                {
                    btnCargar.Enabled = true;
                    btnCargar.Text = "Cargar Excel";

                    tbRutaExcel.Enabled = true;
                }
            }
        }

        private DataTable CargarExcel(string rutaArchivo)
        {
            using (var stream = File.Open(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    return result.Tables[0];
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvTablaAfiliados.DataSource = null;
            tbRutaExcel.Clear();
        }
    }
}
