using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de RepPromedios.
	/// </summary>
	public class RepPromedios : System.Windows.Forms.Form
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
		private System.Windows.Forms.ComboBox cmbConcretera;
		private System.Windows.Forms.ComboBox cmbPlanta;
		private LancNeo.dsConcreto dsConcreto1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcreto;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepPromedios;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPromedios;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsPromedios dsPromedios1;
		private LancNeo.CryRepPromedios cryRepPromedios1;
		private LancNeo.dsMuestra dsMuestra1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private LancNeo.dsDiametro dsDiametro1;
		private System.Data.SqlClient.SqlDataAdapter sqlDADiametro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
		private System.Windows.Forms.ComboBox cmbIdDiam;
		private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chbLab;
        private System.Data.SqlClient.SqlDataAdapter sqlDATipo;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand11;
        private dsTipo dsTipo1;
        private ComboBox cmbTipo;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RepPromedios()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepPromedios));
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
            this.cmbIdDiam = new System.Windows.Forms.ComboBox();
            this.dsDiametro1 = new LancNeo.dsDiametro();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
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
            this.crvRepPromedios = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAPromedios = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsPromedios1 = new LancNeo.dsPromedios();
            this.cryRepPromedios1 = new LancNeo.CryRepPromedios();
            this.dsMuestra1 = new LancNeo.dsMuestra();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATipo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand11 = new System.Data.SqlClient.SqlCommand();
            this.dsTipo1 = new LancNeo.dsTipo();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPromedios1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMuestra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).BeginInit();
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
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.cmbIdDiam);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cbkPrefijo);
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
            this.panel1.Size = new System.Drawing.Size(1046, 78);
            this.panel1.TabIndex = 10;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConcreto1.Muestras;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(360, 0);
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
            this.btnVistaPrevia.Location = new System.Drawing.Point(792, 8);
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
            this.chbLab.Location = new System.Drawing.Point(440, 52);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 24);
            this.chbLab.TabIndex = 77;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // cmbIdDiam
            // 
            this.cmbIdDiam.DataSource = this.dsDiametro1;
            this.cmbIdDiam.DisplayMember = "Diametro.Figura";
            this.cmbIdDiam.Location = new System.Drawing.Point(224, 28);
            this.cmbIdDiam.Name = "cmbIdDiam";
            this.cmbIdDiam.Size = new System.Drawing.Size(128, 21);
            this.cmbIdDiam.TabIndex = 76;
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
            this.label14.Location = new System.Drawing.Point(144, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "F. geométrica:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 74;
            this.textBox1.Text = "textBox1";
            this.textBox1.Visible = false;
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(112, 48);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 73;
            this.cbkPrefijo.Text = "No prefijo";
            this.cbkPrefijo.CheckedChanged += new System.EventHandler(this.cbkPrefijo_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(672, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Planta:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 6);
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
            this.cmbUnidad.Location = new System.Drawing.Point(696, 52);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(84, 21);
            this.cmbUnidad.TabIndex = 10;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(560, 28);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(560, 4);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBuscaObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(224, 4);
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
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Análisis promedios";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(424, 6);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbConcretera.DisplayMember = "Concretera";
            this.cmbConcretera.Location = new System.Drawing.Point(712, 4);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(68, 21);
            this.cmbConcretera.TabIndex = 5;
            this.cmbConcretera.ValueMember = "IdConcretera";
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DataSource = this.dsPlanta1.Planta;
            this.cmbPlanta.DisplayMember = "Planta";
            this.cmbPlanta.Enabled = false;
            this.cmbPlanta.Location = new System.Drawing.Point(712, 28);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(68, 21);
            this.cmbPlanta.TabIndex = 6;
            this.cmbPlanta.ValueMember = "IdPlanta";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(368, 24);
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
            // crvRepPromedios
            // 
            this.crvRepPromedios.ActiveViewIndex = -1;
            this.crvRepPromedios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepPromedios.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepPromedios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepPromedios.EnableRefresh = false;
            this.crvRepPromedios.Location = new System.Drawing.Point(0, 78);
            this.crvRepPromedios.Name = "crvRepPromedios";
            this.crvRepPromedios.ShowCloseButton = false;
            this.crvRepPromedios.ShowGroupTreeButton = false;
            this.crvRepPromedios.ShowLogo = false;
            this.crvRepPromedios.ShowRefreshButton = false;
            this.crvRepPromedios.Size = new System.Drawing.Size(1046, 670);
            this.crvRepPromedios.TabIndex = 11;
            this.crvRepPromedios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepPromedios.ToolPanelWidth = 167;
            // 
            // sqlDAPromedios
            // 
            this.sqlDAPromedios.SelectCommand = this.sqlSelectCommand2;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "[Promedios]";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
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
            // dsPromedios1
            // 
            this.dsPromedios1.DataSetName = "dsPromedios";
            this.dsPromedios1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsPromedios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMuestra1
            // 
            this.dsMuestra1.DataSetName = "dsMuestra";
            this.dsMuestra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsMuestra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlDATipo
            // 
            this.sqlDATipo.SelectCommand = this.sqlSelectCommand11;
            this.sqlDATipo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("DesTipo", "DesTipo")})});
            // 
            // sqlSelectCommand11
            // 
            this.sqlSelectCommand11.CommandText = "SELECT Tipo, DesTipo FROM Tipo ORDER BY Tipo";
            this.sqlSelectCommand11.Connection = this.sqlConn;
            // 
            // dsTipo1
            // 
            this.dsTipo1.DataSetName = "dsTipo";
            this.dsTipo1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataSource = this.dsTipo1;
            this.cmbTipo.DisplayMember = "Tipo.DesTipo";
            this.cmbTipo.Location = new System.Drawing.Point(560, 52);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(64, 21);
            this.cmbTipo.TabIndex = 78;
            this.cmbTipo.ValueMember = "Tipo.Tipo";
            // 
            // RepPromedios
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1046, 748);
            this.Controls.Add(this.crvRepPromedios);
            this.Controls.Add(this.panel1);
            this.Name = "RepPromedios";
            this.Text = "RepPromedios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepPromedios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPromedios1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMuestra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void RepPromedios_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsBuscaObra1, "Obra");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
            sqlDATipo.Fill(dsTipo1, "Tipo");
            dsConcretera1.Concretera.AddConcreteraRow("%", "Todas", "%");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			cmbConcretera.SelectedIndex = 0;
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",cmbConcretera.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
			sqlDADiametro.Fill(dsDiametro1,"Diametro");
			cmbIdDiam.SelectedIndex = 0;
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
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            cryRepPromedios1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            cryRepPromedios1.SetDataSource(dsPromedios1);				
            
            try
			{
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
				
				CrystalDecisions.Shared.ParameterDiscreteValue pdvUnidad = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvUnidad.Value = cmbUnidad.Text;
				CrystalDecisions.Shared.ParameterDiscreteValue pdvRes = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvRes.Value = float.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString()) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
				CrystalDecisions.Shared.ParameterDiscreteValue pdvTip = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvTip.Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString();
				CrystalDecisions.Shared.ParameterDiscreteValue pdvTma = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvTma.Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
				CrystalDecisions.Shared.ParameterDiscreteValue pdvRev = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvRev.Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString();
				CrystalDecisions.Shared.ParameterDiscreteValue pdvTag = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvTag.Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString();
				
				CrystalDecisions.Shared.ParameterDiscreteValue pdvCon = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvCon.Value = cmbConcretera.Text;
				CrystalDecisions.Shared.ParameterDiscreteValue pdvPla = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvPla.Value = cmbPlanta.Text;

				CrystalDecisions.Shared.ParameterDiscreteValue pdvCra = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvCra.Value = dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString();
				CrystalDecisions.Shared.ParameterDiscreteValue pdvObr = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvObr.Value = txtIdobra.Text;
				CrystalDecisions.Shared.ParameterDiscreteValue pdvZon = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvZon.Value = dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString();

				pvCollection.Clear();
				pvCollection.Add(pdvUnidad);
				cryRepPromedios1.DataDefinition.ParameterFields["@Unidad"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvRes);
				cryRepPromedios1.DataDefinition.ParameterFields["@Res"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvTip);
				cryRepPromedios1.DataDefinition.ParameterFields["@Tip"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvTma);
				cryRepPromedios1.DataDefinition.ParameterFields["@Tma"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvRev);
				cryRepPromedios1.DataDefinition.ParameterFields["@Rev"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvTag);
				cryRepPromedios1.DataDefinition.ParameterFields["@Tag"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvCon);
				cryRepPromedios1.DataDefinition.ParameterFields["@Con"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvPla);
				cryRepPromedios1.DataDefinition.ParameterFields["@Pla"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvCra);
				cryRepPromedios1.DataDefinition.ParameterFields["@Cra"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvObr);
				cryRepPromedios1.DataDefinition.ParameterFields["@Obr"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvZon);
				cryRepPromedios1.DataDefinition.ParameterFields["@Zon"].ApplyCurrentValues(pvCollection);
			
			}
			catch(Exception ex1)
			{
				MessageBox.Show("parametro" + ex1.Message );
			}
		
			
			try
				{
                for (int x = 0; x < cmbTipo.Items.Count; x++)
                {
                    if(dsTipo1.Tables[0].Rows[x][1].ToString() == dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString())
                        cmbTipo.SelectedIndex = x;   
                }
                    dsPromedios1.Clear();
				sqlDAPromedios.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
				sqlDAPromedios.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString() ;
				sqlDAPromedios.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
				sqlDAPromedios.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
				sqlDAPromedios.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
				sqlDAPromedios.SelectCommand.Parameters["@ResistenciaKg"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
                sqlDAPromedios.SelectCommand.Parameters["@Tipo"].Value = cmbTipo.SelectedValue;
				sqlDAPromedios.SelectCommand.Parameters["@Agregado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
				sqlDAPromedios.SelectCommand.Parameters["@Renvenimiento"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString();
				sqlDAPromedios.SelectCommand.Parameters["@IdAgregado"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString() == "Normal" ? 1 : 2);
				sqlDAPromedios.SelectCommand.Parameters["@IdPrueba"].Value = 1;
				sqlDAPromedios.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
				sqlDAPromedios.SelectCommand.Parameters["@Todos"].Value =true;
				sqlDAPromedios.SelectCommand.Parameters["@IdDiam"].Value = cmbIdDiam.SelectedValue.ToString();
				sqlDAPromedios.Fill(dsPromedios1, "Promedios");

				// Establece el valor actual de parameter1 en el subinforme en 10 
				float res = float.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString()) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                string Pdia = "3 días";
                string Sdia = "7 días";
                switch (int.Parse(cmbTipo.SelectedValue.ToString()))
                {
                    case 1:
                    case 2:
                        Pdia = "3 días";
                        Sdia = "7 días";
                        break;
                    case 6:
                    case 11:
                        Pdia = "1 día";
                        Sdia = "3 días";
                        break;
                    case 7:
                    case 12:
                        Pdia = " ";
                        Sdia = "1 día";
                        break;
                    case 8:
                    case 13:
                        Pdia = " ";
                        Sdia = " ";
                        break;
                    default:
                        Pdia = "3 días";
                        Sdia = "7 días";
                        break;
                }

				//Una forma mas facil de pasar un parametro a un reporte de crystal
				cryRepPromedios1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
				cryRepPromedios1.SetParameterValue("@Ubic", dsBuscaObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][1].ToString());
				cryRepPromedios1.SetParameterValue("@Diam", cmbIdDiam.SelectedValue.ToString());
                cryRepPromedios1.SetParameterValue("@Pdia", Pdia);
                cryRepPromedios1.SetParameterValue("@Sdia", Sdia);
                //cryRepPromedios1.SetParameterValue("@Lab", chbLab.Checked);

				crvRepPromedios.Visible = true;
				crvRepPromedios.ReportSource = cryRepPromedios1;
//				crvRepPromedios.RefreshReport();
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

	}
}
