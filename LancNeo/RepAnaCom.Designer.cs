namespace LancNeo
{
    partial class RepAnaCom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepAnaCom));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAAnalisis = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATitulo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.crvRepAnalisis = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBuscaObra1 = new LancNeo.dsBuscaObra();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.txtResIndice = new System.Windows.Forms.TextBox();
            this.lblIndice = new System.Windows.Forms.Label();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIncrem = new System.Windows.Forms.TextBox();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsAnaCompac1 = new LancNeo.dsAnaCompac();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRequerido = new System.Windows.Forms.ComboBox();
            this.dsAnaReque1 = new LancNeo.dsAnaReque();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCapa = new System.Windows.Forms.ComboBox();
            this.dsAnaCapa1 = new LancNeo.dsAnaCapa();
            this.label5 = new System.Windows.Forms.Label();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDACompac = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDACapa = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARequer = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsAnaCompacta1 = new LancNeo.dsAnaCompacta();
            this.cryRepAnaCompacta1 = new LancNeo.CryRepAnaCompacta();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnaCompac1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnaReque1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnaCapa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnaCompacta1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDABusObra
            // 
            this.sqlDABusObra.SelectCommand = this.sqlCommand1;
            this.sqlDABusObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // sqlDAAnalisis
            // 
            this.sqlDAAnalisis.SelectCommand = this.sqlSelectCommand4;
            this.sqlDAAnalisis.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Analisis", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("Rev", "Rev"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("  3", "  3"),
                        new System.Data.Common.DataColumnMapping(" 3i", " 3i"),
                        new System.Data.Common.DataColumnMapping("  7", "  7"),
                        new System.Data.Common.DataColumnMapping(" 7i", " 7i"),
                        new System.Data.Common.DataColumnMapping("C", "C"),
                        new System.Data.Common.DataColumnMapping("ee1", "ee1"),
                        new System.Data.Common.DataColumnMapping("ee2", "ee2"),
                        new System.Data.Common.DataColumnMapping("Int", "Int"),
                        new System.Data.Common.DataColumnMapping("Prm", "Prm"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Con", "Con"),
                        new System.Data.Common.DataColumnMapping("200", "200"),
                        new System.Data.Common.DataColumnMapping(" 63", " 63"),
                        new System.Data.Common.DataColumnMapping("N", "N"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("unico", "unico"),
                        new System.Data.Common.DataColumnMapping("hoja", "hoja"),
                        new System.Data.Common.DataColumnMapping("a1", "a1"),
                        new System.Data.Common.DataColumnMapping("a2", "a2"),
                        new System.Data.Common.DataColumnMapping("a3", "a3")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "[AnaCompacta]";
            this.sqlSelectCommand4.CommandTimeout = 60;
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@Requerido", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Capa", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@Increm", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@datos", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDATitulo
            // 
            this.sqlDATitulo.SelectCommand = this.sqlSelectCommand7;
            this.sqlDATitulo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Titulo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Ejex", "Ejex"),
                        new System.Data.Common.DataColumnMapping("c1", "c1"),
                        new System.Data.Common.DataColumnMapping("c2", "c2"),
                        new System.Data.Common.DataColumnMapping("c3", "c3"),
                        new System.Data.Common.DataColumnMapping("c4", "c4"),
                        new System.Data.Common.DataColumnMapping("c5", "c5"),
                        new System.Data.Common.DataColumnMapping("c6", "c6"),
                        new System.Data.Common.DataColumnMapping("c7", "c7"),
                        new System.Data.Common.DataColumnMapping("c8", "c8"),
                        new System.Data.Common.DataColumnMapping("c9", "c9"),
                        new System.Data.Common.DataColumnMapping("c10", "c10"),
                        new System.Data.Common.DataColumnMapping("c11", "c11"),
                        new System.Data.Common.DataColumnMapping("c12", "c12")})});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "[Titulo]";
            this.sqlSelectCommand7.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand7.Connection = this.sqlConn;
            this.sqlSelectCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKg", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Hoja", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@incre", System.Data.SqlDbType.Float, 8)});
            // 
            // crvRepAnalisis
            // 
            this.crvRepAnalisis.ActiveViewIndex = -1;
            this.crvRepAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepAnalisis.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepAnalisis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepAnalisis.EnableRefresh = false;
            this.crvRepAnalisis.Location = new System.Drawing.Point(0, 78);
            this.crvRepAnalisis.Name = "crvRepAnalisis";
            this.crvRepAnalisis.ShowCloseButton = false;
            this.crvRepAnalisis.ShowGroupTreeButton = false;
            this.crvRepAnalisis.ShowLogo = false;
            this.crvRepAnalisis.ShowRefreshButton = false;
            this.crvRepAnalisis.Size = new System.Drawing.Size(1028, 570);
            this.crvRepAnalisis.TabIndex = 12;
            this.crvRepAnalisis.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepAnalisis.ToolPanelWidth = 167;
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(324, 16);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(409, -1);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(100, 20);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Análisis estadístico compactaciones";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBuscaObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(236, 26);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // dsBuscaObra1
            // 
            this.dsBuscaObra1.DataSetName = "dsBuscaObra";
            this.dsBuscaObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBuscaObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(543, -1);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Capas:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(543, 26);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // txtResIndice
            // 
            this.txtResIndice.Location = new System.Drawing.Point(721, 0);
            this.txtResIndice.MaxLength = 3;
            this.txtResIndice.Name = "txtResIndice";
            this.txtResIndice.Size = new System.Drawing.Size(34, 20);
            this.txtResIndice.TabIndex = 33;
            this.txtResIndice.Text = "5";
            this.txtResIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResIndice.Visible = false;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(656, 0);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(39, 13);
            this.lblIndice.TabIndex = 34;
            this.lblIndice.Text = "Indice:";
            this.lblIndice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIndice.Visible = false;
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(155, 48);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 35;
            this.cbkPrefijo.Text = "No prefijo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(631, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Incremento eje:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIncrem
            // 
            this.txtIncrem.Location = new System.Drawing.Point(721, 29);
            this.txtIncrem.MaxLength = 3;
            this.txtIncrem.Name = "txtIncrem";
            this.txtIncrem.Size = new System.Drawing.Size(34, 20);
            this.txtIncrem.TabIndex = 42;
            this.txtIncrem.Text = "2";
            this.txtIncrem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsAnaCompac1.CompactaMdor;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(323, -2);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(58, 54);
            this.buscaBtn1.TabIndex = 36;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsAnaCompac1
            // 
            this.dsAnaCompac1.DataSetName = "dsAnaCompac";
            this.dsAnaCompac1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(764, 2);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 37;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.cmbRequerido);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbCapa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtIncrem);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cbkPrefijo);
            this.panel1.Controls.Add(this.lblIndice);
            this.panel1.Controls.Add(this.txtResIndice);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 78);
            this.panel1.TabIndex = 11;
            // 
            // cmbRequerido
            // 
            this.cmbRequerido.DataSource = this.dsAnaReque1;
            this.cmbRequerido.DisplayMember = "CompactaMdor.Requerido";
            this.cmbRequerido.FormattingEnabled = true;
            this.cmbRequerido.Location = new System.Drawing.Point(429, 49);
            this.cmbRequerido.Name = "cmbRequerido";
            this.cmbRequerido.Size = new System.Drawing.Size(80, 21);
            this.cmbRequerido.TabIndex = 46;
            this.cmbRequerido.ValueMember = "CompactaMdor.Requerido";
            this.cmbRequerido.SelectedIndexChanged += new System.EventHandler(this.cmbRequerido_SelectedIndexChanged);
            // 
            // dsAnaReque1
            // 
            this.dsAnaReque1.DataSetName = "dsAnaReque";
            this.dsAnaReque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Requerido %:";
            // 
            // cmbCapa
            // 
            this.cmbCapa.DataSource = this.dsAnaCapa1;
            this.cmbCapa.DisplayMember = "CompactaMdor.CAPA";
            this.cmbCapa.FormattingEnabled = true;
            this.cmbCapa.Location = new System.Drawing.Point(429, 26);
            this.cmbCapa.Name = "cmbCapa";
            this.cmbCapa.Size = new System.Drawing.Size(80, 21);
            this.cmbCapa.TabIndex = 44;
            this.cmbCapa.ValueMember = "CompactaMdor.CAPA";
            // 
            // dsAnaCapa1
            // 
            this.dsAnaCapa1.DataSetName = "dsAnaCapa";
            this.dsAnaCapa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Final:";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlDACompac
            // 
            this.sqlDACompac.SelectCommand = this.sqlSelectCommand1;
            this.sqlDACompac.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CompactaMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("CAPA", "CAPA")})});
            // 
            // sqlDACapa
            // 
            this.sqlDACapa.SelectCommand = this.sqlCommand2;
            this.sqlDACapa.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CompactaMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("CAPA", "CAPA")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlDARequer
            // 
            this.sqlDARequer.SelectCommand = this.sqlCommand3;
            this.sqlDARequer.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CompactaMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("CAPA", "CAPA")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // dsAnaCompacta1
            // 
            this.dsAnaCompacta1.DataSetName = "dsAnaCompacta";
            this.dsAnaCompacta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RepAnaCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 648);
            this.Controls.Add(this.crvRepAnalisis);
            this.Controls.Add(this.panel1);
            this.Name = "RepAnaCom";
            this.Text = "RepAnaCom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepAnaCom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnaCompac1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnaReque1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnaCapa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnaCompacta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAAnalisis;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlDataAdapter sqlDATitulo;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepAnalisis;
        private System.Windows.Forms.TextBox txtIdobra;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.TextBox txtResIndice;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.CheckBox cbkPrefijo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIncrem;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCapa;
        private System.Windows.Forms.Label label5;
        private dsBuscaObra dsBuscaObra1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDACompac;
        private dsAnaCompac dsAnaCompac1;
        private System.Data.SqlClient.SqlDataAdapter sqlDACapa;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private dsAnaCapa dsAnaCapa1;
        private System.Windows.Forms.ComboBox cmbRequerido;
        private System.Windows.Forms.Label label6;
        private System.Data.SqlClient.SqlDataAdapter sqlDARequer;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private dsAnaReque dsAnaReque1;
        private dsAnaCompacta dsAnaCompacta1;
        private CryRepAnaCompacta cryRepAnaCompacta1;
    }
}