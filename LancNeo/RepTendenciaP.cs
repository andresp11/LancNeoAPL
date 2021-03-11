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
	/// Descripción breve de RepTendenciaP.
	/// </summary>
	public class RepTendenciaP : System.Windows.Forms.Form
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
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcreto;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepTendenciaP;
        private LancNeo.dsBuscaObra dsBuscaObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDATendencia;
        private LancNeo.CryRepTendenciaP cryRepTendenciaP1;
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
		private System.Data.SqlClient.SqlDataAdapter sqlDATipo;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private LancNeo.dsTipo dsTipo1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAgregado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand8;
        private LancNeo.dsAgregado dsAgregado1;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox cbx1;
		private System.Windows.Forms.CheckBox cbx2;
		private System.Windows.Forms.ComboBox cmbConcretera1;
		private System.Windows.Forms.ComboBox cmbPlanta1;
		private System.Windows.Forms.ComboBox cmbConcretera2;
		private System.Windows.Forms.ComboBox cmbPlanta2;
		private System.Windows.Forms.ComboBox cmbConcretera3;
		private System.Windows.Forms.ComboBox cmbPlanta3;
		private System.Windows.Forms.ComboBox cmbConcretera4;
		private System.Windows.Forms.ComboBox cmbPlanta4;
		private System.Windows.Forms.CheckBox cbx3;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
        private LancNeo.dsConcretera dsConcretera3;
        private LancNeo.dsConcretera dsConcretera4;
        private LancNeo.dsConcretera dsConcretera5;
        private LancNeo.dsPlanta dsPlanta3;
        private LancNeo.dsPlanta dsPlanta4;
        private LancNeo.dsPlanta dsPlanta5;
		private System.Windows.Forms.ComboBox cmbIdAgregado;
		private System.Windows.Forms.CheckBox cbx5;
		private System.Windows.Forms.CheckBox cbx4;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private System.Windows.Forms.TextBox txtIdobra;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox txtMaximo;
        private LancNeo.dsTendenciaC dsTendenciaC1;
		private System.Windows.Forms.CheckBox chbLab;
        private TextBox txtRango;
        private Label label29;
		private DBGraphics memGraphics;

		public RepTendenciaP()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepTendenciaP));
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
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.txtRango = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbx5 = new System.Windows.Forms.CheckBox();
            this.cbx4 = new System.Windows.Forms.CheckBox();
            this.cbx3 = new System.Windows.Forms.CheckBox();
            this.cmbPlanta4 = new System.Windows.Forms.ComboBox();
            this.dsPlanta5 = new LancNeo.dsPlanta();
            this.cmbConcretera4 = new System.Windows.Forms.ComboBox();
            this.dsConcretera5 = new LancNeo.dsConcretera();
            this.cmbPlanta3 = new System.Windows.Forms.ComboBox();
            this.dsPlanta4 = new LancNeo.dsPlanta();
            this.cmbConcretera3 = new System.Windows.Forms.ComboBox();
            this.dsConcretera4 = new LancNeo.dsConcretera();
            this.cmbPlanta2 = new System.Windows.Forms.ComboBox();
            this.dsPlanta3 = new LancNeo.dsPlanta();
            this.cmbConcretera2 = new System.Windows.Forms.ComboBox();
            this.dsConcretera3 = new LancNeo.dsConcretera();
            this.cmbPlanta1 = new System.Windows.Forms.ComboBox();
            this.dsPlanta2 = new LancNeo.dsPlanta();
            this.cmbConcretera1 = new System.Windows.Forms.ComboBox();
            this.dsConcretera2 = new LancNeo.dsConcretera();
            this.cbx2 = new System.Windows.Forms.CheckBox();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbConcretera = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbIdAgregado = new System.Windows.Forms.ComboBox();
            this.dsAgregado1 = new LancNeo.dsAgregado();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dsTipo1 = new LancNeo.dsTipo();
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
            this.dsConcretoC1 = new LancNeo.dsConcretoC();
            this.sqlDAConcreto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.crvRepTendenciaP = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDATendencia = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.cryRepTendenciaP1 = new LancNeo.CryRepTendenciaP();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.sqlDATipo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAAgregado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsTendenciaC1 = new LancNeo.dsTendenciaC();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusResistencia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretoC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTendenciaC1)).BeginInit();
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
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.txtRango);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.txtMaximo);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Controls.Add(this.cbkPrefijo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.cmbIdAgregado);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cmbTipo);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 166);
            this.panel1.TabIndex = 10;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(793, 94);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // txtRango
            // 
            this.txtRango.Location = new System.Drawing.Point(419, 143);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(37, 20);
            this.txtRango.TabIndex = 78;
            this.txtRango.Text = "100";
            this.txtRango.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(325, 147);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(95, 13);
            this.label29.TabIndex = 77;
            this.label29.Text = "Rango resistencia:";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.Location = new System.Drawing.Point(47, 135);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(115, 24);
            this.chbLab.TabIndex = 76;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(723, 97);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(50, 20);
            this.txtMaximo.TabIndex = 72;
            this.txtMaximo.Text = "800";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(650, 97);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(76, 13);
            this.label28.TabIndex = 71;
            this.label28.Text = "Maxímo eje y :";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(856, 72);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.Size = new System.Drawing.Size(76, 20);
            this.txtIdobra.TabIndex = 70;
            this.txtIdobra.Text = "textBox1";
            this.txtIdobra.Visible = false;
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(723, 66);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 69;
            this.cbkPrefijo.Text = "No prefijo";
            this.cbkPrefijo.CheckedChanged += new System.EventHandler(this.cbkPrefijo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.cbx5);
            this.panel2.Controls.Add(this.cbx4);
            this.panel2.Controls.Add(this.cbx3);
            this.panel2.Controls.Add(this.cmbPlanta4);
            this.panel2.Controls.Add(this.cmbConcretera4);
            this.panel2.Controls.Add(this.cmbPlanta3);
            this.panel2.Controls.Add(this.cmbConcretera3);
            this.panel2.Controls.Add(this.cmbPlanta2);
            this.panel2.Controls.Add(this.cmbConcretera2);
            this.panel2.Controls.Add(this.cmbPlanta1);
            this.panel2.Controls.Add(this.cmbConcretera1);
            this.panel2.Controls.Add(this.cbx2);
            this.panel2.Controls.Add(this.cbx1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmbConcretera);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cmbPlanta);
            this.panel2.Location = new System.Drawing.Point(320, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 132);
            this.panel2.TabIndex = 68;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(200, 102);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 13);
            this.label27.TabIndex = 65;
            this.label27.Text = "Planta:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(200, 78);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 13);
            this.label26.TabIndex = 64;
            this.label26.Text = "Planta:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(200, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 63;
            this.label25.Text = "Planta:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(200, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 62;
            this.label24.Text = "Planta:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(64, 102);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 13);
            this.label23.TabIndex = 61;
            this.label23.Text = "Concretera:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(64, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 60;
            this.label22.Text = "Concretera:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(64, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 59;
            this.label21.Text = "Concretera:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(64, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 58;
            this.label20.Text = "Concretera:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbx5
            // 
            this.cbx5.Location = new System.Drawing.Point(8, 100);
            this.cbx5.Name = "cbx5";
            this.cbx5.Size = new System.Drawing.Size(40, 21);
            this.cbx5.TabIndex = 57;
            this.cbx5.Text = "5a.";
            this.cbx5.CheckedChanged += new System.EventHandler(this.ckb5_CheckedChanged);
            // 
            // cbx4
            // 
            this.cbx4.Location = new System.Drawing.Point(8, 76);
            this.cbx4.Name = "cbx4";
            this.cbx4.Size = new System.Drawing.Size(40, 21);
            this.cbx4.TabIndex = 56;
            this.cbx4.Text = "4a.";
            this.cbx4.CheckedChanged += new System.EventHandler(this.ckb4_CheckedChanged);
            // 
            // cbx3
            // 
            this.cbx3.Location = new System.Drawing.Point(8, 52);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(40, 21);
            this.cbx3.TabIndex = 55;
            this.cbx3.Text = "3a.";
            this.cbx3.CheckedChanged += new System.EventHandler(this.cbx3_CheckedChanged);
            // 
            // cmbPlanta4
            // 
            this.cmbPlanta4.DataSource = this.dsPlanta5.Planta;
            this.cmbPlanta4.DisplayMember = "IdPlanta";
            this.cmbPlanta4.Enabled = false;
            this.cmbPlanta4.Location = new System.Drawing.Point(240, 100);
            this.cmbPlanta4.Name = "cmbPlanta4";
            this.cmbPlanta4.Size = new System.Drawing.Size(68, 21);
            this.cmbPlanta4.TabIndex = 54;
            this.cmbPlanta4.ValueMember = "IdPlanta";
            // 
            // dsPlanta5
            // 
            this.dsPlanta5.DataSetName = "dsPlanta";
            this.dsPlanta5.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbConcretera4
            // 
            this.cmbConcretera4.DataSource = this.dsConcretera5.Concretera;
            this.cmbConcretera4.DisplayMember = "IdConcretera";
            this.cmbConcretera4.Enabled = false;
            this.cmbConcretera4.Location = new System.Drawing.Point(132, 100);
            this.cmbConcretera4.Name = "cmbConcretera4";
            this.cmbConcretera4.Size = new System.Drawing.Size(68, 21);
            this.cmbConcretera4.TabIndex = 53;
            this.cmbConcretera4.ValueMember = "IdConcretera";
            this.cmbConcretera4.SelectedIndexChanged += new System.EventHandler(this.cmbConcretera4_SelectedIndexChanged);
            // 
            // dsConcretera5
            // 
            this.dsConcretera5.DataSetName = "dsConcretera";
            this.dsConcretera5.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPlanta3
            // 
            this.cmbPlanta3.DataSource = this.dsPlanta4.Planta;
            this.cmbPlanta3.DisplayMember = "IdPlanta";
            this.cmbPlanta3.Enabled = false;
            this.cmbPlanta3.Location = new System.Drawing.Point(240, 76);
            this.cmbPlanta3.Name = "cmbPlanta3";
            this.cmbPlanta3.Size = new System.Drawing.Size(68, 21);
            this.cmbPlanta3.TabIndex = 52;
            this.cmbPlanta3.ValueMember = "IdPlanta";
            // 
            // dsPlanta4
            // 
            this.dsPlanta4.DataSetName = "dsPlanta";
            this.dsPlanta4.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbConcretera3
            // 
            this.cmbConcretera3.DataSource = this.dsConcretera4.Concretera;
            this.cmbConcretera3.DisplayMember = "IdConcretera";
            this.cmbConcretera3.Enabled = false;
            this.cmbConcretera3.Location = new System.Drawing.Point(132, 76);
            this.cmbConcretera3.Name = "cmbConcretera3";
            this.cmbConcretera3.Size = new System.Drawing.Size(68, 21);
            this.cmbConcretera3.TabIndex = 51;
            this.cmbConcretera3.ValueMember = "IdConcretera";
            this.cmbConcretera3.SelectedIndexChanged += new System.EventHandler(this.cmbConcretera3_SelectedIndexChanged);
            // 
            // dsConcretera4
            // 
            this.dsConcretera4.DataSetName = "dsConcretera";
            this.dsConcretera4.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPlanta2
            // 
            this.cmbPlanta2.DataSource = this.dsPlanta3.Planta;
            this.cmbPlanta2.DisplayMember = "IdPlanta";
            this.cmbPlanta2.Enabled = false;
            this.cmbPlanta2.Location = new System.Drawing.Point(240, 52);
            this.cmbPlanta2.Name = "cmbPlanta2";
            this.cmbPlanta2.Size = new System.Drawing.Size(68, 21);
            this.cmbPlanta2.TabIndex = 50;
            this.cmbPlanta2.ValueMember = "IdPlanta";
            // 
            // dsPlanta3
            // 
            this.dsPlanta3.DataSetName = "dsPlanta";
            this.dsPlanta3.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbConcretera2
            // 
            this.cmbConcretera2.DataSource = this.dsConcretera3.Concretera;
            this.cmbConcretera2.DisplayMember = "IdConcretera";
            this.cmbConcretera2.Enabled = false;
            this.cmbConcretera2.Location = new System.Drawing.Point(132, 52);
            this.cmbConcretera2.Name = "cmbConcretera2";
            this.cmbConcretera2.Size = new System.Drawing.Size(68, 21);
            this.cmbConcretera2.TabIndex = 49;
            this.cmbConcretera2.ValueMember = "IdConcretera";
            this.cmbConcretera2.SelectedIndexChanged += new System.EventHandler(this.cmbConcretera2_SelectedIndexChanged);
            // 
            // dsConcretera3
            // 
            this.dsConcretera3.DataSetName = "dsConcretera";
            this.dsConcretera3.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPlanta1
            // 
            this.cmbPlanta1.DataSource = this.dsPlanta2.Planta;
            this.cmbPlanta1.DisplayMember = "IdPlanta";
            this.cmbPlanta1.Enabled = false;
            this.cmbPlanta1.Location = new System.Drawing.Point(240, 28);
            this.cmbPlanta1.Name = "cmbPlanta1";
            this.cmbPlanta1.Size = new System.Drawing.Size(68, 21);
            this.cmbPlanta1.TabIndex = 48;
            this.cmbPlanta1.ValueMember = "IdPlanta";
            // 
            // dsPlanta2
            // 
            this.dsPlanta2.DataSetName = "dsPlanta";
            this.dsPlanta2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbConcretera1
            // 
            this.cmbConcretera1.DataSource = this.dsConcretera2.Concretera;
            this.cmbConcretera1.DisplayMember = "IdConcretera";
            this.cmbConcretera1.Enabled = false;
            this.cmbConcretera1.Location = new System.Drawing.Point(132, 28);
            this.cmbConcretera1.Name = "cmbConcretera1";
            this.cmbConcretera1.Size = new System.Drawing.Size(68, 21);
            this.cmbConcretera1.TabIndex = 47;
            this.cmbConcretera1.ValueMember = "IdConcretera";
            this.cmbConcretera1.SelectedIndexChanged += new System.EventHandler(this.cmbConcretera1_SelectedIndexChanged);
            // 
            // dsConcretera2
            // 
            this.dsConcretera2.DataSetName = "dsConcretera";
            this.dsConcretera2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbx2
            // 
            this.cbx2.Location = new System.Drawing.Point(8, 28);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(40, 21);
            this.cbx2.TabIndex = 46;
            this.cbx2.Text = "2a.";
            this.cbx2.CheckedChanged += new System.EventHandler(this.cbx2_CheckedChanged);
            // 
            // cbx1
            // 
            this.cbx1.Checked = true;
            this.cbx1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx1.Location = new System.Drawing.Point(8, 8);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(40, 21);
            this.cbx1.TabIndex = 45;
            this.cbx1.Text = "1a.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Concretera:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbConcretera.DisplayMember = "IdConcretera";
            this.cmbConcretera.Location = new System.Drawing.Point(132, 4);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(68, 21);
            this.cmbConcretera.TabIndex = 41;
            this.cmbConcretera.ValueMember = "IdConcretera";
            this.cmbConcretera.SelectedIndexChanged += new System.EventHandler(this.cmbConcretera_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Planta:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DataSource = this.dsPlanta1.Planta;
            this.cmbPlanta.DisplayMember = "IdPlanta";
            this.cmbPlanta.Location = new System.Drawing.Point(240, 4);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(68, 21);
            this.cmbPlanta.TabIndex = 42;
            this.cmbPlanta.ValueMember = "IdPlanta";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(173, 139);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 67;
            this.label19.Text = "Agregado:";
            // 
            // cmbIdAgregado
            // 
            this.cmbIdAgregado.DataSource = this.dsAgregado1.Agregado;
            this.cmbIdAgregado.DisplayMember = "Tipo";
            this.cmbIdAgregado.Location = new System.Drawing.Point(237, 135);
            this.cmbIdAgregado.Name = "cmbIdAgregado";
            this.cmbIdAgregado.Size = new System.Drawing.Size(80, 21);
            this.cmbIdAgregado.TabIndex = 66;
            this.cmbIdAgregado.ValueMember = "IdAgregado";
            // 
            // dsAgregado1
            // 
            this.dsAgregado1.DataSetName = "dsAgregado";
            this.dsAgregado1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAgregado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(203, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataSource = this.dsTipo1.Tipo;
            this.cmbTipo.DisplayMember = "DesTipo";
            this.cmbTipo.Location = new System.Drawing.Point(237, 35);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(80, 21);
            this.cmbTipo.TabIndex = 64;
            this.cmbTipo.ValueMember = "Tipo";
            // 
            // dsTipo1
            // 
            this.dsTipo1.DataSetName = "dsTipo";
            this.dsTipo1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMqui
            // 
            this.txtMqui.Location = new System.Drawing.Point(820, 42);
            this.txtMqui.MaxLength = 2;
            this.txtMqui.Name = "txtMqui";
            this.txtMqui.Size = new System.Drawing.Size(20, 20);
            this.txtMqui.TabIndex = 63;
            this.txtMqui.Text = "15";
            this.txtMqui.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQui
            // 
            this.txtQui.Location = new System.Drawing.Point(820, 21);
            this.txtQui.MaxLength = 2;
            this.txtQui.Name = "txtQui";
            this.txtQui.Size = new System.Drawing.Size(20, 20);
            this.txtQui.TabIndex = 62;
            this.txtQui.Text = "63";
            this.txtQui.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(820, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "5°";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMcua
            // 
            this.txtMcua.Location = new System.Drawing.Point(797, 42);
            this.txtMcua.MaxLength = 2;
            this.txtMcua.Name = "txtMcua";
            this.txtMcua.Size = new System.Drawing.Size(20, 20);
            this.txtMcua.TabIndex = 60;
            this.txtMcua.Text = "5";
            this.txtMcua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCua
            // 
            this.txtCua.Location = new System.Drawing.Point(797, 21);
            this.txtCua.MaxLength = 2;
            this.txtCua.Name = "txtCua";
            this.txtCua.Size = new System.Drawing.Size(20, 20);
            this.txtCua.TabIndex = 59;
            this.txtCua.Text = "28";
            this.txtCua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(800, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "4°";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMter
            // 
            this.txtMter.Location = new System.Drawing.Point(773, 42);
            this.txtMter.MaxLength = 2;
            this.txtMter.Name = "txtMter";
            this.txtMter.Size = new System.Drawing.Size(20, 20);
            this.txtMter.TabIndex = 57;
            this.txtMter.Text = "5";
            this.txtMter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTer
            // 
            this.txtTer.Location = new System.Drawing.Point(773, 21);
            this.txtTer.MaxLength = 2;
            this.txtTer.Name = "txtTer";
            this.txtTer.Size = new System.Drawing.Size(20, 20);
            this.txtTer.TabIndex = 56;
            this.txtTer.Text = "14";
            this.txtTer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(777, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "3°";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMseg
            // 
            this.txtMseg.Location = new System.Drawing.Point(750, 42);
            this.txtMseg.MaxLength = 2;
            this.txtMseg.Name = "txtMseg";
            this.txtMseg.Size = new System.Drawing.Size(20, 20);
            this.txtMseg.TabIndex = 54;
            this.txtMseg.Text = "5";
            this.txtMseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSeg
            // 
            this.txtSeg.Location = new System.Drawing.Point(750, 21);
            this.txtSeg.MaxLength = 2;
            this.txtSeg.Name = "txtSeg";
            this.txtSeg.Size = new System.Drawing.Size(20, 20);
            this.txtSeg.TabIndex = 53;
            this.txtSeg.Text = "7";
            this.txtSeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(753, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "2°";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMpri
            // 
            this.txtMpri.Location = new System.Drawing.Point(723, 42);
            this.txtMpri.MaxLength = 2;
            this.txtMpri.Name = "txtMpri";
            this.txtMpri.Size = new System.Drawing.Size(20, 20);
            this.txtMpri.TabIndex = 51;
            this.txtMpri.Text = "5";
            this.txtMpri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPri
            // 
            this.txtPri.Location = new System.Drawing.Point(723, 21);
            this.txtPri.MaxLength = 2;
            this.txtPri.Name = "txtPri";
            this.txtPri.Size = new System.Drawing.Size(20, 20);
            this.txtPri.TabIndex = 50;
            this.txtPri.Text = "3";
            this.txtPri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(730, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "1°";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(637, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Minímo ensayes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(690, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Días:";
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(84, 84);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(80, 21);
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
            this.label7.Location = new System.Drawing.Point(36, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Prueba:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Resistencia:";
            // 
            // cmbRes
            // 
            this.cmbRes.DataSource = this.dsBusResistencia1.Resistencia;
            this.cmbRes.DisplayMember = "Resistencia";
            this.cmbRes.Location = new System.Drawing.Point(237, 111);
            this.cmbRes.Name = "cmbRes";
            this.cmbRes.Size = new System.Drawing.Size(80, 21);
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
            this.label11.Location = new System.Drawing.Point(7, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "F. geométrica:";
            // 
            // cmbDiam1
            // 
            this.cmbDiam1.DataSource = this.dsDiametro1.Diametro;
            this.cmbDiam1.DisplayMember = "Diametro";
            this.cmbDiam1.Location = new System.Drawing.Point(84, 60);
            this.cmbDiam1.Name = "cmbDiam1";
            this.cmbDiam1.Size = new System.Drawing.Size(79, 21);
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
            this.cmbUnidad.Location = new System.Drawing.Point(84, 108);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(80, 21);
            this.cmbUnidad.TabIndex = 10;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(237, 87);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(80, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(237, 62);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(80, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBuscaObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(84, 36);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tendencia por concretera";
            // 
            // dsConcretoC1
            // 
            this.dsConcretoC1.DataSetName = "dsConcretoC";
            this.dsConcretoC1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretoC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // crvRepTendenciaP
            // 
            this.crvRepTendenciaP.ActiveViewIndex = -1;
            this.crvRepTendenciaP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepTendenciaP.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepTendenciaP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepTendenciaP.EnableRefresh = false;
            this.crvRepTendenciaP.Location = new System.Drawing.Point(0, 166);
            this.crvRepTendenciaP.Name = "crvRepTendenciaP";
            this.crvRepTendenciaP.ShowCloseButton = false;
            this.crvRepTendenciaP.ShowGroupTreeButton = false;
            this.crvRepTendenciaP.ShowLogo = false;
            this.crvRepTendenciaP.ShowRefreshButton = false;
            this.crvRepTendenciaP.Size = new System.Drawing.Size(1028, 576);
            this.crvRepTendenciaP.TabIndex = 11;
            this.crvRepTendenciaP.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepTendenciaP.ToolPanelWidth = 167;
            // 
            // sqlDATendencia
            // 
            this.sqlDATendencia.SelectCommand = this.sqlSelectCommand3;
            this.sqlDATendencia.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RepTendenciaP", new System.Data.Common.DataColumnMapping[] {
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
            this.sqlSelectCommand3.CommandText = "RepTendenciaPX";
            this.sqlSelectCommand3.CommandTimeout = 120;
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
            new System.Data.SqlClient.SqlParameter("@m5", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Rango", System.Data.SqlDbType.Real, 4)});
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
            // sqlDATipo
            // 
            this.sqlDATipo.SelectCommand = this.sqlSelectCommand4;
            this.sqlDATipo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("DesTipo", "DesTipo")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT Tipo, DesTipo FROM Tipo";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            // 
            // sqlDAAgregado
            // 
            this.sqlDAAgregado.SelectCommand = this.sqlSelectCommand8;
            this.sqlDAAgregado.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Agregado", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo")})});
            // 
            // sqlSelectCommand8
            // 
            this.sqlSelectCommand8.CommandText = "SELECT IdAgregado, Agregado, Tipo FROM Agregado";
            this.sqlSelectCommand8.Connection = this.sqlConn;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 392);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // dsTendenciaC1
            // 
            this.dsTendenciaC1.DataSetName = "dsTendenciaC";
            this.dsTendenciaC1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsTendenciaC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RepTendenciaP
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1028, 742);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crvRepTendenciaP);
            this.Controls.Add(this.panel1);
            this.Name = "RepTendenciaP";
            this.Text = "RepTendenciaP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepTendenciaP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusResistencia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretoC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTendenciaC1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		protected GraphPane myPane;

		private void RepTendenciaP_Load(object sender, System.EventArgs e)
		{
			dsBuscaObra1.Obra.AddObraRow("Todas","%", " "," "," "," ");
			sqlDABusObra.Fill(dsBuscaObra1, "Obra");
			cmbIdObra.SelectedIndex = 0;
            cmbIdObra.SelectedIndex = 1;
            cmbIdObra.SelectedIndex = 0;
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
			cmbPrueba.SelectedIndex = 0;
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			cmbUnidad.SelectedIndex = 0;
			sqlDADiametro.Fill(dsDiametro1, "Diametro");
			cmbDiam1.SelectedIndex = 0;
			sqlDARes.Fill(dsBusResistencia1, "Resistencia");
			cmbRes.SelectedIndex = 0;
			sqlDATipo.Fill(dsTipo1, "Tipo");
			cmbTipo.SelectedIndex = 0;
			sqlDAAgregado.Fill(dsAgregado1, "Agregado");
			cmbIdAgregado.SelectedIndex = 0;

			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			cmbConcretera.SelectedIndex = 0;
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",cmbConcretera.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1, "Planta");

			sqlDAConcretera.Fill(dsConcretera2, "Concretera");
			cmbConcretera1.SelectedIndex = 0;
			dsPlanta2.Planta.AddPlantaRow(-1,"Todas",cmbConcretera1.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera1.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta2, "Planta");

			sqlDAConcretera.Fill(dsConcretera3, "Concretera");
			cmbConcretera2.SelectedIndex = 0;
			dsPlanta3.Planta.AddPlantaRow(-1,"Todas",cmbConcretera2.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera2.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta3, "Planta");

			sqlDAConcretera.Fill(dsConcretera4, "Concretera");
			cmbConcretera3.SelectedIndex = 0;
			dsPlanta4.Planta.AddPlantaRow(-1,"Todas",cmbConcretera3.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera3.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta4, "Planta");

			sqlDAConcretera.Fill(dsConcretera5, "Concretera");
			cmbConcretera4.SelectedIndex = 0;
			dsPlanta5.Planta.AddPlantaRow(-1,"Todas",cmbConcretera4.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera4.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta5, "Planta");

		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsConcretoC1.Clear();
			sqlDAConcreto.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAConcreto.Fill(dsConcretoC1, "Muestras");
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			cbkPrefijo.Checked = true;
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			btnVistaPrevia.Visible = true;
//			cmbRes.SelectedItem = dsConcretoC1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			int j = 0;
			int k = 0;
			double[] x = new double[5];
			double[] y = new double[5];
			
			try
				{
				dsTendenciaC1.Clear();
			
                sqlDATendencia.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text);
				sqlDATendencia.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
				sqlDATendencia.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
				sqlDATendencia.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
				sqlDATendencia.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
				sqlDATendencia.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
				sqlDATendencia.SelectCommand.Parameters["@ResistenciaKg"].Value = cmbRes.SelectedValue.ToString();
				sqlDATendencia.SelectCommand.Parameters["@Tipo"].Value = cmbTipo.SelectedValue.ToString();
				sqlDATendencia.SelectCommand.Parameters["@IdAgregado"].Value = cmbIdAgregado.SelectedValue.ToString() ;
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
                sqlDATendencia.SelectCommand.Parameters["@Rango"].Value = decimal.Parse(txtRango.Text);

				sqlDATendencia.Fill(dsTendenciaC1, "RepTendencia");
				if (cbx2.Checked)
				{
					sqlDATendencia.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera1.SelectedValue.ToString();
					sqlDATendencia.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta1.SelectedValue.ToString();
					sqlDATendencia.Fill(dsTendenciaC1, "RepTendencia");
				}
				if (cbx3.Checked)
				{
					sqlDATendencia.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera2.SelectedValue.ToString();
					sqlDATendencia.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta2.SelectedValue.ToString();
					sqlDATendencia.Fill(dsTendenciaC1, "RepTendencia");
				}
				if (cbx4.Checked)
				{
					sqlDATendencia.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera3.SelectedValue.ToString();
					sqlDATendencia.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta3.SelectedValue.ToString();
					sqlDATendencia.Fill(dsTendenciaC1, "RepTendencia");
				}
				if (cbx5.Checked)
				{
					sqlDATendencia.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera4.SelectedValue.ToString();
					sqlDATendencia.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta4.SelectedValue.ToString();
					sqlDATendencia.Fill(dsTendenciaC1, "RepTendencia");
				}

				// Establece el valor actual de parameter1 en el subinforme en 10 
                cryRepTendenciaP1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cryRepTendenciaP1.SetDataSource(dsTendenciaC1);				

                cryRepTendenciaP1.SetParameterValue("@Unidad", cmbUnidad.Text);
				cryRepTendenciaP1.SetParameterValue("@Prueba", cmbPrueba.Text);
				cryRepTendenciaP1.SetParameterValue("@fi", dtpIni.Text);
				cryRepTendenciaP1.SetParameterValue("@ff", dtpFin.Text);
				cryRepTendenciaP1.SetParameterValue("@Tipo", cmbTipo.Text);
				cryRepTendenciaP1.SetParameterValue("@TA", cmbIdAgregado.Text);
				cryRepTendenciaP1.SetParameterValue("@Cra", (cmbIdObra.SelectedValue.ToString() == "Todas" ? " " : dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString()));
				cryRepTendenciaP1.SetParameterValue("@Obr", txtIdobra.Text);
				cryRepTendenciaP1.SetParameterValue("@Zon", (cmbIdObra.SelectedValue.ToString() == "Todas" ? " " : dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString()));
				cryRepTendenciaP1.SetParameterValue("@Con", cmbConcretera.Text);
				cryRepTendenciaP1.SetParameterValue("@Pta", cmbPlanta.Text);
				cryRepTendenciaP1.SetParameterValue("@Col", (cmbIdObra.SelectedValue.ToString() == "Todas" ? " " : dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString()));
//				cryRepTendenciaP1.SetParameterValue("@Titulo", "GRAFICO DE TENDENCIA");
				cryRepTendenciaP1.SetParameterValue("@Figura", cmbDiam1.Text);
                cryRepTendenciaP1.SetParameterValue("@Lab", chbLab.Checked);

				memGraphics.CreateDoubleBuffer(this.CreateGraphics(),
					this.ClientRectangle.Width, this.ClientRectangle.Height);

				myPane = new GraphPane( new Rectangle( 10, 10, 10, 10 ),
					"", "Edad en días", "Resistencia");
				SetSize();

				CurveItem curve;
				for (j=0; j < dsTendenciaC1.Tables[0].Rows.Count; j++)
				{
					for (k = 0; k < 5; k++)
						x[k] = y[k] = 0;
					k = 0;
					string acotacion = dsTendenciaC1.Tables[0].Rows[j][0].ToString();
					if (dsTendenciaC1.Tables[0].Rows[j][5].ToString() != "")
					{
                        if (dsTendenciaC1.Tables[0].Rows[j][3].ToString() == "-2" && (cmbTipo.SelectedValue.ToString().Trim() == "8" || cmbTipo.SelectedValue.ToString().Trim() == "13"))
                            x[k] = 0.667;
                        else
                            x[k] = double.Parse(dsTendenciaC1.Tables[0].Rows[j][3].ToString());
						y[k++] = double.Parse(dsTendenciaC1.Tables[0].Rows[j][5].ToString());
					}
					if (dsTendenciaC1.Tables[0].Rows[j][9].ToString() != "")
					{
                        if (dsTendenciaC1.Tables[0].Rows[j][7].ToString() == "-1" && (cmbTipo.SelectedValue.ToString().Trim() == "8" || cmbTipo.SelectedValue.ToString().Trim() == "13"))
                            x[k] = 0.883;
                        else
                            x[k] = double.Parse(dsTendenciaC1.Tables[0].Rows[j][7].ToString());
                        y[k++] = double.Parse(dsTendenciaC1.Tables[0].Rows[j][9].ToString());
					}
					if (dsTendenciaC1.Tables[0].Rows[j][13].ToString() != "")
					{
						x[k] = double.Parse(dsTendenciaC1.Tables[0].Rows[j][11].ToString());
						y[k++] = double.Parse(dsTendenciaC1.Tables[0].Rows[j][13].ToString());
					}
					if (dsTendenciaC1.Tables[0].Rows[j][17].ToString() != "")
					{
						x[k] = double.Parse(dsTendenciaC1.Tables[0].Rows[j][15].ToString());
						y[k++] = double.Parse(dsTendenciaC1.Tables[0].Rows[j][17].ToString());
					}
					if (dsTendenciaC1.Tables[0].Rows[j][21].ToString() != "")
					{
						x[k] = double.Parse(dsTendenciaC1.Tables[0].Rows[j][19].ToString());
						y[k++] = double.Parse(dsTendenciaC1.Tables[0].Rows[j][21].ToString());
					}
					if ( j == 0 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
						curve = myPane.AddCurve( acotacion, x, y, Color.Chocolate, SymbolType.Circle );
						curve.Line.Width = 2.0F;
						curve.Symbol.Fill = new Fill( Color.Chocolate );
					}
					if ( j == 1 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
						curve = myPane.AddCurve( acotacion, x, y, Color.DarkBlue, SymbolType.Diamond );
						curve.Line.Width = 2.0F;
						curve.Symbol.Fill = new Fill( Color.DarkBlue );
						curve.Symbol.Size = 12;
					}
					if ( j == 2 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
						curve = myPane.AddCurve( acotacion, x, y, Color.Red, SymbolType.Star );
						curve.Line.Width = 2.0F;
						curve.Symbol.Fill = new Fill( Color.Red );
						curve.Symbol.Size = 12;
					}
					if ( j == 3 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
						curve = myPane.AddCurve( acotacion, x, y, Color.Brown, SymbolType.TriangleDown );
						curve.Line.Width = 2.0F;
						curve.Symbol.Fill = new Fill( Color.Brown );
						curve.Symbol.Size = 12;
					}
					if ( j == 4 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
						curve = myPane.AddCurve( acotacion, x, y, Color.Magenta, SymbolType.Plus );
						curve.Line.Width = 2.0F;
						curve.Symbol.Fill = new Fill( Color.Magenta );
						curve.Symbol.Size = 12;

					}
					if ( j == 5 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
						curve = myPane.AddCurve( acotacion, x, y, Color.DarkBlue, SymbolType.Square );
						curve.Line.Width = 2.0F;
						curve.Symbol.Fill = new Fill( Color.DarkBlue );
						curve.Symbol.Size = 12;
					}
					if ( j == 6 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
						curve = myPane.AddCurve( acotacion, x, y, Color.Red, SymbolType.Triangle );
						curve.Line.Width = 2.0F;
						curve.Symbol.Fill = new Fill( Color.Red );
						curve.Symbol.Size = 12;
					}
					if ( j == 7 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
						curve = myPane.AddCurve( acotacion, x, y, Color.Brown, SymbolType.XCross );
						curve.Line.Width = 2.0F;
						curve.Symbol.Fill = new Fill( Color.Brown );
						curve.Symbol.Size = 12;
					}
					if ( j == 8 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
					{
						curve = myPane.AddCurve( acotacion, x, y, Color.Magenta, SymbolType.Circle );
						curve.Line.Width = 2.0F;
						curve.Symbol.Fill = new Fill( Color.White );
						curve.Symbol.Size = 12;

					}
                    if (j == 9 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
                    {
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkGoldenrod, SymbolType.Square);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkGoldenrod);
                        curve.Symbol.Size = 12;
                    }
                    if (j == 10 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
                    {
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkKhaki, SymbolType.Triangle);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkKhaki);
                        curve.Symbol.Size = 12;
                    }
                    if (j == 11 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
                    {
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkOrchid, SymbolType.XCross);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkOrchid);
                        curve.Symbol.Size = 12;
                    }
                    if (j == 12 && double.Parse(dsTendenciaC1.Tables[0].Rows[j][2].ToString()) < 10000)
                    {
                        curve = myPane.AddCurve(acotacion, x, y, Color.DarkViolet, SymbolType.Circle);
                        curve.Line.Width = 2.0F;
                        curve.Symbol.Fill = new Fill(Color.DarkViolet);
                        curve.Symbol.Size = 12;

                    }
                }
                float F16 = 0.67F;
                ArrowItem arrow = new ArrowItem(Color.Red, 0, F16, 0, F16, float.Parse(txtMaximo.Text));
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 0F;
                myPane.ArrowList.Add(arrow);
                F16 = 0.83F;
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
				arrow = new ArrowItem (Color.Gray, 0,7,0,7,float.Parse(txtMaximo.Text));
				arrow.CoordinateFrame = CoordType.AxisXYScale;
				arrow.PenWidth = 0F;
				myPane.ArrowList.Add( arrow);
				arrow = new ArrowItem (Color.Gray, 0,14,0,14,float.Parse(txtMaximo.Text));
				arrow.CoordinateFrame = CoordType.AxisXYScale;
				arrow.PenWidth = 0F;
				myPane.ArrowList.Add( arrow);
				arrow = new ArrowItem (Color.Gray, 0,28,0,28,float.Parse(txtMaximo.Text));
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

                    curve = myPane.AddCurve((j * 50 + 200).ToString(), x, y, colorado[j], SymbolType.Diamond);
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
                myPane.PaneFill = new Fill(Color.White, Color.White, 0F);
				myPane.AxisChange( this.CreateGraphics() );
				pictureBox1.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
				MemoryStream ms = new MemoryStream();
				pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
				byte[] arrImage = ms.GetBuffer();
				ms.Close();
				
				myPane.Image.Dispose();
				pictureBox1.Image.Dispose();
				dsTendenciaC1.Grafica.AddGraficaRow(Math.Round(double.Parse(dsTendenciaC1.Tables[0].Rows[0][2].ToString()),4),arrImage);

				
			
				crvRepTendenciaP.ReportSource = cryRepTendenciaP1;
				// crvRepTendenciaP.RefreshReport();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}

		}

		private void cmbConcretera_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsPlanta1.Clear();
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",cmbConcretera.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
		}

		private void cbx2_CheckedChanged(object sender, System.EventArgs e)
		{
			
			cmbConcretera1.Enabled = (cbx2.Checked ? true : false);
			cmbPlanta1.Enabled = (cbx2.Checked ? true : false);
		}

		private void cbx3_CheckedChanged(object sender, System.EventArgs e)
		{
			cmbConcretera2.Enabled = (cbx3.Checked ? true : false);
			cmbPlanta2.Enabled = (cbx3.Checked ? true : false);
		}

		private void ckb4_CheckedChanged(object sender, System.EventArgs e)
		{
			cmbConcretera3.Enabled = (cbx4.Checked ? true : false);
			cmbPlanta3.Enabled = (cbx4.Checked ? true : false);
		}

		private void ckb5_CheckedChanged(object sender, System.EventArgs e)
		{
			cmbConcretera4.Enabled = (cbx5.Checked ? true : false);
			cmbPlanta4.Enabled = (cbx5.Checked ? true : false);
		}

		private void cmbConcretera1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsPlanta2.Clear();
			dsPlanta2.Planta.AddPlantaRow(-1,"Todas",cmbConcretera1.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera1.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta2, "Planta");
		}

		private void cmbConcretera2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsPlanta3.Clear();
			dsPlanta3.Planta.AddPlantaRow(-1,"Todas",cmbConcretera2.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera2.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta3, "Planta");
		
		}

		private void cmbConcretera3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsPlanta4.Clear();
			dsPlanta4.Planta.AddPlantaRow(-1,"Todas",cmbConcretera3.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera3.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta4, "Planta");
		}

		private void cmbConcretera4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsPlanta5.Clear();
			dsPlanta5.Planta.AddPlantaRow(-1,"Todas",cmbConcretera4.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera4.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta5, "Planta");		
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

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

	}
}
