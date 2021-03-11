namespace LancNeo
{
    partial class Avance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avance));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.tbBtn2 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsObra1 = new LancNeo.dsObra();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAObras = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAAvance = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.dsAvance1 = new LancNeo.dsAvance();
            this.dgvAvance = new System.Windows.Forms.DataGridView();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdObraM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presupuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEcoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAceroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aAceroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AAB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PConector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AConector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AAF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAcero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incioPrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPrefaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPrefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPrefaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMorteroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMorteroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UMortero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acalas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCalas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAzfaltoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aAzfaltoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAgregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aAgregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTerraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTerraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UModulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqlComInserta = new System.Data.SqlClient.SqlCommand();
            this.sqlComAgrega = new System.Data.SqlClient.SqlCommand();
            this.sqlComActualiza = new System.Data.SqlClient.SqlCommand();
            this.sqlComUpdate = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAvance1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.tbBtn2);
            this.panel1.Controls.Add(this.tbBtn1);
            this.panel1.Controls.Add(this.dtpFinal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 88);
            this.panel1.TabIndex = 3;
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(465, 12);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 58;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            this.tbBtn1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBtn1_KeyUp);
            // 
            // tbBtn2
            // 
            this.tbBtn2.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn2.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn2.Icon")));
            this.tbBtn2.Location = new System.Drawing.Point(842, 12);
            this.tbBtn2.Name = "tbBtn2";
            this.tbBtn2.Size = new System.Drawing.Size(64, 64);
            this.tbBtn2.TabIndex = 63;
            this.tbBtn2.Click += new System.EventHandler(this.tbBtn2_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(724, 12);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 13;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(636, 34);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(82, 20);
            this.dtpFinal.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(345, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(379, 34);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 60;
            this.cmbIdObra.ValueMember = "IdObra";
            // 
            // dsObra1
            // 
            this.dsObra1.DataSetName = "dsObra";
            this.dsObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(549, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha avance:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "Avance de muestro de acero, prefabricados, mortero y asfalto";
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAObras
            // 
            this.sqlDAObras.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAObras.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Codigop", "Codigop"),
                        new System.Data.Common.DataColumnMapping("Sintendente", "Sintendente"),
                        new System.Data.Common.DataColumnMapping("Jfrente", "Jfrente"),
                        new System.Data.Common.DataColumnMapping("Telefono", "Telefono"),
                        new System.Data.Common.DataColumnMapping("Solicitud", "Solicitud"),
                        new System.Data.Common.DataColumnMapping("Presupuesto", "Presupuesto"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Fechai", "Fechai"),
                        new System.Data.Common.DataColumnMapping("Fechaf", "Fechaf"),
                        new System.Data.Common.DataColumnMapping("Carpeta", "Carpeta"),
                        new System.Data.Common.DataColumnMapping("Diaj", "Diaj"),
                        new System.Data.Common.DataColumnMapping("Horaj", "Horaj"),
                        new System.Data.Common.DataColumnMapping("Soldadura", "Soldadura"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("Origen", "Origen"),
                        new System.Data.Common.DataColumnMapping("Coeficiente", "Coeficiente"),
                        new System.Data.Common.DataColumnMapping("PresupuestoZ", "PresupuestoZ"),
                        new System.Data.Common.DataColumnMapping("Duracion", "Duracion"),
                        new System.Data.Common.DataColumnMapping("Paradox", "Paradox"),
                        new System.Data.Common.DataColumnMapping("Informes", "Informes"),
                        new System.Data.Common.DataColumnMapping("Contrato", "Contrato"),
                        new System.Data.Common.DataColumnMapping("Tipolab", "Tipolab"),
                        new System.Data.Common.DataColumnMapping("Certificado", "Certificado"),
                        new System.Data.Common.DataColumnMapping("SerConcreto", "SerConcreto"),
                        new System.Data.Common.DataColumnMapping("SerSoldadura", "SerSoldadura"),
                        new System.Data.Common.DataColumnMapping("PlaCim", "PlaCim"),
                        new System.Data.Common.DataColumnMapping("PlaPT", "PlaPT"),
                        new System.Data.Common.DataColumnMapping("PlaCorte", "PlaCorte"),
                        new System.Data.Common.DataColumnMapping("SerAcero", "SerAcero"),
                        new System.Data.Common.DataColumnMapping("SerTerra", "SerTerra"),
                        new System.Data.Common.DataColumnMapping("SerPrefa", "SerPrefa"),
                        new System.Data.Common.DataColumnMapping("SerMor", "SerMor"),
                        new System.Data.Common.DataColumnMapping("AccesoWEB", "AccesoWEB"),
                        new System.Data.Common.DataColumnMapping("InfResbajas", "InfResbajas"),
                        new System.Data.Common.DataColumnMapping("Infemail", "Infemail"),
                        new System.Data.Common.DataColumnMapping("InfTelefono", "InfTelefono"),
                        new System.Data.Common.DataColumnMapping("InfOriginal", "InfOriginal"),
                        new System.Data.Common.DataColumnMapping("InfCopia", "InfCopia"),
                        new System.Data.Common.DataColumnMapping("TelResidente", "TelResidente"),
                        new System.Data.Common.DataColumnMapping("Correo1", "Correo1"),
                        new System.Data.Common.DataColumnMapping("Correo2", "Correo2"),
                        new System.Data.Common.DataColumnMapping("Correo3", "Correo3"),
                        new System.Data.Common.DataColumnMapping("Correo4", "Correo4"),
                        new System.Data.Common.DataColumnMapping("Correo5", "Correo5"),
                        new System.Data.Common.DataColumnMapping("SeEspe", "SeEspe"),
                        new System.Data.Common.DataColumnMapping("CualEsp", "CualEsp")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlDAAvance
            // 
            this.sqlDAAvance.DeleteCommand = this.sqlCommand1;
            this.sqlDAAvance.InsertCommand = this.sqlInsertCommand;
            this.sqlDAAvance.SelectCommand = this.sqlCommand3;
            this.sqlDAAvance.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Avance", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Presupuesto", "Presupuesto"),
                        new System.Data.Common.DataColumnMapping("InicioO", "InicioO"),
                        new System.Data.Common.DataColumnMapping("Duracion", "Duracion"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Ciente", "Ciente"),
                        new System.Data.Common.DataColumnMapping("PAcero", "PAcero"),
                        new System.Data.Common.DataColumnMapping("AAcero", "AAcero"),
                        new System.Data.Common.DataColumnMapping("IncioPr", "IncioPr"),
                        new System.Data.Common.DataColumnMapping("PPrefa", "PPrefa"),
                        new System.Data.Common.DataColumnMapping("APrefa", "APrefa"),
                        new System.Data.Common.DataColumnMapping("PMortero", "PMortero"),
                        new System.Data.Common.DataColumnMapping("AMortero", "AMortero"),
                        new System.Data.Common.DataColumnMapping("PAzfalto", "PAzfalto"),
                        new System.Data.Common.DataColumnMapping("AAzfalto", "AAzfalto"),
                        new System.Data.Common.DataColumnMapping("PAgrega", "PAgrega"),
                        new System.Data.Common.DataColumnMapping("AAgrega", "AAgrega"),
                        new System.Data.Common.DataColumnMapping("PTerra", "PTerra"),
                        new System.Data.Common.DataColumnMapping("ATerra", "ATerra"),
                        new System.Data.Common.DataColumnMapping("PNucleo", "PNucleo"),
                        new System.Data.Common.DataColumnMapping("ANucleo", "ANucleo"),
                        new System.Data.Common.DataColumnMapping("Operador", "Operador"),
                        new System.Data.Common.DataColumnMapping("IdObraM", "IdObraM"),
                        new System.Data.Common.DataColumnMapping("PConector", "PConector"),
                        new System.Data.Common.DataColumnMapping("AConector", "AConector"),
                        new System.Data.Common.DataColumnMapping("PCalas", "PCalas"),
                        new System.Data.Common.DataColumnMapping("Acalas", "Acalas"),
                        new System.Data.Common.DataColumnMapping("PModulo", "PModulo"),
                        new System.Data.Common.DataColumnMapping("AModulo", "AModulo"),
                        new System.Data.Common.DataColumnMapping("UAcero", "UAcero"),
                        new System.Data.Common.DataColumnMapping("PAB", "PAB"),
                        new System.Data.Common.DataColumnMapping("AAB", "AAB"),
                        new System.Data.Common.DataColumnMapping("PAC", "PAC"),
                        new System.Data.Common.DataColumnMapping("AAC", "AAC"),
                        new System.Data.Common.DataColumnMapping("PAD", "PAD"),
                        new System.Data.Common.DataColumnMapping("AAD", "AAD"),
                        new System.Data.Common.DataColumnMapping("PAF", "PAF"),
                        new System.Data.Common.DataColumnMapping("AAF", "AAF"),
                        new System.Data.Common.DataColumnMapping("UMortero", "UMortero"),
                        new System.Data.Common.DataColumnMapping("UPrefa", "UPrefa"),
                        new System.Data.Common.DataColumnMapping("UModulos", "UModulos"),
                        new System.Data.Common.DataColumnMapping("Ucalidades", "Ucalidades"),
                        new System.Data.Common.DataColumnMapping("UCalas", "UCalas"),
                        new System.Data.Common.DataColumnMapping("UAB", "UAB")})});
            this.sqlDAAvance.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConn;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Presupuesto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Presupuesto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Presupuesto", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Presupuesto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InicioO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InicioO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InicioO", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InicioO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Duracion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Duracion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Duracion", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Duracion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ciente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ciente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ciente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ciente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAcero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAcero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IncioPr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IncioPr", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IncioPr", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IncioPr", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PPrefa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PPrefa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PPrefa", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PPrefa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_APrefa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "APrefa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_APrefa", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "APrefa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PMortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PMortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PMortero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PMortero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AMortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AMortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AMortero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AMortero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAzfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAzfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAzfalto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAzfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAzfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAzfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAzfalto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAzfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAgrega", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAgrega", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAgrega", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAgrega", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAgrega", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAgrega", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAgrega", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAgrega", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PTerra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PTerra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PTerra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PTerra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ATerra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ATerra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ATerra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ATerra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PNucleo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PNucleo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PNucleo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PNucleo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ANucleo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ANucleo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ANucleo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ANucleo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Operador", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Operador", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Operador", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Operador", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdObraM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdObraM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdObraM", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObraM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PConector", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PConector", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PConector", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PConector", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AConector", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AConector", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AConector", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AConector", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PCalas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PCalas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PCalas", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PCalas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Acalas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Acalas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Acalas", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Acalas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PModulo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PModulo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PModulo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PModulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AModulo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AModulo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AModulo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AModulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UAcero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAB", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAB", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAC", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAC", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAD", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAD", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAF", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAF", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UMortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UMortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UMortero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UMortero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UPrefa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UPrefa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UPrefa", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UPrefa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UModulos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UModulos", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UModulos", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UModulos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ucalidades", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ucalidades", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ucalidades", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ucalidades", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UCalas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UCalas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UCalas", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UCalas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UAB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UAB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UAB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UAB", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = resources.GetString("sqlInsertCommand.CommandText");
            this.sqlInsertCommand.Connection = this.sqlConn;
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Presupuesto", System.Data.SqlDbType.NVarChar, 0, "Presupuesto"),
            new System.Data.SqlClient.SqlParameter("@InicioO", System.Data.SqlDbType.NVarChar, 0, "InicioO"),
            new System.Data.SqlClient.SqlParameter("@Duracion", System.Data.SqlDbType.SmallInt, 0, "Duracion"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Ciente", System.Data.SqlDbType.NVarChar, 0, "Ciente"),
            new System.Data.SqlClient.SqlParameter("@PAcero", System.Data.SqlDbType.SmallInt, 0, "PAcero"),
            new System.Data.SqlClient.SqlParameter("@AAcero", System.Data.SqlDbType.SmallInt, 0, "AAcero"),
            new System.Data.SqlClient.SqlParameter("@IncioPr", System.Data.SqlDbType.NVarChar, 0, "IncioPr"),
            new System.Data.SqlClient.SqlParameter("@PPrefa", System.Data.SqlDbType.SmallInt, 0, "PPrefa"),
            new System.Data.SqlClient.SqlParameter("@APrefa", System.Data.SqlDbType.SmallInt, 0, "APrefa"),
            new System.Data.SqlClient.SqlParameter("@PMortero", System.Data.SqlDbType.SmallInt, 0, "PMortero"),
            new System.Data.SqlClient.SqlParameter("@AMortero", System.Data.SqlDbType.SmallInt, 0, "AMortero"),
            new System.Data.SqlClient.SqlParameter("@PAzfalto", System.Data.SqlDbType.SmallInt, 0, "PAzfalto"),
            new System.Data.SqlClient.SqlParameter("@AAzfalto", System.Data.SqlDbType.SmallInt, 0, "AAzfalto"),
            new System.Data.SqlClient.SqlParameter("@PAgrega", System.Data.SqlDbType.SmallInt, 0, "PAgrega"),
            new System.Data.SqlClient.SqlParameter("@AAgrega", System.Data.SqlDbType.SmallInt, 0, "AAgrega"),
            new System.Data.SqlClient.SqlParameter("@PTerra", System.Data.SqlDbType.SmallInt, 0, "PTerra"),
            new System.Data.SqlClient.SqlParameter("@ATerra", System.Data.SqlDbType.SmallInt, 0, "ATerra"),
            new System.Data.SqlClient.SqlParameter("@PNucleo", System.Data.SqlDbType.SmallInt, 0, "PNucleo"),
            new System.Data.SqlClient.SqlParameter("@ANucleo", System.Data.SqlDbType.SmallInt, 0, "ANucleo"),
            new System.Data.SqlClient.SqlParameter("@Operador", System.Data.SqlDbType.NVarChar, 0, "Operador"),
            new System.Data.SqlClient.SqlParameter("@IdObraM", System.Data.SqlDbType.NVarChar, 0, "IdObraM"),
            new System.Data.SqlClient.SqlParameter("@PConector", System.Data.SqlDbType.SmallInt, 0, "PConector"),
            new System.Data.SqlClient.SqlParameter("@AConector", System.Data.SqlDbType.SmallInt, 0, "AConector"),
            new System.Data.SqlClient.SqlParameter("@PCalas", System.Data.SqlDbType.SmallInt, 0, "PCalas"),
            new System.Data.SqlClient.SqlParameter("@Acalas", System.Data.SqlDbType.SmallInt, 0, "Acalas"),
            new System.Data.SqlClient.SqlParameter("@PModulo", System.Data.SqlDbType.SmallInt, 0, "PModulo"),
            new System.Data.SqlClient.SqlParameter("@AModulo", System.Data.SqlDbType.SmallInt, 0, "AModulo"),
            new System.Data.SqlClient.SqlParameter("@UAcero", System.Data.SqlDbType.NVarChar, 0, "UAcero"),
            new System.Data.SqlClient.SqlParameter("@PAB", System.Data.SqlDbType.SmallInt, 0, "PAB"),
            new System.Data.SqlClient.SqlParameter("@AAB", System.Data.SqlDbType.SmallInt, 0, "AAB"),
            new System.Data.SqlClient.SqlParameter("@PAC", System.Data.SqlDbType.SmallInt, 0, "PAC"),
            new System.Data.SqlClient.SqlParameter("@AAC", System.Data.SqlDbType.SmallInt, 0, "AAC"),
            new System.Data.SqlClient.SqlParameter("@PAD", System.Data.SqlDbType.SmallInt, 0, "PAD"),
            new System.Data.SqlClient.SqlParameter("@AAD", System.Data.SqlDbType.SmallInt, 0, "AAD"),
            new System.Data.SqlClient.SqlParameter("@PAF", System.Data.SqlDbType.SmallInt, 0, "PAF"),
            new System.Data.SqlClient.SqlParameter("@AAF", System.Data.SqlDbType.SmallInt, 0, "AAF"),
            new System.Data.SqlClient.SqlParameter("@UMortero", System.Data.SqlDbType.NVarChar, 0, "UMortero"),
            new System.Data.SqlClient.SqlParameter("@UPrefa", System.Data.SqlDbType.NVarChar, 0, "UPrefa"),
            new System.Data.SqlClient.SqlParameter("@UModulos", System.Data.SqlDbType.NVarChar, 0, "UModulos"),
            new System.Data.SqlClient.SqlParameter("@Ucalidades", System.Data.SqlDbType.NVarChar, 0, "Ucalidades"),
            new System.Data.SqlClient.SqlParameter("@UCalas", System.Data.SqlDbType.NVarChar, 0, "UCalas"),
            new System.Data.SqlClient.SqlParameter("@UAB", System.Data.SqlDbType.NVarChar, 0, "UAB")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Connection = this.sqlConn;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Presupuesto", System.Data.SqlDbType.NVarChar, 0, "Presupuesto"),
            new System.Data.SqlClient.SqlParameter("@InicioO", System.Data.SqlDbType.NVarChar, 0, "InicioO"),
            new System.Data.SqlClient.SqlParameter("@Duracion", System.Data.SqlDbType.SmallInt, 0, "Duracion"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Ciente", System.Data.SqlDbType.NVarChar, 0, "Ciente"),
            new System.Data.SqlClient.SqlParameter("@PAcero", System.Data.SqlDbType.SmallInt, 0, "PAcero"),
            new System.Data.SqlClient.SqlParameter("@AAcero", System.Data.SqlDbType.SmallInt, 0, "AAcero"),
            new System.Data.SqlClient.SqlParameter("@IncioPr", System.Data.SqlDbType.NVarChar, 0, "IncioPr"),
            new System.Data.SqlClient.SqlParameter("@PPrefa", System.Data.SqlDbType.SmallInt, 0, "PPrefa"),
            new System.Data.SqlClient.SqlParameter("@APrefa", System.Data.SqlDbType.SmallInt, 0, "APrefa"),
            new System.Data.SqlClient.SqlParameter("@PMortero", System.Data.SqlDbType.SmallInt, 0, "PMortero"),
            new System.Data.SqlClient.SqlParameter("@AMortero", System.Data.SqlDbType.SmallInt, 0, "AMortero"),
            new System.Data.SqlClient.SqlParameter("@PAzfalto", System.Data.SqlDbType.SmallInt, 0, "PAzfalto"),
            new System.Data.SqlClient.SqlParameter("@AAzfalto", System.Data.SqlDbType.SmallInt, 0, "AAzfalto"),
            new System.Data.SqlClient.SqlParameter("@PAgrega", System.Data.SqlDbType.SmallInt, 0, "PAgrega"),
            new System.Data.SqlClient.SqlParameter("@AAgrega", System.Data.SqlDbType.SmallInt, 0, "AAgrega"),
            new System.Data.SqlClient.SqlParameter("@PTerra", System.Data.SqlDbType.SmallInt, 0, "PTerra"),
            new System.Data.SqlClient.SqlParameter("@ATerra", System.Data.SqlDbType.SmallInt, 0, "ATerra"),
            new System.Data.SqlClient.SqlParameter("@PNucleo", System.Data.SqlDbType.SmallInt, 0, "PNucleo"),
            new System.Data.SqlClient.SqlParameter("@ANucleo", System.Data.SqlDbType.SmallInt, 0, "ANucleo"),
            new System.Data.SqlClient.SqlParameter("@Operador", System.Data.SqlDbType.NVarChar, 0, "Operador"),
            new System.Data.SqlClient.SqlParameter("@IdObraM", System.Data.SqlDbType.NVarChar, 0, "IdObraM"),
            new System.Data.SqlClient.SqlParameter("@PConector", System.Data.SqlDbType.SmallInt, 0, "PConector"),
            new System.Data.SqlClient.SqlParameter("@AConector", System.Data.SqlDbType.SmallInt, 0, "AConector"),
            new System.Data.SqlClient.SqlParameter("@PCalas", System.Data.SqlDbType.SmallInt, 0, "PCalas"),
            new System.Data.SqlClient.SqlParameter("@Acalas", System.Data.SqlDbType.SmallInt, 0, "Acalas"),
            new System.Data.SqlClient.SqlParameter("@PModulo", System.Data.SqlDbType.SmallInt, 0, "PModulo"),
            new System.Data.SqlClient.SqlParameter("@AModulo", System.Data.SqlDbType.SmallInt, 0, "AModulo"),
            new System.Data.SqlClient.SqlParameter("@UAcero", System.Data.SqlDbType.NVarChar, 0, "UAcero"),
            new System.Data.SqlClient.SqlParameter("@PAB", System.Data.SqlDbType.SmallInt, 0, "PAB"),
            new System.Data.SqlClient.SqlParameter("@AAB", System.Data.SqlDbType.SmallInt, 0, "AAB"),
            new System.Data.SqlClient.SqlParameter("@PAC", System.Data.SqlDbType.SmallInt, 0, "PAC"),
            new System.Data.SqlClient.SqlParameter("@AAC", System.Data.SqlDbType.SmallInt, 0, "AAC"),
            new System.Data.SqlClient.SqlParameter("@PAD", System.Data.SqlDbType.SmallInt, 0, "PAD"),
            new System.Data.SqlClient.SqlParameter("@AAD", System.Data.SqlDbType.SmallInt, 0, "AAD"),
            new System.Data.SqlClient.SqlParameter("@PAF", System.Data.SqlDbType.SmallInt, 0, "PAF"),
            new System.Data.SqlClient.SqlParameter("@AAF", System.Data.SqlDbType.SmallInt, 0, "AAF"),
            new System.Data.SqlClient.SqlParameter("@UMortero", System.Data.SqlDbType.NVarChar, 0, "UMortero"),
            new System.Data.SqlClient.SqlParameter("@UPrefa", System.Data.SqlDbType.NVarChar, 0, "UPrefa"),
            new System.Data.SqlClient.SqlParameter("@UModulos", System.Data.SqlDbType.NVarChar, 0, "UModulos"),
            new System.Data.SqlClient.SqlParameter("@Ucalidades", System.Data.SqlDbType.NVarChar, 0, "Ucalidades"),
            new System.Data.SqlClient.SqlParameter("@UCalas", System.Data.SqlDbType.NVarChar, 0, "UCalas"),
            new System.Data.SqlClient.SqlParameter("@UAB", System.Data.SqlDbType.NVarChar, 0, "UAB"),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Presupuesto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Presupuesto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Presupuesto", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Presupuesto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InicioO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InicioO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InicioO", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InicioO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Duracion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Duracion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Duracion", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Duracion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ciente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ciente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ciente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ciente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAcero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAcero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IncioPr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IncioPr", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IncioPr", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IncioPr", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PPrefa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PPrefa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PPrefa", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PPrefa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_APrefa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "APrefa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_APrefa", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "APrefa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PMortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PMortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PMortero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PMortero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AMortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AMortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AMortero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AMortero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAzfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAzfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAzfalto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAzfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAzfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAzfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAzfalto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAzfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAgrega", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAgrega", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAgrega", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAgrega", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAgrega", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAgrega", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAgrega", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAgrega", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PTerra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PTerra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PTerra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PTerra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ATerra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ATerra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ATerra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ATerra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PNucleo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PNucleo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PNucleo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PNucleo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ANucleo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ANucleo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ANucleo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ANucleo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Operador", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Operador", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Operador", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Operador", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdObraM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdObraM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdObraM", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObraM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PConector", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PConector", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PConector", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PConector", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AConector", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AConector", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AConector", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AConector", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PCalas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PCalas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PCalas", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PCalas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Acalas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Acalas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Acalas", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Acalas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PModulo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PModulo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PModulo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PModulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AModulo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AModulo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AModulo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AModulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UAcero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAB", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAB", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAC", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAC", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAD", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAD", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAF", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AAF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AAF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AAF", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AAF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UMortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UMortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UMortero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UMortero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UPrefa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UPrefa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UPrefa", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UPrefa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UModulos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UModulos", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UModulos", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UModulos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ucalidades", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ucalidades", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ucalidades", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ucalidades", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UCalas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UCalas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UCalas", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UCalas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UAB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UAB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UAB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UAB", System.Data.DataRowVersion.Original, null)});
            // 
            // dsAvance1
            // 
            this.dsAvance1.DataSetName = "dsAvance";
            this.dsAvance1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvAvance
            // 
            this.dgvAvance.AllowUserToAddRows = false;
            this.dgvAvance.AutoGenerateColumns = false;
            this.dgvAvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObraDataGridViewTextBoxColumn,
            this.IdObraM,
            this.Obra,
            this.presupuestoDataGridViewTextBoxColumn,
            this.inicioODataGridViewTextBoxColumn,
            this.operadorDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.noEcoDataGridViewTextBoxColumn,
            this.cienteDataGridViewTextBoxColumn,
            this.pAceroDataGridViewTextBoxColumn,
            this.aAceroDataGridViewTextBoxColumn,
            this.PAB,
            this.AAB,
            this.PAC,
            this.AAC,
            this.PAD,
            this.AAD,
            this.PConector,
            this.AConector,
            this.PAF,
            this.AAF,
            this.UAcero,
            this.incioPrDataGridViewTextBoxColumn,
            this.pPrefaDataGridViewTextBoxColumn,
            this.UPrefa,
            this.aPrefaDataGridViewTextBoxColumn,
            this.pMorteroDataGridViewTextBoxColumn,
            this.aMorteroDataGridViewTextBoxColumn,
            this.UMortero,
            this.Acalas,
            this.UCalas,
            this.pAzfaltoDataGridViewTextBoxColumn,
            this.aAzfaltoDataGridViewTextBoxColumn,
            this.pAgregaDataGridViewTextBoxColumn,
            this.aAgregaDataGridViewTextBoxColumn,
            this.pTerraDataGridViewTextBoxColumn,
            this.aTerraDataGridViewTextBoxColumn,
            this.Ucalidades,
            this.PModulo,
            this.AModulo,
            this.UModulos});
            this.dgvAvance.DataMember = "Avance";
            this.dgvAvance.DataSource = this.dsAvance1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvance.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvance.Location = new System.Drawing.Point(0, 88);
            this.dgvAvance.Name = "dgvAvance";
            this.dgvAvance.Size = new System.Drawing.Size(1099, 421);
            this.dgvAvance.TabIndex = 4;
            this.dgvAvance.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvance_CellValueChanged);
            this.dgvAvance.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAvance_DefaultValuesNeeded);
            this.dgvAvance.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAvance_NewRowNeeded);
            this.dgvAvance.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvAvance_RowPrePaint);
            this.dgvAvance.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAvance_RowsRemoved);
            this.dgvAvance.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAvance_UserDeletedRow);
            this.dgvAvance.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvAvance_UserDeletingRow);
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            this.idObraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idObraDataGridViewTextBoxColumn.Width = 50;
            // 
            // IdObraM
            // 
            this.IdObraM.DataPropertyName = "IdObraM";
            this.IdObraM.HeaderText = "Clave mortero";
            this.IdObraM.MaxInputLength = 6;
            this.IdObraM.Name = "IdObraM";
            this.IdObraM.Width = 50;
            // 
            // Obra
            // 
            this.Obra.HeaderText = "Obra";
            this.Obra.Name = "Obra";
            this.Obra.ReadOnly = true;
            // 
            // presupuestoDataGridViewTextBoxColumn
            // 
            this.presupuestoDataGridViewTextBoxColumn.DataPropertyName = "Presupuesto";
            this.presupuestoDataGridViewTextBoxColumn.HeaderText = "Presupuesto";
            this.presupuestoDataGridViewTextBoxColumn.Name = "presupuestoDataGridViewTextBoxColumn";
            this.presupuestoDataGridViewTextBoxColumn.Width = 65;
            // 
            // inicioODataGridViewTextBoxColumn
            // 
            this.inicioODataGridViewTextBoxColumn.DataPropertyName = "InicioO";
            this.inicioODataGridViewTextBoxColumn.HeaderText = "Inicio";
            this.inicioODataGridViewTextBoxColumn.MaxInputLength = 6;
            this.inicioODataGridViewTextBoxColumn.Name = "inicioODataGridViewTextBoxColumn";
            this.inicioODataGridViewTextBoxColumn.Width = 45;
            // 
            // operadorDataGridViewTextBoxColumn
            // 
            this.operadorDataGridViewTextBoxColumn.DataPropertyName = "Operador";
            this.operadorDataGridViewTextBoxColumn.HeaderText = "Operador";
            this.operadorDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.operadorDataGridViewTextBoxColumn.Name = "operadorDataGridViewTextBoxColumn";
            this.operadorDataGridViewTextBoxColumn.Width = 70;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duración";
            this.duracionDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            this.duracionDataGridViewTextBoxColumn.Width = 55;
            // 
            // noEcoDataGridViewTextBoxColumn
            // 
            this.noEcoDataGridViewTextBoxColumn.DataPropertyName = "NoEco";
            this.noEcoDataGridViewTextBoxColumn.HeaderText = "Lab. ensaye";
            this.noEcoDataGridViewTextBoxColumn.Name = "noEcoDataGridViewTextBoxColumn";
            this.noEcoDataGridViewTextBoxColumn.Width = 40;
            // 
            // cienteDataGridViewTextBoxColumn
            // 
            this.cienteDataGridViewTextBoxColumn.DataPropertyName = "Ciente";
            this.cienteDataGridViewTextBoxColumn.HeaderText = "Clente";
            this.cienteDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.cienteDataGridViewTextBoxColumn.Name = "cienteDataGridViewTextBoxColumn";
            this.cienteDataGridViewTextBoxColumn.Width = 90;
            // 
            // pAceroDataGridViewTextBoxColumn
            // 
            this.pAceroDataGridViewTextBoxColumn.DataPropertyName = "PAcero";
            this.pAceroDataGridViewTextBoxColumn.HeaderText = "Pre \'A\'";
            this.pAceroDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.pAceroDataGridViewTextBoxColumn.Name = "pAceroDataGridViewTextBoxColumn";
            this.pAceroDataGridViewTextBoxColumn.Width = 40;
            // 
            // aAceroDataGridViewTextBoxColumn
            // 
            this.aAceroDataGridViewTextBoxColumn.DataPropertyName = "AAcero";
            this.aAceroDataGridViewTextBoxColumn.HeaderText = "Ava \'A\'";
            this.aAceroDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.aAceroDataGridViewTextBoxColumn.Name = "aAceroDataGridViewTextBoxColumn";
            this.aAceroDataGridViewTextBoxColumn.Width = 40;
            // 
            // PAB
            // 
            this.PAB.DataPropertyName = "PAB";
            this.PAB.HeaderText = "Pre \'B\'";
            this.PAB.Name = "PAB";
            this.PAB.Width = 40;
            // 
            // AAB
            // 
            this.AAB.DataPropertyName = "AAB";
            this.AAB.HeaderText = "Ava \'B\'";
            this.AAB.Name = "AAB";
            this.AAB.Width = 40;
            // 
            // PAC
            // 
            this.PAC.DataPropertyName = "PAC";
            this.PAC.HeaderText = "Pre \'C\'";
            this.PAC.Name = "PAC";
            this.PAC.Width = 40;
            // 
            // AAC
            // 
            this.AAC.DataPropertyName = "AAC";
            this.AAC.HeaderText = "Ava \'C\'";
            this.AAC.Name = "AAC";
            this.AAC.Width = 40;
            // 
            // PAD
            // 
            this.PAD.DataPropertyName = "PAD";
            this.PAD.HeaderText = "Pre \'D\'";
            this.PAD.Name = "PAD";
            this.PAD.Width = 40;
            // 
            // AAD
            // 
            this.AAD.DataPropertyName = "AAD";
            this.AAD.HeaderText = "Ava \'D\'";
            this.AAD.Name = "AAD";
            this.AAD.Width = 40;
            // 
            // PConector
            // 
            this.PConector.DataPropertyName = "PConector";
            this.PConector.HeaderText = "Pres. Cone.";
            this.PConector.MaxInputLength = 4;
            this.PConector.Name = "PConector";
            this.PConector.Width = 40;
            // 
            // AConector
            // 
            this.AConector.DataPropertyName = "AConector";
            this.AConector.HeaderText = "Ava Cone.";
            this.AConector.MaxInputLength = 4;
            this.AConector.Name = "AConector";
            this.AConector.Width = 40;
            // 
            // PAF
            // 
            this.PAF.DataPropertyName = "PAF";
            this.PAF.HeaderText = "Pre \'F\'";
            this.PAF.Name = "PAF";
            this.PAF.Width = 40;
            // 
            // AAF
            // 
            this.AAF.DataPropertyName = "AAF";
            this.AAF.HeaderText = "Ava \'F\'";
            this.AAF.Name = "AAF";
            this.AAF.Width = 40;
            // 
            // UAcero
            // 
            this.UAcero.DataPropertyName = "UAcero";
            this.UAcero.HeaderText = "Ult Sem";
            this.UAcero.Name = "UAcero";
            this.UAcero.Width = 50;
            // 
            // incioPrDataGridViewTextBoxColumn
            // 
            this.incioPrDataGridViewTextBoxColumn.DataPropertyName = "IncioPr";
            this.incioPrDataGridViewTextBoxColumn.HeaderText = "Inicio Pefabr.";
            this.incioPrDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.incioPrDataGridViewTextBoxColumn.Name = "incioPrDataGridViewTextBoxColumn";
            this.incioPrDataGridViewTextBoxColumn.Width = 50;
            // 
            // pPrefaDataGridViewTextBoxColumn
            // 
            this.pPrefaDataGridViewTextBoxColumn.DataPropertyName = "PPrefa";
            this.pPrefaDataGridViewTextBoxColumn.HeaderText = "Presu. Prefa.";
            this.pPrefaDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.pPrefaDataGridViewTextBoxColumn.Name = "pPrefaDataGridViewTextBoxColumn";
            this.pPrefaDataGridViewTextBoxColumn.Width = 40;
            // 
            // UPrefa
            // 
            this.UPrefa.DataPropertyName = "UPrefa";
            this.UPrefa.HeaderText = "U S Pre";
            this.UPrefa.Name = "UPrefa";
            this.UPrefa.Width = 50;
            // 
            // aPrefaDataGridViewTextBoxColumn
            // 
            this.aPrefaDataGridViewTextBoxColumn.DataPropertyName = "APrefa";
            this.aPrefaDataGridViewTextBoxColumn.HeaderText = "Ava Prefa.";
            this.aPrefaDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.aPrefaDataGridViewTextBoxColumn.Name = "aPrefaDataGridViewTextBoxColumn";
            this.aPrefaDataGridViewTextBoxColumn.Width = 40;
            // 
            // pMorteroDataGridViewTextBoxColumn
            // 
            this.pMorteroDataGridViewTextBoxColumn.DataPropertyName = "PMortero";
            this.pMorteroDataGridViewTextBoxColumn.HeaderText = "Pres. Mortero";
            this.pMorteroDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.pMorteroDataGridViewTextBoxColumn.Name = "pMorteroDataGridViewTextBoxColumn";
            this.pMorteroDataGridViewTextBoxColumn.Width = 40;
            // 
            // aMorteroDataGridViewTextBoxColumn
            // 
            this.aMorteroDataGridViewTextBoxColumn.DataPropertyName = "AMortero";
            this.aMorteroDataGridViewTextBoxColumn.HeaderText = "Ava Mortero";
            this.aMorteroDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.aMorteroDataGridViewTextBoxColumn.Name = "aMorteroDataGridViewTextBoxColumn";
            this.aMorteroDataGridViewTextBoxColumn.Width = 40;
            // 
            // UMortero
            // 
            this.UMortero.DataPropertyName = "UMortero";
            this.UMortero.HeaderText = "U S Mor";
            this.UMortero.Name = "UMortero";
            this.UMortero.Width = 50;
            // 
            // Acalas
            // 
            this.Acalas.DataPropertyName = "Acalas";
            this.Acalas.HeaderText = "Ava calas";
            this.Acalas.MaxInputLength = 4;
            this.Acalas.Name = "Acalas";
            this.Acalas.Width = 40;
            // 
            // UCalas
            // 
            this.UCalas.DataPropertyName = "UCalas";
            this.UCalas.HeaderText = "U S Cal";
            this.UCalas.Name = "UCalas";
            this.UCalas.Width = 50;
            // 
            // pAzfaltoDataGridViewTextBoxColumn
            // 
            this.pAzfaltoDataGridViewTextBoxColumn.DataPropertyName = "PAzfalto";
            this.pAzfaltoDataGridViewTextBoxColumn.HeaderText = "Presu. Asfalto";
            this.pAzfaltoDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.pAzfaltoDataGridViewTextBoxColumn.Name = "pAzfaltoDataGridViewTextBoxColumn";
            this.pAzfaltoDataGridViewTextBoxColumn.Width = 40;
            // 
            // aAzfaltoDataGridViewTextBoxColumn
            // 
            this.aAzfaltoDataGridViewTextBoxColumn.DataPropertyName = "AAzfalto";
            this.aAzfaltoDataGridViewTextBoxColumn.HeaderText = "Ava asfalto";
            this.aAzfaltoDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.aAzfaltoDataGridViewTextBoxColumn.Name = "aAzfaltoDataGridViewTextBoxColumn";
            this.aAzfaltoDataGridViewTextBoxColumn.Width = 40;
            // 
            // pAgregaDataGridViewTextBoxColumn
            // 
            this.pAgregaDataGridViewTextBoxColumn.DataPropertyName = "PAgrega";
            this.pAgregaDataGridViewTextBoxColumn.HeaderText = "Pres. Agrega.";
            this.pAgregaDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.pAgregaDataGridViewTextBoxColumn.Name = "pAgregaDataGridViewTextBoxColumn";
            this.pAgregaDataGridViewTextBoxColumn.Width = 40;
            // 
            // aAgregaDataGridViewTextBoxColumn
            // 
            this.aAgregaDataGridViewTextBoxColumn.DataPropertyName = "AAgrega";
            this.aAgregaDataGridViewTextBoxColumn.HeaderText = "Ava Agrega.";
            this.aAgregaDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.aAgregaDataGridViewTextBoxColumn.Name = "aAgregaDataGridViewTextBoxColumn";
            this.aAgregaDataGridViewTextBoxColumn.Width = 40;
            // 
            // pTerraDataGridViewTextBoxColumn
            // 
            this.pTerraDataGridViewTextBoxColumn.DataPropertyName = "PTerra";
            this.pTerraDataGridViewTextBoxColumn.HeaderText = "Pres. Terra.";
            this.pTerraDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.pTerraDataGridViewTextBoxColumn.Name = "pTerraDataGridViewTextBoxColumn";
            this.pTerraDataGridViewTextBoxColumn.Width = 40;
            // 
            // aTerraDataGridViewTextBoxColumn
            // 
            this.aTerraDataGridViewTextBoxColumn.DataPropertyName = "ATerra";
            this.aTerraDataGridViewTextBoxColumn.HeaderText = "Ava Terra.";
            this.aTerraDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.aTerraDataGridViewTextBoxColumn.Name = "aTerraDataGridViewTextBoxColumn";
            this.aTerraDataGridViewTextBoxColumn.Width = 40;
            // 
            // Ucalidades
            // 
            this.Ucalidades.DataPropertyName = "Ucalidades";
            this.Ucalidades.HeaderText = "U S Cal";
            this.Ucalidades.Name = "Ucalidades";
            this.Ucalidades.Width = 50;
            // 
            // PModulo
            // 
            this.PModulo.DataPropertyName = "PModulo";
            this.PModulo.HeaderText = "Pres. Modulo";
            this.PModulo.MaxInputLength = 4;
            this.PModulo.Name = "PModulo";
            this.PModulo.Width = 45;
            // 
            // AModulo
            // 
            this.AModulo.DataPropertyName = "AModulo";
            this.AModulo.HeaderText = "Ava Modulo";
            this.AModulo.MaxInputLength = 4;
            this.AModulo.Name = "AModulo";
            this.AModulo.Width = 45;
            // 
            // UModulos
            // 
            this.UModulos.DataPropertyName = "UModulos";
            this.UModulos.HeaderText = "U S Mod";
            this.UModulos.Name = "UModulos";
            this.UModulos.Width = 50;
            // 
            // sqlComInserta
            // 
            this.sqlComInserta.CommandText = "insertAvance";
            this.sqlComInserta.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComInserta.Connection = this.sqlConn;
            this.sqlComInserta.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // sqlComAgrega
            // 
            this.sqlComAgrega.CommandText = "[agregaconcentra]";
            this.sqlComAgrega.CommandTimeout = 60;
            this.sqlComAgrega.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComAgrega.Connection = this.sqlConn;
            this.sqlComAgrega.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdObram", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // sqlComActualiza
            // 
            this.sqlComActualiza.CommandText = "ActualizaAvance";
            this.sqlComActualiza.CommandTimeout = 240;
            this.sqlComActualiza.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComActualiza.Connection = this.sqlConn;
            this.sqlComActualiza.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdObraN", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // sqlComUpdate
            // 
            this.sqlComUpdate.CommandText = "ActualizaAvance";
            this.sqlComUpdate.CommandTimeout = 240;
            this.sqlComUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComUpdate.Connection = this.sqlConn;
            this.sqlComUpdate.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdObraN", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // Avance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 509);
            this.Controls.Add(this.dgvAvance);
            this.Controls.Add(this.panel1);
            this.Name = "Avance";
            this.Text = "Avance";
            this.Load += new System.EventHandler(this.Avance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAvance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection sqlConn;
        private dsObra dsObra1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAObras;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAAvance;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private dsAvance dsAvance1;
        private System.Windows.Forms.DataGridView dgvAvance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Data.SqlClient.SqlCommand sqlComInserta;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Data.SqlClient.SqlCommand sqlComAgrega;
        private System.Data.SqlClient.SqlCommand sqlComActualiza;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn2;
        private System.Data.SqlClient.SqlCommand sqlComUpdate;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdObraM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obra;
        private System.Windows.Forms.DataGridViewTextBoxColumn presupuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noEcoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAceroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aAceroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAB;
        private System.Windows.Forms.DataGridViewTextBoxColumn AAB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn AAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PConector;
        private System.Windows.Forms.DataGridViewTextBoxColumn AConector;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAF;
        private System.Windows.Forms.DataGridViewTextBoxColumn AAF;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAcero;
        private System.Windows.Forms.DataGridViewTextBoxColumn incioPrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPrefaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPrefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPrefaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMorteroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMorteroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UMortero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acalas;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCalas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAzfaltoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aAzfaltoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAgregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aAgregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTerraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTerraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn PModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UModulos;
    }
}