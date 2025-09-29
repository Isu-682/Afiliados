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
            this.labFechaFinal = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tsslTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbEntidad = new System.Windows.Forms.ComboBox();
            this.cbMunicipio = new System.Windows.Forms.ComboBox();
            this.labFechaInicio = new System.Windows.Forms.Label();
            this.labInicioResultadoFecha = new System.Windows.Forms.Label();
            this.labFinalResultadoFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.chboxFecha = new System.Windows.Forms.CheckBox();
            this.labResultadoAfiliado = new System.Windows.Forms.Label();
            this.labNumeroAfiliados = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAfiliados)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 108);
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
            this.dgvTablaAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Colum4,
            this.Column4,
            this.Column5});
            this.dgvTablaAfiliados.Location = new System.Drawing.Point(12, 188);
            this.dgvTablaAfiliados.Name = "dgvTablaAfiliados";
            this.dgvTablaAfiliados.Size = new System.Drawing.Size(717, 150);
            this.dgvTablaAfiliados.TabIndex = 2;
            this.dgvTablaAfiliados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaAfiliados_CellContentClick);
            // 
            // labFechaFinal
            // 
            this.labFechaFinal.AutoSize = true;
            this.labFechaFinal.Location = new System.Drawing.Point(279, 155);
            this.labFechaFinal.Name = "labFechaFinal";
            this.labFechaFinal.Size = new System.Drawing.Size(85, 13);
            this.labFechaFinal.TabIndex = 3;
            this.labFechaFinal.Text = "ULTIMA FECHA";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTimer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(743, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tsslTimer
            // 
            this.tsslTimer.Name = "tsslTimer";
            this.tsslTimer.Size = new System.Drawing.Size(118, 17);
            this.tsslTimer.Text = "toolStripStatusLabel1";
            // 
            // cbEntidad
            // 
            this.cbEntidad.FormattingEnabled = true;
            this.cbEntidad.Items.AddRange(new object[] {
            "COAHUILA"});
            this.cbEntidad.Location = new System.Drawing.Point(104, 105);
            this.cbEntidad.Name = "cbEntidad";
            this.cbEntidad.Size = new System.Drawing.Size(121, 21);
            this.cbEntidad.TabIndex = 6;
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.Items.AddRange(new object[] {
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
            this.labFechaInicio.Location = new System.Drawing.Point(282, 108);
            this.labFechaInicio.Name = "labFechaInicio";
            this.labFechaInicio.Size = new System.Drawing.Size(95, 13);
            this.labFechaInicio.TabIndex = 9;
            this.labFechaInicio.Text = "FECHA DE INICIO";
            // 
            // labInicioResultadoFecha
            // 
            this.labInicioResultadoFecha.AutoSize = true;
            this.labInicioResultadoFecha.ForeColor = System.Drawing.Color.Gray;
            this.labInicioResultadoFecha.Location = new System.Drawing.Point(393, 108);
            this.labInicioResultadoFecha.Name = "labInicioResultadoFecha";
            this.labInicioResultadoFecha.Size = new System.Drawing.Size(95, 13);
            this.labInicioResultadoFecha.TabIndex = 11;
            this.labInicioResultadoFecha.Text = "FECHA DE INICIO";
            // 
            // labFinalResultadoFecha
            // 
            this.labFinalResultadoFecha.AutoSize = true;
            this.labFinalResultadoFecha.ForeColor = System.Drawing.Color.Gray;
            this.labFinalResultadoFecha.Location = new System.Drawing.Point(390, 155);
            this.labFinalResultadoFecha.Name = "labFinalResultadoFecha";
            this.labFinalResultadoFecha.Size = new System.Drawing.Size(85, 13);
            this.labFinalResultadoFecha.TabIndex = 10;
            this.labFinalResultadoFecha.Text = "ULTIMA FECHA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(256, 40);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(194, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // chboxFecha
            // 
            this.chboxFecha.AutoSize = true;
            this.chboxFecha.Location = new System.Drawing.Point(285, 12);
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
            this.labResultadoAfiliado.Location = new System.Drawing.Point(644, 108);
            this.labResultadoAfiliado.Name = "labResultadoAfiliado";
            this.labResultadoAfiliado.Size = new System.Drawing.Size(85, 13);
            this.labResultadoAfiliado.TabIndex = 15;
            this.labResultadoAfiliado.Text = "ULTIMA FECHA";
            // 
            // labNumeroAfiliados
            // 
            this.labNumeroAfiliados.AutoSize = true;
            this.labNumeroAfiliados.Location = new System.Drawing.Point(507, 108);
            this.labNumeroAfiliados.Name = "labNumeroAfiliados";
            this.labNumeroAfiliados.Size = new System.Drawing.Size(131, 13);
            this.labNumeroAfiliados.TabIndex = 14;
            this.labNumeroAfiliados.Text = "NUMERO DE AFILIADOS";
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "ENTIDAD";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "MUNICIPIO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Colum4
            // 
            this.Colum4.Frozen = true;
            this.Colum4.HeaderText = "NOMBRE";
            this.Colum4.Name = "Colum4";
            this.Colum4.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "FECHA AFILIACION";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "ESTATUS";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 363);
            this.Controls.Add(this.labResultadoAfiliado);
            this.Controls.Add(this.labNumeroAfiliados);
            this.Controls.Add(this.chboxFecha);
            this.Controls.Add(this.dtpFecha);
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
        private System.Windows.Forms.ToolStripStatusLabel tsslTimer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbEntidad;
        private System.Windows.Forms.ComboBox cbMunicipio;
        private System.Windows.Forms.Label labFechaInicio;
        private System.Windows.Forms.Label labInicioResultadoFecha;
        private System.Windows.Forms.Label labFinalResultadoFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox chboxFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label labResultadoAfiliado;
        private System.Windows.Forms.Label labNumeroAfiliados;
    }
}

