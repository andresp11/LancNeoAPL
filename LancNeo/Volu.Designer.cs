namespace LancNeo
{
    partial class Volu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Volu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.sqlDAVolumetrico = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDALaboratorista = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsVolumetrico1 = new LancNeo.dsVolumetrico();
            this.dsLaboratorio1 = new LancNeo.dsLaboratorio();
            this.sqlDALaboratorio = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAVolRes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsTiPr1 = new LancNeo.dsTiPr();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dtpFEnsaye = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObserva = new System.Windows.Forms.TextBox();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.cmbNoeco = new System.Windows.Forms.ComboBox();
            this.dtpFinforme = new System.Windows.Forms.DateTimePicker();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgVolum = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLaboratorio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipoprueba = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Masa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Optimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pruebaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLaboratorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopruebaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVolumetrico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiPr1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVolum)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 455);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(800, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(800, 64);
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsLaboratorista1
            // 
            this.dsLaboratorista1.DataSetName = "dsLaboratorista";
            this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAVolumetrico
            // 
            this.sqlDAVolumetrico.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAVolumetrico.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAVolumetrico.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAVolumetrico.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Volumetrico", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
                        new System.Data.Common.DataColumnMapping("FEnsaye", "FEnsaye")})});
            this.sqlDAVolumetrico.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FEnsaye", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FEnsaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Finforme", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 512, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Volumetrico(FOLIO, IdObra, ConsObra, Finforme, NoEco, Semana, Observa" +
    "ciones, FEnsaye) VALUES (@FOLIO, @IdObra, @ConsObra, @Finforme, @NoEco, @Semana," +
    " @Observaciones, @FEnsaye)";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 2, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@Finforme", System.Data.SqlDbType.DateTime, 4, "Finforme"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 2, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 512, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@FEnsaye", System.Data.SqlDbType.DateTime, 4, "FEnsaye")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 2, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@Finforme", System.Data.SqlDbType.DateTime, 4, "Finforme"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 2, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 512, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@FEnsaye", System.Data.SqlDbType.DateTime, 4, "FEnsaye"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FEnsaye", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FEnsaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Finforme", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 512, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDALaboratorista
            // 
            this.sqlDALaboratorista.SelectCommand = this.sqlSelectCommand5;
            this.sqlDALaboratorista.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorista", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Laboratorista", "Laboratorista"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("IdNivel", "IdNivel"),
                        new System.Data.Common.DataColumnMapping("Fechai", "Fechai")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT NoEco, LTRIM(STR(NoEco)) + \' \' + Laboratorista AS Laboratorista, IdZona, I" +
    "dNivel, Fechai FROM Laboratorista ORDER BY NoEco";
            this.sqlSelectCommand5.Connection = this.sqlConn;
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
            this.sqlCommand1.CommandText = "SELECT Obra.Idobra, Obra.Ubicacion, Obra.RFC, Razonsocial.Facturar FROM Obra LEFT" +
    " OUTER JOIN Razonsocial ON Obra.IdCliente = Razonsocial.IdCliente AND Obra.RFC =" +
    " Razonsocial.RFC ORDER BY Obra.Idobra";
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // dsVolumetrico1
            // 
            this.dsVolumetrico1.DataSetName = "dsVolumetrico";
            this.dsVolumetrico1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsVolumetrico1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsLaboratorio1
            // 
            this.dsLaboratorio1.DataSetName = "dsLaboratorio";
            this.dsLaboratorio1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDALaboratorio
            // 
            this.sqlDALaboratorio.SelectCommand = this.sqlSelectCommand4;
            this.sqlDALaboratorio.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorio", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT IdLaboratorio, Laboratorio, IdZona FROM Laboratorio ORDER BY IdLaboratorio" +
    ", Laboratorio";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            // 
            // sqlDAVolRes
            // 
            this.sqlDAVolRes.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDAVolRes.InsertCommand = this.sqlInsertCommand2;
            this.sqlDAVolRes.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAVolRes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "VolumetricoRes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba"),
                        new System.Data.Common.DataColumnMapping("FECHA", "FECHA"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Material", "Material"),
                        new System.Data.Common.DataColumnMapping("Tipoprueba", "Tipoprueba"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("Optimo", "Optimo")})});
            this.sqlDAVolRes.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Prueba", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prueba", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FECHA", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FECHA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Material", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Optimo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Optimo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tipoprueba", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipoprueba", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Prueba", System.Data.SqlDbType.VarChar, 10, "Prueba"),
            new System.Data.SqlClient.SqlParameter("@FECHA", System.Data.SqlDbType.DateTime, 4, "FECHA"),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@Material", System.Data.SqlDbType.VarChar, 50, "Material"),
            new System.Data.SqlClient.SqlParameter("@Tipoprueba", System.Data.SqlDbType.VarChar, 10, "Tipoprueba"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Optimo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Optimo", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT FOLIO, Prueba, FECHA, IdLaboratorio, Material, Tipoprueba, Masa, Optimo FR" +
    "OM VolumetricoRes WHERE (FOLIO = @Folio) ORDER BY FOLIO";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.VarChar, 10, "FOLIO")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Prueba", System.Data.SqlDbType.VarChar, 10, "Prueba"),
            new System.Data.SqlClient.SqlParameter("@FECHA", System.Data.SqlDbType.DateTime, 4, "FECHA"),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@Material", System.Data.SqlDbType.VarChar, 50, "Material"),
            new System.Data.SqlClient.SqlParameter("@Tipoprueba", System.Data.SqlDbType.VarChar, 10, "Tipoprueba"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Optimo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Optimo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Prueba", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prueba", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FECHA", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FECHA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Material", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Optimo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Optimo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tipoprueba", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipoprueba", System.Data.DataRowVersion.Original, null)});
            // 
            // dsTiPr1
            // 
            this.dsTiPr1.DataSetName = "dsTiPr";
            this.dsTiPr1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.label59);
            this.panel2.Controls.Add(this.dtpFEnsaye);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtObserva);
            this.panel2.Controls.Add(this.txtSemana);
            this.panel2.Controls.Add(this.cmbNoeco);
            this.panel2.Controls.Add(this.dtpFinforme);
            this.panel2.Controls.Add(this.txtConsecutivo);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.txtFolio);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 136);
            this.panel2.TabIndex = 5;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsVolumetrico1.Volumetrico;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(208, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 34;
            // 
            // dtpFEnsaye
            // 
            this.dtpFEnsaye.CustomFormat = "dd/MM/yyyy";
            this.dtpFEnsaye.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.FEnsaye", true));
            this.dtpFEnsaye.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFEnsaye.Location = new System.Drawing.Point(560, 8);
            this.dtpFEnsaye.Name = "dtpFEnsaye";
            this.dtpFEnsaye.Size = new System.Drawing.Size(84, 20);
            this.dtpFEnsaye.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(472, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha muestreo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObserva
            // 
            this.txtObserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.Observaciones", true));
            this.txtObserva.Location = new System.Drawing.Point(376, 56);
            this.txtObserva.MaxLength = 512;
            this.txtObserva.Multiline = true;
            this.txtObserva.Name = "txtObserva";
            this.txtObserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObserva.Size = new System.Drawing.Size(394, 68);
            this.txtObserva.TabIndex = 10;
            this.txtObserva.Text = "textBox5";
            // 
            // txtSemana
            // 
            this.txtSemana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.Semana", true));
            this.txtSemana.Location = new System.Drawing.Point(117, 80);
            this.txtSemana.MaxLength = 2;
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(66, 20);
            this.txtSemana.TabIndex = 4;
            this.txtSemana.Text = "textBox3";
            // 
            // cmbNoeco
            // 
            this.cmbNoeco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsVolumetrico1, "Volumetrico.NoEco", true));
            this.cmbNoeco.DataSource = this.dsLaboratorista1.Laboratorista;
            this.cmbNoeco.DisplayMember = "Laboratorista";
            this.cmbNoeco.ItemHeight = 13;
            this.cmbNoeco.Location = new System.Drawing.Point(376, 32);
            this.cmbNoeco.Name = "cmbNoeco";
            this.cmbNoeco.Size = new System.Drawing.Size(392, 21);
            this.cmbNoeco.TabIndex = 7;
            this.cmbNoeco.ValueMember = "NoEco";
            // 
            // dtpFinforme
            // 
            this.dtpFinforme.CustomFormat = "dd/MM/yyyy";
            this.dtpFinforme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.Finforme", true));
            this.dtpFinforme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinforme.Location = new System.Drawing.Point(376, 8);
            this.dtpFinforme.Name = "dtpFinforme";
            this.dtpFinforme.Size = new System.Drawing.Size(84, 20);
            this.dtpFinforme.TabIndex = 5;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.ConsObra", true));
            this.txtConsecutivo.Location = new System.Drawing.Point(117, 56);
            this.txtConsecutivo.MaxLength = 4;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(66, 20);
            this.txtConsecutivo.TabIndex = 3;
            this.txtConsecutivo.Text = "textBox2";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsVolumetrico1, "Volumetrico.IdObra", true));
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.ItemHeight = 13;
            this.cmbIdObra.Location = new System.Drawing.Point(117, 32);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 2;
            this.cmbIdObra.ValueMember = "Obra.Idobra";
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(117, 8);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(64, 20);
            this.txtFolio.TabIndex = 1;
            this.txtFolio.Text = "textBox1";
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(285, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Observaciones:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(54, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Semana:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(291, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ensayado por:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(288, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha informe:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(34, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Consecutivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(72, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Obra:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(63, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgVolum
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgVolum.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVolum.AutoGenerateColumns = false;
            this.dgVolum.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgVolum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVolum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.FECHA,
            this.Prueba,
            this.IdLaboratorio,
            this.Material,
            this.Tipoprueba,
            this.Masa,
            this.Optimo,
            this.fOLIODataGridViewTextBoxColumn,
            this.pruebaDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.idLaboratorioDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.tipopruebaDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.optimoDataGridViewTextBoxColumn});
            this.dgVolum.DataMember = "Volumetrico.VolumetricoVolumetricoRes";
            this.dgVolum.DataSource = this.dsVolumetrico1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVolum.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgVolum.Location = new System.Drawing.Point(8, 213);
            this.dgVolum.Name = "dgVolum";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVolum.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgVolum.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgVolum.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgVolum.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgVolum.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgVolum.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgVolum.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgVolum.Size = new System.Drawing.Size(784, 211);
            this.dgVolum.TabIndex = 7;
            // 
            // Folio
            // 
            this.Folio.DataPropertyName = "FOLIO";
            this.Folio.Frozen = true;
            this.Folio.HeaderText = "Folio";
            this.Folio.MaxInputLength = 0;
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            this.Folio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Folio.Width = 5;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle2;
            this.FECHA.Frozen = true;
            this.FECHA.HeaderText = "Fecha ensaye";
            this.FECHA.MaxInputLength = 10;
            this.FECHA.Name = "FECHA";
            this.FECHA.Width = 75;
            // 
            // Prueba
            // 
            this.Prueba.DataPropertyName = "Prueba";
            this.Prueba.Frozen = true;
            this.Prueba.HeaderText = "No. de prueba";
            this.Prueba.MaxInputLength = 10;
            this.Prueba.Name = "Prueba";
            this.Prueba.Width = 80;
            // 
            // IdLaboratorio
            // 
            this.IdLaboratorio.DataPropertyName = "IdLaboratorio";
            this.IdLaboratorio.DataSource = this.dsLaboratorio1;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            this.IdLaboratorio.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdLaboratorio.DisplayMember = "Laboratorio.IdLaboratorio";
            this.IdLaboratorio.Frozen = true;
            this.IdLaboratorio.HeaderText = "IdLaboratorio";
            this.IdLaboratorio.Name = "IdLaboratorio";
            this.IdLaboratorio.ValueMember = "Laboratorio.IdLaboratorio";
            this.IdLaboratorio.Width = 72;
            // 
            // Material
            // 
            this.Material.DataPropertyName = "Material";
            this.Material.Frozen = true;
            this.Material.HeaderText = "Material";
            this.Material.MaxInputLength = 50;
            this.Material.Name = "Material";
            this.Material.Width = 280;
            // 
            // Tipoprueba
            // 
            this.Tipoprueba.DataPropertyName = "Tipoprueba";
            this.Tipoprueba.DataSource = this.dsTiPr1;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            this.Tipoprueba.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tipoprueba.DisplayMember = "DataTable1.Prueba";
            this.Tipoprueba.Frozen = true;
            this.Tipoprueba.HeaderText = "Tipo de prueba";
            this.Tipoprueba.Name = "Tipoprueba";
            this.Tipoprueba.ValueMember = "DataTable1.Tipo";
            this.Tipoprueba.Width = 80;
            // 
            // Masa
            // 
            this.Masa.DataPropertyName = "Masa";
            this.Masa.Frozen = true;
            this.Masa.HeaderText = "masa";
            this.Masa.MaxInputLength = 10;
            this.Masa.Name = "Masa";
            this.Masa.Width = 55;
            // 
            // Optimo
            // 
            this.Optimo.DataPropertyName = "Optimo";
            this.Optimo.Frozen = true;
            this.Optimo.HeaderText = "Contenido optimo";
            this.Optimo.Name = "Optimo";
            this.Optimo.Width = 120;
            // 
            // fOLIODataGridViewTextBoxColumn
            // 
            this.fOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.Name = "fOLIODataGridViewTextBoxColumn";
            // 
            // pruebaDataGridViewTextBoxColumn
            // 
            this.pruebaDataGridViewTextBoxColumn.DataPropertyName = "Prueba";
            this.pruebaDataGridViewTextBoxColumn.HeaderText = "Prueba";
            this.pruebaDataGridViewTextBoxColumn.Name = "pruebaDataGridViewTextBoxColumn";
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            // 
            // idLaboratorioDataGridViewTextBoxColumn
            // 
            this.idLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "IdLaboratorio";
            this.idLaboratorioDataGridViewTextBoxColumn.HeaderText = "IdLaboratorio";
            this.idLaboratorioDataGridViewTextBoxColumn.Name = "idLaboratorioDataGridViewTextBoxColumn";
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            // 
            // tipopruebaDataGridViewTextBoxColumn
            // 
            this.tipopruebaDataGridViewTextBoxColumn.DataPropertyName = "Tipoprueba";
            this.tipopruebaDataGridViewTextBoxColumn.HeaderText = "Tipoprueba";
            this.tipopruebaDataGridViewTextBoxColumn.Name = "tipopruebaDataGridViewTextBoxColumn";
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            // 
            // optimoDataGridViewTextBoxColumn
            // 
            this.optimoDataGridViewTextBoxColumn.DataPropertyName = "Optimo";
            this.optimoDataGridViewTextBoxColumn.HeaderText = "Optimo";
            this.optimoDataGridViewTextBoxColumn.Name = "optimoDataGridViewTextBoxColumn";
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.IdUsuario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(294, 104);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 70;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Red;
            this.label59.Location = new System.Drawing.Point(233, 108);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(54, 13);
            this.label59.TabIndex = 69;
            this.label59.Text = "Usuario:";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Volu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.dgVolum);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAVolumetrico;
            this.dsGeneral = this.dsVolumetrico1;
            this.Name = "Volu";
            this.NombreTabla = "Volumetrico";
            this.Text = "Volu";
            this.Load += new System.EventHandler(this.Volu_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgVolum, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVolumetrico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiPr1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVolum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private dsBusObra dsBusObra1;
        private dsLaboratorista dsLaboratorista1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAVolumetrico;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorista;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private dsVolumetrico dsVolumetrico1;
        private dsLaboratorio dsLaboratorio1;
        private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorio;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        public System.Data.SqlClient.SqlDataAdapter sqlDAVolRes;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private dsTiPr dsTiPr1;
        private System.Windows.Forms.Panel panel2;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.DateTimePicker dtpFEnsaye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObserva;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.ComboBox cmbNoeco;
        private System.Windows.Forms.DateTimePicker dtpFinforme;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgVolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueba;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipoprueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Optimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pruebaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLaboratorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopruebaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtUsrMov;
        private System.Windows.Forms.Label label59;
    }
}