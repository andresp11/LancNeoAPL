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
	/// Descripción breve de RepAnalisis.
	/// </summary>
	public class RepAnalisis : System.Windows.Forms.Form
	{
		private LancNeo.dsTipoPrueba dsTipoPrueba1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPLanta;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrueba;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsUnidad dsUnidad1;
		private LancNeo.dsPlanta dsPlanta1;
		private LancNeo.dsConcretera dsConcretera1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
//		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
//		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.ComboBox cmbPrueba;
		private System.Windows.Forms.Label label7;
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
		private LancNeo.CryRepAnalisis cryRepAnalisis1;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private LancNeo.CryRepAnalisisT cryRepAnalisisT1;
		private System.Windows.Forms.Label lblIndice;
		private System.Windows.Forms.TextBox txtResIndice;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAnalisis63;
		private System.Data.SqlClient.SqlCommand sqlCommand3;
		private System.Windows.Forms.Label label13;
		private LancNeo.dsDiametro dsDiametro1;
		private System.Data.SqlClient.SqlDataAdapter sqlDADiametro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
		private System.Windows.Forms.ComboBox cmbIdDiam;
		private System.Windows.Forms.CheckBox cbkFormato;
		private LancNeo.CryRepAnalisisM cryRepAnalisisM1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtIncrem;
		private System.Windows.Forms.GroupBox gBoxEsp;
		private System.Windows.Forms.RadioButton rButNormal;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.CheckBox chbLeyenda;
		private System.Windows.Forms.CheckBox chbLab;
        private ComboBox cmbEdif;
        private Label label15;
        private SqlCommand sqlSelectCommand8;
        private SqlDataAdapter sqlDAEdif;
        private dsEdif dsEdif1;
        private CheckBox chbLanc200;
        private PictureBox pictureBox1;
        private DBGraphics memGraphics;
        private PictureBox pictureBox2;
        private DBGraphics memGraphics1;
        private PictureBox pictureBox3;
        private dsTenPro dsTenPro1;
        private SqlDataAdapter sqlDATenPro;
        private SqlCommand sqlCommand4;
        private ComboBox cmbOrigen;
        private Label label16;
        private dsOrigenCo dsOrigenCo1;

        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public RepAnalisis()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
            memGraphics = new DBGraphics();
            memGraphics1 = new DBGraphics();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepAnalisis));
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPLanta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.dsPlanta1 = new LancNeo.dsPlanta();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsConcreto1 = new LancNeo.dsConcreto();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.dsOrigenCo1 = new LancNeo.dsOrigenCo();
            this.label16 = new System.Windows.Forms.Label();
            this.chbLanc200 = new System.Windows.Forms.CheckBox();
            this.cmbEdif = new System.Windows.Forms.ComboBox();
            this.dsEdif1 = new LancNeo.dsEdif();
            this.label15 = new System.Windows.Forms.Label();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.gBoxEsp = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rButNormal = new System.Windows.Forms.RadioButton();
            this.txtIncrem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbkFormato = new System.Windows.Forms.CheckBox();
            this.cmbIdDiam = new System.Windows.Forms.ComboBox();
            this.dsDiametro1 = new LancNeo.dsDiametro();
            this.txtEE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.sqlDATitulo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.cryRepAnalisis1 = new LancNeo.CryRepAnalisis();
            this.cryRepAnalisisT1 = new LancNeo.CryRepAnalisisT();
            this.sqlDAAnalisis63 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.cryRepAnalisisM1 = new LancNeo.CryRepAnalisisM();
            this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAEdif = new System.Data.SqlClient.SqlDataAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dsAnalisis1 = new LancNeo.dsAnalisis();
            this.dsTenPro1 = new LancNeo.dsTenPro();
            this.sqlDATenPro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigenCo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEdif1)).BeginInit();
            this.gBoxEsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNoEco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalisis1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTenPro1)).BeginInit();
            this.SuspendLayout();
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
            this.sqlSelectCommand6.CommandText = "SELECT IdConcretera, IdPlanta, Planta FROM Planta WHERE (IdConcretera LIKE @IdCon" +
    "cretera)";
            this.sqlSelectCommand6.Connection = this.sqlConn;
            this.sqlSelectCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera")});
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
            this.panel1.Controls.Add(this.cmbOrigen);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.chbLanc200);
            this.panel1.Controls.Add(this.cmbEdif);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.gBoxEsp);
            this.panel1.Controls.Add(this.txtIncrem);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cbkFormato);
            this.panel1.Controls.Add(this.cmbIdDiam);
            this.panel1.Controls.Add(this.txtEE);
            this.panel1.Controls.Add(this.label13);
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
            this.panel1.Controls.Add(this.cmbPrueba);
            this.panel1.Controls.Add(this.label7);
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
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 137);
            this.panel1.TabIndex = 10;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(573, 16);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(50, 46);
            this.btnVistaPrevia.TabIndex = 37;
            this.btnVistaPrevia.Visible = false;
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
            // cmbOrigen
            // 
            this.cmbOrigen.DataSource = this.dsOrigenCo1;
            this.cmbOrigen.DisplayMember = "OrigenCo.Origen";
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(733, 106);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(79, 21);
            this.cmbOrigen.TabIndex = 53;
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
            this.label16.Location = new System.Drawing.Point(695, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Origen:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chbLanc200
            // 
            this.chbLanc200.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLanc200.ForeColor = System.Drawing.Color.White;
            this.chbLanc200.Location = new System.Drawing.Point(114, 108);
            this.chbLanc200.Name = "chbLanc200";
            this.chbLanc200.Size = new System.Drawing.Size(89, 24);
            this.chbLanc200.TabIndex = 51;
            this.chbLanc200.Text = "LANC 200";
            this.chbLanc200.CheckedChanged += new System.EventHandler(this.chbLanc200_CheckedChanged);
            // 
            // cmbEdif
            // 
            this.cmbEdif.DataSource = this.dsEdif1;
            this.cmbEdif.DisplayMember = "Edif.Edif1";
            this.cmbEdif.FormattingEnabled = true;
            this.cmbEdif.Location = new System.Drawing.Point(521, 106);
            this.cmbEdif.Name = "cmbEdif";
            this.cmbEdif.Size = new System.Drawing.Size(121, 21);
            this.cmbEdif.TabIndex = 50;
            this.cmbEdif.ValueMember = "Edif.Edif";
            // 
            // dsEdif1
            // 
            this.dsEdif1.DataSetName = "dsEdif";
            this.dsEdif1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(491, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Edif:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.ForeColor = System.Drawing.Color.White;
            this.chbLab.Location = new System.Drawing.Point(8, 80);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 24);
            this.chbLab.TabIndex = 48;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.Checked = true;
            this.chbLeyenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLeyenda.ForeColor = System.Drawing.Color.White;
            this.chbLeyenda.Location = new System.Drawing.Point(7, 108);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(68, 24);
            this.chbLeyenda.TabIndex = 44;
            this.chbLeyenda.Text = "Leyenda";
            // 
            // gBoxEsp
            // 
            this.gBoxEsp.Controls.Add(this.radioButton1);
            this.gBoxEsp.Controls.Add(this.rButNormal);
            this.gBoxEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxEsp.ForeColor = System.Drawing.Color.White;
            this.gBoxEsp.Location = new System.Drawing.Point(659, 4);
            this.gBoxEsp.Name = "gBoxEsp";
            this.gBoxEsp.Size = new System.Drawing.Size(110, 72);
            this.gBoxEsp.TabIndex = 43;
            this.gBoxEsp.TabStop = false;
            this.gBoxEsp.Text = "Tempranos";
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(8, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton1.Size = new System.Drawing.Size(100, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "7, 14, Tipo";
            // 
            // rButNormal
            // 
            this.rButNormal.Checked = true;
            this.rButNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButNormal.ForeColor = System.Drawing.Color.White;
            this.rButNormal.Location = new System.Drawing.Point(8, 20);
            this.rButNormal.Name = "rButNormal";
            this.rButNormal.Size = new System.Drawing.Size(100, 24);
            this.rButNormal.TabIndex = 0;
            this.rButNormal.TabStop = true;
            this.rButNormal.Text = "3, 7, Tipo";
            // 
            // txtIncrem
            // 
            this.txtIncrem.Location = new System.Drawing.Point(921, 29);
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
            this.label14.Location = new System.Drawing.Point(838, 33);
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
            // cmbIdDiam
            // 
            this.cmbIdDiam.DataSource = this.dsDiametro1;
            this.cmbIdDiam.DisplayMember = "Diametro.Figura";
            this.cmbIdDiam.Location = new System.Drawing.Point(293, 106);
            this.cmbIdDiam.Name = "cmbIdDiam";
            this.cmbIdDiam.Size = new System.Drawing.Size(120, 21);
            this.cmbIdDiam.TabIndex = 39;
            this.cmbIdDiam.ValueMember = "IdDiam";
            // 
            // dsDiametro1
            // 
            this.dsDiametro1.DataSetName = "dsDiametro";
            this.dsDiametro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDiametro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEE
            // 
            this.txtEE.Location = new System.Drawing.Point(784, 80);
            this.txtEE.MaxLength = 5;
            this.txtEE.Name = "txtEE";
            this.txtEE.Size = new System.Drawing.Size(28, 20);
            this.txtEE.TabIndex = 29;
            this.txtEE.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(209, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "F. geométrica:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.ForeColor = System.Drawing.Color.White;
            this.cbkPrefijo.Location = new System.Drawing.Point(8, 25);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 35;
            this.cbkPrefijo.Text = "No prefijo";
            this.cbkPrefijo.CheckedChanged += new System.EventHandler(this.cbkPrefijo_CheckedChanged);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(881, 9);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(39, 13);
            this.lblIndice.TabIndex = 34;
            this.lblIndice.Text = "Indice:";
            this.lblIndice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIndice.Visible = false;
            // 
            // txtResIndice
            // 
            this.txtResIndice.Location = new System.Drawing.Point(921, 5);
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
            this.cmbNoEco.Location = new System.Drawing.Point(185, 52);
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
            this.label10.Location = new System.Drawing.Point(560, 84);
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
            this.label11.Location = new System.Drawing.Point(438, 83);
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
            this.label12.Location = new System.Drawing.Point(694, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Ajuste Edad Esp:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtA7
            // 
            this.txtA7.Location = new System.Drawing.Point(640, 79);
            this.txtA7.MaxLength = 5;
            this.txtA7.Name = "txtA7";
            this.txtA7.Size = new System.Drawing.Size(28, 20);
            this.txtA7.TabIndex = 28;
            this.txtA7.Text = "0";
            // 
            // txtA3
            // 
            this.txtA3.Location = new System.Drawing.Point(521, 80);
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
            this.label6.Location = new System.Drawing.Point(139, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "NoEco:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(434, 33);
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
            this.label8.Location = new System.Drawing.Point(410, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Concretera:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(293, 80);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(120, 21);
            this.cmbPrueba.TabIndex = 11;
            this.cmbPrueba.ValueMember = "IdPrueba";
            this.cmbPrueba.SelectedIndexChanged += new System.EventHandler(this.cmbPrueba_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(242, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Prueba:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.label5.Location = new System.Drawing.Point(369, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(329, 29);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(298, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(329, 5);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(294, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBuscaObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(114, 27);
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
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Análisis Estadístico";
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(256, 8);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(46, 38);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbConcretera.DisplayMember = "IdConcretera";
            this.cmbConcretera.Location = new System.Drawing.Point(472, 5);
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
            this.cmbPlanta.Location = new System.Drawing.Point(472, 29);
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
            this.crvRepAnalisis.Location = new System.Drawing.Point(0, 137);
            this.crvRepAnalisis.Name = "crvRepAnalisis";
            this.crvRepAnalisis.ShowCloseButton = false;
            this.crvRepAnalisis.ShowGroupTreeButton = false;
            this.crvRepAnalisis.ShowLogo = false;
            this.crvRepAnalisis.ShowRefreshButton = false;
            this.crvRepAnalisis.Size = new System.Drawing.Size(1028, 611);
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
            this.sqlSelectCommand4.CommandText = "[Analisis]";
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
            new System.Data.SqlClient.SqlParameter("@diaa", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@diab", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@diac", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Indice", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 1),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Increm", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@Edif", System.Data.SqlDbType.NVarChar, 12),
            new System.Data.SqlClient.SqlParameter("@Web", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Image", System.Data.SqlDbType.Image, 2147483647),
            new System.Data.SqlClient.SqlParameter("@Origen", System.Data.SqlDbType.Int, 4)});
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
            // sqlDAAnalisis63
            // 
            this.sqlDAAnalisis63.SelectCommand = this.sqlCommand3;
            this.sqlDAAnalisis63.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "[Analisis63]";
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
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@3i", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@7i", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@eei", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@datos", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@diaa", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@diab", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@diac", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Indice", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 1)});
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
            // sqlSelectCommand8
            // 
            this.sqlSelectCommand8.CommandText = resources.GetString("sqlSelectCommand8.CommandText");
            this.sqlSelectCommand8.Connection = this.sqlConn;
            this.sqlSelectCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Resistencia", System.Data.SqlDbType.Real, 4, "ResistenciaKG"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Real, 4, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Revenimiento", System.Data.SqlDbType.Real, 4, "Revenimento"),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 4, "IdAgregado"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 1, "Grado")});
            // 
            // sqlDAEdif
            // 
            this.sqlDAEdif.SelectCommand = this.sqlSelectCommand8;
            this.sqlDAEdif.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestras", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Edif1", "Edif1"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado")})});
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(214, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 392);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(214, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(616, 392);
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(214, 186);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(340, 200);
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // dsAnalisis1
            // 
            this.dsAnalisis1.DataSetName = "dsAnalisis";
            this.dsAnalisis1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsAnalisis1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsTenPro1
            // 
            this.dsTenPro1.DataSetName = "dsTenPro";
            this.dsTenPro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDATenPro
            // 
            this.sqlDATenPro.SelectCommand = this.sqlCommand4;
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
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlConn;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 2, "IdPrueba"),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 2, "IdDiametro"),
            new System.Data.SqlClient.SqlParameter("@Sem", System.Data.SqlDbType.SmallInt, 2, "Sem")});
            // 
            // RepAnalisis
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1028, 748);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crvRepAnalisis);
            this.Controls.Add(this.panel1);
            this.Name = "RepAnalisis";
            this.Text = "RepAnalisis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepAnalisis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigenCo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEdif1)).EndInit();
            this.gBoxEsp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNoEco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalisis1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTenPro1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
        protected GraphPane myPane;
        protected GraphPane myPane1;
        private void RepAnalisis_Load(object sender, System.EventArgs e)
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
//			dsBuscaObra1.Tables[0].Rows.Add((Rr);
			sqlDABusObra.Fill(dsBuscaObra1, "Obra");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
            dsOrigenCo1.OrigenCo.AddOrigenCoRow(-1, "Todos");
            dsOrigenCo1.OrigenCo.AddOrigenCoRow(1, "Lanc");
            dsOrigenCo1.OrigenCo.AddOrigenCoRow(2, "Cliente");
            dsOrigenCo1.OrigenCo.AddOrigenCoRow(3, "Obra");
            cmbOrigen.SelectedIndex = 1;
            dsConcretera1.Concretera.AddConcreteraRow("Todas","Todas","%");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			cmbConcretera.SelectedIndex = 0;
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",(cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString()));
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue);
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
			dsBusNoEco1.Laboratorista.AddLaboratoristaRow(-1,"Todos");
			sqlDANoEco.Fill(dsBusNoEco1, "Laboratorista");
			cmbNoEco.SelectedIndex = 0;
			sqlDADiametro.Fill(dsDiametro1,"Diametro");
			cmbIdDiam.SelectedIndex= 0;
            dsEdif1.Edif.AddEdifRow("%", "Todos");
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
			btnVistaPrevia.Visible = true;
            int tipo = 1;
            switch (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString())
            {
                case "Normal":
                    tipo = 1;
                    break;
                case "Rápido":
                    tipo = 2;
                    break;
                case "Tres":
                    tipo = 3;
                    break;
                case "P63":
                    tipo = 4;
                    break;
                default:
                    tipo = 1;
                    break;
            }
            dsEdif1.Clear();
            dsEdif1.Edif.AddEdifRow("%", "Todos");
            sqlDAEdif.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text);
            sqlDAEdif.SelectCommand.Parameters["@Resistencia"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
            sqlDAEdif.SelectCommand.Parameters["@Agregado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
            sqlDAEdif.SelectCommand.Parameters["@Revenimiento"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString();
            sqlDAEdif.SelectCommand.Parameters["@IdAgregado"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString() == "Normal" ? 1 : 2);
            sqlDAEdif.SelectCommand.Parameters["@Tipo"].Value = tipo;
            sqlDAEdif.SelectCommand.Parameters["@Grado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString();
            sqlDAEdif.Fill(dsEdif1, "Edif");
            chbLanc200.Visible = (tipo == 1 ? true : false);
            cmbEdif.SelectedIndex = 0;
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            crvRepAnalisis.Visible = true;
            int dias = 28;
            int tipo = 1;
            switch (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString())
            {
                case "Normal":
                    dias = 28;
                    tipo = 1;
                    break;
                case "Rápido":
                    dias = 14;
                    tipo = 2;
                    break;
                case "Tres":
                    dias = 3;
                    tipo = 3;
                    break;
                case "P63":
                    dias = 63;
                    tipo = 4;
                    break;
                default:
                    dias = 28;
                    tipo = 1;
                    break;
            }

            double incremento = float.Parse(txtIncrem.Text);
			incremento = (incremento >19 || incremento < 0 ? 0.1 : incremento /100);
			try
				{
				dsAnalisis1.Clear();
				if (dias != 63)
				{
                    if (tipo == 1 && chbLanc200.Checked)
                        sqlDAAnalisis.SelectCommand.CommandText = "Analisis200";
                    else
                        sqlDAAnalisis.SelectCommand.CommandText = "Analisis";

                    sqlDAAnalisis.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text);
					sqlDAAnalisis.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue) ;
					sqlDAAnalisis.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
					sqlDAAnalisis.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
					sqlDAAnalisis.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
					sqlDAAnalisis.SelectCommand.Parameters["@ResistenciaKg"].Value = (tipo == 1 && chbLanc200.Checked ? "200" : dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString());
					sqlDAAnalisis.SelectCommand.Parameters["@Agregado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
					sqlDAAnalisis.SelectCommand.Parameters["@Renvenimiento"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString();
					sqlDAAnalisis.SelectCommand.Parameters["@IdAgregado"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString() == "Normal" ? 1 : 2);
					sqlDAAnalisis.SelectCommand.Parameters["@IdPrueba"].Value = cmbPrueba.SelectedValue.ToString();
					sqlDAAnalisis.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
					sqlDAAnalisis.SelectCommand.Parameters["@NoEco"].Value = cmbNoEco.SelectedValue.ToString();
					sqlDAAnalisis.SelectCommand.Parameters["@3i"].Value = txtA3.Text;
					sqlDAAnalisis.SelectCommand.Parameters["@7i"].Value = txtA7.Text;
					sqlDAAnalisis.SelectCommand.Parameters["@eei"].Value = txtEE.Text;
					sqlDAAnalisis.SelectCommand.Parameters["@diaa"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Tres" ? 2 : (rButNormal.Checked ? 3 : 7 ));
					sqlDAAnalisis.SelectCommand.Parameters["@diab"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Tres" ? 14 : (rButNormal.Checked ? 7 :14));
					sqlDAAnalisis.SelectCommand.Parameters["@diac"].Value = dias;
					sqlDAAnalisis.SelectCommand.Parameters["@Indice"].Value = txtResIndice.Text;
					sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 1;
					sqlDAAnalisis.SelectCommand.Parameters["@Tipo"].Value = tipo;
					sqlDAAnalisis.SelectCommand.Parameters["@Grado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString();
					sqlDAAnalisis.SelectCommand.Parameters["@IdDiam"].Value = cmbIdDiam.SelectedValue;
					sqlDAAnalisis.SelectCommand.Parameters["@Increm"].Value = incremento;
                    sqlDAAnalisis.SelectCommand.Parameters["@Edif"].Value = cmbEdif.SelectedValue;
                    sqlDAAnalisis.SelectCommand.Parameters["@Origen"].Value = cmbOrigen.SelectedValue;
                    sqlDAAnalisis.Fill(dsAnalisis1, "Analisis1");
					sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 2;
					sqlDAAnalisis.Fill(dsAnalisis1, "Grafica1");
					sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 3;
					sqlDAAnalisis.Fill(dsAnalisis1, "GraficaFinal");
				}
				else
				{
					sqlDAAnalisis63.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
					sqlDAAnalisis63.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue) ;
					sqlDAAnalisis63.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
					sqlDAAnalisis63.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
					sqlDAAnalisis63.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
					sqlDAAnalisis63.SelectCommand.Parameters["@ResistenciaKg"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
					sqlDAAnalisis63.SelectCommand.Parameters["@Agregado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
					sqlDAAnalisis63.SelectCommand.Parameters["@Renvenimiento"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString();
					sqlDAAnalisis63.SelectCommand.Parameters["@IdAgregado"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString() == "Normal" ? 1 : 2);
					sqlDAAnalisis63.SelectCommand.Parameters["@IdPrueba"].Value = cmbPrueba.SelectedValue.ToString();
					sqlDAAnalisis63.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
					sqlDAAnalisis63.SelectCommand.Parameters["@NoEco"].Value = cmbNoEco.SelectedValue.ToString();
					sqlDAAnalisis63.SelectCommand.Parameters["@3i"].Value = txtA3.Text;
					sqlDAAnalisis63.SelectCommand.Parameters["@7i"].Value = txtA7.Text;
					sqlDAAnalisis63.SelectCommand.Parameters["@eei"].Value = txtEE.Text;
					sqlDAAnalisis63.SelectCommand.Parameters["@diaa"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Tres" ? 2 : 3);
					sqlDAAnalisis63.SelectCommand.Parameters["@diab"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Tres" ? 14 : 7);
					sqlDAAnalisis63.SelectCommand.Parameters["@diac"].Value = dias;
					sqlDAAnalisis63.SelectCommand.Parameters["@Indice"].Value = txtResIndice.Text;
					sqlDAAnalisis63.SelectCommand.Parameters["@Datos"].Value = 1;
					sqlDAAnalisis63.SelectCommand.Parameters["@Tipo"].Value = tipo;
					sqlDAAnalisis63.SelectCommand.Parameters["@Grado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString();
					sqlDAAnalisis63.Fill(dsAnalisis1, "Analisis1");
					sqlDAAnalisis63.SelectCommand.Parameters["@Datos"].Value = 2;
					sqlDAAnalisis63.Fill(dsAnalisis1, "Grafica1");
					sqlDAAnalisis63.SelectCommand.Parameters["@Datos"].Value = 3;
					sqlDAAnalisis63.Fill(dsAnalisis1, "GraficaFinal");
				}

                int semestre = (dtpFin.Value.Month > 6 ? 1 : 2);
                int año = (semestre == 2 ? dtpFin.Value.Year-1 : dtpFin.Value.Year );
                int todas = 0;
                dsTenPro1.Clear();
                sqlDATenPro.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
                sqlDATenPro.SelectCommand.Parameters["@Año"].Value = año;
                sqlDATenPro.SelectCommand.Parameters["@Sem"].Value = semestre;
                sqlDATenPro.SelectCommand.Parameters["@IdDiam"].Value = cmbIdDiam.SelectedValue;
                sqlDATenPro.SelectCommand.Parameters["@IdPrueba"].Value = cmbPrueba.SelectedValue.ToString();
                sqlDATenPro.SelectCommand.Parameters["@Tipo"].Value = tipo;
                sqlDATenPro.Fill(dsTenPro1, "Tendencia");

                if (dsTenPro1.Tendencia.Rows.Count == 0 && cmbConcretera.SelectedValue.ToString() != "Todas")
                {
                    todas = 1;
                    sqlDATenPro.SelectCommand.Parameters["@IdConcretera"].Value = "Todas";
                    sqlDATenPro.SelectCommand.Parameters["@Año"].Value = año;
                    sqlDATenPro.SelectCommand.Parameters["@Sem"].Value = semestre;
                    sqlDATenPro.SelectCommand.Parameters["@IdDiam"].Value = cmbIdDiam.SelectedValue;
                    sqlDATenPro.SelectCommand.Parameters["@IdPrueba"].Value = cmbPrueba.SelectedValue.ToString();
                    sqlDATenPro.SelectCommand.Parameters["@Tipo"].Value = tipo;
                    sqlDATenPro.Fill(dsTenPro1, "Tendencia");
                }

                double ressis = double.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString());
                ressis = (ressis > 400 ? (ressis > 799 ? 1000 : 800) : 500);
                ressis = ressis * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                float ressis1 = float.Parse(ressis.ToString());
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
                yy[0] = (rButNormal.Checked ? 3 : 7);
                yy[1] = (rButNormal.Checked ? 7 : 14);
                yy[2] = dias;
                yy[3] = (dias == 28 ? 63 : 28);
                dias = dsAnalisis1.Analisis1.Rows.Count;
                for (int i = 0; i < dias; i++)
                {
                    if (! DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][5]))
                    {
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][5].ToString()) > 0)
                        {
                            s[0] += double.Parse(dsAnalisis1.Analisis1.Rows[i][5].ToString());
                            n[0]++;
                        }
                    }
                    if (! DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][7]))
                    {
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][7].ToString()) > 0)
                        {
                            s[1] += double.Parse(dsAnalisis1.Analisis1.Rows[i][7].ToString());
                            n[1]++;
                        }
                    }
                    if (! DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][13]))
                    {
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][13].ToString()) > 0)
                        {
                            s[2] += double.Parse(dsAnalisis1.Analisis1.Rows[i][13].ToString());
                            n[2]++;
                        }
                    }
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][17]))
                    {
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][17].ToString()) > 0)
                        {
                            s[3] += double.Parse(dsAnalisis1.Analisis1.Rows[i][17].ToString());
                            n[3]++;
                        }
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
                            su[0] += Math.Pow((double.Parse(dsAnalisis1.Analisis1.Rows[i][5].ToString()) - xx[0]),2);
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][7]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][7].ToString()) > 0)
                            su[1] += Math.Pow((double.Parse(dsAnalisis1.Analisis1.Rows[i][7].ToString()) - xx[1]), 2);
                    if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][13]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][13].ToString()) > 0)
                            su[2] += Math.Pow((double.Parse(dsAnalisis1.Analisis1.Rows[i][13].ToString()) - xx[2]),2);
                if (!DBNull.Value.Equals(dsAnalisis1.Analisis1.Rows[i][17]))
                        if (double.Parse(dsAnalisis1.Analisis1.Rows[i][17].ToString()) > 0)
                            su[3] += Math.Pow((double.Parse(dsAnalisis1.Analisis1.Rows[i][17].ToString()) - xx[3]), 2);
                }
                for (int i = 0; i < 5; i++)
                    if (su[i] != 0)
                        de[i] = Math.Sqrt(su[i] / n[i]);

                xx[3] = (xx[3] > xx[2] ? xx[3] : 0);
                string[] matriz = new string[10] { "cero", "uno", " dos", " tres", " cuatro", " cinco", " seis", " siete", " ocho", " nueve" };

                dias = dsAnalisis1.Grafica1.Rows.Count;
				dias = dsAnalisis1.GraficaFinal.Rows.Count;
                //for (int i = 0; i < dias; i++)
                //    dsAnalisis1.Tables["GraficaFinal"].Rows[i][0] = matriz[i];
                //DataRow filas = dsAnalisis1.Tables["GraficaFinal"].Rows[2];
