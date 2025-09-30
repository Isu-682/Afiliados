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
        // Contiene los datos cargados desde el archivo Excel
        private DataTable tablaAfiliados;
        // Ruta del archivo Excel seleccionado por el usuario
        private string rutaArchivo;

        // Diccionario que almacena la relación entre entidades federativas y sus municipios correspondientes
        // Cada clave representa una entidad, y el valor es una lista de municipios pertenecientes a esa entidad
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

        // Inicializa los componentes visuales y registra el proveedor de codificaciones
        // necesarias para leer archivos Excel con codificaciones específicas
        public frmAfiliados()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        // Configura el estado inicial de los controles del formulario como la visibilidad de fechas,
        // el temporizador de reloj, y la carga de entidades en el ComboBox.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Oculta controles de fecha al iniciar
            labFechaIn.Visible = false;
            labFechaFin.Visible = false;
            dtpFechaInicial.Visible = false;
            dtpFechaFinal.Visible = false;

            // Desactiva la autogeneración de columnas del DataGridView
            dgvTablaAfiliados.AutoGenerateColumns = false;

            // Configura y activa el temporizador para mostrar la hora actual
            tTiempo.Interval = 1000;
            tTiempo.Tick += tTiempo_Tick;
            tTiempo.Start();

            // Carga las entidades al ComboBox y limpia la selección
            cbEntidad.DataSource = entidadMunicipios.Keys.ToList();
            cbEntidad.SelectedIndex = -1;

            // Limpia el ComboBox de municipios
            cbMunicipio.DataSource = null;

            // Registra el evento para cuando cambie la entidad seleccionada
            cbEntidad.SelectedIndexChanged += cbEntidad_SelectedIndexChanged_1;
        }

        // Muestra u oculta los controles de selección de fechas y etiquetas relacionadas
        private void chboxFecha_CheckedChanged(object sender, EventArgs e)
        {
            bool mostrar = chboxFecha.Checked;
            dtpFechaInicial.Visible = mostrar;
            dtpFechaFinal.Visible = mostrar;

            labFechaIn.Visible = mostrar;
            labFechaFin.Visible = mostrar;

            // Si se desactiva el filtro por fecha, se reinician los valores
            if (!mostrar)
            {
                dtpFechaInicial.Value = DateTime.Today;
                dtpFechaFinal.Value = DateTime.Today;
            }
        }

        // Abre un diálogo para seleccionar un archivo de Excel y comienza la carga en un hilo separado
        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfExcel = new OpenFileDialog();
            opfExcel.Filter = "Archivos de Excel|*.xls;*.xlsx";

            if (opfExcel.ShowDialog() == DialogResult.OK)
            {
                // Libera recursos si ya había una tabla cargada
                if (tablaAfiliados != null)
                {
                    tablaAfiliados.Dispose();
                    tablaAfiliados = null;
                }

                // Deshabilita controles mientras se carga el archivo
                rutaArchivo = opfExcel.FileName;
                tbRutaExcel.Text = rutaArchivo;
                tbRutaExcel.Enabled = false;
                btnCargar.Text = "CARGANDO...";
                btnCargar.Enabled = false;

                // Carga el archivo en un hilo aparte para no congelar la interfaz
                Thread hilo = new Thread(new ThreadStart(CargarArchivoEnHilo));
                hilo.Start();
            }
        }

        // Carga el contenido de un archivo de Excel en una tabla de datos (DataTable)
        // Solo lee la primera hoja del libro y usa la primera fila como encabezados
        private DataTable CargarExcel(string rutaArchivo)
        {
            using (var stream = File.Open(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        // Configura la lectura de la hoja de Excel: se usará la primera fila como encabezados de columna
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        },
                        // Solo se carga la primera hoja
                        FilterSheet = (tableReader, index) => index == 0
                    });

                    return result.Tables[0];
                }
            }
        }

        // Limpia la interfaz, restablece los valores de los controles, y borra cualquier archivo cargado previamente
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvTablaAfiliados.DataSource = null;
            tbRutaExcel.Clear();

            // Limpia etiquetas de resultado
            labResultadoAfiliado.Text = "0";
            labInicioResultadoFecha.Text = "No disponible";
            labFinalResultadoFecha.Text = "No disponible";

            dgvTablaAfiliados.DataSource = null;
            tbRutaExcel.Clear();

            // Limpia selección de entidad y municipio
            cbEntidad.SelectedIndex = -1;
            cbMunicipio.DataSource = null;

            // Refuerza limpieza por seguridad
            labResultadoAfiliado.Text = "0";
            labInicioResultadoFecha.Text = "";
            labFinalResultadoFecha.Text = "";
        }

        // Filtra los registros mostrados en el DataGridView en función de la entidad, municipio y rango de fechas seleccionados
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Si no hay datos cargados, no se realiza ninguna acción
            if (tablaAfiliados == null) return;

            // Se obtiene una vista de los datos originales para aplicar filtros
            DataView vista = tablaAfiliados.DefaultView;

            string entidad = cbEntidad.SelectedItem?.ToString();
            string municipio = cbMunicipio.SelectedItem?.ToString();

            List<string> filtros = new List<string>();

            // Filtro por entidad seleccionada
            if (!string.IsNullOrEmpty(entidad))
                filtros.Add($"ENTIDAD = '{entidad.Replace("'", "''")}'");

            // Filtro por municipio, considerando los valores vacíos como "SIN MUNICIPIO"
            if (!string.IsNullOrEmpty(municipio))
            {
                if (municipio == "SIN MUNICIPIO")
                    filtros.Add("(MUNICIPIO IS NULL OR MUNICIPIO = '')");
                else
                    filtros.Add($"MUNICIPIO = '{municipio.Replace("'", "''")}'");
            }

            // Filtro por fechas si los controles están visibles
            if (dtpFechaInicial.Visible && dtpFechaFinal.Visible)
            {
                DateTime fechaInicio = dtpFechaInicial.Value.Date;
                DateTime fechaFin = dtpFechaFinal.Value.Date;

                // El formato con # es para la sintaxis de filtros de DataTable
                filtros.Add($"FECHA_AFILIACION >= #{fechaInicio:MM/dd/yyyy}# AND FECHA_AFILIACION <= #{fechaFin:MM/dd/yyyy}#");
            }

            // Se combinan los filtros con AND lógico
            vista.RowFilter = string.Join(" AND ", filtros);

            // Se actualiza la tabla con la vista filtrada
            dgvTablaAfiliados.DataSource = vista;

            // Muestra el número de resultados encontrados
            labResultadoAfiliado.Text = $"{vista.Count}";

            // Si hay resultados, se actualizan las fechas mínima y máxima encontradas
            if (vista.Count > 0)
            {
                // Toma la columna FECHA_AFILIACION de todos los registros actualmente visibles en el DataView,
                // convierte esas fechas a DateTime, las ordena de menor a mayor, y las guarda en una lista
                var fechasFiltradas = vista.Cast<DataRowView>()
                                          .Select(r => Convert.ToDateTime(r["FECHA_AFILIACION"]))
                                          .OrderBy(f => f)
                                          .ToList();

                labInicioResultadoFecha.Text = fechasFiltradas.First().ToString("dd/MM/yyyy");
                labFinalResultadoFecha.Text = fechasFiltradas.Last().ToString("dd/MM/yyyy");
            }
            else
            {
                // Si no hay resultados, se indican como no disponibles
                labInicioResultadoFecha.Text = "No disponible";
                labFinalResultadoFecha.Text = "No disponible";
            }
        }

        // Configura manualmente las columnas del DataGridView para mostrar las propiedades esperadas del archivo Excel
        private void ConfigurarColumnas()
        {
            // Desactiva la generación automática para usar configuración manual
            dgvTablaAfiliados.AutoGenerateColumns = false;
            dgvTablaAfiliados.Columns.Clear();

            // Agrega columna para ID
            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Name = "ID"
            });

            // Columna para ENTIDAD
            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ENTIDAD",
                HeaderText = "ENTIDAD",
                Name = "ENTIDAD"
            });

            // Columna para MUNICIPIO
            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "MUNICIPIO",
                HeaderText = "MUNICIPIO",
                Name = "MUNICIPIO"
            });

            // Columna para NOMBRE del afiliado
            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "NOMBRE",
                HeaderText = "NOMBRE",
                Name = "NOMBRE"
            });

            // Columna para FECHA de AFILIACION
            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FECHA_AFILIACION",
                HeaderText = "FECHA AFILIACION",
                Name = "FECHA_AFILIACION"
            });

            // Columna para ESTATUS
            dgvTablaAfiliados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ESTATUS",
                HeaderText = "ESTATUS",
                Name = "ESTATUS"
            });
        }

        // Actualiza el ComboBox de municipios con base en la entidad seleccionada
        private void cbEntidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbEntidad.SelectedItem == null) return;

            string entidadSeleccionada = cbEntidad.SelectedItem.ToString();

            if (entidadMunicipios.ContainsKey(entidadSeleccionada))
            {
                // Asigna la lista de municipios correspondientes a la entidad seleccionada
                cbMunicipio.DataSource = entidadMunicipios[entidadSeleccionada];
            }
            else
            {
                // Limpia el ComboBox si no hay municipios disponibles
                cbMunicipio.DataSource = null;
            }
        }

        // Evento del temporizador que actualiza la hora actual en la barra de estado
        private void tTiempo_Tick(object sender, EventArgs e)
        {
            tsslTiempo.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // Carga el archivo Excel seleccionado en un hilo separado para no bloquear la UI
        // Solo se cargan las columnas necesarias, y se actualiza la interfaz con los datos cargados
        private void CargarArchivoEnHilo()
        {
            try
            {
                // Carga los datos desde el archivo Excel
                DataTable datosOriginales = CargarExcel(rutaArchivo);

                // Define las columnas que se desean conservar
                string[] columnasNecesarias = { "ID", "ENTIDAD", "MUNICIPIO", "NOMBRE", "FECHA_AFILIACION", "ESTATUS" };

                // Filtra el DataTable para que solo contenga las columnas necesarias
                DataTable datosFiltrados = datosOriginales.DefaultView.ToTable(false, columnasNecesarias);

                // Accede al hilo principal para actualizar la UI
                Invoke(new Action(() =>
                {
                    // Libera la tabla anterior si existía
                    if (tablaAfiliados != null)
                    {
                        tablaAfiliados.Dispose();
                        tablaAfiliados = null;
                    }

                    // Asigna los nuevos datos filtrados
                    tablaAfiliados = datosFiltrados;

                    // Mejora rendimiento al modificar columnas
                    dgvTablaAfiliados.SuspendLayout();

                    // Define las columnas del DataGridView manualmente
                    ConfigurarColumnas();

                    dgvTablaAfiliados.DataSource = tablaAfiliados;

                    // Llena el ancho disponible
                    dgvTablaAfiliados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Reactiva el layout
                    dgvTablaAfiliados.ResumeLayout();

                    // Muestra el rango de fechas disponible
                    ConfigurarFechas(tablaAfiliados);

                    // Muestra número de registros
                    labResultadoAfiliado.Text = $"{tablaAfiliados.Rows.Count}";

                    // Notifica al usuario
                    MessageBox.Show("Archivo cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Restablece el estado de los controles
                    btnCargar.Text = "CARGAR";
                    btnCargar.Enabled = true;
                    tbRutaExcel.Enabled = true;
                }));
            }
            catch (Exception ex)
            {
                // En caso de error, muestra mensaje y habilita nuevamente los controles
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Error al cargar Excel: " + ex.Message);
                    btnCargar.Text = "CARGAR";
                    btnCargar.Enabled = true;
                    tbRutaExcel.Enabled = true;
                }));
            }
        }

        // Configura y muestra las fechas mínima y máxima de afiliación encontradas en el DataTable.
        private void ConfigurarFechas(DataTable datos)
        {
            // Verifica si existe la columna "FECHA_AFILIACION" en el DataTable
            if (datos.Columns.Contains("FECHA_AFILIACION"))
            {
                // Convierte el DataTable en una lista de fechas de la columna "FECHA_AFILIACION" excluyendo valores nulos
                // Filtra las filas que no tienen valor nulo en la columna de fecha
                // Su resultado seria una lista que contiene todas las fechas válidas encontradas en la columna
                var fechas = datos.AsEnumerable()
                                  .Where(r => !r.IsNull("FECHA_AFILIACION"))
                                  // Convierte a DateTime
                                  .Select(r => Convert.ToDateTime(r["FECHA_AFILIACION"]))
                                  .ToList();

                // Si hay fechas válidas
                if (fechas.Any())
                {
                    // Muestra la fecha más antigua y la más reciente en formato dd/MM/yyyy
                    labInicioResultadoFecha.Text = fechas.Min().ToString("dd/MM/yyyy");
                    labFinalResultadoFecha.Text = fechas.Max().ToString("dd/MM/yyyy");
                }
                else
                {
                    // No hay fechas válidas en el dataset
                    labInicioResultadoFecha.Text = "No disponible";
                    labFinalResultadoFecha.Text = "No disponible";
                }
            }
            else
            {
                // La columna "FECHA_AFILIACION" no fue encontrada en el archivo Excel
                labInicioResultadoFecha.Text = "Columna no encontrada";
                labFinalResultadoFecha.Text = "Columna no encontrada";
            }
        }
    }
}
