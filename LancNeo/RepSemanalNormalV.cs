using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de RepSemanalNormalV.
	/// </summary>
	public class RepSemanalNormalV : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpIni;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbConcretera;
		private System.Windows.Forms.ComboBox cmbPlanta;
		private System.Windows.Forms.ComboBox cmbUnidad;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.CheckBox chbRevisa;
		private System.Windows.Forms.CheckBox chbImprime;
		private System.Windows.Forms.ComboBox cmbMezcla;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbPrueba;
		private System.Windows.Forms.Label label7;
		private LancNeo.dsBusObra dsBusObra1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private LancNeo.dsUnidad dsUnidad1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrueba;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsTipoPrueba dsTipoPrueba1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private LancNeo.dsPlanta dsPlanta1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPLanta;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		private LancNeo.dsConcretera dsConcretera1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusEspecimen;
		private LancNeo.dsBusEspMues dsBusEspMues1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Data.SqlClient.SqlDataAdapter sqlDARepSemNormal;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepSemNormal;
		private System.Data.SqlClient.SqlDataAdapter sqlDAFirmas;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private LancNeo.dsFirmas dsFirmas1;
		private System.Windows.Forms.CheckBox chbLogo;
		private LancNeo.dsLogoLaboratorio dsLogoLaboratorio1;
		private System.Data.SqlClient.SqlDataAdapter sqlDALogoLab;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private LancNeo.dsLaboratorio dsLaboratorio1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private LancNeo.CryRepSemNormalV cryRepSemNormalV1;
		private LancNeo.dsRepSemNormal dsRepSemNormal1;
		private System.Windows.Forms.CheckBox chbFormato;
		private System.Windows.Forms.CheckBox chbElemento;
		private System.Data.SqlClient.SqlDataAdapter sqlDARepSemNormalLogo;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private LancNeo.CryRepSemNormalVlogo cryRepSemNormalVlogo1;
		private System.Windows.Forms.CheckBox chbDuplicado;
		public System.Data.SqlClient.SqlDataAdapter sqlDANorma;
		private System.Windows.Forms.CheckBox chbLeyenda;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
		private System.Windows.Forms.CheckBox chbLab;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RepSemanalNormalV()
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
		protected struct matCombo1
		{
			private string Descripcion;
			private short Identificador;
			public matCombo1(string Nombre , short id)
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
			public short getId
			{
				get
				{
					return Identificador;
				}
			}
		}
		protected struct matComboS
		{
			private string Descripcion;
			private string Identificador;
			public matComboS(string Nombre , string id)
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
			public string getId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepSemanalNormalV));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusEspMues1 = new LancNeo.dsBusEspMues();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.chbFormato = new System.Windows.Forms.CheckBox();
            this.chbElemento = new System.Windows.Forms.CheckBox();
            this.chbLogo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMezcla = new System.Windows.Forms.ComboBox();
            this.chbImprime = new System.Windows.Forms.CheckBox();
            this.chbRevisa = new System.Windows.Forms.CheckBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.cmbConcretera = new System.Windows.Forms.ComboBox();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.dsPlanta1 = new LancNeo.dsPlanta();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chbDuplicado = new System.Windows.Forms.CheckBox();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPLanta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusEspecimen = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARepSemNormal = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.crvRepSemNormal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAFirmas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsFirmas1 = new LancNeo.dsFirmas();
            this.dsLogoLaboratorio1 = new LancNeo.dsLogoLaboratorio();
            this.sqlDALogoLab = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
            this.dsLaboratorio1 = new LancNeo.dsLaboratorio();
            this.cryRepSemNormalV1 = new LancNeo.CryRepSemNormalV();
            this.dsRepSemNormal1 = new LancNeo.dsRepSemNormal();
            this.sqlDARepSemNormalLogo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.cryRepSemNormalVlogo1 = new LancNeo.CryRepSemNormalVlogo();
            this.sqlDANorma = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEspMues1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogoLaboratorio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepSemNormal1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.chbFormato);
            this.panel1.Controls.Add(this.chbElemento);
            this.panel1.Controls.Add(this.chbLogo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbPrueba);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbMezcla);
            this.panel1.Controls.Add(this.chbImprime);
            this.panel1.Controls.Add(this.chbRevisa);
            this.panel1.Controls.Add(this.cmbUnidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.cmbConcretera);
            this.panel1.Controls.Add(this.cmbPlanta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chbDuplicado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 111);
            this.panel1.TabIndex = 9;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(770, 7);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusEspMues1.Especimen;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(313, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsBusEspMues1
            // 
            this.dsBusEspMues1.DataSetName = "dsBusEspMues";
            this.dsBusEspMues1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusEspMues1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.Location = new System.Drawing.Point(330, 76);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 25);
            this.chbLab.TabIndex = 42;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.Location = new System.Drawing.Point(453, 76);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(116, 25);
            this.chbLeyenda.TabIndex = 41;
            this.chbLeyenda.Text = "Formato leyenda";
            // 
            // chbFormato
            // 
            this.chbFormato.Checked = true;
            this.chbFormato.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFormato.Location = new System.Drawing.Point(207, 76);
            this.chbFormato.Name = "chbFormato";
            this.chbFormato.Size = new System.Drawing.Size(115, 25);
            this.chbFormato.TabIndex = 40;
            this.chbFormato.Text = "Formato con logo";
            // 
            // chbElemento
            // 
            this.chbElemento.Location = new System.Drawing.Point(97, 76);
            this.chbElemento.Name = "chbElemento";
            this.chbElemento.Size = new System.Drawing.Size(104, 25);
            this.chbElemento.TabIndex = 39;
            this.chbElemento.Text = "Por elemento";
            // 
            // chbLogo
            // 
            this.chbLogo.Location = new System.Drawing.Point(8, 28);
            this.chbLogo.Name = "chbLogo";
            this.chbLogo.Size = new System.Drawing.Size(184, 24);
            this.chbLogo.TabIndex = 25;
            this.chbLogo.Text = "Incluye imagen de acreditación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(647, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Planta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Concretera:";
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(430, 24);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(68, 21);
            this.cmbPrueba.TabIndex = 11;
            this.cmbPrueba.ValueMember = "IdPrueba";
            this.cmbPrueba.Visible = false;
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
            this.label7.Location = new System.Drawing.Point(380, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Prueba:";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mezcla:";
            // 
            // cmbMezcla
            // 
            this.cmbMezcla.Location = new System.Drawing.Point(697, 52);
            this.cmbMezcla.Name = "cmbMezcla";
            this.cmbMezcla.Size = new System.Drawing.Size(68, 21);
            this.cmbMezcla.TabIndex = 9;
            this.cmbMezcla.Text = "cmbMezcla";
            // 
            // chbImprime
            // 
            this.chbImprime.Checked = true;
            this.chbImprime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbImprime.Location = new System.Drawing.Point(8, 52);
            this.chbImprime.Name = "chbImprime";
            this.chbImprime.Size = new System.Drawing.Size(180, 24);
            this.chbImprime.TabIndex = 8;
            this.chbImprime.Text = "No imprime muestras sin datos";
            // 
            // chbRevisa
            // 
            this.chbRevisa.Checked = true;
            this.chbRevisa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRevisa.Location = new System.Drawing.Point(200, 52);
            this.chbRevisa.Name = "chbRevisa";
            this.chbRevisa.Size = new System.Drawing.Size(112, 23);
            this.chbRevisa.TabIndex = 7;
            this.chbRevisa.Text = "Revisa secuencia";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(540, 52);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(84, 21);
            this.cmbUnidad.TabIndex = 10;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // dsUnidad1
            // 
            this.dsUnidad1.DataSetName = "dsUnidad";
            this.dsUnidad1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsUnidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(540, 28);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(540, 3);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "IdObra";
            this.cmbIdObra.Location = new System.Drawing.Point(230, 28);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte semanal normal vapor";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(360, 16);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(380, 3);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbConcretera.DisplayMember = "IdConcretera";
            this.cmbConcretera.Location = new System.Drawing.Point(697, 4);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(68, 21);
            this.cmbConcretera.TabIndex = 5;
            this.cmbConcretera.ValueMember = "IdConcretera";
            this.cmbConcretera.SelectedIndexChanged += new System.EventHandler(this.cmbConcretera_SelectedIndexChanged);
            // 
            // dsConcretera1
            // 
            this.dsConcretera1.DataSetName = "dsConcretera";
            this.dsConcretera1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DataSource = this.dsPlanta1.Planta;
            this.cmbPlanta.DisplayMember = "Planta";
            this.cmbPlanta.Enabled = false;
            this.cmbPlanta.Location = new System.Drawing.Point(697, 28);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(68, 21);
            this.cmbPlanta.TabIndex = 6;
            this.cmbPlanta.ValueMember = "IdPlanta";
            // 
            // dsPlanta1
            // 
            this.dsPlanta1.DataSetName = "dsPlanta";
            this.dsPlanta1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(592, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // chbDuplicado
            // 
            this.chbDuplicado.Location = new System.Drawing.Point(7, 76);
            this.chbDuplicado.Name = "chbDuplicado";
            this.chbDuplicado.Size = new System.Drawing.Size(88, 24);
            this.chbDuplicado.TabIndex = 30;
            this.chbDuplicado.Text = "¿Duplicado?";
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
            // sqlDABusEspecimen
            // 
            this.sqlDABusEspecimen.SelectCommand = this.sqlSelectCommand3;
            this.sqlDABusEspecimen.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Especimen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("tipo", "tipo")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlDARepSemNormal
            // 
            this.sqlDARepSemNormal.SelectCommand = this.sqlSelectCommand4;
            this.sqlDARepSemNormal.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RepSemNormalV", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("PREMEZ.", "PREMEZ."),
                        new System.Data.Common.DataColumnMapping("PTA", "PTA"),
                        new System.Data.Common.DataColumnMapping("Res.", "Res."),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Tma", "Tma"),
                        new System.Data.Common.DataColumnMapping("Rev.", "Rev."),
                        new System.Data.Common.DataColumnMapping("G", "G"),
                        new System.Data.Common.DataColumnMapping("T.A.", "T.A."),
                        new System.Data.Common.DataColumnMapping("m3", "m3"),
                        new System.Data.Common.DataColumnMapping("Olla", "Olla"),
                        new System.Data.Common.DataColumnMapping("Rem", "Rem"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("Obt", "Obt"),
                        new System.Data.Common.DataColumnMapping("ELEMENTO", "ELEMENTO"),
                        new System.Data.Common.DataColumnMapping("EJES", "EJES"),
                        new System.Data.Common.DataColumnMapping("Niv.", "Niv."),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("Observa1", "Observa1"),
                        new System.Data.Common.DataColumnMapping("Nota", "Nota"),
                        new System.Data.Common.DataColumnMapping("Nota1", "Nota1"),
                        new System.Data.Common.DataColumnMapping("Origen", "Origen"),
                        new System.Data.Common.DataColumnMapping("Resbajo", "Resbajo"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("v1", "v1"),
                        new System.Data.Common.DataColumnMapping("N1", "N1"),
                        new System.Data.Common.DataColumnMapping("3 días", "3 días"),
                        new System.Data.Common.DataColumnMapping("d2", "d2"),
                        new System.Data.Common.DataColumnMapping("v2", "v2"),
                        new System.Data.Common.DataColumnMapping("N2", "N2"),
                        new System.Data.Common.DataColumnMapping("7 días", "7 días"),
                        new System.Data.Common.DataColumnMapping("d3", "d3"),
                        new System.Data.Common.DataColumnMapping("v3", "v3"),
                        new System.Data.Common.DataColumnMapping("N3", "N3"),
                        new System.Data.Common.DataColumnMapping("ee1", "ee1"),
                        new System.Data.Common.DataColumnMapping("d4", "d4"),
                        new System.Data.Common.DataColumnMapping("v4", "v4"),
                        new System.Data.Common.DataColumnMapping("N4", "N4"),
                        new System.Data.Common.DataColumnMapping("ee2", "ee2"),
                        new System.Data.Common.DataColumnMapping("d5", "d5"),
                        new System.Data.Common.DataColumnMapping("v5", "v5"),
                        new System.Data.Common.DataColumnMapping("N5", "N5"),
                        new System.Data.Common.DataColumnMapping("eV1", "eV1"),
                        new System.Data.Common.DataColumnMapping("d6", "d6"),
                        new System.Data.Common.DataColumnMapping("v6", "v6"),
                        new System.Data.Common.DataColumnMapping("N6", "N6"),
                        new System.Data.Common.DataColumnMapping("eV2", "eV2"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("UMaxagr", "UMaxagr"),
                        new System.Data.Common.DataColumnMapping("UReven", "UReven"),
                        new System.Data.Common.DataColumnMapping("Cuantos", "Cuantos")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "[RepSemNormal]";
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.NVarChar, 4),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@IdReporte", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Mezcla", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Nulos", System.Data.SqlDbType.Bit, 1),
            new System.Data.SqlClient.SqlParameter("@Secuencia", System.Data.SqlDbType.Bit, 1)});
            // 
            // crvRepSemNormal
            // 
            this.crvRepSemNormal.ActiveViewIndex = -1;
            this.crvRepSemNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepSemNormal.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepSemNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepSemNormal.EnableRefresh = false;
            this.crvRepSemNormal.Location = new System.Drawing.Point(0, 111);
            this.crvRepSemNormal.Name = "crvRepSemNormal";
            this.crvRepSemNormal.ShowCloseButton = false;

            this.crvRepSemNormal.ShowGroupTreeButton = false;
            this.crvRepSemNormal.ShowLogo = false;
            this.crvRepSemNormal.ShowRefreshButton = false;
            this.crvRepSemNormal.Size = new System.Drawing.Size(1028, 637);
            this.crvRepSemNormal.TabIndex = 10;
            this.crvRepSemNormal.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepSemNormal.ToolPanelWidth = 167;
            // 
            // sqlDAFirmas
            // 
            this.sqlDAFirmas.SelectCommand = this.sqlSelectCommand7;
            this.sqlDAFirmas.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Firmas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdFirma", "IdFirma"),
                        new System.Data.Common.DataColumnMapping("Nombre", "Nombre"),
                        new System.Data.Common.DataColumnMapping("Cargo", "Cargo"),
                        new System.Data.Common.DataColumnMapping("Imprime", "Imprime")})});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "SELECT     IdFirma, Nombre, Cargo, Imprime\r\nFROM         Firmas\r\nWHERE     (Impri" +
                "me = 1) AND (Concreto < 6)\r\nORDER BY Concreto";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // dsFirmas1
            // 
            this.dsFirmas1.DataSetName = "dsFirmas";
            this.dsFirmas1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsFirmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsLogoLaboratorio1
            // 
            this.dsLogoLaboratorio1.DataSetName = "dsLogoLaboratorio";
            this.dsLogoLaboratorio1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsLogoLaboratorio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDALogoLab
            // 
            this.sqlDALogoLab.SelectCommand = this.sqlSelectCommand8;
            this.sqlDALogoLab.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorio", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("Rutaimagen", "Rutaimagen")})});
            // 
            // sqlSelectCommand8
            // 
            this.sqlSelectCommand8.CommandText = "SELECT IdLaboratorio, Laboratorio, IdZona, Rutaimagen FROM Laboratorio WHERE (IdL" +
                "aboratorio = @IdLaboratorio)";
            this.sqlSelectCommand8.Connection = this.sqlConn;
            this.sqlSelectCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, "IdLaboratorio")});
            // 
            // dsLaboratorio1
            // 
            this.dsLaboratorio1.DataSetName = "dsLaboratorio";
            this.dsLaboratorio1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsRepSemNormal1
            // 
            this.dsRepSemNormal1.DataSetName = "dsRepSemNormal";
            this.dsRepSemNormal1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsRepSemNormal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDARepSemNormalLogo
            // 
            this.sqlDARepSemNormalLogo.SelectCommand = this.sqlCommand2;
            this.sqlDARepSemNormalLogo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RepSemNormalV", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("PREMEZ.", "PREMEZ."),
                        new System.Data.Common.DataColumnMapping("PTA", "PTA"),
                        new System.Data.Common.DataColumnMapping("Res.", "Res."),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Tma", "Tma"),
                        new System.Data.Common.DataColumnMapping("Rev.", "Rev."),
                        new System.Data.Common.DataColumnMapping("G", "G"),
                        new System.Data.Common.DataColumnMapping("T.A.", "T.A."),
                        new System.Data.Common.DataColumnMapping("m3", "m3"),
                        new System.Data.Common.DataColumnMapping("Olla", "Olla"),
                        new System.Data.Common.DataColumnMapping("Rem", "Rem"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("Obt", "Obt"),
                        new System.Data.Common.DataColumnMapping("ELEMENTO", "ELEMENTO"),
                        new System.Data.Common.DataColumnMapping("EJES", "EJES"),
                        new System.Data.Common.DataColumnMapping("Niv.", "Niv."),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("Observa1", "Observa1"),
                        new System.Data.Common.DataColumnMapping("Nota", "Nota"),
                        new System.Data.Common.DataColumnMapping("Nota1", "Nota1"),
                        new System.Data.Common.DataColumnMapping("Origen", "Origen"),
                        new System.Data.Common.DataColumnMapping("Resbajo", "Resbajo"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("v1", "v1"),
                        new System.Data.Common.DataColumnMapping("N1", "N1"),
                        new System.Data.Common.DataColumnMapping("3 días", "3 días"),
                        new System.Data.Common.DataColumnMapping("d2", "d2"),
                        new System.Data.Common.DataColumnMapping("v2", "v2"),
                        new System.Data.Common.DataColumnMapping("N2", "N2"),
                        new System.Data.Common.DataColumnMapping("7 días", "7 días"),
                        new System.Data.Common.DataColumnMapping("d3", "d3"),
                        new System.Data.Common.DataColumnMapping("v3", "v3"),
                        new System.Data.Common.DataColumnMapping("N3", "N3"),
                        new System.Data.Common.DataColumnMapping("ee1", "ee1"),
                        new System.Data.Common.DataColumnMapping("d4", "d4"),
                        new System.Data.Common.DataColumnMapping("v4", "v4"),
                        new System.Data.Common.DataColumnMapping("N4", "N4"),
                        new System.Data.Common.DataColumnMapping("ee2", "ee2"),
                        new System.Data.Common.DataColumnMapping("d5", "d5"),
                        new System.Data.Common.DataColumnMapping("v5", "v5"),
                        new System.Data.Common.DataColumnMapping("N5", "N5"),
                        new System.Data.Common.DataColumnMapping("eV1", "eV1"),
                        new System.Data.Common.DataColumnMapping("d6", "d6"),
                        new System.Data.Common.DataColumnMapping("v6", "v6"),
                        new System.Data.Common.DataColumnMapping("N6", "N6"),
                        new System.Data.Common.DataColumnMapping("eV2", "eV2"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("UMaxagr", "UMaxagr"),
                        new System.Data.Common.DataColumnMapping("UReven", "UReven"),
                        new System.Data.Common.DataColumnMapping("Cuantos", "Cuantos")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "[RepSemNormalLogo]";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.NVarChar, 4),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@IdReporte", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Mezcla", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Nulos", System.Data.SqlDbType.Bit, 1),
            new System.Data.SqlClient.SqlParameter("@Secuencia", System.Data.SqlDbType.Bit, 1)});
            // 
            // sqlDANorma
            // 
            this.sqlDANorma.SelectCommand = this.sqlSelectCommand9;
            this.sqlDANorma.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Normas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdNorma", "IdNorma"),
                        new System.Data.Common.DataColumnMapping("Informe", "Informe"),
                        new System.Data.Common.DataColumnMapping("Normas", "Normas"),
                        new System.Data.Common.DataColumnMapping("Titulo", "Titulo"),
                        new System.Data.Common.DataColumnMapping("IdInforme", "IdInforme"),
                        new System.Data.Common.DataColumnMapping("Norma1", "Norma1"),
                        new System.Data.Common.DataColumnMapping("Norma2", "Norma2"),
                        new System.Data.Common.DataColumnMapping("Norma3", "Norma3"),
                        new System.Data.Common.DataColumnMapping("Norma4", "Norma4"),
                        new System.Data.Common.DataColumnMapping("Norma5", "Norma5")})});
            // 
            // sqlSelectCommand9
            // 
            this.sqlSelectCommand9.CommandText = "SELECT IdNorma, Informe, Normas, Titulo, IdInforme, Norma1, Norma2, Norma3, Norma" +
                "4, Norma5 FROM Normas WHERE (IdNorma = @IdNorma) ORDER BY IdNorma";
            this.sqlSelectCommand9.Connection = this.sqlConn;
            this.sqlSelectCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdNorma", System.Data.SqlDbType.SmallInt, 2, "IdNorma")});
            // 
            // RepSemanalNormalV
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1028, 748);
            this.Controls.Add(this.crvRepSemNormal);
            this.Controls.Add(this.panel1);
            this.Name = "RepSemanalNormalV";
            this.Text = "RepSemanalNormalV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepSemanalNormal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEspMues1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogoLaboratorio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepSemNormal1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void RepSemanalNormal_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsBusObra1, "Obra");
			sqlDAFirmas.Fill(dsFirmas1, "Firmas");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
			dsConcretera1.Concretera.AddConcreteraRow("Todas","%","%");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			cmbConcretera.SelectedIndex = 0;
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",cmbConcretera.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsBusEspMues1.Clear();
//			crvRepMuestreador.Visible = false;
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
			LlenasSqlDA();
		}
		private void LlenasSqlDA()
		{
			sqlDABusEspecimen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDABusEspecimen.Fill(dsBusEspMues1, "Especimen");
		}

		private void cmbConcretera_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cmbConcretera.SelectedIndex == 0)
				cmbPlanta.Enabled = false;
			else
				cmbPlanta.Enabled = true;
			dsPlanta1.Clear();
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",cmbConcretera.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
			cmbPlanta.SelectedIndex = 0;
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			try
				{
				crvRepSemNormal.Visible = true;
                dsRepSemNormal1.Clear();
                cryRepSemNormalVlogo1.SetDataSource(dsRepSemNormal1);
                cryRepSemNormalV1.SetDataSource(dsRepSemNormal1);
                if (chbElemento.Checked == false)
				{
					sqlDARepSemNormal.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
					sqlDARepSemNormal.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString());
					sqlDARepSemNormal.SelectCommand.Parameters["@IdPlanta"].Value = (cmbPlanta.SelectedIndex == 0 ? "%" : cmbPlanta.SelectedValue.ToString());
					sqlDARepSemNormal.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
					sqlDARepSemNormal.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
					sqlDARepSemNormal.SelectCommand.Parameters["@IdReporte"].Value = 2;
					sqlDARepSemNormal.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
					sqlDARepSemNormal.SelectCommand.Parameters["@Mezcla"].Value = cmbMezcla.SelectedValue.ToString();
					sqlDARepSemNormal.SelectCommand.Parameters["@Nulos"].Value = chbImprime.Checked;
					sqlDARepSemNormal.SelectCommand.Parameters["@Secuencia"].Value = chbRevisa.Checked;
					sqlDARepSemNormal.Fill(dsRepSemNormal1, "RepSemNormal");
				}
				else
				{
					sqlDARepSemNormalLogo.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
					sqlDARepSemNormalLogo.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString());
					sqlDARepSemNormalLogo.SelectCommand.Parameters["@IdPlanta"].Value = (cmbPlanta.SelectedIndex == 0 ? "%" : cmbPlanta.SelectedValue.ToString());
					sqlDARepSemNormalLogo.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
					sqlDARepSemNormalLogo.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
					sqlDARepSemNormalLogo.SelectCommand.Parameters["@IdReporte"].Value = 2;
					sqlDARepSemNormalLogo.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
					sqlDARepSemNormalLogo.SelectCommand.Parameters["@Mezcla"].Value = cmbMezcla.SelectedValue.ToString();
					sqlDARepSemNormalLogo.SelectCommand.Parameters["@Nulos"].Value = chbImprime.Checked;
					sqlDARepSemNormalLogo.SelectCommand.Parameters["@Secuencia"].Value = chbRevisa.Checked;
					sqlDARepSemNormalLogo.Fill(dsRepSemNormal1, "RepSemNormal");
				}
				int cuantos = dsRepSemNormal1.Tables["RepSemNormal"].Rows.Count;
