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
	/// Descripción breve de RepAnsAcs.
	/// </summary>
	public class RepAnsAcs : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cmbGrado;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cmbMarca;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cmbIdAcero;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private System.Windows.Forms.ComboBox cmbNoEco;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtMAX;
		private System.Windows.Forms.TextBox txtLE;
		private System.Windows.Forms.Label label6;
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
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cmbInforme;
		private LancNeo.dsAcero dsAcero1;
		private System.Data.SqlClient.SqlDataAdapter sqlDATitulo;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDAMarca;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAnalisis;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private LancNeo.dsGradoBlock dsGradoBlock2;
		private LancNeo.dsUnidad dsUnidad1;
		private LancNeo.dsConcreto dsConcreto1;
		private System.Data.SqlClient.SqlDataAdapter sqlDANoEco;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsGradoBlock dsGradoBlock1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAcero;
		private System.Data.SqlClient.SqlCommand sqlCommand3;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private LancNeo.dsAnalBlock dsAnalBlock1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcreto;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDAGrado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand8;
		private LancNeo.dsTipoPrueba dsTipoPrueba1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrueba;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsBusNoEco dsBusNoEco1;
		private LancNeo.dsTipInf dsTipInf1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepAnalisis;
		private LancNeo.CryRepAnsAcs cryRepAnsAcs1;
		private LancNeo.CryRepAnsAcsa cryRepAnsAcsa1;
		private LancNeo.CryRepAnsAcsb cryRepAnsAcsb1;
		private LancNeo.CryRepAnsAcsc cryRepAnsAcsc1;
		private LancNeo.CryRepAnsAcsd cryRepAnsAcsd1;
		private LancNeo.CryRepAnsAcse cryRepAnsAcse1;
		private System.Windows.Forms.CheckBox chbLab;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RepAnsAcs()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepAnsAcs));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.cmbInforme = new System.Windows.Forms.ComboBox();
            this.dsTipInf1 = new LancNeo.dsTipInf();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.dsGradoBlock2 = new LancNeo.dsGradoBlock();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.dsGradoBlock1 = new LancNeo.dsGradoBlock();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbIdAcero = new System.Windows.Forms.ComboBox();
            this.dsAcero1 = new LancNeo.dsAcero();
            this.label8 = new System.Windows.Forms.Label();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.cmbNoEco = new System.Windows.Forms.ComboBox();
            this.dsBusNoEco1 = new LancNeo.dsBusNoEco();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMAX = new System.Windows.Forms.TextBox();
            this.txtLE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.dsUnidad1 = new LancNeo.dsUnidad();
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
            this.sqlDATitulo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAMarca = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAAnalisis = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsConcreto1 = new LancNeo.dsConcreto();
            this.sqlDANoEco = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAAcero = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsAnalBlock1 = new LancNeo.dsAnalBlock();
            this.sqlDAConcreto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAGrado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.crvRepAnalisis = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryRepAnsAcs1 = new LancNeo.CryRepAnsAcs();
            this.cryRepAnsAcsa1 = new LancNeo.CryRepAnsAcsa();
            this.cryRepAnsAcsb1 = new LancNeo.CryRepAnsAcsb();
            this.cryRepAnsAcsc1 = new LancNeo.CryRepAnsAcsc();
            this.cryRepAnsAcsd1 = new LancNeo.CryRepAnsAcsd();
            this.cryRepAnsAcse1 = new LancNeo.CryRepAnsAcse();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipInf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGradoBlock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGradoBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNoEco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.cmbInforme);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbGrado);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cmbMarca);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbIdAcero);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbkPrefijo);
            this.panel1.Controls.Add(this.cmbNoEco);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtMAX);
            this.panel1.Controls.Add(this.txtLE);
            this.panel1.Controls.Add(this.label6);
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
            this.panel1.Size = new System.Drawing.Size(1028, 137);
            this.panel1.TabIndex = 11;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(703, 5);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 13;
            this.btnVistaPrevia.Load += new System.EventHandler(this.btnVistaPrevia_Load);
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.Location = new System.Drawing.Point(582, 7);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(115, 24);
            this.chbLab.TabIndex = 54;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // cmbInforme
            // 
            this.cmbInforme.DataSource = this.dsTipInf1;
            this.cmbInforme.DisplayMember = "Informe.Informe";
            this.cmbInforme.Location = new System.Drawing.Point(92, 32);
            this.cmbInforme.Name = "cmbInforme";
            this.cmbInforme.Size = new System.Drawing.Size(116, 21);
            this.cmbInforme.TabIndex = 1;
            this.cmbInforme.ValueMember = "Informe.IdInforme";
            this.cmbInforme.SelectedIndexChanged += new System.EventHandler(this.cmbInforme_SelectedIndexChanged);
            // 
            // dsTipInf1
            // 
            this.dsTipInf1.DataSetName = "dsTipInf";
            this.dsTipInf1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsTipInf1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tipo de informe:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Esfuerzos o Cargas";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbGrado
            // 
            this.cmbGrado.DataSource = this.dsGradoBlock2;
            this.cmbGrado.DisplayMember = "TabiqueMdor.Grado";
            this.cmbGrado.Location = new System.Drawing.Point(337, 102);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(94, 21);
            this.cmbGrado.TabIndex = 10;
            this.cmbGrado.ValueMember = "TabiqueMdor.Grado";
            this.cmbGrado.Visible = false;
            // 
            // dsGradoBlock2
            // 
            this.dsGradoBlock2.DataSetName = "dsGradoBlock";
            this.dsGradoBlock2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsGradoBlock2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(290, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Grado:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DataSource = this.dsGradoBlock1;
            this.cmbMarca.DisplayMember = "TabiqueMdor.Grado";
            this.cmbMarca.Location = new System.Drawing.Point(337, 76);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(94, 21);
            this.cmbMarca.TabIndex = 9;
            this.cmbMarca.ValueMember = "TabiqueMdor.Grado1";
            // 
            // dsGradoBlock1
            // 
            this.dsGradoBlock1.DataSetName = "dsGradoBlock";
            this.dsGradoBlock1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsGradoBlock1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Marca:";
            this.label9.Visible = false;
            // 
            // cmbIdAcero
            // 
            this.cmbIdAcero.DataSource = this.dsAcero1;
            this.cmbIdAcero.DisplayMember = "Acero.Nominal";
            this.cmbIdAcero.Location = new System.Drawing.Point(337, 52);
            this.cmbIdAcero.Name = "cmbIdAcero";
            this.cmbIdAcero.Size = new System.Drawing.Size(94, 21);
            this.cmbIdAcero.TabIndex = 8;
            this.cmbIdAcero.ValueMember = "Acero.Numero";
            // 
            // dsAcero1
            // 
            this.dsAcero1.DataSetName = "dsAcero";
            this.dsAcero1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAcero1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Número:";
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(278, 4);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 2;
            this.cbkPrefijo.Text = "No prefijo";
            // 
            // cmbNoEco
            // 
            this.cmbNoEco.DataSource = this.dsBusNoEco1;
            this.cmbNoEco.DisplayMember = "Laboratorista.Laboratorista";
            this.cmbNoEco.Location = new System.Drawing.Point(48, 90);
            this.cmbNoEco.Name = "cmbNoEco";
            this.cmbNoEco.Size = new System.Drawing.Size(229, 21);
            this.cmbNoEco.TabIndex = 7;
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
            this.label10.Location = new System.Drawing.Point(437, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Maximo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Limite elástico:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMAX
            // 
            this.txtMAX.Location = new System.Drawing.Point(543, 104);
            this.txtMAX.MaxLength = 5;
            this.txtMAX.Name = "txtMAX";
            this.txtMAX.Size = new System.Drawing.Size(48, 20);
            this.txtMAX.TabIndex = 12;
            this.txtMAX.Text = "6300";
            // 
            // txtLE
            // 
            this.txtLE.Location = new System.Drawing.Point(543, 76);
            this.txtLE.MaxLength = 5;
            this.txtLE.Name = "txtLE";
            this.txtLE.Size = new System.Drawing.Size(48, 20);
            this.txtLE.TabIndex = 11;
            this.txtLE.Text = "4200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "NoEco:";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataSource = this.dsUnidad1;
            this.cmbUnidad.DisplayMember = "Unidad.Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(195, 61);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(82, 21);
            this.cmbUnidad.TabIndex = 4;
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
            this.label5.Location = new System.Drawing.Point(140, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(488, 32);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(488, 8);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBuscaObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(55, 61);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 3;
            this.cmbIdObra.ValueMember = "Obra.Idobra";
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
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Análisis Estadístico ACEROS";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(355, 9);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(300, 9);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
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
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAMarca
            // 
            this.sqlDAMarca.SelectCommand = this.sqlSelectCommand5;
            this.sqlDAMarca.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ProbetaEsp", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("Grado1", "Grado1")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "[MarInf]";
            this.sqlSelectCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand5.Connection = this.sqlConn;
            this.sqlSelectCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdInforme", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Car", System.Data.SqlDbType.VarChar, 1)});
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
            this.sqlSelectCommand4.CommandText = "[AnsAcs]";
            this.sqlSelectCommand4.CommandTimeout = 60;
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 10),
            new System.Data.SqlClient.SqlParameter("@Marca", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLE", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@datos", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdInforme", System.Data.SqlDbType.Int, 4)});
            // 
            // dsConcreto1
            // 
            this.dsConcreto1.DataSetName = "dsConcreto";
            this.dsConcreto1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcreto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlDAAcero
            // 
            this.sqlDAAcero.SelectCommand = this.sqlCommand3;
            this.sqlDAAcero.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Acero", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Nominal", "Nominal"),
                        new System.Data.Common.DataColumnMapping("Milimetros", "Milimetros"),
                        new System.Data.Common.DataColumnMapping("Clasificacion", "Clasificacion")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "[aceinf]";
            this.sqlCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdInforme", System.Data.SqlDbType.Int, 4)});
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
            // dsAnalBlock1
            // 
            this.dsAnalBlock1.DataSetName = "dsAnalBlock";
            this.dsAnalBlock1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsAnalBlock1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlSelectCommand8.CommandText = "[GraInf]";
            this.sqlSelectCommand8.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand8.Connection = this.sqlConn;
            this.sqlSelectCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdInforme", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Car", System.Data.SqlDbType.VarChar, 1)});
            // 
            // dsTipoPrueba1
            // 
            this.dsTipoPrueba1.DataSetName = "dsTipoPrueba";
            this.dsTipoPrueba1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipoPrueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlCommand1.CommandText = "[BusObraInf]";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConn;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdInforme", System.Data.SqlDbType.Int, 4)});
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
            this.crvRepAnalisis.TabIndex = 12;
            this.crvRepAnalisis.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepAnalisis.ToolPanelWidth = 167;
            // 
            // RepAnsAcs
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 748);
            this.Controls.Add(this.crvRepAnalisis);
            this.Controls.Add(this.panel1);
            this.Name = "RepAnsAcs";
            this.Text = "RepAnsAcs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepAnsAcs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipInf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGradoBlock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGradoBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusNoEco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void RepAnsAcs_Load(object sender, System.EventArgs e)
		{
			dsTipInf1.Informe.AddInformeRow(0,"Soldadura");
			dsTipInf1.Informe.AddInformeRow(1,"Var grado 60");
			dsTipInf1.Informe.AddInformeRow(2,"Var grado 50");
			dsTipInf1.Informe.AddInformeRow(3,"Var conector");
			dsTipInf1.Informe.AddInformeRow(4,"Placa acero");
			dsTipInf1.Informe.AddInformeRow(5,"Toron");
			DataColumn[] Llave = new DataColumn[1];
			Object[] Matriz = new Object[6];
			Llave[0] = dsBuscaObra1.Tables["Obra"].Columns["IdObra"];
			Matriz[0] = "Todos";
			Matriz[1] = "Todos";
			Matriz[2] = "Todos";
			Matriz[3] = "Todos";
			Matriz[4] = "Todos";
			Matriz[5] = "Todos";
			dsBuscaObra1.Tables["Obra"].BeginLoadData();
			dsBuscaObra1.Tables["Obra"].LoadDataRow(Matriz,true);
			dsBuscaObra1.Tables["Obra"].EndLoadData();
			sqlDABusObra.SelectCommand.Parameters["@IdInforme"].Value = 0;
			sqlDABusObra.Fill(dsBuscaObra1, "Obra");
			cmbIdObra.SelectedIndex = 1;
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
			dsGradoBlock1.Clear();
			dsGradoBlock1.TabiqueMdor.AddTabiqueMdorRow("Todos","Todos");
			sqlDAGrado.SelectCommand.Parameters["@car"].Value = "-";
			sqlDAGrado.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAGrado.SelectCommand.Parameters["@IdInforme"].Value = 0;
			sqlDAGrado.Fill(dsGradoBlock1, "TabiqueMdor");
			dsAcero1.Acero.AddAceroRow("Todos","Todos",100,"A",1," ",0,0,0,0,0,0," "," ",0,0,0,0,0,0,0,0,0," ",0,0);
			sqlDAAcero.SelectCommand.Parameters["@IdInforme"].Value = 0;
			sqlDAAcero.Fill(dsAcero1, "Acero");
			dsGradoBlock2.Clear();
			dsGradoBlock2.TabiqueMdor.AddTabiqueMdorRow("Todos","Todos");
			sqlDAMarca.SelectCommand.Parameters["@car"].Value = "-";
			sqlDAMarca.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAMarca.SelectCommand.Parameters["@IdInforme"].Value = 0;
			sqlDAMarca.Fill(dsGradoBlock2, "TabiqueMdor");
			dsBusNoEco1.Laboratorista.AddLaboratoristaRow(-1,"Todos");
			sqlDANoEco.Fill(dsBusNoEco1, "Laboratorista");
			cmbNoEco.SelectedIndex = 0;
			cmbInforme.SelectedIndex = 0;

		}

		private void cmbInforme_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsBuscaObra1.Clear();
			DataColumn[] Llave = new DataColumn[1];
			Object[] Matriz = new Object[6];
			Llave[0] = dsBuscaObra1.Tables["Obra"].Columns["IdObra"];
			Matriz[0] = "Todos";
			Matriz[1] = "Todos";
			Matriz[2] = "Todos";
			Matriz[3] = "Todos";
			Matriz[4] = "Todos";
			Matriz[5] = "Todos";
			dsBuscaObra1.Tables["Obra"].BeginLoadData();
			dsBuscaObra1.Tables["Obra"].LoadDataRow(Matriz,true);
			dsBuscaObra1.Tables["Obra"].EndLoadData();
			sqlDABusObra.SelectCommand.Parameters["@IdInforme"].Value = cmbInforme.SelectedIndex;
			sqlDABusObra.Fill(dsBuscaObra1, "Obra");
			btnVistaPrevia.Visible = false;
			cmbIdObra.SelectedIndex = 1;
			dsAcero1.Clear();
			dsAcero1.Acero.AddAceroRow("Todos","Todos",100,"A",1," ",0,0,0,0,0,0," "," ",0,0,0,0,0,0,0,0,0," ",0,0);
			if(cmbInforme.SelectedIndex < 4)
			{
				sqlDAAcero.SelectCommand.Parameters["@IdInforme"].Value = cmbInforme.SelectedIndex;
				sqlDAAcero.Fill(dsAcero1, "Acero");
			}
			dsGradoBlock1.Clear();
			dsGradoBlock1.TabiqueMdor.AddTabiqueMdorRow("Todos","Todos");
			sqlDAGrado.SelectCommand.Parameters["@car"].Value = "-";
			sqlDAGrado.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAGrado.SelectCommand.Parameters["@IdInforme"].Value = cmbInforme.SelectedIndex;
			sqlDAGrado.Fill(dsGradoBlock1, "TabiqueMdor");
			dsGradoBlock2.Clear();
			dsGradoBlock2.TabiqueMdor.AddTabiqueMdorRow("Todos","Todos");
			sqlDAMarca.SelectCommand.Parameters["@car"].Value = "-";
			sqlDAMarca.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAMarca.SelectCommand.Parameters["@IdInforme"].Value = cmbInforme.SelectedIndex;
			sqlDAMarca.Fill(dsGradoBlock2, "TabiqueMdor");
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			btnVistaPrevia.Visible = true;
			dsGradoBlock1.Clear();
			dsGradoBlock1.TabiqueMdor.AddTabiqueMdorRow("Todos","Todos");
			sqlDAGrado.SelectCommand.Parameters["@car"].Value = "-";
			sqlDAGrado.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAGrado.SelectCommand.Parameters["@IdInforme"].Value = cmbInforme.SelectedIndex;
			sqlDAGrado.Fill(dsGradoBlock1, "TabiqueMdor");
			dsGradoBlock2.Clear();
			dsGradoBlock2.TabiqueMdor.AddTabiqueMdorRow("Todos","Todos");
			sqlDAMarca.SelectCommand.Parameters["@car"].Value = "-";
			sqlDAMarca.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAMarca.SelectCommand.Parameters["@IdInforme"].Value = cmbInforme.SelectedIndex;
			sqlDAMarca.Fill(dsGradoBlock2, "TabiqueMdor");
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            crvRepAnalisis.Visible = true;
			dsAnalBlock1.Clear();
			sqlDAAnalisis.SelectCommand.Parameters["@IdObra"].Value = (cmbIdObra.SelectedValue.ToString() == "Todos" ? "%" : txtIdobra.Text);
			sqlDAAnalisis.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@Numero"].Value = (cmbIdAcero.SelectedValue.ToString() == "Todos" ? "%" : cmbIdAcero.SelectedValue.ToString());
			sqlDAAnalisis.SelectCommand.Parameters["@Grado"].Value = (cmbMarca.SelectedValue.ToString() == "Todos" ? "%" : cmbMarca.SelectedValue.ToString());
			sqlDAAnalisis.SelectCommand.Parameters["@Marca"].Value = "Todos";
			sqlDAAnalisis.SelectCommand.Parameters["@EsfuerzoLE"].Value = txtLE.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@EsfuerzoMAX"].Value = txtMAX.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
			sqlDAAnalisis.SelectCommand.Parameters["@NoEco"].Value = cmbNoEco.SelectedValue.ToString();
			sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 3;
			sqlDAAnalisis.SelectCommand.Parameters["@IdInforme"].Value = cmbInforme.SelectedIndex;
			sqlDAAnalisis.Fill(dsAnalBlock1, "GraficaFinal");
			sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 1;
			sqlDAAnalisis.Fill(dsAnalBlock1, "Analisis");
			sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 2;
			sqlDAAnalisis.Fill(dsAnalBlock1, "Grafica1");

            int lineas = (cmbInforme.SelectedIndex != 3 ? 2 : 1);
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
				ee[i] = float.Parse(dsAnalBlock1.Tables["GraficaFinal"].Rows[lineas][i].ToString());
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
			float res = float.Parse(txtMAX.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());

			sqlDATitulo.SelectCommand.Parameters["@ResistenciaKg"].Value = res.ToString();
			sqlDATitulo.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
			sqlDATitulo.SelectCommand.Parameters["@Hoja"].Value = int.Parse(dsAnalBlock1.Tables["GraficaFinal"].Rows[0][24].ToString());
			sqlDATitulo.Fill(dsAnalBlock1,"Titulo");
            cryRepAnsAcs1.SetDataSource(dsAnalBlock1);
        
			switch(cmbInforme.SelectedIndex)       
			{         
				case 0:
                    // Establece el valor actual de parameter1 en el subinforme en 10 
                    cryRepAnsAcs1.SetDataSource(dsAnalBlock1);
                    cryRepAnsAcs1.SetParameterValue("@Unidad", cmbUnidad.Text);
                    cryRepAnsAcs1.SetParameterValue("@Res", float.Parse(txtMAX.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcs1.SetParameterValue("@Lab", cmbNoEco.Text);
                    cryRepAnsAcs1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                    cryRepAnsAcs1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                    cryRepAnsAcs1.SetParameterValue("@Obr", txtIdobra.Text);
                    cryRepAnsAcs1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                    cryRepAnsAcs1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
                    cryRepAnsAcs1.SetParameterValue("@reskg", res.ToString(), "Gauss");
                    cryRepAnsAcs1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
                    cryRepAnsAcs1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                    cryRepAnsAcs1.SetParameterValue("@Prueba", "Flexión");
                    cryRepAnsAcs1.SetParameterValue("@Numero", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][0].ToString());
                    cryRepAnsAcs1.SetParameterValue("@Indice", res.ToString());
                    cryRepAnsAcs1.SetParameterValue("@Nominal", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][1].ToString());
                    cryRepAnsAcs1.SetParameterValue("@mm", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][2].ToString());
                    cryRepAnsAcs1.SetParameterValue("@Marca", cmbMarca.SelectedValue.ToString());
                    cryRepAnsAcs1.SetParameterValue("@Grado", cmbGrado.SelectedValue.ToString());
                    cryRepAnsAcs1.SetParameterValue("@LE", float.Parse(txtLE.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcs1.SetParameterValue("@Lab1", true); 
                    crvRepAnalisis.ReportSource = cryRepAnsAcs1;
					break;                  
				case 1:
                    //1
                    cryRepAnsAcsa1.SetDataSource(dsAnalBlock1);
                    cryRepAnsAcsa1.SetParameterValue("@Unidad", cmbUnidad.Text);
                    cryRepAnsAcsa1.SetParameterValue("@Res", float.Parse(txtMAX.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcsa1.SetParameterValue("@Lab", cmbNoEco.Text);
                    cryRepAnsAcsa1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                    cryRepAnsAcsa1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                    cryRepAnsAcsa1.SetParameterValue("@Obr", txtIdobra.Text);
                    cryRepAnsAcsa1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                    cryRepAnsAcsa1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
                    cryRepAnsAcsa1.SetParameterValue("@reskg", res.ToString(), "Gauss");
                    cryRepAnsAcsa1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
                    cryRepAnsAcsa1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                    cryRepAnsAcsa1.SetParameterValue("@Prueba", "Flexión");
                    cryRepAnsAcsa1.SetParameterValue("@Numero", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][0].ToString());
                    cryRepAnsAcsa1.SetParameterValue("@Indice", res.ToString());
                    cryRepAnsAcsa1.SetParameterValue("@Nominal", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][1].ToString());
                    cryRepAnsAcsa1.SetParameterValue("@mm", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][2].ToString());
                    cryRepAnsAcsa1.SetParameterValue("@Marca", cmbMarca.SelectedValue.ToString());
                    cryRepAnsAcsa1.SetParameterValue("@Grado", cmbGrado.SelectedValue.ToString());
                    cryRepAnsAcsa1.SetParameterValue("@LE", float.Parse(txtLE.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcsa1.SetParameterValue("@Lab1", true); 
                    crvRepAnalisis.ReportSource = cryRepAnsAcsa1;
					break;                  
				case 2:
                    //2
                    cryRepAnsAcsb1.SetDataSource(dsAnalBlock1);
                    cryRepAnsAcsb1.SetParameterValue("@Unidad", cmbUnidad.Text);
                    cryRepAnsAcsb1.SetParameterValue("@Res", float.Parse(txtMAX.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcsb1.SetParameterValue("@Lab", cmbNoEco.Text);
                    cryRepAnsAcsb1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                    cryRepAnsAcsb1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                    cryRepAnsAcsb1.SetParameterValue("@Obr", txtIdobra.Text);
                    cryRepAnsAcsb1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                    cryRepAnsAcsb1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString()); cryRepAnsAcsb1.SetParameterValue("@reskg", res.ToString(), "Gauss");
                    cryRepAnsAcsb1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
                    cryRepAnsAcsb1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                    cryRepAnsAcsb1.SetParameterValue("@Prueba", "Flexión");
                    cryRepAnsAcsb1.SetParameterValue("@Numero", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][0].ToString());
                    cryRepAnsAcsb1.SetParameterValue("@Indice", res.ToString());
                    cryRepAnsAcsb1.SetParameterValue("@Nominal", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][1].ToString());
                    cryRepAnsAcsb1.SetParameterValue("@mm", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][2].ToString());
                    cryRepAnsAcsb1.SetParameterValue("@Marca", cmbMarca.SelectedValue.ToString());
                    cryRepAnsAcsb1.SetParameterValue("@Grado", cmbGrado.SelectedValue.ToString());
                    cryRepAnsAcsb1.SetParameterValue("@LE", float.Parse(txtLE.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcsb1.SetParameterValue("@Lab1", true);
                    crvRepAnalisis.ReportSource = cryRepAnsAcsb1;
					break;                  
				case 3:
                    // 3
                    cryRepAnsAcsc1.SetDataSource(dsAnalBlock1);
                    cryRepAnsAcsc1.SetParameterValue("@Unidad", cmbUnidad.Text);
                    cryRepAnsAcsc1.SetParameterValue("@Res", float.Parse(txtMAX.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcsc1.SetParameterValue("@Lab", cmbNoEco.Text);
                    cryRepAnsAcsc1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                    cryRepAnsAcsc1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                    cryRepAnsAcsc1.SetParameterValue("@Obr", txtIdobra.Text);
                    cryRepAnsAcsc1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                    cryRepAnsAcsc1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString()); cryRepAnsAcsc1.SetParameterValue("@reskg", res.ToString(), "Gauss");
                    cryRepAnsAcsc1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
                    cryRepAnsAcsc1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                    cryRepAnsAcsc1.SetParameterValue("@Prueba", "Flexión");
                    cryRepAnsAcsc1.SetParameterValue("@Numero", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][0].ToString());
                    cryRepAnsAcsc1.SetParameterValue("@Indice", res.ToString());
                    cryRepAnsAcsc1.SetParameterValue("@Nominal", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][1].ToString());
                    cryRepAnsAcsc1.SetParameterValue("@mm", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][2].ToString());
                    cryRepAnsAcsc1.SetParameterValue("@Marca", cmbMarca.SelectedValue.ToString());
                    cryRepAnsAcsc1.SetParameterValue("@Grado", cmbGrado.SelectedValue.ToString());
                    cryRepAnsAcsc1.SetParameterValue("@LE", float.Parse(txtLE.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcsc1.SetParameterValue("@Lab1", true);
                    crvRepAnalisis.ReportSource = cryRepAnsAcsc1;
					break;                  
				case 4:
                    // 4
                    cryRepAnsAcsd1.SetDataSource(dsAnalBlock1);
                    cryRepAnsAcsd1.SetParameterValue("@Unidad", cmbUnidad.Text);
                    cryRepAnsAcsd1.SetParameterValue("@Res", float.Parse(txtMAX.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcsd1.SetParameterValue("@Lab", cmbNoEco.Text);
                    cryRepAnsAcsd1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                    cryRepAnsAcsd1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                    cryRepAnsAcsd1.SetParameterValue("@Obr", txtIdobra.Text);
                    cryRepAnsAcsd1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                    cryRepAnsAcsd1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString()); cryRepAnsAcsd1.SetParameterValue("@reskg", res.ToString(), "Gauss");
                    cryRepAnsAcsd1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
                    cryRepAnsAcsd1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                    cryRepAnsAcsd1.SetParameterValue("@Prueba", "Flexión");
                    cryRepAnsAcsd1.SetParameterValue("@Numero", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][0].ToString());
                    cryRepAnsAcsd1.SetParameterValue("@Indice", res.ToString());
                    cryRepAnsAcsd1.SetParameterValue("@Nominal", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][1].ToString());
                    cryRepAnsAcsd1.SetParameterValue("@mm", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][2].ToString());
                    cryRepAnsAcsd1.SetParameterValue("@Marca", cmbMarca.SelectedValue.ToString());
                    cryRepAnsAcsd1.SetParameterValue("@Grado", cmbGrado.SelectedValue.ToString());
                    cryRepAnsAcsd1.SetParameterValue("@LE", float.Parse(txtLE.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcsd1.SetParameterValue("@Lab1", true); crvRepAnalisis.ReportSource = cryRepAnsAcsd1;
					break;                  
				case 5:
                    // 5
                    cryRepAnsAcse1.SetDataSource(dsAnalBlock1);
                    cryRepAnsAcse1.SetParameterValue("@Unidad", cmbUnidad.Text);
                    cryRepAnsAcse1.SetParameterValue("@Res", float.Parse(txtMAX.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcse1.SetParameterValue("@Lab", cmbNoEco.Text);
                    cryRepAnsAcse1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                    cryRepAnsAcse1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                    cryRepAnsAcse1.SetParameterValue("@Obr", txtIdobra.Text);
                    cryRepAnsAcse1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                    cryRepAnsAcse1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
                    cryRepAnsAcse1.SetParameterValue("@reskg", res.ToString(), "Gauss");
                    cryRepAnsAcse1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
                    cryRepAnsAcse1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
                    cryRepAnsAcse1.SetParameterValue("@Prueba", "Flexión");
                    cryRepAnsAcse1.SetParameterValue("@Numero", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][0].ToString());
                    cryRepAnsAcse1.SetParameterValue("@Indice", res.ToString());
                    cryRepAnsAcse1.SetParameterValue("@Nominal", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][1].ToString());
                    cryRepAnsAcse1.SetParameterValue("@mm", dsAcero1.Tables["Acero"].Rows[cmbIdAcero.SelectedIndex][2].ToString());
                    cryRepAnsAcse1.SetParameterValue("@Marca", cmbMarca.SelectedValue.ToString());
                    cryRepAnsAcse1.SetParameterValue("@Grado", cmbGrado.SelectedValue.ToString());
                    cryRepAnsAcse1.SetParameterValue("@LE", float.Parse(txtLE.Text) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString()));
                    cryRepAnsAcse1.SetParameterValue("@Lab1", true); crvRepAnalisis.ReportSource = cryRepAnsAcse1;
					break;                  
			}
			//crvRepAnalisis.RefreshReport();
		}

        private void btnVistaPrevia_Load(object sender, EventArgs e)
        {

        }

		
	}

}
