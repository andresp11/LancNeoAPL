using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.Data;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de RepCartaEE.
	/// </summary>
	public class RepCartaEE : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Windows.Forms.ToolTip toolTip1;
		private LancNeo.dsUnidad dsUnidad1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDAExpMues;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private bool blnCambioFecha;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cmbUnidad;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpIni;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rdSI;
		private System.Windows.Forms.RadioButton rdNO;
		private Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crysRepCartaEdadEspecificada;
		private CrystalDecisions.CrystalReports.Engine.ReportDocument cryRepCartaEdadEspecificada;
		private String strRazonSocial;
		private String strObraUbicacion;
		private String strObraColonia;
		private System.Windows.Forms.TextBox txtConsecutivo;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPromedios;
		private System.Data.SqlClient.SqlCommand sqlCommand3;
		private System.Data.SqlClient.SqlDataAdapter sqlDAMuestras;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private LancNeo.dsExpMuesEE dsExpMuesEE1;
		private System.Windows.Forms.CheckBox chkTodas;
		private System.Windows.Forms.Label label1;
		private LancNeo.dsExpMues dsExpMues1;
		private LancNeo.dsRegistro dsRegistro1;
		private System.Data.SqlClient.SqlDataAdapter sqlDARegistro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private LancNeo.dsRegistro dsRegistro2;
        private System.Windows.Forms.CheckBox chkResultados;
		private System.Windows.Forms.TextBox txtDias;
        private DataGridView dgRegistro;
        private DataGridViewTextBoxColumn fechaRegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaRegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idConcreteraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idPlantaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaIniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resistenciaKGDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agregadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revenimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAgregadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idPruebaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idUnidadDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn todosDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn idDiamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAgregadoDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idPruebaDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDiamDDataGridViewTextBoxColumn;
		
		private System.ComponentModel.IContainer components;
		

		public RepCartaEE()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			blnCambioFecha = true;
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
            this.components = new System.ComponentModel.Container();
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepCartaEE));
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAExpMues = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chkResultados = new System.Windows.Forms.CheckBox();
            this.chkTodas = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdSI = new System.Windows.Forms.RadioButton();
            this.rdNO = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.crysRepCartaEdadEspecificada = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryRepCartaEdadEspecificada = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.sqlDAPromedios = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAMuestras = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsExpMuesEE1 = new LancNeo.dsExpMuesEE();
            this.dsExpMues1 = new LancNeo.dsExpMues();
            this.sqlDARegistro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.dsRegistro2 = new LancNeo.dsRegistro();
            this.dgRegistro = new System.Windows.Forms.DataGridView();
            this.fechaRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConcreteraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlantaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistenciaKGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAgregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPruebaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todosDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDiamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAgregadoDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPruebaDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDiamDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMuesEE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMues1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRegistro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // dsUnidad1
            // 
            this.dsUnidad1.DataSetName = "dsUnidad";
            this.dsUnidad1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsUnidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
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
            // sqlDAExpMues
            // 
            this.sqlDAExpMues.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAExpMues.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Agregado", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("TipoAgregado", "TipoAgregado"),
                        new System.Data.Common.DataColumnMapping("N° muestras", "N° muestras"),
                        new System.Data.Common.DataColumnMapping("TP", "TP")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.tbBtn1);
            this.panel1.Controls.Add(this.chkResultados);
            this.panel1.Controls.Add(this.chkTodas);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbUnidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtConsecutivo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Enter += new System.EventHandler(this.panel1_Enter);
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(957, 15);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 56;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // chkResultados
            // 
            this.chkResultados.Location = new System.Drawing.Point(662, 34);
            this.chkResultados.Name = "chkResultados";
            this.chkResultados.Size = new System.Drawing.Size(219, 24);
            this.chkResultados.TabIndex = 60;
            this.chkResultados.Text = "Selecciona todos los resultados";
            this.chkResultados.CheckStateChanged += new System.EventHandler(this.chkResultados_CheckStateChanged);
            // 
            // chkTodas
            // 
            this.chkTodas.Checked = true;
            this.chkTodas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTodas.Location = new System.Drawing.Point(661, 59);
            this.chkTodas.Name = "chkTodas";
            this.chkTodas.Size = new System.Drawing.Size(219, 24);
            this.chkTodas.TabIndex = 59;
            this.chkTodas.Text = "Imprime todas las muestras en la carta";
            this.chkTodas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdSI);
            this.groupBox3.Controls.Add(this.rdNO);
            this.groupBox3.Location = new System.Drawing.Point(491, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 75);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logotipo";
            // 
            // rdSI
            // 
            this.rdSI.Checked = true;
            this.rdSI.Location = new System.Drawing.Point(56, 13);
            this.rdSI.Name = "rdSI";
            this.rdSI.Size = new System.Drawing.Size(39, 24);
            this.rdSI.TabIndex = 0;
            this.rdSI.TabStop = true;
            this.rdSI.Text = "SI";
            // 
            // rdNO
            // 
            this.rdNO.Location = new System.Drawing.Point(114, 13);
            this.rdNO.Name = "rdNO";
            this.rdNO.Size = new System.Drawing.Size(39, 24);
            this.rdNO.TabIndex = 0;
            this.rdNO.Text = "NO";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(266, 66);
            this.label12.TabIndex = 51;
            this.label12.Text = "Cartas automaticas de pruebas a edad especificada";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.Undescr", true));
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsUnidad1, "Unidad.IdUnidad", true));
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(708, 7);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(96, 21);
            this.cmbUnidad.TabIndex = 35;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Unidad:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(811, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Consecutivo:";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(889, 7);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(52, 20);
            this.txtConsecutivo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDias);
            this.groupBox1.Controls.Add(this.dtpIni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(286, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha de registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Días posteriores:";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(109, 46);
            this.txtDias.MaxLength = 1;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(64, 20);
            this.txtDias.TabIndex = 51;
            this.txtDias.Text = "0";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(109, 20);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(86, 20);
            this.dtpIni.TabIndex = 31;
            this.dtpIni.ValueChanged += new System.EventHandler(this.dtpIni_ValueChanged_1);
            this.dtpIni.Enter += new System.EventHandler(this.dtpIni_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Inicial:";
            // 
            // crysRepCartaEdadEspecificada
            // 
            this.crysRepCartaEdadEspecificada.ActiveViewIndex = -1;
            this.crysRepCartaEdadEspecificada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crysRepCartaEdadEspecificada.Cursor = System.Windows.Forms.Cursors.Default;
            this.crysRepCartaEdadEspecificada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crysRepCartaEdadEspecificada.Location = new System.Drawing.Point(0, 90);
            this.crysRepCartaEdadEspecificada.Name = "crysRepCartaEdadEspecificada";
            this.crysRepCartaEdadEspecificada.ShowCloseButton = false;
            this.crysRepCartaEdadEspecificada.ShowGroupTreeButton = false;
            this.crysRepCartaEdadEspecificada.ShowLogo = false;
            this.crysRepCartaEdadEspecificada.Size = new System.Drawing.Size(1025, 483);
            this.crysRepCartaEdadEspecificada.TabIndex = 1;
            this.crysRepCartaEdadEspecificada.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crysRepCartaEdadEspecificada.Visible = false;
            this.crysRepCartaEdadEspecificada.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crysRepCartaEdadEspecificada_ReportRefresh);
            // 
            // sqlDAPromedios
            // 
            this.sqlDAPromedios.SelectCommand = this.sqlCommand3;
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "[Promedios]";
            this.sqlCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Renvenimiento", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Todos", System.Data.SqlDbType.Bit, 1),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDAMuestras
            // 
            this.sqlDAMuestras.SelectCommand = this.sqlSelectCommand4;
            this.sqlDAMuestras.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestras", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKg", System.Data.SqlDbType.Real, 4, "ResistenciaKG"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Real, 4, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Revenimiento", System.Data.SqlDbType.Real, 4, "Revenimento"),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 4, "IdAgregado")});
            // 
            // dsExpMuesEE1
            // 
            this.dsExpMuesEE1.DataSetName = "dsExpMuesEE";
            this.dsExpMuesEE1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsExpMuesEE1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsExpMues1
            // 
            this.dsExpMues1.DataSetName = "dsExpMues";
            this.dsExpMues1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsExpMues1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDARegistro
            // 
            this.sqlDARegistro.SelectCommand = this.sqlSelectCommand5;
            this.sqlDARegistro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Registro", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FechaReg", "FechaReg"),
                        new System.Data.Common.DataColumnMapping("HoraReg", "HoraReg"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("FechaIni", "FechaIni"),
                        new System.Data.Common.DataColumnMapping("FechaFin", "FechaFin"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Todos", "Todos"),
                        new System.Data.Common.DataColumnMapping("IdDiam", "IdDiam"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario"),
                        new System.Data.Common.DataColumnMapping("TipoD", "TipoD"),
                        new System.Data.Common.DataColumnMapping("IdAgregadoD", "IdAgregadoD"),
                        new System.Data.Common.DataColumnMapping("IdPruebaD", "IdPruebaD")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = resources.GetString("sqlSelectCommand5.CommandText");
            this.sqlSelectCommand5.Connection = this.sqlConn;
            this.sqlSelectCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FechaReg", System.Data.SqlDbType.DateTime, 4, "FechaReg")});
            // 
            // dsRegistro2
            // 
            this.dsRegistro2.DataSetName = "dsRegistro";
            this.dsRegistro2.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsRegistro2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgRegistro
            // 
            this.dgRegistro.AutoGenerateColumns = false;
            this.dgRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaRegDataGridViewTextBoxColumn,
            this.horaRegDataGridViewTextBoxColumn,
            this.idObraDataGridViewTextBoxColumn,
            this.idConcreteraDataGridViewTextBoxColumn,
            this.idPlantaDataGridViewTextBoxColumn,
            this.fechaIniDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.resistenciaKGDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.agregadoDataGridViewTextBoxColumn,
            this.revenimientoDataGridViewTextBoxColumn,
            this.idAgregadoDataGridViewTextBoxColumn,
            this.idPruebaDataGridViewTextBoxColumn,
            this.idUnidadDataGridViewTextBoxColumn,
            this.todosDataGridViewCheckBoxColumn,
            this.idDiamDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.tipoDDataGridViewTextBoxColumn,
            this.idAgregadoDDataGridViewTextBoxColumn,
            this.idPruebaDDataGridViewTextBoxColumn,
            this.idDiamDDataGridViewTextBoxColumn});
            this.dgRegistro.DataMember = "Registro";
            this.dgRegistro.DataSource = this.dsRegistro2;
            this.dgRegistro.Location = new System.Drawing.Point(0, 90);
            this.dgRegistro.Name = "dgRegistro";
            this.dgRegistro.Size = new System.Drawing.Size(1025, 483);
            this.dgRegistro.TabIndex = 3;
            // 
            // fechaRegDataGridViewTextBoxColumn
            // 
            this.fechaRegDataGridViewTextBoxColumn.DataPropertyName = "FechaReg";
            this.fechaRegDataGridViewTextBoxColumn.HeaderText = "FechaReg";
            this.fechaRegDataGridViewTextBoxColumn.Name = "fechaRegDataGridViewTextBoxColumn";
            // 
            // horaRegDataGridViewTextBoxColumn
            // 
            this.horaRegDataGridViewTextBoxColumn.DataPropertyName = "HoraReg";
            this.horaRegDataGridViewTextBoxColumn.HeaderText = "HoraReg";
            this.horaRegDataGridViewTextBoxColumn.Name = "horaRegDataGridViewTextBoxColumn";
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
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
            // fechaIniDataGridViewTextBoxColumn
            // 
            this.fechaIniDataGridViewTextBoxColumn.DataPropertyName = "FechaIni";
            this.fechaIniDataGridViewTextBoxColumn.HeaderText = "FechaIni";
            this.fechaIniDataGridViewTextBoxColumn.Name = "fechaIniDataGridViewTextBoxColumn";
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            // 
            // resistenciaKGDataGridViewTextBoxColumn
            // 
            this.resistenciaKGDataGridViewTextBoxColumn.DataPropertyName = "ResistenciaKG";
            this.resistenciaKGDataGridViewTextBoxColumn.HeaderText = "ResistenciaKG";
            this.resistenciaKGDataGridViewTextBoxColumn.Name = "resistenciaKGDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // agregadoDataGridViewTextBoxColumn
            // 
            this.agregadoDataGridViewTextBoxColumn.DataPropertyName = "Agregado";
            this.agregadoDataGridViewTextBoxColumn.HeaderText = "Agregado";
            this.agregadoDataGridViewTextBoxColumn.Name = "agregadoDataGridViewTextBoxColumn";
            // 
            // revenimientoDataGridViewTextBoxColumn
            // 
            this.revenimientoDataGridViewTextBoxColumn.DataPropertyName = "Revenimiento";
            this.revenimientoDataGridViewTextBoxColumn.HeaderText = "Revenimiento";
            this.revenimientoDataGridViewTextBoxColumn.Name = "revenimientoDataGridViewTextBoxColumn";
            // 
            // idAgregadoDataGridViewTextBoxColumn
            // 
            this.idAgregadoDataGridViewTextBoxColumn.DataPropertyName = "IdAgregado";
            this.idAgregadoDataGridViewTextBoxColumn.HeaderText = "IdAgregado";
            this.idAgregadoDataGridViewTextBoxColumn.Name = "idAgregadoDataGridViewTextBoxColumn";
            // 
            // idPruebaDataGridViewTextBoxColumn
            // 
            this.idPruebaDataGridViewTextBoxColumn.DataPropertyName = "IdPrueba";
            this.idPruebaDataGridViewTextBoxColumn.HeaderText = "IdPrueba";
            this.idPruebaDataGridViewTextBoxColumn.Name = "idPruebaDataGridViewTextBoxColumn";
            // 
            // idUnidadDataGridViewTextBoxColumn
            // 
            this.idUnidadDataGridViewTextBoxColumn.DataPropertyName = "IdUnidad";
            this.idUnidadDataGridViewTextBoxColumn.HeaderText = "IdUnidad";
            this.idUnidadDataGridViewTextBoxColumn.Name = "idUnidadDataGridViewTextBoxColumn";
            // 
            // todosDataGridViewCheckBoxColumn
            // 
            this.todosDataGridViewCheckBoxColumn.DataPropertyName = "Todos";
            this.todosDataGridViewCheckBoxColumn.HeaderText = "Todos";
            this.todosDataGridViewCheckBoxColumn.Name = "todosDataGridViewCheckBoxColumn";
            // 
            // idDiamDataGridViewTextBoxColumn
            // 
            this.idDiamDataGridViewTextBoxColumn.DataPropertyName = "IdDiam";
            this.idDiamDataGridViewTextBoxColumn.HeaderText = "IdDiam";
            this.idDiamDataGridViewTextBoxColumn.Name = "idDiamDataGridViewTextBoxColumn";
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // tipoDDataGridViewTextBoxColumn
            // 
            this.tipoDDataGridViewTextBoxColumn.DataPropertyName = "TipoD";
            this.tipoDDataGridViewTextBoxColumn.HeaderText = "TipoD";
            this.tipoDDataGridViewTextBoxColumn.Name = "tipoDDataGridViewTextBoxColumn";
            // 
            // idAgregadoDDataGridViewTextBoxColumn
            // 
            this.idAgregadoDDataGridViewTextBoxColumn.DataPropertyName = "IdAgregadoD";
            this.idAgregadoDDataGridViewTextBoxColumn.HeaderText = "IdAgregadoD";
            this.idAgregadoDDataGridViewTextBoxColumn.Name = "idAgregadoDDataGridViewTextBoxColumn";
            // 
            // idPruebaDDataGridViewTextBoxColumn
            // 
            this.idPruebaDDataGridViewTextBoxColumn.DataPropertyName = "IdPruebaD";
            this.idPruebaDDataGridViewTextBoxColumn.HeaderText = "IdPruebaD";
            this.idPruebaDDataGridViewTextBoxColumn.Name = "idPruebaDDataGridViewTextBoxColumn";
            // 
            // idDiamDDataGridViewTextBoxColumn
            // 
            this.idDiamDDataGridViewTextBoxColumn.DataPropertyName = "IdDiamD";
            this.idDiamDDataGridViewTextBoxColumn.HeaderText = "IdDiamD";
            this.idDiamDDataGridViewTextBoxColumn.Name = "idDiamDDataGridViewTextBoxColumn";
            // 
            // RepCartaEE
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1025, 573);
            this.Controls.Add(this.dgRegistro);
            this.Controls.Add(this.crysRepCartaEdadEspecificada);
            this.Controls.Add(this.panel1);
            this.Name = "RepCartaEE";
            this.Text = "RepCartaEE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepCartaEE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMuesEE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMues1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRegistro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistro)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void RepCartaEE_Load(object sender, System.EventArgs e)
		{
			dtpIni.Value = DateTime.Today;
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			LlenasSqlDA();
		}
		private void LlenasSqlDA()
		{
			crysRepCartaEdadEspecificada.Visible = false;
			dgRegistro.Visible = true;
			dsRegistro2.Clear();
			sqlDARegistro.SelectCommand.Parameters["@FechaReg"].Value = dtpIni.Value;
			sqlDARegistro.Fill(dsRegistro2, "Registro");
		}
		
		private void tbBtn1_Click(object sender, System.EventArgs e)
		{
            
			dgRegistro.Visible = false;
            crysRepCartaEdadEspecificada.Visible = true;
            dsExpMuesEE1.Clear();

			for(int i = 0; dsRegistro2.Tables["Registro"].Rows.Count > i; i++)
				if (dsRegistro2.Tables["Registro"].Rows[i]["Todos"].ToString() == "True")
				{
					dsRegistro2.Tables["Registro"].Rows[i]["Todos"] = false;
					try
					{
						DateTime Fecha = System.Convert.ToDateTime(dsRegistro2.Tables["Registro"].Rows[i]["FechaFin"].ToString());
						Fecha = (int.Parse(txtDias.Text) > 0 ? Fecha.AddDays(int.Parse(txtDias.Text)) : Fecha);
						GetDatosEmpresa(i);
						sqlDAMuestras.SelectCommand.Parameters["@IdObra"].Value = dsRegistro2.Tables["Registro"].Rows[i]["IdObra"].ToString();
						sqlDAMuestras.SelectCommand.Parameters["@IdConcretera"].Value = dsRegistro2.Tables["Registro"].Rows[i]["IdConcretera"].ToString() ;
						sqlDAMuestras.SelectCommand.Parameters["@FechaIni"].Value = dsRegistro2.Tables["Registro"].Rows[i]["FechaIni"].ToString();
						sqlDAMuestras.SelectCommand.Parameters["@FechaFin"].Value = Fecha.ToString();
						sqlDAMuestras.SelectCommand.Parameters["@ResistenciaKg"].Value = dsRegistro2.Tables["Registro"].Rows[i]["ResistenciaKG"].ToString();
						sqlDAMuestras.SelectCommand.Parameters["@Tipo"].Value = dsRegistro2.Tables["Registro"].Rows[i]["Tipo"].ToString();
						sqlDAMuestras.SelectCommand.Parameters["@Agregado"].Value = dsRegistro2.Tables["Registro"].Rows[i]["Agregado"].ToString();
						sqlDAMuestras.SelectCommand.Parameters["@Revenimiento"].Value = dsRegistro2.Tables["Registro"].Rows[i]["Revenimiento"].ToString();
						sqlDAMuestras.SelectCommand.Parameters["@IdAgregado"].Value = dsRegistro2.Tables["Registro"].Rows[i]["IdAgregado"].ToString();
						sqlDAMuestras.Fill(dsExpMuesEE1, "Muestras");
						
                        sqlDAPromedios.SelectCommand.Parameters["@IdObra"].Value = dsRegistro2.Tables["Registro"].Rows[i]["IdObra"].ToString();
						sqlDAPromedios.SelectCommand.Parameters["@IdConcretera"].Value = dsRegistro2.Tables["Registro"].Rows[i]["IdConcretera"].ToString() ;
						sqlDAPromedios.SelectCommand.Parameters["@IdPlanta"].Value = dsRegistro2.Tables["Registro"].Rows[i]["IdPlanta"].ToString();
						sqlDAPromedios.SelectCommand.Parameters["@FechaIni"].Value = dsRegistro2.Tables["Registro"].Rows[i]["FechaIni"].ToString();
						sqlDAPromedios.SelectCommand.Parameters["@FechaFin"].Value = Fecha.ToString();
						sqlDAPromedios.SelectCommand.Parameters["@ResistenciaKg"].Value = dsRegistro2.Tables["Registro"].Rows[i]["ResistenciaKG"].ToString();
						sqlDAPromedios.SelectCommand.Parameters["@Tipo"].Value = dsRegistro2.Tables["Registro"].Rows[i]["Tipo"].ToString();
						sqlDAPromedios.SelectCommand.Parameters["@Agregado"].Value = dsRegistro2.Tables["Registro"].Rows[i]["Agregado"].ToString();
						sqlDAPromedios.SelectCommand.Parameters["@Renvenimiento"].Value = dsRegistro2.Tables["Registro"].Rows[i]["Revenimiento"].ToString();
						sqlDAPromedios.SelectCommand.Parameters["@IdAgregado"].Value = dsRegistro2.Tables["Registro"].Rows[i]["IdAgregado"].ToString();
						sqlDAPromedios.SelectCommand.Parameters["@IdPrueba"].Value = dsRegistro2.Tables["Registro"].Rows[i]["IdPrueba"].ToString();
						sqlDAPromedios.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
						sqlDAPromedios.SelectCommand.Parameters["@Todos"].Value = chkTodas.Checked;
                        //sqlDAPromedios.SelectCommand.Parameters["@Leyenda"].Value = false;
                        //sqlDAPromedios.SelectCommand.Parameters["@Lab"].Value = true;
						sqlDAPromedios.SelectCommand.Parameters["@IdDiam"].Value = dsRegistro2.Tables["Registro"].Rows[i]["IdDiam"].ToString();
						sqlDAPromedios.Fill(dsExpMuesEE1, "Promedios");


                        cryRepCartaEdadEspecificada = new CryRepCartaEdadEspecificada();
                        cryRepCartaEdadEspecificada.SetDataSource(dsExpMuesEE1);
                        cryRepCartaEdadEspecificada.SetParameterValue("@Leyenda", false);
                        cryRepCartaEdadEspecificada.SetParameterValue("@Lab", true);
                        
                        crysRepCartaEdadEspecificada.Visible = true;
                        SetCrysParams(i);
				
						crysRepCartaEdadEspecificada.ReportSource = cryRepCartaEdadEspecificada;
						//crysRepCartaEdadEspecificada.RefreshReport();
						i = dsRegistro2.Tables["Registro"].Rows.Count;
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message );
					}
				}
		}


		private void dtpIni_ValueChanged_1(object sender, System.EventArgs e)
		{
			blnCambioFecha = true;
			LlenasSqlDA();
		}

		private void crysRepCartaEdadEspecificada_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
		{
//			SetCrysParams();
//			crysRepCartaEdadEspecificada.ReportSource = cryRepCartaEdadEspecificada;
		}

		private void SetCrysParams(int i)
		{
			ParameterValues pvs = new CrystalDecisions.Shared.ParameterValues();
				
			ParameterDiscreteValue pdvRazonsocial = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvObraUbicacion = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvObraColonia = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvTipoPrueba = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvExp3 = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvExp7 = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvUnidad = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvSINO = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvConsecutivo = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvRes = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvConcre= new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvDiam= new CrystalDecisions.Shared.ParameterDiscreteValue();

			pdvRazonsocial.Value = strRazonSocial;
			pvs.Add(pdvRazonsocial);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Razonsocial"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvObraUbicacion.Value = strObraUbicacion;
			pvs.Add(pdvObraUbicacion);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["ObraUbicacion"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvObraColonia.Value = strObraColonia;
			pvs.Add(pdvObraColonia);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["ObraColonia"].ApplyCurrentValues(pvs);
			pvs.Clear();
				
			pdvTipoPrueba.Value = dsRegistro2.Tables["Registro"].Rows[i]["IdPruebaD"].ToString().ToUpper();
			pvs.Add(pdvTipoPrueba);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["TipoPrueba"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvUnidad.Value = cmbUnidad.Text.ToString();
			pvs.Add(pdvUnidad);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Unidad"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvSINO.Value = rdNO.Checked ? 0 : 1;
			pvs.Add(pdvSINO);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Logotipo"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvConsecutivo.Value = txtConsecutivo.Text.Length > 0 ? txtConsecutivo.Text : "0";
			pvs.Add(pdvConsecutivo);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Consecutivo"].ApplyCurrentValues(pvs);
			pvs.Clear();

			string resis;
			double resis1;
			resis1 = double.Parse(dsRegistro2.Tables["Registro"].Rows[i]["ResistenciaKG"].ToString()) * double.Parse(dsUnidad1.Tables[0].Rows[int.Parse(cmbUnidad.SelectedIndex.ToString())][2].ToString());
			if (double.Parse(dsUnidad1.Tables[0].Rows[int.Parse(cmbUnidad.SelectedIndex.ToString())][2].ToString()) == 1)
				resis = dsRegistro2.Tables["Registro"].Rows[i]["ResistenciaKG"].ToString();
			else
				resis = resis1.ToString("###.00");
			pdvRes.Value = resis  + " - " + dsRegistro2.Tables["Registro"].Rows[i]["TipoD"].ToString() + " - " + dsRegistro2.Tables["Registro"].Rows[i]["IdAgregadoD"].ToString() + " - " + dsRegistro2.Tables["Registro"].Rows[i]["Revenimiento"].ToString() ;
			pvs.Add(pdvRes);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Res"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvConcre.Value = dsRegistro2.Tables["Registro"].Rows[i]["IdConcretera"].ToString() ;
			pvs.Add(pdvConcre);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Concre"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvDiam.Value = dsRegistro2.Tables["Registro"].Rows[i]["IdDiam"].ToString() ;
			pvs.Add(pdvDiam);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Diam"].ApplyCurrentValues(pvs);
			pvs.Clear();

//			pdvRes1.Value = double.Parse(resis) ;
//			pvs.Add(pdvRes1);
//			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Res1"].ApplyCurrentValues(pvs);
//			pvs.Clear();
		}
		private void GetDatosEmpresa(int i)
		{
			String strSql = " Select O.infomres as Facturar, O.Ubicacion, O.Colonia from Obra O ";
//				strSql += " Join RazonSocial RS on RS.RFC = O.RFC ";
				strSql += " Where O.IdObra = '" + dsRegistro2.Tables["Registro"].Rows[i]["IdObra"].ToString() + "'";
			SqlCommand sqlCmd  = new SqlCommand(strSql, sqlConn);
			try
			{
				sqlConn.Open();
				SqlDataReader dr = sqlCmd.ExecuteReader();
				if(dr.Read())
				{	
					strRazonSocial   = dr["Facturar"].ToString();
					strObraUbicacion = dr["Ubicacion"].ToString();
					strObraColonia   = dr["Colonia"].ToString();
				}					                                                                                                                 
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if(sqlConn.State == ConnectionState.Open)
				{
					sqlConn.Close();
				}
			}
		}


		private void button1_Click(object sender, System.EventArgs e)
		{
//			PageSetupDialog  psd = new PageSetupDialog();
//			psd.
//			psd.ShowDialog();
			pageSetupDialog1.Document = new System.Drawing.Printing.PrintDocument();
			pageSetupDialog1.ShowDialog();
			this.cryRepCartaEdadEspecificada.PrintOptions.ApplyPageMargins(new PageMargins(pageSetupDialog1.PageSettings.Margins.Left,pageSetupDialog1.PageSettings.Margins.Top,pageSetupDialog1.PageSettings.Margins.Right,pageSetupDialog1.PageSettings.Margins.Bottom));
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void chkResultados_CheckStateChanged(object sender, System.EventArgs e)
		{
			if (chkResultados.Checked == true)
				for(int i = 0; dsRegistro2.Tables["Registro"].Rows.Count > i; i++)
					dsRegistro2.Tables["Registro"].Rows[i]["Todos"] = true;
			else
				for(int i = 0; dsRegistro2.Tables["Registro"].Rows.Count > i; i++)
					dsRegistro2.Tables["Registro"].Rows[i]["Todos"] = false;
		}

		private void dtpIni_Enter(object sender, System.EventArgs e)
		{
			dgRegistro.Visible = true;
			crysRepCartaEdadEspecificada.Visible = false;
		}

		private void panel1_Enter(object sender, System.EventArgs e)
		{
			dgRegistro.Visible = true;
			crysRepCartaEdadEspecificada.Visible = false;
		}

	}
}