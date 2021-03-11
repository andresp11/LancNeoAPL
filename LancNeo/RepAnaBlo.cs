using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de RepAnaBlo.
	/// </summary>
	public class RepAnaBlo : System.Windows.Forms.Form
	{
		private LancNeo.dsTipoPrueba dsTipoPrueba1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrueba;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsUnidad dsUnidad1;
		private System.Windows.Forms.Panel panel1;
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
		private System.Windows.Forms.TextBox txtEE;
		private System.Windows.Forms.TextBox txtA7;
		private System.Data.SqlClient.SqlDataAdapter sqlDATitulo;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Data.SqlClient.SqlDataAdapter sqlDATipo;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private LancNeo.dsTipoBlock dsTipoBlock1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Data.SqlClient.SqlDataAdapter sqlDAComo;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		private LancNeo.dsComo dsComo1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtLargo;
		private System.Windows.Forms.Label label16;
		private System.Data.SqlClient.SqlDataAdapter sqlDAGrado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand8;
		private System.Windows.Forms.TextBox txtAncho;
		private LancNeo.dsGradoBlock dsGradoBlock1;
		private System.Windows.Forms.TextBox txtPeralte;
		private System.Windows.Forms.ComboBox cmbComo;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.ComboBox cmbGrado;
		private LancNeo.dsAnalBlock dsAnalBlock1;
		private LancNeo.CryRepAnalBlock cryRepAnalBlock1;
		private System.Windows.Forms.CheckBox chbLab;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RepAnaBlo()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepAnaBlo));
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsConcreto1 = new LancNeo.dsConcreto();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.dsGradoBlock1 = new LancNeo.dsGradoBlock();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPeralte = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dsTipoBlock1 = new LancNeo.dsTipoBlock();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbComo = new System.Windows.Forms.ComboBox();
            this.dsComo1 = new LancNeo.dsComo();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEE = new System.Windows.Forms.TextBox();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.cmbNoEco = new System.Windows.Forms.ComboBox();
            this.dsBusNoEco1 = new LancNeo.dsBusNoEco();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtA7 = new System.Windows.Forms.TextBox();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.sqlDAConcreto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDANoEco = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.crvRepAnalisis = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAAnalisis = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATitulo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATipo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAComo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAGrado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
            this.dsAnalBlock1 = new LancNeo.dsAnalBlock();
            this.cryRepAnalBlock1 = new LancNeo.CryRepAnalBlock();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGradoBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNoEco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalBlock1)).BeginInit();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.cmbGrado);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtPeralte);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtAncho);
            this.panel1.Controls.Add(this.txtLargo);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbComo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtEE);
            this.panel1.Controls.Add(this.cbkPrefijo);
            this.panel1.Controls.Add(this.cmbNoEco);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtA7);
            this.panel1.Controls.Add(this.txtA3);
            this.panel1.Controls.Add(this.label6);
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
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 107);
            this.panel1.TabIndex = 10;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(783, 5);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 37;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConcreto1.Muestras;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(8, 52);
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
            // cmbGrado
            // 
            this.cmbGrado.DataSource = this.dsGradoBlock1;
            this.cmbGrado.DisplayMember = "TabiqueMdor.Grado";
            this.cmbGrado.Location = new System.Drawing.Point(458, 50);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(94, 21);
            this.cmbGrado.TabIndex = 51;
            this.cmbGrado.ValueMember = "TabiqueMdor.Grado";
            // 
            // dsGradoBlock1
            // 
            this.dsGradoBlock1.DataSetName = "dsGradoBlock";
            this.dsGradoBlock1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsGradoBlock1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(423, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Grado:";
            // 
            // txtPeralte
            // 
            this.txtPeralte.Location = new System.Drawing.Point(733, 49);
            this.txtPeralte.MaxLength = 5;
            this.txtPeralte.Name = "txtPeralte";
            this.txtPeralte.Size = new System.Drawing.Size(30, 20);
            this.txtPeralte.TabIndex = 47;
            this.txtPeralte.Text = "20";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(695, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Ancho:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(697, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Largo:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(692, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Peralte:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(733, 24);
            this.txtAncho.MaxLength = 5;
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(30, 20);
            this.txtAncho.TabIndex = 46;
            this.txtAncho.Text = "12";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(733, 2);
            this.txtLargo.MaxLength = 5;
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(30, 20);
            this.txtLargo.TabIndex = 45;
            this.txtLargo.Text = "40";
            this.txtLargo.TextChanged += new System.EventHandler(this.txtLargo_TextChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataSource = this.dsTipoBlock1;
            this.cmbTipo.DisplayMember = "TabiqueMdor.Tipo";
            this.cmbTipo.Location = new System.Drawing.Point(458, 24);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(94, 21);
            this.cmbTipo.TabIndex = 43;
            this.cmbTipo.ValueMember = "TabiqueMdor.Tipo";
            // 
            // dsTipoBlock1
            // 
            this.dsTipoBlock1.DataSetName = "dsTipoBlock";
            this.dsTipoBlock1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipoBlock1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Tipo:";
            // 
            // cmbComo
            // 
            this.cmbComo.DataSource = this.dsComo1;
            this.cmbComo.DisplayMember = "TabiqueMdor.Como";
            this.cmbComo.Location = new System.Drawing.Point(458, 2);
            this.cmbComo.Name = "cmbComo";
            this.cmbComo.Size = new System.Drawing.Size(94, 21);
            this.cmbComo.TabIndex = 41;
            this.cmbComo.ValueMember = "TabiqueMdor.Como";
            // 
            // dsComo1
            // 
            this.dsComo1.DataSetName = "dsComo";
            this.dsComo1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsComo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Como:";
            // 
            // txtEE
            // 
            this.txtEE.Location = new System.Drawing.Point(642, 49);
            this.txtEE.MaxLength = 5;
            this.txtEE.Name = "txtEE";
            this.txtEE.Size = new System.Drawing.Size(47, 20);
            this.txtEE.TabIndex = 29;
            this.txtEE.Text = "0";
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(8, 26);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 35;
            this.cbkPrefijo.Text = "No prefijo";
            this.cbkPrefijo.CheckedChanged += new System.EventHandler(this.cbkPrefijo_CheckedChanged);
            // 
            // cmbNoEco
            // 
            this.cmbNoEco.DataSource = this.dsBusNoEco1.Laboratorista;
            this.cmbNoEco.DisplayMember = "Laboratorista";
            this.cmbNoEco.Location = new System.Drawing.Point(262, 52);
            this.cmbNoEco.Name = "cmbNoEco";
            this.cmbNoEco.Size = new System.Drawing.Size(155, 21);
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
            this.label10.Location = new System.Drawing.Point(562, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Ajuste a 7 días:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(562, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ajuste a 3 días:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(552, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Ajuste Edad Esp:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtA7
            // 
            this.txtA7.Location = new System.Drawing.Point(642, 24);
            this.txtA7.MaxLength = 5;
            this.txtA7.Name = "txtA7";
            this.txtA7.Size = new System.Drawing.Size(47, 20);
            this.txtA7.TabIndex = 28;
            this.txtA7.Text = "0";
            // 
            // txtA3
            // 
            this.txtA3.Location = new System.Drawing.Point(642, 2);
            this.txtA3.MaxLength = 5;
            this.txtA3.Name = "txtA3";
            this.txtA3.Size = new System.Drawing.Size(47, 20);
            this.txtA3.TabIndex = 27;
            this.txtA3.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "NoEco:";
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(118, 73);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(120, 21);
            this.cmbPrueba.TabIndex = 11;
            this.cmbPrueba.ValueMember = "IdPrueba";
            this.cmbPrueba.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 76);
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
            this.cmbUnidad.Location = new System.Drawing.Point(118, 52);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(94, 21);
            this.cmbUnidad.TabIndex = 10;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(333, 23);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(333, 0);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 2);
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
            this.cmbIdObra.Location = new System.Drawing.Point(118, 28);
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
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(200, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(212, 16);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.Location = new System.Drawing.Point(247, 73);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(115, 24);
            this.chbLab.TabIndex = 79;
            this.chbLab.Text = "Incluye laboratorio";
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
            this.crvRepAnalisis.Location = new System.Drawing.Point(0, 107);
            this.crvRepAnalisis.Name = "crvRepAnalisis";
            this.crvRepAnalisis.ShowCloseButton = false;

            this.crvRepAnalisis.ShowGroupTreeButton = false;
            this.crvRepAnalisis.ShowLogo = false;
            this.crvRepAnalisis.ShowRefreshButton = false;
            this.crvRepAnalisis.Size = new System.Drawing.Size(1028, 641);
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
            this.sqlSelectCommand4.CommandText = "[AnaBlock]";
            this.sqlSelectCommand4.CommandTimeout = 60;
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@Largo", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Peralte", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
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
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@Como", System.Data.SqlDbType.NVarChar, 15)});
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
            new System.Data.SqlClient.SqlParameter("@Hoja", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDATipo
            // 
            this.sqlDATipo.SelectCommand = this.sqlSelectCommand5;
            this.sqlDATipo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TabiqueMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Tipo1", "Tipo1")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = resources.GetString("sqlSelectCommand5.CommandText");
            this.sqlSelectCommand5.Connection = this.sqlConn;
            // 
            // sqlDAComo
            // 
            this.sqlDAComo.SelectCommand = this.sqlSelectCommand6;
            this.sqlDAComo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TabiqueMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Como", "Como"),
                        new System.Data.Common.DataColumnMapping("Como1", "Como1")})});
            // 
            // sqlSelectCommand6
            // 
            this.sqlSelectCommand6.CommandText = resources.GetString("sqlSelectCommand6.CommandText");
            this.sqlSelectCommand6.Connection = this.sqlConn;
            // 
            // sqlDAGrado
            // 
            this.sqlDAGrado.SelectCommand = this.sqlSelectCommand8;
            this.sqlDAGrado.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TabiqueMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("Grado1", "Grado1")})});
            // 
            // sqlSelectCommand8
            // 
            this.sqlSelectCommand8.CommandText = resources.GetString("sqlSelectCommand8.CommandText");
            this.sqlSelectCommand8.Connection = this.sqlConn;
            // 
            // dsAnalBlock1
            // 
            this.dsAnalBlock1.DataSetName = "dsAnalBlock";
            this.dsAnalBlock1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsAnalBlock1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RepAnaBlo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1028, 748);
            this.Controls.Add(this.crvRepAnalisis);
            this.Controls.Add(this.panel1);
            this.Name = "RepAnaBlo";
            this.Text = "RepAnaBlo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepAnaBlo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGradoBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNoEco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalBlock1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void RepAnaBlo_Load(object sender, System.EventArgs e)
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
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
			sqlDAGrado.Fill(dsGradoBlock1, "TabiqueMdor");
			sqlDATipo.Fill(dsTipoBlock1, "TabiqueMdor");
			sqlDAComo.Fill(dsComo1, "TabiqueMdor");
			dsBusNoEco1.Laboratorista.AddLaboratoristaRow(-1,"Todos");
			sqlDANoEco.Fill(dsBusNoEco1, "Laboratorista");
			cmbNoEco.SelectedIndex = 0;
			cmbIdObra.SelectedIndex = 0;
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsConcreto1.Clear();
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = false;
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			btnVistaPrevia.Visible = true;
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            
            crvRepAnalisis.Visible = true;
            cryRepAnalBlock1.SetDataSource(dsAnalBlock1);				
                        
            try
			{
				CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
				
				CrystalDecisions.Shared.ParameterDiscreteValue pdvUnidad = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvUnidad.Value = cmbUnidad.Text;
				CrystalDecisions.Shared.ParameterDiscreteValue pdvRes = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvRes.Value = float.Parse(cmbGrado.SelectedValue.ToString().Substring(0,3)) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
				CrystalDecisions.Shared.ParameterDiscreteValue pdvTip = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvTip.Value = cmbTipo.SelectedValue.ToString();
				
				CrystalDecisions.Shared.ParameterDiscreteValue pdvLab = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvLab.Value = cmbNoEco.Text;

				CrystalDecisions.Shared.ParameterDiscreteValue pdvCra = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvCra.Value = dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString();
				CrystalDecisions.Shared.ParameterDiscreteValue pdvDir = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvDir.Value = dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString();
				CrystalDecisions.Shared.ParameterDiscreteValue pdvObr = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvObr.Value = txtIdobra.Text;
				CrystalDecisions.Shared.ParameterDiscreteValue pdvZon = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvZon.Value = dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString();
				CrystalDecisions.Shared.ParameterDiscreteValue pdvLoc = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvLoc.Value = dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString();

				pvCollection.Clear();
				pvCollection.Add(pdvUnidad);
				cryRepAnalBlock1.DataDefinition.ParameterFields["@Unidad"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvRes);
				cryRepAnalBlock1.DataDefinition.ParameterFields["@Res"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvTip);
				cryRepAnalBlock1.DataDefinition.ParameterFields["@Tip"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvLab);
				cryRepAnalBlock1.DataDefinition.ParameterFields["@Lab"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvCra);
				cryRepAnalBlock1.DataDefinition.ParameterFields["@Cra"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvDir);
				cryRepAnalBlock1.DataDefinition.ParameterFields["@Dir"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvObr);
				cryRepAnalBlock1.DataDefinition.ParameterFields["@Obr"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvZon);
				cryRepAnalBlock1.DataDefinition.ParameterFields["@Zon"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvLoc);
				cryRepAnalBlock1.DataDefinition.ParameterFields["@Loc"].ApplyCurrentValues(pvCollection);	
			}
			catch(Exception ex1)
			{
				MessageBox.Show("parametro" + ex1.Message );
			}
			dsAnalBlock1.Clear();
			sqlDAAnalisis.SelectCommand.Parameters["@IdObra"].Value = (cmbIdObra.SelectedValue.ToString() == "Todas" ? "%" : txtIdobra.Text);
			sqlDAAnalisis.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@Tipo"].Value = cmbTipo.SelectedValue.ToString();
			sqlDAAnalisis.SelectCommand.Parameters["@Largo"].Value = txtLargo.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@Ancho"].Value = txtAncho.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@Peralte"].Value = txtPeralte.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@IdPrueba"].Value = cmbPrueba.SelectedValue.ToString();
			sqlDAAnalisis.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
			sqlDAAnalisis.SelectCommand.Parameters["@NoEco"].Value = cmbNoEco.SelectedValue.ToString();
			sqlDAAnalisis.SelectCommand.Parameters["@3i"].Value = txtA3.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@7i"].Value = txtA7.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@eei"].Value = txtEE.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 3;
			sqlDAAnalisis.SelectCommand.Parameters["@diaa"].Value = "3";
			sqlDAAnalisis.SelectCommand.Parameters["@diab"].Value = "14" ;
			sqlDAAnalisis.SelectCommand.Parameters["@diac"].Value = "28";
			sqlDAAnalisis.SelectCommand.Parameters["@Grado"].Value = cmbGrado.SelectedValue.ToString();
			sqlDAAnalisis.SelectCommand.Parameters["@Como"].Value = cmbComo.SelectedValue.ToString();
			sqlDAAnalisis.Fill(dsAnalBlock1, "GraficaFinal");
			sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 1;
			sqlDAAnalisis.Fill(dsAnalBlock1, "Analisis");
			sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 2;
			sqlDAAnalisis.Fill(dsAnalBlock1, "Grafica1");

			float[] gaus;
			gaus= new float[24];
			float[] ee;
			ee= new float[24];
			float[] nuevoee;
			nuevoee = new float[24];
			float moda = 0;
			int indice = 1;
			for(int i= 1; i <= 23; i++)
			{
				nuevoee[i] = 0;
				ee[i] = float.Parse(dsAnalBlock1.Tables["GraficaFinal"].Rows[2][i].ToString());
				if (moda < ee[i])
				{
					indice = i;
					moda = ee[i];
				}
			}
				indice = 12;
				for(int i= 1; i <= 23; i++)
					if(1 <= (i - (12 - indice)) && (i - (12 - indice)) <= 23)
						nuevoee[(i - (12 - indice))] = gaus[i] * (moda + 2);
				float res = float.Parse(cmbGrado.SelectedValue.ToString().Substring(0,3).Trim()) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());

				sqlDATitulo.SelectCommand.Parameters["@ResistenciaKg"].Value = res.ToString();
				sqlDATitulo.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
				sqlDATitulo.SelectCommand.Parameters["@Hoja"].Value = int.Parse(dsAnalBlock1.Tables["GraficaFinal"].Rows[0][24].ToString());
				sqlDATitulo.Fill(dsAnalBlock1,"titulo");

				// Establece el valor actual de parameter1 en el subinforme en 10 
				cryRepAnalBlock1.SetParameterValue("@reskg", res.ToString(), "Gauss");
				cryRepAnalBlock1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
				cryRepAnalBlock1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
				cryRepAnalBlock1.SetParameterValue("@Prueba", cmbPrueba.Text);
				cryRepAnalBlock1.SetParameterValue("@Grado", cmbGrado.SelectedValue.ToString());
				cryRepAnalBlock1.SetParameterValue("@Indice", int.Parse(res.ToString()));
			cryRepAnalBlock1.SetParameterValue("@Como", cmbComo.SelectedValue);
			cryRepAnalBlock1.SetParameterValue("@Largo", txtLargo.Text);
			cryRepAnalBlock1.SetParameterValue("@Ancho", txtAncho.Text);
			cryRepAnalBlock1.SetParameterValue("@Peralte", txtPeralte.Text);
			cryRepAnalBlock1.SetParameterValue("@Lab1", chbLab.Checked);

				
				crvRepAnalisis.ReportSource = cryRepAnalBlock1;

				//crvRepAnalisis.RefreshReport();
			
		}

		private void cbkPrefijo_CheckedChanged(object sender, System.EventArgs e)
		{
		if (cbkPrefijo.Checked == false)
			txtIdobra.Text = txtIdobra.Text.Substring(0,3)+"%";
		else
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
		}

        private void txtLargo_TextChanged(object sender, EventArgs e)
        {

        }


	}
}
