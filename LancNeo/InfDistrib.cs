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
	/// Descripción breve de InfDistrib.
	/// </summary>
	public class InfDistrib : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbUnidad;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDADatos;
		private LancNeo.dsDatos dsDatos1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
        private LancNeo.dsUnidad dsUnidad1;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDATipo;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private LancNeo.dsTipo dsTipo1;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.TextBox txtResis3;
		private System.Windows.Forms.TextBox txtResis2;
		private System.Windows.Forms.TextBox txtResis1;
		private System.Windows.Forms.TextBox txtResis4;
		private System.Windows.Forms.TextBox txtLan30EE;
		private System.Windows.Forms.TextBox txtLan25EE;
		private System.Windows.Forms.TextBox txtLan2007;
		private System.Windows.Forms.TextBox txtLan20EE;
		private System.Windows.Forms.TextBox txtLan1507;
		private System.Windows.Forms.TextBox txtLan15EE;
		private System.Windows.Forms.TextBox txtLan3007;
		private System.Windows.Forms.TextBox txtLan2507;
		private System.Windows.Forms.TextBox txtLan2003;
		private System.Windows.Forms.TextBox txtLan1503;
		private System.Windows.Forms.TextBox txtLan3003;
		private System.Windows.Forms.TextBox txtLan2503;
		private System.Windows.Forms.TextBox txtLan2001;
		private System.Windows.Forms.TextBox txtLan1501;
		private System.Windows.Forms.TextBox txtLan3001;
		private System.Windows.Forms.TextBox txtLan2501;
		private LancNeo.dsGraDis dsGraDis1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvGraDis;
		private LancNeo.CryInfGraDis cryInfGraDis1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private DBGraphics memGraphics;
		private DBGraphics memGraphics1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.CheckBox chbLab;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox chbTodas;
		private System.Data.SqlClient.SqlDataAdapter sqlDADatosT;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private LancNeo.dsPlanta dsPlanta1;
		private LancNeo.dsConcretera dsConcretera1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPLanta;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbConcretera;
        private System.Windows.Forms.ComboBox cmbPlanta;
        private Label label2;
        private ComboBox cmbIdObra;
        private SqlCommand sqlCommand2;
        public SqlDataAdapter sqlDABusObra;
        private Label label17;
        private TextBox txtMin;
        private TextBox txtMax;
        private Label label18;
        private Label label16;
        private TextBox txt16h;
        private TextBox txt20h;
        private Label label11;
        private GroupBox gbox;
        private RadioButton rBPre3;
        private RadioButton rBPre2;
        private RadioButton rBPre1;
        private SqlCommand sqlSelectCommand3;
        private SqlDataAdapter sqlDACemento;
        private dsCementoC dsCementoC1;
        private dsCemDia dsCemDia1;

		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public InfDistrib()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			memGraphics = new  DBGraphics();
			memGraphics1 = new  DBGraphics();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfDistrib));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBuscaObra1 = new LancNeo.dsBuscaObra();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.rBPre3 = new System.Windows.Forms.RadioButton();
            this.rBPre2 = new System.Windows.Forms.RadioButton();
            this.rBPre1 = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt16h = new System.Windows.Forms.TextBox();
            this.txt20h = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbConcretera = new System.Windows.Forms.ComboBox();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.dsPlanta1 = new LancNeo.dsPlanta();
            this.chbTodas = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dsTipo1 = new LancNeo.dsTipo();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResis4 = new System.Windows.Forms.TextBox();
            this.txtResis3 = new System.Windows.Forms.TextBox();
            this.txtResis2 = new System.Windows.Forms.TextBox();
            this.txtResis1 = new System.Windows.Forms.TextBox();
            this.txtLan3001 = new System.Windows.Forms.TextBox();
            this.txtLan3003 = new System.Windows.Forms.TextBox();
            this.txtLan2501 = new System.Windows.Forms.TextBox();
            this.txtLan2503 = new System.Windows.Forms.TextBox();
            this.txtLan2001 = new System.Windows.Forms.TextBox();
            this.txtLan2003 = new System.Windows.Forms.TextBox();
            this.txtLan1501 = new System.Windows.Forms.TextBox();
            this.txtLan1503 = new System.Windows.Forms.TextBox();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.txtLan3007 = new System.Windows.Forms.TextBox();
            this.txtLan30EE = new System.Windows.Forms.TextBox();
            this.txtLan2507 = new System.Windows.Forms.TextBox();
            this.txtLan25EE = new System.Windows.Forms.TextBox();
            this.txtLan2007 = new System.Windows.Forms.TextBox();
            this.txtLan20EE = new System.Windows.Forms.TextBox();
            this.txtLan1507 = new System.Windows.Forms.TextBox();
            this.txtLan15EE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.sqlDADatos = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsDatos1 = new LancNeo.dsDatos();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATipo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsGraDis1 = new LancNeo.dsGraDis();
            this.crvGraDis = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryInfGraDis1 = new LancNeo.CryInfGraDis();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sqlDADatosT = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPLanta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDACemento = new System.Data.SqlClient.SqlDataAdapter();
            this.dsCementoC1 = new LancNeo.dsCementoC();
            this.dsCemDia1 = new LancNeo.dsCemDia();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            this.gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGraDis1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCementoC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCemDia1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.gbox);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtMin);
            this.panel1.Controls.Add(this.txtMax);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txt16h);
            this.panel1.Controls.Add(this.txt20h);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbConcretera);
            this.panel1.Controls.Add(this.cmbPlanta);
            this.panel1.Controls.Add(this.chbTodas);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtResis4);
            this.panel1.Controls.Add(this.txtResis3);
            this.panel1.Controls.Add(this.txtResis2);
            this.panel1.Controls.Add(this.txtResis1);
            this.panel1.Controls.Add(this.txtLan3001);
            this.panel1.Controls.Add(this.txtLan3003);
            this.panel1.Controls.Add(this.txtLan2501);
            this.panel1.Controls.Add(this.txtLan2503);
            this.panel1.Controls.Add(this.txtLan2001);
            this.panel1.Controls.Add(this.txtLan2003);
            this.panel1.Controls.Add(this.txtLan1501);
            this.panel1.Controls.Add(this.txtLan1503);
            this.panel1.Controls.Add(this.cbkPrefijo);
            this.panel1.Controls.Add(this.txtLan3007);
            this.panel1.Controls.Add(this.txtLan30EE);
            this.panel1.Controls.Add(this.txtLan2507);
            this.panel1.Controls.Add(this.txtLan25EE);
            this.panel1.Controls.Add(this.txtLan2007);
            this.panel1.Controls.Add(this.txtLan20EE);
            this.panel1.Controls.Add(this.txtLan1507);
            this.panel1.Controls.Add(this.txtLan15EE);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbUnidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 114);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(825, 43);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBuscaObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(50, 31);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "Obra.Idobra";
            // 
            // dsBuscaObra1
            // 
            this.dsBuscaObra1.DataSetName = "dsBuscaObra";
            this.dsBuscaObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBuscaObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.rBPre3);
            this.gbox.Controls.Add(this.rBPre2);
            this.gbox.Controls.Add(this.rBPre1);
            this.gbox.ForeColor = System.Drawing.Color.White;
            this.gbox.Location = new System.Drawing.Point(3, 50);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(75, 62);
            this.gbox.TabIndex = 114;
            this.gbox.TabStop = false;
            this.gbox.Text = "Prefijo";
            // 
            // rBPre3
            // 
            this.rBPre3.AutoSize = true;
            this.rBPre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPre3.Location = new System.Drawing.Point(9, 42);
            this.rBPre3.Name = "rBPre3";
            this.rBPre3.Size = new System.Drawing.Size(45, 17);
            this.rBPre3.TabIndex = 2;
            this.rBPre3.Text = "Otro";
            this.rBPre3.UseVisualStyleBackColor = true;
            // 
            // rBPre2
            // 
            this.rBPre2.AutoSize = true;
            this.rBPre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPre2.Location = new System.Drawing.Point(9, 26);
            this.rBPre2.Name = "rBPre2";
            this.rBPre2.Size = new System.Drawing.Size(34, 17);
            this.rBPre2.TabIndex = 1;
            this.rBPre2.Text = "Si";
            this.rBPre2.UseVisualStyleBackColor = true;
            // 
            // rBPre1
            // 
            this.rBPre1.AutoSize = true;
            this.rBPre1.Checked = true;
            this.rBPre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPre1.Location = new System.Drawing.Point(9, 9);
            this.rBPre1.Name = "rBPre1";
            this.rBPre1.Size = new System.Drawing.Size(38, 17);
            this.rBPre1.TabIndex = 0;
            this.rBPre1.TabStop = true;
            this.rBPre1.Text = "No";
            this.rBPre1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(890, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 113;
            this.label17.Text = "Mínimo eje y::";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.Red;
            this.txtMin.Location = new System.Drawing.Point(965, 84);
            this.txtMin.MaxLength = 4;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(28, 20);
            this.txtMin.TabIndex = 111;
            this.txtMin.Text = "0";
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.Red;
            this.txtMax.Location = new System.Drawing.Point(965, 62);
            this.txtMax.MaxLength = 4;
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(28, 20);
            this.txtMax.TabIndex = 110;
            this.txtMax.Text = "300";
            this.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(892, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 112;
            this.label18.Text = "Máximo eje y:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(847, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 13);
            this.label16.TabIndex = 109;
            this.label16.Text = "Incremento a 16 horas:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt16h
            // 
            this.txt16h.BackColor = System.Drawing.Color.Red;
            this.txt16h.Location = new System.Drawing.Point(965, 24);
            this.txt16h.MaxLength = 4;
            this.txt16h.Name = "txt16h";
            this.txt16h.Size = new System.Drawing.Size(28, 20);
            this.txt16h.TabIndex = 107;
            this.txt16h.Text = "170";
            this.txt16h.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt20h
            // 
            this.txt20h.BackColor = System.Drawing.Color.Red;
            this.txt20h.Location = new System.Drawing.Point(965, 2);
            this.txt20h.MaxLength = 4;
            this.txt20h.Name = "txt20h";
            this.txt20h.Size = new System.Drawing.Size(28, 20);
            this.txt20h.TabIndex = 106;
            this.txt20h.Text = "105";
            this.txt20h.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt20h.TextChanged += new System.EventHandler(this.txt20h_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(847, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 108;
            this.label11.Text = "Incremento a 20 horas:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(379, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 105;
            this.label6.Text = "Planta:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 104;
            this.label8.Text = "Concretera:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbConcretera.DisplayMember = "IdConcretera";
            this.cmbConcretera.Location = new System.Drawing.Point(419, 57);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(78, 21);
            this.cmbConcretera.TabIndex = 102;
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
            this.cmbPlanta.Location = new System.Drawing.Point(419, 83);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(78, 21);
            this.cmbPlanta.TabIndex = 103;
            this.cmbPlanta.ValueMember = "IdPlanta";
            // 
            // dsPlanta1
            // 
            this.dsPlanta1.DataSetName = "dsPlanta";
            this.dsPlanta1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chbTodas
            // 
            this.chbTodas.AutoSize = true;
            this.chbTodas.Checked = true;
            this.chbTodas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTodas.Location = new System.Drawing.Point(442, 6);
            this.chbTodas.Name = "chbTodas";
            this.chbTodas.Size = new System.Drawing.Size(130, 17);
            this.chbTodas.TabIndex = 101;
            this.chbTodas.Text = "Todas las resistencias";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(615, 88);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 20);
            this.textBox2.TabIndex = 97;
            this.textBox2.Text = "-21";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Red;
            this.textBox3.Location = new System.Drawing.Point(615, 70);
            this.textBox3.MaxLength = 4;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(28, 20);
            this.textBox3.TabIndex = 96;
            this.textBox3.Text = "-71";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Red;
            this.textBox4.Location = new System.Drawing.Point(615, 48);
            this.textBox4.MaxLength = 4;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(28, 20);
            this.textBox4.TabIndex = 95;
            this.textBox4.Text = "1";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(521, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 98;
            this.label9.Text = "Incremento a EE:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.ForeColor = System.Drawing.Color.White;
            this.chbLab.Location = new System.Drawing.Point(240, 81);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 25);
            this.chbLab.TabIndex = 94;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataSource = this.dsTipo1.Tipo;
            this.cmbTipo.DisplayMember = "DesTipo";
            this.cmbTipo.Location = new System.Drawing.Point(149, 59);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(84, 21);
            this.cmbTipo.TabIndex = 93;
            this.cmbTipo.ValueMember = "Tipo";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // dsTipo1
            // 
            this.dsTipo1.DataSetName = "dsTipo";
            this.dsTipo1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(647, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 92;
            this.label15.Text = "1 dia:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(647, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 91;
            this.label14.Text = "3 dias:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(647, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "7 dias:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(588, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 89;
            this.label10.Text = "Edad especificada:";
            // 
            // txtResis4
            // 
            this.txtResis4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResis4.Location = new System.Drawing.Point(786, 2);
            this.txtResis4.MaxLength = 3;
            this.txtResis4.Name = "txtResis4";
            this.txtResis4.Size = new System.Drawing.Size(32, 20);
            this.txtResis4.TabIndex = 88;
            this.txtResis4.Text = "300";
            this.txtResis4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResis4.TextChanged += new System.EventHandler(this.txtResis4_TextChanged);
            // 
            // txtResis3
            // 
            this.txtResis3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResis3.Location = new System.Drawing.Point(752, 2);
            this.txtResis3.MaxLength = 3;
            this.txtResis3.Name = "txtResis3";
            this.txtResis3.Size = new System.Drawing.Size(32, 20);
            this.txtResis3.TabIndex = 87;
            this.txtResis3.Text = "250";
            this.txtResis3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResis3.TextChanged += new System.EventHandler(this.txtResis3_TextChanged);
            // 
            // txtResis2
            // 
            this.txtResis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResis2.Location = new System.Drawing.Point(722, 2);
            this.txtResis2.MaxLength = 3;
            this.txtResis2.Name = "txtResis2";
            this.txtResis2.ReadOnly = true;
            this.txtResis2.Size = new System.Drawing.Size(28, 20);
            this.txtResis2.TabIndex = 86;
            this.txtResis2.Text = "200";
            this.txtResis2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResis2.TextChanged += new System.EventHandler(this.txtResis2_TextChanged);
            // 
            // txtResis1
            // 
            this.txtResis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResis1.Location = new System.Drawing.Point(688, 2);
            this.txtResis1.MaxLength = 3;
            this.txtResis1.Name = "txtResis1";
            this.txtResis1.Size = new System.Drawing.Size(32, 20);
            this.txtResis1.TabIndex = 85;
            this.txtResis1.Text = "150";
            this.txtResis1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResis1.TextChanged += new System.EventHandler(this.txtResis1_TextChanged);
            // 
            // txtLan3001
            // 
            this.txtLan3001.Location = new System.Drawing.Point(786, 88);
            this.txtLan3001.MaxLength = 4;
            this.txtLan3001.Name = "txtLan3001";
            this.txtLan3001.Size = new System.Drawing.Size(32, 20);
            this.txtLan3001.TabIndex = 82;
            this.txtLan3001.Text = "50";
            this.txtLan3001.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan3003
            // 
            this.txtLan3003.Location = new System.Drawing.Point(786, 68);
            this.txtLan3003.MaxLength = 4;
            this.txtLan3003.Name = "txtLan3003";
            this.txtLan3003.Size = new System.Drawing.Size(32, 20);
            this.txtLan3003.TabIndex = 81;
            this.txtLan3003.Text = "30";
            this.txtLan3003.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan2501
            // 
            this.txtLan2501.Location = new System.Drawing.Point(752, 88);
            this.txtLan2501.MaxLength = 4;
            this.txtLan2501.Name = "txtLan2501";
            this.txtLan2501.Size = new System.Drawing.Size(32, 20);
            this.txtLan2501.TabIndex = 80;
            this.txtLan2501.Text = "90";
            this.txtLan2501.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan2503
            // 
            this.txtLan2503.Location = new System.Drawing.Point(752, 68);
            this.txtLan2503.MaxLength = 4;
            this.txtLan2503.Name = "txtLan2503";
            this.txtLan2503.Size = new System.Drawing.Size(32, 20);
            this.txtLan2503.TabIndex = 79;
            this.txtLan2503.Text = "70";
            this.txtLan2503.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan2001
            // 
            this.txtLan2001.Location = new System.Drawing.Point(722, 88);
            this.txtLan2001.MaxLength = 4;
            this.txtLan2001.Name = "txtLan2001";
            this.txtLan2001.Size = new System.Drawing.Size(28, 20);
            this.txtLan2001.TabIndex = 78;
            this.txtLan2001.Text = "140";
            this.txtLan2001.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan2003
            // 
            this.txtLan2003.Location = new System.Drawing.Point(722, 68);
            this.txtLan2003.MaxLength = 4;
            this.txtLan2003.Name = "txtLan2003";
            this.txtLan2003.Size = new System.Drawing.Size(28, 20);
            this.txtLan2003.TabIndex = 77;
            this.txtLan2003.Text = "120";
            this.txtLan2003.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan1501
            // 
            this.txtLan1501.Location = new System.Drawing.Point(688, 88);
            this.txtLan1501.MaxLength = 4;
            this.txtLan1501.Name = "txtLan1501";
            this.txtLan1501.Size = new System.Drawing.Size(32, 20);
            this.txtLan1501.TabIndex = 76;
            this.txtLan1501.Text = "180";
            this.txtLan1501.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan1503
            // 
            this.txtLan1503.Location = new System.Drawing.Point(688, 68);
            this.txtLan1503.MaxLength = 4;
            this.txtLan1503.Name = "txtLan1503";
            this.txtLan1503.Size = new System.Drawing.Size(32, 20);
            this.txtLan1503.TabIndex = 75;
            this.txtLan1503.Text = "160";
            this.txtLan1503.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.ForeColor = System.Drawing.Color.White;
            this.cbkPrefijo.Location = new System.Drawing.Point(360, 31);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(129, 24);
            this.cbkPrefijo.TabIndex = 71;
            this.cbkPrefijo.Text = "No prefijo concretera";
            this.cbkPrefijo.CheckedChanged += new System.EventHandler(this.cbkPrefijo_CheckedChanged);
            // 
            // txtLan3007
            // 
            this.txtLan3007.Location = new System.Drawing.Point(786, 48);
            this.txtLan3007.MaxLength = 4;
            this.txtLan3007.Name = "txtLan3007";
            this.txtLan3007.Size = new System.Drawing.Size(32, 20);
            this.txtLan3007.TabIndex = 60;
            this.txtLan3007.Text = "0";
            this.txtLan3007.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan30EE
            // 
            this.txtLan30EE.Location = new System.Drawing.Point(786, 28);
            this.txtLan30EE.MaxLength = 4;
            this.txtLan30EE.Name = "txtLan30EE";
            this.txtLan30EE.Size = new System.Drawing.Size(32, 20);
            this.txtLan30EE.TabIndex = 59;
            this.txtLan30EE.Text = "-100";
            this.txtLan30EE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan2507
            // 
            this.txtLan2507.Location = new System.Drawing.Point(752, 48);
            this.txtLan2507.MaxLength = 4;
            this.txtLan2507.Name = "txtLan2507";
            this.txtLan2507.Size = new System.Drawing.Size(32, 20);
            this.txtLan2507.TabIndex = 57;
            this.txtLan2507.Text = "30";
            this.txtLan2507.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan25EE
            // 
            this.txtLan25EE.Location = new System.Drawing.Point(752, 28);
            this.txtLan25EE.MaxLength = 4;
            this.txtLan25EE.Name = "txtLan25EE";
            this.txtLan25EE.Size = new System.Drawing.Size(32, 20);
            this.txtLan25EE.TabIndex = 56;
            this.txtLan25EE.Text = "-50";
            this.txtLan25EE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan2007
            // 
            this.txtLan2007.Location = new System.Drawing.Point(722, 48);
            this.txtLan2007.MaxLength = 4;
            this.txtLan2007.Name = "txtLan2007";
            this.txtLan2007.Size = new System.Drawing.Size(28, 20);
            this.txtLan2007.TabIndex = 54;
            this.txtLan2007.Text = "80";
            this.txtLan2007.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan20EE
            // 
            this.txtLan20EE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLan20EE.ForeColor = System.Drawing.Color.Red;
            this.txtLan20EE.Location = new System.Drawing.Point(722, 28);
            this.txtLan20EE.MaxLength = 4;
            this.txtLan20EE.Name = "txtLan20EE";
            this.txtLan20EE.Size = new System.Drawing.Size(28, 20);
            this.txtLan20EE.TabIndex = 53;
            this.txtLan20EE.Text = "0";
            this.txtLan20EE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLan20EE.UseWaitCursor = true;
            // 
            // txtLan1507
            // 
            this.txtLan1507.Location = new System.Drawing.Point(688, 48);
            this.txtLan1507.MaxLength = 4;
            this.txtLan1507.Name = "txtLan1507";
            this.txtLan1507.Size = new System.Drawing.Size(32, 20);
            this.txtLan1507.TabIndex = 51;
            this.txtLan1507.Text = "120";
            this.txtLan1507.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLan15EE
            // 
            this.txtLan15EE.Location = new System.Drawing.Point(688, 28);
            this.txtLan15EE.MaxLength = 4;
            this.txtLan15EE.Name = "txtLan15EE";
            this.txtLan15EE.Size = new System.Drawing.Size(32, 20);
            this.txtLan15EE.TabIndex = 50;
            this.txtLan15EE.Text = "50";
            this.txtLan15EE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(591, 6);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Experiencia res";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(115, 61);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Tipo:";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataSource = this.dsUnidad1;
            this.cmbUnidad.DisplayMember = "Unidad.Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(149, 85);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(84, 21);
            this.cmbUnidad.TabIndex = 10;
            this.cmbUnidad.ValueMember = "Unidad.IdUnidad";
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
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(103, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(270, 57);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(238, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(270, 36);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            this.dtpIni.ValueChanged += new System.EventHandler(this.dtpIni_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(234, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carta de control y distribución de frecuencias";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(140, 38);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(60, 31);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // sqlDADatos
            // 
            this.sqlDADatos.SelectCommand = this.sqlSelectCommand1;
            this.sqlDADatos.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "InfDistribucion", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("ResKg", "ResKg"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("Resul", "Resul")}),
            new System.Data.Common.DataTableMapping("Table1", "Table1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Column1", "Column1"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Column2", "Column2"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("Column3", "Column3")}),
            new System.Data.Common.DataTableMapping("Table2", "Table2", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Column1", "Column1"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Column2", "Column2"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("Column3", "Column3")}),
            new System.Data.Common.DataTableMapping("Table3", "Table3", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Column1", "Column1"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Column2", "Column2"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("Column3", "Column3")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[InfDistribucion]";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@TipoCon", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@IdReporte", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Resis1", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Resis2", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Resis3", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Resis4", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan15EE", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan20EE", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan25EE", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan30EE", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan1507", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan2007", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan2507", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan3007", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan1503", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan2003", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan2503", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan3003", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan1501", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan2001", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan2501", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Lan3001", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsDatos1
            // 
            this.dsDatos1.DataSetName = "dsDatos";
            this.dsDatos1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDatos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAUnidad
            // 
            this.sqlDAUnidad.SelectCommand = this.sqlCommand1;
            this.sqlDAUnidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Unidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Factor", "Factor"),
                        new System.Data.Common.DataColumnMapping("Undescr", "Undescr"),
                        new System.Data.Common.DataColumnMapping("MaxagrUn", "MaxagrUn"),
                        new System.Data.Common.DataColumnMapping("RevenUn", "RevenUn")})});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT IdUnidad, Factor, Undescr, MaxagrUn, RevenUn FROM Unidad";
            this.sqlCommand1.Connection = this.sqlConn;
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
            // dsGraDis1
            // 
            this.dsGraDis1.DataSetName = "dsGraDis";
            this.dsGraDis1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsGraDis1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crvGraDis
            // 
            this.crvGraDis.ActiveViewIndex = -1;
            this.crvGraDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvGraDis.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvGraDis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvGraDis.EnableRefresh = false;
            this.crvGraDis.Location = new System.Drawing.Point(0, 114);
            this.crvGraDis.Name = "crvGraDis";
            this.crvGraDis.ShowCloseButton = false;
            this.crvGraDis.ShowGroupTreeButton = false;
            this.crvGraDis.ShowLogo = false;
            this.crvGraDis.ShowRefreshButton = false;
            this.crvGraDis.Size = new System.Drawing.Size(1005, 566);
            this.crvGraDis.TabIndex = 12;
            this.crvGraDis.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(98, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 432);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(578, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 432);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // sqlDADatosT
            // 
            this.sqlDADatosT.SelectCommand = this.sqlSelectCommand2;
            this.sqlDADatosT.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "InfDistribucionT", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("ResKg", "ResKg"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("Resul", "Resul")}),
            new System.Data.Common.DataTableMapping("Table1", "Table1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Column1", "Column1"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("ResKg", "ResKg"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("Resul", "Resul")}),
            new System.Data.Common.DataTableMapping("Table2", "Table2", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Column1", "Column1"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("ResKg", "ResKg"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("Resul", "Resul")}),
            new System.Data.Common.DataTableMapping("Table3", "Table3", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Column1", "Column1"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("ResKg", "ResKg"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("Resul", "Resul")}),
            new System.Data.Common.DataTableMapping("Table4", "Table4", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Column1", "Column1"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("ResKg", "ResKg"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("Resul", "Resul")}),
            new System.Data.Common.DataTableMapping("Table5", "Table5", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("MediaEE", "MediaEE"),
                        new System.Data.Common.DataColumnMapping("DesEsEE", "DesEsEE"),
                        new System.Data.Common.DataColumnMapping("CoeVaEE", "CoeVaEE"),
                        new System.Data.Common.DataColumnMapping("NEE", "NEE"),
                        new System.Data.Common.DataColumnMapping("Media07", "Media07"),
                        new System.Data.Common.DataColumnMapping("DesEs07", "DesEs07"),
                        new System.Data.Common.DataColumnMapping("CoeVa07", "CoeVa07"),
                        new System.Data.Common.DataColumnMapping("N07", "N07"),
                        new System.Data.Common.DataColumnMapping("Media03", "Media03"),
                        new System.Data.Common.DataColumnMapping("DesEs03", "DesEs03"),
                        new System.Data.Common.DataColumnMapping("CoeVa03", "CoeVa03"),
                        new System.Data.Common.DataColumnMapping("N03", "N03"),
                        new System.Data.Common.DataColumnMapping("Media01", "Media01"),
                        new System.Data.Common.DataColumnMapping("DesEs01", "DesEs01"),
                        new System.Data.Common.DataColumnMapping("CoeVa01", "CoeVa01"),
                        new System.Data.Common.DataColumnMapping("N01", "N01"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana")}),
            new System.Data.Common.DataTableMapping("Table6", "Table6", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Cuart", "Cuart"),
                        new System.Data.Common.DataColumnMapping("N", "N")})});
            this.sqlDADatosT.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(this.sqlDADatosT_RowUpdated);
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "[InfDistribucionT]";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@TipoCon", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@IdReporte", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Inc7aEE", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Inc3aEE", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Inc1aEE", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Inc16X1", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Inc20X2", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Prefijo", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IncaEE", System.Data.SqlDbType.Real, 4)});
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
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // sqlDABusObra
            // 
            this.sqlDABusObra.SelectCommand = this.sqlCommand2;
            this.sqlDABusObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT     CONVERT(VARCHAR(10), Fecha, 103) AS Fecha, Cemento\r\nFROM         Muest" +
    "reador\r\nWHERE     (IdObra = @IdObra) AND (Cemento IS NOT NULL) AND (Fecha >= @Fe" +
    "chaI) AND (Fecha <= @FechaF)";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@FechaI", System.Data.SqlDbType.DateTime, 8, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@FechaF", System.Data.SqlDbType.DateTime, 8, "Fecha")});
            // 
            // sqlDACemento
            // 
            this.sqlDACemento.SelectCommand = this.sqlSelectCommand3;
            this.sqlDACemento.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestreador", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Cemento", "Cemento")})});
            // 
            // dsCementoC1
            // 
            this.dsCementoC1.DataSetName = "dsCementoC";
            this.dsCementoC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsCemDia1
            // 
            this.dsCemDia1.DataSetName = "dsCemDia";
            this.dsCemDia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InfDistrib
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1005, 680);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crvGraDis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "InfDistrib";
            this.Text = "InfDistrib";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfDistrib_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGraDis1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCementoC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCemDia1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		protected GraphPane myPane;
		protected GraphPane myPane1;

		private void InfDistrib_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsBuscaObra1, "Obra");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			cmbUnidad.SelectedIndex = 0;
			sqlDATipo.Fill(dsTipo1, "Tipo");
			cmbTipo.SelectedIndex = 0;
			dsConcretera1.Concretera.AddConcreteraRow("Todas","Todas","%");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			cmbConcretera.SelectedIndex = 0;
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",(cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString()));
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue);
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			double[,] datos = new double[150, 36];
			double[,] media = new double[5, 35];
			double[] ua = new double[30];
			double[] va = new double[30];
			double[] xa = new double[30];
			double[] ya = new double[30];
            double[] y1 = new double[30];
            double[] y2 = new double[30];
            double[] wa = new double[30];
			double[] za = new double[30];
			double[] xaa = new double[2];
			double[] C200 = new double[2];
			int min = int.Parse(txtMin.Text);
			int max = int.Parse(txtMax.Text);
			int[] ren = new int[150];
			int[] dic = new int[30];
            decimal[] Cemento = new decimal[30];
			int col, d1, d2, renm, dia, ren28, ren07, ren03, ren01, renx1, renx2, renr, edad;
			string Etiqueta = " Edad", Titulo;
			double suma;
			dsDatos1.Clear();
			dsGraDis1.Clear();
            int erre = 0;

            renr = 7;
            if (int.Parse(cmbTipo.SelectedValue.ToString()) == 1 || int.Parse(cmbTipo.SelectedValue.ToString()) == 2)
            	edad = 14;
            if (int.Parse(cmbTipo.SelectedValue.ToString()) == 6 || int.Parse(cmbTipo.SelectedValue.ToString()) == 11)
            	edad = 7;
            if (int.Parse(cmbTipo.SelectedValue.ToString()) == 7 || int.Parse(cmbTipo.SelectedValue.ToString()) == 12)
            	edad = 3;
            if (int.Parse(cmbTipo.SelectedValue.ToString()) == 8 || int.Parse(cmbTipo.SelectedValue.ToString()) == 13)
            	edad = 1;
            sqlDACemento.SelectCommand.Parameters["@IdObra"].Value = (rBPre1.Checked == true ? cmbIdObra.SelectedValue.ToString() : cmbIdObra.SelectedValue.ToString() + "%");
            sqlDACemento.SelectCommand.Parameters["@FechaI"].Value = dtpIni.Text;
            sqlDACemento.SelectCommand.Parameters["@FechaF"].Value = dtpFin.Text;
            sqlDACemento.Fill(dsCementoC1, "Muestreador");

            if (chbTodas.Checked == false)
				{
                    cryInfGraDis1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    cryInfGraDis1.SetDataSource(dsGraDis1);

                    sqlDADatos.SelectCommand.Parameters["@IdObra"].Value = (rBPre1.Checked == true ? cmbIdObra.SelectedValue.ToString() : cmbIdObra.SelectedValue.ToString() + "%");
				    sqlDADatos.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
				    sqlDADatos.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
				    sqlDADatos.SelectCommand.Parameters["@TipoCon"].Value = cmbTipo.SelectedValue;
				    sqlDADatos.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
				    sqlDADatos.SelectCommand.Parameters["@Resis1"].Value = txtResis1.Text;
				    sqlDADatos.SelectCommand.Parameters["@Resis2"].Value = txtResis2.Text;
				    sqlDADatos.SelectCommand.Parameters["@Resis3"].Value = txtResis3.Text;
				    sqlDADatos.SelectCommand.Parameters["@Resis4"].Value = txtResis4.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan15EE"].Value = txtLan15EE.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan20EE"].Value = txtLan20EE.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan25EE"].Value = txtLan25EE.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan30EE"].Value = txtLan30EE.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan1507"].Value = txtLan1507.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan2007"].Value = txtLan2007.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan2507"].Value = txtLan2507.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan3007"].Value = txtLan3007.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan1503"].Value = txtLan1503.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan2003"].Value = txtLan2003.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan2503"].Value = txtLan2503.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan3003"].Value = txtLan3003.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan1501"].Value = txtLan1501.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan2001"].Value = txtLan2001.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan2501"].Value = txtLan2501.Text;
				    sqlDADatos.SelectCommand.Parameters["@Lan3001"].Value = txtLan3001.Text;
				    sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 0;
                    sqlDADatos.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : (cbkPrefijo.Checked == false ? cmbConcretera.SelectedValue.ToString().Trim() + "%" : cmbConcretera.SelectedValue.ToString()));
				    sqlDADatos.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
				    sqlDADatos.Fill(dsDatos1, "InfDistribucion");
				    sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 1;
				    sqlDADatos.Fill(dsDatos1, "Total");
				    sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 2;
				    sqlDADatos.Fill(dsDatos1, "Media");
				    sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 3;
				    sqlDADatos.Fill(dsDatos1, "Erre");
				    sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 4;
				    sqlDADatos.Fill(dsDatos1, "Semanal");
				    sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 5;
				    sqlDADatos.Fill(dsGraDis1, "Estadisticos");
				    sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 6;
				    sqlDADatos.Fill(dsDatos1, "Barra");
			}
			else
				{

                    cryInfGraDis1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    cryInfGraDis1.SetDataSource(dsGraDis1);

                    sqlDADatosT.SelectCommand.Parameters["@IdObra"].Value = (rBPre1.Checked == true ? cmbIdObra.SelectedValue.ToString() : cmbIdObra.SelectedValue.ToString() + "%");
				    sqlDADatosT.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
				    sqlDADatosT.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
				    sqlDADatosT.SelectCommand.Parameters["@TipoCon"].Value = cmbTipo.SelectedValue;
				    sqlDADatosT.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
				    sqlDADatosT.SelectCommand.Parameters["@Inc7aEE"].Value = textBox4.Text;
				    sqlDADatosT.SelectCommand.Parameters["@Inc3aEE"].Value = textBox3.Text;
				    sqlDADatosT.SelectCommand.Parameters["@Inc1aEE"].Value = textBox2.Text;
                    sqlDADatosT.SelectCommand.Parameters["@Inc16X1"].Value = txt16h.Text;
                    sqlDADatosT.SelectCommand.Parameters["@Inc20X2"].Value = txt20h.Text;
                    sqlDADatosT.SelectCommand.Parameters["@IncaEE"].Value = txtLan20EE.Text;
                    sqlDADatosT.SelectCommand.Parameters["@Prefijo"].Value = (rBPre3.Checked == true ? 3 : 1);
                    sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 0;
                    sqlDADatosT.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : (cbkPrefijo.Checked == false ? cmbConcretera.SelectedValue.ToString().Trim() + "%" : cmbConcretera.SelectedValue.ToString()));
				    sqlDADatosT.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
				    sqlDADatosT.Fill(dsDatos1, "InfDistribucion");
				    sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 1;
				    sqlDADatosT.Fill(dsDatos1, "Total");
				    sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 2;
				    sqlDADatosT.Fill(dsDatos1, "Media");
				    sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 3;
				    sqlDADatosT.Fill(dsDatos1, "Erre");
				    sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 4;
				    sqlDADatosT.Fill(dsDatos1, "Semanal");
				    sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 5;
				    sqlDADatosT.Fill(dsGraDis1, "Estadisticos");
				    sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 6;
				    sqlDADatosT.Fill(dsDatos1, "Barra");
                    sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 7;
                    sqlDADatosT.Fill(dsGraDis1, "Estadisticos1");
                }
			int renDatos = dsDatos1.InfDistribucion.Rows.Count;
			col = renm  = ren28 = ren07 = ren03 = ren01 = renx1 = renx2 = renr = 0 ;
			int d1ant = int.Parse(dsDatos1.InfDistribucion.Rows[0]["d1"].ToString());
            for (int i = 0; i < 150; i++)
				ren [i] = 0;
			for (int i = 0; i < renDatos; i++)
			{
				d1 = int.Parse(dsDatos1.InfDistribucion.Rows[i]["d1"].ToString());
				if (d1 == d1ant)
				{
					dia = int.Parse(dsDatos1.InfDistribucion.Rows[i]["Dia"].ToString());
					if (dia > 6 && dia < 14)
						dia = dia -1;
					else if (dia > 13 && dia < 21)
						dia = dia -2;
					else if (dia > 20 && dia < 28)
						dia = dia -3;
					else if (dia > 27 && dia < 35)
						dia = dia -4;
					datos[ren[dia],35] = d1;
					datos[ren[dia]++,dia] = double.Parse(dsDatos1.InfDistribucion.Rows[i]["Resul"].ToString());
				}
				else
				{
					renm = ren[0];
					for (int j = 0; j < 35; j++)
						if (renm < ren[j])
							renm = ren[j];
					datos[renm,35] = d1ant;
					ren28 = (d1ant >= 14 ? renm : ren28);
					ren07 = (d1ant == 07 ? renm : ren07);
					ren03 = (d1ant == 03 ? renm : ren03);
					ren01 = (d1ant == 01 ? renm : ren01);
                    renx1 = (d1ant == -1 ? renm : renx1);
                    renx2 = (d1ant == -2 ? renm : renx2);
                    renm = renm + 4;
					for (int j = 0; j < 35; j++)
							ren[j] = renm;
					d1ant= d1;
					dia = int.Parse(dsDatos1.InfDistribucion.Rows[i]["Dia"].ToString());
					if (dia > 6 && dia < 14)
						dia = dia -1;
					else if (dia > 13 && dia < 21)
						dia = dia -2;
					else if (dia > 20 && dia < 28)
						dia = dia -3;
					else if (dia > 27 && dia < 35)
						dia = dia -4;
					datos[ren[dia],35] = d1;
					datos[ren[dia]++,dia] = double.Parse(dsDatos1.InfDistribucion.Rows[i]["Resul"].ToString());
				}
				renm = ren[0];
				for (int j = 0; j < 35; j++)
					if (renm < ren[j])
						renm = ren[j];
				datos[renm,35] = d1ant;
				ren28 = (d1ant >= 14 ? renm : ren28);
				ren07 = (d1ant == 07 ? renm : ren07);
				ren03 = (d1ant == 03 ? renm : ren03);
				ren01 = (d1ant == 01 ? renm : ren01);
                renx1 = (d1ant == -1 ? renm : renx1);
                renx2 = (d1ant == -2 ? renm : renx2);
            }

            renDatos = dsDatos1.Media.Rows.Count;
			for (int i = 0; i < renDatos; i++)
			{
				d2 = d1 = int.Parse(dsDatos1.Media.Rows[i]["d1"].ToString());
				if(d1 >= 14)
					d1 = ren28;
				else if (d1 == 07)
					d1 = ren07;
				else if (d1 == 03)
					d1 = ren03;
				else if (d1 == 01) 
					d1 = ren01;
                else if (d1 == -1)
                    d1 = renx1;
                else if (d1 == -2)
                    d1 = renx2;
                dia = int.Parse(dsDatos1.Media.Rows[i]["Dia"].ToString());
				if (dia > 6 && dia < 14)
					dia = dia -1;
				else if (dia > 13 && dia < 21)
					dia = dia -2;
				else if (dia > 20 && dia < 28)
					dia = dia -3;
				else if (dia > 27 && dia < 35)
					dia = dia -4;
				datos[d1+1,35] = d2;
				datos[d1+1,dia] = double.Parse(dsDatos1.Media.Rows[i]["Resul"].ToString());
			}
			ren01 = (ren01 == 0 ? 146 : ren01); // modificado 20161023 de 145 a 146
            renx1 = (renx1 == 0 ? 146 : renx1);
            renx2 = (renx2 == 0 ? 146 : renx2);
            renDatos = dsDatos1.Semanal.Rows.Count;
			for (int i = 0; i < renDatos; i++)
			{
				d2 = d1 = int.Parse(dsDatos1.Semanal.Rows[i]["d1"].ToString());
				if(d1 >= 14)
					d1 = ren28;
				else if (d1 == 07)
					d1 = ren07;
				else if (d1 == 03)
					d1 = ren03;
				else if (d1 == 01) 
					d1 = ren01;
                else if (d1 == -1)
                    d1 = renx1;
                else if (d1 == -2)
                    d1 = renx2;
                dia = int.Parse(dsDatos1.Semanal.Rows[i]["Dia"].ToString());
				if (dia <= 6 )
					dia = 5;
				else if (dia > 6 && dia < 14)
					dia = 11;
				else if (dia > 13 && dia < 21)
					dia = 17;
				else if (dia > 20 && dia < 28)
					dia = 23;
				else if (dia > 27 && dia < 35)
					dia = 29;
				datos[d1+2,35] = d2;
				datos[d1+2,dia] = double.Parse(dsDatos1.Semanal.Rows[i]["Resul"].ToString());
			}
			renDatos = dsDatos1.Erre.Rows.Count;
			for (int i = 0; i < renDatos; i++)
			{
				d2 = d1 = int.Parse(dsDatos1.Erre.Rows[i]["d1"].ToString());
				if(d1 >= 14)
					d1 = ren28;
				else if (d1 == 07)
					d1 = ren07;
				else if (d1 == 03)
					d1 = ren03;
				else if (d1 == 01) 
					d1 = ren01;
                else if (d1 == -1)
                    d1 = renx1;
                else if (d1 == -2)
                    d1 = renx2;
                dia = int.Parse(dsDatos1.Erre.Rows[i]["Dia"].ToString());
				if (dia > 6 && dia < 14)
					dia = dia -1;
				else if (dia > 13 && dia < 21)
					dia = dia -2;
				else if (dia > 20 && dia < 28)
					dia = dia -3;
				else if (dia > 27 && dia < 35)
					dia = dia -4;
				datos[d1+3,35] = d2;
				datos[d1+3,dia] = double.Parse(dsDatos1.Erre.Rows[i]["Resul"].ToString());
			}
			for (int i = 0; i < 145; i++)
			{
				suma = 0;
				for (int j = 0; j < 34; j++)
					suma = suma +  datos[i,j];
				if (datos[i,35] == 28)
					Etiqueta = "28 días";
                else if (datos[i, 35] == 14)
                    Etiqueta = "14 días";
                else if (datos[i, 35] == 7)
						 Etiqueta = "7 días";
				else if (datos[i,35] == 3)
						 Etiqueta = "3 días";
				else if (datos[i,35] == 1)
						 Etiqueta = "1 día";
                else if (datos[i, 35] == -1)
                    Etiqueta = "20 horas";
                else if (datos[i, 35] == -2)
                    Etiqueta = "16 horas";
                Titulo = System.Convert.ToString(i + 1);
                if ((i == (ren28 == 0 ? 145 : ren28) + 3 || i == ren07 + 3 || i == ren03 + 3 || i == ren01 + 3 || i == renx1 + 3 || i == renx2 + 3) && suma == 0)
                    erre = 0;
                else
                    erre = 1;
                if (suma > 0 )
				{
//					if (i == (ren28 == 0 ? 90 : ren28) + 1 || i == ren07 + 1 || i == ren03 + 1 || i == ren01 + 1)
//						Titulo = "TOTAL";
                    if (i == (ren28 == 0 ? 145 : ren28) + 1 || i == ren07 + 1 || i == ren03 + 1 || i == ren01 + 1 || i == renx1 + 1 || i == renx2 + 1)
						Titulo = "Media";
                    if (i == (ren28 == 0 ? 145 : ren28) + 2 || i == ren07 + 2 || i == ren03 + 2 || i == ren01 + 2 || i == renx1 + 2 || i == renx2 + 2)
						Titulo = "Media Semanal";
                    if (i == (ren28 == 0 ? 145 : ren28) + 3 || i == ren07 + 3 || i == ren03 + 3 || i == ren01 + 3)
                    {
                        Titulo = "R";
                        renr = i-3;
                    }
                        dsGraDis1.Gradis.AddGradisRow(i.ToString(), datos[i, 0], datos[i, 1], datos[i, 2], datos[i, 3], datos[i, 4], datos[i, 5], datos[i, 6], datos[i, 7], datos[i, 8], datos[i, 9], datos[i, 10], datos[i, 11],
                        datos[i, 12], datos[i, 13], datos[i, 14], datos[i, 15], datos[i, 16], datos[i, 17], datos[i, 18], datos[i, 19], datos[i, 20], datos[i, 21], datos[i, 22], datos[i, 23], datos[i, 24], datos[i, 25], datos[i, 26], datos[i, 27], 
                        datos[i, 28], datos[i, 29], datos[i, 28], Etiqueta.Trim(), Titulo);
                    if (i == ren28 + 1 && ren28 != 0)
				for (int j = 0; j < 30; j++)
					ua[j] = datos[i,j];
			if (i == ren07 + 1 && ren07 != 0)
				for (int j = 0; j < 30; j++)
					va[j] = datos[i,j];
			if (i == renr + 3 && renr != 0)
				for (int j = 0; j < 30; j++)
					za[j] = datos[i,j];
			if (i == ren03 + 1 && ren03 != 0)
				for (int j = 0; j < 30; j++)
					wa[j] = datos[i,j];
			if (i == ren01 + 1 && ren01 != 0)
				for (int j = 0; j < 30; j++)
					ya[j] = datos[i,j];
            if (i == renx1 + 1 && renx1 != 0)
                for (int j = 0; j < 30; j++)
                    y1[j] = datos[i, j];
            if (i == renx2 + 1 && renx2 != 0)
                for (int j = 0; j < 30; j++)
                    y2[j] = datos[i, j];
                }

			}
			DateTime dias = dtpIni.Value;
			int dmes = 0;
			for (int i = 0; i < 35; i++)
				if(dias.AddDays(i).DayOfWeek.ToString() != DayOfWeek.Sunday.ToString())
					dic[dmes++] = dias.AddDays(i).Day;
			dsGraDis1.Dias.AddDiasRow( dic[0], dic[1], dic[2], dic[3], 
				dic[4], dic[5], dic[6], dic[7], dic[8], dic[9], dic[10], dic[11], 
				dic[12], dic[13], dic[14], dic[15], dic[16], dic[17], dic[18], dic[19], 
				dic[20], dic[21], dic[22], dic[23], dic[24], dic[25], dic[26], dic[27], 
				dic[28], dic[29]);

			dias = dtpIni.Value;
			dmes = 0;
            for (int i = 0; i < 35; i++)
                if (dias.AddDays(i).DayOfWeek.ToString() != DayOfWeek.Sunday.ToString())
                {
                    DataRow foundRow = dsCementoC1.Tables["Muestreador"].Rows.Find(dias.AddDays(i).ToString().Substring(0,10));
                    if (foundRow != null)
                    {
                        Cemento[dmes] = Decimal.Parse(foundRow["Cemento"].ToString());
                    }
                    else
                    {
                        //                MessageBox.Show(foundRow[0].ToString());
                    }
                    dmes++;
                }
            dsGraDis1.Cemento.AddCementoRow(Cemento[0], Cemento[1], Cemento[2], Cemento[3],
                Cemento[4], Cemento[5], Cemento[6], Cemento[7], Cemento[8], Cemento[9], Cemento[10], Cemento[11],
                Cemento[12], Cemento[13], Cemento[14], Cemento[15], Cemento[16], Cemento[17], Cemento[18], Cemento[19],
                Cemento[20], Cemento[21], Cemento[22], Cemento[23], Cemento[24], Cemento[25], Cemento[26], Cemento[27],
                Cemento[28], Cemento[29]);

			memGraphics.CreateDoubleBuffer(this.CreateGraphics(),
				this.ClientRectangle.Width, this.ClientRectangle.Height);

			myPane = new GraphPane( new Rectangle( 10, 10, 10, 10 ),
				"CARTA DE CONTROL Y DISTRIBUCIÓN DE FRECUENCIAS", "", "" );
			SetSize();

			for( int j = 0; j < 30; j++)
				xa[j] = j+1;

			CurveItem curve;
			curve = myPane.AddCurve( "E. E:", xa, ua, Color.Black, SymbolType.Circle );
			curve.Line.Width = 2.5F;
			curve.Symbol.Fill = new Fill( Color.Black );
			for (int j = 29; j >= 0; j--)
				if(ua[j] == 0)
					curve.Points.Remove(j);
			curve = myPane.AddCurve( "7 días", xa, va, Color.Blue, SymbolType.Circle);
			curve.Line.Width = 2.5F;
