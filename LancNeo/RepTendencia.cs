using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ZedGraph;
using System.IO;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de RepTendencia.
	/// </summary>
	public class RepTendencia : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPLanta;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsUnidad dsUnidad1;
		private LancNeo.dsPlanta dsPlanta1;
		private LancNeo.dsConcretera dsConcretera1;
		private System.Windows.Forms.Panel panel1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.ComboBox cmbUnidad;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpIni;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcreto;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepTendencia;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDATendencia;
		private LancNeo.CryRepTendencia cryRepTendencia1;
		private LancNeo.dsDiametro dsDiametro1;
		private System.Data.SqlClient.SqlDataAdapter sqlDADiametro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmbDiam1;
		private System.Data.SqlClient.SqlDataAdapter sqlDARes;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private System.Windows.Forms.Label label6;
		private LancNeo.dsBusResistencia dsBusResistencia1;
		private System.Windows.Forms.ComboBox cmbRes;
		private LancNeo.dsPlanta dsPlanta2;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlCommand sqlCommand3;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
		private System.Data.SqlClient.SqlCommand sqlCommand4;
		private LancNeo.dsConcretera dsConcretera2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbConcretera;
		private System.Windows.Forms.ComboBox cmbPlanta;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrueba;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsTipoPrueba dsTipoPrueba1;
		private System.Windows.Forms.ComboBox cmbPrueba;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtPri;
		private System.Windows.Forms.TextBox txtMpri;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtMseg;
		private System.Windows.Forms.TextBox txtSeg;
		private System.Windows.Forms.TextBox txtMcua;
		private System.Windows.Forms.TextBox txtCua;
		private System.Windows.Forms.TextBox txtMter;
		private System.Windows.Forms.TextBox txtTer;
		private System.Windows.Forms.TextBox txtMqui;
		private System.Windows.Forms.TextBox txtQui;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsConcretoC dsConcretoC1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private LancNeo.dsTendencia dsTendencia1;
		private System.Windows.Forms.TextBox txtMaximo;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.CheckBox chbLab;
		private DBGraphics memGraphics;

		public RepTendencia()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			memGraphics = new  DBGraphics();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepTendencia));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPLanta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.dsPlanta1 = new LancNeo.dsPlanta();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsConcretoC1 = new LancNeo.dsConcretoC();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.txtMqui = new System.Windows.Forms.TextBox();
            this.txtQui = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMcua = new System.Windows.Forms.TextBox();
            this.txtCua = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMter = new System.Windows.Forms.TextBox();
            this.txtTer = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMseg = new System.Windows.Forms.TextBox();
            this.txtSeg = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMpri = new System.Windows.Forms.TextBox();
            this.txtPri = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbConcretera = new System.Windows.Forms.ComboBox();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRes = new System.Windows.Forms.ComboBox();
            this.dsBusResistencia1 = new LancNeo.dsBusResistencia();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDiam1 = new System.Windows.Forms.ComboBox();
            this.dsDiametro1 = new LancNeo.dsDiametro();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBuscaObra1 = new LancNeo.dsBuscaObra();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.sqlDAConcreto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.crvRepTendencia = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDATendencia = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.cryRepTendencia1 = new LancNeo.CryRepTendencia();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsPlanta2 = new LancNeo.dsPlanta();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsConcretera2 = new LancNeo.dsConcretera();
            this.sqlDAPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsTendencia1 = new LancNeo.dsTendencia();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretoC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusResistencia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTendencia1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAUnidad
            // 
            this.sqlDAUnidad.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAUnidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Unidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Factor", "Factor"),
                        new System.Data.Common.DataColumnMapping("Undescr", "Undescr"),
                        new System.Data.Common.DataColumnMapping("MaxagrUn", "MaxagrUn"),
                        new System.Data.Common.DataColumnMapping("RevenUn", "RevenUn")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdUnidad, Factor, Undescr, MaxagrUn, RevenUn FROM Unidad";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlDAConcretera
            // 
            this.sqlDAConcretera.SelectCommand = this.sqlSelectCommand5;
            this.sqlDAConcretera.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concretera", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("Concretera", "Concretera"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT     IdConcretera, Concretera, Direccion\r\nFROM         Concretera\r\nORDER BY" +
    " IdConcretera";
            this.sqlSelectCommand5.Connection = this.sqlConn;
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
            // dsUnidad1
            // 
            this.dsUnidad1.DataSetName = "dsUnidad";
            this.dsUnidad1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsUnidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.txtMaximo);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cbkPrefijo);
            this.panel1.Controls.Add(this.txtMqui);
            this.panel1.Controls.Add(this.txtQui);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtMcua);
            this.panel1.Controls.Add(this.txtCua);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtMter);
            this.panel1.Controls.Add(this.txtTer);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtMseg);
            this.panel1.Controls.Add(this.txtSeg);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtMpri);
            this.panel1.Controls.Add(this.txtPri);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbPrueba);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbConcretera);
            this.panel1.Controls.Add(this.cmbPlanta);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbRes);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmbDiam1);
            this.panel1.Controls.Add(this.cmbUnidad);
            this.panel1.Controls.Add(this.label5);
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
            this.panel1.Size = new System.Drawing.Size(1028, 104);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConcretoC1.Muestras;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(123, 35);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsConcretoC1
            // 
            this.dsConcretoC1.DataSetName = "dsConcretoC";
            this.dsConcretoC1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretoC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(914, 14);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chbLab
            // 
            this.chbLab.Location = new System.Drawing.Point(190, 76);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 25);
            this.chbLab.TabIndex = 75;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(590, 10);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(32, 20);
            this.txtMaximo.TabIndex = 74;
            this.txtMaximo.Text = "800";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(513, 10);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(76, 13);
            this.label28.TabIndex = 73;
            this.label28.Text = "Maxímo eje y :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 72;
            this.textBox1.Text = "textBox1";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(7, 80);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 23);
            this.cbkPrefijo.TabIndex = 71;
            this.cbkPrefijo.Text = "No prefijo";
            this.cbkPrefijo.CheckedChanged += new System.EventHandler(this.cbkPrefijo_CheckedChanged);
            // 
            // txtMqui
            // 
            this.txtMqui.Location = new System.Drawing.Point(736, 48);
            this.txtMqui.MaxLength = 3;
            this.txtMqui.Name = "txtMqui";
            this.txtMqui.Size = new System.Drawing.Size(27, 20);
            this.txtMqui.TabIndex = 63;
            this.txtMqui.Text = "199";
            this.txtMqui.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQui
            // 
            this.txtQui.Location = new System.Drawing.Point(736, 31);
            this.txtQui.MaxLength = 2;
            this.txtQui.Name = "txtQui";
            this.txtQui.Size = new System.Drawing.Size(27, 20);
            this.txtQui.TabIndex = 62;
            this.txtQui.Text = "63";
            this.txtQui.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(700, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "5°";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMcua
            // 
            this.txtMcua.Location = new System.Drawing.Point(707, 48);
            this.txtMcua.MaxLength = 3;
            this.txtMcua.Name = "txtMcua";
            this.txtMcua.Size = new System.Drawing.Size(27, 20);
            this.txtMcua.TabIndex = 60;
            this.txtMcua.Text = "5";
            this.txtMcua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCua
            // 
            this.txtCua.Location = new System.Drawing.Point(707, 31);
            this.txtCua.MaxLength = 2;
            this.txtCua.Name = "txtCua";
            this.txtCua.Size = new System.Drawing.Size(27, 20);
            this.txtCua.TabIndex = 59;
            this.txtCua.Text = "28";
            this.txtCua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(683, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "4°";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMter
            // 
            this.txtMter.Location = new System.Drawing.Point(679, 48);
            this.txtMter.MaxLength = 3;
            this.txtMter.Name = "txtMter";
            this.txtMter.Size = new System.Drawing.Size(27, 20);
            this.txtMter.TabIndex = 57;
            this.txtMter.Text = "5";
            this.txtMter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTer
            // 
            this.txtTer.Location = new System.Drawing.Point(679, 31);
            this.txtTer.MaxLength = 2;
            this.txtTer.Name = "txtTer";
            this.txtTer.Size = new System.Drawing.Size(27, 20);
            this.txtTer.TabIndex = 56;
            this.txtTer.Text = "14";
            this.txtTer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(667, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "3°";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMseg
            // 
            this.txtMseg.Location = new System.Drawing.Point(651, 48);
            this.txtMseg.MaxLength = 3;
            this.txtMseg.Name = "txtMseg";
            this.txtMseg.Size = new System.Drawing.Size(27, 20);
            this.txtMseg.TabIndex = 54;
            this.txtMseg.Text = "5";
            this.txtMseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSeg
            // 
            this.txtSeg.Location = new System.Drawing.Point(651, 31);
            this.txtSeg.MaxLength = 2;
            this.txtSeg.Name = "txtSeg";
            this.txtSeg.Size = new System.Drawing.Size(27, 20);
            this.txtSeg.TabIndex = 53;
            this.txtSeg.Text = "7";
            this.txtSeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(647, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "2°";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMpri
            // 
            this.txtMpri.Location = new System.Drawing.Point(623, 49);
            this.txtMpri.MaxLength = 3;
            this.txtMpri.Name = "txtMpri";
            this.txtMpri.Size = new System.Drawing.Size(27, 20);
            this.txtMpri.TabIndex = 51;
            this.txtMpri.Text = "5";
            this.txtMpri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPri
            // 
            this.txtPri.Location = new System.Drawing.Point(623, 31);
            this.txtPri.MaxLength = 2;
            this.txtPri.Name = "txtPri";
            this.txtPri.Size = new System.Drawing.Size(27, 20);
            this.txtPri.TabIndex = 50;
            this.txtPri.Text = "3";
            this.txtPri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(630, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "1°";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(517, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Minímo de ensayes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(597, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Días";
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(270, 55);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(107, 21);
            this.cmbPrueba.TabIndex = 45;
            this.cmbPrueba.ValueMember = "IdPrueba";
            // 
            // dsTipoPrueba1
            // 
            this.dsTipoPrueba1.DataSetName = "dsTipoPrueba";
            this.dsTipoPrueba1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipoPrueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Prueba:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Planta:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Concretera:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbConcretera.DisplayMember = "Concretera";
            this.cmbConcretera.Location = new System.Drawing.Point(373, 76);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(69, 21);
            this.cmbConcretera.TabIndex = 41;
            this.cmbConcretera.ValueMember = "IdConcretera";
            this.cmbConcretera.Click += new System.EventHandler(this.cmbConcretera_Click);
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DataSource = this.dsPlanta1.Planta;
            this.cmbPlanta.DisplayMember = "Planta";
            this.cmbPlanta.Enabled = false;
            this.cmbPlanta.Location = new System.Drawing.Point(487, 76);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(68, 21);
            this.cmbPlanta.TabIndex = 42;
            this.cmbPlanta.ValueMember = "IdPlanta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Resistencia:";
            // 
            // cmbRes
            // 
            this.cmbRes.DataSource = this.dsBusResistencia1.Resistencia;
            this.cmbRes.DisplayMember = "Resistencia";
            this.cmbRes.Location = new System.Drawing.Point(627, 80);
            this.cmbRes.Name = "cmbRes";
            this.cmbRes.Size = new System.Drawing.Size(68, 21);
            this.cmbRes.TabIndex = 39;
            this.cmbRes.ValueMember = "ResistenciaKG";
            // 
            // dsBusResistencia1
            // 
            this.dsBusResistencia1.DataSetName = "dsBusResistencia";
            this.dsBusResistencia1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusResistencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "F. Geométrica:";
            // 
            // cmbDiam1
            // 
            this.cmbDiam1.DataSource = this.dsDiametro1.Diametro;
            this.cmbDiam1.DisplayMember = "Diametro";
            this.cmbDiam1.Location = new System.Drawing.Point(270, 35);
            this.cmbDiam1.Name = "cmbDiam1";
            this.cmbDiam1.Size = new System.Drawing.Size(107, 21);
            this.cmbDiam1.TabIndex = 37;
            this.cmbDiam1.ValueMember = "IdDiam";
            // 
            // dsDiametro1
            // 
            this.dsDiametro1.DataSetName = "dsDiametro";
            this.dsDiametro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDiametro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(430, 55);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(80, 21);
            this.cmbUnidad.TabIndex = 10;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(430, 31);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(80, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(430, 7);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(80, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBuscaObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(40, 31);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grafico de tendencia";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(273, 10);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(931, 36);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(47, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // sqlDAConcreto
            // 
            this.sqlDAConcreto.SelectCommand = this.sqlCommand2;
            this.sqlDAConcreto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestras", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Resistencia", "Resistencia"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("T.M.A.", "T.M.A."),
                        new System.Data.Common.DataColumnMapping("Rev.", "Rev."),
                        new System.Data.Common.DataColumnMapping("T. A.", "T. A.")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // crvRepTendencia
            // 
            this.crvRepTendencia.ActiveViewIndex = -1;
            this.crvRepTendencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepTendencia.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepTendencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepTendencia.EnableRefresh = false;
            this.crvRepTendencia.Location = new System.Drawing.Point(0, 104);
            this.crvRepTendencia.Name = "crvRepTendencia";
            this.crvRepTendencia.ShowCloseButton = false;
            this.crvRepTendencia.ShowGroupTreeButton = false;
            this.crvRepTendencia.ShowLogo = false;
            this.crvRepTendencia.ShowRefreshButton = false;
            this.crvRepTendencia.Size = new System.Drawing.Size(1028, 638);
            this.crvRepTendencia.TabIndex = 11;
            this.crvRepTendencia.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepTendencia.ToolPanelWidth = 167;
            this.crvRepTendencia.Load += new System.EventHandler(this.crvRepTendencia_Load);
            // 
            // sqlDATendencia
            // 
            this.sqlDATendencia.SelectCommand = this.sqlSelectCommand3;
            this.sqlDATendencia.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RepTendencia", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Resistencia", "Resistencia"),
                        new System.Data.Common.DataColumnMapping("dia1", "dia1"),
                        new System.Data.Common.DataColumnMapping("n1", "n1"),
                        new System.Data.Common.DataColumnMapping("x1", "x1"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("dia2", "dia2"),
                        new System.Data.Common.DataColumnMapping("n2", "n2"),
                        new System.Data.Common.DataColumnMapping("x2", "x2"),
                        new System.Data.Common.DataColumnMapping("d2", "d2"),
                        new System.Data.Common.DataColumnMapping("dia3", "dia3"),
                        new System.Data.Common.DataColumnMapping("n3", "n3"),
                        new System.Data.Common.DataColumnMapping("x3", "x3"),
                        new System.Data.Common.DataColumnMapping("d3", "d3"),
                        new System.Data.Common.DataColumnMapping("dia4", "dia4"),
                        new System.Data.Common.DataColumnMapping("n4", "n4"),
                        new System.Data.Common.DataColumnMapping("x4", "x4"),
                        new System.Data.Common.DataColumnMapping("d4", "d4"),
                        new System.Data.Common.DataColumnMapping("dia5", "dia5"),
                        new System.Data.Common.DataColumnMapping("n5", "n5"),
                        new System.Data.Common.DataColumnMapping("x5", "x5"),
                        new System.Data.Common.DataColumnMapping("d5", "d5")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "[RepTendencia]";
            this.sqlSelectCommand3.CommandTimeout = 720;
            this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Dia1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Dia2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Dia3", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Dia4", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Dia5", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@m1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@m2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@m3", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@m4", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@m5", System.Data.SqlDbType.Int, 4)});
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
            this.sqlSelectCommand9.CommandText = "SELECT IdDiam, Diametro + \' \' + Figura AS Diametro FROM Diametro";
            this.sqlSelectCommand9.Connection = this.sqlConn;
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
            this.sqlSelectCommand7.CommandText = "SELECT ResistenciaKG, STR(ResistenciaKG) AS Resistencia FROM Resistencia";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // dsPlanta2
            // 
            this.dsPlanta2.DataSetName = "dsPlanta";
            this.dsPlanta2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlCommand3;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Planta", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("Planta", "Planta")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT IdConcretera, IdPlanta, Planta FROM Planta WHERE (IdConcretera LIKE @IdCon" +
    "cretera)";
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera")});
            // 
            // sqlDataAdapter2
            // 
            this.sqlDataAdapter2.SelectCommand = this.sqlCommand4;
            this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concretera", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("Concretera", "Concretera"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT IdConcretera, Concretera, Direccion FROM Concretera";
            this.sqlCommand4.Connection = this.sqlConn;
            // 
            // dsConcretera2
            // 
            this.dsConcretera2.DataSetName = "dsConcretera";
            this.dsConcretera2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAPrueba
            // 
            this.sqlDAPrueba.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAPrueba.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipoprueba", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT IdPrueba, Prueba FROM Tipoprueba";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 392);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // dsTendencia1
            // 
            this.dsTendencia1.DataSetName = "dsTendencia";
            this.dsTendencia1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsTendencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RepTendencia
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1028, 742);
            this.Controls.Add(this.crvRepTendencia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RepTendencia";
            this.Text = "RepTendencia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepTendencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretoC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusResistencia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTendencia1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		
		protected GraphPane myPane;

		private void RepTendencia_Load(object sender, System.EventArgs e)
		{
			DataColumn[] Llave = new DataColumn[1];
			Object[] Matriz = new Object[6];
			Llave[0] = dsBuscaObra1.Tables["Obra"].Columns["IdObra"];
			Matriz[0] = "Todas";
			Matriz[1] = "Todas";
			Matriz[2] = "Todas";
			Matriz[3] = "Todas";
			Matriz[4] = "Todas";
			Matriz[5] = "Todas";
			dsBuscaObra1.Tables["Obra"].BeginLoadData();
			dsBuscaObra1.Tables["Obra"].LoadDataRow(Matriz,true);
			dsBuscaObra1.Tables["Obra"].EndLoadData();
			sqlDABusObra.Fill(dsBuscaObra1, "Obra");
			sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
			cmbPrueba.SelectedIndex = 0;
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			cmbUnidad.SelectedIndex = 0;
			sqlDADiametro.Fill(dsDiametro1, "Diametro");
			cmbDiam1.SelectedIndex = 0;
			dsBusResistencia1.Resistencia.AddResistenciaRow(-1,"Todas");
			sqlDARes.Fill(dsBusResistencia1, "Resistencia");
			cmbRes.SelectedIndex = 0;
			dsConcretera1.Concretera.AddConcreteraRow("%","Todas","%");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			cmbConcretera.SelectedIndex = 0;
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",cmbConcretera.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsConcretoC1.Clear();
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
			sqlDAConcreto.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text);
			sqlDAConcreto.Fill(dsConcretoC1, "Muestras");
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			cbkPrefijo.Checked = true;
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			btnVistaPrevia.Visible = true;
			cmbRes.SelectedItem = dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            crvRepTendencia.Visible = true;
            cryRepTendencia1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;

            cryRepTendencia1.SetDataSource(dsTendencia1);

            int j = 0;
			int k = 0;
			double[] x = new double[5];
			double[] y = new double[5];
            double[] yy = new double[5];
            double[] yw = new double[5];
            double[] x1 = new double[5];
            double[] y1 = new double[5];
            double n, mx, my, mlnx, lnx22, x0, y0, x2, y2;
            double[] lnx = new double[3];
            double[] lnxy = new double[3];
            double[] lnx2 = new double[3];
            
            n = mx = my = mlnx = lnx22 = x0 = y0 = x2 = y2 =0;
			try
				{
				dsTendencia1.Clear();
				sqlDATendencia.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text);
				sqlDATendencia.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString());
				sqlDATendencia.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
				sqlDATendencia.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
				sqlDATendencia.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
				sqlDATendencia.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
				sqlDATendencia.SelectCommand.Parameters["@ResistenciaKg"].Value = cmbRes.SelectedValue.ToString();
				sqlDATendencia.SelectCommand.Parameters["@Tipo"].Value = dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString();
				sqlDATendencia.SelectCommand.Parameters["@IdAgregado"].Value = dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][7].ToString() ;
				sqlDATendencia.SelectCommand.Parameters["@IdDiam"].Value = cmbDiam1.SelectedValue.ToString();
				sqlDATendencia.SelectCommand.Parameters["@Dia1"].Value = txtPri.Text;
				sqlDATendencia.SelectCommand.Parameters["@Dia2"].Value = txtSeg.Text;
				sqlDATendencia.SelectCommand.Parameters["@Dia3"].Value = txtTer.Text;
				sqlDATendencia.SelectCommand.Parameters["@Dia4"].Value = txtCua.Text;
				sqlDATendencia.SelectCommand.Parameters["@Dia5"].Value = txtQui.Text;
				sqlDATendencia.SelectCommand.Parameters["@m1"].Value = txtMpri.Text;
				sqlDATendencia.SelectCommand.Parameters["@m2"].Value = txtMseg.Text;
				sqlDATendencia.SelectCommand.Parameters["@m3"].Value = txtMter.Text;
				sqlDATendencia.SelectCommand.Parameters["@m4"].Value = txtMcua.Text;
				sqlDATendencia.SelectCommand.Parameters["@m5"].Value = txtMqui.Text;
				sqlDATendencia.Fill(dsTendencia1, "RepTendencia");

				// Establece el valor actual de parameter1 en el subinforme en 10 
				cryRepTendencia1.SetParameterValue("@Unidad", cmbUnidad.Text);
				cryRepTendencia1.SetParameterValue("@Prueba", cmbPrueba.Text);
				cryRepTendencia1.SetParameterValue("@fi", dtpIni.Text);
				cryRepTendencia1.SetParameterValue("@ff", dtpFin.Text);
				cryRepTendencia1.SetParameterValue("@Tipo", dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString());
				cryRepTendencia1.SetParameterValue("@TA", dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString());
				cryRepTendencia1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
				cryRepTendencia1.SetParameterValue("@Obr", txtIdobra.Text);
				cryRepTendencia1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
				cryRepTendencia1.SetParameterValue("@Con", cmbConcretera.Text);
				cryRepTendencia1.SetParameterValue("@Pta", cmbPlanta.Text);
				cryRepTendencia1.SetParameterValue("@Lab", chbLab.Checked);
				cryRepTendencia1.SetParameterValue("@Col", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
				cryRepTendencia1.SetParameterValue("@Titulo", "GRAFICO DE TENDENCIA");
				cryRepTendencia1.SetParameterValue("@Figura", cmbDiam1.Text);

				memGraphics.CreateDoubleBuffer(this.CreateGraphics(),
					this.ClientRectangle.Width, this.ClientRectangle.Height);

				myPane = new GraphPane( new Rectangle( 10, 10, 10, 10 ),
					"", "Edad en días", "Resistencia");
				SetSize();
                float FX0, FX1, FY0, FY1;
                float F16 = 0.6667F;
                ArrowItem arrow = new ArrowItem(Color.Red, 0, F16, 0, F16, float.Parse(txtMaximo.Text));

                for (k = 0; k < 5; k++)
                    yy[k] = yw[k] = x1[k] = y[k] = 0; 

				CurveItem curve;
				for (j=0; j < dsTendencia1.Tables[0].Rows.Count; j++)
				{
                    for (k = 0; k < 5; k++)
						x[k] = y[k] = 0; 
					k = 0;
					string acotacion = "";
					double acota = double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString());
					if(cmbUnidad.SelectedValue.ToString() == "2")
						acotacion = acota.ToString("####.00");
					else
						acotacion = acota.ToString("####");
					if (dsTendencia1.Tables[0].Rows[j][5].ToString() != "")
					{
                            x[0] = double.Parse(dsTendencia1.Tables[0].Rows[j][3].ToString());
                        y[0] = double.Parse(dsTendencia1.Tables[0].Rows[j][5].ToString());
                    }
					if (dsTendencia1.Tables[0].Rows[j][9].ToString() != "")
					{
        					x[1] = double.Parse(dsTendencia1.Tables[0].Rows[j][7].ToString());
						y[1] = double.Parse(dsTendencia1.Tables[0].Rows[j][9].ToString());
                    }
                    if (dsTendencia1.Tables[0].Rows[j][13].ToString() != "")
                    {
                        x[2] = double.Parse(dsTendencia1.Tables[0].Rows[j][11].ToString());
                        y[2] = double.Parse(dsTendencia1.Tables[0].Rows[j][13].ToString());
                        if ( (dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-1" || dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-8"))
                        {
                            x0 = x[2];
                            y0 = y[2];
                        }

                    }
                    if (dsTendencia1.Tables[0].Rows[j][17].ToString() != "")
                    {
                        x[3] = double.Parse(dsTendencia1.Tables[0].Rows[j][15].ToString());
                        y[3] = double.Parse(dsTendencia1.Tables[0].Rows[j][17].ToString());
                        if ((dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-1" || dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-8"))
                        {
                            x2 = x[3];
                            y2 = y[3];
                        }
                    }
                    if (dsTendencia1.Tables[0].Rows[j][21].ToString() != "")
                    {
                        x[4] = double.Parse(dsTendencia1.Tables[0].Rows[j][19].ToString());
                        y[4] = double.Parse(dsTendencia1.Tables[0].Rows[j][21].ToString());
                    }
					if ( j == 0 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
                        if ((dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-1" || dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-8"))
                        {
                            lnx[0] = Math.Log(x0);
                            lnx[1] = Math.Log(x2);
                            lnx[2] = lnx[0] + lnx[1];
                            lnxy[0] = lnx[0] * y0;
                            lnxy[1] = lnx[1] * y2;
                            lnxy[2] = lnxy[0] + lnxy[1];
                            lnx2[0] = lnx[0] * lnx[0];
                            lnx2[1] = lnx[1] * lnx[1];
                            lnx2[2] = lnx2[0] + lnx2[1];
                            lnx22 = lnx[2] * lnx[2];
                            double denominador = 2 * lnxy[2] - (lnx[2] * (y0 + y2));
                            double numerador = 2 * lnx2[2] - lnx22;
                            double b = denominador / numerador;
                            double a = ((y2 + y0)/2) - (b * (lnx[2] / 2));
                            x[0] = 0.667;
                            y[0] = (b * Math.Log(x[0])) + a;
                            x[1] = 0.833;
                            y[1] = (b * Math.Log(x[1])) + a;
                        }
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkBlue, SymbolType.Circle);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkBlue);
                        curve.Symbol.Size = 12;
                        for (int jj = 4; jj >= 0; jj--)
                            if (y[jj] == 0)
                                curve.Points.Remove(jj);
                    }
					if ( j == 1 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
                        if ((dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-1" || dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-8"))
                        {
                            lnx[0] = Math.Log(x0);
                            lnx[1] = Math.Log(x2);
                            lnx[2] = lnx[0] + lnx[1];
                            lnxy[0] = lnx[0] * y0;
                            lnxy[1] = lnx[1] * y2;
                            lnxy[2] = lnxy[0] + lnxy[1];
                            lnx2[0] = lnx[0] * lnx[0];
                            lnx2[1] = lnx[1] * lnx[1];
                            lnx2[2] = lnx2[0] + lnx2[1];
                            lnx22 = lnx[2] * lnx[2];
                            double denominador = 2 * lnxy[2] - (lnx[2] * (y0 + y2));
                            double numerador = 2 * lnx2[2] - lnx22;
                            double b = denominador / numerador;
                            double a = ((y2 + y0) / 2) - (b * (lnx[2] / 2));
                            x[0] = 0.667;
                            y[0] = (b * Math.Log(x[0])) + a;
                            x[1] = 0.833;
                            y[1] = (b * Math.Log(x[1])) + a;
                        }
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkCyan, SymbolType.Diamond);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkCyan);
                        curve.Symbol.Size = 12;
                        for (int jj = 4; jj >= 0; jj--)
                            if (y[jj] == 0)
                                curve.Points.Remove(jj);
                    }
					if ( j == 2 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
                        if ((dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-1" || dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-8"))
                        {
                            lnx[0] = Math.Log(x0);
                            lnx[1] = Math.Log(x2);
                            lnx[2] = lnx[0] + lnx[1];
                            lnxy[0] = lnx[0] * y0;
                            lnxy[1] = lnx[1] * y2;
                            lnxy[2] = lnxy[0] + lnxy[1];
                            lnx2[0] = lnx[0] * lnx[0];
                            lnx2[1] = lnx[1] * lnx[1];
                            lnx2[2] = lnx2[0] + lnx2[1];
                            lnx22 = lnx[2] * lnx[2];
                            double denominador = 2 * lnxy[2] - (lnx[2] * (y0 + y2));
                            double numerador = 2 * lnx2[2] - lnx22;
                            double b = denominador / numerador;
                            double a = ((y2 + y0) / 2) - (b * (lnx[2] / 2));
                            x[0] = 0.667;
                            y[0] = (b * Math.Log(x[0])) + a;
                            x[1] = 0.833;
                            y[1] = (b * Math.Log(x[1])) + a;
                        }
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkGoldenrod, SymbolType.Star);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkGoldenrod);
                        curve.Symbol.Size = 12;
                        for (int jj = 4; jj >= 0; jj--)
                            if (y[jj] == 0)
                                curve.Points.Remove(jj);
                    }
					if ( j == 3 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
                        if ((dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-1" || dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-8"))
                        {
                            lnx[0] = Math.Log(x0);
                            lnx[1] = Math.Log(x2);
                            lnx[2] = lnx[0] + lnx[1];
                            lnxy[0] = lnx[0] * y0;
                            lnxy[1] = lnx[1] * y2;
                            lnxy[2] = lnxy[0] + lnxy[1];
                            lnx2[0] = lnx[0] * lnx[0];
                            lnx2[1] = lnx[1] * lnx[1];
                            lnx2[2] = lnx2[0] + lnx2[1];
                            lnx22 = lnx[2] * lnx[2];
                            double denominador = 2 * lnxy[2] - (lnx[2] * (y0 + y2));
                            double numerador = 2 * lnx2[2] - lnx22;
                            double b = denominador / numerador;
                            double a = ((y2 + y0) / 2) - (b * (lnx[2] / 2));
                            x[0] = 0.667;
                            y[0] = (b * Math.Log(x[0])) + a;
                            x[1] = 0.833;
                            y[1] = (b * Math.Log(x[1])) + a; ;
                        }
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkGray, SymbolType.TriangleDown);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkGray);
                        curve.Symbol.Size = 12;
                        for (int jj = 4; jj >= 0; jj--)
                            if (y[jj] == 0)
                                curve.Points.Remove(jj);
                    }
					if ( j == 4 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
                        if ((dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-1" || dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-8"))
                        {
                            lnx[0] = Math.Log(x0);
                            lnx[1] = Math.Log(x2);
                            lnx[2] = lnx[0] + lnx[1];
                            lnxy[0] = lnx[0] * y0;
                            lnxy[1] = lnx[1] * y2;
                            lnxy[2] = lnxy[0] + lnxy[1];
                            lnx2[0] = lnx[0] * lnx[0];
                            lnx2[1] = lnx[1] * lnx[1];
                            lnx2[2] = lnx2[0] + lnx2[1];
                            lnx22 = lnx[2] * lnx[2];
                            double denominador = 2 * lnxy[2] - (lnx[2] * (y0 + y2));
                            double numerador = 2 * lnx2[2] - lnx22;
                            double b = denominador / numerador;
                            double a = ((y2 + y0) / 2) - (b * (lnx[2] / 2));
                            x[0] = 0.667;
                            y[0] = (b * Math.Log(x[0])) + a;
                            x[1] = 0.833;
                            y[1] = (b * Math.Log(x[1])) + a; ;
                        }
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkGreen, SymbolType.Plus);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkGreen);
                        curve.Symbol.Size = 12;
                        for (int jj = 4; jj >= 0; jj--)
                            if (y[jj] == 0)
                                curve.Points.Remove(jj);
                    }
					if ( j == 5 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
                        if ((dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-1" || dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-8"))
                        {
                            lnx[0] = Math.Log(x0);
                            lnx[1] = Math.Log(x2);
                            lnx[2] = lnx[0] + lnx[1];
                            lnxy[0] = lnx[0] * y0;
                            lnxy[1] = lnx[1] * y2;
                            lnxy[2] = lnxy[0] + lnxy[1];
                            lnx2[0] = lnx[0] * lnx[0];
                            lnx2[1] = lnx[1] * lnx[1];
                            lnx2[2] = lnx2[0] + lnx2[1];
                            lnx22 = lnx[2] * lnx[2];
                            double denominador = 2 * lnxy[2] - (lnx[2] * (y0 + y2));
                            double numerador = 2 * lnx2[2] - lnx22;
                            double b = denominador / numerador;
                            double a = ((y2 + y0) / 2) - (b * (lnx[2] / 2));
                            x[0] = 0.667;
                            y[0] = (b * Math.Log(x[0])) + a;
                            x[1] = 0.833;
                            y[1] = (b * Math.Log(x[1])) + a; 
                        }
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkKhaki, SymbolType.Square);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkKhaki);
                        curve.Symbol.Size = 12;
                        for (int jj = 4; jj >= 0; jj--)
                            if (y[jj] == 0)
                                curve.Points.Remove(jj);
                    }
					if ( j == 6 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
                        if ((dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-1" || dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-8"))
                        {
                            lnx[0] = Math.Log(x0);
                            lnx[1] = Math.Log(x2);
                            lnx[2] = lnx[0] + lnx[1];
                            lnxy[0] = lnx[0] * y0;
                            lnxy[1] = lnx[1] * y2;
                            lnxy[2] = lnxy[0] + lnxy[1];
                            lnx2[0] = lnx[0] * lnx[0];
                            lnx2[1] = lnx[1] * lnx[1];
                            lnx2[2] = lnx2[0] + lnx2[1];
                            lnx22 = lnx[2] * lnx[2];
                            double denominador = 2 * lnxy[2] - (lnx[2] * (y0 + y2));
                            double numerador = 2 * lnx2[2] - lnx22;
                            double b = denominador / numerador;
                            double a = ((y2 + y0) / 2) - (b * (lnx[2] / 2));
                            x[0] = 0.667;
                            y[0] = (b * Math.Log(x[0])) + a;
                            x[1] = 0.833;
                            y[1] = (b * Math.Log(x[1])) + a; 
                        }
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkMagenta, SymbolType.Triangle);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkMagenta);
                        curve.Symbol.Size = 12;
                        for (int jj = 4; jj >= 0; jj--)
                            if (y[jj] == 0)
                                curve.Points.Remove(jj);
                    }
					if ( j == 7 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
                        if ((dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-1" || dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "A1-8"))
                        {
                            lnx[0] = Math.Log(x0);
                            lnx[1] = Math.Log(x2);
                            lnx[2] = lnx[0] + lnx[1];
                            lnxy[0] = lnx[0] * y0;
                            lnxy[1] = lnx[1] * y2;
                            lnxy[2] = lnxy[0] + lnxy[1];
                            lnx2[0] = lnx[0] * lnx[0];
                            lnx2[1] = lnx[1] * lnx[1];
                            lnx2[2] = lnx2[0] + lnx2[1];
                            lnx22 = lnx[2] * lnx[2];
                            double denominador = 2 * lnxy[2] - (lnx[2] * (y0 + y2));
                            double numerador = 2 * lnx2[2] - lnx22;
                            double b = denominador / numerador;
                            double a = ((y2 + y0) / 2) - (b * (lnx[2] / 2));
                            x[0] = 0.667;
                            y[0] = (b * Math.Log(x[0])) + a;
                            x[1] = 0.833;
                            y[1] = (b * Math.Log(x[1])) + a; 
                        }
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkOliveGreen, SymbolType.XCross);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkOliveGreen);
                        curve.Symbol.Size = 12;
                        for (int jj = 4; jj >= 0; jj--)
                            if (y[jj] == 0)
                                curve.Points.Remove(jj);
                    }
					if ( j == 8 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
						curve = myPane.AddCurve( acotacion, x, y, Color.DarkOrange, SymbolType.Circle );
						curve.Line.Width = 2.0F;
						curve.Symbol.Fill = new Fill( Color.DarkOrange );
						curve.Symbol.Size = 12;

					}
                    if (j == 9 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
                    {
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkOrchid, SymbolType.Square);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkOrchid);
                        curve.Symbol.Size = 12;
                    }
                    if (j == 10 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
                    {
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkRed, SymbolType.Triangle);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkRed);
                        curve.Symbol.Size = 12;
                    }
                    if (j == 11 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
                    {
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkSalmon, SymbolType.XCross);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkSalmon);
                        curve.Symbol.Size = 12;
                    }
                    if (j == 12 && double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) < 10000)
                    {
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkSeaGreen, SymbolType.Circle);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkSeaGreen);
                        curve.Symbol.Size = 12;

                    }
                    if (double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) == 15000)
					{
						curve = myPane.AddCurve( "+s", x, y, Color.Gray, SymbolType.Empty );
						curve.Line.Width = 2.0F;
						curve.Line.Style = DashStyle.Dot;
						curve.Symbol.Fill = new Fill( Color.Gray );
						curve.Symbol.IsVisible = false;
                        for (int jj = 4; jj >= 0; jj--)
                            if (y[jj] == 0)
                                curve.Points.Remove(jj);
					}
					if ( double.Parse(dsTendencia1.Tables[0].Rows[j][2].ToString()) == 16000)
					{
						curve = myPane.AddCurve( "-s", x, y, Color.Gray, SymbolType.Empty );
						curve.Line.Width = 2.0F;
						curve.Line.Style = DashStyle.Dot;
						curve.Symbol.Fill = new Fill( Color.Gray );
						curve.Symbol.IsVisible = false;
                        for (int jj = 4; jj >= 0; jj--)
                            if (y[jj] == 0)
                                curve.Points.Remove(jj);
                    }
                }

                arrow = new ArrowItem(Color.Red, 0, F16, 0, F16, float.Parse(txtMaximo.Text));
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 0F;
                myPane.ArrowList.Add(arrow);
                F16 = 0.8333F;
                arrow = new ArrowItem(Color.Red, 0, F16, 0, F16, float.Parse(txtMaximo.Text));
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 0F;
                myPane.ArrowList.Add(arrow);
                arrow = new ArrowItem(Color.Red, 0, 1, 0, 1, float.Parse(txtMaximo.Text));
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 0F;
                myPane.ArrowList.Add(arrow);
                arrow = new ArrowItem(Color.Red, 0, 3, 0, 3, float.Parse(txtMaximo.Text));
				arrow.CoordinateFrame = CoordType.AxisXYScale;
				arrow.PenWidth = 0F;
				myPane.ArrowList.Add( arrow);
				arrow = new ArrowItem (Color.Red, 0,7,0,7,float.Parse(txtMaximo.Text));
				arrow.CoordinateFrame = CoordType.AxisXYScale;
				arrow.PenWidth = 0F;
				myPane.ArrowList.Add( arrow);
				arrow = new ArrowItem (Color.Red, 0,14,0,14,float.Parse(txtMaximo.Text));
				arrow.CoordinateFrame = CoordType.AxisXYScale;
				arrow.PenWidth = 0F;
				myPane.ArrowList.Add( arrow);
				arrow = new ArrowItem (Color.Red, 0,28,0,28,float.Parse(txtMaximo.Text));
				arrow.CoordinateFrame = CoordType.AxisXYScale;
				arrow.PenWidth = 0F;
				myPane.ArrowList.Add( arrow);
				arrow = new ArrowItem (Color.Gray, 0,63,0,63,float.Parse(txtMaximo.Text));
				arrow.CoordinateFrame = CoordType.AxisXYScale;
				arrow.PenWidth = 0F;
				myPane.ArrowList.Add( arrow);

                Color[] colorado = { Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.DarkGreen, Color.DarkKhaki, Color.DarkMagenta, Color.DarkOliveGreen, Color.DarkOrange };
                for (k = 0; k < 5; k++)
                    x[k] = y[k] = 0; 

                for (j = 0; j < 9; j++)
                {
                    x[0] = 1;
                     x[1] = 100;
                     switch (j)
                     {
                         case 0:
                             y[0] = 72.322 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             y[1] = 286.909115 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             break;
                         case 1:
                             y[0] = 103.38 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             y[1] = 360.155079 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             break;
                         case 2:
                             y[0] = 140.16 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             y[1] = 420.462894 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             break;
                         case 3:
                             y[0] = 175.5 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             y[1] = 461.771194 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             break;
                         case 4:
                             y[0] = 254.66 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             y[1] = 554.525657 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             break;
                         case 5:
                             y[0] = 311.25 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             y[1] = 585.561567 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             break;
                         case 6:
                             y[0] = 345.21 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             y[1] = 627.483907 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             break;
                         case 7:
                             y[0] = 393.70 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             y[1] = 656.8 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             break;
                         case 8:
                             y[0] = 395.81 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             y[1] = 635.4 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             break;
                         default:
                             y[0] = 115.7 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             y[1] = 287.8 * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                             break;
                     }


                            curve = myPane.AddCurve((j*50 + 200).ToString(), x, y, colorado[j], SymbolType.Diamond);
                            curve.Line.Width = 1.0F;
                            curve.Line.Style = DashStyle.DashDot;
                            curve.Symbol.Fill = new Fill(colorado[j]);
                            curve.Symbol.IsVisible = true;
                            curve.Label.Remove(0, curve.Label.Length);

               }
                myPane.XAxis.IsMinorInsideTic = true;
                myPane.XAxis.TicSize = 10;
                myPane.XAxis.IsShowGrid = true;
				myPane.XAxis.IsInsideTic = true;
				myPane.XAxis.ScaleFontSpec.Angle = 0;
                myPane.XAxis.NumDec = 0;
                myPane.XAxis.ScaleFontSpec.Size = 10;
				myPane.XAxis.Min = 0.6; //cambiar
				myPane.XAxis.Max = 100;

