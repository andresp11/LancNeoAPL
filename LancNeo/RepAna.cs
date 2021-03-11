using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using ZedGraph;
using System.IO;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de RepAna.
	/// </summary>
	public class RepAna : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
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
		private System.Windows.Forms.ComboBox cmbConcretera;
		private System.Windows.Forms.ComboBox cmbPlanta;
		private LancNeo.dsConcreto dsConcreto1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcreto;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDANoEco;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsBusNoEco dsBusNoEco1;
		private System.Windows.Forms.ComboBox cmbNoEco;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtA3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepAnalisis;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAnalisis;
		private LancNeo.dsAnalisis dsAnalisis1;
		private System.Windows.Forms.TextBox txtEE;
		private System.Windows.Forms.TextBox txtA7;
		private System.Data.SqlClient.SqlDataAdapter sqlDATitulo;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Windows.Forms.Label lblIndice;
		private System.Windows.Forms.TextBox txtResIndice;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.CheckBox cbkFormato;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtIncrem;
		private LancNeo.CryRepAna cryRepAna1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn2;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusParTip;
		private System.Data.SqlClient.SqlCommand sqlCommand3;
		private LancNeo.dsBusPTC dsBusPTC1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAnaNew;
		private System.Data.SqlClient.SqlCommand sqlCommand4;
		private LancNeo.dsAplPrueba dsAplPrueba1;
		private System.Windows.Forms.CheckBox chbLeyenda;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDANorma;
		private System.Windows.Forms.CheckBox chbLab;
        private CryRepAna3 cryRepAna31;
        private CryRepAna1 cryRepAna11;
        private CryRepAna7 cryRepAna71;
        private DBGraphics memGraphics;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private SqlDataAdapter sqlDATenPro;
        private SqlCommand sqlCommand5;
        private dsTenPro dsTenPro1;
        private ComboBox cmbOrigen;
        private Label label16;
        private dsOrigenCo dsOrigenCo1;

        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public RepAna()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
            memGraphics = new DBGraphics();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepAna));
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
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsConcreto1 = new LancNeo.dsConcreto();
            this.buscaBtn2 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusPTC1 = new LancNeo.dsBusPTC();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.dsOrigenCo1 = new LancNeo.dsOrigenCo();
            this.label16 = new System.Windows.Forms.Label();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.txtIncrem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbkFormato = new System.Windows.Forms.CheckBox();
            this.txtEE = new System.Windows.Forms.TextBox();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.lblIndice = new System.Windows.Forms.Label();
            this.txtResIndice = new System.Windows.Forms.TextBox();
            this.cmbNoEco = new System.Windows.Forms.ComboBox();
            this.dsBusNoEco1 = new LancNeo.dsBusNoEco();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtA7 = new System.Windows.Forms.TextBox();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.cmbConcretera = new System.Windows.Forms.ComboBox();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.sqlDAConcreto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDANoEco = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.crvRepAnalisis = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAAnalisis = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsAnalisis1 = new LancNeo.dsAnalisis();
            this.sqlDATitulo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.cryRepAna1 = new LancNeo.CryRepAna();
            this.sqlDABusParTip = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAAnaNew = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsAplPrueba1 = new LancNeo.dsAplPrueba();
            this.sqlDANorma = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.cryRepAna31 = new LancNeo.CryRepAna3();
            this.cryRepAna11 = new LancNeo.CryRepAna1();
            this.cryRepAna71 = new LancNeo.CryRepAna7();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sqlDATenPro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.dsTenPro1 = new LancNeo.dsTenPro();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusPTC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigenCo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNoEco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalisis1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTenPro1)).BeginInit();
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
            this.sqlDAConcretera.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(this.sqlDAConcretera_RowUpdated);
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT IdConcretera, Concretera, Direccion FROM Concretera ORDER BY IdConcretera";
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
            this.sqlSelectCommand6.CommandText = "SELECT     IdConcretera, IdPlanta, LTRIM(STR(IdPlanta)) + \' .-. \' + Planta AS Pla" +
    "nta\r\nFROM         Planta\r\nWHERE     (IdConcretera LIKE @IdConcretera)\r\nORDER BY " +
    "IdConcretera, Planta";
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
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.buscaBtn2);
            this.panel1.Controls.Add(this.cmbOrigen);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.txtIncrem);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cbkFormato);
            this.panel1.Controls.Add(this.txtEE);
            this.panel1.Controls.Add(this.cbkPrefijo);
            this.panel1.Controls.Add(this.lblIndice);
            this.panel1.Controls.Add(this.txtResIndice);
            this.panel1.Controls.Add(this.cmbNoEco);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtA7);
            this.panel1.Controls.Add(this.txtA3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
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
            this.panel1.Controls.Add(this.cmbConcretera);
            this.panel1.Controls.Add(this.cmbPlanta);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 114);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(747, 2);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 37;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Load += new System.EventHandler(this.btnVistaPrevia_Load);
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConcreto1.Muestras;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(196, -2);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(58, 54);
            this.buscaBtn1.TabIndex = 36;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsConcreto1
            // 
            this.dsConcreto1.DataSetName = "dsConcreto";
            this.dsConcreto1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcreto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscaBtn2
            // 
            this.buscaBtn2.AnchoDlgBusq = 800;
            this.buscaBtn2.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn2.Datos = this.dsBusPTC1.ParamTipos;
            this.buscaBtn2.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn2.Icon")));
            this.buscaBtn2.Location = new System.Drawing.Point(676, 7);
            this.buscaBtn2.Name = "buscaBtn2";
            this.buscaBtn2.Size = new System.Drawing.Size(58, 54);
            this.buscaBtn2.TabIndex = 43;
            this.buscaBtn2.Visible = false;
            this.buscaBtn2.Click += new System.EventHandler(this.buscaBtn2_Click);
            // 
            // dsBusPTC1
            // 
            this.dsBusPTC1.DataSetName = "dsBusPTC";
            this.dsBusPTC1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusPTC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DataSource = this.dsOrigenCo1;
            this.cmbOrigen.DisplayMember = "OrigenCo.Origen";
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(642, 80);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(79, 21);
            this.cmbOrigen.TabIndex = 80;
            this.cmbOrigen.ValueMember = "OrigenCo.IdOrigen";
            // 
            // dsOrigenCo1
            // 
            this.dsOrigenCo1.DataSetName = "dsOrigenCo";
            this.dsOrigenCo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(599, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 79;
            this.label16.Text = "Origen:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.ForeColor = System.Drawing.Color.White;
            this.chbLab.Location = new System.Drawing.Point(253, 52);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 24);
            this.chbLab.TabIndex = 78;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.Checked = true;
            this.chbLeyenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLeyenda.ForeColor = System.Drawing.Color.White;
            this.chbLeyenda.Location = new System.Drawing.Point(132, 52);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(116, 24);
            this.chbLeyenda.TabIndex = 44;
            this.chbLeyenda.Text = "Formato leyenda";
            // 
            // txtIncrem
            // 
            this.txtIncrem.Location = new System.Drawing.Point(513, 80);
            this.txtIncrem.MaxLength = 3;
            this.txtIncrem.Name = "txtIncrem";
            this.txtIncrem.Size = new System.Drawing.Size(34, 20);
            this.txtIncrem.TabIndex = 42;
            this.txtIncrem.Text = "10";
            this.txtIncrem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(423, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Incremento eje:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbkFormato
            // 
            this.cbkFormato.ForeColor = System.Drawing.Color.White;
            this.cbkFormato.Location = new System.Drawing.Point(8, 52);
            this.cbkFormato.Name = "cbkFormato";
            this.cbkFormato.Size = new System.Drawing.Size(116, 24);
            this.cbkFormato.TabIndex = 40;
            this.cbkFormato.Text = "Formato con obra";
            // 
            // txtEE
            // 
            this.txtEE.Location = new System.Drawing.Point(642, 52);
            this.txtEE.MaxLength = 5;
            this.txtEE.Name = "txtEE";
            this.txtEE.Size = new System.Drawing.Size(28, 20);
            this.txtEE.TabIndex = 29;
            this.txtEE.Text = "0";
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.ForeColor = System.Drawing.Color.White;
            this.cbkPrefijo.Location = new System.Drawing.Point(8, 26);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 35;
            this.cbkPrefijo.Text = "No prefijo";
            this.cbkPrefijo.CheckedChanged += new System.EventHandler(this.cbkPrefijo_CheckedChanged);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(884, -2);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(39, 13);
            this.lblIndice.TabIndex = 34;
            this.lblIndice.Text = "Indice:";
            this.lblIndice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIndice.Visible = false;
            // 
            // txtResIndice
            // 
            this.txtResIndice.Location = new System.Drawing.Point(924, -2);
            this.txtResIndice.MaxLength = 3;
            this.txtResIndice.Name = "txtResIndice";
            this.txtResIndice.Size = new System.Drawing.Size(34, 20);
            this.txtResIndice.TabIndex = 33;
            this.txtResIndice.Text = "30";
            this.txtResIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResIndice.Visible = false;
            // 
            // cmbNoEco
            // 
            this.cmbNoEco.DataSource = this.dsBusNoEco1.Laboratorista;
            this.cmbNoEco.DisplayMember = "Laboratorista";
            this.cmbNoEco.Location = new System.Drawing.Point(50, 80);
            this.cmbNoEco.Name = "cmbNoEco";
            this.cmbNoEco.Size = new System.Drawing.Size(228, 21);
            this.cmbNoEco.TabIndex = 25;
            this.cmbNoEco.ValueMember = "NoEco";
            // 
            // dsBusNoEco1
            // 
            this.dsBusNoEco1.DataSetName = "dsBusNoEco";
            this.dsBusNoEco1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusNoEco1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(562, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Ajuste a 7 días:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(562, -2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ajuste a 3 días:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(552, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Ajuste Edad Esp:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtA7
            // 
            this.txtA7.Location = new System.Drawing.Point(642, 26);
            this.txtA7.MaxLength = 5;
            this.txtA7.Name = "txtA7";
            this.txtA7.Size = new System.Drawing.Size(28, 20);
            this.txtA7.TabIndex = 28;
            this.txtA7.Text = "0";
            // 
            // txtA3
            // 
            this.txtA3.Location = new System.Drawing.Point(642, -2);
            this.txtA3.MaxLength = 5;
            this.txtA3.Name = "txtA3";
            this.txtA3.Size = new System.Drawing.Size(28, 20);
            this.txtA3.TabIndex = 27;
            this.txtA3.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "NoEco:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(434, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Planta:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(410, -2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Concretera:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(456, 52);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(94, 21);
            this.cmbUnidad.TabIndex = 10;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(418, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(326, 26);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(298, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(326, -2);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(294, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBuscaObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(114, 26);
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Análisis Estadístico";
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(256, -2);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(38, 38);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbConcretera.DisplayMember = "IdConcretera";
            this.cmbConcretera.Location = new System.Drawing.Point(472, -2);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(78, 21);
            this.cmbConcretera.TabIndex = 5;
            this.cmbConcretera.ValueMember = "IdConcretera";
            this.cmbConcretera.SelectedIndexChanged += new System.EventHandler(this.cmbConcretera_SelectedIndexChanged);
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DataSource = this.dsPlanta1.Planta;
            this.cmbPlanta.DisplayMember = "Planta";
            this.cmbPlanta.Enabled = false;
            this.cmbPlanta.Location = new System.Drawing.Point(472, 26);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(78, 21);
            this.cmbPlanta.TabIndex = 6;
            this.cmbPlanta.ValueMember = "IdPlanta";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(202, 16);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
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
            this.sqlSelectCommand3.CommandText = "SELECT NoEco, Laboratorista FROM Laboratorista ORDER BY Laboratorista";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // crvRepAnalisis
            // 
            this.crvRepAnalisis.ActiveViewIndex = -1;
            this.crvRepAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepAnalisis.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepAnalisis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepAnalisis.EnableRefresh = false;
            this.crvRepAnalisis.Location = new System.Drawing.Point(0, 114);
            this.crvRepAnalisis.Name = "crvRepAnalisis";
            this.crvRepAnalisis.ShowCloseButton = false;
            this.crvRepAnalisis.ShowGroupTreeButton = false;
            this.crvRepAnalisis.ShowLogo = false;
            this.crvRepAnalisis.ShowRefreshButton = false;
            this.crvRepAnalisis.Size = new System.Drawing.Size(1028, 634);
            this.crvRepAnalisis.TabIndex = 11;
            this.crvRepAnalisis.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepAnalisis.ToolPanelWidth = 167;
            // 
            // sqlDAAnalisis
            // 
            this.sqlDAAnalisis.SelectCommand = this.sqlSelectCommand4;
            this.sqlDAAnalisis.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Analisis", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("Rev", "Rev"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("  3", "  3"),
                        new System.Data.Common.DataColumnMapping(" 3i", " 3i"),
                        new System.Data.Common.DataColumnMapping("  7", "  7"),
                        new System.Data.Common.DataColumnMapping(" 7i", " 7i"),
                        new System.Data.Common.DataColumnMapping("C", "C"),
                        new System.Data.Common.DataColumnMapping("ee1", "ee1"),
                        new System.Data.Common.DataColumnMapping("ee2", "ee2"),
                        new System.Data.Common.DataColumnMapping("Int", "Int"),
                        new System.Data.Common.DataColumnMapping("Prm", "Prm"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Con", "Con"),
                        new System.Data.Common.DataColumnMapping("200", "200"),
                        new System.Data.Common.DataColumnMapping(" 63", " 63"),
                        new System.Data.Common.DataColumnMapping("N", "N"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("unico", "unico"),
                        new System.Data.Common.DataColumnMapping("hoja", "hoja"),
                        new System.Data.Common.DataColumnMapping("a1", "a1"),
                        new System.Data.Common.DataColumnMapping("a2", "a2"),
                        new System.Data.Common.DataColumnMapping("a3", "a3")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "[AnalisisnEW]";
            this.sqlSelectCommand4.CommandTimeout = 60;
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
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
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@3i", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@7i", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@eei", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@datos", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Indice", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 1),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Increm", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@Tempranos", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@DesPar", System.Data.SqlDbType.VarChar, 25),
            new System.Data.SqlClient.SqlParameter("@Origen", System.Data.SqlDbType.Int)});
            // 
            // dsAnalisis1
            // 
            this.dsAnalisis1.DataSetName = "dsAnalisis";
            this.dsAnalisis1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsAnalisis1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDATitulo
            // 
            this.sqlDATitulo.SelectCommand = this.sqlSelectCommand7;
            this.sqlDATitulo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Titulo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Ejex", "Ejex"),
                        new System.Data.Common.DataColumnMapping("c1", "c1"),
                        new System.Data.Common.DataColumnMapping("c2", "c2"),
                        new System.Data.Common.DataColumnMapping("c3", "c3"),
                        new System.Data.Common.DataColumnMapping("c4", "c4"),
                        new System.Data.Common.DataColumnMapping("c5", "c5"),
                        new System.Data.Common.DataColumnMapping("c6", "c6"),
                        new System.Data.Common.DataColumnMapping("c7", "c7"),
                        new System.Data.Common.DataColumnMapping("c8", "c8"),
                        new System.Data.Common.DataColumnMapping("c9", "c9"),
                        new System.Data.Common.DataColumnMapping("c10", "c10"),
                        new System.Data.Common.DataColumnMapping("c11", "c11"),
                        new System.Data.Common.DataColumnMapping("c12", "c12")})});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "[Titulo]";
            this.sqlSelectCommand7.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand7.Connection = this.sqlConn;
            this.sqlSelectCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKg", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Hoja", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@incre", System.Data.SqlDbType.Float, 8)});
            // 
            // sqlDABusParTip
            // 
            this.sqlDABusParTip.SelectCommand = this.sqlCommand3;
            this.sqlDABusParTip.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ParamTipos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("DesTipo", "DesTipo"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro"),
                        new System.Data.Common.DataColumnMapping("Figura", "Figura"),
                        new System.Data.Common.DataColumnMapping("Tempranos", "Tempranos"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba"),
                        new System.Data.Common.DataColumnMapping("DesPar", "DesPar")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdTipo", System.Data.SqlDbType.NVarChar, 6, "DesTipo")});
            // 
            // sqlDAAnaNew
            // 
            this.sqlDAAnaNew.SelectCommand = this.sqlCommand4;
            this.sqlDAAnaNew.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Analisis", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("Rev", "Rev"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("  3", "  3"),
                        new System.Data.Common.DataColumnMapping(" 3i", " 3i"),
                        new System.Data.Common.DataColumnMapping("  7", "  7"),
                        new System.Data.Common.DataColumnMapping(" 7i", " 7i"),
                        new System.Data.Common.DataColumnMapping("C", "C"),
                        new System.Data.Common.DataColumnMapping("ee1", "ee1"),
                        new System.Data.Common.DataColumnMapping("ee2", "ee2"),
                        new System.Data.Common.DataColumnMapping("Int", "Int"),
                        new System.Data.Common.DataColumnMapping("Prm", "Prm"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Con", "Con"),
                        new System.Data.Common.DataColumnMapping("200", "200"),
                        new System.Data.Common.DataColumnMapping(" 63", " 63"),
                        new System.Data.Common.DataColumnMapping("N", "N"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("unico", "unico"),
                        new System.Data.Common.DataColumnMapping("hoja", "hoja"),
                        new System.Data.Common.DataColumnMapping("a1", "a1"),
                        new System.Data.Common.DataColumnMapping("a2", "a2"),
                        new System.Data.Common.DataColumnMapping("a3", "a3")})});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "[AnaNew]";
            this.sqlCommand4.CommandTimeout = 60;
            this.sqlCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand4.Connection = this.sqlConn;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@datos", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Tempranos", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@DesPar", System.Data.SqlDbType.VarChar, 25)});
            // 
            // dsAplPrueba1
            // 
            this.dsAplPrueba1.DataSetName = "dsAplPrueba";
            this.dsAplPrueba1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAplPrueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDANorma
            // 
            this.sqlDANorma.SelectCommand = this.sqlSelectCommand2;
            this.sqlDANorma.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Normas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdNorma", "IdNorma"),
                        new System.Data.Common.DataColumnMapping("Informe", "Informe"),
                        new System.Data.Common.DataColumnMapping("Normas", "Normas"),
                        new System.Data.Common.DataColumnMapping("Titulo", "Titulo"),
                        new System.Data.Common.DataColumnMapping("IdInforme", "IdInforme")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT IdNorma, Informe, Normas, Titulo, IdInforme FROM Normas WHERE (IdNorma = 1" +
    "4) ORDER BY IdNorma";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(206, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 392);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(206, 178);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(340, 200);
            this.pictureBox3.TabIndex = 78;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(206, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(616, 392);
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // sqlDATenPro
            // 
            this.sqlDATenPro.SelectCommand = this.sqlCommand5;
            this.sqlDATenPro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Analisis", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("Rev", "Rev"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("  3", "  3"),
                        new System.Data.Common.DataColumnMapping(" 3i", " 3i"),
                        new System.Data.Common.DataColumnMapping("  7", "  7"),
                        new System.Data.Common.DataColumnMapping(" 7i", " 7i"),
                        new System.Data.Common.DataColumnMapping("C", "C"),
                        new System.Data.Common.DataColumnMapping("ee1", "ee1"),
                        new System.Data.Common.DataColumnMapping("ee2", "ee2"),
                        new System.Data.Common.DataColumnMapping("Int", "Int"),
                        new System.Data.Common.DataColumnMapping("Prm", "Prm"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Con", "Con"),
                        new System.Data.Common.DataColumnMapping("200", "200"),
                        new System.Data.Common.DataColumnMapping(" 63", " 63"),
                        new System.Data.Common.DataColumnMapping("N", "N"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("unico", "unico"),
                        new System.Data.Common.DataColumnMapping("hoja", "hoja"),
                        new System.Data.Common.DataColumnMapping("a1", "a1"),
                        new System.Data.Common.DataColumnMapping("a2", "a2"),
                        new System.Data.Common.DataColumnMapping("a3", "a3")})});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = resources.GetString("sqlCommand5.CommandText");
            this.sqlCommand5.Connection = this.sqlConn;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 2, "IdPrueba"),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 2, "IdDiametro"),
            new System.Data.SqlClient.SqlParameter("@Sem", System.Data.SqlDbType.SmallInt, 2, "Sem")});
            // 
            // dsTenPro1
            // 
            this.dsTenPro1.DataSetName = "dsTenPro";
            this.dsTenPro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RepAna
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1028, 748);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crvRepAnalisis);
            this.Controls.Add(this.panel1);
            this.Name = "RepAna";
            this.Text = "RepAna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusPTC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigenCo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNoEco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalisis1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTenPro1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
        protected GraphPane myPane;
		private void RepAna_Load(object sender, System.EventArgs e)
		{
            dsOrigenCo1.OrigenCo.AddOrigenCoRow(-1, "Todos");
            dsOrigenCo1.OrigenCo.AddOrigenCoRow(1, "Lanc");
            dsOrigenCo1.OrigenCo.AddOrigenCoRow(2, "Cliente");
            dsOrigenCo1.OrigenCo.AddOrigenCoRow(3, "Obra");
            cmbOrigen.SelectedIndex = 1;
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
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			dsConcretera1.Concretera.AddConcreteraRow("Todas","Todas","%");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			cmbConcretera.SelectedIndex = 0;
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",(cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString()));
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue);
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
			dsBusNoEco1.Laboratorista.AddLaboratoristaRow(-1,"Todos");
			sqlDANoEco.Fill(dsBusNoEco1, "Laboratorista");
			cmbNoEco.SelectedIndex = 0;
			sqlDABusParTip.SelectCommand.Parameters["@IdTipo"].Value = 1;
			sqlDABusParTip.Fill(dsBusPTC1, "ParamTipos");
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsConcreto1.Clear();
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
			sqlDAConcreto.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text);;
			sqlDAConcreto.Fill(dsConcreto1, "Muestras");
			cbkPrefijo.Checked = true;
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			btnVistaPrevia.Visible = false;
			dsBusPTC1.Clear();
			sqlDABusParTip.SelectCommand.Parameters["@IdTipo"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString();
			sqlDABusParTip.Fill(dsBusPTC1, "ParamTipos");
			buscaBtn2.Visible = true;
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            int tp = int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][0].ToString());
            crvRepAnalisis.Visible = true;
            if (tp != 6 && tp != 11 && tp != 7 && tp != 12 && tp != 8 && tp != 13) 
            {
            cryRepAna1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            cryRepAna1.SetDataSource(dsAnalisis1);				
            }
            else if (tp == 8 || tp == 13)
            {
                cryRepAna11.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cryRepAna11.SetDataSource(dsAnalisis1);				       
            }
            else if (tp == 7 || tp == 12)
            {
                cryRepAna31.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cryRepAna31.SetDataSource(dsAnalisis1);
            }
            else if (tp == 6 || tp == 11)
            {
                cryRepAna71.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cryRepAna71.SetDataSource(dsAnalisis1);
            }

            double incremento = float.Parse(txtIncrem.Text);
			int dias;
			incremento = (incremento >19 || incremento < 0 ? 0.1 : incremento /100);
            dsAnalisis1.Clear();
            dsAnalisis1.Grafica1.Clear();
            dsAnalisis1.GraficaFinal.Clear();
            dsAnalisis1.ParTip.Clear();
            dsAnalisis1.TipPar.Clear();
            dsAnalisis1.Grafica11.Clear();
            dsAnalisis1.Grafica2.Clear();
			
			try
				{
                if (tp == 8 || tp == 13)
                    sqlDAAnalisis.SelectCommand.CommandText = "AnalisisNewHoras";
                else
                    sqlDAAnalisis.SelectCommand.CommandText = "AnalisisNew";
				sqlDAAnalisis.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text);
				sqlDAAnalisis.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue) ;
				sqlDAAnalisis.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
				sqlDAAnalisis.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
				sqlDAAnalisis.SelectCommand.Parameters["@ResistenciaKg"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@Agregado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@Renvenimiento"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@IdAgregado"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString() == "Normal" ? 1 : 2);
				sqlDAAnalisis.SelectCommand.Parameters["@IdPrueba"].Value = dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@NoEco"].Value = cmbNoEco.SelectedValue.ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@3i"].Value = txtA3.Text;
				sqlDAAnalisis.SelectCommand.Parameters["@7i"].Value = txtA7.Text;
				sqlDAAnalisis.SelectCommand.Parameters["@eei"].Value = txtEE.Text;
				sqlDAAnalisis.SelectCommand.Parameters["@Indice"].Value = txtResIndice.Text;
				sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 1;
				sqlDAAnalisis.SelectCommand.Parameters["@Tipo"].Value = dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][0].ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@Grado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@IdDiam"].Value = int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][2].ToString());
				sqlDAAnalisis.SelectCommand.Parameters["@Increm"].Value = incremento;
				sqlDAAnalisis.SelectCommand.Parameters["@Tempranos"].Value = int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][5].ToString());
                sqlDAAnalisis.SelectCommand.Parameters["@Despar"].Value = dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][9].ToString();
                sqlDAAnalisis.SelectCommand.Parameters["@Origen"].Value = cmbOrigen.SelectedValue;
                sqlDAAnalisis.Fill(dsAnalisis1, "Analisis1");
				sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 2;
				sqlDAAnalisis.Fill(dsAnalisis1, "Grafica1");
				sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 3;
				sqlDAAnalisis.Fill(dsAnalisis1, "GraficaFinal");

                int semestre = (dtpFin.Value.Month > 6 ? 1 : 2);
                int año = (semestre == 2 ? dtpFin.Value.Year - 1 : dtpFin.Value.Year);
                int todas = 0;
                dsTenPro1.Clear();
                sqlDATenPro.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
                sqlDATenPro.SelectCommand.Parameters["@Año"].Value = año;
                sqlDATenPro.SelectCommand.Parameters["@Sem"].Value = semestre;
                sqlDATenPro.SelectCommand.Parameters["@IdDiam"].Value = int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][2].ToString()); ;
                sqlDATenPro.SelectCommand.Parameters["@IdPrueba"].Value = dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString();
                sqlDATenPro.SelectCommand.Parameters["@Tipo"].Value = dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][0].ToString();
                sqlDATenPro.Fill(dsTenPro1, "Tendencia");

                if (dsTenPro1.Tendencia.Rows.Count == 0 && cmbConcretera.SelectedValue.ToString() == "Todas")
                {
                    sqlDATenPro.SelectCommand.Parameters["@IdConcretera"].Value = "Todas";
                    sqlDATenPro.SelectCommand.Parameters["@Año"].Value = año;
                    sqlDATenPro.SelectCommand.Parameters["@Sem"].Value = semestre;
                    sqlDATenPro.SelectCommand.Parameters["@IdDiam"].Value = int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][2].ToString()); ;
                    sqlDATenPro.SelectCommand.Parameters["@IdPrueba"].Value = dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString();
                    sqlDATenPro.SelectCommand.Parameters["@Tipo"].Value = dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][0].ToString();
                    sqlDATenPro.Fill(dsTenPro1, "Tendencia");
                }

                int Lineas = dsAnalisis1.GraficaFinal.Rows.Count;
                dias = dsAnalisis1.Grafica1.Rows.Count;
				dias = dsAnalisis1.GraficaFinal.Rows.Count;
                dias = dsAnalisis1.Analisis1.Rows.Count;
                double cuan1 = 0;
                double cuan2 = 0;
                double cuan3 = 0;
                for(int i= 0; i < dias; i++)
				{
                    cuan1 = cuan1 + (dsAnalisis1.Tables["Analisis1"].Rows[i]["  3"].ToString() != "0" ? 1 : 0) ;
                    cuan2 = cuan2 + (dsAnalisis1.Tables["Analisis1"].Rows[i]["  7"].ToString() != "0" ? 1 : 0);
                    cuan3 = cuan3 + (dsAnalisis1.Tables["Analisis1"].Rows[i][" 63"].ToString() != "0" ? 1 : 0);
                }
                if (cuan1 == 0)
                    dsAnalisis1.Tables["Analisis1"].Rows[0]["  3"] = 0.01;
                if (cuan2 == 0)
                    dsAnalisis1.Tables["Analisis1"].Rows[0]["  7"] = 0.01;
                if (cuan3 == 0)
                    dsAnalisis1.Tables["Analisis1"].Rows[0][" 63"] = 0.01;


				sqlDATitulo.SelectCommand.Parameters["@ResistenciaKg"].Value = (int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString()) == 1 ? dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1] : txtResIndice.Text);
				sqlDATitulo.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
				sqlDATitulo.SelectCommand.Parameters["@Hoja"].Value = int.Parse(dsAnalisis1.Tables["GraficaFinal"].Rows[0][24].ToString());
				sqlDATitulo.SelectCommand.Parameters["@Incre"].Value = incremento;
				sqlDATitulo.Fill(dsAnalisis1,"Titulo");


                if (tp == 8 || tp == 13)
                    sqlDAAnaNew.SelectCommand.CommandText = "AnaNewHoras";
                else
                    sqlDAAnaNew.SelectCommand.CommandText = "AnaNew";
                sqlDAAnaNew.SelectCommand.Parameters["@IdPrueba"].Value = int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString());
				sqlDAAnaNew.SelectCommand.Parameters["@Tipo"].Value = int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][0].ToString());
				sqlDAAnaNew.SelectCommand.Parameters["@IdDiam"].Value = int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][2].ToString());
				sqlDAAnaNew.SelectCommand.Parameters["@Tempranos"].Value = int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][5].ToString());
                sqlDAAnaNew.SelectCommand.Parameters["@Despar"].Value = dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][9].ToString();
				
				sqlDAAnaNew.SelectCommand.Parameters["@Datos"].Value = 4;
				sqlDAAnaNew.Fill(dsAnalisis1, "ParTip");
				sqlDAAnaNew.SelectCommand.Parameters["@Datos"].Value = 5;
				sqlDAAnaNew.Fill(dsAnalisis1, "TipPar");
				dias = dsAnalisis1.ParTip.Rows.Count;
				dias = dsAnalisis1.TipPar.Rows.Count;

                double[] s = new double[5];
                double[] n = new double[5];
                double[] x = new double[5];
                double[] y = new double[5];
                double[] xx = new double[5];
                double[] yy = new double[5];
                double[] de = new double[5];
                double[] su = new double[5];
                double[] s2 = new double[5];
                for (int i = 0; i < 5; i++)
                    s[i] = n[i] = x[i] = y[i] = xx[i] = yy[i] = de[i] = su[i] = s2[i] = 0;
                yy[0] = double.Parse(dsAnalisis1.ParTip.Rows[0]["DiA"].ToString());
                yy[1] = double.Parse(dsAnalisis1.ParTip.Rows[0]["DiB"].ToString());
                yy[2] = double.Parse(dsAnalisis1.ParTip.Rows[0]["DiC"].ToString());
                yy[3] = double.Parse(dsAnalisis1.ParTip.Rows[0]["DiE"].ToString());
                if(tp == 8 || tp == 13)
                    yy[4] = double.Parse(dsAnalisis1.ParTip.Rows[0]["DiF"].ToString());
                yy[3] = (yy[3] == 14 && (tp == 8 || tp == 13) ? 0.667 : yy[3]);
                yy[4] = (yy[4] == 28 && (tp == 8 || tp == 13) ? 0.833 : yy[4]);
                dias = dsAnalisis1.Analisis1.Rows.Count;
                for (int i = 0; i < dias; i++)
                {
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][5]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][5].ToString()) > 0)
                    {
                        s[0] += double.Parse(dsAnalisis1.Analisis1.Rows[i][5].ToString());
                        n[0]++;
                    }
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][7]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][7].ToString()) > 0)
                        {
                        s[1] += double.Parse(dsAnalisis1.Analisis1.Rows[i][7].ToString());
                        n[1]++;
                    }
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][13]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][13].ToString()) > 0)
                    {
                        s[2] += double.Parse(dsAnalisis1.Analisis1.Rows[i][13].ToString());
                        n[2]++;
                    }
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][17]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][17].ToString()) > 0)
                    {
                        s[3] += double.Parse(dsAnalisis1.Analisis1.Rows[i][17].ToString());
                        n[3]++;
                    }
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][8]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][8].ToString()) > 0)
                        {
                        s[4] += double.Parse(dsAnalisis1.Analisis1.Rows[i][8].ToString());
                        n[4]++;
                    }
                }
                for (int i = 0; i < 5; i++)
                    if (s[i] != 0)
                        xx[i] = s[i] / n[i];
                //Desviación estandar
                for (int i = 0; i < dias; i++)
                {
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][5]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][5].ToString()) > 0)
                            su[0] += Math.Pow((double.Parse(dsAnalisis1.Analisis1.Rows[i][5].ToString()) - xx[0]), 2);
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][7]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][7].ToString()) > 0)
                            su[1] += Math.Pow((double.Parse(dsAnalisis1.Analisis1.Rows[i][7].ToString()) - xx[1]), 2);
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][13]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][13].ToString()) > 0)
                            su[2] += Math.Pow((double.Parse(dsAnalisis1.Analisis1.Rows[i][13].ToString()) - xx[2]), 2);
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][17]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][17].ToString()) > 0)
                            su[3] += Math.Pow((double.Parse(dsAnalisis1.Analisis1.Rows[i][17].ToString()) - xx[3]), 2);
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][8]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][8].ToString()) > 0)
                            su[4] += Math.Pow((double.Parse(dsAnalisis1.Analisis1.Rows[i][8].ToString()) - xx[4]), 2);
                }
                for (int i = 0; i < 5; i++)
                    if (su[i] != 0)
                        de[i] = Math.Sqrt(su[i] / n[i]);


                //if ((tp == 6 || tp == 11))
                //{
                //    s[4] = n[4] = 0;
                //    yy[4] = 0;
                //    xx[4] = 0;
                //}

                double auxili, auxiliX, auxiliDE, auxiliN;
                int l;
                for (int i = 0; i < 5; i++)
                {
                    auxili = yy[i];
                    auxiliX = xx[i];
                    auxiliDE = de[i];
                    auxiliN = n[i];
                    l = i - 1;
                    while (l >= 0 && yy[l] > auxili)
                    {
                        yy[l + 1] = yy[l];
                        xx[l + 1] = xx[l];
                        de[l + 1] = de[l];
                        n[l + 1] = n[l];
                        l--;
                    }
                    yy[l + 1] = auxili;
                    xx[l + 1] = auxiliX;
                    de[l + 1] = auxiliDE;
                    n[l + 1] = auxiliN;
                }
                
                // Establece el valor actual de parameter1 en el subinforme en 10 
				float res = float.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString()) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
				res = (int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString()) == 1 ? res : float.Parse(txtResIndice.Text));
                double ressis = double.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString());
                ressis = (ressis >= 400 ? 800 : 500);
                ressis = ressis * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                float ressis1 = float.Parse(ressis.ToString());


                memGraphics.CreateDoubleBuffer(this.CreateGraphics(),
this.ClientRectangle.Width, this.ClientRectangle.Height);

                myPane = new GraphPane(new Rectangle(10, 10, 10, 10),
                    "", "Edad en días", "Resistencia");
                SetSize();
                string acotacion = "";
                double acota = double.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString());
                if (cmbUnidad.SelectedValue.ToString() == "2")
                    acotacion = acota.ToString("####.00");
                else
                    acotacion = acota.ToString("####");
                float F16 = 0.6667F;
                CurveItem curve;
                ArrowItem arrow = new ArrowItem(Color.Red, 0, 3, 0, 3, ressis1);
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 0F;
                myPane.ArrowList.Add(arrow);
                arrow = new ArrowItem(Color.Red, 0, F16, 0, F16, ressis1);
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 0F;
                myPane.ArrowList.Add(arrow);
                F16 = 0.8333F;
                arrow = new ArrowItem(Color.Red, 0, F16, 0, F16, ressis1);
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 0F;
                myPane.ArrowList.Add(arrow);
                arrow = new ArrowItem(Color.Red, 0, 7, 0, 7, ressis1);
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 0F;
                myPane.ArrowList.Add(arrow);
                arrow = new ArrowItem(Color.Red, 0, 14, 0, 14, ressis1);
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 0F;
                myPane.ArrowList.Add(arrow);
                arrow = new ArrowItem(Color.Red, 0, 28, 0, 28, ressis1);
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 0F;
                myPane.ArrowList.Add(arrow);
                arrow = new ArrowItem(Color.Gray, 0, 63, 0, 63, ressis1);
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 0F;
                myPane.ArrowList.Add(arrow);
                float inicio = 0.5F;
                for (float ww = 100; ww < ressis1; ww = ww + 100)
                {
                    arrow = new ArrowItem(Color.Gray, 0, inicio, ww, 100, ww);
                    arrow.CoordinateFrame = CoordType.AxisXYScale;
                    arrow.PenWidth = 0F;
                    myPane.ArrowList.Add(arrow);
                }


                curve = myPane.AddCurve(acotacion, yy, xx, Color.DarkBlue, SymbolType.Circle);
                curve.Line.Width = 2.0F;
                curve.Symbol.Fill = new Fill(Color.DarkBlue);
                curve.Symbol.Size = 12;
                for (int jj = 4; jj >= 0; jj--)
                    if (xx[jj] <= 0.01)
                        curve.Points.Remove(jj);

                for (int i = 0; i < 5; i++)
                {
                    su[i] = s2[i] = 0;
                    su[i] = xx[i] + de[i];
                    s2[i] = xx[i] + de[i] + de[i];
                }
                curve = myPane.AddCurve(acotacion, yy, su, Color.DarkBlue, SymbolType.Empty);
                curve.Line.Width = 1.75F;
                curve.Line.Style = new Single();
                curve.Symbol.Fill = new Fill(Color.DarkBlue);
                curve.Symbol.Size = 1;
                for (int jj = 4; jj >= 0; jj--)
                    if (su[jj] <= 0.01 || (jj == 4 && n[jj] < 10))
                        curve.Points.Remove(jj);
                curve = myPane.AddCurve(acotacion, yy, s2, Color.Green, SymbolType.Empty);
                curve.Line.Width = 1.0F;
                curve.Line.Style = new DashStyle();
                curve.Symbol.Fill = new Fill(Color.AliceBlue);
                curve.Symbol.Size = 1;
                for (int jj = 4; jj >= 0; jj--)
                    if (s2[jj] <= 0.01 || (jj == 4 && n[jj] < 10))
                        curve.Points.Remove(jj);
                for (int i = 0; i < 5; i++)
                {
                    su[i] = s2[i] = 0;
                    su[i] = xx[i] - de[i];
                    s2[i] = xx[i] - de[i] - de[i];
                }
                curve = myPane.AddCurve(acotacion, yy, su, Color.DarkBlue, SymbolType.Empty);
                curve.Line.Width = 1.75F;
                curve.Line.Style = new Single();
                curve.Symbol.Fill = new Fill(Color.DarkBlue);
                curve.Symbol.Size = 1;
                for (int jj = 4; jj >= 0; jj--)
                    if (su[jj] <= 0.01 || (jj == 4 && n[jj] < 10))
                        curve.Points.Remove(jj);
                curve = myPane.AddCurve(acotacion, yy, s2, Color.Green, SymbolType.Empty);
                curve.Line.Width = 1.0F;
                curve.Line.Style = new DashStyle();
                curve.Symbol.Fill = new Fill(Color.AliceBlue);
                curve.Symbol.Size = 1;
                for (int jj = 4; jj >= 0; jj--)
                    if (s2[jj] <= 0.01 || (jj == 4 && n[jj] < 10))
                        curve.Points.Remove(jj);


                Color[] colorado = { Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.DarkGreen, Color.DarkKhaki, Color.DarkMagenta, Color.DarkOliveGreen, Color.DarkOrange };
                for (int k = 0; k < 5; k++)
                    x[k] = y[k] = 0;

                if (dsTenPro1.Tendencia.Rows.Count == 0) 
                for (int j = 0; j < 9; j++)
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
                else
                    for (int j = 0; j < dsTenPro1.Tendencia.Rows.Count; j++)
                    {
                        x[0] = 1;
                        x[1] = 100;
                        y[0] = double.Parse(dsTenPro1.Tendencia.Rows[j]["U"].ToString()) * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                        y[1] = double.Parse(dsTenPro1.Tendencia.Rows[j]["C"].ToString()) * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());

                        curve = myPane.AddCurve(dsTenPro1.Tendencia.Rows[j]["ResKg"].ToString(), x, y, colorado[j], SymbolType.Diamond);
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
                myPane.XAxis.Min = 0.5; //cambiar
                myPane.XAxis.Max = 100;

                //				MessageBox.Show(myPane.XAxis.ScaleFormat.ToString()); //esta buena
                myPane.XAxis.Type = AxisType.Log;
                myPane.XAxis.PickLogScale();

                //                myPane.XAxis.ScaleFormat = "{0:000.0}";
                myPane.XAxis.TitleFontSpec.Family = "Times New Roman";
                myPane.XAxis.TitleFontSpec.Size = 11;
                myPane.XAxis.IsShowTitle = false;
                myPane.XAxis.ScaleFontSpec.FontColor = Color.White;
                myPane.XAxis.IsMinorTic = false;

                myPane.YAxis.IsInsideTic = true;
                myPane.YAxis.IsMinorInsideTic = true;
                myPane.YAxis.IsShowGrid = true;
                myPane.YAxis.ScaleFontSpec.Angle = 90;
                myPane.YAxis.Min = 0;
                myPane.YAxis.Max = ressis;
                myPane.YAxis.TitleFontSpec.Family = "Times New Roman";
                myPane.YAxis.ScaleFontSpec.Family = "Times New Roman";
                myPane.Legend.IsVisible = true;
                myPane.Legend.Location = LegendLoc.Bottom;
                myPane.Legend.FontSpec.Size = 7;
                myPane.PaneFill = new Fill(Color.White, Color.White, 2F);
                myPane.AxisChange(this.CreateGraphics());

                pictureBox1.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
                pictureBox1.BorderStyle = BorderStyle.None;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] arrImage = ms.GetBuffer();
                ms.Close();

                myPane.Image.Dispose();
                pictureBox1.Image.Dispose();
                dsAnalisis1.Grafica.AddGraficaRow("1", arrImage);

                float[] gaus;
                gaus = new float[22];
                double[] ee;
                ee = new double[22];
                double[] nuevoee;
                nuevoee = new double[22];
                for (int i = 0; i <= 21; i++)
                {
                    nuevoee[i] = 0;
                    ee[i] = 0;
                }

                myPane = new GraphPane(new Rectangle(10, 10, 10, 10), " ", "", "");
                SetSize();

                double incdec = 0.1;
                for (int j = 0; j < Lineas; j++)
                {
                    for (int i = 0; i <= 21; i++)
                    {
                        nuevoee[i] = double.Parse(dsAnalisis1.Tables["GraficaFinal"].Rows[j][i + 1].ToString());
                        ee[i] = res * (incdec * i);
                    }
                    if (j == 0)
                    {
                        curve = myPane.AddCurve(dsAnalisis1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkSeaGreen, SymbolType.Square);
                        curve.Line.Width = 2.5F;
                        curve.Symbol.Fill = new Fill(Color.DarkSeaGreen);
                    }
                    if (j == 1)
                    {
                        curve = myPane.AddCurve(dsAnalisis1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkCyan, SymbolType.Diamond);
                        curve.Line.Width = 2.5F;
                        curve.Symbol.Fill = new Fill(Color.DarkCyan);
                    }
                    if (j == 2)
                    {
                        curve = myPane.AddCurve(dsAnalisis1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkSlateBlue, SymbolType.Circle);
                        curve.Line.Width = 3.5F;
                        curve.Symbol.Fill = new Fill(Color.DarkSlateBlue);
                    }
                    if (j == 3)
                    {
                        curve = myPane.AddCurve(dsAnalisis1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.Brown, SymbolType.TriangleDown);
                        curve.Line.Width = 2.5F;
                        curve.Symbol.Fill = new Fill(Color.Brown);
                    }
                    if (j == 4)
                    {
                        curve = myPane.AddCurve(dsAnalisis1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkMagenta, SymbolType.Triangle);
                        curve.Line.Width = 2.5F;
                        curve.Symbol.Fill = new Fill(Color.DarkMagenta);
                    }
                }

                myPane.XAxis.IsMinorInsideTic = true;
                myPane.XAxis.TicSize = float.Parse((res * 0.05).ToString());
                myPane.XAxis.IsShowGrid = true;
                myPane.XAxis.IsInsideTic = true;
                myPane.XAxis.ScaleFontSpec.Angle = 0;
                myPane.XAxis.NumDec = 0;
                myPane.XAxis.Step = float.Parse((res * 0.05).ToString());
                myPane.XAxis.ScaleFontSpec.Size = 10;
                myPane.XAxis.Min = res * 0.1; //cambiar
                myPane.XAxis.Max = res * 22 * 0.1;
                myPane.XAxis.Type = AxisType.Linear;
                myPane.XAxis.StepAuto = true;
                //                myPane1.XAxis.MinorStepAuto = true;
                myPane.XAxis.TitleFontSpec.Family = "Times New Roman";
                myPane.XAxis.TitleFontSpec.Size = 12;
                myPane.XAxis.IsShowTitle = false;
                myPane.XAxis.ScaleFontSpec.FontColor = Color.Black;
                myPane.XAxis.IsMinorTic = true;

                myPane.YAxis.IsMinorInsideTic = true;
                myPane.XAxis.IsInsideTic = true;
                myPane.YAxis.IsShowGrid = true;
                myPane.YAxis.ScaleFontSpec.Angle = 90;
                myPane.YAxis.ScaleFontSpec.Size = 10;
                myPane.YAxis.Min = 0;
                myPane.YAxis.Max = ressis;
                myPane.YAxis.TicSize = 10;
                myPane.YAxis.TitleFontSpec.Family = "Times New Roman";
                myPane.YAxis.ScaleFontSpec.Family = "Times New Roman";
                myPane.Legend.IsVisible = true;
                myPane.Legend.Location = LegendLoc.InsideTopRight;
                myPane.Legend.FontSpec.Size = 10;
                myPane.PaneFill = new Fill(Color.White, Color.White, 2F);
                myPane.AxisChange(this.CreateGraphics());

                pictureBox2.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
                pictureBox2.BorderStyle = BorderStyle.None;
                MemoryStream ms1 = new MemoryStream();
                pictureBox2.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] arrImage1 = ms1.GetBuffer();
                ms1.Close();

                myPane.Image.Dispose();
                pictureBox2.Image.Dispose();
                dsAnalisis1.Grafica2.AddGrafica2Row("1", arrImage1);

                incdec = 0.1;
                double[] eex;
                eex = new double[12];
                double[] neey;
                neey = new double[12];
                int hoja = int.Parse(dsAnalisis1.Grafica1.Rows[0][0].ToString());
                int hoaa = hoja;
                int ij = 0;
                myPane = new GraphPane(new Rectangle(10, 10, 10, 10), " ", "", "");
                SetSize();
                for (int m = 0; m < dsAnalisis1.Grafica1.Rows.Count; m++)
                {
                    if (hoaa != int.Parse(dsAnalisis1.Grafica1.Rows[m][0].ToString()) && ij >= Lineas)
                    {
                        guardagrafica(res, hoaa);
                        myPane = new GraphPane(new Rectangle(10, 10, 10, 10),
                            " ", "", "");
                        SetSize();
                        ij = 0;
                        hoaa = int.Parse(dsAnalisis1.Grafica1.Rows[m][0].ToString());
                    }
                    for (int i = 0; i <= 11; i++)
                    {
                        neey[i] = double.Parse(dsAnalisis1.Tables["Grafica1"].Rows[m][i + 2].ToString());
                        eex[i] = double.Parse(dsAnalisis1.titulo.Rows[0][i + 2].ToString());
                    }
                    if (ij == 0)
                    {
                        curve = myPane.AddCurve(dsAnalisis1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.DarkSeaGreen, SymbolType.Square);
                        curve.Symbol.Fill = new Fill(Color.DarkSeaGreen);
                        curve.Line.Width = 2.5F;
                    }
                    if (ij == 1)
                    {
                        curve = myPane.AddCurve(dsAnalisis1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.DarkCyan, SymbolType.Diamond);
                        curve.Symbol.Fill = new Fill(Color.DarkCyan);
                        curve.Line.Width = 2.5F;
                    }
                    if (ij == 2)
                    {
                        curve = myPane.AddCurve(dsAnalisis1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.DarkSlateBlue, SymbolType.Circle);
                        curve.Line.Width = 3.5F;
                        curve.Symbol.Fill = new Fill(Color.DarkSlateBlue);
                    }
                    if (ij == 3)
                    {
                        curve = myPane.AddCurve(dsAnalisis1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.Brown, SymbolType.TriangleDown);
                        curve.Symbol.Fill = new Fill(Color.Brown);
                        curve.Line.Width = 2.5F;
                    }
                    if (ij == 4)
                    {
                        curve = myPane.AddCurve(dsAnalisis1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.DarkMagenta, SymbolType.TriangleDown);
                        curve.Symbol.Fill = new Fill(Color.DarkMagenta);
                        curve.Line.Width = 2.5F;
                    }
                    ij++;
                }
                guardagrafica(res, hoaa);

                if (tp != 6 && tp != 11 && tp != 7 && tp != 12 && tp != 8 && tp != 13) 
            {
                cryRepAna1.SetParameterValue("@Unidad", cmbUnidad.Text);
				cryRepAna1.SetParameterValue("@Edad", (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Normal" ? 1 : (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Rápido" ? 2 : 4)));
				cryRepAna1.SetParameterValue("@Res", float.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString()) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
				cryRepAna1.SetParameterValue("@Tip", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString());
				cryRepAna1.SetParameterValue("@Tma", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString());
				cryRepAna1.SetParameterValue("@Rev", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString());
				cryRepAna1.SetParameterValue("@Tag", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString());
				cryRepAna1.SetParameterValue("@Con", cmbConcretera.Text);
				cryRepAna1.SetParameterValue("@Pla", cmbPlanta.Text);
				cryRepAna1.SetParameterValue("@Lab", cmbNoEco.Text);
				cryRepAna1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
				cryRepAna1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
				cryRepAna1.SetParameterValue("@Obr", txtIdobra.Text);
				cryRepAna1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
				cryRepAna1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
				cryRepAna1.SetParameterValue("@reskg", res.ToString(), "Gauss");
				cryRepAna1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
				cryRepAna1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
				cryRepAna1.SetParameterValue("@Prueba", dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][8].ToString());
				cryRepAna1.SetParameterValue("@Grado", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString());
				cryRepAna1.SetParameterValue("@Indice", (int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString()) == 1 ? res.ToString() : txtResIndice.Text ));
				cryRepAna1.SetParameterValue("@Figura", dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][3].ToString()+ " " + dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][4].ToString());
				cryRepAna1.SetParameterValue("@Tempranos", true);
				cryRepAna1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                //cryRepAna1.SetParameterValue("T2018", dsTenPro1.Tendencia.Rows.Count, "Gauss");
                //cryRepAna1.SetParameterValue("Concretera", cmbConcretera.Text, "Gauss");
				crvRepAnalisis.ReportSource = cryRepAna1;
            }
            else if(tp == 7 || tp == 12)
            {
                cryRepAna31.SetParameterValue("@Unidad", cmbUnidad.Text);
//				cryRepAna31.SetParameterValue("@Edad", (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Normal" ? 1 : (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Rápido" ? 2 : 4)));
				cryRepAna31.SetParameterValue("@Res", float.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString()) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
				cryRepAna31.SetParameterValue("@Tip", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString());
				cryRepAna31.SetParameterValue("@Tma", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString());
				cryRepAna31.SetParameterValue("@Rev", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString());
				cryRepAna31.SetParameterValue("@Tag", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString());
				cryRepAna31.SetParameterValue("@Con", cmbConcretera.Text);
				cryRepAna31.SetParameterValue("@Pla", cmbPlanta.Text);
				cryRepAna31.SetParameterValue("@Lab", cmbNoEco.Text);
				cryRepAna31.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
				cryRepAna31.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
				cryRepAna31.SetParameterValue("@Obr", txtIdobra.Text);
				cryRepAna31.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
				cryRepAna31.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
				cryRepAna31.SetParameterValue("@reskg", res.ToString(), "Gauss");
				cryRepAna31.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
				cryRepAna31.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
				cryRepAna31.SetParameterValue("@Prueba", dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][8].ToString());
				cryRepAna31.SetParameterValue("@Grado", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString());
				cryRepAna31.SetParameterValue("@Indice", (int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString()) == 1 ? res.ToString() : txtResIndice.Text ));
				cryRepAna31.SetParameterValue("@Figura", dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][3].ToString()+ " " + dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][4].ToString());
