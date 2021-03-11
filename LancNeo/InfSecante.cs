using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de InfSecante.
	/// </summary>
	public class InfSecante : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAInfSecante;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsBusObra dsBusObra1;
		private LancNeo.dsUnidad dsUnidad1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDAFirmas;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private LancNeo.dsFirmas dsFirmas1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsInfSecante dsInfSecante1;
		private System.Windows.Forms.Panel panel1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.ComboBox cmbUnidad;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Windows.Forms.TextBox txtFolioIni;
		private System.Windows.Forms.TextBox txtFolioFin;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDASecante;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfSecante;
		private LancNeo.CryRepSecante cryRepSecante1;
		private LancNeo.dsSecanteInf dsSecanteInf1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nudRenglon;
		private System.Windows.Forms.CheckBox chbDuplicado;
		private System.Windows.Forms.CheckBox chbFormato;
		private System.Windows.Forms.CheckBox chbLeyenda;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlDataAdapter sqlDANorma;
		private System.Windows.Forms.CheckBox chbLab;
        private CheckBox chbLab1;
        private TextBox txtDesc;
        private CheckBox chbTodos;
        private CheckBox chbRespaldo;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public InfSecante()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfSecante));
            this.sqlDAInfSecante = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAFirmas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsFirmas1 = new LancNeo.dsFirmas();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsInfSecante1 = new LancNeo.dsInfSecante();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsSecanteInf1 = new LancNeo.dsSecanteInf();
            this.chbRespaldo = new System.Windows.Forms.CheckBox();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.chbLab1 = new System.Windows.Forms.CheckBox();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.chbFormato = new System.Windows.Forms.CheckBox();
            this.chbDuplicado = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudRenglon = new System.Windows.Forms.NumericUpDown();
            this.txtFolioFin = new System.Windows.Forms.TextBox();
            this.txtFolioIni = new System.Windows.Forms.TextBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.sqlDASecante = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.crvInfSecante = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryRepSecante1 = new LancNeo.CryRepSecante();
            this.sqlDANorma = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfSecante1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecanteInf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenglon)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDAInfSecante
            // 
            this.sqlDAInfSecante.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAInfSecante.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SecanteRep", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FEnsaye", "FEnsaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("Observac", "Observac"),
                        new System.Data.Common.DataColumnMapping("PromedioP", "PromedioP"),
                        new System.Data.Common.DataColumnMapping("PromedioR", "PromedioR"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("IdCroncretera", "IdCroncretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimiento", "Revenimiento"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("IdRemision", "IdRemision"),
                        new System.Data.Common.DataColumnMapping("RevObt", "RevObt"),
                        new System.Data.Common.DataColumnMapping("Cilindro", "Cilindro"),
                        new System.Data.Common.DataColumnMapping("Edad", "Edad"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("Resistencia", "Resistencia"),
                        new System.Data.Common.DataColumnMapping("Obtenido", "Obtenido"),
                        new System.Data.Common.DataColumnMapping("Promedio", "Promedio"),
                        new System.Data.Common.DataColumnMapping("Requerido", "Requerido"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.SecanteRep";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "LE1218"),
            new System.Data.SqlClient.SqlParameter("@FolioIni", System.Data.SqlDbType.Char, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "71/18"),
            new System.Data.SqlClient.SqlParameter("@FOlioFin", System.Data.SqlDbType.Char, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "71/18"),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "1")});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsUnidad1
            // 
            this.dsUnidad1.DataSetName = "dsUnidad";
            this.dsUnidad1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsUnidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
    "me = 1) AND (Moduloelastico < 6)\r\nORDER BY Moduloelastico";
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
            // dsInfSecante1
            // 
            this.dsInfSecante1.DataSetName = "dsInfSecante";
            this.dsInfSecante1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsInfSecante1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.chbRespaldo);
            this.panel1.Controls.Add(this.chbTodos);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.chbLab1);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.chbFormato);
            this.panel1.Controls.Add(this.chbDuplicado);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nudRenglon);
            this.panel1.Controls.Add(this.txtFolioFin);
            this.panel1.Controls.Add(this.txtFolioIni);
            this.panel1.Controls.Add(this.cmbUnidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 118);
            this.panel1.TabIndex = 11;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(714, 24);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 63);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Load += new System.EventHandler(this.btnVistaPrevia_Load);
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 650;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsSecanteInf1.Secante;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(396, -3);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 63);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsSecanteInf1
            // 
            this.dsSecanteInf1.DataSetName = "dsSecanteInf";
            this.dsSecanteInf1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsSecanteInf1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chbRespaldo
            // 
            this.chbRespaldo.ForeColor = System.Drawing.Color.White;
            this.chbRespaldo.Location = new System.Drawing.Point(507, 58);
            this.chbRespaldo.Name = "chbRespaldo";
            this.chbRespaldo.Size = new System.Drawing.Size(116, 24);
            this.chbRespaldo.TabIndex = 45;
            this.chbRespaldo.Text = "Respaldo";
            // 
            // chbTodos
            // 
            this.chbTodos.ForeColor = System.Drawing.Color.White;
            this.chbTodos.Location = new System.Drawing.Point(507, 35);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(124, 24);
            this.chbTodos.TabIndex = 43;
            this.chbTodos.Text = "Todos los informes";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(870, 28);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 42;
            // 
            // chbLab1
            // 
            this.chbLab1.Checked = true;
            this.chbLab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab1.ForeColor = System.Drawing.Color.White;
            this.chbLab1.Location = new System.Drawing.Point(212, 58);
            this.chbLab1.Name = "chbLab1";
            this.chbLab1.Size = new System.Drawing.Size(133, 24);
            this.chbLab1.TabIndex = 41;
            this.chbLab1.Text = "Incluye laboratorista";
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.ForeColor = System.Drawing.Color.White;
            this.chbLab.Location = new System.Drawing.Point(212, 81);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(183, 24);
            this.chbLab.TabIndex = 36;
            this.chbLab.Text = "Incluye Laboratorios";
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.Checked = true;
            this.chbLeyenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLeyenda.ForeColor = System.Drawing.Color.White;
            this.chbLeyenda.Location = new System.Drawing.Point(507, 81);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(110, 24);
            this.chbLeyenda.TabIndex = 35;
            this.chbLeyenda.Text = "Formato leyenda";
            // 
            // chbFormato
            // 
            this.chbFormato.ForeColor = System.Drawing.Color.White;
            this.chbFormato.Location = new System.Drawing.Point(25, 81);
            this.chbFormato.Name = "chbFormato";
            this.chbFormato.Size = new System.Drawing.Size(182, 24);
            this.chbFormato.TabIndex = 34;
            this.chbFormato.Text = "Incluye imagen de acreditación";
            this.chbFormato.CheckedChanged += new System.EventHandler(this.chbFormato_CheckedChanged);
            // 
            // chbDuplicado
            // 
            this.chbDuplicado.ForeColor = System.Drawing.Color.White;
            this.chbDuplicado.Location = new System.Drawing.Point(408, 81);
            this.chbDuplicado.Name = "chbDuplicado";
            this.chbDuplicado.Size = new System.Drawing.Size(89, 25);
            this.chbDuplicado.TabIndex = 31;
            this.chbDuplicado.Text = "¿Duplicado?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(596, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Especio entre renglones:";
            // 
            // nudRenglon
            // 
            this.nudRenglon.Location = new System.Drawing.Point(730, -2);
            this.nudRenglon.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudRenglon.Name = "nudRenglon";
            this.nudRenglon.Size = new System.Drawing.Size(48, 20);
            this.nudRenglon.TabIndex = 29;
            this.nudRenglon.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtFolioFin
            // 
            this.txtFolioFin.Location = new System.Drawing.Point(926, 81);
            this.txtFolioFin.Name = "txtFolioFin";
            this.txtFolioFin.Size = new System.Drawing.Size(54, 20);
            this.txtFolioFin.TabIndex = 28;
            this.txtFolioFin.Visible = false;
            this.txtFolioFin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFolioIni
            // 
            this.txtFolioIni.Location = new System.Drawing.Point(532, 0);
            this.txtFolioIni.Name = "txtFolioIni";
            this.txtFolioIni.Size = new System.Drawing.Size(54, 20);
            this.txtFolioIni.TabIndex = 27;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(308, 33);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(80, 21);
            this.cmbUnidad.TabIndex = 25;
            this.cmbUnidad.ValueMember = "IdUnidad";
            this.cmbUnidad.SelectedIndexChanged += new System.EventHandler(this.cmbUnidad_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(262, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Unidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(864, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Folio final:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(462, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Folio inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(308, 0);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe de Módulo Elástico Secante NMX-C-128";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(396, 32);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // sqlDASecante
            // 
            this.sqlDASecante.SelectCommand = this.sqlSelectCommand2;
            this.sqlDASecante.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Secante", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("PromedioP", "PromedioP"),
                        new System.Data.Common.DataColumnMapping("PromedioR", "PromedioR")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT FOLIO, IdObra, ConsObra, Fensaye, Finforme, NoEco, Semana FROM Secante WHE" +
    "RE (IdObra = @IdObra) ORDER BY FOLIO";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // crvInfSecante
            // 
            this.crvInfSecante.ActiveViewIndex = -1;
            this.crvInfSecante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfSecante.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfSecante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfSecante.EnableRefresh = false;
            this.crvInfSecante.Location = new System.Drawing.Point(0, 118);
            this.crvInfSecante.Name = "crvInfSecante";
            this.crvInfSecante.ShowCloseButton = false;
            this.crvInfSecante.ShowGroupTreeButton = false;
            this.crvInfSecante.ShowLogo = false;
            this.crvInfSecante.Size = new System.Drawing.Size(1028, 487);
            this.crvInfSecante.TabIndex = 12;
            this.crvInfSecante.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvInfSecante.ToolPanelWidth = 167;
            // 
            // sqlDANorma
            // 
            this.sqlDANorma.SelectCommand = this.sqlSelectCommand3;
            this.sqlDANorma.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Normas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdNorma", "IdNorma"),
                        new System.Data.Common.DataColumnMapping("Informe", "Informe"),
                        new System.Data.Common.DataColumnMapping("Normas", "Normas"),
                        new System.Data.Common.DataColumnMapping("Titulo", "Titulo"),
                        new System.Data.Common.DataColumnMapping("IdInforme", "IdInforme")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT IdNorma, Informe, Normas, Titulo, IdInforme FROM Normas WHERE (IdNorma = 9" +
    ") ORDER BY IdNorma";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // InfSecante
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1028, 605);
            this.Controls.Add(this.crvInfSecante);
            this.Controls.Add(this.panel1);
            this.Name = "InfSecante";
            this.Text = "InfSecante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfSecante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfSecante1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecanteInf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenglon)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void InfSecante_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsBusObra1, "Obra");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
			dsSecanteInf1.Clear();
			sqlDASecante.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDASecante.Fill(dsSecanteInf1, "Secante");
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			if(dsSecanteInf1.Tables["Secante"].Rows.Count > 0)
			{
				txtFolioIni.Text = dsSecanteInf1.Tables["Secante"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
				txtFolioFin.Text = dsSecanteInf1.Tables["Secante"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
				btnVistaPrevia.Visible = true;
			}
			else
			{
				btnVistaPrevia.Visible = false;
			}
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			string renglon = "";
			for (int i = 1; i <= nudRenglon.Value ; i++)
				renglon += "\r\n";
			crvInfSecante.Visible = true;
			dsInfSecante1.Clear();
            
            cryRepSecante1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            cryRepSecante1.SetDataSource(dsInfSecante1);				

			sqlDAInfSecante.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAInfSecante.SelectCommand.Parameters["@FolioIni"].Value = (chbTodos.Checked ? " " : txtFolioIni.Text);
			sqlDAInfSecante.SelectCommand.Parameters["@FolioFin"].Value = (chbTodos.Checked ? "zzzzzzzz" : txtFolioIni.Text);
			sqlDAInfSecante.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
			sqlDAInfSecante.Fill(dsInfSecante1, "SecanteRep");
			sqlDAFirmas.Fill(dsFirmas1, "Firmas");
			sqlDANorma.Fill(dsInfSecante1, "Normas");
			cryRepSecante1.SetParameterValue("@F1", dsFirmas1.Tables[0].Rows[0][1].ToString());
			cryRepSecante1.SetParameterValue("@F2", dsFirmas1.Tables[0].Rows[1][1].ToString());
			cryRepSecante1.SetParameterValue("@F3", dsFirmas1.Tables[0].Rows[2][1].ToString());
			cryRepSecante1.SetParameterValue("@F4", dsFirmas1.Tables[0].Rows[3][1].ToString());
            cryRepSecante1.SetParameterValue("@F5", dsFirmas1.Tables[0].Rows[4][1].ToString());
            cryRepSecante1.SetParameterValue("@C1", dsFirmas1.Tables[0].Rows[0][2].ToString());
			cryRepSecante1.SetParameterValue("@C2", dsFirmas1.Tables[0].Rows[1][2].ToString());
			cryRepSecante1.SetParameterValue("@C3", dsFirmas1.Tables[0].Rows[2][2].ToString());
			cryRepSecante1.SetParameterValue("@C4", dsFirmas1.Tables[0].Rows[3][2].ToString());
            cryRepSecante1.SetParameterValue("@C5", dsFirmas1.Tables[0].Rows[4][2].ToString());
            cryRepSecante1.SetParameterValue("@Unidad", dsUnidad1.Tables[0].Rows[cmbUnidad.SelectedIndex][1].ToString());
			string conversion  = (cmbUnidad.SelectedValue.ToString() == "2" ? "** Para convertir a kg/cm² multiplique por 10,19716" : "** Para convertir en Mega Pascales multiplique por 0,0980665" );
			cryRepSecante1.SetParameterValue("@Conversion", conversion);
			cryRepSecante1.SetParameterValue("@Renglon", renglon);
			cryRepSecante1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
			cryRepSecante1.SetParameterValue("@Ruta", chbFormato.Checked);
			cryRepSecante1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
			cryRepSecante1.SetParameterValue("@Lab", chbLab.Checked);
            cryRepSecante1.SetParameterValue("@Ineco", chbLab1.Checked);
            cryRepSecante1.SetParameterValue("@Respaldo", chbRespaldo.Checked);

			crvInfSecante.ReportSource = cryRepSecante1;
//			crvInfSecante.RefreshReport();
		}

		private void chbFormato_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btnVistaPrevia_Load(object sender, System.EventArgs e)
		{
		
		}

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDesc.Text = dsUnidad1.Unidad.Rows[cmbUnidad.SelectedIndex][1].ToString();
        }

	}
}
