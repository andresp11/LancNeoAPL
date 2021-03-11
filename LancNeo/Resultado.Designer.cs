namespace LancNeo
{
    partial class Resultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDABajosTemp = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBtn3 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.Pdf = new Soluciones2000.Tools.WinLib.tbBtn();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.tbBtn2 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.chkObliga = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbUno = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdbTres = new System.Windows.Forms.RadioButton();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryRepCartaEdadTemprana = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.dsRepCartaEdadTemprana1 = new LancNeo.dsRepCartaEdadTemprana();
            this.sqlDACartaEdadTemp = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDACorreos = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsCorreos1 = new LancNeo.dsCorreos();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.dsBajosTemp1 = new LancNeo.dsBajosTemp();
            this.resultadoCR1 = new LancNeo.ResultadoCR();
            this.cryRepCartaEdadTempranM1 = new LancNeo.CryRepCartaEdadTempranM();
            this.sqlComActualiza = new System.Data.SqlClient.SqlCommand();
            this.resultadoFCR1 = new LancNeo.ResultadoFCR();
            this.sqlDABajosRes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.Carta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Mortero = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MPa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConcreteraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistenciaKGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fensayeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incrementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLaboratorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepCartaEdadTemprana1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCorreos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBajosTemp1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDABajosTemp
            // 
            this.sqlDABajosTemp.SelectCommand = this.sqlSelectCommand1;
            this.sqlDABajosTemp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Agregado", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"),
                        new System.Data.Common.DataColumnMapping("IdEspecimen", "IdEspecimen"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Resistencia", "Resistencia"),
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("IdDiam", "IdDiam"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye"),
                        new System.Data.Common.DataColumnMapping("DesTipo", "DesTipo"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro"),
                        new System.Data.Common.DataColumnMapping("IdConc", "IdConc"),
                        new System.Data.Common.DataColumnMapping("Incremento", "Incremento"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Orden", "Orden"),
                        new System.Data.Common.DataColumnMapping("Incremento7", "Incremento7")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "ResultadoRep";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Dia", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Finicial", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@Ffinal", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@Tole", System.Data.SqlDbType.Float, 8)});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.tbBtn3);
            this.panel1.Controls.Add(this.Pdf);
            this.panel1.Controls.Add(this.tbBtn1);
            this.panel1.Controls.Add(this.tbBtn2);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTolerancia);
            this.panel1.Controls.Add(this.chkObliga);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 88);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbBtn3
            // 
            this.tbBtn3.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn3.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn3.Icon")));
            this.tbBtn3.Location = new System.Drawing.Point(1022, 13);
            this.tbBtn3.Name = "tbBtn3";
            this.tbBtn3.Size = new System.Drawing.Size(64, 64);
            this.tbBtn3.TabIndex = 64;
            this.tbBtn3.Click += new System.EventHandler(this.tbBtn3_Click);
            // 
            // Pdf
            // 
            this.Pdf.BackColor = System.Drawing.Color.Transparent;
            this.Pdf.Icon = ((System.Drawing.Icon)(resources.GetObject("Pdf.Icon")));
            this.Pdf.Location = new System.Drawing.Point(799, 11);
            this.Pdf.Name = "Pdf";
            this.Pdf.Size = new System.Drawing.Size(64, 65);
            this.Pdf.TabIndex = 59;
            this.Pdf.Visible = false;
            this.Pdf.Click += new System.EventHandler(this.Pdf_Click);
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(727, 12);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 58;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // tbBtn2
            // 
            this.tbBtn2.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn2.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn2.Icon")));
            this.tbBtn2.Location = new System.Drawing.Point(887, 12);
            this.tbBtn2.Name = "tbBtn2";
            this.tbBtn2.Size = new System.Drawing.Size(64, 65);
            this.tbBtn2.TabIndex = 63;
            this.tbBtn2.Visible = false;
            this.tbBtn2.Click += new System.EventHandler(this.tbBtn2_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(654, 12);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 13;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Tolerancia modificada:";
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(262, 60);
            this.txtTolerancia.MaxLength = 2;
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(22, 20);
            this.txtTolerancia.TabIndex = 61;
            this.txtTolerancia.Text = "20";
            // 
            // chkObliga
            // 
            this.chkObliga.AutoSize = true;
            this.chkObliga.ForeColor = System.Drawing.Color.White;
            this.chkObliga.Location = new System.Drawing.Point(52, 58);
            this.chkObliga.Name = "chkObliga";
            this.chkObliga.Size = new System.Drawing.Size(89, 17);
            this.chkObliga.TabIndex = 60;
            this.chkObliga.Text = "Obliga correo";
            this.chkObliga.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUno);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rdbTres);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(305, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 56);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edad temprana:";
            // 
            // rdbUno
            // 
            this.rdbUno.AutoSize = true;
            this.rdbUno.ForeColor = System.Drawing.Color.White;
            this.rdbUno.Location = new System.Drawing.Point(7, 20);
            this.rdbUno.Name = "rdbUno";
            this.rdbUno.Size = new System.Drawing.Size(50, 17);
            this.rdbUno.TabIndex = 2;
            this.rdbUno.TabStop = true;
            this.rdbUno.Text = "1 día";
            this.rdbUno.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(153, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "7 días";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdbTres
            // 
            this.rdbTres.AutoSize = true;
            this.rdbTres.Checked = true;
            this.rdbTres.ForeColor = System.Drawing.Color.White;
            this.rdbTres.Location = new System.Drawing.Point(93, 20);
            this.rdbTres.Name = "rdbTres";
            this.rdbTres.Size = new System.Drawing.Size(55, 17);
            this.rdbTres.TabIndex = 0;
            this.rdbTres.TabStop = true;
            this.rdbTres.Text = "3 días";
            this.rdbTres.UseVisualStyleBackColor = true;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(561, 49);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(80, 20);
            this.dtpFin.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(529, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(561, 25);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(80, 20);
            this.dtpIni.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(529, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Inicial:";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(543, 8);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(98, 13);
            this.Fecha.TabIndex = 17;
            this.Fecha.Text = "Fechas de periodo:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reporte diario de resultados bajos edades tempranas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // crvReporte
            // 
            this.crvReporte.ActiveViewIndex = -1;
            this.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporte.EnableRefresh = false;
            this.crvReporte.Location = new System.Drawing.Point(0, 89);
            this.crvReporte.Name = "crvReporte";
            this.crvReporte.ShowCloseButton = false;
            this.crvReporte.ShowGroupTreeButton = false;
            this.crvReporte.ShowLogo = false;
            this.crvReporte.Size = new System.Drawing.Size(1099, 650);
            this.crvReporte.TabIndex = 18;
            this.crvReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsRepCartaEdadTemprana1
            // 
            this.dsRepCartaEdadTemprana1.DataSetName = "dsRepCartaEdadTemprana";
            this.dsRepCartaEdadTemprana1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsRepCartaEdadTemprana1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDACartaEdadTemp
            // 
            this.sqlDACartaEdadTemp.SelectCommand = this.sqlSelectCommand4;
            this.sqlDACartaEdadTemp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RepCartaEdadTemprana", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("R3", "R3"),
                        new System.Data.Common.DataColumnMapping("R7", "R7"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "[RepCartaEdadTemprana]";
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Renvenimiento", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IncD3EE", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@IncD7EE", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 1),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // dsUnidad1
            // 
            this.dsUnidad1.DataSetName = "dsUnidad";
            this.dsUnidad1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsUnidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAUnidad
            // 
            this.sqlDAUnidad.SelectCommand = this.sqlCommand2;
            this.sqlDAUnidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Unidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Factor", "Factor"),
                        new System.Data.Common.DataColumnMapping("Undescr", "Undescr"),
                        new System.Data.Common.DataColumnMapping("MaxagrUn", "MaxagrUn"),
                        new System.Data.Common.DataColumnMapping("RevenUn", "RevenUn")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT IdUnidad, Factor, Undescr, MaxagrUn, RevenUn FROM Unidad";
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // sqlDACorreos
            // 
            this.sqlDACorreos.SelectCommand = this.sqlCommand3;
            this.sqlDACorreos.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Correo1", "Correo1"),
                        new System.Data.Common.DataColumnMapping("Correo2", "Correo2"),
                        new System.Data.Common.DataColumnMapping("Correo3", "Correo3"),
                        new System.Data.Common.DataColumnMapping("Correo4", "Correo4"),
                        new System.Data.Common.DataColumnMapping("Correo5", "Correo5")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT     Idobra, Correo1, Correo2, Correo3, Correo4, Correo5\r\nFROM         Obra" +
    "\r\nWHERE     (Idobra = @IdObra)\r\nORDER BY Idobra";
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Idobra")});
            // 
            // dsCorreos1
            // 
            this.dsCorreos1.DataSetName = "dsCorreos";
            this.dsCorreos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AutoGenerateColumns = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carta,
            this.Mortero,
            this.MPa,
            this.idObraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.muestraDataGridViewTextBoxColumn,
            this.idConcreteraDataGridViewTextBoxColumn,
            this.resistenciaKGDataGridViewTextBoxColumn,
            this.desTipoDataGridViewTextBoxColumn,
            this.agregadoDataGridViewTextBoxColumn,
            this.revenimentoDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.elementoDataGridViewTextBoxColumn,
            this.ejesDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn,
            this.edifDataGridViewTextBoxColumn,
            this.fensayeDataGridViewTextBoxColumn,
            this.resistenciaDataGridViewTextBoxColumn,
            this.Diario,
            this.incrementoDataGridViewTextBoxColumn,
            this.idConcDataGridViewTextBoxColumn,
            this.idLaboratorioDataGridViewTextBoxColumn,
            this.Suma});
            this.dgvResultado.DataMember = "Agregado";
            this.dgvResultado.DataSource = this.dsBajosTemp1;
            this.dgvResultado.Location = new System.Drawing.Point(0, 89);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(1099, 650);
            this.dgvResultado.TabIndex = 19;
            // 
            // dsBajosTemp1
            // 
            this.dsBajosTemp1.DataSetName = "dsBajosTemp";
            this.dsBajosTemp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlComActualiza
            // 
            this.sqlComActualiza.CommandText = "UPDATE    BajosTemp\r\nSET              Carta = @Carta\r\nWHERE     (IdObra = @IdObra" +
    ") AND (Fecha = @Fecha) AND (Consecutivo = @Consecutivo) AND (IdEspecimen = @IdEs" +
    "pecimen) AND (Fensaye = @Fensaye)";
            this.sqlComActualiza.Connection = this.sqlConn;
            this.sqlComActualiza.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Carta", System.Data.SqlDbType.SmallInt, 2, "Carta"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Consecutivo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IdEspecimen", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEspecimen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Fensaye", System.Data.SqlDbType.SmallDateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDABajosRes
            // 
            this.sqlDABajosRes.SelectCommand = this.sqlCommand1;
            this.sqlDABajosRes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Agregado", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"),
                        new System.Data.Common.DataColumnMapping("IdEspecimen", "IdEspecimen"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Resistencia", "Resistencia"),
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("IdDiam", "IdDiam"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye"),
                        new System.Data.Common.DataColumnMapping("DesTipo", "DesTipo"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro"),
                        new System.Data.Common.DataColumnMapping("IdConc", "IdConc"),
                        new System.Data.Common.DataColumnMapping("Incremento", "Incremento"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Orden", "Orden"),
                        new System.Data.Common.DataColumnMapping("Incremento7", "Incremento7")})});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "ResultadoFRep";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConn;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Finicial", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@Ffinal", System.Data.SqlDbType.DateTime, 8)});
            // 
            // Carta
            // 
            this.Carta.HeaderText = "Carta";
            this.Carta.Name = "Carta";
            this.Carta.Width = 52;
            // 
            // Mortero
            // 
            this.Mortero.HeaderText = "Mortero";
            this.Mortero.Name = "Mortero";
            this.Mortero.Width = 60;
            // 
            // MPa
            // 
            this.MPa.HeaderText = "Mpa";
            this.MPa.Name = "MPa";
            this.MPa.Width = 40;
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            this.idObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObraDataGridViewTextBoxColumn.Width = 53;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MaxInputLength = 8;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 80;
            // 
            // muestraDataGridViewTextBoxColumn
            // 
            this.muestraDataGridViewTextBoxColumn.DataPropertyName = "Muestra";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.muestraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.muestraDataGridViewTextBoxColumn.HeaderText = "Muestra";
            this.muestraDataGridViewTextBoxColumn.Name = "muestraDataGridViewTextBoxColumn";
            this.muestraDataGridViewTextBoxColumn.ReadOnly = true;
            this.muestraDataGridViewTextBoxColumn.Width = 53;
            // 
            // idConcreteraDataGridViewTextBoxColumn
            // 
            this.idConcreteraDataGridViewTextBoxColumn.DataPropertyName = "IdConcretera";
            this.idConcreteraDataGridViewTextBoxColumn.HeaderText = "Premezcladora";
            this.idConcreteraDataGridViewTextBoxColumn.Name = "idConcreteraDataGridViewTextBoxColumn";
            this.idConcreteraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idConcreteraDataGridViewTextBoxColumn.Width = 80;
            // 
            // resistenciaKGDataGridViewTextBoxColumn
            // 
            this.resistenciaKGDataGridViewTextBoxColumn.DataPropertyName = "ResistenciaKG";
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = null;
            this.resistenciaKGDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.resistenciaKGDataGridViewTextBoxColumn.HeaderText = "Res. Sol";
            this.resistenciaKGDataGridViewTextBoxColumn.Name = "resistenciaKGDataGridViewTextBoxColumn";
            this.resistenciaKGDataGridViewTextBoxColumn.ReadOnly = true;
            this.resistenciaKGDataGridViewTextBoxColumn.Width = 35;
            // 
            // desTipoDataGridViewTextBoxColumn
            // 
            this.desTipoDataGridViewTextBoxColumn.DataPropertyName = "DesTipo";
            this.desTipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.desTipoDataGridViewTextBoxColumn.Name = "desTipoDataGridViewTextBoxColumn";
            this.desTipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.desTipoDataGridViewTextBoxColumn.Width = 55;
            // 
            // agregadoDataGridViewTextBoxColumn
            // 
            this.agregadoDataGridViewTextBoxColumn.DataPropertyName = "Agregado";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.agregadoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.agregadoDataGridViewTextBoxColumn.HeaderText = "Tma";
            this.agregadoDataGridViewTextBoxColumn.Name = "agregadoDataGridViewTextBoxColumn";
            this.agregadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.agregadoDataGridViewTextBoxColumn.Width = 40;
            // 
            // revenimentoDataGridViewTextBoxColumn
            // 
            this.revenimentoDataGridViewTextBoxColumn.DataPropertyName = "Revenimento";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.revenimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.revenimentoDataGridViewTextBoxColumn.HeaderText = "Rev";
            this.revenimentoDataGridViewTextBoxColumn.Name = "revenimentoDataGridViewTextBoxColumn";
            this.revenimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.revenimentoDataGridViewTextBoxColumn.Width = 40;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "T.A.";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Width = 53;
            // 
            // elementoDataGridViewTextBoxColumn
            // 
            this.elementoDataGridViewTextBoxColumn.DataPropertyName = "Elemento";
            this.elementoDataGridViewTextBoxColumn.HeaderText = "Elemento";
            this.elementoDataGridViewTextBoxColumn.Name = "elementoDataGridViewTextBoxColumn";
            this.elementoDataGridViewTextBoxColumn.ReadOnly = true;
            this.elementoDataGridViewTextBoxColumn.Width = 150;
            // 
            // ejesDataGridViewTextBoxColumn
            // 
            this.ejesDataGridViewTextBoxColumn.DataPropertyName = "Ejes";
            this.ejesDataGridViewTextBoxColumn.HeaderText = "Ejes";
            this.ejesDataGridViewTextBoxColumn.Name = "ejesDataGridViewTextBoxColumn";
            this.ejesDataGridViewTextBoxColumn.ReadOnly = true;
            this.ejesDataGridViewTextBoxColumn.Width = 150;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.ReadOnly = true;
            this.nivelDataGridViewTextBoxColumn.Width = 50;
            // 
            // edifDataGridViewTextBoxColumn
            // 
            this.edifDataGridViewTextBoxColumn.DataPropertyName = "Edif";
            this.edifDataGridViewTextBoxColumn.HeaderText = "Edif";
            this.edifDataGridViewTextBoxColumn.Name = "edifDataGridViewTextBoxColumn";
            this.edifDataGridViewTextBoxColumn.ReadOnly = true;
            this.edifDataGridViewTextBoxColumn.Width = 50;
            // 
            // fensayeDataGridViewTextBoxColumn
            // 
            this.fensayeDataGridViewTextBoxColumn.DataPropertyName = "Fensaye";
            this.fensayeDataGridViewTextBoxColumn.HeaderText = "Fensaye";
            this.fensayeDataGridViewTextBoxColumn.Name = "fensayeDataGridViewTextBoxColumn";
            this.fensayeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resistenciaDataGridViewTextBoxColumn
            // 
            this.resistenciaDataGridViewTextBoxColumn.DataPropertyName = "Resistencia";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = null;
            this.resistenciaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.resistenciaDataGridViewTextBoxColumn.HeaderText = "Res. obt.";
            this.resistenciaDataGridViewTextBoxColumn.Name = "resistenciaDataGridViewTextBoxColumn";
            this.resistenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.resistenciaDataGridViewTextBoxColumn.Width = 40;
            // 
            // Diario
            // 
            this.Diario.DataPropertyName = "Diario";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N1";
            dataGridViewCellStyle7.NullValue = null;
            this.Diario.DefaultCellStyle = dataGridViewCellStyle7;
            this.Diario.HeaderText = "Diario";
            this.Diario.Name = "Diario";
            this.Diario.Width = 40;
            // 
            // incrementoDataGridViewTextBoxColumn
            // 
            this.incrementoDataGridViewTextBoxColumn.DataPropertyName = "Incremento";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N1";
            dataGridViewCellStyle8.NullValue = null;
            this.incrementoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.incrementoDataGridViewTextBoxColumn.HeaderText = "Inc";
            this.incrementoDataGridViewTextBoxColumn.Name = "incrementoDataGridViewTextBoxColumn";
            this.incrementoDataGridViewTextBoxColumn.ReadOnly = true;
            this.incrementoDataGridViewTextBoxColumn.Width = 40;
            // 
            // idConcDataGridViewTextBoxColumn
            // 
            this.idConcDataGridViewTextBoxColumn.DataPropertyName = "IdConc";
            this.idConcDataGridViewTextBoxColumn.HeaderText = "Experiencia";
            this.idConcDataGridViewTextBoxColumn.Name = "idConcDataGridViewTextBoxColumn";
            this.idConcDataGridViewTextBoxColumn.ReadOnly = true;
            this.idConcDataGridViewTextBoxColumn.Width = 80;
            // 
            // idLaboratorioDataGridViewTextBoxColumn
            // 
            this.idLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "IdLaboratorio";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idLaboratorioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.idLaboratorioDataGridViewTextBoxColumn.HeaderText = "Lab";
            this.idLaboratorioDataGridViewTextBoxColumn.Name = "idLaboratorioDataGridViewTextBoxColumn";
            this.idLaboratorioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLaboratorioDataGridViewTextBoxColumn.Width = 52;
            // 
            // Suma
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N1";
            dataGridViewCellStyle10.NullValue = null;
            this.Suma.DefaultCellStyle = dataGridViewCellStyle10;
            this.Suma.HeaderText = "Suma";
            this.Suma.Name = "Suma";
            this.Suma.ReadOnly = true;
            this.Suma.Width = 40;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.crvReporte);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepCartaEdadTemprana1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCorreos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBajosTemp1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDABajosTemp;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private dsBajosTemp dsBajosTemp1;
        private System.Windows.Forms.Panel panel1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdbTres;
        private ResultadoCR resultadoCR1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporte;
        private System.Windows.Forms.DataGridView dgvResultado;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
        protected Soluciones2000.Tools.WinLib.tbBtn Pdf;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument cryRepCartaEdadTemprana;
        private dsRepCartaEdadTemprana dsRepCartaEdadTemprana1;
        private System.Data.SqlClient.SqlDataAdapter sqlDACartaEdadTemp;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private dsUnidad dsUnidad1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        public System.Data.SqlClient.SqlDataAdapter sqlDACorreos;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private dsCorreos dsCorreos1;
        private CryRepCartaEdadTempranM cryRepCartaEdadTempranM1;
        private System.Windows.Forms.CheckBox chkObliga;
        private System.Windows.Forms.RadioButton rdbUno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTolerancia;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn2;
        private System.Data.SqlClient.SqlCommand sqlComActualiza;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn3;
        private ResultadoFCR resultadoFCR1;
        private System.Data.SqlClient.SqlDataAdapter sqlDABajosRes;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Carta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Mortero;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MPa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConcreteraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resistenciaKGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agregadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fensayeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resistenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diario;
        private System.Windows.Forms.DataGridViewTextBoxColumn incrementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLaboratorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma;
    }
}