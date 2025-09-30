namespace Afiliados
{
    partial class frmAfiliados
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
            this.labFechaIn = new System.Windows.Forms.Label();
            this.labFechaFin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAfiliados)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(47, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTIDAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(47, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
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
            this.dgvTablaAfiliados.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgvTablaAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvTablaAfiliados.Location = new System.Drawing.Point(16, 311);
            this.dgvTablaAfiliados.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvTablaAfiliados.Name = "dgvTablaAfiliados";
            this.dgvTablaAfiliados.ReadOnly = true;
            this.dgvTablaAfiliados.Size = new System.Drawing.Size(1125, 231);
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
            this.labFechaFinal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labFechaFinal.Location = new System.Drawing.Point(348, 238);
            this.labFechaFinal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labFechaFinal.Name = "labFechaFinal";
            this.labFechaFinal.Size = new System.Drawing.Size(108, 20);
            this.labFechaFinal.TabIndex = 3;
            this.labFechaFinal.Text = "ULTIMA FECHA";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTiempo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1152, 22);
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
            this.cbEntidad.BackColor = System.Drawing.Color.OliveDrab;
            this.cbEntidad.ForeColor = System.Drawing.SystemColors.Window;
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
            this.cbEntidad.Location = new System.Drawing.Point(139, 162);
            this.cbEntidad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbEntidad.Name = "cbEntidad";
            this.cbEntidad.Size = new System.Drawing.Size(159, 28);
            this.cbEntidad.TabIndex = 6;
            this.cbEntidad.SelectedIndexChanged += new System.EventHandler(this.cbEntidad_SelectedIndexChanged_1);
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.BackColor = System.Drawing.Color.OliveDrab;
            this.cbMunicipio.ForeColor = System.Drawing.SystemColors.Window;
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
            this.cbMunicipio.Location = new System.Drawing.Point(139, 231);
            this.cbMunicipio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(159, 28);
            this.cbMunicipio.TabIndex = 7;
            // 
            // labFechaInicio
            // 
            this.labFechaInicio.AutoSize = true;
            this.labFechaInicio.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labFechaInicio.Location = new System.Drawing.Point(348, 167);
            this.labFechaInicio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labFechaInicio.Name = "labFechaInicio";
            this.labFechaInicio.Size = new System.Drawing.Size(122, 20);
            this.labFechaInicio.TabIndex = 9;
            this.labFechaInicio.Text = "FECHA DE INICIO";
            // 
            // labInicioResultadoFecha
            // 
            this.labInicioResultadoFecha.AutoSize = true;
            this.labInicioResultadoFecha.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labInicioResultadoFecha.Location = new System.Drawing.Point(496, 167);
            this.labInicioResultadoFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labInicioResultadoFecha.Name = "labInicioResultadoFecha";
            this.labInicioResultadoFecha.Size = new System.Drawing.Size(0, 20);
            this.labInicioResultadoFecha.TabIndex = 11;
            // 
            // labFinalResultadoFecha
            // 
            this.labFinalResultadoFecha.AutoSize = true;
            this.labFinalResultadoFecha.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labFinalResultadoFecha.Location = new System.Drawing.Point(496, 238);
            this.labFinalResultadoFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labFinalResultadoFecha.Name = "labFinalResultadoFecha";
            this.labFinalResultadoFecha.Size = new System.Drawing.Size(0, 20);
            this.labFinalResultadoFecha.TabIndex = 10;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarMonthBackground = System.Drawing.Color.DarkKhaki;
            this.dtpFechaInicial.Location = new System.Drawing.Point(866, 151);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(261, 27);
            this.dtpFechaInicial.TabIndex = 12;
            // 
            // chboxFecha
            // 
            this.chboxFecha.AutoSize = true;
            this.chboxFecha.ForeColor = System.Drawing.Color.SaddleBrown;
            this.chboxFecha.Location = new System.Drawing.Point(910, 68);
            this.chboxFecha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chboxFecha.Name = "chboxFecha";
            this.chboxFecha.Size = new System.Drawing.Size(156, 24);
            this.chboxFecha.TabIndex = 13;
            this.chboxFecha.Text = "HABILITAR FECHA?";
            this.chboxFecha.UseVisualStyleBackColor = true;
            this.chboxFecha.CheckedChanged += new System.EventHandler(this.chboxFecha_CheckedChanged);
            // 
            // labResultadoAfiliado
            // 
            this.labResultadoAfiliado.AutoSize = true;
            this.labResultadoAfiliado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labResultadoAfiliado.Location = new System.Drawing.Point(797, 198);
            this.labResultadoAfiliado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labResultadoAfiliado.Name = "labResultadoAfiliado";
            this.labResultadoAfiliado.Size = new System.Drawing.Size(0, 20);
            this.labResultadoAfiliado.TabIndex = 15;
            // 
            // labNumeroAfiliados
            // 
            this.labNumeroAfiliados.AutoSize = true;
            this.labNumeroAfiliados.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labNumeroAfiliados.Location = new System.Drawing.Point(614, 198);
            this.labNumeroAfiliados.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labNumeroAfiliados.Name = "labNumeroAfiliados";
            this.labNumeroAfiliados.Size = new System.Drawing.Size(170, 20);
            this.labNumeroAfiliados.TabIndex = 14;
            this.labNumeroAfiliados.Text = "NUMERO DE AFILIADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(53, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "ARCHIVO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 16;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCargar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCargar.Location = new System.Drawing.Point(264, 84);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(135, 35);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnReiniciar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnReiniciar.Location = new System.Drawing.Point(427, 82);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(135, 35);
            this.btnReiniciar.TabIndex = 19;
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // tbRutaExcel
            // 
            this.tbRutaExcel.BackColor = System.Drawing.Color.OliveDrab;
            this.tbRutaExcel.ForeColor = System.Drawing.SystemColors.Window;
            this.tbRutaExcel.Location = new System.Drawing.Point(139, 31);
            this.tbRutaExcel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbRutaExcel.Name = "tbRutaExcel";
            this.tbRutaExcel.Size = new System.Drawing.Size(725, 27);
            this.tbRutaExcel.TabIndex = 20;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnFiltrar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnFiltrar.Location = new System.Drawing.Point(589, 84);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(135, 35);
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CalendarMonthBackground = System.Drawing.Color.DarkKhaki;
            this.dtpFechaFinal.Location = new System.Drawing.Point(866, 230);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(261, 27);
            this.dtpFechaFinal.TabIndex = 22;
            // 
            // labFechaIn
            // 
            this.labFechaIn.AutoSize = true;
            this.labFechaIn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labFechaIn.Location = new System.Drawing.Point(930, 115);
            this.labFechaIn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labFechaIn.Name = "labFechaIn";
            this.labFechaIn.Size = new System.Drawing.Size(122, 20);
            this.labFechaIn.TabIndex = 23;
            this.labFechaIn.Text = "FECHA DE INICIO";
            // 
            // labFechaFin
            // 
            this.labFechaFin.AutoSize = true;
            this.labFechaFin.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labFechaFin.Location = new System.Drawing.Point(942, 192);
            this.labFechaFin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labFechaFin.Name = "labFechaFin";
            this.labFechaFin.Size = new System.Drawing.Size(98, 20);
            this.labFechaFin.TabIndex = 24;
            this.labFechaFin.Text = "FECHA FINAL";
            // 
            // frmAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1152, 558);
            this.Controls.Add(this.labFechaFin);
            this.Controls.Add(this.labFechaIn);
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
            this.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmAfiliados";
            this.Text = "Afiliados del PRI";
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
        private System.Windows.Forms.Label labFechaIn;
        private System.Windows.Forms.Label labFechaFin;
    }
}