//                dsAnalisis1.Tables["GraficaFinal"].Rows.InsertAt(filas, 0);
//                dsAnalisis1.Tables["GraficaFinal"].Rows.Add(filas);
//                dsAnalisis1.Tables["GraficaFinal"].Rows.Add(filas);

                float[] gaus;
				gaus= new float[22];
				double[] ee;
				ee= new double[22];
				double[] nuevoee;
				nuevoee = new double[22];
				double moda = 0;
				int indice = 1;
				for(int i= 0; i <= 21; i++)
				{
					nuevoee[i] = 0;
					ee[i] = 0;
				}

				sqlDATitulo.SelectCommand.Parameters["@ResistenciaKg"].Value = (cmbPrueba.SelectedIndex == 0 ? (tipo == 1 && chbLanc200.Checked ? "200" : dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1]) : txtResIndice.Text);
				sqlDATitulo.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
				sqlDATitulo.SelectCommand.Parameters["@Hoja"].Value = int.Parse(dsAnalisis1.Tables["GraficaFinal"].Rows[0][24].ToString());
				sqlDATitulo.SelectCommand.Parameters["@Incre"].Value = incremento;
				sqlDATitulo.Fill(dsAnalisis1,"Titulo");

				// Establece el valor actual de parameter1 en el subinforme en 10 
				float res = float.Parse((tipo == 1 && chbLanc200.Checked ? "200" : dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString())) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
				res = (cmbPrueba.SelectedIndex == 0 ? res : float.Parse(txtResIndice.Text));

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

                CurveItem curve;
                ArrowItem arrow = new ArrowItem(Color.Red, 0, 3, 0, 3, ressis1);
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
                for (float ww = 100; ww < ressis1; ww = ww + 100)
                {
                    arrow = new ArrowItem(Color.Gray, 0, 0, ww, 100, ww);
                    arrow.CoordinateFrame = CoordType.AxisXYScale;
                    arrow.PenWidth = 0F;
                    myPane.ArrowList.Add(arrow);
                }
                curve = myPane.AddCurve(acotacion, yy, xx, Color.DarkBlue, SymbolType.Circle);
                curve.Line.Width = 2.0F;
                curve.Symbol.Fill = new Fill(Color.DarkBlue);
                curve.Symbol.Size = 12;
                for (int jj = 4; jj >= 0; jj--)
                    if (xx[jj] == 0)
                        curve.Points.Remove(jj);
                for (int i = 0; i < 5; i++)
                {
                    su[i] = s2[i] = 0;
                    su[i] = xx[i] + de[i];
                    s2[i] = xx[i] + de[i]  + de[i];
                }
                curve = myPane.AddCurve(acotacion, yy, su, Color.DarkBlue, SymbolType.Empty);
                curve.Line.Width = 1.75F;
                curve.Line.Style = new Single();
                curve.Symbol.Fill = new Fill(Color.DarkBlue);
                curve.Symbol.Size = 1;
                for (int jj = 4; jj >= 0; jj--)
                    if (su[jj] <= 0 || (jj == 3 && n[jj] < 10))
                        curve.Points.Remove(jj);
                curve = myPane.AddCurve(acotacion, yy, s2, Color.Green, SymbolType.Empty);
                curve.Line.Width = 1.0F;
                curve.Line.Style = new DashStyle()   ;
                curve.Symbol.Fill = new Fill(Color.AliceBlue);
                curve.Symbol.Size = 1;
                for (int jj = 4; jj >= 0; jj--)
                    if (s2[jj] <= 0 || (jj == 3 && n[jj] < 10))
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
                    if (su[jj] <= 0 || (jj == 3 && n[jj] < 10))
                        curve.Points.Remove(jj);
                curve = myPane.AddCurve(acotacion, yy, s2, Color.Green, SymbolType.Empty);
                curve.Line.Width = 1.0F;
                curve.Line.Style = new DashStyle();
                curve.Symbol.Fill = new Fill(Color.AliceBlue);
                curve.Symbol.Size = 1;
                for (int jj = 4; jj >= 0; jj--)
                    if (s2[jj] <= 0 || (jj == 3 && n[jj] < 10))
                        curve.Points.Remove(jj);
                
                Color[] colorado = { Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.DarkGreen,
                                     Color.DarkKhaki, Color.DarkMagenta, Color.DarkOliveGreen, Color.DarkOrange };
                for (int k = 0; k < 5; k++)
                    x[k] = y[k] = 0;

                if(dsTenPro1.Tendencia.Rows.Count == 0)
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
                myPane.XAxis.Min = 0.95; //cambiar
                myPane.XAxis.Max = 100;
                myPane.XAxis.Type = AxisType.Log;
                myPane.XAxis.PickLogScale();

                myPane.XAxis.TitleFontSpec.Family = "Times New Roman";
                myPane.XAxis.TitleFontSpec.Size = 11;
                myPane.XAxis.IsShowTitle = false;
                myPane.XAxis.ScaleFontSpec.FontColor = Color.White;
                myPane.XAxis.IsMinorTic = false;

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

                memGraphics1.CreateDoubleBuffer(this.CreateGraphics(),
                    this.ClientRectangle.Width, this.ClientRectangle.Height);

                myPane1 = new GraphPane(new Rectangle(10, 10, 10, 10),
                    " ", "", "");
                SetSize1();
                CurveItem curve1;

                double incdec = 0.1;
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i <= 21; i++)
                    {
                        nuevoee[i] = double.Parse(dsAnalisis1.Tables["GraficaFinal"].Rows[j][i+1].ToString());
                        ee[i] = res * (incdec * i);
                    }
                    if (j == 0)
                    {
                        curve1 = myPane1.AddCurve(dsAnalisis1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkSeaGreen, SymbolType.Square);
                        curve1.Line.Width = 2.5F;
                        curve1.Symbol.Fill = new Fill(Color.DarkSeaGreen);
                        //for (int k = 23; k >= 3; k--)
                        //    if (nuevoee[k] == 0)
                        //        curve.Points.Remove(k);
                    }
                    if (j == 1)
                    {
                        curve1 = myPane1.AddCurve(dsAnalisis1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkCyan, SymbolType.Diamond);
                        curve1.Line.Width = 2.5F;
                        curve1.Symbol.Fill = new Fill(Color.DarkCyan);
                        //for (int k = 23; k >= 3; k--)
                        //    if (nuevoee[k] == 0)
                        //        curve.Points.Remove(k);
                    }
                    if (j == 2)
                    {
                        curve1 = myPane1.AddCurve(dsAnalisis1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkSlateBlue, SymbolType.Circle);
                        curve1.Line.Width = 3.5F;
                        curve1.Symbol.Fill = new Fill(Color.DarkSlateBlue);
                        //for (int k = 23; k >= 3; k--)
                        //    if (nuevoee[k] == 0)
                        //        curve.Points.Remove(k);
                    }
                    if (j == 3)
                    {
                        if (n[j] > 10)
                        {
                            curve1 = myPane1.AddCurve(dsAnalisis1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.Brown, SymbolType.TriangleDown);
                            curve1.Line.Width = 2.5F;
                            curve1.Symbol.Fill = new Fill(Color.Brown);
                            //for (int k = 23; k >= 3; k--)
                            //    if (nuevoee[k] == 0)
                            //        curve.Points.Remove(k);
                        }
                    }

                }


                myPane1.XAxis.IsMinorInsideTic = true;
                myPane1.XAxis.TicSize = float.Parse((res * 0.05).ToString());
                myPane1.XAxis.IsShowGrid = true;
                myPane1.XAxis.IsInsideTic = true;
                myPane1.XAxis.ScaleFontSpec.Angle = 0;
                myPane1.XAxis.NumDec = 0;
                myPane1.XAxis.Step = float.Parse((res * 0.05).ToString());
                myPane1.XAxis.ScaleFontSpec.Size = 10;
                myPane1.XAxis.Min = res*0.1; //cambiar
                myPane1.XAxis.Max = res * 22 * 0.1;
                myPane1.XAxis.Type = AxisType.Linear;
                myPane1.XAxis.StepAuto = true;
