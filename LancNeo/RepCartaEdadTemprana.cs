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
	/// Descripción breve de RepCartaEdadTemprana.
	/// </summary>
	public class RepCartaEdadTemprana : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsBusObra dsBusObra1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDATipoPrueba;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private LancNeo.dsTipoPrueba dsTipoPrueba1;
		private System.Windows.Forms.ToolTip toolTip1;
		private LancNeo.dsUnidad dsUnidad1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private LancNeo.dsConcretera dsConcretera1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsPlanta dsPlanta1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPLanta;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		private System.Data.SqlClient.SqlDataAdapter sqlDAExpMues;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsExpMues dsExpMues1;
		private bool blnCambioFecha;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbPlanta;
		private System.Windows.Forms.ComboBox cmbUnidad;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpIni;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbConcretera;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtResistencia;
		private System.Windows.Forms.TextBox txtTipo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtAgregado;
		private System.Windows.Forms.TextBox txtTipoAgregado;
		private System.Windows.Forms.TextBox txtRevenimento;
		private System.Windows.Forms.ComboBox cmbPrueba;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cmbObra;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rdSI;
		private System.Windows.Forms.RadioButton rdNO;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn2;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crysRepCartaEdadTemprana;
		private System.Data.SqlClient.SqlDataAdapter sqlDACartaEdadTemp;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private LancNeo.dsRepCartaEdadTemprana dsRepCartaEdadTemprana1;
		private System.Windows.Forms.TextBox txt3d;
		private System.Windows.Forms.TextBox txt7d;
		private CrystalDecisions.CrystalReports.Engine.ReportDocument cryRepCartaEdadTemprana;
		private String strRazonSocial;
		private String strObraUbicacion;
		private String strObraColonia;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretoSolicitado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private LancNeo.dsConcretoSolicitado dsConcretoSolicitado1;
		private System.Windows.Forms.TextBox txtConsecutivo;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private LancNeo.dsDiametro dsDiametro1;
		private System.Data.SqlClient.SqlDataAdapter sqlDADiametro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
		private System.Windows.Forms.ComboBox cmbIdDiam;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.CheckBox chbLeyenda;
		private System.Windows.Forms.CheckBox chbLab;
        private dsExpMueN dsExpMueN1;
        private CheckBox chkMortero;
        private SqlDataAdapter sqlDABajosTemp;
        private SqlCommand sqlCommand3;
        private dsBajosTemp dsBajosTemp1;
        private DataGridView dgvResultado;
        private DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idConcreteraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resistenciaKGDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn desTipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agregadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revenimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Dia;
        private DataGridViewTextBoxColumn fensayeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resistenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idConcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idLaboratorioDataGridViewTextBoxColumn;
        private CryRepCartaEdadTempranM cryRepCartaEdadTempranM1;
		
		private System.ComponentModel.IContainer components;
		

		public RepCartaEdadTemprana()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepCartaEdadTemprana));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsExpMues1 = new LancNeo.dsExpMues();
            this.dsPlanta1 = new LancNeo.dsPlanta();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATipoPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsExpMueN1 = new LancNeo.dsExpMueN();
            this.buscaBtn2 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsConcretoSolicitado1 = new LancNeo.dsConcretoSolicitado();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPLanta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAExpMues = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chkMortero = new System.Windows.Forms.CheckBox();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.cmbIdDiam = new System.Windows.Forms.ComboBox();
            this.dsDiametro1 = new LancNeo.dsDiametro();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdSI = new System.Windows.Forms.RadioButton();
            this.rdNO = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt3d = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt7d = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbConcretera = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResistencia = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAgregado = new System.Windows.Forms.TextBox();
            this.txtTipoAgregado = new System.Windows.Forms.TextBox();
            this.txtRevenimento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbObra = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.crysRepCartaEdadTemprana = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDACartaEdadTemp = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsRepCartaEdadTemprana1 = new LancNeo.dsRepCartaEdadTemprana();
            this.cryRepCartaEdadTemprana = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.sqlDAConcretoSolicitado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABajosTemp = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsBajosTemp1 = new LancNeo.dsBajosTemp();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConcreteraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistenciaKGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fensayeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLaboratorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cryRepCartaEdadTempranM1 = new LancNeo.CryRepCartaEdadTempranM();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMues1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMueN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretoSolicitado1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepCartaEdadTemprana1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBajosTemp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dsExpMues1
            // 
            this.dsExpMues1.DataSetName = "dsExpMues";
            this.dsExpMues1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsExpMues1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPlanta1
            // 
            this.dsPlanta1.DataSetName = "dsPlanta";
            this.dsPlanta1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsConcretera1
            // 
            this.dsConcretera1.DataSetName = "dsConcretera";
            this.dsConcretera1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsUnidad1
            // 
            this.dsUnidad1.DataSetName = "dsUnidad";
            this.dsUnidad1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsUnidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsTipoPrueba1
            // 
            this.dsTipoPrueba1.DataSetName = "dsTipoPrueba";
            this.dsTipoPrueba1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipoPrueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlCommand1.CommandText = "SELECT Obra.Idobra, Obra.Ubicacion, Obra.RFC, Razonsocial.Facturar FROM Obra LEFT" +
    " OUTER JOIN Razonsocial ON Obra.IdCliente = Razonsocial.IdCliente AND Obra.RFC =" +
    " Razonsocial.RFC ORDER BY Obra.Idobra";
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // sqlDATipoPrueba
            // 
            this.sqlDATipoPrueba.SelectCommand = this.sqlSelectCommand1;
            this.sqlDATipoPrueba.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipoprueba", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdPrueba, Prueba FROM Tipoprueba";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsExpMueN1.Muestras;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(430, 8);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 55;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Seleccionar concreto solicitado");
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click_1);
            // 
            // dsExpMueN1
            // 
            this.dsExpMueN1.DataSetName = "dsExpMueN";
            this.dsExpMueN1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscaBtn2
            // 
            this.buscaBtn2.AnchoColTit = true;
            this.buscaBtn2.AnchoDlgBusq = 800;
            this.buscaBtn2.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn2.Datos = this.dsConcretoSolicitado1.Experiencia;
            this.buscaBtn2.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn2.Icon")));
            this.buscaBtn2.Location = new System.Drawing.Point(1120, 74);
            this.buscaBtn2.Name = "buscaBtn2";
            this.buscaBtn2.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn2.TabIndex = 57;
            this.toolTip1.SetToolTip(this.buscaBtn2, "Seleccionar Experiencia");
            this.buscaBtn2.Visible = false;
            this.buscaBtn2.Click += new System.EventHandler(this.buscaBtn2_Click);
            // 
            // dsConcretoSolicitado1
            // 
            this.dsConcretoSolicitado1.DataSetName = "dsConcretoSolicitado";
            this.dsConcretoSolicitado1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretoSolicitado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlDAConcretera
            // 
            this.sqlDAConcretera.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAConcretera.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concretera", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("Concretera", "Concretera"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT IdConcretera, Concretera, Direccion FROM Concretera ORDER BY IdConcretera";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlDAPLanta
            // 
            this.sqlDAPLanta.SelectCommand = this.sqlSelectCommand6;
            this.sqlDAPLanta.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Planta", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("Planta", "Planta")})});
            // 
            // sqlSelectCommand6
            // 
            this.sqlSelectCommand6.CommandText = "SELECT IdConcretera, IdPlanta, Planta FROM Planta WHERE (IdConcretera LIKE @IdCon" +
    "cretera)";
            this.sqlSelectCommand6.Connection = this.sqlConn;
            this.sqlSelectCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera")});
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
                        new System.Data.Common.DataColumnMapping("TipoAgregado", "TipoAgregado"),
                        new System.Data.Common.DataColumnMapping("N° muestras", "N° muestras")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcretera", System.Data.DataRowVersion.Current, "bsu"),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Current, "01/01/2012"),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Current, "31/10/2014"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Current, "bsu")});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.tbBtn1);
            this.panel1.Controls.Add(this.buscaBtn2);
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.dgvResultado);
            this.panel1.Controls.Add(this.chkMortero);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.cmbIdDiam);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbPrueba);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbPlanta);
            this.panel1.Controls.Add(this.cmbUnidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbConcretera);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtResistencia);
            this.panel1.Controls.Add(this.txtTipo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtAgregado);
            this.panel1.Controls.Add(this.txtTipoAgregado);
            this.panel1.Controls.Add(this.txtRevenimento);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cmbObra);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtConsecutivo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 153);
            this.panel1.TabIndex = 0;
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(1120, 4);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 56;
            this.tbBtn1.Load += new System.EventHandler(this.tbBtn1_Load);
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // chkMortero
            // 
            this.chkMortero.ForeColor = System.Drawing.Color.Red;
            this.chkMortero.Location = new System.Drawing.Point(1057, 123);
            this.chkMortero.Name = "chkMortero";
            this.chkMortero.Size = new System.Drawing.Size(130, 24);
            this.chkMortero.TabIndex = 79;
            this.chkMortero.Text = "Formato MORTERO";
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.Location = new System.Drawing.Point(1057, 101);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 24);
            this.chbLab.TabIndex = 78;
            this.chbLab.Text = "Incluye laboratorio";
            this.chbLab.CheckedChanged += new System.EventHandler(this.chbLab_CheckedChanged);
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.Checked = true;
            this.chbLeyenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLeyenda.Location = new System.Drawing.Point(1057, 80);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(116, 24);
            this.chbLeyenda.TabIndex = 61;
            this.chbLeyenda.Text = "Formato leyenda";
            this.chbLeyenda.CheckedChanged += new System.EventHandler(this.chbLeyenda_CheckedChanged);
            // 
            // cmbIdDiam
            // 
            this.cmbIdDiam.DataSource = this.dsDiametro1;
            this.cmbIdDiam.DisplayMember = "Diametro.Figura";
            this.cmbIdDiam.Location = new System.Drawing.Point(85, 130);
            this.cmbIdDiam.Name = "cmbIdDiam";
            this.cmbIdDiam.Size = new System.Drawing.Size(128, 21);
            this.cmbIdDiam.TabIndex = 60;
            this.cmbIdDiam.ValueMember = "IdDiam";
            // 
            // dsDiametro1
            // 
            this.dsDiametro1.DataSetName = "dsDiametro";
            this.dsDiametro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDiametro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 59;
            this.label18.Text = "F. geométrica:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdSI);
            this.groupBox3.Controls.Add(this.rdNO);
            this.groupBox3.Location = new System.Drawing.Point(223, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 46);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logotipo";
            // 
            // rdSI
            // 
            this.rdSI.Checked = true;
            this.rdSI.Location = new System.Drawing.Point(53, 18);
            this.rdSI.Name = "rdSI";
            this.rdSI.Size = new System.Drawing.Size(39, 24);
            this.rdSI.TabIndex = 0;
            this.rdSI.TabStop = true;
            this.rdSI.Text = "SI";
            // 
            // rdNO
            // 
            this.rdNO.Location = new System.Drawing.Point(111, 18);
            this.rdNO.Name = "rdNO";
            this.rdNO.Size = new System.Drawing.Size(39, 24);
            this.rdNO.TabIndex = 0;
            this.rdNO.Text = "No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt3d);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt7d);
            this.groupBox2.Location = new System.Drawing.Point(815, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 69);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Experiencia";
            // 
            // txt3d
            // 
            this.txt3d.Location = new System.Drawing.Point(60, 40);
            this.txt3d.Name = "txt3d";
            this.txt3d.Size = new System.Drawing.Size(71, 20);
            this.txt3d.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(227, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Incremento en resistencia a edad especificada";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "de 3 dias:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(143, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "de 7 dias:";
            // 
            // txt7d
            // 
            this.txt7d.Location = new System.Drawing.Point(197, 40);
            this.txt7d.Name = "txt7d";
            this.txt7d.Size = new System.Drawing.Size(71, 20);
            this.txt7d.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 24);
            this.label12.TabIndex = 51;
            this.label12.Text = " Carta Edad Temprana";
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(85, 104);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(128, 21);
            this.cmbPrueba.TabIndex = 49;
            this.cmbPrueba.ValueMember = "IdPrueba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Prueba:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Planta:";
            this.label6.Visible = false;
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DataSource = this.dsPlanta1;
            this.cmbPlanta.DisplayMember = "Planta.Planta";
            this.cmbPlanta.Enabled = false;
            this.cmbPlanta.Location = new System.Drawing.Point(85, 80);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(128, 21);
            this.cmbPlanta.TabIndex = 47;
            this.cmbPlanta.ValueMember = "Planta.IdPlanta";
            this.cmbPlanta.Visible = false;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.Undescr", true));
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsUnidad1, "Unidad.IdUnidad", true));
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(571, 53);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(80, 21);
            this.cmbUnidad.TabIndex = 35;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Unidad:";
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1;
            this.cmbConcretera.DisplayMember = "Concretera.IdConcretera";
            this.cmbConcretera.Location = new System.Drawing.Point(85, 56);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(128, 21);
            this.cmbConcretera.TabIndex = 30;
            this.cmbConcretera.ValueMember = "Concretera.IdConcretera";
            this.cmbConcretera.SelectedIndexChanged += new System.EventHandler(this.cmbConcretera_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Concretera:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Resistencia:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Tipo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResistencia
            // 
            this.txtResistencia.Location = new System.Drawing.Point(571, 7);
            this.txtResistencia.Name = "txtResistencia";
            this.txtResistencia.ReadOnly = true;
            this.txtResistencia.Size = new System.Drawing.Size(80, 20);
            this.txtResistencia.TabIndex = 45;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(571, 30);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(80, 20);
            this.txtTipo.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Revenimento:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(678, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Agregado:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(654, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Tipo Agregado:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAgregado
            // 
            this.txtAgregado.Location = new System.Drawing.Point(742, 7);
            this.txtAgregado.Name = "txtAgregado";
            this.txtAgregado.ReadOnly = true;
            this.txtAgregado.Size = new System.Drawing.Size(64, 20);
            this.txtAgregado.TabIndex = 42;
            // 
            // txtTipoAgregado
            // 
            this.txtTipoAgregado.Location = new System.Drawing.Point(742, 54);
            this.txtTipoAgregado.Name = "txtTipoAgregado";
            this.txtTipoAgregado.ReadOnly = true;
            this.txtTipoAgregado.Size = new System.Drawing.Size(64, 20);
            this.txtTipoAgregado.TabIndex = 43;
            // 
            // txtRevenimento
            // 
            this.txtRevenimento.Location = new System.Drawing.Point(742, 30);
            this.txtRevenimento.Name = "txtRevenimento";
            this.txtRevenimento.ReadOnly = true;
            this.txtRevenimento.Size = new System.Drawing.Size(64, 20);
            this.txtRevenimento.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Obra:";
            // 
            // cmbObra
            // 
            this.cmbObra.DataSource = this.dsBusObra1;
            this.cmbObra.DisplayMember = "Obra.Idobra";
            this.cmbObra.Location = new System.Drawing.Point(85, 32);
            this.cmbObra.Name = "cmbObra";
            this.cmbObra.Size = new System.Drawing.Size(128, 21);
            this.cmbObra.TabIndex = 30;
            this.cmbObra.ValueMember = "Obra.Idobra";
            this.cmbObra.SelectedIndexChanged += new System.EventHandler(this.cmbObra_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(225, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Consecutivo:";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(296, 6);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(94, 20);
            this.txtConsecutivo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpIni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFin);
            this.groupBox1.Location = new System.Drawing.Point(222, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 66);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas de periodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(80, 18);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(80, 20);
            this.dtpIni.TabIndex = 31;
            this.dtpIni.ValueChanged += new System.EventHandler(this.dtpIni_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Inicial:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(80, 42);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(80, 20);
            this.dtpFin.TabIndex = 32;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged_1);
            // 
            // crysRepCartaEdadTemprana
            // 
            this.crysRepCartaEdadTemprana.ActiveViewIndex = -1;
            this.crysRepCartaEdadTemprana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crysRepCartaEdadTemprana.Cursor = System.Windows.Forms.Cursors.Default;
            this.crysRepCartaEdadTemprana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crysRepCartaEdadTemprana.EnableRefresh = false;
            this.crysRepCartaEdadTemprana.Location = new System.Drawing.Point(0, 153);
            this.crysRepCartaEdadTemprana.Name = "crysRepCartaEdadTemprana";
            this.crysRepCartaEdadTemprana.ShowCloseButton = false;
            this.crysRepCartaEdadTemprana.ShowGroupTreeButton = false;
            this.crysRepCartaEdadTemprana.ShowLogo = false;
            this.crysRepCartaEdadTemprana.Size = new System.Drawing.Size(1196, 508);
            this.crysRepCartaEdadTemprana.TabIndex = 1;
            this.crysRepCartaEdadTemprana.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crysRepCartaEdadTemprana.ToolPanelWidth = 167;
            this.crysRepCartaEdadTemprana.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crysRepCartaEdadTemprana_ReportRefresh);
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
            // dsRepCartaEdadTemprana1
            // 
            this.dsRepCartaEdadTemprana1.DataSetName = "dsRepCartaEdadTemprana";
            this.dsRepCartaEdadTemprana1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsRepCartaEdadTemprana1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAConcretoSolicitado
            // 
            this.sqlDAConcretoSolicitado.SelectCommand = this.sqlSelectCommand5;
            this.sqlDAConcretoSolicitado.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Experiencia", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Fechaini", "Fechaini"),
                        new System.Data.Common.DataColumnMapping("Fechafin", "Fechafin"),
                        new System.Data.Common.DataColumnMapping("Planta", "Planta"),
                        new System.Data.Common.DataColumnMapping("Muestras", "Muestras"),
                        new System.Data.Common.DataColumnMapping("d3a7", "d3a7"),
                        new System.Data.Common.DataColumnMapping("d3aEE", "d3aEE"),
                        new System.Data.Common.DataColumnMapping("d7aEE", "d7aEE"),
                        new System.Data.Common.DataColumnMapping("s3a7", "s3a7"),
                        new System.Data.Common.DataColumnMapping("s3EE", "s3EE"),
                        new System.Data.Common.DataColumnMapping("s7EE", "s7EE"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = resources.GetString("sqlSelectCommand5.CommandText");
            this.sqlSelectCommand5.Connection = this.sqlConn;
            this.sqlSelectCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@Diametro", System.Data.SqlDbType.VarChar, 40, "Diametro")});
            // 
            // sqlDADiametro
            // 
            this.sqlDADiametro.SelectCommand = this.sqlSelectCommand9;
            this.sqlDADiametro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Diametro", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdDiam", "IdDiam"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro")})});
            // 
            // sqlSelectCommand9
            // 
            this.sqlSelectCommand9.CommandText = "SELECT IdDiam, Diametro, Diametro + \' \' + Figura AS Figura FROM Diametro";
            this.sqlSelectCommand9.Connection = this.sqlConn;
            // 
            // sqlDABajosTemp
            // 
            this.sqlDABajosTemp.SelectCommand = this.sqlCommand3;
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
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Finicial", System.Data.SqlDbType.SmallDateTime, 4, "Fensaye"),
            new System.Data.SqlClient.SqlParameter("@Ffinal", System.Data.SqlDbType.SmallDateTime, 4, "Fensaye"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // dsBajosTemp1
            // 
            this.dsBajosTemp1.DataSetName = "dsBajosTemp";
            this.dsBajosTemp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AutoGenerateColumns = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.muestraDataGridViewTextBoxColumn,
            this.idConcreteraDataGridViewTextBoxColumn,
            this.resistenciaKGDataGridViewTextBoxColumn,
            this.desTipoDataGridViewTextBoxColumn,
            this.agregadoDataGridViewTextBoxColumn,
            this.revenimentoDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.Dia,
            this.fensayeDataGridViewTextBoxColumn,
            this.resistenciaDataGridViewTextBoxColumn,
            this.idConcDataGridViewTextBoxColumn,
            this.idLaboratorioDataGridViewTextBoxColumn});
            this.dgvResultado.DataMember = "Agregado";
            this.dgvResultado.DataSource = this.dsBajosTemp1;
            this.dgvResultado.Location = new System.Drawing.Point(391, 82);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResultado.RowTemplate.Height = 18;
            this.dgvResultado.Size = new System.Drawing.Size(665, 71);
            this.dgvResultado.TabIndex = 80;
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            this.idObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObraDataGridViewTextBoxColumn.Width = 40;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MaxInputLength = 8;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 60;
            // 
            // muestraDataGridViewTextBoxColumn
            // 
            this.muestraDataGridViewTextBoxColumn.DataPropertyName = "Muestra";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.muestraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.muestraDataGridViewTextBoxColumn.HeaderText = "Muestra";
            this.muestraDataGridViewTextBoxColumn.Name = "muestraDataGridViewTextBoxColumn";
            this.muestraDataGridViewTextBoxColumn.ReadOnly = true;
            this.muestraDataGridViewTextBoxColumn.Width = 45;
            // 
            // idConcreteraDataGridViewTextBoxColumn
            // 
            this.idConcreteraDataGridViewTextBoxColumn.DataPropertyName = "IdConcretera";
            this.idConcreteraDataGridViewTextBoxColumn.HeaderText = "Premez.";
            this.idConcreteraDataGridViewTextBoxColumn.Name = "idConcreteraDataGridViewTextBoxColumn";
            this.idConcreteraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idConcreteraDataGridViewTextBoxColumn.Width = 60;
            // 
            // resistenciaKGDataGridViewTextBoxColumn
            // 
            this.resistenciaKGDataGridViewTextBoxColumn.DataPropertyName = "ResistenciaKG";
            dataGridViewCellStyle13.Format = "N1";
            dataGridViewCellStyle13.NullValue = null;
            this.resistenciaKGDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.resistenciaKGDataGridViewTextBoxColumn.HeaderText = "Res.sol";
            this.resistenciaKGDataGridViewTextBoxColumn.Name = "resistenciaKGDataGridViewTextBoxColumn";
            this.resistenciaKGDataGridViewTextBoxColumn.ReadOnly = true;
            this.resistenciaKGDataGridViewTextBoxColumn.Width = 50;
            // 
            // desTipoDataGridViewTextBoxColumn
            // 
            this.desTipoDataGridViewTextBoxColumn.DataPropertyName = "DesTipo";
            this.desTipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.desTipoDataGridViewTextBoxColumn.Name = "desTipoDataGridViewTextBoxColumn";
            this.desTipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.desTipoDataGridViewTextBoxColumn.Width = 35;
            // 
            // agregadoDataGridViewTextBoxColumn
            // 
            this.agregadoDataGridViewTextBoxColumn.DataPropertyName = "Agregado";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.agregadoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.agregadoDataGridViewTextBoxColumn.HeaderText = "Tma";
            this.agregadoDataGridViewTextBoxColumn.Name = "agregadoDataGridViewTextBoxColumn";
            this.agregadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.agregadoDataGridViewTextBoxColumn.Width = 28;
            // 
            // revenimentoDataGridViewTextBoxColumn
            // 
            this.revenimentoDataGridViewTextBoxColumn.DataPropertyName = "Revenimento";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.revenimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.revenimentoDataGridViewTextBoxColumn.HeaderText = "Rev";
            this.revenimentoDataGridViewTextBoxColumn.Name = "revenimentoDataGridViewTextBoxColumn";
            this.revenimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.revenimentoDataGridViewTextBoxColumn.Width = 28;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "T.A.";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Width = 35;
            // 
            // Dia
            // 
            this.Dia.DataPropertyName = "Dia";
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.Width = 25;
            // 
            // fensayeDataGridViewTextBoxColumn
            // 
            this.fensayeDataGridViewTextBoxColumn.DataPropertyName = "Fensaye";
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            this.fensayeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.fensayeDataGridViewTextBoxColumn.HeaderText = "Fensaye";
            this.fensayeDataGridViewTextBoxColumn.Name = "fensayeDataGridViewTextBoxColumn";
            this.fensayeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fensayeDataGridViewTextBoxColumn.Width = 60;
            // 
            // resistenciaDataGridViewTextBoxColumn
            // 
            this.resistenciaDataGridViewTextBoxColumn.DataPropertyName = "Resistencia";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N1";
            dataGridViewCellStyle17.NullValue = null;
            this.resistenciaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.resistenciaDataGridViewTextBoxColumn.HeaderText = "Res.obt.";
            this.resistenciaDataGridViewTextBoxColumn.Name = "resistenciaDataGridViewTextBoxColumn";
            this.resistenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.resistenciaDataGridViewTextBoxColumn.Width = 50;
            // 
            // idConcDataGridViewTextBoxColumn
            // 
            this.idConcDataGridViewTextBoxColumn.DataPropertyName = "IdConc";
            this.idConcDataGridViewTextBoxColumn.HeaderText = "Experiencia";
            this.idConcDataGridViewTextBoxColumn.Name = "idConcDataGridViewTextBoxColumn";
            this.idConcDataGridViewTextBoxColumn.ReadOnly = true;
            this.idConcDataGridViewTextBoxColumn.Width = 60;
            // 
            // idLaboratorioDataGridViewTextBoxColumn
            // 
            this.idLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "IdLaboratorio";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idLaboratorioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.idLaboratorioDataGridViewTextBoxColumn.HeaderText = "Lab";
            this.idLaboratorioDataGridViewTextBoxColumn.Name = "idLaboratorioDataGridViewTextBoxColumn";
            this.idLaboratorioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLaboratorioDataGridViewTextBoxColumn.Width = 28;
            // 
            // RepCartaEdadTemprana
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1196, 661);
            this.Controls.Add(this.crysRepCartaEdadTemprana);
            this.Controls.Add(this.panel1);
            this.Name = "RepCartaEdadTemprana";
            this.Text = "RepCartaEdadTemprana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepCartaEdadTemprana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMues1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMueN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretoSolicitado1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepCartaEdadTemprana1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBajosTemp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void RepCartaEdadTemprana_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsBusObra1,"Obra");
			sqlDATipoPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			sqlDAPLanta.SelectCommand.Parameters[0].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1,"Planta");
			dtpIni.Value = DateTime.Today.AddDays(-30);
			dtpFin.Value = DateTime.Today;
			sqlDADiametro.Fill(dsDiametro1, "Diametro");
			cmbIdDiam.SelectedIndex = 0;
			LlenasSqlDA();
		}
		private void LlenasSqlDA()
		{
			dsExpMueN1.Clear();
			sqlDAExpMues.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Value;
			sqlDAExpMues.SelectCommand.Parameters["@FechaFin"].Value  = dtpFin.Value.AddHours(23).AddMinutes(59).AddSeconds(59);;
			sqlDAExpMues.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAExpMues.SelectCommand.Parameters["@IdObra"].Value = cmbObra.SelectedValue.ToString();
			sqlDAExpMues.Fill(dsExpMueN1, "Muestras");
		}
		
		private void buscaBtn1_Click_1(object sender, System.EventArgs e)
		{
			dsConcretoSolicitado1.Clear();
			sqlDAConcretoSolicitado.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAConcretoSolicitado.SelectCommand.Parameters["@Diametro"].Value = dsDiametro1.Tables[0].Rows[cmbIdDiam.SelectedIndex][2] ;
			sqlDAConcretoSolicitado.Fill(dsConcretoSolicitado1, "Experiencia");
			//Si no cambio la fecha no hay que volver a cargar el dataset.
			//if(blnCambioFecha)on
			//{
				LlenasSqlDA();				
			//}

			if(dsExpMueN1.Tables["Muestras"].Rows.Count > 0)
			{
				if(buscaBtn1.ResultadoDialogo == DialogResult.OK) 
				{
					//txtPlanta.Text = dsExpMueN1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
					txtResistencia.Text  = dsExpMueN1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
					txtTipo.Text  = dsExpMueN1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
					txtAgregado.Text  = dsExpMueN1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString();
					txtRevenimento.Text  = dsExpMueN1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
					txtTipoAgregado.Text  = dsExpMueN1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString();
					if(txtResistencia.Text.Length > 0)
					{
						//tbBtnGenExp.Visible = true;
					}
				}
			}
			blnCambioFecha = false;
		}

		private void tbBtn1_Click(object sender, System.EventArgs e)
		{
            int dia1 = 3;
            int dia2 = 7;
            int i = dgvResultado.CurrentRow.Index;
            DateTime Finicial = DateTime.Parse(dsBajosTemp1.Agregado.Rows[i][1].ToString());
            DateTime Ffinal = DateTime.Parse(dsBajosTemp1.Agregado.Rows[i][1].ToString());
            Finicial = Finicial.AddHours(-Finicial.Hour).AddMinutes(-Finicial.Minute).AddSeconds(-Finicial.Second);
            Ffinal = Finicial.AddHours(23).AddMinutes(59).AddSeconds(59);
            double factor = double.Parse(dsUnidad1.Unidad.Rows[cmbUnidad.SelectedIndex][2].ToString());
            double Res = double.Parse(dsBajosTemp1.Agregado.Rows[i][6].ToString()) * factor;
            double incD3EE = (dsBajosTemp1.Agregado.Rows[i]["Dia"].ToString() == "3" ? double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString()) : double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString()));
            double incD7EE = (dsBajosTemp1.Agregado.Rows[i]["Dia"].ToString() == "3" ? double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString()) : double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString()));
            switch (int.Parse(dsBajosTemp1.Agregado.Rows[i][7].ToString()))
              {
                  case 1:
                  case 2:
                      dia1 = 3;
                      dia2 = 7;
                      incD3EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString());
                      incD7EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString());
                      if (dsBajosTemp1.Agregado.Rows[i]["Dia"].ToString() == "7")
                      {
                          incD3EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString());
                          incD7EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString());
                      }
                      break;
                  case 6:
                  case 11:
                      dia1 = 1;
                      dia2 = 3;
                      incD3EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString());
                      incD7EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString());
                      break;
                  case 7:
                  case 12:
                      dia1 = -2;
                      dia2 = 1;
                      incD3EE = 0;
                      incD7EE = 0;
                      break;
                  case 8:
                  case 13:
                      dia1 = -1;
                      dia2 = -2;
                      incD3EE = 0;
                      incD7EE = 0;
                      break;
                  default:
                      dia1 = 3;
                      dia2 = 7;
                      incD3EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString());
                      incD7EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString());
                      break;
              }
            incD3EE = incD3EE * factor;
            incD7EE = incD7EE * factor;
            string resis = (cmbUnidad.SelectedIndex == 0 ? Res.ToString() : Res.ToString("###.00")) + " - " + dsBajosTemp1.Agregado.Rows[i][21].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][8].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][9].ToString();
            dsRepCartaEdadTemprana1.Clear();
            sqlDACartaEdadTemp.SelectCommand.Parameters["@FechaIni"].Value = Finicial;
            sqlDACartaEdadTemp.SelectCommand.Parameters["@FechaFin"].Value = Ffinal;
            sqlDACartaEdadTemp.SelectCommand.Parameters["@IncD3EE"].Value = incD3EE;
            sqlDACartaEdadTemp.SelectCommand.Parameters["@IncD7EE"].Value = incD7EE;
            sqlDACartaEdadTemp.SelectCommand.Parameters["@ResistenciaKG"].Value = dsBajosTemp1.Agregado.Rows[i][6].ToString();
            sqlDACartaEdadTemp.SelectCommand.Parameters["@IdObra"].Value = dsBajosTemp1.Agregado.Rows[i][0].ToString();
            sqlDACartaEdadTemp.SelectCommand.Parameters["@IdConcretera"].Value = dsBajosTemp1.Agregado.Rows[i][5].ToString();
            sqlDACartaEdadTemp.SelectCommand.Parameters["@Tipo"].Value = dsBajosTemp1.Agregado.Rows[i][7].ToString();
            sqlDACartaEdadTemp.SelectCommand.Parameters["@Agregado"].Value = dsBajosTemp1.Agregado.Rows[i][8].ToString();
            sqlDACartaEdadTemp.SelectCommand.Parameters["@Renvenimiento"].Value = dsBajosTemp1.Agregado.Rows[i][9].ToString();
            sqlDACartaEdadTemp.SelectCommand.Parameters["@IdAgregado"].Value = dsBajosTemp1.Agregado.Rows[i][11].ToString();
            sqlDACartaEdadTemp.SelectCommand.Parameters["@IdPrueba"].Value = dsBajosTemp1.Agregado.Rows[i][18].ToString();
            sqlDACartaEdadTemp.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString(); ;
            sqlDACartaEdadTemp.SelectCommand.Parameters["@IdDiam"].Value = dsBajosTemp1.Agregado.Rows[i][19].ToString();

            sqlDACartaEdadTemp.Fill(dsRepCartaEdadTemprana1, "RepCartaEdadTemprana");
            if (chkMortero.Checked != true)
            {
                resis = (cmbUnidad.SelectedIndex == 0 ? Res.ToString() : Res.ToString("###.00")) + " - " + dsBajosTemp1.Agregado.Rows[i][21].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][8].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][9].ToString();
                cryRepCartaEdadTemprana = new CryRepCartaEdadTemprana();
                cryRepCartaEdadTemprana.SetDataSource(dsRepCartaEdadTemprana1);
                cryRepCartaEdadTemprana.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cryRepCartaEdadTemprana.SetParameterValue("@Leyenda", true);
                cryRepCartaEdadTemprana.SetParameterValue("@Lab", true);

                cryRepCartaEdadTemprana.SetParameterValue("Razonsocial", strRazonSocial);
                cryRepCartaEdadTemprana.SetParameterValue("ObraUbicacion", strObraUbicacion);
                cryRepCartaEdadTemprana.SetParameterValue("ObraColonia", strObraColonia);
                cryRepCartaEdadTemprana.SetParameterValue("TipoPrueba", "COMPRESIÓN");
                cryRepCartaEdadTemprana.SetParameterValue("Exp3", incD3EE);
                cryRepCartaEdadTemprana.SetParameterValue("Exp7", incD7EE);
                cryRepCartaEdadTemprana.SetParameterValue("Unidad", dsUnidad1.Unidad.Rows[cmbUnidad.SelectedIndex][1].ToString());
                cryRepCartaEdadTemprana.SetParameterValue("Logotipo", " ");
                cryRepCartaEdadTemprana.SetParameterValue("Consecutivo", "0");
                cryRepCartaEdadTemprana.SetParameterValue("Res", resis);
                cryRepCartaEdadTemprana.SetParameterValue("Concre", dsBajosTemp1.Agregado.Rows[i][5].ToString());
                cryRepCartaEdadTemprana.SetParameterValue("Diam", dsBajosTemp1.Agregado.Rows[i][24].ToString());
                cryRepCartaEdadTemprana.SetParameterValue("Res1", Res);
                cryRepCartaEdadTemprana.SetParameterValue("Tipo", dsBajosTemp1.Agregado.Rows[i][7].ToString());
                cryRepCartaEdadTemprana.SetParameterValue("Dia1", dia1);
                cryRepCartaEdadTemprana.SetParameterValue("Dia2", dia2);
                //SetCrysParams();
                crysRepCartaEdadTemprana.ReportSource = cryRepCartaEdadTemprana;
            }
            else
            {
                resis = (cmbUnidad.SelectedIndex == 0 ? Res.ToString() : Res.ToString("###.00")) + " - " + dsBajosTemp1.Agregado.Rows[i][21].ToString() ;
                cryRepCartaEdadTempranM1 = new CryRepCartaEdadTempranM();
                cryRepCartaEdadTempranM1.SetDataSource(dsRepCartaEdadTemprana1);
                cryRepCartaEdadTempranM1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cryRepCartaEdadTempranM1.SetParameterValue("@Leyenda", true);
                cryRepCartaEdadTempranM1.SetParameterValue("@Lab", true);

                cryRepCartaEdadTempranM1.SetParameterValue("Razonsocial", strRazonSocial);
                cryRepCartaEdadTempranM1.SetParameterValue("ObraUbicacion", strObraUbicacion);
                cryRepCartaEdadTempranM1.SetParameterValue("ObraColonia", strObraColonia);
                cryRepCartaEdadTempranM1.SetParameterValue("TipoPrueba", "COMPRESIÓN");
                cryRepCartaEdadTempranM1.SetParameterValue("Exp3", incD3EE);
                cryRepCartaEdadTempranM1.SetParameterValue("Exp7", incD7EE);
                cryRepCartaEdadTempranM1.SetParameterValue("Unidad", dsUnidad1.Unidad.Rows[cmbUnidad.SelectedIndex][1].ToString());
                cryRepCartaEdadTempranM1.SetParameterValue("Logotipo", " ");
                cryRepCartaEdadTempranM1.SetParameterValue("Consecutivo", "0");
                cryRepCartaEdadTempranM1.SetParameterValue("Res", resis);
                cryRepCartaEdadTempranM1.SetParameterValue("Concre", dsBajosTemp1.Agregado.Rows[i][5].ToString());
                cryRepCartaEdadTempranM1.SetParameterValue("Diam", dsBajosTemp1.Agregado.Rows[i][24].ToString());
                cryRepCartaEdadTempranM1.SetParameterValue("Res1", Res);
                cryRepCartaEdadTempranM1.SetParameterValue("Tipo", dsBajosTemp1.Agregado.Rows[i][7].ToString());
                cryRepCartaEdadTempranM1.SetParameterValue("Dia1", dia1);
                cryRepCartaEdadTempranM1.SetParameterValue("Dia2", dia2);
                //SetCrysParams();
                crysRepCartaEdadTemprana.ReportSource = cryRepCartaEdadTempranM1;
            }

		}

		private void cmbObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			blnCambioFecha = true;
			cmbConcretera_SelectedIndexChanged_1(sender,e);
			GetDatosEmpresa();
            dsBajosTemp1.Clear();
            sqlDABajosTemp.SelectCommand.Parameters["@Finicial"].Value = dtpIni.Value;
            sqlDABajosTemp.SelectCommand.Parameters["@Ffinal"].Value = dtpFin.Value;
            sqlDABajosTemp.SelectCommand.Parameters["@IdObra"].Value = cmbObra.SelectedValue;
            sqlDABajosTemp.Fill(dsBajosTemp1, "Agregado");
		}

		private void cmbConcretera_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
			//if(blnCambioFecha)
			//{
				LlenasSqlDA();				
			//}
		}

		private void dtpIni_ValueChanged_1(object sender, System.EventArgs e)
		{
			blnCambioFecha = true;
			cmbConcretera_SelectedIndexChanged_1(sender,e);	
		}

		private void dtpFin_ValueChanged_1(object sender, System.EventArgs e)
		{
			blnCambioFecha = true;
			cmbConcretera_SelectedIndexChanged_1(sender,e);
		}

		private void crysRepCartaEdadTemprana_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
		{
			SetCrysParams();
			crysRepCartaEdadTemprana.ReportSource = cryRepCartaEdadTemprana;
		}

		private void SetCrysParams()
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
			ParameterDiscreteValue pdvRes1 = new CrystalDecisions.Shared.ParameterDiscreteValue();

			pdvRazonsocial.Value = strRazonSocial;
			pvs.Add(pdvRazonsocial);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Razonsocial"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvObraUbicacion.Value = strObraUbicacion;
			pvs.Add(pdvObraUbicacion);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["ObraUbicacion"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvObraColonia.Value = strObraColonia;
			pvs.Add(pdvObraColonia);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["ObraColonia"].ApplyCurrentValues(pvs);
			pvs.Clear();
				
			pdvTipoPrueba.Value = cmbPrueba.Text.ToUpper();
			pvs.Add(pdvTipoPrueba);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["TipoPrueba"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvExp3.Value = double.Parse(txt3d.Text) * double.Parse(dsUnidad1.Tables[0].Rows[int.Parse(cmbUnidad.SelectedIndex.ToString())][2].ToString());
			pvs.Add(pdvExp3);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Exp3"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvExp7.Value = double.Parse(txt7d.Text) * double.Parse(dsUnidad1.Tables[0].Rows[int.Parse(cmbUnidad.SelectedIndex.ToString())][2].ToString());
			pvs.Add(pdvExp7);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Exp7"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvUnidad.Value = cmbUnidad.Text.ToString();
			pvs.Add(pdvUnidad);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Unidad"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvSINO.Value = rdNO.Checked ? 0 : 1;
			pvs.Add(pdvSINO);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Logotipo"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvConsecutivo.Value = txtConsecutivo.Text.Length > 0 ? txtConsecutivo.Text : "0";
			pvs.Add(pdvConsecutivo);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Consecutivo"].ApplyCurrentValues(pvs);
			pvs.Clear();
			string resis;
			double resis1;
			resis1 = double.Parse(txtResistencia.Text) * double.Parse(dsUnidad1.Tables[0].Rows[int.Parse(cmbUnidad.SelectedIndex.ToString())][2].ToString());
			if (double.Parse(dsUnidad1.Tables[0].Rows[int.Parse(cmbUnidad.SelectedIndex.ToString())][2].ToString()) == 1)
				resis = txtResistencia.Text;
			else
				resis = resis1.ToString("###.00");
			pdvRes.Value = resis  + " - " + txtTipo.Text + " - " + txtAgregado.Text + " - " + txtRevenimento.Text ;
			pvs.Add(pdvRes);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Res"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvConcre.Value = cmbConcretera.Text ;
			pvs.Add(pdvConcre);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Concre"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvDiam.Value = cmbIdDiam.SelectedValue.ToString() ;
			pvs.Add(pdvDiam);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Diam"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvRes1.Value = double.Parse(resis) ;
			pvs.Add(pdvRes1);
			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Res1"].ApplyCurrentValues(pvs);
			pvs.Clear();
		}
		private void GetDatosEmpresa()
		{
			String strSql = " Select O.informes as Facturar, O.Ubicacion, O.Colonia from Obra O ";
//				strSql += " Join RazonSocial RS on RS.RFC = O.RFC ";
				strSql += " Where O.IdObra = '" + cmbObra.SelectedValue.ToString() + "'";
			SqlCommand sqlCmd  = new SqlCommand(strSql, sqlConn);
			try
			{
				sqlConn.Open();
				SqlDataReader dr = sqlCmd.ExecuteReader();
				if(dr.Read())
				{	
					strRazonSocial = dr["Facturar"].ToString();
					strObraUbicacion = dr["Ubicacion"].ToString();
					strObraColonia = dr["Colonia"].ToString();
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

		private void buscaBtn2_Click(object sender, System.EventArgs e)
		{
			if(buscaBtn2.ResultadoDialogo == DialogResult.OK)
			{				
				txt3d.Text = dsConcretoSolicitado1.Tables[0].Rows[buscaBtn2.RegistroSeleccionado][13].ToString();
				txt7d.Text = dsConcretoSolicitado1.Tables[0].Rows[buscaBtn2.RegistroSeleccionado][14].ToString();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
//			PageSetupDialog  psd = new PageSetupDialog();
//			psd.
//			psd.ShowDialog();
			pageSetupDialog1.Document = new System.Drawing.Printing.PrintDocument();
			pageSetupDialog1.ShowDialog();
			this.cryRepCartaEdadTemprana.PrintOptions.ApplyPageMargins(new PageMargins(pageSetupDialog1.PageSettings.Margins.Left,pageSetupDialog1.PageSettings.Margins.Top,pageSetupDialog1.PageSettings.Margins.Right,pageSetupDialog1.PageSettings.Margins.Bottom));
		}

		private void tbBtn1_Load(object sender, System.EventArgs e)
		{
		
		}

		private void chbLab_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void chbLeyenda_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}	
	}
}