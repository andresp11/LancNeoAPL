using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using System.Data;
using System.Data.SqlClient;
namespace LancNeo
{
	/// <summary>
	/// Descripción breve de RepExperiencia.
	/// </summary>
	public class RepExperiencia : System.Windows.Forms.Form
	{
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private LancNeo.CryRepExperiencia cryRepExperiencia1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDARepExperiencia;
		private System.Windows.Forms.Panel panel1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepExperiencia;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDAExpMues;
		private LancNeo.dsExpMues dsExpMues1;
		private System.Windows.Forms.ComboBox cmbConcretera;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsConcretera dsConcretera1;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpIni;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.ComboBox cmbUnidad;
		private System.Windows.Forms.Label label5;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsUnidad dsUnidad1;		
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtResistencia;
		private System.Windows.Forms.TextBox txtAgregado;
		private System.Windows.Forms.TextBox txtTipoAgregado;
		private System.Windows.Forms.TextBox txtRevenimento;
		private System.ComponentModel.IContainer components;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private Soluciones2000.Tools.WinLib.tbBtn tbBtnGenExp;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbPlanta;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPLanta;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		private LancNeo.dsPlanta dsPlanta1;
		public LancNeo.dsRepExperiencia dsRepExperiencia1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtGrado;
		private System.Windows.Forms.ComboBox cmbPrueba;
		private System.Windows.Forms.Label label13;
		private LancNeo.dsTipoPrueba dsTipoPrueba1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrueba;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cmbResistencia;
		private System.Data.SqlClient.SqlDataAdapter sqlDAResistencia;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private LancNeo.dsResis dsResis1;
        private dsExpMueP dsExpMueP1;
        private TextBox txtTipo;
        private TextBox txtTipoM;
        private SqlDataAdapter sqlDADiametro;
        private SqlCommand sqlCommand3;
        private dsDiametro dsDiametro1;
        private TextBox txtDiametro;
        private TextBox txtIdDiam;
		private bool blnCambioFecha;