//                myPane1.XAxis.MinorStepAuto = true;
                myPane1.XAxis.TitleFontSpec.Family = "Times New Roman";
                myPane1.XAxis.TitleFontSpec.Size = 12;
                myPane1.XAxis.IsShowTitle = false;
                myPane1.XAxis.ScaleFontSpec.FontColor = Color.Black;
                myPane1.XAxis.IsMinorTic = true;

                myPane1.YAxis.IsMinorInsideTic = true;
                myPane1.XAxis.IsInsideTic = true;
                myPane1.YAxis.IsShowGrid = true;
                myPane1.YAxis.ScaleFontSpec.Angle = 90;
                myPane1.YAxis.ScaleFontSpec.Size = 10;
                myPane1.YAxis.Min = 0;
                //myPane1.YAxis.Max = ressis;
                myPane1.YAxis.TicSize = 10;
                myPane1.YAxis.TitleFontSpec.Family = "Times New Roman";
                myPane1.YAxis.ScaleFontSpec.Family = "Times New Roman";
                myPane1.Legend.IsVisible = true;
                myPane1.Legend.Location = LegendLoc.InsideTopRight;
                myPane1.Legend.FontSpec.Size = 10;
                myPane1.PaneFill = new Fill(Color.White, Color.White, 2F);
                myPane1.AxisChange(this.CreateGraphics());

                pictureBox2.Image = Image.FromHbitmap(myPane1.Image.GetHbitmap());
                pictureBox2.BorderStyle = BorderStyle.None;
                MemoryStream ms1 = new MemoryStream();
                pictureBox2.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] arrImage1 = ms1.GetBuffer();
                ms1.Close();

                myPane1.Image.Dispose();
                pictureBox2.Image.Dispose();
                dsAnalisis1.Grafica2.AddGrafica2Row("1", arrImage1);

