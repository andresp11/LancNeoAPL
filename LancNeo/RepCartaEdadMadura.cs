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
	/// Descripción breve de RepCartaEdadMadura.
	/// </summary>
	public class RepCartaEdadMadura : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rdSI;
		private System.Windows.Forms.RadioButton rdNO;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
		private String strRazonSocial;
		private String strObraUbicacion;
		private String strObraColonia;
		private System.Windows.Forms.TextBox txtConsecutivo;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPromedios;
		private System.Data.SqlClient.SqlCommand sqlCommand3;
		private LancNeo.dsExpMues dsExpMues1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAMuestras;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private LancNeo.dsExpMuesEE dsExpMuesEE1;
		private LancNeo.dsDiametro dsDiametro1;
		private System.Data.SqlClient.SqlDataAdapter sqlDADiametro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
		private System.Windows.Forms.ComboBox cmbIdDiam;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox chkTodas;
		private LancNeo.CryRepCartaEdadMadura cryRepCartaEdadMadura1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crysRepCartaEdadMadura;
		private System.Windows.Forms.CheckBox chbLeyenda;
		private System.Windows.Forms.CheckBox chbLab;
        private dsExpMueO dsExpMueO1;
		
		private System.ComponentModel.IContainer components;
		

		public RepCartaEdadMadura()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepCartaEdadMadura));
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
            this.dsExpMueO1 = new LancNeo.dsExpMueO();
            this.dsExpMues1 = new LancNeo.dsExpMues();
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
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.chkTodas = new System.Windows.Forms.CheckBox();
            this.cmbIdDiam = new System.Windows.Forms.ComboBox();
            this.dsDiametro1 = new LancNeo.dsDiametro();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdSI = new System.Windows.Forms.RadioButton();
            this.rdNO = new System.Windows.Forms.RadioButton();
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
            this.crysRepCartaEdadMadura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAPromedios = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAMuestras = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsExpMuesEE1 = new LancNeo.dsExpMuesEE();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.cryRepCartaEdadMadura1 = new LancNeo.CryRepCartaEdadMadura();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMueO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMues1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMuesEE1)).BeginInit();
            this.SuspendLayout();
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
            this.buscaBtn1.Datos = this.dsExpMueO1.Muestras;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(458, 8);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 55;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Seleccionar concreto solicitado");
            this.buscaBtn1.Load += new System.EventHandler(this.buscaBtn1_Load);
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click_1);
            // 
            // dsExpMueO1
            // 
            this.dsExpMueO1.DataSetName = "dsExpMueO";
            this.dsExpMueO1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsExpMues1
            // 
            this.dsExpMues1.DataSetName = "dsExpMues";
            this.dsExpMues1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsExpMues1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
                        new System.Data.Common.DataColumnMapping("N° muestras", "N° muestras"),
                        new System.Data.Common.DataColumnMapping("Tp", "Tp")})});
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
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.tbBtn1);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.chkTodas);
            this.panel1.Controls.Add(this.cmbIdDiam);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.groupBox3);
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
            this.panel1.Size = new System.Drawing.Size(1028, 127);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(850, 14);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 56;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.Location = new System.Drawing.Point(458, 104);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 24);
            this.chbLab.TabIndex = 78;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.Checked = true;
            this.chbLeyenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLeyenda.Location = new System.Drawing.Point(777, 104);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(116, 24);
            this.chbLeyenda.TabIndex = 60;
            this.chbLeyenda.Text = "Formato leyenda";
            // 
            // chkTodas
            // 
            this.chkTodas.Checked = true;
            this.chkTodas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTodas.Location = new System.Drawing.Point(600, 104);
            this.chkTodas.Name = "chkTodas";
            this.chkTodas.Size = new System.Drawing.Size(104, 24);
            this.chkTodas.TabIndex = 59;
            this.chkTodas.Text = "Imprime todas";
            // 
            // cmbIdDiam
            // 
            this.cmbIdDiam.DataSource = this.dsDiametro1;
            this.cmbIdDiam.DisplayMember = "Diametro.Figura";
            this.cmbIdDiam.Location = new System.Drawing.Point(85, 104);
            this.cmbIdDiam.Name = "cmbIdDiam";
            this.cmbIdDiam.Size = new System.Drawing.Size(128, 21);
            this.cmbIdDiam.TabIndex = 58;
            this.cmbIdDiam.ValueMember = "IdDiam";
            // 
            // dsDiametro1
            // 
            this.dsDiametro1.DataSetName = "dsDiametro";
            this.dsDiametro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDiametro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "F. geométrica:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdSI);
            this.groupBox3.Controls.Add(this.rdNO);
            this.groupBox3.Location = new System.Drawing.Point(246, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 40);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logotipo";
            // 
            // rdSI
            // 
            this.rdSI.Checked = true;
            this.rdSI.Location = new System.Drawing.Point(76, 13);
            this.rdSI.Name = "rdSI";
            this.rdSI.Size = new System.Drawing.Size(39, 24);
            this.rdSI.TabIndex = 0;
            this.rdSI.TabStop = true;
            this.rdSI.Text = "SI";
            // 
            // rdNO
            // 
            this.rdNO.Location = new System.Drawing.Point(134, 13);
            this.rdNO.Name = "rdNO";
            this.rdNO.Size = new System.Drawing.Size(39, 24);
            this.rdNO.TabIndex = 0;
            this.rdNO.Text = "NO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 24);
            this.label12.TabIndex = 51;
            this.label12.Text = " Carta Edad Madura";
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(600, 80);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(83, 21);
            this.cmbPrueba.TabIndex = 49;
            this.cmbPrueba.ValueMember = "IdPrueba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 82);
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
            this.cmbUnidad.Location = new System.Drawing.Point(601, 53);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(83, 21);
            this.cmbUnidad.TabIndex = 35;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 56);
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
            this.label7.Location = new System.Drawing.Point(530, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Resistencia:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Tipo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResistencia
            // 
            this.txtResistencia.Location = new System.Drawing.Point(601, 7);
            this.txtResistencia.Name = "txtResistencia";
            this.txtResistencia.ReadOnly = true;
            this.txtResistencia.Size = new System.Drawing.Size(83, 20);
            this.txtResistencia.TabIndex = 45;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(601, 30);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(83, 20);
            this.txtTipo.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(697, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Revenimento:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(713, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Agregado:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(689, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Tipo Agregado:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAgregado
            // 
            this.txtAgregado.Location = new System.Drawing.Point(777, 7);
            this.txtAgregado.Name = "txtAgregado";
            this.txtAgregado.ReadOnly = true;
            this.txtAgregado.Size = new System.Drawing.Size(64, 20);
            this.txtAgregado.TabIndex = 42;
            // 
            // txtTipoAgregado
            // 
            this.txtTipoAgregado.Location = new System.Drawing.Point(777, 54);
            this.txtTipoAgregado.Name = "txtTipoAgregado";
            this.txtTipoAgregado.ReadOnly = true;
            this.txtTipoAgregado.Size = new System.Drawing.Size(64, 20);
            this.txtTipoAgregado.TabIndex = 43;
            // 
            // txtRevenimento
            // 
            this.txtRevenimento.Location = new System.Drawing.Point(777, 30);
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
            this.label17.Location = new System.Drawing.Point(701, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Consecutivo:";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(777, 78);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(64, 20);
            this.txtConsecutivo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpIni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFin);
            this.groupBox1.Location = new System.Drawing.Point(246, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas de periodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(80, 20);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(80, 20);
            this.dtpIni.TabIndex = 31;
            this.dtpIni.ValueChanged += new System.EventHandler(this.dtpIni_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Inicial:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(80, 47);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(80, 20);
            this.dtpFin.TabIndex = 32;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged_1);
            // 
            // crysRepCartaEdadMadura
            // 
            this.crysRepCartaEdadMadura.ActiveViewIndex = -1;
            this.crysRepCartaEdadMadura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crysRepCartaEdadMadura.Cursor = System.Windows.Forms.Cursors.Default;
            this.crysRepCartaEdadMadura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crysRepCartaEdadMadura.EnableRefresh = false;
            this.crysRepCartaEdadMadura.Location = new System.Drawing.Point(0, 127);
            this.crysRepCartaEdadMadura.Name = "crysRepCartaEdadMadura";
            this.crysRepCartaEdadMadura.ShowCloseButton = false;
            this.crysRepCartaEdadMadura.ShowGroupTreeButton = false;
            this.crysRepCartaEdadMadura.ShowLogo = false;
            this.crysRepCartaEdadMadura.Size = new System.Drawing.Size(1028, 534);
            this.crysRepCartaEdadMadura.TabIndex = 1;
            this.crysRepCartaEdadMadura.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crysRepCartaEdadMadura.ToolPanelWidth = 167;
            this.crysRepCartaEdadMadura.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crysRepCartaEdadMadura_ReportRefresh);
            // 
            // sqlDAPromedios
            // 
            this.sqlDAPromedios.SelectCommand = this.sqlCommand3;
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "[PromediosMadura]";
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
            // RepCartaEdadMadura
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1028, 661);
            this.Controls.Add(this.crysRepCartaEdadMadura);
            this.Controls.Add(this.panel1);
            this.Name = "RepCartaEdadMadura";
            this.Text = "RepCartaEdadMadura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepCartaEdadMadura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMueO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMues1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMuesEE1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void RepCartaEdadMadura_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsBusObra1,"Obra");
			sqlDATipoPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			sqlDAPLanta.SelectCommand.Parameters[0].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1,"Planta");
			sqlDADiametro.Fill(dsDiametro1,"Diametro");
			cmbIdDiam.SelectedIndex = 0;
			dtpIni.Value = DateTime.Today;
			dtpFin.Value = DateTime.Today;
			LlenasSqlDA();
		}
		private void LlenasSqlDA()
		{
			dsExpMueO1.Clear();
			sqlDAExpMues.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Value;
			sqlDAExpMues.SelectCommand.Parameters["@FechaFin"].Value  = dtpFin.Value;
			sqlDAExpMues.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAExpMues.SelectCommand.Parameters["@IdObra"].Value = cmbObra.SelectedValue.ToString();
			sqlDAExpMues.Fill(dsExpMueO1, "Muestras");
		}
		
		private void buscaBtn1_Click_1(object sender, System.EventArgs e)
		{
			//Si no cambio la fecha no hay que volver a cargar el dataset.
			//if(blnCambioFecha)
			//{
				LlenasSqlDA();				
			//}

			if(dsExpMueO1.Tables["Muestras"].Rows.Count > 0)
			{
				if(buscaBtn1.ResultadoDialogo == DialogResult.OK) 
				{
					//txtPlanta.Text = dsExpMueO1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
					txtResistencia.Text  = dsExpMueO1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
					txtTipo.Text  = dsExpMueO1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
					txtAgregado.Text  = dsExpMueO1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString();
					txtRevenimento.Text  = dsExpMueO1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
					txtTipoAgregado.Text  = dsExpMueO1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString();
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
            try
			{

				dsExpMuesEE1.Clear();
				sqlDAMuestras.SelectCommand.Parameters["@IdObra"].Value = cmbObra.SelectedValue.ToString();
				sqlDAMuestras.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString() ;
//				sqlDAMuestras.SelectCommand.Parameters["@IdPlanta"].Value = -1;
				sqlDAMuestras.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Value;
				sqlDAMuestras.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Value;
				sqlDAMuestras.SelectCommand.Parameters["@ResistenciaKg"].Value = txtResistencia.Text;
				sqlDAMuestras.SelectCommand.Parameters["@Tipo"].Value = dsExpMueO1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][7].ToString();
				sqlDAMuestras.SelectCommand.Parameters["@Agregado"].Value = txtAgregado.Text;
				sqlDAMuestras.SelectCommand.Parameters["@Revenimiento"].Value = txtRevenimento.Text;
				sqlDAMuestras.SelectCommand.Parameters["@IdAgregado"].Value = txtTipoAgregado.Text;
				sqlDAMuestras.Fill(dsExpMuesEE1, "Muestras");
				sqlDAPromedios.SelectCommand.Parameters["@IdObra"].Value = cmbObra.SelectedValue.ToString();
				sqlDAPromedios.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString() ;
				sqlDAPromedios.SelectCommand.Parameters["@IdPlanta"].Value = -1;
				sqlDAPromedios.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
				sqlDAPromedios.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
				sqlDAPromedios.SelectCommand.Parameters["@ResistenciaKg"].Value = txtResistencia.Text;
				sqlDAPromedios.SelectCommand.Parameters["@Tipo"].Value = dsExpMueO1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][7].ToString();
				sqlDAPromedios.SelectCommand.Parameters["@Agregado"].Value = txtAgregado.Text;
				sqlDAPromedios.SelectCommand.Parameters["@Renvenimiento"].Value = txtRevenimento.Text;
				sqlDAPromedios.SelectCommand.Parameters["@IdAgregado"].Value = txtTipoAgregado.Text;
				sqlDAPromedios.SelectCommand.Parameters["@IdPrueba"].Value = cmbPrueba.SelectedValue.ToString();
				sqlDAPromedios.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
				sqlDAPromedios.SelectCommand.Parameters["@Todos"].Value = chkTodas.Checked;
				sqlDAPromedios.SelectCommand.Parameters["@IdDiam"].Value = cmbIdDiam.SelectedValue.ToString();
				sqlDAPromedios.Fill(dsExpMuesEE1, "Promedios");


				cryRepCartaEdadMadura1 = new CryRepCartaEdadMadura();
				cryRepCartaEdadMadura1.SetDataSource(dsExpMuesEE1);
                SetCrysParams();
                cryRepCartaEdadMadura1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
				cryRepCartaEdadMadura1.SetParameterValue("@Lab", chbLab.Checked);
				crysRepCartaEdadMadura.ReportSource = cryRepCartaEdadMadura1;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}
		}

		private void cmbObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			blnCambioFecha = true;
			cmbConcretera_SelectedIndexChanged_1(sender,e);
			GetDatosEmpresa();
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

		private void crysRepCartaEdadMadura_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
		{
			SetCrysParams();
			crysRepCartaEdadMadura.ReportSource = cryRepCartaEdadMadura1;
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

			pdvRazonsocial.Value = strRazonSocial;
			pvs.Add(pdvRazonsocial);
			cryRepCartaEdadMadura1.DataDefinition.ParameterFields["Razonsocial"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvObraUbicacion.Value = strObraUbicacion;
			pvs.Add(pdvObraUbicacion);
			cryRepCartaEdadMadura1.DataDefinition.ParameterFields["ObraUbicacion"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvObraColonia.Value = strObraColonia;
			pvs.Add(pdvObraColonia);
			cryRepCartaEdadMadura1.DataDefinition.ParameterFields["ObraColonia"].ApplyCurrentValues(pvs);
			pvs.Clear();
				
			pdvTipoPrueba.Value = cmbPrueba.Text.ToUpper();
			pvs.Add(pdvTipoPrueba);
			cryRepCartaEdadMadura1.DataDefinition.ParameterFields["TipoPrueba"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvUnidad.Value = cmbUnidad.Text.ToString();
			pvs.Add(pdvUnidad);
			cryRepCartaEdadMadura1.DataDefinition.ParameterFields["Unidad"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvSINO.Value = rdNO.Checked ? 0 : 1;
			pvs.Add(pdvSINO);
			cryRepCartaEdadMadura1.DataDefinition.ParameterFields["Logotipo"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvConsecutivo.Value = txtConsecutivo.Text.Length > 0 ? txtConsecutivo.Text : "0";
			pvs.Add(pdvConsecutivo);
			cryRepCartaEdadMadura1.DataDefinition.ParameterFields["Consecutivo"].ApplyCurrentValues(pvs);
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
			cryRepCartaEdadMadura1.DataDefinition.ParameterFields["Res"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvConcre.Value = cmbConcretera.Text ;
			pvs.Add(pdvConcre);
			cryRepCartaEdadMadura1.DataDefinition.ParameterFields["Concre"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvDiam.Value = cmbIdDiam.SelectedValue.ToString() ;
			pvs.Add(pdvDiam);
			cryRepCartaEdadMadura1.DataDefinition.ParameterFields["Diam"].ApplyCurrentValues(pvs);
			pvs.Clear();

//			pdvRes1.Value = double.Parse(resis) ;
//			pvs.Add(pdvRes1);
//			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Res1"].ApplyCurrentValues(pvs);
//			pvs.Clear();
		}
		private void GetDatosEmpresa()
		{
			String strSql = " Select O.informes as Facturar, O.Ubicacion, O.Colonia from Obra O ";
				strSql += " Join RazonSocial RS on RS.RFC = O.RFC ";
				strSql += " Where O.IdObra = '" + cmbObra.SelectedValue.ToString() + "'";
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
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

        private void buscaBtn1_Load(object sender, EventArgs e)
        {

        }	
	}
}