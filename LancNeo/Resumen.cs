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
	/// Descripción breve de Resumen.
	/// </summary>
	public class Resumen : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAResumen;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsDGObra dsDGObra1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsResumen dsResumen1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpIni;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpFin1;
		private System.Windows.Forms.DateTimePicker dtpIni1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpIni2;
		private System.Windows.Forms.DateTimePicker dtpFin2;
		private LancNeo.dsConcentra dsConcentra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcentra;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvResumen;
		private LancNeo.CryRepResumen cryRepResumen1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcepto;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.CheckBox cbkTotal;
		private System.Windows.Forms.CheckBox ckbAdicional1;
		private System.Windows.Forms.CheckBox ckbAdicional2;
		private LancNeo.dsDGObra dsDGObra2;
		private LancNeo.dsDGObra dsDGObra3;
		private LancNeo.dsDGObra dsDGObra4;
		private System.Windows.Forms.CheckBox ckbAdicional3;
		private System.Windows.Forms.CheckBox ckbAdicional4;
		private System.Windows.Forms.ComboBox cmbIdObr1;
		private System.Data.SqlClient.SqlDataAdapter sqlDASumaResumen;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Windows.Forms.ComboBox cmbIdObr2;
		private System.Windows.Forms.ComboBox cmbIdObr4;
		private System.Windows.Forms.ComboBox cmbIdObr3;
		private LancNeo.dsDGObra dsDGObra5;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Resumen()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resumen));
            this.sqlDAResumen = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsDGObra1 = new LancNeo.dsDGObra();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsResumen1 = new LancNeo.dsResumen();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsConcentra1 = new LancNeo.dsConcentra();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.ckbAdicional4 = new System.Windows.Forms.CheckBox();
            this.ckbAdicional3 = new System.Windows.Forms.CheckBox();
            this.ckbAdicional2 = new System.Windows.Forms.CheckBox();
            this.ckbAdicional1 = new System.Windows.Forms.CheckBox();
            this.cmbIdObr4 = new System.Windows.Forms.ComboBox();
            this.dsDGObra5 = new LancNeo.dsDGObra();
            this.cmbIdObr3 = new System.Windows.Forms.ComboBox();
            this.dsDGObra4 = new LancNeo.dsDGObra();
            this.cmbIdObr2 = new System.Windows.Forms.ComboBox();
            this.dsDGObra3 = new LancNeo.dsDGObra();
            this.cmbIdObr1 = new System.Windows.Forms.ComboBox();
            this.dsDGObra2 = new LancNeo.dsDGObra();
            this.cbkTotal = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFin2 = new System.Windows.Forms.DateTimePicker();
            this.dtpIni2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFin1 = new System.Windows.Forms.DateTimePicker();
            this.dtpIni1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.sqlDAConcentra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.crvResumen = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryRepResumen1 = new LancNeo.CryRepResumen();
            this.sqlDAConcepto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASumaResumen = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResumen1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcentra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra2)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDAResumen
            // 
            this.sqlDAResumen.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAResumen.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ResumenTrabajos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Column1", "Column1"),
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("Column2", "Column2"),
                        new System.Data.Common.DataColumnMapping("Column3", "Column3"),
                        new System.Data.Common.DataColumnMapping("Column4", "Column4"),
                        new System.Data.Common.DataColumnMapping("Column5", "Column5"),
                        new System.Data.Common.DataColumnMapping("Column6", "Column6")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[ResumenTrabajos]";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FIni1", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin1", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FIni2", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin2", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FHoy", System.Data.SqlDbType.DateTime, 8)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsDGObra1
            // 
            this.dsDGObra1.DataSetName = "dsDGObra";
            this.dsDGObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDGObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dsResumen1
            // 
            this.dsResumen1.DataSetName = "dsResumen";
            this.dsResumen1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsResumen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.ckbAdicional4);
            this.panel1.Controls.Add(this.ckbAdicional3);
            this.panel1.Controls.Add(this.ckbAdicional2);
            this.panel1.Controls.Add(this.ckbAdicional1);
            this.panel1.Controls.Add(this.cmbIdObr4);
            this.panel1.Controls.Add(this.cmbIdObr3);
            this.panel1.Controls.Add(this.cmbIdObr2);
            this.panel1.Controls.Add(this.cmbIdObr1);
            this.panel1.Controls.Add(this.cbkTotal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpFin2);
            this.panel1.Controls.Add(this.dtpIni2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpFin1);
            this.panel1.Controls.Add(this.dtpIni1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbkPrefijo);
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
            this.panel1.Size = new System.Drawing.Size(848, 116);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConcentra1.Concentra;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(368, 2);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(58, 54);
            this.buscaBtn1.TabIndex = 44;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsConcentra1
            // 
            this.dsConcentra1.DataSetName = "dsConcentra";
            this.dsConcentra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcentra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(774, 4);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 45;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // ckbAdicional4
            // 
            this.ckbAdicional4.Location = new System.Drawing.Point(214, 86);
            this.ckbAdicional4.Name = "ckbAdicional4";
            this.ckbAdicional4.Size = new System.Drawing.Size(62, 24);
            this.ckbAdicional4.TabIndex = 58;
            this.ckbAdicional4.Text = "Clave 4";
            this.ckbAdicional4.CheckedChanged += new System.EventHandler(this.ckbAdicional4_CheckedChanged);
            // 
            // ckbAdicional3
            // 
            this.ckbAdicional3.Location = new System.Drawing.Point(214, 64);
            this.ckbAdicional3.Name = "ckbAdicional3";
            this.ckbAdicional3.Size = new System.Drawing.Size(62, 24);
            this.ckbAdicional3.TabIndex = 57;
            this.ckbAdicional3.Text = "Clave 3";
            this.ckbAdicional3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ckbAdicional2
            // 
            this.ckbAdicional2.Location = new System.Drawing.Point(214, 42);
            this.ckbAdicional2.Name = "ckbAdicional2";
            this.ckbAdicional2.Size = new System.Drawing.Size(62, 24);
            this.ckbAdicional2.TabIndex = 56;
            this.ckbAdicional2.Text = "Clave 2";
            this.ckbAdicional2.CheckedChanged += new System.EventHandler(this.ckbAdicional2_CheckedChanged);
            // 
            // ckbAdicional1
            // 
            this.ckbAdicional1.Location = new System.Drawing.Point(214, 20);
            this.ckbAdicional1.Name = "ckbAdicional1";
            this.ckbAdicional1.Size = new System.Drawing.Size(62, 24);
            this.ckbAdicional1.TabIndex = 55;
            this.ckbAdicional1.Text = "Clave 1";
            this.ckbAdicional1.CheckedChanged += new System.EventHandler(this.ckbAdicional1_CheckedChanged);
            // 
            // cmbIdObr4
            // 
            this.cmbIdObr4.DataSource = this.dsDGObra5.Obra;
            this.cmbIdObr4.DisplayMember = "Idobra";
            this.cmbIdObr4.Enabled = false;
            this.cmbIdObr4.Location = new System.Drawing.Point(280, 88);
            this.cmbIdObr4.Name = "cmbIdObr4";
            this.cmbIdObr4.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObr4.TabIndex = 53;
            this.cmbIdObr4.ValueMember = "IdObra";
            // 
            // dsDGObra5
            // 
            this.dsDGObra5.DataSetName = "dsDGObra";
            this.dsDGObra5.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDGObra5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbIdObr3
            // 
            this.cmbIdObr3.DataSource = this.dsDGObra4.Obra;
            this.cmbIdObr3.DisplayMember = "Idobra";
            this.cmbIdObr3.Enabled = false;
            this.cmbIdObr3.Location = new System.Drawing.Point(280, 66);
            this.cmbIdObr3.Name = "cmbIdObr3";
            this.cmbIdObr3.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObr3.TabIndex = 51;
            this.cmbIdObr3.ValueMember = "IdObra";
            // 
            // dsDGObra4
            // 
            this.dsDGObra4.DataSetName = "dsDGObra";
            this.dsDGObra4.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDGObra4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbIdObr2
            // 
            this.cmbIdObr2.DataSource = this.dsDGObra3.Obra;
            this.cmbIdObr2.DisplayMember = "Idobra";
            this.cmbIdObr2.Enabled = false;
            this.cmbIdObr2.Location = new System.Drawing.Point(280, 44);
            this.cmbIdObr2.Name = "cmbIdObr2";
            this.cmbIdObr2.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObr2.TabIndex = 49;
            this.cmbIdObr2.ValueMember = "IdObra";
            // 
            // dsDGObra3
            // 
            this.dsDGObra3.DataSetName = "dsDGObra";
            this.dsDGObra3.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDGObra3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbIdObr1
            // 
            this.cmbIdObr1.DataSource = this.dsDGObra2.Obra;
            this.cmbIdObr1.DisplayMember = "Idobra";
            this.cmbIdObr1.Enabled = false;
            this.cmbIdObr1.Location = new System.Drawing.Point(280, 22);
            this.cmbIdObr1.Name = "cmbIdObr1";
            this.cmbIdObr1.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObr1.TabIndex = 47;
            this.cmbIdObr1.ValueMember = "IdObra";
            // 
            // dsDGObra2
            // 
            this.dsDGObra2.DataSetName = "dsDGObra";
            this.dsDGObra2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDGObra2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbkTotal
            // 
            this.cbkTotal.Checked = true;
            this.cbkTotal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkTotal.Location = new System.Drawing.Point(2, 52);
            this.cbkTotal.Name = "cbkTotal";
            this.cbkTotal.Size = new System.Drawing.Size(148, 24);
            this.cbkTotal.TabIndex = 46;
            this.cbkTotal.Text = "Incluye total de muestas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(686, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tercer periodo";
            // 
            // dtpFin2
            // 
            this.dtpFin2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin2.Location = new System.Drawing.Point(686, 44);
            this.dtpFin2.Name = "dtpFin2";
            this.dtpFin2.Size = new System.Drawing.Size(84, 20);
            this.dtpFin2.TabIndex = 42;
            this.dtpFin2.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dtpIni2
            // 
            this.dtpIni2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni2.Location = new System.Drawing.Point(686, 22);
            this.dtpIni2.Name = "dtpIni2";
            this.dtpIni2.Size = new System.Drawing.Size(84, 20);
            this.dtpIni2.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Segundo periodo";
            // 
            // dtpFin1
            // 
            this.dtpFin1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin1.Location = new System.Drawing.Point(586, 44);
            this.dtpFin1.Name = "dtpFin1";
            this.dtpFin1.Size = new System.Drawing.Size(84, 20);
            this.dtpFin1.TabIndex = 39;
            // 
            // dtpIni1
            // 
            this.dtpIni1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni1.Location = new System.Drawing.Point(586, 22);
            this.dtpIni1.Name = "dtpIni1";
            this.dtpIni1.Size = new System.Drawing.Size(84, 20);
            this.dtpIni1.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Primer periodo";
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(2, 76);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 36;
            this.cbkPrefijo.Text = "No prefijo";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(486, 44);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(486, 22);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsDGObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(280, 0);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resumen de trabajos de laboratorio";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(436, 4);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(45, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas:";
            this.Fecha.Click += new System.EventHandler(this.Fecha_Click);
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(370, 30);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // sqlDAConcentra
            // 
            this.sqlDAConcentra.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAConcentra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concentra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT IdObra, Fecha, Semana FROM Concentra WHERE (IdObra = @IdObra) ORDER BY IdO" +
    "bra, Fecha";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // crvResumen
            // 
            this.crvResumen.ActiveViewIndex = -1;
            this.crvResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvResumen.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvResumen.EnableRefresh = false;
            this.crvResumen.Location = new System.Drawing.Point(0, 116);
            this.crvResumen.Name = "crvResumen";
            this.crvResumen.ShowCloseButton = false;
            this.crvResumen.ShowGroupTreeButton = false;
            this.crvResumen.ShowLogo = false;
            this.crvResumen.Size = new System.Drawing.Size(848, 265);
            this.crvResumen.TabIndex = 13;
            this.crvResumen.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // sqlDAConcepto
            // 
            this.sqlDAConcepto.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAConcepto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concepto", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("Concepto", "Concepto")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT IdConcepto, Concepto FROM Concepto ORDER BY IdConcepto";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlDASumaResumen
            // 
            this.sqlDASumaResumen.SelectCommand = this.sqlSelectCommand4;
            this.sqlDASumaResumen.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SumaResumen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("Pres", "Pres"),
                        new System.Data.Common.DataColumnMapping("Parc1", "Parc1"),
                        new System.Data.Common.DataColumnMapping("Parc2", "Parc2"),
                        new System.Data.Common.DataColumnMapping("Parc3", "Parc3"),
                        new System.Data.Common.DataColumnMapping("total", "total"),
                        new System.Data.Common.DataColumnMapping("PreUni", "PreUni"),
                        new System.Data.Common.DataColumnMapping("PreLis", "PreLis")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "[SumaResumen]";
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdObr1", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdObr2", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdObr3", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdObr4", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FIni1", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin1", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FIni2", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin2", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FHoy", System.Data.SqlDbType.DateTime, 8)});
            // 
            // Resumen
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(848, 381);
            this.Controls.Add(this.crvResumen);
            this.Controls.Add(this.panel1);
            this.Name = "Resumen";
            this.Text = "Resumen de trabajos de laboratorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Resumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResumen1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcentra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Fecha_Click(object sender, System.EventArgs e)
		{
		
		}

		private void dateTimePicker3_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            cryRepResumen1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            cryRepResumen1.SetDataSource(dsResumen1);				
            
            decimal [] tot = new decimal[8];
			for (int i = 0; i<8;i++)
				tot[i] = 0;
			crvResumen.Visible = true;
			dsResumen1.Clear();
			try 
			{
				sqlDAConcepto.Fill(dsResumen1, "Concepto");
			}
			catch(Exception ex)
			{
				ex.ToString();
			}
			dsResumen1.Clear();
			sqlDAConcepto.Fill(dsResumen1, "Concepto");
			if (ckbAdicional1.Checked || ckbAdicional2.Checked || ckbAdicional3.Checked || ckbAdicional4.Checked)
			{
				sqlDASumaResumen.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim() + (cbkPrefijo.Checked  ? "" : "%");
				sqlDASumaResumen.SelectCommand.Parameters["@IdObr1"].Value = (ckbAdicional1.Checked ? (cmbIdObr1.SelectedValue.ToString() + (cbkPrefijo.Checked  ? "" : "%")) : "");
				sqlDASumaResumen.SelectCommand.Parameters["@IdObr2"].Value = (ckbAdicional2.Checked ? (cmbIdObr2.SelectedValue.ToString() + (cbkPrefijo.Checked  ? "" : "%")) : "");
				sqlDASumaResumen.SelectCommand.Parameters["@IdObr3"].Value = (ckbAdicional3.Checked ? (cmbIdObr3.SelectedValue.ToString() + (cbkPrefijo.Checked  ? "" : "%")) : "");
				sqlDASumaResumen.SelectCommand.Parameters["@IdObr4"].Value = (ckbAdicional4.Checked ? (cmbIdObr4.SelectedValue.ToString() + (cbkPrefijo.Checked  ? "" : "%")) : "");
				sqlDASumaResumen.SelectCommand.Parameters["@FIni"].Value = dtpIni.Text;
				sqlDASumaResumen.SelectCommand.Parameters["@FFin"].Value = dtpFin.Text;
				sqlDASumaResumen.SelectCommand.Parameters["@FIni1"].Value = dtpIni1.Text;
				sqlDASumaResumen.SelectCommand.Parameters["@FFin1"].Value = dtpFin1.Text;
				sqlDASumaResumen.SelectCommand.Parameters["@FIni2"].Value = dtpIni2.Text;
				sqlDASumaResumen.SelectCommand.Parameters["@FFin2"].Value = dtpFin2.Text;
				sqlDASumaResumen.SelectCommand.Parameters["@FHoy"].Value = DateTime.Today;
				sqlDASumaResumen.Fill(dsResumen1, "ResumenTrabajos");
			}
			else
			{
				sqlDAResumen.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim() + (cbkPrefijo.Checked  ? "" : "%");
				sqlDAResumen.SelectCommand.Parameters["@FIni"].Value = dtpIni.Text;
				sqlDAResumen.SelectCommand.Parameters["@FFin"].Value = dtpFin.Text;
				sqlDAResumen.SelectCommand.Parameters["@FIni1"].Value = dtpIni1.Text;
				sqlDAResumen.SelectCommand.Parameters["@FFin1"].Value = dtpFin1.Text;
				sqlDAResumen.SelectCommand.Parameters["@FIni2"].Value = dtpIni2.Text;
				sqlDAResumen.SelectCommand.Parameters["@FFin2"].Value = dtpFin2.Text;
				sqlDAResumen.SelectCommand.Parameters["@FHoy"].Value = DateTime.Today;
				sqlDAResumen.Fill(dsResumen1, "ResumenTrabajos");
			}
			foreach (DataRow dr in dsResumen1.Tables["ResumenTrabajos"].Rows)
			{
				tot[0] += decimal.Parse(dr["Pres"].ToString()) * decimal.Parse(dr["Preuni"].ToString());
				tot[1] += decimal.Parse(dr["Parc1"].ToString()) * decimal.Parse(dr["Preuni"].ToString());
				tot[2] += decimal.Parse(dr["Parc2"].ToString()) * decimal.Parse(dr["Preuni"].ToString());
				tot[3] += decimal.Parse(dr["Parc3"].ToString()) * decimal.Parse(dr["Preuni"].ToString());
				tot[4] += decimal.Parse(dr["Total"].ToString()) * decimal.Parse(dr["Preuni"].ToString());
				if (dr["IdConcepto"].ToString() != "14" && dr["IdConcepto"].ToString() != "16" && dr["IdConcepto"].ToString() != "17" && dr["IdConcepto"].ToString() != "18" && dr["IdConcepto"].ToString() != "19" && dr["IdConcepto"].ToString() != "20")
					tot[5] += decimal.Parse(dr["Total"].ToString()) * decimal.Parse(dr["Prelis"].ToString()); //14, 16, 17, 18, 19, 20 
				if (dr["IdConcepto"].ToString() != "10" &&  dr["IdConcepto"].ToString() != "18" && dr["IdConcepto"].ToString() != "19" && dr["IdConcepto"].ToString() != "20")
					tot[6] += decimal.Parse(dr["Total"].ToString()) * decimal.Parse(dr["Prelis"].ToString());
				if (dr["IdConcepto"].ToString() != "10" &&  dr["IdConcepto"].ToString() != "14" && dr["IdConcepto"].ToString() != "16" && dr["IdConcepto"].ToString() != "17" && dr["IdConcepto"].ToString() != "30")
					tot[7] += decimal.Parse(dr["Total"].ToString()) * decimal.Parse(dr["Prelis"].ToString());
			}
			dsResumen1.Tables["Concepto"].Rows[0]["Tot1"] = tot[0];
			dsResumen1.Tables["Concepto"].Rows[0]["Tot2"] = tot[1];
			dsResumen1.Tables["Concepto"].Rows[0]["Tot3"] = tot[2];
			dsResumen1.Tables["Concepto"].Rows[0]["Tot4"] = tot[3];
			dsResumen1.Tables["Concepto"].Rows[0]["Tot5"] = tot[4];
			dsResumen1.Tables["Concepto"].Rows[0]["Tot6"] = tot[5];
			dsResumen1.Tables["Concepto"].Rows[0]["Tot7"] = tot[6];
			dsResumen1.Tables["Concepto"].Rows[0]["Tot8"] = tot[7];
			string obras = "";
			if (ckbAdicional1.Checked || ckbAdicional2.Checked || ckbAdicional3.Checked || ckbAdicional4.Checked)
			{
				obras  = (ckbAdicional1.Checked ? (cmbIdObr1.SelectedValue.ToString() + (cbkPrefijo.Checked  ? "" : "%") + " ") : "");
				obras += (ckbAdicional2.Checked ? (cmbIdObr2.SelectedValue.ToString() + (cbkPrefijo.Checked  ? "" : "%") + " ") : "");
				obras += (ckbAdicional3.Checked ? (cmbIdObr3.SelectedValue.ToString() + (cbkPrefijo.Checked  ? "" : "%") + " ") : "");
				obras += (ckbAdicional4.Checked ? (cmbIdObr4.SelectedValue.ToString() + (cbkPrefijo.Checked  ? "" : "%") + " ") : "");
			}

			cryRepResumen1.SetParameterValue("@Cons", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][3].ToString());
			cryRepResumen1.SetParameterValue("@Ubica", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][1].ToString());
			cryRepResumen1.SetParameterValue("@Col", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][4].ToString());
			cryRepResumen1.SetParameterValue("@Zona", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][5].ToString());
			cryRepResumen1.SetParameterValue("@Fi", dtpIni.Value);
			cryRepResumen1.SetParameterValue("@Ff", dtpFin.Value);
			cryRepResumen1.SetParameterValue("@Fi1", dtpIni1.Value);
			cryRepResumen1.SetParameterValue("@Ff1", dtpFin1.Value);
			cryRepResumen1.SetParameterValue("@Fi2", dtpIni2.Value);
			cryRepResumen1.SetParameterValue("@Ff2", dtpFin2.Value);
			cryRepResumen1.SetParameterValue("@Total", cbkTotal.Checked);
			cryRepResumen1.SetParameterValue("@Obras", obras);

			
			crvResumen.ReportSource = cryRepResumen1;
			//crvResumen.RefreshReport();
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void Resumen_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsDGObra1, "Obra");
			sqlDABusObra.Fill(dsDGObra2, "Obra");
			sqlDABusObra.Fill(dsDGObra3, "Obra");
			sqlDABusObra.Fill(dsDGObra4, "Obra");
			sqlDABusObra.Fill(dsDGObra5, "Obra");
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			if(dsConcentra1.Tables["Concentra"].Rows.Count > 0)
			{
				dtpIni.Text = dsConcentra1.Tables["Concentra"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
				dtpIni1.Text = dsConcentra1.Tables["Concentra"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
				dtpIni2.Text = dsConcentra1.Tables["Concentra"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
				btnVistaPrevia.Visible = true;
			}
			else
			{
				btnVistaPrevia.Visible = false;
			}
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsConcentra1.Clear();
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
			LlenasSqlDA();
		}
		private void LlenasSqlDA()
		{
			sqlDAConcentra.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAConcentra.Fill(dsConcentra1, "Concentra");
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			cmbIdObr3.Enabled = ckbAdicional3.Checked;
			cmbIdObr3.SelectedIndex = -1;
		}

		private void ckbAdicional2_CheckedChanged(object sender, System.EventArgs e)
		{
			cmbIdObr2.Enabled = ckbAdicional2.Checked;
			cmbIdObr2.SelectedIndex = -1;
		}

		private void ckbAdicional1_CheckedChanged(object sender, System.EventArgs e)
		{
			cmbIdObr1.Enabled = ckbAdicional1.Checked;
			cmbIdObr1.SelectedIndex = -1;
		}

		private void ckbAdicional4_CheckedChanged(object sender, System.EventArgs e)
		{
			cmbIdObr4.Enabled = ckbAdicional4.Checked;
			cmbIdObr4.SelectedIndex = -1;
		}

	}
}
