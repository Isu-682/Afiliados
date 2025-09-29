using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afiliados
{
    public partial class Form1 : Form
    {
        private DataTable tablaAfiliados;
        private string rutaArchivo;

        private Dictionary<string, List<string>> entidadMunicipios = new Dictionary<string, List<string>>()
        {
            { "COAHUILA", new List<string>
            { "SIN MUNICIPIO", "ABASOLO", "ACUÑA", "ALLENDE", "ARTEAGA", "CASTAÑOS",
                "CUATROCIENEGAS", "FRANCISCO I. MADERO", "FRONTERA", "GENERAL CEPEDA",
                "JIMENEZ", "LAMADRID", "MATAMOROS", "MONCLOVA", "MUZQUIZ", "NADADORES",
                "NAVA", "OCAMPO", "PARRAS", "PIEDRAS NEGRAS", "PROGRESO", "RAMOS ARIZPE",
                "SABINAS", "SACRAMENTO", "SALTILLO", "SAN BUENAVENTURA", "SAN PEDRO",
                "SIERRA MOJADA", "TORREON", "VIESCA", "VILLA UNION", "ZARAGOZA"
            }
            },
            { "AGUASCALIENTES", new List<string> { "SIN MUNICIPIO" } },
            { "BAJA CALIFORNIA", new List<string> { "SIN MUNICIPIO" } },
            { "BAJA CALIFORNIA SUR", new List<string> { "SIN MUNICIPIO" } },
            { "CAMPECHE", new List<string> { "SIN MUNICIPIO" } },
            { "COLIMA", new List<string> { "SIN MUNICIPIO" } },
            { "CHIAPAS", new List<string> { "SIN MUNICIPIO" } },
            { "CHIHUAHUA", new List<string> { "SIN MUNICIPIO" } },
            { "DURANGO", new List<string> { "SIN MUNICIPIO" } },
            { "GUANAJUATO", new List<string> { "SIN MUNICIPIO" } },
            { "GUERRERO", new List<string> { "SIN MUNICIPIO" } },
            { "HIDALGO", new List<string> { "SIN MUNICIPIO" } },
            { "JALISCO", new List<string> { "SIN MUNICIPIO" } },
            { "MORELOS", new List<string> { "SIN MUNICIPIO" } },
            { "NAYARIT", new List<string> { "SIN MUNICIPIO" } },
            { "NUEVO LEON", new List<string> { "SIN MUNICIPIO" } },
            { "OAXACA", new List<string> { "SIN MUNICIPIO" } },
            { "PUEBLA", new List<string> { "SIN MUNICIPIO" } },
            { "QUERETARO", new List<string> { "SIN MUNICIPIO" } },
            { "QUINTANA ROO", new List<string> { "SIN MUNICIPIO" } },
            { "SAN LUIS POTOSI", new List<string> { "SIN MUNICIPIO" } },
            { "SINALOA", new List<string> { "SIN MUNICIPIO" } },
            { "TABASCO", new List<string> { "SIN MUNICIPIO" } },
            { "TAMAULIPAS", new List<string> { "SIN MUNICIPIO" } },
            { "TLAXCALA", new List<string> { "SIN MUNICIPIO" } },
            { "VERACRUZ", new List<string> { "SIN MUNICIPIO" } },
            { "YUCATAN", new List<string> { "SIN MUNICIPIO" } },
            { "ZACATECAS", new List<string> { "SIN MUNICIPIO" } },
        };

        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpFechaInicial.Visible = false;
            dtpFechaFinal.Visible = false;
            dgvTablaAfiliados.AutoGenerateColumns = false;

            tTiempo.Interval = 1000;
            tTiempo.Tick += tTiempo_Tick;
            tTiempo.Start();

            cbEntidad.DataSource = entidadMunicipios.Keys.ToList();
            if (cbEntidad.Items.Count > 0)
            {
                string entidadSeleccionada = cbEntidad.SelectedItem.ToString();
                cbMunicipio.DataSource = entidadMunicipios[entidadSeleccionada];
            }
            cbEntidad.SelectedIndexChanged += cbEntidad_SelectedIndexChanged;
        }


        private void chboxFecha_CheckedChanged(object sender, EventArgs e)
        {
            bool mostrar = chboxFecha.Checked;
            dtpFechaInicial.Visible = dtpFechaFinal.Visible = mostrar;

            if (!mostrar)
            {
                dtpFechaInicial.Value = DateTime.Today;
                dtpFechaFinal.Value = DateTime.Today;
            }
        }


        private async void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfExcel = new OpenFileDialog();
            opfExcel.Filter = "Archivos de Excel|*.xls;*.xlsx";

            if (opfExcel.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = opfExcel.FileName;
                tbRutaExcel.Text = rutaArchivo;

                tbRutaExcel.Enabled = false;
                btnCargar.Text = "CARGANDO...";
                btnCargar.Enabled = false;

                try
                {
                    tablaAfiliados = await Task.Run(() => CargarExcel(rutaArchivo));

                    labResultadoAfiliado.Text = $"{tablaAfiliados.Rows.Count}";

                    ConfigurarColumnas();
                    dgvTablaAfiliados.DataSource = tablaAfiliados;

                    if (tablaAfiliados.Columns.Contains("FECHA_AFILIACION"))
                    {
                        var fechas = tablaAfiliados.AsEnumerable()
                            .Where(r => !r.IsNull("FECHA_AFILIACION"))
                            .Select(r => Convert.ToDateTime(r["FECHA_AFILIACION"]))
                            .ToList();

                        if (fechas.Any())
                        {
                            labInicioResultadoFecha.Text = fechas.Min().ToString("dd/MM/yyyy");
                            labFinalResultadoFecha.Text = fechas.Max().ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            labInicioResultadoFecha.Text = "No disponible";
                            labFinalResultadoFecha.Text = "No disponible";
                        }
                    }
                    else
                    {
                        labInicioResultadoFecha.Text = "Columna no encontrada";
                        labFinalResultadoFecha.Text = "Columna no encontrada";
                    }

                    MessageBox.Show("Archivo cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar Excel: " + ex.Message);
                }
                finally
                {
                    btnCargar.Text = "CARGAR";
                    btnCargar.Enabled = true;
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

        private void cbEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string entidadSeleccionada = cbEntidad.SelectedItem.ToString();
            if (entidadMunicipios.ContainsKey(entidadSeleccionada))
            {
                cbMunicipio.DataSource = entidadMunicipios[entidadSeleccionada];
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (tablaAfiliados == null) return;

            DataView vista = tablaAfiliados.DefaultView;

            string entidad = cbEntidad.SelectedItem?.ToString();
            string municipio = cbMunicipio.SelectedItem?.ToString();

            List<string> filtros = new List<string>();

            if (!string.IsNullOrEmpty(entidad))
                filtros.Add($"ENTIDAD = '{entidad.Replace("'", "''")}'");

            if (!string.IsNullOrEmpty(municipio))
            {
                if (municipio == "SIN MUNICIPIO")
                    filtros.Add("(MUNICIPIO IS NULL OR MUNICIPIO = '')");
                else
                    filtros.Add($"MUNICIPIO = '{municipio.Replace("'", "''")}'");
            }

            if (dtpFechaInicial.Visible && dtpFechaFinal.Visible)
            {
                DateTime fechaInicio = dtpFechaInicial.Value.Date;
                DateTime fechaFin = dtpFechaFinal.Value.Date;

                filtros.Add($"FECHA_AFILIACION >= #{fechaInicio:MM/dd/yyyy}# AND FECHA_AFILIACION <= #{fechaFin:MM/dd/yyyy}#");
            }

            vista.RowFilter = string.Join(" AND ", filtros);

            dgvTablaAfiliados.DataSource = vista;

            labResultadoAfiliado.Text = $"{vista.Count}";

            if (vista.Count > 0)
            {
                var fechasFiltradas = vista.Cast<DataRowView>()
                                          .Select(r => Convert.ToDateTime(r["FECHA_AFILIACION"]))
                                          .OrderBy(f => f)
                                          .ToList();

                labInicioResultadoFecha.Text = fechasFiltradas.First().ToString("dd/MM/yyyy");
                labFinalResultadoFecha.Text = fechasFiltradas.Last().ToString("dd/MM/yyyy");
            }
            else
            {
                labInicioResultadoFecha.Text = "No disponible";
                labFinalResultadoFecha.Text = "No disponible";
            }
        }

        private void ConfigurarColumnas()
        {
            dgvTablaAfiliados.AutoGenerateColumns = false;
            dgvTablaAfiliados.Columns.Clear();

            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Name = "ID"
            });
            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ENTIDAD",
                HeaderText = "Entidad",
                Name = "ENTIDAD"
            });
            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "MUNICIPIO",
                HeaderText = "Municipio",
                Name = "MUNICIPIO"
            });
            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "NOMBRE",
                HeaderText = "Nombre",
                Name = "NOMBRE"
            });
            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FECHA_AFILIACION",
                HeaderText = "Fecha Afiliación",
                Name = "FECHA_AFILIACION"
            });
            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ESTATUS",
                HeaderText = "Estatus",
                Name = "ESTATUS"
            });
        }


        private void cbEntidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string entidadSeleccionada = cbEntidad.SelectedItem.ToString();
            if (entidadMunicipios.ContainsKey(entidadSeleccionada))
            {
                cbMunicipio.DataSource = entidadMunicipios[entidadSeleccionada];
            }
        }

        private void tTiempo_Tick(object sender, EventArgs e)
        {
            tsslTiempo.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
