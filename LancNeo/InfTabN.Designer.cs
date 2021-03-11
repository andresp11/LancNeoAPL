namespace LancNeo
{
    partial class InfTabN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfTabN));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsInfTabiqueMdor1 = new LancNeo.dsInfTabiqueMdor();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAFirmas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.sqlDAInfTabiqueResC = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAInfTabiqueResA = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAInfTabiqueMdor = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsUnidad2 = new LancNeo.dsUnidad();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsTabMdor1 = new LancNeo.dsTabMdor();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbDuplicado = new System.Windows.Forms.CheckBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.chbLab1 = new System.Windows.Forms.CheckBox();
            this.crvInfTabique = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsInfTabN1 = new LancNeo.dsInfTabN();
            this.sqlDATabiqueMdor = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand = new System.Data.SqlClient.SqlCommand();
            this.dsFirmas1 = new LancNeo.dsFirmas();
            this.sqlDANorma = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.cryRepTabN1 = new LancNeo.CryRepTabN();
            this.chbRespaldo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfTabiqueMdor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTabMdor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfTabN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsInfTabiqueMdor1
            // 
            this.dsInfTabiqueMdor1.DataSetName = "dsInfTabiqueMdor";
            this.dsInfTabiqueMdor1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsInfTabiqueMdor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlDAFirmas
            // 
            this.sqlDAFirmas.SelectCommand = this.sqlSelectCommand7;
            this.sqlDAFirmas.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Firmas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdFirma", "IdFirma"),
                        new System.Data.Common.DataColumnMapping("Nombre", "Nombre"),
                        new System.Data.Common.DataColumnMapping("Cargo", "Cargo"),
                        new System.Data.Common.DataColumnMapping("Imprime", "Imprime")})});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "SELECT     IdFirma, Nombre, Cargo, Imprime, Prefabricados\r\nFROM         Firmas\r\nW" +
    "HERE     (Imprime = 1) AND (Prefabricados < 6)\r\nORDER BY Prefabricados";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // dsUnidad1
            // 
            this.dsUnidad1.DataSetName = "dsUnidad";
            this.dsUnidad1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsUnidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAInfTabiqueResC
            // 
            this.sqlDAInfTabiqueResC.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAInfTabiqueResC.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TabiqueRep1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("TMuestra", "TMuestra"),
                        new System.Data.Common.DataColumnMapping("Largo", "Largo"),
                        new System.Data.Common.DataColumnMapping("Ancho", "Ancho"),
                        new System.Data.Common.DataColumnMapping("Peralte", "Peralte"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("RcAInd", "RcAInd"),
                        new System.Data.Common.DataColumnMapping("RcAPro", "RcAPro"),
                        new System.Data.Common.DataColumnMapping("EspInd", "EspInd"),
                        new System.Data.Common.DataColumnMapping("EspPro", "EspPro")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "[TabRepN1]";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Folio1", System.Data.SqlDbType.Char, 10),
            new System.Data.SqlClient.SqlParameter("@Prueba", System.Data.SqlDbType.Bit, 1),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDAInfTabiqueResA
            // 
            this.sqlDAInfTabiqueResA.SelectCommand = this.sqlCommand2;
            this.sqlDAInfTabiqueResA.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TabiqueRep1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("TMuestra", "TMuestra"),
                        new System.Data.Common.DataColumnMapping("Largo", "Largo"),
                        new System.Data.Common.DataColumnMapping("Ancho", "Ancho"),
                        new System.Data.Common.DataColumnMapping("Peralte", "Peralte"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("RcAInd", "RcAInd"),
                        new System.Data.Common.DataColumnMapping("RcAPro", "RcAPro"),
                        new System.Data.Common.DataColumnMapping("EspInd", "EspInd"),
                        new System.Data.Common.DataColumnMapping("EspPro", "EspPro")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "[TabRepN1]";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Folio1", System.Data.SqlDbType.Char, 10),
            new System.Data.SqlClient.SqlParameter("@Prueba", System.Data.SqlDbType.Bit, 1),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDAInfTabiqueMdor
            // 
            this.sqlDAInfTabiqueMdor.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAInfTabiqueMdor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TabiqueRep", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FMuestreo", "FMuestreo"),
                        new System.Data.Common.DataColumnMapping("FEnsaye", "FEnsaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("MReducida", "MReducida"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Cumple", "Cumple"),
                        new System.Data.Common.DataColumnMapping("Norma", "Norma"),
                        new System.Data.Common.DataColumnMapping("Como", "Como"),
                        new System.Data.Common.DataColumnMapping("ObsComo", "ObsComo"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Subtipo", "Subtipo"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("Empleado", "Empleado"),
                        new System.Data.Common.DataColumnMapping("Observac", "Observac"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[TabRepN]";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FolioIni", System.Data.SqlDbType.Char, 10),
            new System.Data.SqlClient.SqlParameter("@FOlioFin", System.Data.SqlDbType.Char, 10)});
            // 
            // dsUnidad2
            // 
            this.dsUnidad2.DataSetName = "dsUnidad";
            this.dsUnidad2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsUnidad2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.chbRespaldo);
            this.panel1.Controls.Add(this.chbTodos);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbDuplicado);
            this.panel1.Controls.Add(this.txtFolio);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.cmbUnidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.chbLab1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 109);
            this.panel1.TabIndex = 13;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsTabMdor1.TabiqueMdor;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(560, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsTabMdor1
            // 
            this.dsTabMdor1.DataSetName = "dsTabMdor";
            this.dsTabMdor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(780, 7);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chbTodos
            // 
            this.chbTodos.ForeColor = System.Drawing.Color.White;
            this.chbTodos.Location = new System.Drawing.Point(628, 53);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(125, 24);
            this.chbTodos.TabIndex = 79;
            this.chbTodos.Text = "Todos los informes";
            this.chbTodos.UseVisualStyleBackColor = true;
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.ForeColor = System.Drawing.Color.White;
            this.chbLab.Location = new System.Drawing.Point(352, 76);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(115, 24);
            this.chbLab.TabIndex = 78;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // chbDuplicado
            // 
            this.chbDuplicado.ForeColor = System.Drawing.Color.White;
            this.chbDuplicado.Location = new System.Drawing.Point(628, 32);
            this.chbDuplicado.Name = "chbDuplicado";
            this.chbDuplicado.Size = new System.Drawing.Size(89, 24);
            this.chbDuplicado.TabIndex = 34;
            this.chbDuplicado.Text = "¿Duplicado?";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(665, 6);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(56, 20);
            this.txtFolio.TabIndex = 33;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(628, 8);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(32, 13);
            this.Fecha.TabIndex = 32;
            this.Fecha.Text = "Folio:";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.Undescr", true));
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsUnidad1, "Unidad.IdUnidad", true));
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Enabled = false;
            this.cmbUnidad.Location = new System.Drawing.Point(472, 32);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(80, 21);
            this.cmbUnidad.TabIndex = 25;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(429, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Unidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(440, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(472, 6);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe de verificación de las propiedades físicas de bloques, tabiques o ladrill" +
    "oa, tabicones y adoquines";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(560, 32);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.Checked = true;
            this.chbLeyenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLeyenda.ForeColor = System.Drawing.Color.White;
            this.chbLeyenda.Location = new System.Drawing.Point(222, 76);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(116, 24);
            this.chbLeyenda.TabIndex = 33;
            this.chbLeyenda.Text = "Formato leyenda";
            // 
            // chbLab1
            // 
            this.chbLab1.Checked = true;
            this.chbLab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab1.ForeColor = System.Drawing.Color.White;
            this.chbLab1.Location = new System.Drawing.Point(476, 76);
            this.chbLab1.Name = "chbLab1";
            this.chbLab1.Size = new System.Drawing.Size(140, 28);
            this.chbLab1.TabIndex = 41;
            this.chbLab1.Text = "Incluye laboratorista";
            // 
            // crvInfTabique
            // 
            this.crvInfTabique.ActiveViewIndex = -1;
            this.crvInfTabique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfTabique.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfTabique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfTabique.EnableRefresh = false;
            this.crvInfTabique.Location = new System.Drawing.Point(0, 109);
            this.crvInfTabique.Name = "crvInfTabique";
            this.crvInfTabique.ShowCloseButton = false;
            this.crvInfTabique.ShowGroupTreeButton = false;
            this.crvInfTabique.ShowLogo = false;
            this.crvInfTabique.Size = new System.Drawing.Size(856, 415);
            this.crvInfTabique.TabIndex = 14;
            this.crvInfTabique.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // sqlDAUnidad
            // 
            this.sqlDAUnidad.SelectCommand = this.sqlCommand3;
            this.sqlDAUnidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Unidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Factor", "Factor"),
                        new System.Data.Common.DataColumnMapping("Undescr", "Undescr"),
                        new System.Data.Common.DataColumnMapping("MaxagrUn", "MaxagrUn"),
                        new System.Data.Common.DataColumnMapping("RevenUn", "RevenUn")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT IdUnidad, Factor, Undescr, MaxagrUn, RevenUn FROM Unidad";
            this.sqlCommand3.Connection = this.sqlConn;
            // 
            // dsInfTabN1
            // 
            this.dsInfTabN1.DataSetName = "dsInfTabN";
            this.dsInfTabN1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDATabiqueMdor
            // 
            this.sqlDATabiqueMdor.SelectCommand = this.sqlSelectCommand;
            this.sqlDATabiqueMdor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TabiqueMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FMuestreo", "FMuestreo"),
                        new System.Data.Common.DataColumnMapping("FEnsaye", "FEnsaye"),
                        new System.Data.Common.DataColumnMapping("FInforme", "FInforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("MReducida", "MReducida"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Cumple", "Cumple"),
                        new System.Data.Common.DataColumnMapping("Norma", "Norma"),
                        new System.Data.Common.DataColumnMapping("Como", "Como"),
                        new System.Data.Common.DataColumnMapping("ObsComo", "ObsComo"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Subtipo", "Subtipo"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("Empleado", "Empleado"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
                        new System.Data.Common.DataColumnMapping("Largo", "Largo"),
                        new System.Data.Common.DataColumnMapping("Ancho", "Ancho"),
                        new System.Data.Common.DataColumnMapping("Peralte", "Peralte"),
                        new System.Data.Common.DataColumnMapping("FFabrica", "FFabrica"),
                        new System.Data.Common.DataColumnMapping("ParExt", "ParExt"),
                        new System.Data.Common.DataColumnMapping("ParInt", "ParInt"),
                        new System.Data.Common.DataColumnMapping("ResPro", "ResPro"),
                        new System.Data.Common.DataColumnMapping("AbsIni", "AbsIni"),
                        new System.Data.Common.DataColumnMapping("AbsTot", "AbsTot"),
                        new System.Data.Common.DataColumnMapping("Proveedor", "Proveedor"),
                        new System.Data.Common.DataColumnMapping("ExpInt1", "ExpInt1"),
                        new System.Data.Common.DataColumnMapping("ExpInt2", "ExpInt2")})});
            // 
            // sqlSelectCommand
            // 
            this.sqlSelectCommand.CommandText = resources.GetString("sqlSelectCommand.CommandText");
            this.sqlSelectCommand.Connection = this.sqlConn;
            this.sqlSelectCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // dsFirmas1
            // 
            this.dsFirmas1.DataSetName = "dsFirmas";
            this.dsFirmas1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsFirmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDANorma
            // 
            this.sqlDANorma.SelectCommand = this.sqlSelectCommand4;
            this.sqlDANorma.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Normas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdNorma", "IdNorma"),
                        new System.Data.Common.DataColumnMapping("Informe", "Informe"),
                        new System.Data.Common.DataColumnMapping("Normas", "Normas"),
                        new System.Data.Common.DataColumnMapping("Titulo", "Titulo"),
                        new System.Data.Common.DataColumnMapping("IdInforme", "IdInforme"),
                        new System.Data.Common.DataColumnMapping("Norma1", "Norma1"),
                        new System.Data.Common.DataColumnMapping("Norma2", "Norma2"),
                        new System.Data.Common.DataColumnMapping("Norma3", "Norma3"),
                        new System.Data.Common.DataColumnMapping("Norma4", "Norma4"),
                        new System.Data.Common.DataColumnMapping("Norma5", "Norma5")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT IdNorma, Informe, Normas, Titulo, IdInforme, Norma1, Norma2, Norma3, Norma" +
    "4, Norma5 FROM Normas WHERE (IdNorma = @IdNorma)";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdNorma", System.Data.SqlDbType.SmallInt, 2, "IdNorma")});
            // 
            // chbRespaldo
            // 
            this.chbRespaldo.ForeColor = System.Drawing.Color.White;
            this.chbRespaldo.Location = new System.Drawing.Point(627, 76);
            this.chbRespaldo.Name = "chbRespaldo";
            this.chbRespaldo.Size = new System.Drawing.Size(90, 24);
            this.chbRespaldo.TabIndex = 88;
            this.chbRespaldo.Text = "Respaldo";
            // 
            // InfTabN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 524);
            this.Controls.Add(this.crvInfTabique);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "InfTabN";
            this.Text = "InfTabN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfTabN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsInfTabiqueMdor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTabMdor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfTabN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private dsInfTabiqueMdor dsInfTabiqueMdor1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAFirmas;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
        private dsUnidad dsUnidad1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAInfTabiqueResC;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        public System.Data.SqlClient.SqlDataAdapter sqlDAInfTabiqueResA;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDAInfTabiqueMdor;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private dsUnidad dsUnidad2;
        private System.Windows.Forms.Panel panel1;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.CheckBox chbLab;
        private System.Windows.Forms.CheckBox chbDuplicado;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdobra;
        private System.Windows.Forms.CheckBox chbLeyenda;
        private System.Windows.Forms.CheckBox chbLab1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfTabique;
        private dsBusObra dsBusObra1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private dsInfTabN dsInfTabN1;
        private dsTabMdor dsTabMdor1;
        private System.Data.SqlClient.SqlDataAdapter sqlDATabiqueMdor;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand;
        private dsFirmas dsFirmas1;
        public System.Data.SqlClient.SqlDataAdapter sqlDANorma;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private CryRepTabN cryRepTabN1;
        private System.Windows.Forms.CheckBox chbTodos;
        private System.Windows.Forms.CheckBox chbRespaldo;
    }
}