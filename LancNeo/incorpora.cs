using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using Soluciones2000.Tools.WinLib;


namespace LancNeo
{
	/// <summary>
	/// Descripción breve de incorpora.
	/// </summary>
	public class incorpora :  CatalogoGenerico
	{
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label label2;
		private System.Data.SqlClient.SqlDataAdapter sqlDALab;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private LancNeo.dsLab dsLab1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAExternos;
		private LancNeo.dsExternos dsExternos1;
        private System.Windows.Forms.Panel panel1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnPROCESO;
        private System.Windows.Forms.TextBox txtIdObra;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idLaboratorioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idConcreteraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idPlantaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resistenciaMPaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agregadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revenimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn elementoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revObtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muestreadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resultadoa3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resultadoa7DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resultadoa7bisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resultadoa14bisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resultado1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resultado2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ensayadorDataGridViewTextBoxColumn;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public incorpora()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(incorpora));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPROCESO = new Soluciones2000.Tools.WinLib.tbBtn();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsLab1 = new LancNeo.dsLab();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdObra = new System.Windows.Forms.TextBox();
            this.dsExternos1 = new LancNeo.dsExternos();
            this.sqlDALab = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAExternos = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idLaboratorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConcreteraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlantaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistenciaMPaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revObtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestreadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoa3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoa7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoa7bisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoa14bisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ensayadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExternos1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 631);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(976, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(976, 64);
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnPROCESO);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIdObra);
            this.panel2.Location = new System.Drawing.Point(2, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 60);
            this.panel2.TabIndex = 5;
            // 
            // btnPROCESO
            // 
            this.btnPROCESO.BackColor = System.Drawing.Color.Transparent;
            this.btnPROCESO.Icon = ((System.Drawing.Icon)(resources.GetObject("btnPROCESO.Icon")));
            this.btnPROCESO.Location = new System.Drawing.Point(453, -4);
            this.btnPROCESO.Name = "btnPROCESO";
            this.btnPROCESO.Size = new System.Drawing.Size(64, 64);
            this.btnPROCESO.TabIndex = 22;
            this.btnPROCESO.Click += new System.EventHandler(this.btnPROCESO_Click);
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsLab1;
            this.cmbIdObra.DisplayMember = "Externos.Lab";
            this.cmbIdObra.ItemHeight = 13;
            this.cmbIdObra.Location = new System.Drawing.Point(130, 14);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(100, 21);
            this.cmbIdObra.TabIndex = 2;
            this.cmbIdObra.ValueMember = "Externos.IdLaboratorio";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // dsLab1
            // 
            this.dsLab1.DataSetName = "dsLab";
            this.dsLab1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLab1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(60, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Laboratorio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdObra
            // 
            this.txtIdObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsExternos1, "Externos.IdLaboratorio", true));
            this.txtIdObra.Location = new System.Drawing.Point(152, 16);
            this.txtIdObra.Name = "txtIdObra";
            this.txtIdObra.Size = new System.Drawing.Size(48, 20);
            this.txtIdObra.TabIndex = 23;
            this.txtIdObra.Text = "textBox1";
            // 
            // dsExternos1
            // 
            this.dsExternos1.DataSetName = "dsExternos";
            this.dsExternos1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsExternos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDALab
            // 
            this.sqlDALab.SelectCommand = this.sqlSelectCommand1;
            this.sqlDALab.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Externos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT DISTINCT IdLaboratorio AS Lab, IdLaboratorio FROM Externos ORDER BY IdLabo" +
                "ratorio";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlDAExternos
            // 
            this.sqlDAExternos.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAExternos.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAExternos.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAExternos.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Externos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaMPa", "ResistenciaMPa"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("Edad", "Edad"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("RevObt", "RevObt"),
                        new System.Data.Common.DataColumnMapping("Muestreador", "Muestreador"),
                        new System.Data.Common.DataColumnMapping("Resultadoa3", "Resultadoa3"),
                        new System.Data.Common.DataColumnMapping("Resultadoa7", "Resultadoa7"),
                        new System.Data.Common.DataColumnMapping("Resultadoa7bis", "Resultadoa7bis"),
                        new System.Data.Common.DataColumnMapping("Resultadoa14bis", "Resultadoa14bis"),
                        new System.Data.Common.DataColumnMapping("Resultado1", "Resultado1"),
                        new System.Data.Common.DataColumnMapping("Resultado2", "Resultado2"),
                        new System.Data.Common.DataColumnMapping("Ensayador", "Ensayador")})});
            this.sqlDAExternos.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Agregado", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Elemento", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ensayador", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ensayador", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hora", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcretera", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPlanta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPlanta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestreador", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestreador", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaMPa", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaMPa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultado1", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultado1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultado2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultado2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultadoa14bis", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultadoa14bis", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultadoa3", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultadoa3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultadoa7", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultadoa7", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultadoa7bis", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultadoa7bis", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RevObt", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevObt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Revenimento", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Revenimento", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 4, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.DateTime, 8, "Hora"),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.Int, 4, "IdPlanta"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaMPa", System.Data.SqlDbType.Real, 4, "ResistenciaMPa"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Real, 4, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Revenimento", System.Data.SqlDbType.Real, 4, "Revenimento"),
            new System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.SmallInt, 2, "Edad"),
            new System.Data.SqlClient.SqlParameter("@Elemento", System.Data.SqlDbType.NVarChar, 20, "Elemento"),
            new System.Data.SqlClient.SqlParameter("@RevObt", System.Data.SqlDbType.Real, 4, "RevObt"),
            new System.Data.SqlClient.SqlParameter("@Muestreador", System.Data.SqlDbType.SmallInt, 2, "Muestreador"),
            new System.Data.SqlClient.SqlParameter("@Resultadoa3", System.Data.SqlDbType.Float, 8, "Resultadoa3"),
            new System.Data.SqlClient.SqlParameter("@Resultadoa7", System.Data.SqlDbType.Float, 8, "Resultadoa7"),
            new System.Data.SqlClient.SqlParameter("@Resultadoa7bis", System.Data.SqlDbType.Float, 8, "Resultadoa7bis"),
            new System.Data.SqlClient.SqlParameter("@Resultadoa14bis", System.Data.SqlDbType.Float, 8, "Resultadoa14bis"),
            new System.Data.SqlClient.SqlParameter("@Resultado1", System.Data.SqlDbType.Float, 8, "Resultado1"),
            new System.Data.SqlClient.SqlParameter("@Resultado2", System.Data.SqlDbType.Float, 8, "Resultado2"),
            new System.Data.SqlClient.SqlParameter("@Ensayador", System.Data.SqlDbType.SmallInt, 2, "Ensayador")});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdLab", System.Data.SqlDbType.NVarChar, 10, "IdLaboratorio")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 4, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.DateTime, 8, "Hora"),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.Int, 4, "IdPlanta"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaMPa", System.Data.SqlDbType.Real, 4, "ResistenciaMPa"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Real, 4, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Revenimento", System.Data.SqlDbType.Real, 4, "Revenimento"),
            new System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.SmallInt, 2, "Edad"),
            new System.Data.SqlClient.SqlParameter("@Elemento", System.Data.SqlDbType.NVarChar, 20, "Elemento"),
            new System.Data.SqlClient.SqlParameter("@RevObt", System.Data.SqlDbType.Real, 4, "RevObt"),
            new System.Data.SqlClient.SqlParameter("@Muestreador", System.Data.SqlDbType.SmallInt, 2, "Muestreador"),
            new System.Data.SqlClient.SqlParameter("@Resultadoa3", System.Data.SqlDbType.Float, 8, "Resultadoa3"),
            new System.Data.SqlClient.SqlParameter("@Resultadoa7", System.Data.SqlDbType.Float, 8, "Resultadoa7"),
            new System.Data.SqlClient.SqlParameter("@Resultadoa7bis", System.Data.SqlDbType.Float, 8, "Resultadoa7bis"),
            new System.Data.SqlClient.SqlParameter("@Resultadoa14bis", System.Data.SqlDbType.Float, 8, "Resultadoa14bis"),
            new System.Data.SqlClient.SqlParameter("@Resultado1", System.Data.SqlDbType.Float, 8, "Resultado1"),
            new System.Data.SqlClient.SqlParameter("@Resultado2", System.Data.SqlDbType.Float, 8, "Resultado2"),
            new System.Data.SqlClient.SqlParameter("@Ensayador", System.Data.SqlDbType.SmallInt, 2, "Ensayador"),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Agregado", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Elemento", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ensayador", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ensayador", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hora", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcretera", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPlanta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPlanta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestreador", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestreador", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaMPa", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaMPa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultado1", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultado1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultado2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultado2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultadoa14bis", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultadoa14bis", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultadoa3", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultadoa3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultadoa7", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultadoa7", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resultadoa7bis", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resultadoa7bis", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RevObt", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevObt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Revenimento", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Revenimento", System.Data.DataRowVersion.Original, null)});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 487);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLaboratorioDataGridViewTextBoxColumn,
            this.idObraDataGridViewTextBoxColumn,
            this.muestraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.idConcreteraDataGridViewTextBoxColumn,
            this.idPlantaDataGridViewTextBoxColumn,
            this.resistenciaMPaDataGridViewTextBoxColumn,
            this.agregadoDataGridViewTextBoxColumn,
            this.revenimentoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.elementoDataGridViewTextBoxColumn,
            this.revObtDataGridViewTextBoxColumn,
            this.muestreadorDataGridViewTextBoxColumn,
            this.resultadoa3DataGridViewTextBoxColumn,
            this.resultadoa7DataGridViewTextBoxColumn,
            this.resultadoa7bisDataGridViewTextBoxColumn,
            this.resultadoa14bisDataGridViewTextBoxColumn,
            this.resultado1DataGridViewTextBoxColumn,
            this.resultado2DataGridViewTextBoxColumn,
            this.ensayadorDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Externos";
            this.dataGridView1.DataSource = this.dsExternos1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Size = new System.Drawing.Size(974, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // idLaboratorioDataGridViewTextBoxColumn
            // 
            this.idLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "IdLaboratorio";
            this.idLaboratorioDataGridViewTextBoxColumn.HeaderText = "IdLaboratorio";
            this.idLaboratorioDataGridViewTextBoxColumn.Name = "idLaboratorioDataGridViewTextBoxColumn";
            this.idLaboratorioDataGridViewTextBoxColumn.Visible = false;
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            this.idObraDataGridViewTextBoxColumn.Visible = false;
            // 
            // muestraDataGridViewTextBoxColumn
            // 
            this.muestraDataGridViewTextBoxColumn.DataPropertyName = "Muestra";
            this.muestraDataGridViewTextBoxColumn.HeaderText = "Muestra";
            this.muestraDataGridViewTextBoxColumn.Name = "muestraDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // idConcreteraDataGridViewTextBoxColumn
            // 
            this.idConcreteraDataGridViewTextBoxColumn.DataPropertyName = "IdConcretera";
            this.idConcreteraDataGridViewTextBoxColumn.HeaderText = "IdConcretera";
            this.idConcreteraDataGridViewTextBoxColumn.Name = "idConcreteraDataGridViewTextBoxColumn";
            // 
            // idPlantaDataGridViewTextBoxColumn
            // 
            this.idPlantaDataGridViewTextBoxColumn.DataPropertyName = "IdPlanta";
            this.idPlantaDataGridViewTextBoxColumn.HeaderText = "IdPlanta";
            this.idPlantaDataGridViewTextBoxColumn.Name = "idPlantaDataGridViewTextBoxColumn";
            // 
            // resistenciaMPaDataGridViewTextBoxColumn
            // 
            this.resistenciaMPaDataGridViewTextBoxColumn.DataPropertyName = "ResistenciaMPa";
            this.resistenciaMPaDataGridViewTextBoxColumn.HeaderText = "ResistenciaMPa";
            this.resistenciaMPaDataGridViewTextBoxColumn.Name = "resistenciaMPaDataGridViewTextBoxColumn";
            // 
            // agregadoDataGridViewTextBoxColumn
            // 
            this.agregadoDataGridViewTextBoxColumn.DataPropertyName = "Agregado";
            this.agregadoDataGridViewTextBoxColumn.HeaderText = "Agregado";
            this.agregadoDataGridViewTextBoxColumn.Name = "agregadoDataGridViewTextBoxColumn";
            // 
            // revenimentoDataGridViewTextBoxColumn
            // 
            this.revenimentoDataGridViewTextBoxColumn.DataPropertyName = "Revenimento";
            this.revenimentoDataGridViewTextBoxColumn.HeaderText = "Revenimento";
            this.revenimentoDataGridViewTextBoxColumn.Name = "revenimentoDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // elementoDataGridViewTextBoxColumn
            // 
            this.elementoDataGridViewTextBoxColumn.DataPropertyName = "Elemento";
            this.elementoDataGridViewTextBoxColumn.HeaderText = "Elemento";
            this.elementoDataGridViewTextBoxColumn.Name = "elementoDataGridViewTextBoxColumn";
            // 
            // revObtDataGridViewTextBoxColumn
            // 
            this.revObtDataGridViewTextBoxColumn.DataPropertyName = "RevObt";
            this.revObtDataGridViewTextBoxColumn.HeaderText = "RevObt";
            this.revObtDataGridViewTextBoxColumn.Name = "revObtDataGridViewTextBoxColumn";
            // 
            // muestreadorDataGridViewTextBoxColumn
            // 
            this.muestreadorDataGridViewTextBoxColumn.DataPropertyName = "Muestreador";
            this.muestreadorDataGridViewTextBoxColumn.HeaderText = "Muestreador";
            this.muestreadorDataGridViewTextBoxColumn.Name = "muestreadorDataGridViewTextBoxColumn";
            // 
            // resultadoa3DataGridViewTextBoxColumn
            // 
            this.resultadoa3DataGridViewTextBoxColumn.DataPropertyName = "Resultadoa3";
            this.resultadoa3DataGridViewTextBoxColumn.HeaderText = "Resultadoa3";
            this.resultadoa3DataGridViewTextBoxColumn.Name = "resultadoa3DataGridViewTextBoxColumn";
            // 
            // resultadoa7DataGridViewTextBoxColumn
            // 
            this.resultadoa7DataGridViewTextBoxColumn.DataPropertyName = "Resultadoa7";
            this.resultadoa7DataGridViewTextBoxColumn.HeaderText = "Resultadoa7";
            this.resultadoa7DataGridViewTextBoxColumn.Name = "resultadoa7DataGridViewTextBoxColumn";
            // 
            // resultadoa7bisDataGridViewTextBoxColumn
            // 
            this.resultadoa7bisDataGridViewTextBoxColumn.DataPropertyName = "Resultadoa7bis";
            this.resultadoa7bisDataGridViewTextBoxColumn.HeaderText = "Resultadoa7bis";
            this.resultadoa7bisDataGridViewTextBoxColumn.Name = "resultadoa7bisDataGridViewTextBoxColumn";
            // 
            // resultadoa14bisDataGridViewTextBoxColumn
            // 
            this.resultadoa14bisDataGridViewTextBoxColumn.DataPropertyName = "Resultadoa14bis";
            this.resultadoa14bisDataGridViewTextBoxColumn.HeaderText = "Resultadoa14bis";
            this.resultadoa14bisDataGridViewTextBoxColumn.Name = "resultadoa14bisDataGridViewTextBoxColumn";
            // 
            // resultado1DataGridViewTextBoxColumn
            // 
            this.resultado1DataGridViewTextBoxColumn.DataPropertyName = "Resultado1";
            this.resultado1DataGridViewTextBoxColumn.HeaderText = "Resultado1";
            this.resultado1DataGridViewTextBoxColumn.Name = "resultado1DataGridViewTextBoxColumn";
            // 
            // resultado2DataGridViewTextBoxColumn
            // 
            this.resultado2DataGridViewTextBoxColumn.DataPropertyName = "Resultado2";
            this.resultado2DataGridViewTextBoxColumn.HeaderText = "Resultado2";
            this.resultado2DataGridViewTextBoxColumn.Name = "resultado2DataGridViewTextBoxColumn";
            // 
            // ensayadorDataGridViewTextBoxColumn
            // 
            this.ensayadorDataGridViewTextBoxColumn.DataPropertyName = "Ensayador";
            this.ensayadorDataGridViewTextBoxColumn.HeaderText = "Ensayador";
            this.ensayadorDataGridViewTextBoxColumn.Name = "ensayadorDataGridViewTextBoxColumn";
            // 
            // incorpora
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(910, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAExternos;
            this.dsGeneral = this.dsExternos1;
            this.Name = "incorpora";
            this.NombreTabla = "Externos";
            this.Text = "Incorporación de Laboratorios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.incorpora_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExternos1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void incorpora_Load(object sender, System.EventArgs e)
		{
			sqlDALab.Fill(dsLab1,"Externos");
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsExternos1.Clear();
			txtIdObra.Text = cmbIdObra.SelectedValue.ToString();
			sqlDAExternos.SelectCommand.Parameters["@IdLab"].Value = cmbIdObra.SelectedValue;
			sqlDAExternos.Fill(dsExternos1, "Externos");
		}


		private void btnPROCESO_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlgOpenFile = new OpenFileDialog();
			dlgOpenFile.ShowReadOnly = true;
			dlgOpenFile.Filter = "Archivos de excel(*.xls)|*.xls";


			if(dlgOpenFile.ShowDialog() == DialogResult.OK)
			{
				string sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + 
					"Data Source=" + dlgOpenFile.InitialDirectory.ToString() + dlgOpenFile.FileName.ToString() + ";" + 
					"Extended Properties=Excel 8.0;";

				string sqlExcel = "Select * From [Hoja1$]";

				DataSet DS = new DataSet();

				OleDbConnection oledbConn = new OleDbConnection(sConnectionString);
				oledbConn.Open();

				OleDbCommand oledbCmd = new OleDbCommand(sqlExcel, oledbConn);

				OleDbDataAdapter da = new OleDbDataAdapter(oledbCmd);
				da.Fill(DS);

				//				dgExternos.DataSource = DS;
				// Add RowChanged event handler for the table.
				//				dsExternos1.Externos.RowChanged+= new DataRowChangeEventHandler(Row_Changed);

				// Add rows.
				int k = DS.Tables[0].Rows.Count;
				for(int i = 0; i < k;i++)
				{
					DataRow r = dsExternos1.Tables[0].NewRow();
					for(int j = 0; j < 21;j++)
						r[j]= DS.Tables[0].Rows[i][j];
					dsExternos1.Externos.Rows.Add(r);
				}	
			}
		}
			protected override void btnGuardar_Click(object sender, System.EventArgs e)
			{
				try 
				{
					// Intente actualizar el origen de datos.
					base.BindingContext[dsExternos1,"Externos"].Position = this.BindingContext[dsExternos1,"Externos"].Position;
					this.UpdateDataSet1();
					base.dsGeneral_PositionChanged();
				}
				catch (System.Exception eUpdate) 
				{
					statusBar1.Panels[2].Text = eUpdate.Message;	
					statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
					statusBar1.Panels[2].ToolTipText = eUpdate.Message;
				}

			}
		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
			// original			DataSet objDataSetChanges = new DataSet();
			LancNeo.dsExternos objDataSetChanges = new LancNeo.dsExternos();
			// Detener las ediciones actuales.
			// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsExternos1,"Externos"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
			// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

			objDataSetChanges = ((LancNeo.dsExternos)(dsExternos1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsExternos1.Merge(objDataSetChanges);
					dsExternos1.AcceptChanges();
				}
				catch (System.Exception eUpdate) 
				{
					// Agregar aquí el código de control de errores.
					throw eUpdate;
				}
				// Agregar código para comprobar en el conjunto de datos devuelto los errores que se puedan haber
				// introducido en el error del objeto de fila.
			}

		}
		private void UpdateDataSource1(LancNeo.dsExternos ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDAExternos.Update(ChangedRows);
				}
			}
			catch (System.Exception updateException) 
			{
				// Agregar aquí el código de control de errores.
				throw updateException;
			}
			finally 
			{
				// Cerrar la conexión independientemente de si se inició una excepción o no.
				this.sqlConn.Close();
			}
		}
	}
}