//			curve.Symbol.Fill = new Fill( Color.Blue );
			for (int j = 29; j >= 0; j--)
				if(va[j] == 0)
					curve.Points.Remove(j);
			curve = myPane.AddCurve( "3 días", xa, wa, Color.Brown, SymbolType.Square );
			curve.Line.Width = 2.5F;
//			curve.Symbol.Fill = new Fill( Color.Brown );
			for (int j = 29; j >= 0; j--)
				if(wa[j] == 0)
					curve.Points.Remove(j);
			curve = myPane.AddCurve( "1 día", xa, ya, Color.Red, SymbolType.Square );
			curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.Red);
			curve.Symbol.Size = 8;
			for (int j = 29; j >= 0; j--)
				if(ya[j] == 0)
					curve.Points.Remove(j);

            curve = myPane.AddCurve("16 horas", xa, y1, Color.DarkGreen, SymbolType.Triangle);
            curve.Line.Width = 2.5F;
//            curve.Symbol.Fill = new Fill(Color.DarkGreen);
            curve.Symbol.Size = 8;
            for (int j = 29; j >= 0; j--)
                if (y1[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("20 horas", xa, y2, Color.DarkOrange, SymbolType.Diamond);
            curve.Line.Width = 2.5F;
//            curve.Symbol.Fill = new Fill(Color.DarkOrange);
            curve.Symbol.Size = 8;
            for (int j = 29; j >= 0; j--)
                if (y2[j] == 0)
                    curve.Points.Remove(j);
            
            curve = myPane.AddCurve("R", xa, za, Color.DarkMagenta,SymbolType.Star);
			curve.Line.Width = 1.0F;
			curve.Symbol.Fill = new Fill( Color.DarkMagenta );
			curve.Line.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
//			curve.IsY2Axis = true;
			for (int j = 29; j >= 0; j--)
				if(za[j] == 0)
					curve.Points.Remove(j);
//			curve.Line.IsSmooth = true;
            
			xaa[0] = 0;
			xaa[1] = 30;
			C200[0] = 200;
			C200[1] = 200;
			curve = myPane.AddCurve( "C200", xaa, C200, Color.Black,SymbolType.Empty);
			curve.Line.Width = 2.5F;
			curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
			curve.Symbol.Fill = new Fill( Color.White );
			curve.Symbol.FrameColor =  Color.White ;
			C200[0] = 230;
			C200[1] = 230;
			curve = myPane.AddCurve( "C230", xaa, C200, Color.Black, SymbolType.Empty);
			curve.Line.Width = 2.5F;
			curve.Symbol.Fill = new Fill( Color.White );
			curve.Symbol.FrameColor = Color.White ;
			C200[0] = 260;
			C200[1] = 260;
			curve = myPane.AddCurve( "C260", xaa, C200, Color.Black,SymbolType.Empty);
			curve.Line.Width = 2.5F;
			curve.Symbol.Fill = new Fill( Color.White );
			curve.Symbol.FrameColor = Color.White ;
			C200[0] = 40;
			C200[1] = 40;
			curve = myPane.AddCurve( "C040", xaa, C200, Color.Black,SymbolType.Empty);
			curve.Line.Width = 1.0F;
			curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			curve.Symbol.Fill = new Fill( Color.White );
			curve.Symbol.FrameColor = Color.White ;
//			curve.IsY2Axis = true;
			xaa[0] = 6.5;
			xaa[1] = 6.5;
			C200[0] = min;
			C200[1] = max;
			curve = myPane.AddCurve( "C6.5", xaa, C200, Color.Black,SymbolType.Empty);
			curve.Line.Width = 4.0F;
			curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
			curve.Symbol.Fill = new Fill( Color.White );
			curve.Symbol.FrameColor =  Color.White ;
			xaa[0] = 12.5;
			xaa[1] = 12.5;
			C200[0] = min;
			C200[1] = max;
			curve = myPane.AddCurve( "C13.5", xaa, C200, Color.Black,SymbolType.Empty);
			curve.Line.Width = 4.0F;
			curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
			curve.Symbol.Fill = new Fill( Color.White );
			curve.Symbol.FrameColor =  Color.White ;
			xaa[0] = 18.5;
			xaa[1] = 18.5;
			C200[0] = min;
			C200[1] = max;
			curve = myPane.AddCurve( "C20.5", xaa, C200, Color.Black,SymbolType.Empty);
			curve.Line.Width = 4.0F;
			curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
			curve.Symbol.Fill = new Fill( Color.White );
			curve.Symbol.FrameColor =  Color.White ;
			xaa[0] = 24.5;
			xaa[1] = 24.5;
			C200[0] = min;
			C200[1] = max;
			curve = myPane.AddCurve( "C13.5", xaa, C200, Color.Black,SymbolType.Empty);
			curve.Line.Width = 4.0F;
			curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
			curve.Symbol.Fill = new Fill( Color.White );
			curve.Symbol.FrameColor =  Color.White ;


/*			myPane.Y2Axis.IsShowGrid = true;
			myPane.Y2Axis.Step = 10;
			myPane.Y2Axis.Min = 0;
			myPane.Y2Axis.Max = (max - min);
			myPane.Y2Axis.IsVisible = true;
			myPane.Y2Axis.ScaleFontSpec.Size = 6;
*/			myPane.XAxis.IsShowGrid = true;
			myPane.XAxis.IsTic = true;
			myPane.XAxis.ScaleFontSpec.Angle = 0;
			myPane.XAxis.Min = 0;
			myPane.XAxis.Max = 30;
			myPane.XAxis.IsVisible = false;
			myPane.YAxis.IsShowGrid = true;
			myPane.YAxis.ScaleFontSpec.Angle = 90;
			myPane.YAxis.Min = min;
			myPane.YAxis.Max = max;
			
			//			myPane.YAxis.MaxAuto = true;
			myPane.Legend.IsVisible = false;
			myPane.PaneFill = new Fill( Color.White, Color.White, 0F );

			myPane.AxisChange( this.CreateGraphics() );
			pictureBox1.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
			MemoryStream ms = new MemoryStream();
			pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
			byte[] arrImage = ms.GetBuffer();
			ms.Close();
				
			myPane.Image.Dispose();
			pictureBox1.Image.Dispose();
			dsGraDis1.Grafica.AddGraficaRow(arrImage);

			memGraphics1.CreateDoubleBuffer(this.CreateGraphics(),
				this.ClientRectangle.Width, this.ClientRectangle.Height);

			myPane1 = new GraphPane( new Rectangle( 10, 10, 10, 10 ),
				" ", "", "" );
			SetSize1();

			renDatos = dsDatos1.Barra.Rows.Count;
            int renmc = (renDatos > 31 ? renDatos : 31);
            double[] xxa = new double[renmc];
            double[] yya = new double[renmc];
                ;
			for (int i = 0; i < renDatos; i++)
			{
                if (min <= double.Parse(dsDatos1.Barra.Rows[i][0].ToString()) && double.Parse(dsDatos1.Barra.Rows[i][0].ToString()) <= max)
                {
                    int  j = (int.Parse(dsDatos1.Barra.Rows[i][0].ToString())-min)/10;
                    xxa[j] = double.Parse(dsDatos1.Barra.Rows[i][0].ToString());
                    yya[j] = double.Parse(dsDatos1.Barra.Rows[i][1].ToString());
                }
                else
                {
                    xxa[i] = (i * 10) + min;
                    yya[i] = 0;
                }

			}

			CurveItem curve1;
            curve1 = myPane1.AddBar("Cantidad", yya, xxa, Color.Transparent);

			curve1.Bar.FrameWidth = 12.0F;
            if (int.Parse(cmbTipo.SelectedValue.ToString()) == 1 || int.Parse(cmbTipo.SelectedValue.ToString()) == 2)
                curve1.Bar.FrameColor =  (Color.Black);
            if (int.Parse(cmbTipo.SelectedValue.ToString()) == 6 || int.Parse(cmbTipo.SelectedValue.ToString()) == 11)
                curve1.Bar.FrameColor = (Color.Blue);
            if (int.Parse(cmbTipo.SelectedValue.ToString()) == 7 || int.Parse(cmbTipo.SelectedValue.ToString()) == 12)
                curve1.Bar.FrameColor = (Color.Brown);
            if (int.Parse(cmbTipo.SelectedValue.ToString()) == 8 || int.Parse(cmbTipo.SelectedValue.ToString()) == 13)
                curve1.Bar.FrameColor = (Color.DarkRed);

            curve1.Symbol.Fill = new Fill(Color.Blue);		
			myPane1.BarBase = BarBase.Y;
			myPane1.XAxis.IsShowGrid = true;
			myPane1.XAxis.ScaleFontSpec.Angle = 0;
//			myPane1.XAxis.Min = 0;
//			myPane1.XAxis.Max = 30;
			myPane1.XAxis.MaxAuto = true;
			myPane1.XAxis.ScaleFontSpec.Size = 30;
			myPane1.XAxis.IsVisible = false;
			myPane1.XAxis.IsShowGrid = true;
			myPane1.YAxis.IsShowGrid = true;
			myPane1.YAxis.ScaleFontSpec.Angle = 90;
			myPane1.YAxis.Min = min;
			myPane1.YAxis.Max = max;
//            myPane1.YAxis.v
//			myPane1.YAxis.MaxAuto = true;
			myPane1.YAxis.IsVisible = false;
			myPane1.Legend.IsVisible = false;
//			myPane.YAxis.ScaleFontSpec.Size = 10;
			myPane1.PaneFill = new Fill( Color.White, Color.White, 0F );

			myPane1.AxisChange(this.CreateGraphics());
			pictureBox2.Image = Image.FromHbitmap(myPane1.Image.GetHbitmap());
			pictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
			MemoryStream ms1 = new MemoryStream();
			pictureBox2.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Bmp);
			byte[] arrImage1 = ms1.GetBuffer();
			ms1.Close();
				
			myPane1.Image.Dispose();
			pictureBox2.Image.Dispose();
			dsGraDis1.Barras.AddBarrasRow(arrImage1);


			crvGraDis.Visible = true;
//            cryInfGraDis1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLegal;
			cryInfGraDis1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
            cryInfGraDis1.SetParameterValue("@Obr", (rBPre1.Checked == true ? cmbIdObra.SelectedValue.ToString() : cmbIdObra.SelectedValue.ToString() + "%"));
			cryInfGraDis1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
			cryInfGraDis1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
			cryInfGraDis1.SetParameterValue("@Tip", dsTipo1.Tables[0].Rows[cmbTipo.SelectedIndex][1].ToString());
			cryInfGraDis1.SetParameterValue("@Rev", 0);
			cryInfGraDis1.SetParameterValue("@Fecha", dtpIni.Value.AddDays(20));
			cryInfGraDis1.SetParameterValue("@Resistencias", txtResis1.Text.Trim()+ " " + txtResis2.Text.Trim()+" " + txtResis3.Text.Trim()+ " " + txtResis4.Text.Trim());
			cryInfGraDis1.SetParameterValue("@Resis1", txtResis1.Text.Trim());
			cryInfGraDis1.SetParameterValue("@Resis2", txtResis2.Text.Trim());
			cryInfGraDis1.SetParameterValue("@Resis3", txtResis3.Text.Trim());
			cryInfGraDis1.SetParameterValue("@Resis4", txtResis4.Text.Trim());
			cryInfGraDis1.SetParameterValue("Inc15EE", txtLan15EE.Text);
			cryInfGraDis1.SetParameterValue("Inc1507", txtLan1507.Text);
			cryInfGraDis1.SetParameterValue("Inc1503", txtLan1503.Text);
			cryInfGraDis1.SetParameterValue("Inc1501", txtLan1501.Text);
			cryInfGraDis1.SetParameterValue("Inc20EE", txtLan20EE.Text);
			cryInfGraDis1.SetParameterValue("Inc2007", txtLan2007.Text);
			cryInfGraDis1.SetParameterValue("Inc2003", txtLan2003.Text);
			cryInfGraDis1.SetParameterValue("Inc2001", txtLan2001.Text);
			cryInfGraDis1.SetParameterValue("Inc25EE", txtLan25EE.Text);
			cryInfGraDis1.SetParameterValue("Inc2507", txtLan2507.Text);
			cryInfGraDis1.SetParameterValue("Inc2503", txtLan2503.Text);
			cryInfGraDis1.SetParameterValue("Inc2501", txtLan2501.Text);
			cryInfGraDis1.SetParameterValue("Inc30EE", txtLan30EE.Text);
			cryInfGraDis1.SetParameterValue("Inc3007", txtLan3007.Text);
			cryInfGraDis1.SetParameterValue("Inc3003", txtLan3003.Text);
			cryInfGraDis1.SetParameterValue("Inc3001", txtLan3001.Text);
			cryInfGraDis1.SetParameterValue("@Lab", chbLab.Checked);
            cryInfGraDis1.SetParameterValue("@Con", cmbConcretera.Text.Trim() + (cbkPrefijo.Checked != true ?  "%" : ""));
			cryInfGraDis1.SetParameterValue("@Pla", cmbPlanta.Text);
            cryInfGraDis1.SetParameterValue("@Inc16X1", txt16h.Text);
            cryInfGraDis1.SetParameterValue("@Inc20X2", txt20h.Text);


			
			crvGraDis.ReportSource = cryInfGraDis1;
			// crvGraDis.RefreshReport();
		}

		private void dtpIni_ValueChanged(object sender, System.EventArgs e)
		{
			dtpFin.Value = dtpIni.Value.AddDays(33);
			
		}

		private void SetSize()
		{
			Rectangle paneRect = this.ClientRectangle;
			paneRect.Inflate( -2, -1 );
			this.myPane.PaneRect = paneRect;
		}
		private void SetSize1()
		{
			Rectangle paneRect = this.ClientRectangle;
			paneRect.Inflate( -2, -1 );
			this.myPane1.PaneRect = paneRect;
		}

		private void txtResis2_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void textBox4_TextChanged(object sender, System.EventArgs e)
		{
			txtLan1507.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox4.Text));
			txtLan2007.Text = textBox4.Text;
			txtLan2507.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox4.Text));
			txtLan3007.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox4.Text));
		}

		private void textBox3_TextChanged(object sender, System.EventArgs e)
		{
			txtLan1503.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox3.Text));
			txtLan2003.Text = textBox3.Text;
			txtLan2503.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox3.Text));
			txtLan3003.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox3.Text));
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
			txtLan1501.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox2.Text));
			txtLan2001.Text = textBox2.Text;
			txtLan2501.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox2.Text));
			txtLan3001.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox2.Text));
		}

		private void txtResis1_TextChanged(object sender, System.EventArgs e)
		{
			txtLan15EE.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text));
			txtLan1507.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox4.Text));
			txtLan1503.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox3.Text));
			txtLan1501.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox2.Text));
		}

		private void txtResis3_TextChanged(object sender, System.EventArgs e)
		{
			txtLan25EE.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text));
			txtLan2507.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox4.Text));
			txtLan2503.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox3.Text));
			txtLan2501.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox2.Text));
		}

		private void txtResis4_TextChanged(object sender, System.EventArgs e)
		{
			txtLan30EE.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text));
			txtLan3007.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox4.Text));
			txtLan3003.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox3.Text));
			txtLan3001.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox2.Text));
		}

		private void sqlDADatosT_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
		{
		
		}

		private void cmbConcretera_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cmbPlanta.Enabled = true;
		}

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txt20h_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbkPrefijo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (int.Parse(cmbTipo.SelectedValue.ToString()))
            {
                case 6:
                    label13.Text = "14 días";
                    label14.Text = "3 días";
                    label15.Text = "1 días";
                    break;
                case 7:
                    label13.Text = "14 días";
                    label14.Text = "7 días";
                    label15.Text = "1 días";
                    break;
                case 8:
                    label13.Text = "14 días";
                    label14.Text = "7 días";
                    label15.Text = "3 días";
                    break;
                case 11:
                    label13.Text = "14 días";
                    label14.Text = "3 días";
                    label15.Text = "1 días";
                    break;
                case 12:
                    label13.Text = "14 días";
                    label14.Text = "7 días";
                    label15.Text = "1 días";
                    break;
                case 13:
                    label13.Text = "14 días";
                    label14.Text = "7 días";
                    label15.Text = "3 días";
                    break;
                default:
                    label13.Text = "7 días";
                    label14.Text = "3 días";
                    label15.Text = "1 días";
                    break;
            }

        }

	}
}
