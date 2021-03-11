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
	/// Descripción breve de RepCorrelacionF.
	/// </summary>
	public class RepCorrelacionF : System.Windows.Forms.Form
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
		private LancNeo.dsConcreto dsConcreto1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcreto;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepCorrelacion;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDACorrelacion;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsCorrelacion dsCorrelacion1;
		private LancNeo.CryRepCorrelacion cryRepCorrelacion1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtDia;
		private LancNeo.dsDiametro dsDiametro1;
		private System.Data.SqlClient.SqlDataAdapter sqlDADiametro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Data.SqlClient.SqlDataAdapter sqlDARes;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private System.Windows.Forms.Label label6;
		private LancNeo.dsBusResistencia dsBusResistencia1;
		private System.Windows.Forms.ComboBox cmbRes;
		private LancNeo.dsDiametro dsDiametro2;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private LancNeo.dsGraCorrela dsGraCorrela1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private System.Windows.Forms.TextBox textBox1;
		private LancNeo.dsTipoPrueba dsTipoPrueba1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrueba;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsTipoPrueba dsTipoPrueba2;
		private System.Windows.Forms.ComboBox cmbPrueba;
		private System.Windows.Forms.ComboBox cmbPrueba1;
		private System.Windows.Forms.CheckBox chbLab;
		private DBGraphics memGraphics;

		public RepCorrelacionF()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepCorrelacionF));
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
            this.dsConcreto1 = new LancNeo.dsConcreto();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.cmbPrueba1 = new System.Windows.Forms.ComboBox();
            this.dsTipoPrueba2 = new LancNeo.dsTipoPrueba();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRes = new System.Windows.Forms.ComboBox();
            this.dsBusResistencia1 = new LancNeo.dsBusResistencia();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.dsDiametro1 = new LancNeo.dsDiametro();
            this.dsDiametro2 = new LancNeo.dsDiametro();
            this.sqlDAConcreto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.crvRepCorrelacion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDACorrelacion = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsCorrelacion1 = new LancNeo.dsCorrelacion();
            this.cryRepCorrelacion1 = new LancNeo.CryRepCorrelacion();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsGraCorrela1 = new LancNeo.dsGraCorrela();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sqlDAPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusResistencia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCorrelacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGraCorrela1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.sqlSelectCommand5.CommandText = "SELECT IdConcretera, Concretera, Direccion FROM Concretera";
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
            this.panel1.Controls.Add(this.cmbPrueba1);
            this.panel1.Controls.Add(this.cmbPrueba);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cbkPrefijo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbRes);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtDia);
            this.panel1.Controls.Add(this.label13);
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
            this.panel1.Size = new System.Drawing.Size(872, 80);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConcreto1.Muestras;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(232, 8);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsConcreto1
            // 
            this.dsConcreto1.DataSetName = "dsConcreto";
            this.dsConcreto1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcreto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(800, 8);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.Location = new System.Drawing.Point(10, 50);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(132, 24);
            this.chbLab.TabIndex = 77;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // cmbPrueba1
            // 
            this.cmbPrueba1.DataSource = this.dsTipoPrueba2.Tipoprueba;
            this.cmbPrueba1.DisplayMember = "Prueba";
            this.cmbPrueba1.Location = new System.Drawing.Point(584, 52);
            this.cmbPrueba1.Name = "cmbPrueba1";
            this.cmbPrueba1.Size = new System.Drawing.Size(80, 21);
            this.cmbPrueba1.TabIndex = 75;
            this.cmbPrueba1.ValueMember = "IdPrueba";
            // 
            // dsTipoPrueba2
            // 
            this.dsTipoPrueba2.DataSetName = "dsTipoPrueba";
            this.dsTipoPrueba2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipoPrueba2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(584, 27);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(80, 21);
            this.cmbPrueba.TabIndex = 74;
            this.cmbPrueba.ValueMember = "IdPrueba";
            // 
            // dsTipoPrueba1
            // 
            this.dsTipoPrueba1.DataSetName = "dsTipoPrueba";
            this.dsTipoPrueba1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipoPrueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 73;
            this.textBox1.Text = "textBox1";
            this.textBox1.Visible = false;
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(10, 24);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 41;
            this.cbkPrefijo.Text = "No prefijo";
            this.cbkPrefijo.CheckedChanged += new System.EventHandler(this.cbkPrefijo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Resistencia:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbRes
            // 
            this.cmbRes.DataSource = this.dsBusResistencia1.Resistencia;
            this.cmbRes.DisplayMember = "Resistencia";
            this.cmbRes.Location = new System.Drawing.Point(728, 4);
            this.cmbRes.Name = "cmbRes";
            this.cmbRes.Size = new System.Drawing.Size(64, 21);
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
            this.label11.Location = new System.Drawing.Point(532, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Prueba:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Prueba:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(584, 4);
            this.txtDia.MaxLength = 2;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(68, 20);
            this.txtDia.TabIndex = 34;
            this.txtDia.Text = "28";
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(552, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Dia:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(432, 52);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(84, 21);
            this.cmbUnidad.TabIndex = 10;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(432, 28);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(432, 4);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBuscaObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(144, 30);
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
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correlación de pruebas";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(296, 6);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(240, 16);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // dsDiametro1
            // 
            this.dsDiametro1.DataSetName = "dsDiametro";
            this.dsDiametro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDiametro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDiametro2
            // 
            this.dsDiametro2.DataSetName = "dsDiametro";
            this.dsDiametro2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDiametro2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // crvRepCorrelacion
            // 
            this.crvRepCorrelacion.ActiveViewIndex = -1;
            this.crvRepCorrelacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepCorrelacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepCorrelacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepCorrelacion.EnableRefresh = false;
            this.crvRepCorrelacion.Location = new System.Drawing.Point(0, 80);
            this.crvRepCorrelacion.Name = "crvRepCorrelacion";
            this.crvRepCorrelacion.ShowCloseButton = false;
            this.crvRepCorrelacion.ShowGroupTreeButton = false;
            this.crvRepCorrelacion.ShowLogo = false;
            this.crvRepCorrelacion.ShowRefreshButton = false;
            this.crvRepCorrelacion.Size = new System.Drawing.Size(872, 669);
            this.crvRepCorrelacion.TabIndex = 11;
            this.crvRepCorrelacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // sqlDACorrelacion
            // 
            this.sqlDACorrelacion.SelectCommand = this.sqlSelectCommand3;
            this.sqlDACorrelacion.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Correlacion", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("ee1", "ee1"),
                        new System.Data.Common.DataColumnMapping("ee2", "ee2")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "[CorrelacionF]";
            this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@dia", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@IdPrueba1", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdPrueba2", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // dsCorrelacion1
            // 
            this.dsCorrelacion1.DataSetName = "dsCorrelacion";
            this.dsCorrelacion1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsCorrelacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlSelectCommand9.CommandText = "SELECT IdDiam, Diametro FROM Diametro";
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
            // dsGraCorrela1
            // 
            this.dsGraCorrela1.DataSetName = "dsGraCorrela";
            this.dsGraCorrela1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsGraCorrela1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 392);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
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
            // RepCorrelacionF
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(872, 749);
            this.Controls.Add(this.crvRepCorrelacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RepCorrelacionF";
            this.Text = "RepCorrelacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepCorrelacionF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusResistencia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCorrelacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGraCorrela1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		protected GraphPane myPane;

		private void RepCorrelacionF_Load(object sender, System.EventArgs e)
		{

			sqlDABusObra.Fill(dsBuscaObra1, "Obra");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			dsBusResistencia1.Resistencia.AddResistenciaRow(-1,"Todas");
			sqlDARes.Fill(dsBusResistencia1, "Resistencia");
			cmbRes.SelectedIndex = 0;
			sqlDAPrueba.Fill(dsTipoPrueba1, "Tipoprueba");
			sqlDAPrueba.Fill(dsTipoPrueba2, "Tipoprueba");
			cmbPrueba.SelectedIndex = 0;
			cmbPrueba1.SelectedIndex = 1;

//			dsConcretera1.Concretera.AddConcreteraRow("%","Todas","%");
//			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
//			cmbConcretera.SelectedIndex = 0;
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsConcreto1.Clear();
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
			sqlDAConcreto.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAConcreto.Fill(dsConcreto1, "Muestras");
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			cbkPrefijo.Checked = true;
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			btnVistaPrevia.Visible = true;
			cmbRes.SelectedItem = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{

			try
			{
                crvRepCorrelacion.Visible = true;
                cryRepCorrelacion1.SetDataSource(dsGraCorrela1);				
                
                int tipo = 1;
				switch(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString())       
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
				
				dsCorrelacion1.Clear();
				sqlDACorrelacion.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
				sqlDACorrelacion.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
				sqlDACorrelacion.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
				sqlDACorrelacion.SelectCommand.Parameters["@ResistenciaKg"].Value = cmbRes.SelectedValue;
				sqlDACorrelacion.SelectCommand.Parameters["@Tipo"].Value = tipo;
				sqlDACorrelacion.SelectCommand.Parameters["@IdAgregado"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString() == "Normal" ? 1 : 2);
				sqlDACorrelacion.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
				sqlDACorrelacion.SelectCommand.Parameters["@dia"].Value = txtDia.Text;
				sqlDACorrelacion.SelectCommand.Parameters["@IdPrueba1"].Value = cmbPrueba.SelectedValue;
				sqlDACorrelacion.SelectCommand.Parameters["@IdPrueba2"].Value = cmbPrueba1.SelectedValue;
				sqlDACorrelacion.Fill(dsCorrelacion1, "Correlacion");
				double conversion = double.Parse(dsUnidad1.Unidad.Rows[cmbUnidad.SelectedIndex][2].ToString());
				double sxy = 0;
				double sy = 0;
				double sy2 = 0;
				double m = 0;
				double b = 0;
				double r = 0;
				double lm = 0;
				double lb = 0;
				double lr = 0;
				double l10 = 0;
				double l8 = 0;
				double l7 = 0;
				double l6 = 0;
				double l4 = 0;
				int i = 0;
				for( i = 0; i < dsCorrelacion1.Correlacion.Rows.Count; i++)
				{
					sxy += double.Parse(dsCorrelacion1.Tables[0].Rows[i][9].ToString());
					sy  += double.Parse(dsCorrelacion1.Tables[0].Rows[i][5].ToString());
					sy2 += Math.Pow(double.Parse(dsCorrelacion1.Tables[0].Rows[i][5].ToString()),2);
					l10 += double.Parse(dsCorrelacion1.Tables[0].Rows[i][10].ToString());
					l4 += double.Parse(dsCorrelacion1.Tables[0].Rows[i][4].ToString());
					l6 += double.Parse(dsCorrelacion1.Tables[0].Rows[i][6].ToString());
					l8 += double.Parse(dsCorrelacion1.Tables[0].Rows[i][8].ToString()); 
					l7 += double.Parse(dsCorrelacion1.Tables[0].Rows[i][7].ToString()); 
				}
				m = ((i*sxy)-(l4*sy))/((i*l8)-(l4*l4));
				b = double.Parse(dsCorrelacion1.Tables[0].Rows[0][16].ToString()) - (m * double.Parse(dsCorrelacion1.Tables[0].Rows[0][15].ToString()));
				r = ( (b*sy) + (m*sxy) - (i*
					(double.Parse(dsCorrelacion1.Tables[0].Rows[0][16].ToString())
					*double.Parse(dsCorrelacion1.Tables[0].Rows[0][16].ToString()))))
					/(sy2-(i*(double.Parse(dsCorrelacion1.Tables[0].Rows[0][16].ToString())
					*double.Parse(dsCorrelacion1.Tables[0].Rows[0][16].ToString())))); 

				lm = ((i*l10)-(l4*l6))/((i*l8)-(l4*l4));
				lb = ((l6*l8)-(l4*l10))/((i*l8)-(l4*l4));
				lr = ( (lb*l6) + (lm*l10) - (i*
					(double.Parse(dsCorrelacion1.Tables[0].Rows[0][14].ToString())
					*double.Parse(dsCorrelacion1.Tables[0].Rows[0][14].ToString()))))
					/(l7-(i*(double.Parse(dsCorrelacion1.Tables[0].Rows[0][14].ToString())
					*double.Parse(dsCorrelacion1.Tables[0].Rows[0][14].ToString())))); 
				
				memGraphics.CreateDoubleBuffer(this.CreateGraphics(),
					this.ClientRectangle.Width, this.ClientRectangle.Height);

				myPane = new GraphPane( new Rectangle( 10, 10, 10, 10 ),
					"Correlación de resistencias",
					"Prueba de " + cmbPrueba.Text,
					"Prueba de " + cmbPrueba1.Text );
				SetSize();

				double[] xa = new double[i];
				double[] ya = new double[i];
				double[] wa = new double[i];
				double[] za = new double[i];
				double min = 1000;
				double max = 0;
				double minx = 1000;
				double maxx = 0;
				double miny = 1000;
				double maxy = 0;

				for( int j = 0; j < i; j++)
				{
					xa[j] = double.Parse(dsCorrelacion1.Tables[0].Rows[j][4].ToString());
					ya[j] = double.Parse(dsCorrelacion1.Tables[0].Rows[j][5].ToString());
					wa[j] = (m * xa[j]) + b;
					za[j] = Math.Pow(10,((lm*xa[j])+lb));
					minx = (minx > xa[j] ? xa[j] : minx);
					maxx = (maxx < xa[j] ? xa[j] : maxx);
					miny = (miny > ya[j] ? ya[j] : miny);
					maxy = (maxy < ya[j] ? ya[j] : maxy);
					min = (min > wa[j] ? wa[j] : min);
					max = (max < wa[j] ? wa[j] : max);
					min = (min > za[j] ? za[j] : min);
					max = (max < za[j] ? za[j] : max);
				}

				maxx = (maxx < (50 * conversion) ? (50 * conversion) : maxx);
				maxx = (Math.Ceiling(maxx/(50*conversion))) * (50 * conversion);
				minx = (Math.Floor(minx/(50 * conversion))) * (50 * conversion);
				minx = (minx < 0 ? 0 : minx);

				maxy = (maxy < (50 * conversion) ? (50 * conversion) : maxy);
				maxy = (Math.Ceiling(maxy/(50*conversion))) * (50 * conversion);
				miny = (Math.Floor(miny/(50 * conversion))) * (50 * conversion);
				miny = (miny < 0 ? 0 : miny);

//				if( max < 20)
//					max = (max < 20 ? 20 : max);
//				else
				{
					max = (max < (50 * conversion) ? (50 * conversion) : max);
					max = (Math.Ceiling(max/(50*conversion))) * (50 * conversion);
				}
				min = (Math.Floor(min/(50 * conversion))) * (50 * conversion);
				min = (min < 0 ? 0 : min);

				CurveItem curve;

				curve = myPane.AddCurve( "Lineal", xa, wa, Color.Gray, SymbolType.Empty );
				curve.Line.Width = 2.0F;
				curve.Symbol.Fill = new Fill( Color.White );
				curve.Symbol.IsVisible = false;

				curve = myPane.AddCurve( "Observaciones", xa, ya, Color.White, SymbolType.Circle );
				curve.Line.Width = 1.5F;
				curve.Symbol.Fill = new Fill( Color.Green );
				curve.Symbol.Size = 8;

				curve = myPane.AddCurve( "Semilogaritimica", xa, za, Color.RoyalBlue,SymbolType.Empty);
				curve.Line.Width = 2.0F;
				curve.Symbol.Fill = new Fill( Color.White );
				curve.Symbol.IsVisible = false;
				curve.Line.IsSmooth = true;

				myPane.XAxis.IsShowGrid = true;
				myPane.XAxis.ScaleFontSpec.Angle = 0;
				myPane.XAxis.Min = minx;
				myPane.XAxis.Max = maxx;
				myPane.YAxis.IsShowGrid = true;
				myPane.YAxis.ScaleFontSpec.Angle = 90;
				myPane.YAxis.Min = miny;
				myPane.YAxis.Max = maxy;
				myPane.Legend.IsVisible = false;
				myPane.PaneFill = new Fill( Color.White, Color.White, 0F );

				myPane.AxisChange( this.CreateGraphics() );
				string archivo = Directory.GetCurrentDirectory() + "\\correla.bmp";
				File.Delete(archivo);
				myPane.Image.Save(archivo, myPane.Image.RawFormat);
				pictureBox1.Image = Image.FromFile(archivo);
				MemoryStream ms = new MemoryStream();
				pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
				byte[] arrImage = ms.GetBuffer();
				ms.Close();
				myPane.Image.Dispose();
				pictureBox1.Image.Dispose();
				dsGraCorrela1.Clear();
				dsGraCorrela1.Grafica.AddGraficaRow(arrImage);

				string acotacion = "";
				double acota = double.Parse(cmbRes.Text == "Todas" ? "1" : System.Convert.ToString(Double.Parse(cmbRes.Text) * conversion));
				if(cmbUnidad.SelectedValue.ToString() == "2")
					acotacion = acota.ToString("####.00");
				else
					acotacion = acota.ToString("####");

				cryRepCorrelacion1.SetParameterValue("@fi", dtpIni.Text);
				cryRepCorrelacion1.SetParameterValue("@ff", dtpFin.Text);
				cryRepCorrelacion1.SetParameterValue("@Tipo", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString());
				cryRepCorrelacion1.SetParameterValue("@Agregado", dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString());
				cryRepCorrelacion1.SetParameterValue("@Constructora", (cmbIdObra.SelectedValue.ToString() == "Todas" ? " " : dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString()));
				cryRepCorrelacion1.SetParameterValue("@IdObra", txtIdobra.Text);
				cryRepCorrelacion1.SetParameterValue("@Zona", (cmbIdObra.SelectedValue.ToString() == "Todas" ? " " : dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString()));
				cryRepCorrelacion1.SetParameterValue("@resistencia",  (cmbRes.Text == "Todas" ? "Todas" : acotacion));
				cryRepCorrelacion1.SetParameterValue("@Unidad", cmbUnidad.Text);
				cryRepCorrelacion1.SetParameterValue("@r", r );
				cryRepCorrelacion1.SetParameterValue("@m", m);
				cryRepCorrelacion1.SetParameterValue("@b", b);
				cryRepCorrelacion1.SetParameterValue("@lr", lr);
				cryRepCorrelacion1.SetParameterValue("@lm", lm);
				cryRepCorrelacion1.SetParameterValue("@lb", lb);
				cryRepCorrelacion1.SetParameterValue("@Uni", cmbUnidad.SelectedIndex);
				cryRepCorrelacion1.SetParameterValue("@Direccion", (cmbIdObra.SelectedValue.ToString() == "Todas" ? " " : dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString()));
				cryRepCorrelacion1.SetParameterValue("@Lab", chbLab.Checked);

				
				crvRepCorrelacion.ReportSource = cryRepCorrelacion1;
			//	crvRepCorrelacion.RefreshReport();
			}
			catch(Exception ex)
			{
			
				MessageBox.Show(ex.Message );
			}

		}
		private void Form1_Resize(object sender, System.EventArgs e)
		{
			memGraphics.CreateDoubleBuffer(this.CreateGraphics(),
				this.ClientRectangle.Width, this.ClientRectangle.Height);
			SetSize();
			Invalidate();
		}

		private void SetSize()
		{
			Rectangle paneRect = this.ClientRectangle;
			paneRect.Inflate( -2, -1 );
			this.myPane.PaneRect = paneRect;
		}

		private void cbkPrefijo_CheckedChanged(object sender, System.EventArgs e)
		{
			if (cbkPrefijo.Checked == false)
				txtIdobra.Text = txtIdobra.Text.Substring(0,3)+"%";
			else
				txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

	}

}
