using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de RepAnalisisLab.
	/// </summary>
	public class RepAnalisisLab : System.Windows.Forms.Form
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
		private System.Data.SqlClient.SqlDataAdapter sqlDANoEco;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsBusNoEco dsBusNoEco1;
		private System.Windows.Forms.ComboBox cmbNoEco;
		private System.Windows.Forms.Label label6;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepAnalisis;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAnalisis;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbIdLaboratorio;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorio;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private LancNeo.dsAnalisisLa dsAnalisisLa1;
		private LancNeo.dsBusLab dsBusLab1;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		private LancNeo.CryRepAnalisisLa cryRepAnalisisLa1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbMuestreador;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmbMezcla;
		private LancNeo.dsBusResistencia dsBusResistencia1;
		private System.Data.SqlClient.SqlDataAdapter sqlDARes;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cmbRes;
        private dsDiametro dsDiametro1;
        private System.Data.SqlClient.SqlDataAdapter sqlDADiametro;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private Label label13;
        private ComboBox cmdDiametro;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RepAnalisisLab()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			ArrayList Mezcla =new ArrayList();
			Mezcla.Add(new matCombo("Concreto",1));
			Mezcla.Add(new matCombo("Mortero",2));
			cmbMezcla.DataSource = Mezcla; //DataSource for lookup table 
			cmbMezcla.DisplayMember = "getName"; //Display value in lookup table
			cmbMezcla.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}
		protected struct matCombo
		{
			private string Descripcion;
			private int Identificador;
			public matCombo(string Nombre , int id)
			{
				Descripcion=Nombre;
				Identificador = id;
			}
			public string getName
			{
				get
				{
					return Descripcion;
				}
			}
			public int getId
			{
				get
				{
					return Identificador;
				}
			}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepAnalisisLab));
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
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.dsPlanta1 = new LancNeo.dsPlanta();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.cmdDiametro = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbRes = new System.Windows.Forms.ComboBox();
            this.dsBusResistencia1 = new LancNeo.dsBusResistencia();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbMezcla = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbMuestreador = new System.Windows.Forms.RadioButton();
            this.cmbIdLaboratorio = new System.Windows.Forms.ComboBox();
            this.dsBusLab1 = new LancNeo.dsBusLab();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbNoEco = new System.Windows.Forms.ComboBox();
            this.dsBusNoEco1 = new LancNeo.dsBusNoEco();
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
            this.sqlDANoEco = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.crvRepAnalisis = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAAnalisis = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDALaboratorio = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsAnalisisLa1 = new LancNeo.dsAnalisisLa();
            this.cryRepAnalisisLa1 = new LancNeo.CryRepAnalisisLa();
            this.sqlDARes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsDiametro1 = new LancNeo.dsDiametro();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusResistencia1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusLab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNoEco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalisisLa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
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
            this.panel1.Controls.Add(this.cmdDiametro);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbRes);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmbMezcla);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cmbIdLaboratorio);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbNoEco);
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 78);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(929, 6);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 37;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // cmdDiametro
            // 
            this.cmdDiametro.DataSource = this.dsDiametro1;
            this.cmdDiametro.DisplayMember = "Diametro.Diametro";
            this.cmdDiametro.FormattingEnabled = true;
            this.cmdDiametro.Location = new System.Drawing.Point(838, 52);
            this.cmdDiametro.Name = "cmdDiametro";
            this.cmdDiametro.Size = new System.Drawing.Size(85, 21);
            this.cmdDiametro.TabIndex = 46;
            this.cmdDiametro.ValueMember = "Diametro.IdDiam";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(783, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Diámetro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(770, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Resistencia:";
            // 
            // cmbRes
            // 
            this.cmbRes.DataSource = this.dsBusResistencia1.Resistencia;
            this.cmbRes.DisplayMember = "Resistencia";
            this.cmbRes.Location = new System.Drawing.Point(838, 28);
            this.cmbRes.Name = "cmbRes";
            this.cmbRes.Size = new System.Drawing.Size(68, 21);
            this.cmbRes.TabIndex = 43;
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
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(790, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Mezcla:";
            // 
            // cmbMezcla
            // 
            this.cmbMezcla.Location = new System.Drawing.Point(838, 4);
            this.cmbMezcla.Name = "cmbMezcla";
            this.cmbMezcla.Size = new System.Drawing.Size(68, 21);
            this.cmbMezcla.TabIndex = 41;
            this.cmbMezcla.Text = "cmbMezcla";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rdbMuestreador);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(458, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 46);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nivel";
            // 
            // radioButton1
            // 
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(94, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Ensayista";
            // 
            // rdbMuestreador
            // 
            this.rdbMuestreador.Checked = true;
            this.rdbMuestreador.ForeColor = System.Drawing.Color.White;
            this.rdbMuestreador.Location = new System.Drawing.Point(6, 18);
            this.rdbMuestreador.Name = "rdbMuestreador";
            this.rdbMuestreador.Size = new System.Drawing.Size(86, 24);
            this.rdbMuestreador.TabIndex = 0;
            this.rdbMuestreador.TabStop = true;
            this.rdbMuestreador.Text = "Muestreador";
            // 
            // cmbIdLaboratorio
            // 
            this.cmbIdLaboratorio.DataSource = this.dsBusLab1.Laboratorio;
            this.cmbIdLaboratorio.DisplayMember = "IdLaboratorio";
            this.cmbIdLaboratorio.Location = new System.Drawing.Point(222, 30);
            this.cmbIdLaboratorio.Name = "cmbIdLaboratorio";
            this.cmbIdLaboratorio.Size = new System.Drawing.Size(228, 21);
            this.cmbIdLaboratorio.TabIndex = 39;
            this.cmbIdLaboratorio.ValueMember = "IdLaboratorio";
            // 
            // dsBusLab1
            // 
            this.dsBusLab1.DataSetName = "dsBusLab";
            this.dsBusLab1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusLab1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(154, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Laboratorio:";
            // 
            // cmbNoEco
            // 
            this.cmbNoEco.DataSource = this.dsBusNoEco1.Laboratorista;
            this.cmbNoEco.DisplayMember = "Laboratorista";
            this.cmbNoEco.Location = new System.Drawing.Point(222, 54);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(178, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "NoEco:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(644, 30);
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
            this.label8.Location = new System.Drawing.Point(620, 6);
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
            this.cmbPrueba.Location = new System.Drawing.Point(50, 54);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(86, 21);
            this.cmbPrueba.TabIndex = 11;
            this.cmbPrueba.ValueMember = "IdPrueba";
            this.cmbPrueba.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Prueba:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Visible = false;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(686, 52);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(84, 21);
            this.cmbUnidad.TabIndex = 10;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(640, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(528, 2);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(500, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(412, 2);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(380, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBuscaObra1.Obra;
            this.cmbIdObra.DisplayMember = "Ubicacion";
            this.cmbIdObra.Location = new System.Drawing.Point(50, 30);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(86, 21);
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
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coeficiente de ensayes";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(276, 4);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbConcretera.DisplayMember = "Concretera";
            this.cmbConcretera.Location = new System.Drawing.Point(686, 4);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(84, 21);
            this.cmbConcretera.TabIndex = 5;
            this.cmbConcretera.ValueMember = "IdConcretera";
            this.cmbConcretera.SelectedIndexChanged += new System.EventHandler(this.cmbConcretera_SelectedIndexChanged);
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DataSource = this.dsPlanta1.Planta;
            this.cmbPlanta.DisplayMember = "IdPlanta";
            this.cmbPlanta.Location = new System.Drawing.Point(686, 28);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(84, 21);
            this.cmbPlanta.TabIndex = 6;
            this.cmbPlanta.ValueMember = "IdPlanta";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(60, 32);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(54, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
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
            this.sqlSelectCommand3.CommandText = "SELECT NoEco, LTRIM(RTRIM(STR(NoEco))) + \' \' + Laboratorista AS Laboratorista FRO" +
    "M Laboratorista ORDER BY STR(NoEco) + \' \' + Laboratorista";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // crvRepAnalisis
            // 
            this.crvRepAnalisis.ActiveViewIndex = -1;
            this.crvRepAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepAnalisis.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepAnalisis.DisplayStatusBar = false;
            this.crvRepAnalisis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepAnalisis.EnableRefresh = false;
            this.crvRepAnalisis.Location = new System.Drawing.Point(0, 78);
            this.crvRepAnalisis.Name = "crvRepAnalisis";
            this.crvRepAnalisis.ShowCloseButton = false;
            this.crvRepAnalisis.ShowGroupTreeButton = false;
            this.crvRepAnalisis.ShowLogo = false;
            this.crvRepAnalisis.ShowRefreshButton = false;
            this.crvRepAnalisis.ShowTextSearchButton = false;
            this.crvRepAnalisis.Size = new System.Drawing.Size(1000, 672);
            this.crvRepAnalisis.TabIndex = 11;
            this.crvRepAnalisis.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.sqlSelectCommand4.CommandText = "[AnalisisLab]";
            this.sqlSelectCommand4.CommandTimeout = 180;
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Mezcla", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Resistencia", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 2)});
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
            this.sqlCommand2.CommandText = "SELECT DISTINCT IdLaboratorio, Laboratorio, IdLaboratorio + \'   \' + Laboratorio A" +
    "S Expr1, IdZona\r\nFROM         Laboratorio\r\nORDER BY IdLaboratorio";
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // dsAnalisisLa1
            // 
            this.dsAnalisisLa1.DataSetName = "dsAnalisisLa";
            this.dsAnalisisLa1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAnalisisLa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dsDiametro1
            // 
            this.dsDiametro1.DataSetName = "dsDiametro";
            this.dsDiametro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDiametro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDADiametro
            // 
            this.sqlDADiametro.SelectCommand = this.sqlCommand3;
            this.sqlDADiametro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Diametro", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdDiam", "IdDiam"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT     IdDiam, Diametro + \' \' + Figura AS Diametro, Figura\r\nFROM         Diam" +
    "etro\r\nORDER BY IdDiam";
            this.sqlCommand3.Connection = this.sqlConn;
            // 
            // RepAnalisisLab
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.crvRepAnalisis);
            this.Controls.Add(this.panel1);
            this.Name = "RepAnalisisLab";
            this.Text = "RepAnalisis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepAnalisisLab_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusResistencia1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsBusLab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNoEco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalisisLa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void RepAnalisisLab_Load(object sender, System.EventArgs e)
		{
//			dsBuscaObra1.Obra.AddObraRow("%","Todas"," ", " ", " ", " ");
			sqlDABusObra.Fill(dsBuscaObra1, "Obra");
			cmbIdObra.SelectedIndex = 0;
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
			dsConcretera1.Concretera.AddConcreteraRow("%","Todas","%");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			cmbConcretera.SelectedIndex = 0;
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",cmbConcretera.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
			dsBusNoEco1.Laboratorista.AddLaboratoristaRow(-1,"Todos");
			sqlDANoEco.Fill(dsBusNoEco1, "Laboratorista");
			cmbNoEco.SelectedIndex = 0;
			dsBusLab1.Laboratorio.AddLaboratorioRow("%","Todos"," ");
			sqlDALaboratorio.Fill(dsBusLab1, "Laboratorio");
			cmbMezcla.SelectedIndex = 0;
            dsDiametro1.Diametro.AddDiametroRow(-1, "Todos", "");
            sqlDADiametro.Fill(dsDiametro1, "Diametro");
            cmdDiametro.SelectedIndex = 0;
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			btnVistaPrevia.Visible = true;
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			try
				{
				dsAnalisisLa1.Clear();
				sqlDAAnalisis.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
				sqlDAAnalisis.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString() ;
				sqlDAAnalisis.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
				sqlDAAnalisis.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
				sqlDAAnalisis.SelectCommand.Parameters["@IdPrueba"].Value = cmbPrueba.SelectedValue.ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@NoEco"].Value    = cmbNoEco.SelectedValue.ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@IdLaboratorio"].Value = cmbIdLaboratorio.SelectedValue.ToString();
				sqlDAAnalisis.SelectCommand.Parameters["@Nivel"].Value = (rdbMuestreador.Checked == true ? 1 : 2) ;
				sqlDAAnalisis.SelectCommand.Parameters["@Mezcla"].Value = cmbMezcla.SelectedValue ;
				sqlDAAnalisis.SelectCommand.Parameters["@Resistencia"].Value = cmbRes.SelectedValue ;
                sqlDAAnalisis.SelectCommand.Parameters["@IdDiam"].Value = cmdDiametro.SelectedValue;
                sqlDAAnalisis.Fill(dsAnalisisLa1, "Analisis");


				crvRepAnalisis.Visible = true;
				cryRepAnalisisLa1.SetDataSource(dsAnalisisLa1);
                cryRepAnalisisLa1.SetParameterValue("@Con", cmbConcretera.Text);
                cryRepAnalisisLa1.SetParameterValue("@Pla", cmbPlanta.Text);
                cryRepAnalisisLa1.SetParameterValue("@Lab", cmbNoEco.Text);
                cryRepAnalisisLa1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                cryRepAnalisisLa1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                cryRepAnalisisLa1.SetParameterValue("@Obr", txtIdobra.Text);
                cryRepAnalisisLa1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                cryRepAnalisisLa1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
                cryRepAnalisisLa1.SetParameterValue("@Unidad", cmbUnidad.Text);
                cryRepAnalisisLa1.SetParameterValue("@Laboratorio", cmbIdLaboratorio.SelectedValue.ToString());
                cryRepAnalisisLa1.SetParameterValue("@Fini", dtpIni.Text);
                cryRepAnalisisLa1.SetParameterValue("@Ffin", dtpFin.Text);
                cryRepAnalisisLa1.SetParameterValue("@Resistencia", cmbRes.Text);
                cryRepAnalisisLa1.SetParameterValue("@Nivel", rdbMuestreador.Checked ? "Muestreador" : "Ensayista");
                cryRepAnalisisLa1.SetParameterValue("Diametro", cmdDiametro.Text);
			
                crvRepAnalisis.ReportSource = cryRepAnalisisLa1;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void RepAnalisisLab_Load_1(object sender, System.EventArgs e)
		{
			dsBuscaObra1.Clear();
			dsBuscaObra1.Obra.AddObraRow("%","Todas"," ", " ", " ", " ");
			cmbIdObra.SelectedIndex = 0;
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			sqlDABusObra.Fill(dsBuscaObra1, "Obra");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
			dsConcretera1.Concretera.AddConcreteraRow("%","Todas","%");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			cmbConcretera.SelectedIndex = 0;
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",cmbConcretera.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
			dsBusNoEco1.Laboratorista.AddLaboratoristaRow(-1,"Todos");
			sqlDANoEco.Fill(dsBusNoEco1, "Laboratorista");
			cmbNoEco.SelectedIndex = 0;
			dsBusLab1.Laboratorio.AddLaboratorioRow("%","Todos"," ");
			sqlDALaboratorio.Fill(dsBusLab1, "Laboratorio");
			cmbIdLaboratorio.SelectedIndex = 0;
			dsBusResistencia1.Resistencia.AddResistenciaRow(-1,"Todas");
			sqlDARes.Fill(dsBusResistencia1, "Resistencia");
			cmbRes.SelectedIndex = 0;
            dsDiametro1.Diametro.AddDiametroRow(-1, "Todos", " ");
            sqlDADiametro.Fill(dsDiametro1,"Diametro");
            cmdDiametro.SelectedIndex = 0;
		}

		private void cmbConcretera_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cmbPlanta.Visible = true;
			dsPlanta1.Clear();
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",cmbConcretera.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
			cmbPlanta.SelectedIndex = 0;
		}
	}
}