/*				dsLogoLaboratorio1.Clear();
				dsLaboratorio1.Clear();
				sqlDALogoLab.SelectCommand.Parameters["@Idlaboratorio"].Value = dsRepSemNormal1.Tables["RepSemNormal"].Rows[0]["IdLaboratorio"].ToString();
				sqlDALogoLab.Fill(dsLaboratorio1, "Laboratorio");
				string file = dsLaboratorio1.Tables["Laboratorio"].Rows[0]["RutaImagen"].ToString();
				pictureBox1.Image = Image.FromFile (file.Trim());

				MemoryStream ms = new MemoryStream();
				pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
				byte[] arrImage = ms.GetBuffer();
				ms.Close();
				if(chbLogo.Checked)
					dsRepSemNormal1.Laboratorio.AddLaboratorioRow(dsRepSemNormal1.Tables["RepSemNormal"].Rows[0]["IdLaboratorio"].ToString(), arrImage);
				else
					dsRepSemNormal1.Laboratorio.AddLaboratorioRow(dsRepSemNormal1.Tables["RepSemNormal"].Rows[0]["IdLaboratorio"].ToString(), null);
 */
				sqlDANorma.SelectCommand.Parameters["@IdNorma"].Value = cmbMezcla.SelectedValue;
				sqlDANorma.Fill(dsRepSemNormal1, "Normas");
				if (chbFormato.Checked == false)
				{
                    cryRepSemNormalV1.SetParameterValue("@F1", dsFirmas1.Tables["Firmas"].Rows[0][1].ToString());
                    cryRepSemNormalV1.SetParameterValue("@C1", dsFirmas1.Tables["Firmas"].Rows[0][2].ToString());
                    cryRepSemNormalV1.SetParameterValue("@F2", dsFirmas1.Tables["Firmas"].Rows[1][1].ToString());
                    cryRepSemNormalV1.SetParameterValue("@C2", dsFirmas1.Tables["Firmas"].Rows[1][2].ToString());
                    cryRepSemNormalV1.SetParameterValue("@F3", dsFirmas1.Tables["Firmas"].Rows[2][1].ToString());
                    cryRepSemNormalV1.SetParameterValue("@C3", dsFirmas1.Tables["Firmas"].Rows[2][2].ToString());
                    cryRepSemNormalV1.SetParameterValue("@F4", dsFirmas1.Tables["Firmas"].Rows[3][1].ToString());
                    cryRepSemNormalV1.SetParameterValue("@C4", dsFirmas1.Tables["Firmas"].Rows[3][2].ToString());
                    cryRepSemNormalV1.SetParameterValue("@F5", dsFirmas1.Tables["Firmas"].Rows[4][1].ToString());
                    cryRepSemNormalV1.SetParameterValue("@C5", dsFirmas1.Tables["Firmas"].Rows[4][2].ToString());
                    cryRepSemNormalV1.SetParameterValue("Mezcla", (cmbMezcla.SelectedValue.ToString() == "1" ? "Concreto" : "Mortero"));
                    cryRepSemNormalV1.SetParameterValue("@Ruta", chbLogo.Checked);
                    cryRepSemNormalV1.SetParameterValue("@Lab", chbLab.Checked);
					cryRepSemNormalV1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
					crvRepSemNormal.ReportSource = cryRepSemNormalV1;
					//crvRepSemNormal.RefreshReport();
				}
				else
				{
                    cryRepSemNormalVlogo1.SetParameterValue("@F1", dsFirmas1.Tables["Firmas"].Rows[0][1].ToString());
                    cryRepSemNormalVlogo1.SetParameterValue("@C1", dsFirmas1.Tables["Firmas"].Rows[0][2].ToString());
                    cryRepSemNormalVlogo1.SetParameterValue("@F2", dsFirmas1.Tables["Firmas"].Rows[1][1].ToString());
                    cryRepSemNormalVlogo1.SetParameterValue("@C2", dsFirmas1.Tables["Firmas"].Rows[1][2].ToString());
                    cryRepSemNormalVlogo1.SetParameterValue("@F3", dsFirmas1.Tables["Firmas"].Rows[2][1].ToString());
                    cryRepSemNormalVlogo1.SetParameterValue("@C3", dsFirmas1.Tables["Firmas"].Rows[2][2].ToString());
                    cryRepSemNormalVlogo1.SetParameterValue("@F4", dsFirmas1.Tables["Firmas"].Rows[3][1].ToString());
                    cryRepSemNormalVlogo1.SetParameterValue("@C4", dsFirmas1.Tables["Firmas"].Rows[3][2].ToString());
                    cryRepSemNormalVlogo1.SetParameterValue("@F5", dsFirmas1.Tables["Firmas"].Rows[4][1].ToString());
                    cryRepSemNormalVlogo1.SetParameterValue("@C5", dsFirmas1.Tables["Firmas"].Rows[4][2].ToString());
                    cryRepSemNormalVlogo1.SetParameterValue("@Mezcla", (cmbMezcla.SelectedValue.ToString() == "1" ? "Concreto" : "Mortero"));
                    cryRepSemNormalVlogo1.SetParameterValue("@Ruta", chbLogo.Checked);
                    cryRepSemNormalVlogo1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
					cryRepSemNormalVlogo1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
					cryRepSemNormalVlogo1.SetParameterValue("@Lab", chbLab.Checked);
					crvRepSemNormal.ReportSource = cryRepSemNormalVlogo1;
					//crvRepSemNormal.RefreshReport();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}

		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			dtpIni.Text = dsBusEspMues1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
			btnVistaPrevia.Visible = true;
		}



	}
}