//				MessageBox.Show(myPane.XAxis.ScaleFormat.ToString()); //esta buena
				myPane.XAxis.Type = AxisType.Log;
				myPane.XAxis.PickLogScale();

				myPane.XAxis.ScaleFormat = "{0:d###.#}";
                myPane.XAxis.TitleFontSpec.Family = "Arial";
                myPane.XAxis.TitleFontSpec.Size = 12;
				myPane.XAxis.IsShowTitle = false;
				myPane.XAxis.ScaleFontSpec.FontColor = Color.White;
                myPane.XAxis.IsMinorTic = false;

				myPane.YAxis.IsShowGrid = true;
				myPane.YAxis.ScaleFontSpec.Angle = 90;
				myPane.YAxis.Min = 0;
                myPane.YAxis.Max = double.Parse(txtMaximo.Text) * double.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                myPane.Legend.IsVisible = true;
				myPane.Legend.Location = LegendLoc.Bottom;
                myPane.Legend.FontSpec.Size = 8;
				myPane.PaneFill = new Fill( Color.White, Color.White, 0F );
				myPane.AxisChange( this.CreateGraphics() );
				pictureBox1.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
				MemoryStream ms = new MemoryStream();
				pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
				byte[] arrImage = ms.GetBuffer();
				ms.Close();
				
				myPane.Image.Dispose();
				pictureBox1.Image.Dispose();
				dsTendencia1.Grafica.AddGraficaRow(cmbConcretera.SelectedValue.ToString(),arrImage);

				
				crvRepTendencia.ReportSource = cryRepTendencia1;
				//crvRepTendencia.RefreshReport();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}

		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void cbkPrefijo_CheckedChanged(object sender, System.EventArgs e)
		{
			if (cbkPrefijo.Checked == false)
				txtIdobra.Text = txtIdobra.Text.Substring(0,3)+"%";
			else
				txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
		}
		private void SetSize()
		{
			Rectangle paneRect = this.ClientRectangle;
			paneRect.Inflate( -2, -1 );
			this.myPane.PaneRect = paneRect;
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void cmbConcretera_Click(object sender, System.EventArgs e)
		{
			cmbPlanta.Enabled = true;
			dsPlanta1.Clear();
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",cmbConcretera.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
		}

		private void crvRepTendencia_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