		public RepExperiencia()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			blnCambioFecha = true;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepExperiencia));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsExpMueP1 = new LancNeo.dsExpMueP();
            this.dsExpMues1 = new LancNeo.dsExpMues();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cryRepExperiencia1 = new LancNeo.CryRepExperiencia();
            this.sqlDARepExperiencia = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBtnGenExp = new Soluciones2000.Tools.WinLib.tbBtn();
            this.txtTipoM = new System.Windows.Forms.TextBox();
            this.cmbResistencia = new System.Windows.Forms.ComboBox();
            this.dsResis1 = new LancNeo.dsResis();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.dsPlanta1 = new LancNeo.dsPlanta();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.cmbConcretera = new System.Windows.Forms.ComboBox();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResistencia = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAgregado = new System.Windows.Forms.TextBox();
            this.txtTipoAgregado = new System.Windows.Forms.TextBox();
            this.txtRevenimento = new System.Windows.Forms.TextBox();
            this.crvRepExperiencia = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAExpMues = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sqlDAPLanta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.dsRepExperiencia1 = new LancNeo.dsRepExperiencia();
            this.sqlDAPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAResistencia = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsDiametro1 = new LancNeo.dsDiametro();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.txtIdDiam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMueP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMues1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsResis1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepExperiencia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(997, 8);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnVistaPrevia, "Ver Reporte");
            this.btnVistaPrevia.Load += new System.EventHandler(this.btnVistaPrevia_Load);
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsExpMueP1.Muestras;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(332, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar parámetros para experiencia");
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsExpMueP1
            // 
            this.dsExpMueP1.DataSetName = "dsExpMueP";
            this.dsExpMueP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsExpMues1
            // 
            this.dsExpMues1.DataSetName = "dsExpMues";
            this.dsExpMues1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsExpMues1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Concretera:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reporte de Experiencia";
            // 
            // sqlDARepExperiencia
            // 
            this.sqlDARepExperiencia.SelectCommand = this.sqlSelectCommand1;
            this.sqlDARepExperiencia.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Experiencia", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("Agregado1", "Agregado1"),
                        new System.Data.Common.DataColumnMapping("Fechaini", "Fechaini"),
                        new System.Data.Common.DataColumnMapping("Fechafin", "Fechafin"),
                        new System.Data.Common.DataColumnMapping("Planta", "Planta"),
                        new System.Data.Common.DataColumnMapping("Muestras", "Muestras"),
                        new System.Data.Common.DataColumnMapping("d3a7", "d3a7"),
                        new System.Data.Common.DataColumnMapping("d3aEE", "d3aEE"),
                        new System.Data.Common.DataColumnMapping("d7aEE", "d7aEE"),
                        new System.Data.Common.DataColumnMapping("s3a7", "s3a7"),
                        new System.Data.Common.DataColumnMapping("s3EE", "s3EE"),
                        new System.Data.Common.DataColumnMapping("s7EE", "s7EE"),
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo")});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.tbBtnGenExp);
            this.panel1.Controls.Add(this.txtIdDiam);
            this.panel1.Controls.Add(this.txtDiametro);
            this.panel1.Controls.Add(this.txtTipoM);
            this.panel1.Controls.Add(this.cmbResistencia);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cmbPrueba);
            this.panel1.Controls.Add(this.txtGrado);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbPlanta);
            this.panel1.Controls.Add(this.cmbUnidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.cmbConcretera);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtResistencia);
            this.panel1.Controls.Add(this.txtTipo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtAgregado);
            this.panel1.Controls.Add(this.txtTipoAgregado);
            this.panel1.Controls.Add(this.txtRevenimento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 88);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbBtnGenExp
            // 
            this.tbBtnGenExp.BackColor = System.Drawing.Color.Transparent;
            this.tbBtnGenExp.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtnGenExp.Icon")));
            this.tbBtnGenExp.Location = new System.Drawing.Point(931, 8);
            this.tbBtnGenExp.Name = "tbBtnGenExp";
            this.tbBtnGenExp.Size = new System.Drawing.Size(64, 64);
            this.tbBtnGenExp.TabIndex = 26;
            this.tbBtnGenExp.Click += new System.EventHandler(this.tbBtnGenExp_Click);
            // 
            // txtTipoM
            // 
            this.txtTipoM.Location = new System.Drawing.Point(686, 32);
            this.txtTipoM.Name = "txtTipoM";
            this.txtTipoM.ReadOnly = true;
            this.txtTipoM.Size = new System.Drawing.Size(15, 20);
            this.txtTipoM.TabIndex = 35;
            // 
            // cmbResistencia
            // 
            this.cmbResistencia.DataSource = this.dsResis1;
            this.cmbResistencia.DisplayMember = "Resistencia.ResistenciaMPa";
            this.cmbResistencia.Location = new System.Drawing.Point(468, 8);
            this.cmbResistencia.Name = "cmbResistencia";
            this.cmbResistencia.Size = new System.Drawing.Size(80, 21);
            this.cmbResistencia.TabIndex = 34;
            this.cmbResistencia.ValueMember = "Resistencia.ResistenciaKG";
            // 
            // dsResis1
            // 
            this.dsResis1.DataSetName = "dsResis";
            this.dsResis1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsResis1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(398, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Resistencia:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(420, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Prueba:";
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(468, 33);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(80, 21);
            this.cmbPrueba.TabIndex = 31;
            this.cmbPrueba.ValueMember = "IdPrueba";
            // 
            // dsTipoPrueba1
            // 
            this.dsTipoPrueba1.DataSetName = "dsTipoPrueba";
            this.dsTipoPrueba1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipoPrueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(902, 65);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.ReadOnly = true;
            this.txtGrado.Size = new System.Drawing.Size(10, 20);
            this.txtGrado.TabIndex = 30;
            this.txtGrado.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(711, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Diametro:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Planta:";
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DataSource = this.dsPlanta1;
            this.cmbPlanta.DisplayMember = "Planta.Planta";
            this.cmbPlanta.Enabled = false;
            this.cmbPlanta.Location = new System.Drawing.Point(72, 57);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(121, 21);
            this.cmbPlanta.TabIndex = 27;
            this.cmbPlanta.ValueMember = "Planta.IdPlanta";
            // 
            // dsPlanta1
            // 
            this.dsPlanta1.DataSetName = "dsPlanta";
            this.dsPlanta1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.Undescr", true));
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsUnidad1, "Unidad.IdUnidad", true));
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(468, 57);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(80, 21);
            this.cmbUnidad.TabIndex = 21;
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
            this.label5.Location = new System.Drawing.Point(410, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(244, 57);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(80, 20);
            this.dtpFin.TabIndex = 18;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(212, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(244, 33);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(80, 20);
            this.dtpIni.TabIndex = 16;
            this.dtpIni.ValueChanged += new System.EventHandler(this.dtpIni_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(212, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Inicial:";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(226, 16);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(98, 13);
            this.Fecha.TabIndex = 17;
            this.Fecha.Text = "Fechas de periodo:";
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1;
            this.cmbConcretera.DisplayMember = "Concretera.IdConcretera";
            this.cmbConcretera.Location = new System.Drawing.Point(72, 33);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(121, 21);
            this.cmbConcretera.TabIndex = 15;
            this.cmbConcretera.ValueMember = "Concretera.IdConcretera";
            this.cmbConcretera.SelectedIndexChanged += new System.EventHandler(this.cmbConcretera_SelectedIndexChanged);
            // 
            // dsConcretera1
            // 
            this.dsConcretera1.DataSetName = "dsConcretera";
            this.dsConcretera1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(548, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Resistencia:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(582, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tipo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResistencia
            // 
            this.txtResistencia.Location = new System.Drawing.Point(616, 8);
            this.txtResistencia.Name = "txtResistencia";
            this.txtResistencia.ReadOnly = true;
            this.txtResistencia.Size = new System.Drawing.Size(64, 20);
            this.txtResistencia.TabIndex = 25;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(616, 32);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(64, 20);
            this.txtTipo.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(690, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Revenimento:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(557, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Agregado:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(683, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tipo Agregado:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAgregado
            // 
            this.txtAgregado.Location = new System.Drawing.Point(616, 56);
            this.txtAgregado.Name = "txtAgregado";
            this.txtAgregado.ReadOnly = true;
            this.txtAgregado.Size = new System.Drawing.Size(64, 20);
            this.txtAgregado.TabIndex = 25;
            // 
            // txtTipoAgregado
            // 
            this.txtTipoAgregado.Location = new System.Drawing.Point(768, 56);
            this.txtTipoAgregado.Name = "txtTipoAgregado";
            this.txtTipoAgregado.ReadOnly = true;
            this.txtTipoAgregado.Size = new System.Drawing.Size(119, 20);
            this.txtTipoAgregado.TabIndex = 25;
            // 
            // txtRevenimento
            // 
            this.txtRevenimento.Location = new System.Drawing.Point(768, 8);
            this.txtRevenimento.Name = "txtRevenimento";
            this.txtRevenimento.ReadOnly = true;
            this.txtRevenimento.Size = new System.Drawing.Size(119, 20);
            this.txtRevenimento.TabIndex = 25;
            // 
            // crvRepExperiencia
            // 
            this.crvRepExperiencia.ActiveViewIndex = -1;
            this.crvRepExperiencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepExperiencia.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepExperiencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepExperiencia.EnableRefresh = false;
            this.crvRepExperiencia.Location = new System.Drawing.Point(0, 88);
            this.crvRepExperiencia.Name = "crvRepExperiencia";
            this.crvRepExperiencia.ShowCloseButton = false;
            this.crvRepExperiencia.ShowGroupTreeButton = false;
            this.crvRepExperiencia.ShowLogo = false;
            this.crvRepExperiencia.Size = new System.Drawing.Size(1063, 421);
            this.crvRepExperiencia.TabIndex = 15;
            this.crvRepExperiencia.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepExperiencia.Load += new System.EventHandler(this.crvRepExperiencia_Load);
            // 
            // sqlDAExpMues
            // 
            this.sqlDAExpMues.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAExpMues.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestras", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8, "Fecha")});
            // 
            // sqlDAConcretera
            // 
            this.sqlDAConcretera.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAConcretera.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concretera", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("Concretera", "Concretera"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT IdConcretera, Concretera, Direccion FROM Concretera ORDER BY Concretera";
            this.sqlSelectCommand3.Connection = this.sqlConn;
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
            // dsRepExperiencia1
            // 
            this.dsRepExperiencia1.DataSetName = "dsRepExperiencia";
            this.dsRepExperiencia1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsRepExperiencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAPrueba
            // 
            this.sqlDAPrueba.SelectCommand = this.sqlCommand2;
            this.sqlDAPrueba.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipoprueba", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT IdPrueba, Prueba FROM Tipoprueba";
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // sqlDAResistencia
            // 
            this.sqlDAResistencia.SelectCommand = this.sqlSelectCommand4;
            this.sqlDAResistencia.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Resistencia", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("ResistenciaMPa", "ResistenciaMPa")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT STR(ResistenciaKG) AS ResistenciaKG, STR(ResistenciaKG) AS ResistenciaMPa " +
    "FROM Resistencia ORDER BY ResistenciaKG";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            // 
            // sqlDADiametro
            // 
            this.sqlDADiametro.SelectCommand = this.sqlCommand3;
            this.sqlDADiametro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Unidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Factor", "Factor"),
                        new System.Data.Common.DataColumnMapping("Undescr", "Undescr"),
                        new System.Data.Common.DataColumnMapping("MaxagrUn", "MaxagrUn"),
                        new System.Data.Common.DataColumnMapping("RevenUn", "RevenUn")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT     IdDiam, Diametro, Diametro + \' \' + Figura AS Figura\r\nFROM         Diam" +
    "etro\r\nORDER BY IdDiam";
            this.sqlCommand3.Connection = this.sqlConn;
            // 
            // dsDiametro1
            // 
            this.dsDiametro1.DataSetName = "dsDiametro";
            this.dsDiametro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDiametro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDiametro
            // 
            this.txtDiametro.Location = new System.Drawing.Point(768, 32);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.ReadOnly = true;
            this.txtDiametro.Size = new System.Drawing.Size(119, 20);
            this.txtDiametro.TabIndex = 36;
            // 
            // txtIdDiam
            // 
            this.txtIdDiam.Location = new System.Drawing.Point(893, 33);
            this.txtIdDiam.Name = "txtIdDiam";
            this.txtIdDiam.ReadOnly = true;
            this.txtIdDiam.Size = new System.Drawing.Size(10, 20);
            this.txtIdDiam.TabIndex = 37;
            // 
            // RepExperiencia
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1063, 509);
            this.Controls.Add(this.crvRepExperiencia);
            this.Controls.Add(this.panel1);
            this.Name = "RepExperiencia";
            this.Text = "RepExperiencia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepExperiencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMueP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExpMues1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsResis1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepExperiencia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void RepExperiencia_Load(object sender, System.EventArgs e)
		{
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			dsResis1.Resistencia.AddResistenciaRow("%","Todas");
			sqlDAResistencia.Fill(dsResis1, "Resistencia");
			//dsConcretera1.Concretera.AddConcreteraRow("Seleccione", "Seleccione", "");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			sqlDAPLanta.SelectCommand.Parameters[0].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1,"Planta");
			dtpIni.Value = DateTime.Today;
			dtpFin.Value = DateTime.Today;
			cmbResistencia.SelectedIndex = 0;
			LlenasSqlDA();				
		}
		private void LlenasSqlDA()
		{
			sqlDAExpMues.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Value;
			sqlDAExpMues.SelectCommand.Parameters["@FechaFin"].Value  = dtpFin.Value;
			dsExpMueP1.Clear();
			sqlDAExpMues.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAExpMues.Fill(dsExpMueP1, "Muestras");
			sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			//Si no cambio la fecha no hay que volver a cargar el dataset.
			if(blnCambioFecha)
			{
				LlenasSqlDA();				
			}

			if(dsExpMueP1.Tables["Muestras"].Rows.Count > 0)
			{
				if(buscaBtn1.ResultadoDialogo == DialogResult.OK) 
				{
					//txtPlanta.Text = dsExpMueP1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
					txtResistencia.Text  = dsExpMueP1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
					txtTipo.Text  = dsExpMueP1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
					txtAgregado.Text  = dsExpMueP1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString();
					txtRevenimento.Text  = dsExpMueP1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
					txtTipoAgregado.Text  = dsExpMueP1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString();
					txtGrado.Text         = dsExpMueP1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString();
                    txtTipoM.Text = dsExpMueP1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][8].ToString();
                    txtDiametro.Text = dsExpMueP1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][10].ToString();
                    txtIdDiam.Text = dsExpMueP1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][9].ToString();
                    if (txtResistencia.Text.Length > 0)
					{
						tbBtnGenExp.Visible = true;
					}
				}
			}
			blnCambioFecha = false;
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            int caseSwitch = int.Parse(txtTipoM.Text.Trim());
            string Dia1, Dia2, Dia3, Dia4, Dia5, Dia6;
            switch (caseSwitch)
            {
                case 1:
                    Dia1 = "  3a7";
                    Dia2 = " 3a28";
                    Dia3 = " 7a28";
                    Dia4 = "28a63";
                    Dia5 = "28a100";
                    Dia6 = "63a100";
                    break;
                case 2:
                    Dia1 = "  3a7";
                    Dia2 = " 3a14";
                    Dia3 = " 7a14";
                    Dia4 = "14a28";
                    Dia5 = "14a63";
                    Dia6 = "28a63";
                    break;
                case 6:
                case 11:
                    Dia1 = " 1a3";
                    Dia2 = " 1a7";
                    Dia3 = " 3a7";
                    Dia4 = " 7a14";
                    Dia5 = " 7a28";
                    Dia6 = "14a28";
                    break;
                case 7:
                case 12:
                    Dia1 = " 1a3";
                    Dia2 = " 1a7";
                    Dia3 = " 3a7";
                    Dia4 = "7a14";
                    Dia5 = "7a28";
                    Dia6 = "14a28";
                    break;
                case 8:
                case 13:
                    Dia1 = "16a20h";
                    Dia2 = "16a24h";
                    Dia3 = "20a24h";
                    Dia4 = "  1a3";
                    Dia5 = "  1a7";
                    Dia6 = "  3a7";
                    break;
                default:
                    Dia1 = "  3a7";
                    Dia2 = "  3a28";
                    Dia3 = "  7a28";
                    Dia4 = " 28a63";
                    Dia5 = "28a100";
                    Dia6 = "63a100";
                    break;                    
            }
            try
			{
                cryRepExperiencia1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape; 
                cryRepExperiencia1.SetDataSource(dsRepExperiencia1);
                dsRepExperiencia1.Clear();
				sqlDARepExperiencia.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue;
				sqlDARepExperiencia.SelectCommand.Parameters["@Tipo"].Value = txtTipoM.Text.Trim();
				sqlDARepExperiencia.Fill(dsRepExperiencia1, "Experiencia");

                cryRepExperiencia1.SetParameterValue("dia1", Dia1);
                cryRepExperiencia1.SetParameterValue("dia2", Dia2);
                cryRepExperiencia1.SetParameterValue("dia3", Dia3);
                cryRepExperiencia1.SetParameterValue("dia4", Dia4);
                cryRepExperiencia1.SetParameterValue("dia5", Dia5);
                cryRepExperiencia1.SetParameterValue("dia6", Dia6);


				crvRepExperiencia.ReportSource = cryRepExperiencia1;
				//crvRepExperiencia.RefreshReport();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}
		}
		private void tbBtnGenExp_Click(object sender, System.EventArgs e)
		{
				String strSql = "RepExperiencia '" + cmbConcretera.SelectedValue.ToString() + "','" + 
						cmbPlanta.SelectedValue.ToString() + "'," + txtResistencia.Text + "," + txtTipoM.Text.Trim() + "," +
						txtAgregado.Text + "," + txtRevenimento.Text + "," + txtTipoAgregado.Text + "," +
						cmbUnidad.SelectedValue.ToString() + ",'" +
						dtpIni.Value.ToShortDateString() + "','" + dtpFin.Value.ToShortDateString() + "'," +
                        "1" + ", '" + txtGrado.Text + "', " + cmbPrueba.SelectedValue.ToString() + "," + txtIdDiam.Text;
			SqlCommand sqlCmd = new SqlCommand(strSql, sqlConn);
			try
			{
				sqlConn.Open();
				sqlCmd.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if(sqlConn.State == ConnectionState.Open)
				{
					sqlConn.Close();
				}
			}
		}

		private void dtpIni_ValueChanged(object sender, System.EventArgs e)
		{
			blnCambioFecha = true;
			cmbConcretera_SelectedIndexChanged(sender,e);
		}

		private void dtpFin_ValueChanged(object sender, System.EventArgs e)
		{
			blnCambioFecha = true;
			cmbConcretera_SelectedIndexChanged(sender,e);
		}

		private void cmbConcretera_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			blnCambioFecha = true;
			if (cmbConcretera.SelectedIndex == 0)
				cmbPlanta.Enabled = false;
			else
				cmbPlanta.Enabled = true;
			dsPlanta1.Clear();
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",cmbConcretera.SelectedValue.ToString());
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
			cmbPlanta.SelectedIndex = 0;
			if(blnCambioFecha)
			{
				LlenasSqlDA();				
			}
		}

		private void crvRepExperiencia_Load(object sender, System.EventArgs e)
		{
		
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void btnVistaPrevia_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
