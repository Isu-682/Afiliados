using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Afiliados
{
    public partial class frmAfiliados : Form
    {
        // Tabla en memoria para almacenar los datos del archivo Excel
        private DataTable tablaAfiliados;
        // Ruta del archivo seleccionado
        private string rutaArchivo;

        // Diccionario que relaciona la entidad "COAHUILA" con sus municipios
        Dictionary<string, List<string>> entidadMunicipios = new Dictionary<string, List<string>>()
        {
            { "COAHUILA", new List<string> { "SIN MUNICIPIO","ABASOLO","ACUÑA","ALLENDE","ARTEAGA","CASTAÑOS",
                "CUATROCIENEGAS","FRANCISCO I. MADERO","FRONTERA","GENERAL CEPEDA","JIMENEZ","LAMADRID",
                "MATAMOROS","MONCLOVA","MUZQUIZ","NADADORES","NAVA","OCAMPO","PARRAS","PIEDRAS NEGRAS",
                "PROGRESO","RAMOS ARIZPE","SABINAS","SACRAMENTO","SALTILLO","SAN BUENAVENTURA","SAN PEDRO",
                "SIERRA MOJADA","TORREON","VIESCA","VILLA UNION","ZARAGOZA"}
            }
        };

        // Columnas que se esperan del archivo Excel
        string[] columnas = { "ID", "ENTIDAD", "MUNICIPIO", "NOMBRE", "FECHA_AFILIACION", "ESTATUS" };

        public frmAfiliados()
        {
            InitializeComponent();
            // Necesario para que ExcelDataReader pueda leer archivos con codificación diferente
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ocultar controles de fechas inicialmente
            labFechaIn.Visible = labFechaFin.Visible = dtpFechaInicial.Visible = dtpFechaFinal.Visible = false;
            dgvTablaAfiliados.AutoGenerateColumns = false;

            // Configuración de reloj en barra de estado
            tTiempo.Interval = 1000;
            tTiempo.Tick += (s, ev) => tsslTiempo.Text = DateTime.Now.ToString("HH:mm:ss");
            tTiempo.Start();

            // Cargar entidades en ComboBox
            cbEntidad.DataSource = entidadMunicipios.Keys.ToList();

            // Al cambiar de entidad, actualizar los municipios correspondientes
            cbEntidad.SelectedIndexChanged += (s, ev) =>
                cbMunicipio.DataSource = entidadMunicipios.ContainsKey(cbEntidad.Text) ? entidadMunicipios[cbEntidad.Text] : null;
        }

        // Evento que muestra u oculta los filtros por fecha
        private void chboxFecha_CheckedChanged(object sender, EventArgs e)
        {
            bool mostrar = chboxFecha.Checked;
            dtpFechaInicial.Visible = dtpFechaFinal.Visible = labFechaIn.Visible = labFechaFin.Visible = mostrar;
            if (!mostrar) dtpFechaInicial.Value = dtpFechaFinal.Value = DateTime.Today;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opfExcel = new OpenFileDialog { Filter = "Archivos de Excel|*.xls;*.xlsx" })
            {
                if (opfExcel.ShowDialog() != DialogResult.OK) return;

                tablaAfiliados?.Dispose(); // Limpia la tabla previa si existe
                rutaArchivo = opfExcel.FileName;
                tbRutaExcel.Text = rutaArchivo;

                // Deshabilita los controles mientras carga
                tbRutaExcel.Enabled = btnCargar.Enabled = false;

                // Ejecuta la carga del archivo en un hilo separado
                new Thread(CargarArchivoEnHilo).Start();
            }
        }

        private DataTable CargarExcel(string ruta) =>
            ExcelReaderFactory.CreateReader(File.Open(ruta, FileMode.Open, FileAccess.Read))
            .AsDataSet(new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration { UseHeaderRow = true },
                FilterSheet = (r, i) => i == 0 // Solo se usa la primera hoja
            }).Tables[0];

        // Reinicia todos los controles a su estado inicial
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvTablaAfiliados.DataSource = null;
            tbRutaExcel.Clear();
            cbEntidad.SelectedIndex = -1;
            cbMunicipio.DataSource = null;
            labResultadoAfiliado.Text = "0";
            labInicioResultadoFecha.Text = labFinalResultadoFecha.Text = "";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (tablaAfiliados == null) return;
            DataView vista = tablaAfiliados.DefaultView;
            List<string> filtros = new List<string>();

            // Filtro por entidad
            if (!string.IsNullOrEmpty(cbEntidad.Text))
                filtros.Add($"ENTIDAD = '{cbEntidad.Text.Replace("'", "''")}'");

            // Filtro por municipio
            if (!string.IsNullOrEmpty(cbMunicipio.Text) && cbMunicipio.Text != "TODOS")
            {
                if (cbMunicipio.Text == "SIN MUNICIPIO")
                    filtros.Add("(MUNICIPIO IS NULL OR MUNICIPIO = '')");
                else
                    filtros.Add($"MUNICIPIO = '{cbMunicipio.Text.Replace("'", "''")}'");
            }

            // Filtro por rango de fechas
            if (dtpFechaInicial.Visible)
                filtros.Add($"FECHA_AFILIACION >= #{dtpFechaInicial.Value:MM/dd/yyyy}# AND FECHA_AFILIACION <= #{dtpFechaFinal.Value:MM/dd/yyyy}#");

            // Aplicar filtro combinado
            vista.RowFilter = string.Join(" AND ", filtros);
            dgvTablaAfiliados.DataSource = vista;
            labResultadoAfiliado.Text = $"{vista.Count}";

            // Mostrar rango de fechas si hay resultados
            if (vista.Count > 0)
            {
                var fechas = vista.Cast<DataRowView>()
                                  .Select(r => Convert.ToDateTime(r["FECHA_AFILIACION"]))
                                  .OrderBy(f => f).ToList();
                labInicioResultadoFecha.Text = fechas.First().ToString("dd/MM/yyyy");
                labFinalResultadoFecha.Text = fechas.Last().ToString("dd/MM/yyyy");
            }
            else
            {
                labInicioResultadoFecha.Text = labFinalResultadoFecha.Text = "No disponible";
            }
        }

        // Configura las columnas del DataGridView manualmente
        private void ConfigurarColumnas()
        {
            dgvTablaAfiliados.AutoGenerateColumns = false;
            dgvTablaAfiliados.Columns.Clear();

            foreach (var col in columnas)
                dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = col,
                    HeaderText = col.Replace("_", " "),
                    Name = col
                });
        }

        private void cbEntidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string entidad = cbEntidad.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(entidad))
            {
                cbMunicipio.DataSource = null;
                return;
            }

            List<string> municipios;
            if (!entidadMunicipios.TryGetValue(entidad, out municipios))
            {
                cbMunicipio.DataSource = null;
                return;
            }

            // Agregar "TODOS" como opción adicional
            List<string> listaMunicipios = new List<string> { "TODOS" };
            listaMunicipios.AddRange(municipios);

            cbMunicipio.DataSource = listaMunicipios;
        }

        private void tTiempo_Tick(object sender, EventArgs e)
        {
            tsslTiempo.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void CargarArchivoEnHilo()
        {
            try
            {
                // Cargar solo las columnas necesarias
                var datosFiltrados = CargarExcel(rutaArchivo).DefaultView.ToTable(false, "ID", "ENTIDAD", "MUNICIPIO", "NOMBRE", "FECHA_AFILIACION", "ESTATUS");

                // Ejecutar en el hilo principal
                Invoke(new Action(() =>
                {
                    tablaAfiliados?.Dispose();
                    tablaAfiliados = datosFiltrados;

                    dgvTablaAfiliados.SuspendLayout();
                    ConfigurarColumnas();
                    dgvTablaAfiliados.DataSource = tablaAfiliados;
                    dgvTablaAfiliados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvTablaAfiliados.ResumeLayout();

                    ConfigurarFechas(tablaAfiliados);
                    labResultadoAfiliado.Text = $"{tablaAfiliados.Rows.Count}";

                    MessageBox.Show("Archivo cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCargar.Enabled = tbRutaExcel.Enabled = true;
                }));
            }
            catch (Exception ex)
            {
                // Mostrar error si algo falla
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Error al cargar Excel: " + ex.Message);
                    btnCargar.Enabled = tbRutaExcel.Enabled = true;
                }));
            }
        }

        // Extrae y muestra el rango de fechas de afiliación disponibles
        private void ConfigurarFechas(DataTable datos)
        {
            if (!datos.Columns.Contains("FECHA_AFILIACION"))
            {
                labInicioResultadoFecha.Text = labFinalResultadoFecha.Text = "Columna no encontrada";
                return;
            }

            var fechas = datos.AsEnumerable().Where(r => !r.IsNull("FECHA_AFILIACION")).Select(r => Convert.ToDateTime(r["FECHA_AFILIACION"])).ToList();
            if (fechas.Any())
            {
                labInicioResultadoFecha.Text = fechas.Min().ToString("dd/MM/yyyy");
                labFinalResultadoFecha.Text = fechas.Max().ToString("dd/MM/yyyy");
            }
            else labInicioResultadoFecha.Text = labFinalResultadoFecha.Text = "No disponible";
        }
    }
}