namespace LancNeo
{
    partial class Nucleo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nucleo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDANucleoMdor = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDANucleoMue = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusNucleo1 = new LancNeo.dsBusNucleo();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dsNucleo1 = new LancNeo.dsNucleo();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dsLaboratorio1 = new LancNeo.dsLaboratorio();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.txtIdObra = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.lblIdObra = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtObserva = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dsAgregado1 = new LancNeo.dsAgregado();
            this.txtNE = new System.Windows.Forms.TextBox();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusq = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDANoEco = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsResistencia1 = new LancNeo.dsResistencia();
            this.sqlDAFecha = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand12 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATAgregado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATipo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand11 = new System.Data.SqlClient.SqlCommand();
            this.dsTipo1 = new LancNeo.dsTipo();
            this.dsFechaM1 = new LancNeo.dsFechaM();
            this.dgMuestras = new System.Windows.Forms.DataGridView();
            this.sqlDALaboratorio = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEspecimenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAgregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diametroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resisCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNucleo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNucleo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResistencia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFechaM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuestras)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 602);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1368, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(1368, 64);
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDANucleoMdor
            // 
            this.sqlDANucleoMdor.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDANucleoMdor.InsertCommand = this.sqlInsertCommand1;
            this.sqlDANucleoMdor.SelectCommand = this.sqlSelectCommand1;
            this.sqlDANucleoMdor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "NucleoMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("FechaM", "FechaM"),
                        new System.Data.Common.DataColumnMapping("FechaE", "FechaE"),
                        new System.Data.Common.DataColumnMapping("FechaR", "FechaR"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Temperatura", "Temperatura"),
                        new System.Data.Common.DataColumnMapping("Humedad", "Humedad"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDANucleoMdor.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Folio", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FechaM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FechaM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FechaM", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FechaE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FechaE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FechaE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FechaR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FechaR", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FechaR", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaR", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdLaboratorio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Temperatura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Temperatura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Temperatura", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Temperatura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Humedad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Humedad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Humedad", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Humedad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.NChar, 0, "Folio"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@FechaM", System.Data.SqlDbType.DateTime, 0, "FechaM"),
            new System.Data.SqlClient.SqlParameter("@FechaE", System.Data.SqlDbType.DateTime, 0, "FechaE"),
            new System.Data.SqlClient.SqlParameter("@FechaR", System.Data.SqlDbType.DateTime, 0, "FechaR"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@Temperatura", System.Data.SqlDbType.Real, 0, "Temperatura"),
            new System.Data.SqlClient.SqlParameter("@Humedad", System.Data.SqlDbType.Real, 0, "Humedad"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.NChar, 0, "Folio"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@FechaM", System.Data.SqlDbType.DateTime, 0, "FechaM"),
            new System.Data.SqlClient.SqlParameter("@FechaE", System.Data.SqlDbType.DateTime, 0, "FechaE"),
            new System.Data.SqlClient.SqlParameter("@FechaR", System.Data.SqlDbType.DateTime, 0, "FechaR"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@Temperatura", System.Data.SqlDbType.Real, 0, "Temperatura"),
            new System.Data.SqlClient.SqlParameter("@Humedad", System.Data.SqlDbType.Real, 0, "Humedad"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Folio", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FechaM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FechaM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FechaM", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FechaE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FechaE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FechaE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FechaR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FechaR", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FechaR", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaR", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdLaboratorio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Temperatura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Temperatura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Temperatura", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Temperatura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Humedad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Humedad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Humedad", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Humedad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDANucleoMue
            // 
            this.sqlDANucleoMue.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDANucleoMue.InsertCommand = this.sqlInsertCommand2;
            this.sqlDANucleoMue.SelectCommand = this.sqlSelectCommand2;
            this.sqlDANucleoMue.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "NucleoMue", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("IdEspecimen", "IdEspecimen"),
                        new System.Data.Common.DataColumnMapping("FechaC", "FechaC"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("ResEE", "ResEE"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("MasaV", "MasaV"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro"),
                        new System.Data.Common.DataColumnMapping("AlturaA", "AlturaA"),
                        new System.Data.Common.DataColumnMapping("AlturaD", "AlturaD"),
                        new System.Data.Common.DataColumnMapping("Rel", "Rel"),
                        new System.Data.Common.DataColumnMapping("ResisC", "ResisC"),
                        new System.Data.Common.DataColumnMapping("Falla", "Falla"),
                        new System.Data.Common.DataColumnMapping("Edad", "Edad"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDANucleoMue.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Folio", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdEspecimen", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEspecimen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FechaC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FechaC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FechaC", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ResistenciaKG", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ResistenciaKG", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaKG", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaKG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Agregado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Agregado", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Revenimento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Revenimento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Revenimento", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Revenimento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdAgregado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdAgregado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdAgregado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdAgregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Muestra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ResEE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ResEE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ResEE", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResEE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Elemento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Elemento", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ejes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ejes", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ejes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ejes", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nivel", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edif", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edif", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edif", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edif", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Direccion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MasaV", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MasaV", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MasaV", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasaV", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diametro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diametro", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AlturaA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AlturaA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AlturaA", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AlturaA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AlturaD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AlturaD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AlturaD", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AlturaD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Rel", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Rel", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Rel", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ResisC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ResisC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ResisC", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResisC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Falla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Falla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Falla", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Falla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.NChar, 0, "Folio"),
            new System.Data.SqlClient.SqlParameter("@IdEspecimen", System.Data.SqlDbType.SmallInt, 0, "IdEspecimen"),
            new System.Data.SqlClient.SqlParameter("@FechaC", System.Data.SqlDbType.SmallDateTime, 0, "FechaC"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Real, 0, "ResistenciaKG"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 0, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Real, 0, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Revenimento", System.Data.SqlDbType.Real, 0, "Revenimento"),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 0, "IdAgregado"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 0, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@ResEE", System.Data.SqlDbType.Real, 0, "ResEE"),
            new System.Data.SqlClient.SqlParameter("@Elemento", System.Data.SqlDbType.NVarChar, 0, "Elemento"),
            new System.Data.SqlClient.SqlParameter("@Ejes", System.Data.SqlDbType.NVarChar, 0, "Ejes"),
            new System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.NVarChar, 0, "Nivel"),
            new System.Data.SqlClient.SqlParameter("@Edif", System.Data.SqlDbType.NVarChar, 0, "Edif"),
            new System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 0, "Direccion"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Real, 0, "Masa"),
            new System.Data.SqlClient.SqlParameter("@MasaV", System.Data.SqlDbType.Real, 0, "MasaV"),
            new System.Data.SqlClient.SqlParameter("@Diametro", System.Data.SqlDbType.Real, 0, "Diametro"),
            new System.Data.SqlClient.SqlParameter("@AlturaA", System.Data.SqlDbType.Real, 0, "AlturaA"),
            new System.Data.SqlClient.SqlParameter("@AlturaD", System.Data.SqlDbType.Real, 0, "AlturaD"),
            new System.Data.SqlClient.SqlParameter("@Rel", System.Data.SqlDbType.Real, 0, "Rel"),
            new System.Data.SqlClient.SqlParameter("@ResisC", System.Data.SqlDbType.Real, 0, "ResisC"),
            new System.Data.SqlClient.SqlParameter("@Falla", System.Data.SqlDbType.Real, 0, "Falla"),
            new System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.SmallInt, 0, "Edad"),
            new System.Data.SqlClient.SqlParameter("@Observa", System.Data.SqlDbType.NText, 0, "Observa"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario")});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.NChar, 0, "Folio"),
            new System.Data.SqlClient.SqlParameter("@IdEspecimen", System.Data.SqlDbType.SmallInt, 0, "IdEspecimen"),
            new System.Data.SqlClient.SqlParameter("@FechaC", System.Data.SqlDbType.SmallDateTime, 0, "FechaC"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Real, 0, "ResistenciaKG"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 0, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Real, 0, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Revenimento", System.Data.SqlDbType.Real, 0, "Revenimento"),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 0, "IdAgregado"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 0, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@ResEE", System.Data.SqlDbType.Real, 0, "ResEE"),
            new System.Data.SqlClient.SqlParameter("@Elemento", System.Data.SqlDbType.NVarChar, 0, "Elemento"),
            new System.Data.SqlClient.SqlParameter("@Ejes", System.Data.SqlDbType.NVarChar, 0, "Ejes"),
            new System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.NVarChar, 0, "Nivel"),
            new System.Data.SqlClient.SqlParameter("@Edif", System.Data.SqlDbType.NVarChar, 0, "Edif"),
            new System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 0, "Direccion"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Real, 0, "Masa"),
            new System.Data.SqlClient.SqlParameter("@MasaV", System.Data.SqlDbType.Real, 0, "MasaV"),
            new System.Data.SqlClient.SqlParameter("@Diametro", System.Data.SqlDbType.Real, 0, "Diametro"),
            new System.Data.SqlClient.SqlParameter("@AlturaA", System.Data.SqlDbType.Real, 0, "AlturaA"),
            new System.Data.SqlClient.SqlParameter("@AlturaD", System.Data.SqlDbType.Real, 0, "AlturaD"),
            new System.Data.SqlClient.SqlParameter("@Rel", System.Data.SqlDbType.Real, 0, "Rel"),
            new System.Data.SqlClient.SqlParameter("@ResisC", System.Data.SqlDbType.Real, 0, "ResisC"),
            new System.Data.SqlClient.SqlParameter("@Falla", System.Data.SqlDbType.Real, 0, "Falla"),
            new System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.SmallInt, 0, "Edad"),
            new System.Data.SqlClient.SqlParameter("@Observa", System.Data.SqlDbType.NText, 0, "Observa"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Folio", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdEspecimen", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEspecimen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FechaC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FechaC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FechaC", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ResistenciaKG", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ResistenciaKG", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaKG", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaKG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Agregado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Agregado", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Revenimento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Revenimento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Revenimento", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Revenimento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdAgregado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdAgregado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdAgregado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdAgregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Muestra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ResEE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ResEE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ResEE", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResEE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Elemento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Elemento", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ejes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ejes", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ejes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ejes", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nivel", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edif", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edif", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edif", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edif", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Direccion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MasaV", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MasaV", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MasaV", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasaV", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diametro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diametro", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AlturaA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AlturaA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AlturaA", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AlturaA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AlturaD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AlturaD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AlturaD", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AlturaD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Rel", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Rel", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Rel", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ResisC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ResisC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ResisC", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResisC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Falla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Falla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Falla", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Falla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbBtn1);
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtMuestra);
            this.panel2.Controls.Add(this.txtSemana);
            this.panel2.Controls.Add(this.txtIdObra);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.lblIdObra);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.txtObserva);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 128);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(112, 57);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 56;
            this.tbBtn1.Visible = false;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusNucleo1.NucleoMdor;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(108, -2);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Load += new System.EventHandler(this.buscaBtn1_Load);
            // 
            // dsBusNucleo1
            // 
            this.dsBusNucleo1.DataSetName = "dsBusNucleo";
            this.dsBusNucleo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNucleo1, "NucleoMdor.Temperatura", true));
            this.textBox3.Location = new System.Drawing.Point(745, 31);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 20);
            this.textBox3.TabIndex = 73;
            this.textBox3.Text = "textBox1";
            // 
            // dsNucleo1
            // 
            this.dsNucleo1.DataSetName = "dsNucleo";
            this.dsNucleo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(676, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "Temperatura:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNucleo1, "NucleoMdor.Humedad", true));
            this.textBox2.Location = new System.Drawing.Point(622, 31);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 20);
            this.textBox2.TabIndex = 71;
            this.textBox2.Text = "textBox1";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsNucleo1, "NucleoMdor.IdLaboratorio", true));
            this.comboBox2.DataSource = this.dsLaboratorio1;
            this.comboBox2.DisplayMember = "Laboratorio.IdLaboratorio";
            this.comboBox2.Location = new System.Drawing.Point(501, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(66, 21);
            this.comboBox2.TabIndex = 69;
            this.comboBox2.Tag = "ACE";
            this.comboBox2.ValueMember = "Laboratorio.IdLaboratorio";
            // 
            // dsLaboratorio1
            // 
            this.dsLaboratorio1.DataSetName = "dsLaboratorio";
            this.dsLaboratorio1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsNucleo1, "NucleoMdor.NoEco", true));
            this.comboBox1.DataSource = this.dsLaboratorista1;
            this.comboBox1.DisplayMember = "Laboratorista.NoEco";
            this.comboBox1.Location = new System.Drawing.Point(371, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 21);
            this.comboBox1.TabIndex = 67;
            this.comboBox1.Tag = "ACE";
            this.comboBox1.ValueMember = "Laboratorista.NoEco";
            // 
            // dsLaboratorista1
            // 
            this.dsLaboratorista1.DataSetName = "dsLaboratorista";
            this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "No Eco:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNucleo1, "NucleoMdor.Folio", true));
            this.textBox1.Location = new System.Drawing.Point(191, 31);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(259, 5);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fechas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yy";
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNucleo1, "NucleoMdor.FechaR", true));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(622, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(72, 20);
            this.dateTimePicker2.TabIndex = 64;
            this.dateTimePicker2.Value = new System.DateTime(2004, 8, 13, 0, 0, 0, 0);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd-MM-yy";
            this.dtpFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNucleo1, "NucleoMdor.FechaM", true));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(371, 6);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.ShowUpDown = true;
            this.dtpFecha.Size = new System.Drawing.Size(72, 20);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Value = new System.DateTime(2004, 8, 13, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yy";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNucleo1, "NucleoMdor.FechaE", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(501, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(72, 20);
            this.dateTimePicker1.TabIndex = 62;
            this.dateTimePicker1.Value = new System.DateTime(2004, 8, 13, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(301, 5);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 61;
            this.label3.Text = "Muestreo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUser
            // 
            this.txtUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNucleo1, "NucleoMdor.IdUsuario", true));
            this.txtUser.Location = new System.Drawing.Point(833, 6);
            this.txtUser.MaxLength = 2;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(46, 20);
            this.txtUser.TabIndex = 59;
            this.txtUser.Text = "textBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(785, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Muestra:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Visible = false;
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(49, 86);
            this.txtMuestra.MaxLength = 6;
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(32, 20);
            this.txtMuestra.TabIndex = 57;
            this.txtMuestra.Text = "1";
            this.txtMuestra.Visible = false;
            // 
            // txtSemana
            // 
            this.txtSemana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNucleo1, "NucleoMdor.Semana", true));
            this.txtSemana.Location = new System.Drawing.Point(745, 6);
            this.txtSemana.MaxLength = 2;
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(32, 20);
            this.txtSemana.TabIndex = 5;
            this.txtSemana.Text = "textBox1";
            // 
            // txtIdObra
            // 
            this.txtIdObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNucleo1, "NucleoMdor.IdObra", true));
            this.txtIdObra.Location = new System.Drawing.Point(120, 14);
            this.txtIdObra.Name = "txtIdObra";
            this.txtIdObra.Size = new System.Drawing.Size(48, 20);
            this.txtIdObra.TabIndex = 40;
            this.txtIdObra.Text = "textBox1";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(40, 6);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.Tag = "ACE";
            this.cmbIdObra.ValueMember = "Obra.Idobra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsNucleo";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIdObra
            // 
            this.lblIdObra.AutoSize = true;
            this.lblIdObra.Location = new System.Drawing.Point(0, 10);
            this.lblIdObra.Name = "lblIdObra";
            this.lblIdObra.Size = new System.Drawing.Size(42, 13);
            this.lblIdObra.TabIndex = 1;
            this.lblIdObra.Text = "IdObra:";
            this.lblIdObra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(220, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 13);
            this.label23.TabIndex = 38;
            this.label23.Text = "Observaciones:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObserva
            // 
            this.txtObserva.AcceptsReturn = true;
            this.txtObserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNucleo1, "NucleoMdor.Observaciones", true));
            this.txtObserva.Location = new System.Drawing.Point(220, 67);
            this.txtObserva.MaxLength = 255;
            this.txtObserva.Multiline = true;
            this.txtObserva.Name = "txtObserva";
            this.txtObserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObserva.Size = new System.Drawing.Size(661, 56);
            this.txtObserva.TabIndex = 19;
            this.txtObserva.Text = "textBox1";
            this.txtObserva.TextChanged += new System.EventHandler(this.txtObserva_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(697, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Semana:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(181, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Folio:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Laboratorio:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(448, 5);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 63;
            this.label4.Text = "Ensaye:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(570, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Humedad:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(578, 5);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 65;
            this.label5.Text = "Recibo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dsAgregado1
            // 
            this.dsAgregado1.DataSetName = "dsAgregado";
            this.dsAgregado1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAgregado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNE
            // 
            this.txtNE.Location = new System.Drawing.Point(926, 114);
            this.txtNE.Name = "txtNE";
            this.txtNE.Size = new System.Drawing.Size(86, 20);
            this.txtNE.TabIndex = 42;
            this.txtNE.Visible = false;
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
            // sqlDABusq
            // 
            this.sqlDABusq.SelectCommand = this.sqlSelectCommand4;
            this.sqlDABusq.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestreador", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlDANoEco
            // 
            this.sqlDANoEco.SelectCommand = this.sqlSelectCommand3;
            this.sqlDANoEco.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorista", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Laboratorista", "Laboratorista")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT NoEco, Laboratorista, IdZona, IdNivel, Fechai FROM Laboratorista ORDER BY " +
    "NoEco";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlDARes
            // 
            this.sqlDARes.SelectCommand = this.sqlSelectCommand7;
            this.sqlDARes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Resistencia", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("ResistenciaMPa", "ResistenciaMPa")})});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "SELECT ResistenciaKG, ResistenciaMPa FROM Resistencia ORDER BY ResistenciaKG";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // dsResistencia1
            // 
            this.dsResistencia1.DataSetName = "dsResistencia";
            this.dsResistencia1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsResistencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAFecha
            // 
            this.sqlDAFecha.SelectCommand = this.sqlSelectCommand12;
            this.sqlDAFecha.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestras", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha")})});
            // 
            // sqlSelectCommand12
            // 
            this.sqlSelectCommand12.CommandText = "SELECT        TOP (1) Fecha\r\nFROM            NucleoMue\r\nWHERE        (IdObra = @I" +
    "dObra) AND (Muestra = @Muestra)";
            this.sqlSelectCommand12.Connection = this.sqlConn;
            this.sqlSelectCommand12.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 4, "Muestra")});
            // 
            // sqlDATAgregado
            // 
            this.sqlDATAgregado.SelectCommand = this.sqlSelectCommand9;
            this.sqlDATAgregado.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Agregado", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo")})});
            // 
            // sqlSelectCommand9
            // 
            this.sqlSelectCommand9.CommandText = "SELECT IdAgregado, Agregado, Tipo FROM Agregado";
            this.sqlSelectCommand9.Connection = this.sqlConn;
            // 
            // sqlDATipo
            // 
            this.sqlDATipo.SelectCommand = this.sqlSelectCommand11;
            this.sqlDATipo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("DesTipo", "DesTipo")})});
            // 
            // sqlSelectCommand11
            // 
            this.sqlSelectCommand11.CommandText = "SELECT Tipo, DesTipo FROM Tipo ORDER BY Tipo";
            this.sqlSelectCommand11.Connection = this.sqlConn;
            // 
            // dsTipo1
            // 
            this.dsTipo1.DataSetName = "dsTipo";
            this.dsTipo1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsFechaM1
            // 
            this.dsFechaM1.DataSetName = "dsFechaM";
            this.dsFechaM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgMuestras
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgMuestras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgMuestras.AutoGenerateColumns = false;
            this.dgMuestras.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMuestras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMuestras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.folioDataGridViewTextBoxColumn,
            this.idEspecimenDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.tipoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.idAgregadoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.ResEE,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.direccionDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.MasaV,
            this.diametroDataGridViewTextBoxColumn,
            this.alturaADataGridViewTextBoxColumn,
            this.alturaDDataGridViewTextBoxColumn,
            this.relDataGridViewTextBoxColumn,
            this.resisCDataGridViewTextBoxColumn,
            this.fallaDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn11,
            this.idUsuarioDataGridViewTextBoxColumn});
            this.dgMuestras.DataMember = "NucleoMdor.NucleoMdor_NucleoMue";
            this.dgMuestras.DataSource = this.dsNucleo1;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMuestras.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgMuestras.Location = new System.Drawing.Point(8, 204);
            this.dgMuestras.Name = "dgMuestras";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMuestras.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgMuestras.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgMuestras.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMuestras.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgMuestras.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgMuestras.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgMuestras.Size = new System.Drawing.Size(1354, 272);
            this.dgMuestras.TabIndex = 43;
            this.dgMuestras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMuestras_CellContentClick);
            this.dgMuestras.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgMuestras_DefaultValuesNeeded);
            this.dgMuestras.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMuestras_RowEnter);
            this.dgMuestras.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMuestras_RowLeave);
            this.dgMuestras.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgMuestras_RowsAdded);
            // 
            // sqlDALaboratorio
            // 
            this.sqlDALaboratorio.SelectCommand = this.sqlCommand2;
            this.sqlDALaboratorio.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorio", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT IdLaboratorio, Laboratorio, IdZona FROM Laboratorio ORDER BY IdLaboratorio" +
    ", Laboratorio";
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdObra";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdObra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // folioDataGridViewTextBoxColumn
            // 
            this.folioDataGridViewTextBoxColumn.DataPropertyName = "Folio";
            this.folioDataGridViewTextBoxColumn.HeaderText = "Folio";
            this.folioDataGridViewTextBoxColumn.Name = "folioDataGridViewTextBoxColumn";
            this.folioDataGridViewTextBoxColumn.Visible = false;
            // 
            // idEspecimenDataGridViewTextBoxColumn
            // 
            this.idEspecimenDataGridViewTextBoxColumn.DataPropertyName = "IdEspecimen";
            this.idEspecimenDataGridViewTextBoxColumn.HeaderText = "Especimen";
            this.idEspecimenDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.idEspecimenDataGridViewTextBoxColumn.Name = "idEspecimenDataGridViewTextBoxColumn";
            this.idEspecimenDataGridViewTextBoxColumn.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FechaC";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha Colado";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ResistenciaKG";
            this.dataGridViewTextBoxColumn3.HeaderText = "Resistencia KG";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.DataSource = this.dsTipo1;
            this.tipoDataGridViewTextBoxColumn.DisplayMember = "Tipo.DesTipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipoDataGridViewTextBoxColumn.ValueMember = "Tipo.Tipo";
            this.tipoDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Agregado";
            this.dataGridViewTextBoxColumn4.HeaderText = "TMA";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 2;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Revenimento";
            this.dataGridViewTextBoxColumn5.HeaderText = "REV";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 2;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 30;
            // 
            // idAgregadoDataGridViewTextBoxColumn
            // 
            this.idAgregadoDataGridViewTextBoxColumn.DataPropertyName = "IdAgregado";
            this.idAgregadoDataGridViewTextBoxColumn.DataSource = this.dsAgregado1;
            this.idAgregadoDataGridViewTextBoxColumn.DisplayMember = "Agregado.Tipo";
            this.idAgregadoDataGridViewTextBoxColumn.HeaderText = "TA";
            this.idAgregadoDataGridViewTextBoxColumn.Name = "idAgregadoDataGridViewTextBoxColumn";
            this.idAgregadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idAgregadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idAgregadoDataGridViewTextBoxColumn.ValueMember = "Agregado.IdAgregado";
            this.idAgregadoDataGridViewTextBoxColumn.Width = 45;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Muestra";
            this.dataGridViewTextBoxColumn6.HeaderText = "Muestra";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 5;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 45;
            // 
            // ResEE
            // 
            this.ResEE.DataPropertyName = "ResEE";
            this.ResEE.HeaderText = "Resistencia Edad Esp";
            this.ResEE.MaxInputLength = 6;
            this.ResEE.Name = "ResEE";
            this.ResEE.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Elemento";
            this.dataGridViewTextBoxColumn7.HeaderText = "Elemento";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 110;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Ejes";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ejes";
            this.dataGridViewTextBoxColumn8.MaxInputLength = 135;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Nivel";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nivel";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 40;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Edif";
            this.dataGridViewTextBoxColumn10.HeaderText = "Edif";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 55;
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            this.masaDataGridViewTextBoxColumn.Width = 40;
            // 
            // MasaV
            // 
            this.MasaV.DataPropertyName = "MasaV";
            this.MasaV.HeaderText = "Masa Vol.";
            this.MasaV.MaxInputLength = 6;
            this.MasaV.Name = "MasaV";
            this.MasaV.Width = 40;
            // 
            // diametroDataGridViewTextBoxColumn
            // 
            this.diametroDataGridViewTextBoxColumn.DataPropertyName = "Diametro";
            this.diametroDataGridViewTextBoxColumn.HeaderText = "Diametro";
            this.diametroDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.diametroDataGridViewTextBoxColumn.Name = "diametroDataGridViewTextBoxColumn";
            this.diametroDataGridViewTextBoxColumn.Width = 45;
            // 
            // alturaADataGridViewTextBoxColumn
            // 
            this.alturaADataGridViewTextBoxColumn.DataPropertyName = "AlturaA";
            this.alturaADataGridViewTextBoxColumn.HeaderText = "Altura antes";
            this.alturaADataGridViewTextBoxColumn.MaxInputLength = 6;
            this.alturaADataGridViewTextBoxColumn.Name = "alturaADataGridViewTextBoxColumn";
            this.alturaADataGridViewTextBoxColumn.Width = 45;
            // 
            // alturaDDataGridViewTextBoxColumn
            // 
            this.alturaDDataGridViewTextBoxColumn.DataPropertyName = "AlturaD";
            this.alturaDDataGridViewTextBoxColumn.HeaderText = "Altura después";
            this.alturaDDataGridViewTextBoxColumn.Name = "alturaDDataGridViewTextBoxColumn";
            this.alturaDDataGridViewTextBoxColumn.Width = 45;
            // 
            // relDataGridViewTextBoxColumn
            // 
            this.relDataGridViewTextBoxColumn.DataPropertyName = "Rel";
            this.relDataGridViewTextBoxColumn.HeaderText = "Rel Alt/Diám";
            this.relDataGridViewTextBoxColumn.Name = "relDataGridViewTextBoxColumn";
            this.relDataGridViewTextBoxColumn.Width = 45;
            // 
            // resisCDataGridViewTextBoxColumn
            // 
            this.resisCDataGridViewTextBoxColumn.DataPropertyName = "ResisC";
            this.resisCDataGridViewTextBoxColumn.HeaderText = "Resistencia corregida";
            this.resisCDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.resisCDataGridViewTextBoxColumn.Name = "resisCDataGridViewTextBoxColumn";
            this.resisCDataGridViewTextBoxColumn.Width = 50;
            // 
            // fallaDataGridViewTextBoxColumn
            // 
            this.fallaDataGridViewTextBoxColumn.DataPropertyName = "Falla";
            this.fallaDataGridViewTextBoxColumn.HeaderText = "Tipo Falla";
            this.fallaDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.fallaDataGridViewTextBoxColumn.Name = "fallaDataGridViewTextBoxColumn";
            this.fallaDataGridViewTextBoxColumn.Width = 40;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.Width = 40;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Observa";
            this.dataGridViewTextBoxColumn11.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn11.MaxInputLength = 256;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.Width = 50;
            // 
            // Nucleo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1368, 624);
            this.Controls.Add(this.dgMuestras);
            this.Controls.Add(this.txtNE);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDANucleoMdor;
            this.dsGeneral = this.dsNucleo1;
            this.Name = "Nucleo";
            this.NombreTabla = "NucleoMdor";
            this.Text = "Nucleo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Nucleo_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.txtNE, 0);
            this.Controls.SetChildIndex(this.dgMuestras, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNucleo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNucleo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResistencia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFechaM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuestras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDANucleoMdor;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDANucleoMue;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Windows.Forms.Panel panel2;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.TextBox txtIdObra;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label lblIdObra;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtObserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private dsNucleo dsNucleo1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNE;
        private dsBusObra dsBusObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDABusq;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private dsBusNucleo dsBusNucleo1;
        private dsLaboratorista dsLaboratorista1;
        private System.Data.SqlClient.SqlDataAdapter sqlDANoEco;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlDataAdapter sqlDARes;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
        private dsResistencia dsResistencia1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAFecha;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand12;
        private System.Data.SqlClient.SqlDataAdapter sqlDATAgregado;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
        private dsAgregado dsAgregado1;
        private System.Data.SqlClient.SqlDataAdapter sqlDATipo;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand11;
        private dsTipo dsTipo1;
        private dsFechaM dsFechaM1;
        private System.Windows.Forms.DataGridView dgMuestras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn resistenciaKGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn agregadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TA;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private dsLaboratorio dsLaboratorio1;
        private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorio;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecimenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn idAgregadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasaV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diametroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resisCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
    }
}