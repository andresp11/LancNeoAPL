using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de InfConec.
	/// </summary>
	public class InfConec : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.CheckBox chbDuplicado;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtRenglon;
		private System.Windows.Forms.ComboBox cmbUnidad;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.TextBox txtIdobra;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfAcero;
		private System.Data.SqlClient.SqlDataAdapter sqlDAInfConec;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsBusObra dsBusObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAFirmas;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private LancNeo.dsFirmas dsFirmas1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsUnidad dsUnidad1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		public System.Data.SqlClient.SqlDataAdapter sqlDAConecMdor;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsConecMdor dsConecMdor1;
		private LancNeo.dsInfConec dsInfConec1;
		private LancNeo.CryRepConec cryRepConec1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAInfConec1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Windows.Forms.CheckBox chbLeyenda;
		public System.Data.SqlClient.SqlDataAdapter sqlDANorma;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Windows.Forms.CheckBox chbFormato;
		private System.Windows.Forms.CheckBox chbLab;
		private System.Windows.Forms.CheckBox chbLab1;
        private GroupBox groupBox1;
        private RadioButton rbColada;
        private RadioButton radioButton1;
        private CryRepConecO cryRepConecO1;
        private CheckBox chbTodos;
        private CheckBox chbRespaldo;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public InfConec()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfConec));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsConecMdor1 = new LancNeo.dsConecMdor();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbColada = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.chbLab1 = new System.Windows.Forms.CheckBox();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbFormato = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.chbDuplicado = new System.Windows.Forms.CheckBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRenglon = new System.Windows.Forms.TextBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.crvInfAcero = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAInfConec = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAFirmas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsFirmas1 = new LancNeo.dsFirmas();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConecMdor = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsInfConec1 = new LancNeo.dsInfConec();
            this.cryRepConec1 = new LancNeo.CryRepConec();
            this.sqlDAInfConec1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDANorma = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.cryRepConecO1 = new LancNeo.CryRepConecO();
            this.chbRespaldo = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConecMdor1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfConec1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.chbRespaldo);
            this.panel1.Controls.Add(this.chbTodos);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.chbLab1);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbFormato);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.chbDuplicado);
            this.panel1.Controls.Add(this.txtFolio);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRenglon);
            this.panel1.Controls.Add(this.cmbUnidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 114);
            this.panel1.TabIndex = 11;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 650;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConecMdor1.ConecMdor;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(432, 4);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Load += new System.EventHandler(this.buscaBtn1_Load);
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsConecMdor1
            // 
            this.dsConecMdor1.DataSetName = "dsConecMdor";
            this.dsConecMdor1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConecMdor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(785, 8);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 63);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chbTodos
            // 
            this.chbTodos.ForeColor = System.Drawing.Color.White;
            this.chbTodos.Location = new System.Drawing.Point(665, 77);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(114, 24);
            this.chbTodos.TabIndex = 47;
            this.chbTodos.Text = "Todos los informes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbColada);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(621, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 67);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato";
            // 
            // rbColada
            // 
            this.rbColada.AutoSize = true;
            this.rbColada.Checked = true;
            this.rbColada.ForeColor = System.Drawing.Color.White;
            this.rbColada.Location = new System.Drawing.Point(7, 43);
            this.rbColada.Name = "rbColada";
            this.rbColada.Size = new System.Drawing.Size(98, 17);
            this.rbColada.TabIndex = 1;
            this.rbColada.TabStop = true;
            this.rbColada.Text = "Colada, remesa";
            this.rbColada.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Características";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // chbLab1
            // 
            this.chbLab1.Checked = true;
            this.chbLab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab1.ForeColor = System.Drawing.Color.White;
            this.chbLab1.Location = new System.Drawing.Point(10, 76);
            this.chbLab1.Name = "chbLab1";
            this.chbLab1.Size = new System.Drawing.Size(129, 24);
            this.chbLab1.TabIndex = 41;
            this.chbLab1.Text = "Incluye laboratorista";
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.ForeColor = System.Drawing.Color.White;
            this.chbLab.Location = new System.Drawing.Point(360, 76);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 24);
            this.chbLab.TabIndex = 40;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // chbFormato
            // 
            this.chbFormato.ForeColor = System.Drawing.Color.White;
            this.chbFormato.Location = new System.Drawing.Point(485, 76);
            this.chbFormato.Name = "chbFormato";
            this.chbFormato.Size = new System.Drawing.Size(184, 24);
            this.chbFormato.TabIndex = 33;
            this.chbFormato.Text = "Incluye imagen de acreditación";
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.Checked = true;
            this.chbLeyenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLeyenda.ForeColor = System.Drawing.Color.White;
            this.chbLeyenda.Location = new System.Drawing.Point(240, 76);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(116, 23);
            this.chbLeyenda.TabIndex = 32;
            this.chbLeyenda.Text = "Formato leyenda";
            this.chbLeyenda.CheckedChanged += new System.EventHandler(this.chbLeyenda_CheckedChanged);
            // 
            // chbDuplicado
            // 
            this.chbDuplicado.ForeColor = System.Drawing.Color.White;
            this.chbDuplicado.Location = new System.Drawing.Point(145, 76);
            this.chbDuplicado.Name = "chbDuplicado";
            this.chbDuplicado.Size = new System.Drawing.Size(88, 23);
            this.chbDuplicado.TabIndex = 30;
            this.chbDuplicado.Text = "¿Duplicado?";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(542, 8);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(56, 20);
            this.txtFolio.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(505, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Renglones:";
            // 
            // txtRenglon
            // 
            this.txtRenglon.Location = new System.Drawing.Point(577, 33);
            this.txtRenglon.MaxLength = 2;
            this.txtRenglon.Name = "txtRenglon";
            this.txtRenglon.Size = new System.Drawing.Size(23, 20);
            this.txtRenglon.TabIndex = 25;
            this.txtRenglon.Text = "20";
            this.txtRenglon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(344, 38);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(80, 21);
            this.cmbUnidad.TabIndex = 23;
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
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(301, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Unidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(344, 8);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe de verificación de ensaye de tensión de varillas roscadas con conector";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(502, 8);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(32, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Folio:";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(432, 32);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // crvInfAcero
            // 
            this.crvInfAcero.ActiveViewIndex = -1;
            this.crvInfAcero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfAcero.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfAcero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfAcero.EnableRefresh = false;
            this.crvInfAcero.Location = new System.Drawing.Point(0, 114);
            this.crvInfAcero.Name = "crvInfAcero";
            this.crvInfAcero.ShowCloseButton = false;
            this.crvInfAcero.ShowGroupTreeButton = false;
            this.crvInfAcero.ShowLogo = false;
            this.crvInfAcero.Size = new System.Drawing.Size(885, 410);
            this.crvInfAcero.TabIndex = 12;
            this.crvInfAcero.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // sqlDAInfConec
            // 
            this.sqlDAInfConec.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAInfConec.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ConecRep", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FMuestreo", "FMuestreo"),
                        new System.Data.Common.DataColumnMapping("FEnsaye", "FEnsaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("MuesEn", "MuesEn"),
                        new System.Data.Common.DataColumnMapping("Observac", "Observac"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Aci", "Aci"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("EsfLE", "EsfLE"),
                        new System.Data.Common.DataColumnMapping("EsfMAX", "EsfMAX"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Junta", "Junta"),
                        new System.Data.Common.DataColumnMapping("Falla", "Falla"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("CargaLE", "CargaLE"),
                        new System.Data.Common.DataColumnMapping("CargaMax", "CargaMax"),
                        new System.Data.Common.DataColumnMapping("EsfLER", "EsfLER"),
                        new System.Data.Common.DataColumnMapping("EsfMAXR", "EsfMAXR"),
                        new System.Data.Common.DataColumnMapping("Colada", "Colada"),
                        new System.Data.Common.DataColumnMapping("Remesa", "Remesa"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("Observa1", "Observa1"),
                        new System.Data.Common.DataColumnMapping("Nota", "Nota"),
                        new System.Data.Common.DataColumnMapping("Nota1", "Nota1"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Nominal", "Nominal"),
                        new System.Data.Common.DataColumnMapping("Milimetros", "Milimetros"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona")}),
            new System.Data.Common.DataTableMapping("Table1", "Table1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FMuestreo", "FMuestreo"),
                        new System.Data.Common.DataColumnMapping("FEnsaye", "FEnsaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("MuesEn", "MuesEn"),
                        new System.Data.Common.DataColumnMapping("Observac", "Observac"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Aci", "Aci"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("EsfLE", "EsfLE"),
                        new System.Data.Common.DataColumnMapping("EsfMAX", "EsfMAX"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Junta", "Junta"),
                        new System.Data.Common.DataColumnMapping("Falla", "Falla"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("CargaLE", "CargaLE"),
                        new System.Data.Common.DataColumnMapping("CargaMax", "CargaMax"),
                        new System.Data.Common.DataColumnMapping("EsfLER", "EsfLER"),
                        new System.Data.Common.DataColumnMapping("EsfMAXR", "EsfMAXR"),
                        new System.Data.Common.DataColumnMapping("Colada", "Colada"),
                        new System.Data.Common.DataColumnMapping("Remesa", "Remesa"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("Observa1", "Observa1"),
                        new System.Data.Common.DataColumnMapping("Nota", "Nota"),
                        new System.Data.Common.DataColumnMapping("Nota1", "Nota1"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Nominal", "Nominal"),
                        new System.Data.Common.DataColumnMapping("Milimetros", "Milimetros"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[ConecRep]";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Folio1", System.Data.SqlDbType.VarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Numren", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
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
    "me = 1) AND (Conector < 6)\r\nORDER BY Conector";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // dsFirmas1
            // 
            this.dsFirmas1.DataSetName = "dsFirmas";
            this.dsFirmas1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsFirmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlDAUnidad
            // 
            this.sqlDAUnidad.SelectCommand = this.sqlCommand2;
            this.sqlDAUnidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Unidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Factor", "Factor"),
                        new System.Data.Common.DataColumnMapping("Undescr", "Undescr"),
                        new System.Data.Common.DataColumnMapping("MaxagrUn", "MaxagrUn"),
                        new System.Data.Common.DataColumnMapping("RevenUn", "RevenUn")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT IdUnidad, Factor, Undescr, MaxagrUn, RevenUn FROM Unidad";
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // sqlDAConecMdor
            // 
            this.sqlDAConecMdor.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAConecMdor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ConecMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FMuestreo", "FMuestreo"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("MuestreadasEn", "MuestreadasEn"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT FOLIO, IdObra, ConsObra, FMuestreo, Fensaye, Finforme, NoEco, Semana, Mues" +
    "treadasEn, Observaciones FROM ConecMdor WHERE (IdObra = @IdObra) ORDER BY FOLIO " +
    "DESC";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // dsInfConec1
            // 
            this.dsInfConec1.DataSetName = "dsInfConec";
            this.dsInfConec1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsInfConec1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAInfConec1
            // 
            this.sqlDAInfConec1.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAInfConec1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ConecRep1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("Aci", "Aci"),
                        new System.Data.Common.DataColumnMapping("EsfLE", "EsfLE"),
                        new System.Data.Common.DataColumnMapping("EsfMAX", "EsfMAX")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "[ConecRep1]";
            this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Folio1", System.Data.SqlDbType.VarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDANorma
            // 
            this.sqlDANorma.SelectCommand = this.sqlSelectCommand4;
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
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT IdNorma, Informe, Normas, Titulo, IdInforme, Norma1, Norma2, Norma3, Norma" +
    "4, Norma5 FROM Normas WHERE (IdNorma = @IdNorma)";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdNorma", System.Data.SqlDbType.SmallInt, 2, "IdNorma")});
            // 
            // chbRespaldo
            // 
            this.chbRespaldo.ForeColor = System.Drawing.Color.White;
            this.chbRespaldo.Location = new System.Drawing.Point(785, 77);
            this.chbRespaldo.Name = "chbRespaldo";
            this.chbRespaldo.Size = new System.Drawing.Size(90, 24);
            this.chbRespaldo.TabIndex = 86;
            this.chbRespaldo.Text = "Respaldo";
            // 
            // InfConec
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(885, 524);
            this.Controls.Add(this.crvInfAcero);
            this.Controls.Add(this.panel1);
            this.Name = "InfConec";
            this.Text = "InfConec";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfConec_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConecMdor1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfConec1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsConecMdor1.Clear();
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
			LlenasSqlDA();
		}
		private void LlenasSqlDA()
		{
			sqlDAConecMdor.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAConecMdor.Fill(dsConecMdor1, "ConecMdor");
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			crvInfAcero.Visible = true;
			dsInfConec1.Clear();

            sqlDAInfConec.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAInfConec.SelectCommand.Parameters["@Folio1"].Value = (chbTodos.Checked ? "-1" : txtFolio.Text);
            sqlDAInfConec.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
            sqlDAInfConec.SelectCommand.Parameters["@Numren"].Value = txtRenglon.Text;
            sqlDAInfConec.Fill(dsInfConec1, "ConecRep");
            for(int m = 0; m < dsInfConec1.ConecRep.Rows.Count; m++);
            {
            sqlDAInfConec1.SelectCommand.Parameters["@Folio1"].Value = txtFolio.Text;
            sqlDAInfConec1.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
            sqlDAInfConec1.Fill(dsInfConec1, "ConecRep1");
            }
            sqlDAFirmas.Fill(dsFirmas1, "Firmas");
            sqlDANorma.SelectCommand.Parameters["@IdNorma"].Value = 6;
            sqlDANorma.Fill(dsInfConec1, "Normas");
            string unidad1 = (cmbUnidad.SelectedValue.ToString() == "2" ? "t" : "t");
            string conversion = (cmbUnidad.SelectedValue.ToString() == "2" ? "* Para convertir a kg/cm² multiplique por 10,19716" : "* Para convertir en Mega Pascales multiplique por 0,0980665");
            string conversion1 = (cmbUnidad.SelectedValue.ToString() == "2" ? "*** Para convertir a kgf multiplique por 101,9716" : "*** Para convertir en kilonewton multiplique por 0,00980665");
            if (rbColada.Checked)
            {
                cryRepConec1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
                cryRepConec1.SetDataSource(dsInfConec1);
                cryRepConec1.SetParameterValue("@F1", dsFirmas1.Tables[0].Rows[0][1].ToString());
			cryRepConec1.SetParameterValue("@F2", dsFirmas1.Tables[0].Rows[1][1].ToString());
			cryRepConec1.SetParameterValue("@F3", dsFirmas1.Tables[0].Rows[2][1].ToString());
			cryRepConec1.SetParameterValue("@F4", dsFirmas1.Tables[0].Rows[3][1].ToString());
            cryRepConec1.SetParameterValue("@F5", dsFirmas1.Tables[0].Rows[4][1].ToString());
            cryRepConec1.SetParameterValue("@C1", dsFirmas1.Tables[0].Rows[0][2].ToString());
			cryRepConec1.SetParameterValue("@C2", dsFirmas1.Tables[0].Rows[1][2].ToString());
			cryRepConec1.SetParameterValue("@C3", dsFirmas1.Tables[0].Rows[2][2].ToString());
			cryRepConec1.SetParameterValue("@C4", dsFirmas1.Tables[0].Rows[3][2].ToString());
            cryRepConec1.SetParameterValue("@C5", dsFirmas1.Tables[0].Rows[4][2].ToString());
            cryRepConec1.SetParameterValue("@Unidad", dsUnidad1.Tables[0].Rows[cmbUnidad.SelectedIndex][1].ToString());
			cryRepConec1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
			cryRepConec1.SetParameterValue("@Unidad1", unidad1);
			cryRepConec1.SetParameterValue("@Conversion", conversion);
			cryRepConec1.SetParameterValue("@Conversion1", conversion1);
			cryRepConec1.SetParameterValue("@Ruta", chbFormato.Checked);
			cryRepConec1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
			cryRepConec1.SetParameterValue("@Unidad", dsUnidad1.Tables[0].Rows[cmbUnidad.SelectedIndex][1].ToString(),"CryRepSubCon.rpt");
			cryRepConec1.SetParameterValue("@Lab", chbLab.Checked);
            cryRepConec1.SetParameterValue("@Ineco", chbLab1.Checked);
            cryRepConec1.SetParameterValue("@Respaldo", chbRespaldo.Checked);
			crvInfAcero.ReportSource = cryRepConec1;
            }
            else
            {
                cryRepConecO1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
                cryRepConecO1.SetDataSource(dsInfConec1);
                cryRepConecO1.SetParameterValue("@F1", dsFirmas1.Tables[0].Rows[0][1].ToString());
            cryRepConecO1.SetParameterValue("@F2", dsFirmas1.Tables[0].Rows[1][1].ToString());
            cryRepConecO1.SetParameterValue("@F3", dsFirmas1.Tables[0].Rows[2][1].ToString());
            cryRepConecO1.SetParameterValue("@F4", dsFirmas1.Tables[0].Rows[3][1].ToString());
            cryRepConecO1.SetParameterValue("@F5", dsFirmas1.Tables[0].Rows[4][1].ToString());
            cryRepConecO1.SetParameterValue("@C1", dsFirmas1.Tables[0].Rows[0][2].ToString());
            cryRepConecO1.SetParameterValue("@C2", dsFirmas1.Tables[0].Rows[1][2].ToString());
            cryRepConecO1.SetParameterValue("@C3", dsFirmas1.Tables[0].Rows[2][2].ToString());
            cryRepConecO1.SetParameterValue("@C4", dsFirmas1.Tables[0].Rows[3][2].ToString());
            cryRepConecO1.SetParameterValue("@C5", dsFirmas1.Tables[0].Rows[4][2].ToString());
            cryRepConecO1.SetParameterValue("@Unidad", dsUnidad1.Tables[0].Rows[cmbUnidad.SelectedIndex][1].ToString());
            cryRepConecO1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
            cryRepConecO1.SetParameterValue("@Unidad1", unidad1);
            cryRepConecO1.SetParameterValue("@Conversion", conversion);
            cryRepConecO1.SetParameterValue("@Conversion1", conversion1);
            cryRepConecO1.SetParameterValue("@Ruta", chbFormato.Checked);
            cryRepConecO1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
            cryRepConecO1.SetParameterValue("@Unidad", dsUnidad1.Tables[0].Rows[cmbUnidad.SelectedIndex][1].ToString(), "CryRepSubCon.rpt");
            cryRepConecO1.SetParameterValue("@Lab", chbLab.Checked);
            cryRepConecO1.SetParameterValue("@Ineco", chbLab1.Checked);
            cryRepConecO1.SetParameterValue("@Respaldo", chbRespaldo.Checked);
            crvInfAcero.ReportSource = cryRepConecO1;
        }
			//crvInfAcero.RefreshReport();
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			if(dsConecMdor1.Tables["ConecMdor"].Rows.Count > 0)
			{
				txtFolio.Text = dsConecMdor1.Tables["ConecMdor"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
				btnVistaPrevia.Visible = true;
			}
			else
			{
				btnVistaPrevia.Visible = false;
			}
		}

		private void InfConec_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsBusObra1, "Obra");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
		}

		private void chbLeyenda_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

        private void buscaBtn1_Load(object sender, EventArgs e)
        {

        }

	}
}
