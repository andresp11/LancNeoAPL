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
	/// Descripción breve de RepAnalisec.
	/// </summary>
	public class RepAnalisec : System.Windows.Forms.Form
	{
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsConcretera dsConcretera1;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPLanta;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		private LancNeo.dsPlanta dsPlanta1;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcreto;
		private LancNeo.dsConcreto dsConcreto1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAnalisis;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private System.Data.SqlClient.SqlDataAdapter sqlDATitulo;
		private System.Windows.Forms.Panel panel1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpIni;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.ComboBox cmbConcretera;
		private System.Windows.Forms.ComboBox cmbPlanta;
		private System.Windows.Forms.TextBox txtIdobra;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepAnalisis;
		private LancNeo.dsAnalisec dsAnalisec1;
		private System.Windows.Forms.TextBox txtMPa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private LancNeo.CryRepAnalisec cryRepAnalisec1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label label6;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorios;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Windows.Forms.ComboBox cmbLabAnalisec;
		private LancNeo.dsLabAnalisec dsLabAnalisec1;
		private System.Windows.Forms.ComboBox cmbOrigen;
		private System.Windows.Forms.Label label7;
		private LancNeo.dsOrigen dsOrigen1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RepAnalisec()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepAnalisec));
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.dsBuscaObra1 = new LancNeo.dsBuscaObra();
            this.sqlDAPLanta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.dsPlanta1 = new LancNeo.dsPlanta();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcreto = new System.Data.SqlClient.SqlDataAdapter();
            this.dsConcreto1 = new LancNeo.dsConcreto();
            this.sqlDAAnalisis = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATitulo = new System.Data.SqlClient.SqlDataAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.dsOrigen1 = new LancNeo.dsOrigen();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLabAnalisec = new System.Windows.Forms.ComboBox();
            this.dsLabAnalisec1 = new LancNeo.dsLabAnalisec();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMPa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.cmbConcretera = new System.Windows.Forms.ComboBox();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.crvRepAnalisis = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dsAnalisec1 = new LancNeo.dsAnalisec();
            this.cryRepAnalisec1 = new LancNeo.CryRepAnalisec();
            this.sqlDALaboratorios = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLabAnalisec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalisec1)).BeginInit();
            this.SuspendLayout();
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
            this.sqlCommand1.CommandText = "[ObrAnalisec]";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConn;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsConcretera1
            // 
            this.dsConcretera1.DataSetName = "dsConcretera";
            this.dsConcretera1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBuscaObra1
            // 
            this.dsBuscaObra1.DataSetName = "dsBuscaObra";
            this.dsBuscaObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBuscaObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dsPlanta1
            // 
            this.dsPlanta1.DataSetName = "dsPlanta";
            this.dsPlanta1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "[ConAnalisec]";
            this.sqlCommand2.CommandTimeout = 150;
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6)});
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
            // dsConcreto1
            // 
            this.dsConcreto1.DataSetName = "dsConcreto";
            this.dsConcreto1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcreto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlSelectCommand4.CommandText = "[Analisec]";
            this.sqlSelectCommand4.CommandTimeout = 150;
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
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
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@3i", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@7i", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@eei", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@datos", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@diaa", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@diab", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@diac", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Indice", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 1),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@ResistenciaMPa", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@Labs", System.Data.SqlDbType.Int, 4)});
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbOrigen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbLabAnalisec);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMPa);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.cmbConcretera);
            this.panel1.Controls.Add(this.cmbPlanta);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 90);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConcreto1.Muestras;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(388, 20);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(58, 54);
            this.buscaBtn1.TabIndex = 36;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(962, 8);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 37;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Origen:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DataSource = this.dsOrigen1.Origen;
            this.cmbOrigen.DisplayMember = "Origen";
            this.cmbOrigen.Location = new System.Drawing.Point(500, 58);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(98, 21);
            this.cmbOrigen.TabIndex = 45;
            this.cmbOrigen.ValueMember = "Origen";
            // 
            // dsOrigen1
            // 
            this.dsOrigen1.DataSetName = "dsOrigen";
            this.dsOrigen1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsOrigen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Laboratorio:";
            // 
            // cmbLabAnalisec
            // 
            this.cmbLabAnalisec.DataSource = this.dsLabAnalisec1.LabAnalisec;
            this.cmbLabAnalisec.DisplayMember = "IdLaboratorio";
            this.cmbLabAnalisec.Location = new System.Drawing.Point(220, 64);
            this.cmbLabAnalisec.Name = "cmbLabAnalisec";
            this.cmbLabAnalisec.Size = new System.Drawing.Size(80, 21);
            this.cmbLabAnalisec.TabIndex = 43;
            this.cmbLabAnalisec.ValueMember = "IdLaboratorio";
            // 
            // dsLabAnalisec1
            // 
            this.dsLabAnalisec1.DataSetName = "dsLabAnalisec";
            this.dsLabAnalisec1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLabAnalisec1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBuscaObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(220, 38);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 41;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 88);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "MPa";
            // 
            // txtMPa
            // 
            this.txtMPa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPa.Location = new System.Drawing.Point(794, 8);
            this.txtMPa.Name = "txtMPa";
            this.txtMPa.Size = new System.Drawing.Size(100, 29);
            this.txtMPa.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(606, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Planta:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Concretera:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(500, 26);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(500, 2);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Análisis Estadístico";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(364, 2);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            this.Fecha.Click += new System.EventHandler(this.Fecha_Click);
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbConcretera.DisplayMember = "IdConcretera";
            this.cmbConcretera.Location = new System.Drawing.Point(646, 2);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(78, 21);
            this.cmbConcretera.TabIndex = 5;
            this.cmbConcretera.ValueMember = "IdConcretera";
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DataSource = this.dsPlanta1.Planta;
            this.cmbPlanta.DisplayMember = "Planta";
            this.cmbPlanta.Enabled = false;
            this.cmbPlanta.Location = new System.Drawing.Point(646, 26);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(78, 21);
            this.cmbPlanta.TabIndex = 6;
            this.cmbPlanta.ValueMember = "IdPlanta";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(396, 34);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // crvRepAnalisis
            // 
            this.crvRepAnalisis.ActiveViewIndex = -1;
            this.crvRepAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepAnalisis.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepAnalisis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepAnalisis.EnableRefresh = false;
            this.crvRepAnalisis.Location = new System.Drawing.Point(0, 90);
            this.crvRepAnalisis.Name = "crvRepAnalisis";
            this.crvRepAnalisis.ShowCloseButton = false;
            this.crvRepAnalisis.ShowGroupTreeButton = false;
            this.crvRepAnalisis.ShowLogo = false;
            this.crvRepAnalisis.ShowRefreshButton = false;
            this.crvRepAnalisis.Size = new System.Drawing.Size(1028, 659);
            this.crvRepAnalisis.TabIndex = 12;
            this.crvRepAnalisis.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsAnalisec1
            // 
            this.dsAnalisec1.DataSetName = "dsAnalisec";
            this.dsAnalisec1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsAnalisec1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDALaboratorios
            // 
            this.sqlDALaboratorios.SelectCommand = this.sqlSelectCommand1;
            this.sqlDALaboratorios.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LabAnalisec", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[LabAnalisec]";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // RepAnalisec
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.crvRepAnalisis);
            this.Controls.Add(this.panel1);
            this.Name = "RepAnalisec";
            this.Text = "RepAnalisec";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepAnalisec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLabAnalisec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAnalisec1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void RepAnalisec_Load(object sender, System.EventArgs e)
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
			//			dsBuscaObra1.Tables[0].Rows.Add((Rr);
			sqlDABusObra.Fill(dsBuscaObra1, "Obra");

			DataColumn[] Llave1 = new DataColumn[1];
			Object[] Matrix = new Object[1];
			Llave1[0] = dsLabAnalisec1.Tables["LabAnalisec"].Columns["IdLaboratorio"];
			Matrix[0] = "Todos";
			dsLabAnalisec1.Tables["LabAnalisec"].BeginLoadData();
			dsLabAnalisec1.Tables["LabAnalisec"].LoadDataRow(Matrix,true);
			dsLabAnalisec1.Tables["LabAnalisec"].EndLoadData();
			//			dsBuscaObra1.Tables[0].Rows.Add((Rr);
			sqlDALaboratorios.Fill(dsLabAnalisec1, "LabAnalisec");

			Object[] Matriy = new Object[1];
			Matriy[0] = "LancNeo";
			dsOrigen1.Tables["Origen"].BeginLoadData();
			dsOrigen1.Tables["Origen"].LoadDataRow(Matriy,true);
			dsOrigen1.Tables["Origen"].EndLoadData();
			Matriy[0] = "Todos";
			dsOrigen1.Tables["Origen"].BeginLoadData();
			dsOrigen1.Tables["Origen"].LoadDataRow(Matriy,true);
			dsOrigen1.Tables["Origen"].EndLoadData();
			Matriy[0] = "Analisec";
			dsOrigen1.Tables["Origen"].BeginLoadData();
			dsOrigen1.Tables["Origen"].LoadDataRow(Matriy,true);
			dsOrigen1.Tables["Origen"].EndLoadData();

			dsConcretera1.Concretera.AddConcreteraRow("Todas","Todas","%");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			cmbConcretera.SelectedIndex = 0;
			dsPlanta1.Planta.AddPlantaRow(-1,"Todas",(cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString()));
			sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue);
			sqlDAPLanta.Fill(dsPlanta1, "Planta");
			cmbOrigen.SelectedIndex = 1;
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			btnVistaPrevia.Visible = true;
			txtMPa.Text = System.Convert.ToString((double.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString()) * 0.0980665));
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			try
			{
                crvRepAnalisis.Visible = true;
                cryRepAnalisec1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cryRepAnalisec1.SetDataSource(dsAnalisec1);				

                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
				
				CrystalDecisions.Shared.ParameterDiscreteValue pdvEdad = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvEdad.Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Normal" ? 1 : (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Rápido" ? 2 : 4));
				CrystalDecisions.Shared.ParameterDiscreteValue pdvRes = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvRes.Value = float.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString());
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
				CrystalDecisions.Shared.ParameterDiscreteValue pdvLab = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvLab.Value = -1;

				CrystalDecisions.Shared.ParameterDiscreteValue pdvCra = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvCra.Value = "Todas";
				CrystalDecisions.Shared.ParameterDiscreteValue pdvDir = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvDir.Value = "Todas";
				CrystalDecisions.Shared.ParameterDiscreteValue pdvObr = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvObr.Value = "Todas";
				CrystalDecisions.Shared.ParameterDiscreteValue pdvZon = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvZon.Value = "Todas";
				CrystalDecisions.Shared.ParameterDiscreteValue pdvLoc = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvLoc.Value = "Todas";

				pvCollection.Clear();
				pvCollection.Add(pdvEdad);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Edad"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvRes);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Res"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvTip);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Tip"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvTma);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Tma"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvRev);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Rev"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvTag);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Tag"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvCon);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Con"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvPla);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Pla"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvLab);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Lab"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvCra);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Cra"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvDir);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Dir"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvObr);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Obr"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvZon);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Zon"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvLoc);
				cryRepAnalisec1.DataDefinition.ParameterFields["@Loc"].ApplyCurrentValues(pvCollection);
			}
			catch(Exception ex1)
			{
				MessageBox.Show("parametro" + ex1.Message );
			}
		
			
			try
			{
				dsAnalisec1.Clear();
				int dias = 28;
				int tipo = 1;
				switch(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString())       
				{         
					case "Normal":
						dias = 28;
						tipo = 1;
						break;                  
					case "Rápido":
						dias = 14;
						tipo = 2;
						break;                  
					default:
						dias = 28;
						tipo = 1;
						break;
				}
					sqlDAAnalisis.SelectCommand.Parameters["@IdObra"].Value =  "%" ;
					sqlDAAnalisis.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue) ;
					sqlDAAnalisis.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
					sqlDAAnalisis.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
					sqlDAAnalisis.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
					sqlDAAnalisis.SelectCommand.Parameters["@ResistenciaKg"].Value = double.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString());
					sqlDAAnalisis.SelectCommand.Parameters["@Agregado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
					sqlDAAnalisis.SelectCommand.Parameters["@Renvenimiento"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][4].ToString();
					sqlDAAnalisis.SelectCommand.Parameters["@IdAgregado"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString() == "Normal" ? 1 : 2);
					sqlDAAnalisis.SelectCommand.Parameters["@IdPrueba"].Value = 1;
					sqlDAAnalisis.SelectCommand.Parameters["@IdUnidad"].Value = 2;
					sqlDAAnalisis.SelectCommand.Parameters["@NoEco"].Value = -1;
					sqlDAAnalisis.SelectCommand.Parameters["@3i"].Value = 0;
					sqlDAAnalisis.SelectCommand.Parameters["@7i"].Value = 0;
					sqlDAAnalisis.SelectCommand.Parameters["@eei"].Value = 0;
					sqlDAAnalisis.SelectCommand.Parameters["@diaa"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Tres" ? 2 : 3);
					sqlDAAnalisis.SelectCommand.Parameters["@diab"].Value = (dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][2].ToString() == "Tres" ? 14 : 7);
					sqlDAAnalisis.SelectCommand.Parameters["@diac"].Value = dias;
					sqlDAAnalisis.SelectCommand.Parameters["@Indice"].Value = 30;
					sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 1;
					sqlDAAnalisis.SelectCommand.Parameters["@Tipo"].Value = tipo;
					sqlDAAnalisis.SelectCommand.Parameters["@Grado"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString();
					sqlDAAnalisis.SelectCommand.Parameters["@IdDiam"].Value = 1;
					sqlDAAnalisis.SelectCommand.Parameters["@ResistenciaMPa"].Value = txtMPa.Text;
					sqlDAAnalisis.SelectCommand.Parameters["@IdLaboratorio"].Value = (cmbLabAnalisec.SelectedValue.ToString() == "Todos" ? "%" : cmbLabAnalisec.SelectedValue);
					sqlDAAnalisis.SelectCommand.Parameters["@Labs"].Value = (cmbOrigen.SelectedValue.ToString() == "Todos" ? 2 : cmbOrigen.SelectedIndex + 1);
					sqlDAAnalisis.Fill(dsAnalisec1, "Analisis1");
					sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 2;
					sqlDAAnalisis.Fill(dsAnalisec1, "Grafica1");
					sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 3;
					sqlDAAnalisis.Fill(dsAnalisec1, "GraficaFinal");

				dias = dsAnalisec1.Analisis1.Rows.Count;
				dias = dsAnalisec1.Grafica1.Rows.Count;
				dias = dsAnalisec1.GraficaFinal.Rows.Count;
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
					ee[i] = float.Parse(dsAnalisec1.Tables["GraficaFinal"].Rows[2][i].ToString());
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

				sqlDATitulo.SelectCommand.Parameters["@ResistenciaKg"].Value = dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1];
				sqlDATitulo.SelectCommand.Parameters["@IdUnidad"].Value = 2;
				sqlDATitulo.SelectCommand.Parameters["@Hoja"].Value = int.Parse(dsAnalisec1.Tables["GraficaFinal"].Rows[0][24].ToString());
				sqlDATitulo.Fill(dsAnalisec1,"Titulo");

				// Establece el valor actual de parameter1 en el subinforme en 10 
				double res = double.Parse(dsConcreto1.Tables["Muestras"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString())  ;
				res = res * 0.0980665;
				cryRepAnalisec1.SetParameterValue("@Unidad", "MPa");
				cryRepAnalisec1.SetParameterValue("@reskg", res.ToString(), "Gauss");
				cryRepAnalisec1.SetParameterValue("@res", res.ToString());
				cryRepAnalisec1.SetParameterValue("@Unidad", "MPa", "Gauss");
				cryRepAnalisec1.SetParameterValue("@Equi", 1);
				cryRepAnalisec1.SetParameterValue("@Prueba", "Compresión");
				cryRepAnalisec1.SetParameterValue("@Grado", "B");
				cryRepAnalisec1.SetParameterValue("@Indice", res.ToString() );
				cryRepAnalisec1.SetParameterValue("@Figura", "Diámetro cilindro");


				
				crvRepAnalisis.ReportSource = cryRepAnalisec1;
			//	crvRepAnalisis.RefreshReport();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}
		}

		private void Fecha_Click(object sender, System.EventArgs e)
		{
		
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsConcreto1.Clear();
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
			dsConcreto1.Clear();
			sqlDAConcreto.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text) ;
			sqlDAConcreto.Fill(dsConcreto1, "Muestras");
		}
	
	}
}