//                memGraphics1.CreateDoubleBuffer(this.CreateGraphics(), this.ClientRectangle.Width, this.ClientRectangle.Height);

//                myPane1 = new GraphPane(new Rectangle(10, 10, 10, 10), " ", "", "");
                //SetSize1();
                //CurveItem curve1;

                incdec = 0.1;
                double[] eex;
                eex = new double[12];
                double[] neey;
                neey = new double[12];
                int hoja = int.Parse(dsAnalisis1.Grafica1.Rows[0][0].ToString());
                int hoaa = hoja;
                int ij = 0;
                myPane1 = new GraphPane(new Rectangle(10, 10, 10, 10),
                    " ", "", "");
                SetSize1();
                for (int m = 0; m < dsAnalisis1.Grafica1.Rows.Count; m++)
                {
                    if (hoaa != int.Parse(dsAnalisis1.Grafica1.Rows[m][0].ToString()) && ij >= 4)
                    {
                        guardagrafica(res, hoaa);
                        myPane1 = new GraphPane(new Rectangle(10, 10, 10, 10),
                            " ", "", "");
                        SetSize1();
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
                                curve1 = myPane1.AddCurve(dsAnalisis1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.DarkSeaGreen, SymbolType.Square);
                                curve1.Symbol.Fill = new Fill(Color.DarkSeaGreen);
                                curve1.Line.Width = 2.5F;
                            }
                            if (ij == 1)
                            {
                                curve1 = myPane1.AddCurve(dsAnalisis1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.DarkCyan, SymbolType.Diamond);
                                curve1.Symbol.Fill = new Fill(Color.DarkCyan);
                                curve1.Line.Width = 2.5F;
                            }
                            if (ij == 2)
                            {
                                curve1 = myPane1.AddCurve(dsAnalisis1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.DarkSlateBlue, SymbolType.Circle);
                                curve1.Line.Width = 3.5F;
                                curve1.Symbol.Fill = new Fill(Color.DarkSlateBlue);
                            }
                            if (ij == 3)
                            {
                                curve1 = myPane1.AddCurve(dsAnalisis1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.Brown, SymbolType.TriangleDown);
                                curve1.Symbol.Fill = new Fill(Color.Brown);
                                curve1.Line.Width = 2.5F;
                            }
                            ij++;
                }
                guardagrafica(res, hoaa);
                
                switch (tipo)
                {
                    case 3:
                        cryRepAnalisisT1.SetDataSource(dsAnalisis1);
                        cryRepAnalisisT1.SetParameterValue("@Unidad", cmbUnidad.Text);
                        cryRepAnalisisT1.SetParameterValue("@Edad", (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Normal" ? 1 : (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Rápido" ? 2 : 4)));
                        cryRepAnalisisT1.SetParameterValue("@Res", float.Parse((tipo == 1 && chbLanc200.Checked ? "200" : dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString())) * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                        cryRepAnalisisT1.SetParameterValue("@Tip", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString());
                        cryRepAnalisisT1.SetParameterValue("@Tma", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString());
                        cryRepAnalisisT1.SetParameterValue("@Rev", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString());
                        cryRepAnalisisT1.SetParameterValue("@Tag", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString());
                        cryRepAnalisisT1.SetParameterValue("@Con", cmbConcretera.Text);
                        cryRepAnalisisT1.SetParameterValue("@Pla", cmbPlanta.Text);
                        cryRepAnalisisT1.SetParameterValue("@Lab", cmbNoEco.Text);
                        cryRepAnalisisT1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                        cryRepAnalisisT1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                        cryRepAnalisisT1.SetParameterValue("@Obr", txtIdobra.Text);
                        cryRepAnalisisT1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                        cryRepAnalisisT1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
                        cryRepAnalisisT1.SetParameterValue("@reskg", res.ToString(), "Gauss");
                        cryRepAnalisisT1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
                        cryRepAnalisisT1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                        cryRepAnalisisT1.SetParameterValue("@Prueba", cmbPrueba.Text);
                        cryRepAnalisisT1.SetParameterValue("@Grado", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString());
                        cryRepAnalisisT1.SetParameterValue("@Indice", (cmbPrueba.SelectedIndex == 0 ? res.ToString() : txtResIndice.Text));
                        cryRepAnalisisT1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                        cryRepAnalisisT1.SetParameterValue("@Lab1", chbLab.Checked);
                        crvRepAnalisis.ReportSource = cryRepAnalisisT1;
                        break;
                    default:
                        if (cbkFormato.Checked)
                        {
                            cryRepAnalisisM1.SetDataSource(dsAnalisis1);
                            cryRepAnalisisM1.SetParameterValue("@Unidad", cmbUnidad.Text);
                            cryRepAnalisisM1.SetParameterValue("@Edad", (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Normal" ? 1 : (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Rápido" ? 2 : 4)));
                            cryRepAnalisisM1.SetParameterValue("@Res", float.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString()) * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                            cryRepAnalisisM1.SetParameterValue("@Tip", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString());
                            cryRepAnalisisM1.SetParameterValue("@Tma", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString());
                            cryRepAnalisisM1.SetParameterValue("@Rev", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString());
                            cryRepAnalisisM1.SetParameterValue("@Tag", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString());
                            cryRepAnalisisM1.SetParameterValue("@Con", cmbConcretera.Text);
                            cryRepAnalisisM1.SetParameterValue("@Pla", cmbPlanta.Text);
                            cryRepAnalisisM1.SetParameterValue("@Lab", cmbNoEco.Text);
                            cryRepAnalisisM1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                            cryRepAnalisisM1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                            cryRepAnalisisM1.SetParameterValue("@Obr", txtIdobra.Text);
                            cryRepAnalisisM1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                            cryRepAnalisisM1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
                            cryRepAnalisisM1.SetParameterValue("@reskg", res.ToString(), "Gauss");
                            cryRepAnalisisM1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
                            cryRepAnalisisM1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                            cryRepAnalisisM1.SetParameterValue("@Prueba", cmbPrueba.Text);
                            cryRepAnalisisM1.SetParameterValue("@Grado", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString());
                            cryRepAnalisisM1.SetParameterValue("@Indice", (cmbPrueba.SelectedIndex == 0 ? res.ToString() : txtResIndice.Text));
                            cryRepAnalisisM1.SetParameterValue("@Figura", cmbIdDiam.Text);
                            cryRepAnalisisM1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                            crvRepAnalisis.ReportSource = cryRepAnalisisM1;
                        }
                        else
                        {
                            cryRepAnalisis1.SetDataSource(dsAnalisis1);
                            cryRepAnalisis1.SetParameterValue("@Unidad", cmbUnidad.Text);
                            cryRepAnalisis1.SetParameterValue("@Edad", (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Normal" ? 1 : (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Rápido" ? 2 : 4)));
                            cryRepAnalisis1.SetParameterValue("@Res", float.Parse((tipo == 1 && chbLanc200.Checked ? "200" : dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString())) * float.Parse(dsUnidad1.Tables["Unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                            cryRepAnalisis1.SetParameterValue("@Tip", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString());
                            cryRepAnalisis1.SetParameterValue("@Tma", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString());
                            cryRepAnalisis1.SetParameterValue("@Rev", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString());
                            cryRepAnalisis1.SetParameterValue("@Tag", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString());
                            cryRepAnalisis1.SetParameterValue("@Con", cmbConcretera.SelectedValue);
                            cryRepAnalisis1.SetParameterValue("@Pla", cmbPlanta.Text);
                            cryRepAnalisis1.SetParameterValue("@Lab", cmbNoEco.Text);
                            cryRepAnalisis1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                            cryRepAnalisis1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                            cryRepAnalisis1.SetParameterValue("@Obr", txtIdobra.Text);
                            cryRepAnalisis1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                            cryRepAnalisis1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
                            cryRepAnalisis1.SetParameterValue("@reskg", res.ToString(), "Gauss");
                            cryRepAnalisis1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
                            cryRepAnalisis1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                            cryRepAnalisis1.SetParameterValue("@Prueba", cmbPrueba.Text);
                            cryRepAnalisis1.SetParameterValue("@Grado", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString());
                            cryRepAnalisis1.SetParameterValue("@Indice", (cmbPrueba.SelectedIndex == 0 ? res.ToString() : txtResIndice.Text));
                            cryRepAnalisis1.SetParameterValue("@Figura", cmbIdDiam.Text);
                            cryRepAnalisis1.SetParameterValue("@Tempranos", rButNormal.Checked);
                            cryRepAnalisis1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                            cryRepAnalisis1.SetParameterValue("@Edif", dsEdif1.Edif.Rows[cmbEdif.SelectedIndex][1].ToString());
                            cryRepAnalisis1.SetParameterValue("T2018", dsTenPro1.Tendencia.Rows.Count, "Gauss");
                            cryRepAnalisis1.SetParameterValue("Concretera", (cmbConcretera.Text == "Todas" ? " " : cmbConcretera.Text), "Gauss");
                            cryRepAnalisis1.SetParameterValue("Año", año, "Gauss");
                            cryRepAnalisis1.SetParameterValue("Semestre", semestre, "Gauss");
                            crvRepAnalisis.ReportSource = cryRepAnalisis1;
                        }
                        break;
                }

				
//				cryRepAnalisisT1.SetParameterValue("@Figura", cmbIdDiam.Text );

				

//				crvRepAnalisis.RefreshReport();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}
		}

		private void cmbPrueba_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cmbPrueba.SelectedIndex == 0)
			{
				lblIndice.Visible = false;
				txtResIndice.Visible = false;
			}
			else
			{
				lblIndice.Visible = true;
				txtResIndice.Visible = true;
			}
            int tipo = 1;
            switch (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString())
            {
                case "Normal":
                    tipo = 1;
                    break;
                case "Rápido":
                    tipo = 2;
                    break;
                case "Tres":
                    tipo = 3;
                    break;
                case "P63":
                    tipo = 4;
                    break;
                default:
                    tipo = 1;
                    break;
            }
            dsEdif1.Clear();
            dsEdif1.Edif.AddEdifRow("%", "Todos");
            sqlDAEdif.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text);
            sqlDAEdif.SelectCommand.Parameters["@Resistencia"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
            sqlDAEdif.SelectCommand.Parameters["@Agregado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
            sqlDAEdif.SelectCommand.Parameters["@Revenimiento"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString();
            sqlDAEdif.SelectCommand.Parameters["@IdAgregado"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString() == "Normal" ? 1 : 2);
            sqlDAEdif.SelectCommand.Parameters["@Tipo"].Value = tipo;
            sqlDAEdif.SelectCommand.Parameters["@Grado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString();
            sqlDAEdif.Fill(dsEdif1, "Edif");
            cmbEdif.SelectedIndex = 0;
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

		
		private void cmbConcretera_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cmbPlanta.Enabled = true;
		}

        private void chbLanc200_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SetSize()
        {
            Rectangle paneRect = this.ClientRectangle;
            paneRect.Inflate(-2, -1);
            this.myPane.PaneRect = paneRect;
        }

        private void SetSize1()
        {
            Rectangle paneRect = this.ClientRectangle;
            paneRect.Inflate(-2, -1);
            this.myPane1.PaneRect = paneRect;
        }

        private void guardagrafica(double res, int hoja)
        {

            myPane1.XAxis.IsMinorInsideTic = true;
                        myPane1.XAxis.TicSize = float.Parse((res * 0.1).ToString());
                        myPane1.XAxis.IsShowGrid = true;
                        myPane1.XAxis.IsInsideTic = true;
                        myPane1.XAxis.ScaleFontSpec.Angle = 0;
                        myPane1.XAxis.NumDec = 0;
                        myPane1.XAxis.Step = float.Parse((res * 0.1).ToString());
                        myPane1.XAxis.ScaleFontSpec.Size = 10;
                        myPane1.XAxis.Min = res * 0.5; //cambiar
                        myPane1.XAxis.Max = res * 1.6;
                        myPane1.XAxis.Type = AxisType.Linear;
                        myPane1.XAxis.StepAuto = true;
                        //                myPane1.XAxis.MinorStepAuto = true;
                        myPane1.XAxis.TitleFontSpec.Family = "Times New Roman";
                        myPane1.XAxis.TitleFontSpec.Size = 8;
                        myPane1.XAxis.IsShowTitle = false;
                        myPane1.XAxis.ScaleFontSpec.FontColor = Color.Black;
                        myPane1.XAxis.IsMinorTic = true;

                        myPane1.YAxis.IsMinorInsideTic = true;
                        myPane1.XAxis.IsInsideTic = true;
                        myPane1.YAxis.IsShowGrid = true;
                        myPane1.YAxis.ScaleFontSpec.Angle = 90;
                        myPane1.YAxis.ScaleFontSpec.Size = 8;
                        myPane1.YAxis.Min = 0;
                        myPane1.YAxis.Max = 30;
                        myPane1.YAxis.TicSize = 10;
                        myPane1.YAxis.TitleFontSpec.Family = "Times New Roman";
                        myPane1.YAxis.ScaleFontSpec.Family = "Times New Roman";
                        myPane1.Legend.IsVisible = true;
                        myPane1.Legend.Location = LegendLoc.InsideTopRight;
                        myPane1.Legend.FontSpec.Size = 8;
                        myPane1.PaneFill = new Fill(Color.White, Color.White, 2F);
                        myPane1.AxisChange(this.CreateGraphics());

                        pictureBox3.Image = Image.FromHbitmap(myPane1.Image.GetHbitmap());
                        pictureBox3.BorderStyle = BorderStyle.None;
                        MemoryStream ms1 = new MemoryStream();
                        pictureBox3.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Bmp);
                        byte[] arrImage1 = ms1.GetBuffer();
                        ms1.Close();

                        myPane1.Image.Dispose();
                        pictureBox3.Image.Dispose();
                        dsAnalisis1.Grafica11.AddGrafica11Row(hoja, arrImage1);

        }    

	}
}