//				cryRepAna31.SetParameterValue("@Tempranos", true);
//				cryRepAna31.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                cryRepAna31.SetParameterValue("T2018", dsTenPro1.Tendencia.Rows.Count, "Gauss");
                cryRepAna31.SetParameterValue("Concretera", (cmbConcretera.Text == "Todas" ? " " : cmbConcretera.Text), "Gauss");
                cryRepAna31.SetParameterValue("Año", año, "Gauss");
                cryRepAna31.SetParameterValue("Semestre", semestre, "Gauss");

                    crvRepAnalisis.ReportSource = cryRepAna31;
            }
            else if (tp == 8 || tp == 13)
            {
                cryRepAna11.SetParameterValue("@Unidad", cmbUnidad.Text);
                cryRepAna11.SetParameterValue("@Edad", (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Normal" ? 1 : (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Rápido" ? 2 : 4)));
                cryRepAna11.SetParameterValue("@Res", float.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString()) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                cryRepAna11.SetParameterValue("@Tip", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString());
                cryRepAna11.SetParameterValue("@Tma", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString());
                cryRepAna11.SetParameterValue("@Rev", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString());
                cryRepAna11.SetParameterValue("@Tag", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString());
                cryRepAna11.SetParameterValue("@Con", cmbConcretera.Text);
                cryRepAna11.SetParameterValue("@Pla", cmbPlanta.Text);
                cryRepAna11.SetParameterValue("@Lab", cmbNoEco.Text);
                cryRepAna11.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                cryRepAna11.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                cryRepAna11.SetParameterValue("@Obr", txtIdobra.Text);
                cryRepAna11.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                cryRepAna11.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
                cryRepAna11.SetParameterValue("@reskg", res.ToString(), "Gauss");
                cryRepAna11.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
                cryRepAna11.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                cryRepAna11.SetParameterValue("@Prueba", dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][8].ToString());
                cryRepAna11.SetParameterValue("@Grado", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString());
                cryRepAna11.SetParameterValue("@Indice", (int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString()) == 1 ? res.ToString() : txtResIndice.Text));
                cryRepAna11.SetParameterValue("@Figura", dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][3].ToString() + " " + dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][4].ToString());
                cryRepAna11.SetParameterValue("@Tempranos", true);
                cryRepAna11.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                cryRepAna11.SetParameterValue("T2018", dsTenPro1.Tendencia.Rows.Count, "Gauss");
                cryRepAna11.SetParameterValue("Concretera", (cmbConcretera.Text == "Todas" ? " " : cmbConcretera.Text), "Gauss");
                cryRepAna11.SetParameterValue("Año", año, "Gauss");
                cryRepAna11.SetParameterValue("Semestre", semestre, "Gauss");
                crvRepAnalisis.ReportSource = cryRepAna11;
            }
            else if (tp == 6 || tp == 11)
            {
                cryRepAna71.SetParameterValue("@Unidad", cmbUnidad.Text);
                cryRepAna71.SetParameterValue("@Edad", (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Normal" ? 1 : (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Rápido" ? 2 : 4)));
                cryRepAna71.SetParameterValue("@Res", float.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString()) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                cryRepAna71.SetParameterValue("@Tip", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString());
                cryRepAna71.SetParameterValue("@Tma", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString());
                cryRepAna71.SetParameterValue("@Rev", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString());
                cryRepAna71.SetParameterValue("@Tag", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString());
                cryRepAna71.SetParameterValue("@Con", cmbConcretera.Text);
                cryRepAna71.SetParameterValue("@Pla", cmbPlanta.Text);
                cryRepAna71.SetParameterValue("@Lab", cmbNoEco.Text);
                cryRepAna71.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                cryRepAna71.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                cryRepAna71.SetParameterValue("@Obr", txtIdobra.Text);
                cryRepAna71.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                cryRepAna71.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
                cryRepAna71.SetParameterValue("@reskg", res.ToString(), "Gauss");
                cryRepAna71.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
                cryRepAna71.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                cryRepAna71.SetParameterValue("@Prueba", dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][8].ToString());
                cryRepAna71.SetParameterValue("@Grado", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString());
                cryRepAna71.SetParameterValue("@Indice", (int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString()) == 1 ? res.ToString() : txtResIndice.Text));
                cryRepAna71.SetParameterValue("@Figura", dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][3].ToString() + " " + dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][4].ToString());
                cryRepAna71.SetParameterValue("@Tempranos", true);
                cryRepAna71.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                cryRepAna71.SetParameterValue("T2018", dsTenPro1.Tendencia.Rows.Count, "Gauss");
                cryRepAna71.SetParameterValue("Concretera", (cmbConcretera.Text == "Todas" ? " " : cmbConcretera.Text), "Gauss");
                cryRepAna71.SetParameterValue("Año", año, "Gauss");
                cryRepAna71.SetParameterValue("Semestre", semestre, "Gauss");
                crvRepAnalisis.ReportSource = cryRepAna71;
            }

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}
		}



		private void cbkPrefijo_CheckedChanged(object sender, System.EventArgs e)
		{
		if (cbkPrefijo.Checked == false)
			txtIdobra.Text = txtIdobra.Text.Substring(0,3)+"%";
		else
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
		}

		private void sqlDAConcretera_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
		{
		
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void cmbConcretera_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cmbPlanta.Enabled = true;
		}

		private void buscaBtn2_Click(object sender, System.EventArgs e)
		{
			btnVistaPrevia.Visible = true;
			if(int.Parse(dsBusPTC1.Tables["ParamTipos"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString()) ==  1)
			{
				lblIndice.Visible = false;
				txtResIndice.Visible = false;
			}
			else
			{
				lblIndice.Visible = true;
				txtResIndice.Visible = true;
			}
		}

        private void btnVistaPrevia_Load(object sender, EventArgs e)
        {

        }

        private void SetSize()
        {
            Rectangle paneRect = this.ClientRectangle;
            paneRect.Inflate(-2, -1);
            this.myPane.PaneRect = paneRect;
        }

        private void guardagrafica(double res, int hoja)
        {

            myPane.XAxis.IsMinorInsideTic = true;
            myPane.XAxis.TicSize = float.Parse((res * 0.1).ToString());
            myPane.XAxis.IsShowGrid = true;
            myPane.XAxis.IsInsideTic = true;
            myPane.XAxis.ScaleFontSpec.Angle = 0;
            myPane.XAxis.NumDec = 0;
            myPane.XAxis.Step = float.Parse((res * 0.1).ToString());
            myPane.XAxis.ScaleFontSpec.Size = 10;
            myPane.XAxis.Min = res * 0.5; //cambiar
            myPane.XAxis.Max = res * 1.6;
            myPane.XAxis.Type = AxisType.Linear;
            myPane.XAxis.StepAuto = true;
            //                myPane1.XAxis.MinorStepAuto = true;
            myPane.XAxis.TitleFontSpec.Family = "Times New Roman";
            myPane.XAxis.TitleFontSpec.Size = 8;
            myPane.XAxis.IsShowTitle = false;
            myPane.XAxis.ScaleFontSpec.FontColor = Color.Black;
            myPane.XAxis.IsMinorTic = true;

            myPane.YAxis.IsMinorInsideTic = true;
            myPane.XAxis.IsInsideTic = true;
            myPane.YAxis.IsShowGrid = true;
            myPane.YAxis.ScaleFontSpec.Angle = 90;
            myPane.YAxis.ScaleFontSpec.Size = 8;
            myPane.YAxis.Min = 0;
            myPane.YAxis.Max = 30;
            myPane.YAxis.TicSize = 10;
            myPane.YAxis.TitleFontSpec.Family = "Times New Roman";
            myPane.YAxis.ScaleFontSpec.Family = "Times New Roman";
            myPane.Legend.IsVisible = true;
            myPane.Legend.Location = LegendLoc.InsideTopRight;
            myPane.Legend.FontSpec.Size = 8;
            myPane.PaneFill = new Fill(Color.White, Color.White, 2F);
            myPane.AxisChange(this.CreateGraphics());

            pictureBox3.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
            pictureBox3.BorderStyle = BorderStyle.None;
            MemoryStream ms1 = new MemoryStream();
            pictureBox3.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] arrImage1 = ms1.GetBuffer();
            ms1.Close();

            myPane.Image.Dispose();
            pictureBox3.Image.Dispose();
            dsAnalisis1.Grafica11.AddGrafica11Row(hoja, arrImage1);

        }    


	}
}
