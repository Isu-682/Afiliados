namespace Afiliados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTablaAfiliados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labFechaFinal = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTiempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.tTiempo = new System.Windows.Forms.Timer(this.components);
            this.cbEntidad = new System.Windows.Forms.ComboBox();
            this.cbMunicipio = new System.Windows.Forms.ComboBox();
            this.labFechaInicio = new System.Windows.Forms.Label();
            this.labInicioResultadoFecha = new System.Windows.Forms.Label();
            this.labFinalResultadoFecha = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.chboxFecha = new System.Windows.Forms.CheckBox();
            this.labResultadoAfiliado = new System.Windows.Forms.Label();
            this.labNumeroAfiliados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.tbRutaExcel = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAfiliados)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTIDAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MUNICIPIO";
            // 
            // dgvTablaAfiliados
            // 
            this.dgvTablaAfiliados.AllowUserToAddRows = false;
            this.dgvTablaAfiliados.AllowUserToDeleteRows = false;
            this.dgvTablaAfiliados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablaAfiliados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvTablaAfiliados.Location = new System.Drawing.Point(12, 188);
            this.dgvTablaAfiliados.Name = "dgvTablaAfiliados";
            this.dgvTablaAfiliados.ReadOnly = true;
            this.dgvTablaAfiliados.Size = new System.Drawing.Size(903, 150);
            this.dgvTablaAfiliados.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ENTIDAD";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MUNICIPIO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NOMBRE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "FECHA_AFILIACION";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ESTATUS";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // labFechaFinal
            // 
            this.labFechaFinal.AutoSize = true;
            this.labFechaFinal.Location = new System.Drawing.Point(311, 155);
            this.labFechaFinal.Name = "labFechaFinal";
            this.labFechaFinal.Size = new System.Drawing.Size(85, 13);
            this.labFechaFinal.TabIndex = 3;
            this.labFechaFinal.Text = "ULTIMA FECHA";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTiempo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(929, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTiempo
            // 
            this.tsslTiempo.Name = "tsslTiempo";
            this.tsslTiempo.Size = new System.Drawing.Size(0, 17);
            // 
            // ofdExcel
            // 
            this.ofdExcel.FileName = "openFileDialog1";
            // 
            // tTiempo
            // 
            this.tTiempo.Tick += new System.EventHandler(this.tTiempo_Tick);
            // 
            // cbEntidad
            // 
            this.cbEntidad.FormattingEnabled = true;
            this.cbEntidad.Items.AddRange(new object[] {
            "AGUASCALIENTES",
            "BAJA CALIFORNIA",
            "BAA CALIFORNIA SUR",
            "CAMPECHE",
            "COAHUILA",
            "COLIMA",
            "CHIAPAS",
            "CHIHUAHUA",
            "CIUDAD DE MEXICO",
            "DURANGO",
            "GUANAJUATO",
            "GUERRERO",
            "HIDALGO",
            "JALISCO",
            "MORELOS",
            "NAYARIT",
            "NUEVO LEON",
            "OAXACA",
            "PUEBLA",
            "QUERETARO",
            "QUINTANA ROO",
            "SAN LUIS POTOSI",
            "SINALOA",
            "SONORA",
            "TABASCO",
            "TAMAULIPAS",
            "TLAXCALA",
            "VERACRUZ",
            "YUCATAN",
            "ZACATECAS"});
            this.cbEntidad.Location = new System.Drawing.Point(104, 105);
            this.cbEntidad.Name = "cbEntidad";
            this.cbEntidad.Size = new System.Drawing.Size(121, 21);
            this.cbEntidad.TabIndex = 6;
            this.cbEntidad.SelectedIndexChanged += new System.EventHandler(this.cbEntidad_SelectedIndexChanged_1);
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.Items.AddRange(new object[] {
            "SIN MUNICIPIO",
            "ABASOLO",
            "ACUÑA",
            "ALLENDE",
            "ARTEAGA",
            "CASTAÑOS",
            "CUATROCIENEGAS",
            "FRANCISCO I. MADERO",
            "FRONTERA",
            "GENERAL CEPEDA",
            "JIMENEZ",
            "LAMADRID",
            "MATAMOROS",
            "MONCLOVA",
            "MUZQUIZ",
            "NADADORES",
            "NAVA",
            "OCAMPO",
            "PARRAS",
            "PIEDRAS NEGRAS",
            "PROGRESO",
            "RAMOS ARIZPE",
            "SABINAS",
            "SACRAMENTO",
            "SALTILLO",
            "SAN BUENAVENTURA",
            "SAN PEDRO",
            "SIERRA MOJADA",
            "TORREON",
            "VIESCA",
            "VILLA UNION",
            "ZARAGOZA"});
            this.cbMunicipio.Location = new System.Drawing.Point(104, 149);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(121, 21);
            this.cbMunicipio.TabIndex = 7;
            // 
            // labFechaInicio
            // 
            this.labFechaInicio.AutoSize = true;
            this.labFechaInicio.Location = new System.Drawing.Point(311, 108);
            this.labFechaInicio.Name = "labFechaInicio";
            this.labFechaInicio.Size = new System.Drawing.Size(95, 13);
            this.labFechaInicio.TabIndex = 9;
            this.labFechaInicio.Text = "FECHA DE INICIO";
            // 
            // labInicioResultadoFecha
            // 
            this.labInicioResultadoFecha.AutoSize = true;
            this.labInicioResultadoFecha.ForeColor = System.Drawing.Color.Gray;
            this.labInicioResultadoFecha.Location = new System.Drawing.Point(422, 108);
            this.labInicioResultadoFecha.Name = "labInicioResultadoFecha";
            this.labInicioResultadoFecha.Size = new System.Drawing.Size(0, 13);
            this.labInicioResultadoFecha.TabIndex = 11;
            // 
            // labFinalResultadoFecha
            // 
            this.labFinalResultadoFecha.AutoSize = true;
            this.labFinalResultadoFecha.ForeColor = System.Drawing.Color.Gray;
            this.labFinalResultadoFecha.Location = new System.Drawing.Point(422, 155);
            this.labFinalResultadoFecha.Name = "labFinalResultadoFecha";
            this.labFinalResultadoFecha.Size = new System.Drawing.Size(0, 13);
            this.labFinalResultadoFecha.TabIndex = 10;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(721, 77);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(194, 20);
            this.dtpFechaInicial.TabIndex = 12;
            // 
            // chboxFecha
            // 
            this.chboxFecha.AutoSize = true;
            this.chboxFecha.Location = new System.Drawing.Point(754, 23);
            this.chboxFecha.Name = "chboxFecha";
            this.chboxFecha.Size = new System.Drawing.Size(126, 17);
            this.chboxFecha.TabIndex = 13;
            this.chboxFecha.Text = "HABILITAR FECHA?";
            this.chboxFecha.UseVisualStyleBackColor = true;
            this.chboxFecha.CheckedChanged += new System.EventHandler(this.chboxFecha_CheckedChanged);
            // 
            // labResultadoAfiliado
            // 
            this.labResultadoAfiliado.AutoSize = true;
            this.labResultadoAfiliado.ForeColor = System.Drawing.Color.Gray;
            this.labResultadoAfiliado.Location = new System.Drawing.Point(648, 129);
            this.labResultadoAfiliado.Name = "labResultadoAfiliado";
            this.labResultadoAfiliado.Size = new System.Drawing.Size(0, 13);
            this.labResultadoAfiliado.TabIndex = 15;
            // 
            // labNumeroAfiliados
            // 
            this.labNumeroAfiliados.AutoSize = true;
            this.labNumeroAfiliados.Location = new System.Drawing.Point(489, 129);
            this.labNumeroAfiliados.Name = "labNumeroAfiliados";
            this.labNumeroAfiliados.Size = new System.Drawing.Size(131, 13);
            this.labNumeroAfiliados.TabIndex = 14;
            this.labNumeroAfiliados.Text = "NUMERO DE AFILIADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ARCHIVO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(198, 54);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(101, 23);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(321, 53);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(101, 23);
            this.btnReiniciar.TabIndex = 19;
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // tbRutaExcel
            // 
            this.tbRutaExcel.Location = new System.Drawing.Point(104, 21);
            this.tbRutaExcel.Name = "tbRutaExcel";
            this.tbRutaExcel.Size = new System.Drawing.Size(545, 20);
            this.tbRutaExcel.TabIndex = 20;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(442, 54);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(101, 23);
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(724, 154);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(194, 20);
            this.dtpFechaFinal.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(769, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "FECHA DE INICIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(781, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "FECHA FINAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 363);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.tbRutaExcel);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labResultadoAfiliado);
            this.Controls.Add(this.labNumeroAfiliados);
            this.Controls.Add(this.chboxFecha);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.labInicioResultadoFecha);
            this.Controls.Add(this.labFinalResultadoFecha);
            this.Controls.Add(this.labFechaInicio);
            this.Controls.Add(this.cbMunicipio);
            this.Controls.Add(this.cbEntidad);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labFechaFinal);
            this.Controls.Add(this.dgvTablaAfiliados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAfiliados)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTablaAfiliados;
        private System.Windows.Forms.Label labFechaFinal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTiempo;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.Timer tTiempo;
        private System.Windows.Forms.ComboBox cbEntidad;
        private System.Windows.Forms.ComboBox cbMunicipio;
        private System.Windows.Forms.Label labFechaInicio;
        private System.Windows.Forms.Label labInicioResultadoFecha;
        private System.Windows.Forms.Label labFinalResultadoFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.CheckBox chboxFecha;
        private System.Windows.Forms.Label labResultadoAfiliado;
        private System.Windows.Forms.Label labNumeroAfiliados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.TextBox tbRutaExcel;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

