using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de InfCompacta.
	/// </summary>
	public class InfCompacta : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsCompactaRep dsCompactaRep1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAFirmas;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private LancNeo.dsBusObra dsBusObra1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsFirmas dsFirmas1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Data.SqlClient.SqlDataAdapter sqlDACompactaMdor;
		private LancNeo.dsCompactaMdor dsCompactaMdor1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfCompacta;
		private LancNeo.CryRepCompacta cryRepCompacta1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		public System.Data.SqlClient.SqlDataAdapter sqlDAInfCompacta;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Windows.Forms.NumericUpDown nudRenglon;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.CheckBox chbDuplicado;
		private System.Windows.Forms.CheckBox chbLeyenda;
		private System.Data.SqlClient.SqlDataAdapter sqlDANorma;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Windows.Forms.CheckBox chbFormato;
		private System.Windows.Forms.CheckBox chbLab;
        private CheckBox chbLab1;
        private CheckBox chbOrienta;
        public System.Data.SqlClient.SqlDataAdapter sqlDAcMdorH;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private CryRepCompactah cryRepCompactah1;
        private CheckBox chbTodos;
        private CheckBox chbRespaldo;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public InfCompacta()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfCompacta));
            this.sqlDAInfCompacta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsCompactaRep1 = new LancNeo.dsCompactaRep();
            this.sqlDAFirmas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsFirmas1 = new LancNeo.dsFirmas();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsCompactaMdor1 = new LancNeo.dsCompactaMdor();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.chbOrienta = new System.Windows.Forms.CheckBox();
            this.chbLab1 = new System.Windows.Forms.CheckBox();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbFormato = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.chbDuplicado = new System.Windows.Forms.CheckBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudRenglon = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.sqlDACompactaMdor = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.crvInfCompacta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryRepCompacta1 = new LancNeo.CryRepCompacta();
            this.sqlDANorma = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAcMdorH = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.cryRepCompactah1 = new LancNeo.CryRepCompactah();
            this.chbRespaldo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompactaRep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompactaMdor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenglon)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDAInfCompacta
            // 
            this.sqlDAInfCompacta.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAInfCompacta.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CompactaRep", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("Observac", "Observac"),
                        new System.Data.Common.DataColumnMapping("Cala", "Cala"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Localizacion", "Localizacion"),
                        new System.Data.Common.DataColumnMapping("Capa", "Capa"),
                        new System.Data.Common.DataColumnMapping("ProfunCapa", "ProfunCapa"),
                        new System.Data.Common.DataColumnMapping("AguaOptima", "AguaOptima"),
                        new System.Data.Common.DataColumnMapping("AhuaLugar", "AhuaLugar"),
                        new System.Data.Common.DataColumnMapping("MasaSecaMax", "MasaSecaMax"),
                        new System.Data.Common.DataColumnMapping("MasaSecaLugar", "MasaSecaLugar"),
                        new System.Data.Common.DataColumnMapping("Obtenido", "Obtenido"),
                        new System.Data.Common.DataColumnMapping("Promedio", "Promedio"),
                        new System.Data.Common.DataColumnMapping("Requerido", "Requerido"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("Observa1", "Observa1"),
                        new System.Data.Common.DataColumnMapping("Nota", "Nota"),
                        new System.Data.Common.DataColumnMapping("Nota1", "Nota1"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[CompactaRep]";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Folio1", System.Data.SqlDbType.Char, 10)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsCompactaRep1
            // 
            this.dsCompactaRep1.DataSetName = "dsCompactaRep";
            this.dsCompactaRep1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsCompactaRep1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlSelectCommand7.CommandText = "SELECT     IdFirma, Nombre, Cargo, Imprime, Compactacion\r\nFROM         Firmas\r\nWH" +
    "ERE     (Imprime = 1) AND (Compactacion < 6)\r\nORDER BY Compactacion";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dsFirmas1
            // 
            this.dsFirmas1.DataSetName = "dsFirmas";
            this.dsFirmas1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsFirmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.chbRespaldo);
            this.panel1.Controls.Add(this.chbTodos);
            this.panel1.Controls.Add(this.chbOrienta);
            this.panel1.Controls.Add(this.chbLab1);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbFormato);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.chbDuplicado);
            this.panel1.Controls.Add(this.txtFolio);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudRenglon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 76);
            this.panel1.TabIndex = 11;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(931, 4);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 65);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsCompactaMdor1.CompactaMdor;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(366, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsCompactaMdor1
            // 
            this.dsCompactaMdor1.DataSetName = "dsCompactaMdor";
            this.dsCompactaMdor1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsCompactaMdor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chbTodos
            // 
            this.chbTodos.ForeColor = System.Drawing.Color.White;
            this.chbTodos.Location = new System.Drawing.Point(805, 47);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(116, 24);
            this.chbTodos.TabIndex = 43;
            this.chbTodos.Text = "Todos los folios";
            // 
            // chbOrienta
            // 
            this.chbOrienta.ForeColor = System.Drawing.Color.White;
            this.chbOrienta.Location = new System.Drawing.Point(805, 0);
            this.chbOrienta.Name = "chbOrienta";
            this.chbOrienta.Size = new System.Drawing.Size(116, 24);
            this.chbOrienta.TabIndex = 42;
            this.chbOrienta.Text = "Formato vertical";
            this.chbOrienta.Visible = false;
            // 
            // chbLab1
            // 
            this.chbLab1.Checked = true;
            this.chbLab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab1.ForeColor = System.Drawing.Color.White;
            this.chbLab1.Location = new System.Drawing.Point(441, 47);
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
            this.chbLab.Location = new System.Drawing.Point(616, 45);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(115, 24);
            this.chbLab.TabIndex = 37;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // chbFormato
            // 
            this.chbFormato.ForeColor = System.Drawing.Color.White;
            this.chbFormato.Location = new System.Drawing.Point(616, 23);
            this.chbFormato.Name = "chbFormato";
            this.chbFormato.Size = new System.Drawing.Size(183, 23);
            this.chbFormato.TabIndex = 35;
            this.chbFormato.Text = "Incluye imagen de acreditación";
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.Checked = true;
            this.chbLeyenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLeyenda.ForeColor = System.Drawing.Color.White;
            this.chbLeyenda.Location = new System.Drawing.Point(441, 23);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(116, 24);
            this.chbLeyenda.TabIndex = 34;
            this.chbLeyenda.Text = "Formato leyenda";
            // 
            // chbDuplicado
            // 
            this.chbDuplicado.ForeColor = System.Drawing.Color.White;
            this.chbDuplicado.Location = new System.Drawing.Point(248, 30);
            this.chbDuplicado.Name = "chbDuplicado";
            this.chbDuplicado.Size = new System.Drawing.Size(89, 24);
            this.chbDuplicado.TabIndex = 32;
            this.chbDuplicado.Text = "¿Duplicado?";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(478, 4);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(56, 20);
            this.txtFolio.TabIndex = 31;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(438, 8);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(32, 13);
            this.Fecha.TabIndex = 30;
            this.Fecha.Text = "Folio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(560, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Especio entre renglones:";
            // 
            // nudRenglon
            // 
            this.nudRenglon.Location = new System.Drawing.Point(694, 0);
            this.nudRenglon.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudRenglon.Name = "nudRenglon";
            this.nudRenglon.Size = new System.Drawing.Size(48, 20);
            this.nudRenglon.TabIndex = 12;
            this.nudRenglon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(246, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(278, 4);
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
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe de verificación de la compactación";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(366, 32);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // sqlDACompactaMdor
            // 
            this.sqlDACompactaMdor.SelectCommand = this.sqlSelectCommand2;
            this.sqlDACompactaMdor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CompactaMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FInforme", "FInforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT FOLIO, IdObra, ConsObra, FInforme, NoEco, Semana, Observaciones FROM Compa" +
    "ctaMdor WHERE (IdObra = @IdObra) ORDER BY FOLIO";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // crvInfCompacta
            // 
            this.crvInfCompacta.ActiveViewIndex = -1;
            this.crvInfCompacta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfCompacta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfCompacta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfCompacta.Location = new System.Drawing.Point(0, 76);
            this.crvInfCompacta.Name = "crvInfCompacta";
            this.crvInfCompacta.ReuseParameterValuesOnRefresh = true;
            this.crvInfCompacta.ShowCloseButton = false;
            this.crvInfCompacta.ShowGroupTreeButton = false;
            this.crvInfCompacta.ShowLogo = false;
            this.crvInfCompacta.Size = new System.Drawing.Size(1028, 529);
            this.crvInfCompacta.TabIndex = 12;
            this.crvInfCompacta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvInfCompacta.Visible = false;
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
            this.sqlSelectCommand3.CommandText = "SELECT IdNorma, Informe, Normas, Titulo, IdInforme FROM Normas WHERE (IdNorma = 1" +
    "4) ORDER BY IdNorma";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlDAcMdorH
            // 
            this.sqlDAcMdorH.SelectCommand = this.sqlCommand2;
            this.sqlDAcMdorH.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CompactaRep", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("Observac", "Observac"),
                        new System.Data.Common.DataColumnMapping("Cala", "Cala"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Localizacion", "Localizacion"),
                        new System.Data.Common.DataColumnMapping("Capa", "Capa"),
                        new System.Data.Common.DataColumnMapping("ProfunCapa", "ProfunCapa"),
                        new System.Data.Common.DataColumnMapping("AguaOptima", "AguaOptima"),
                        new System.Data.Common.DataColumnMapping("AhuaLugar", "AhuaLugar"),
                        new System.Data.Common.DataColumnMapping("MasaSecaMax", "MasaSecaMax"),
                        new System.Data.Common.DataColumnMapping("MasaSecaLugar", "MasaSecaLugar"),
                        new System.Data.Common.DataColumnMapping("Obtenido", "Obtenido"),
                        new System.Data.Common.DataColumnMapping("Promedio", "Promedio"),
                        new System.Data.Common.DataColumnMapping("Requerido", "Requerido"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("Observa1", "Observa1"),
                        new System.Data.Common.DataColumnMapping("Nota", "Nota"),
                        new System.Data.Common.DataColumnMapping("Nota1", "Nota1"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "[CompactaRep1]";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Folio1", System.Data.SqlDbType.Char, 10)});
            // 
            // chbRespaldo
            // 
            this.chbRespaldo.ForeColor = System.Drawing.Color.White;
            this.chbRespaldo.Location = new System.Drawing.Point(805, 23);
            this.chbRespaldo.Name = "chbRespaldo";
            this.chbRespaldo.Size = new System.Drawing.Size(116, 24);
            this.chbRespaldo.TabIndex = 44;
            this.chbRespaldo.Text = "Respaldo";
            // 
            // InfCompacta
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1028, 605);
            this.Controls.Add(this.crvInfCompacta);
            this.Controls.Add(this.panel1);
            this.Name = "InfCompacta";
            this.Text = "InfCompacta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfCompacta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCompactaRep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompactaMdor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenglon)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void InfCompacta_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsBusObra1, "Obra");
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsCompactaMdor1.Clear();
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
			LlenasSqlDA();
		}
		private void LlenasSqlDA()
		{
			sqlDACompactaMdor.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDACompactaMdor.Fill(dsCompactaMdor1, "CompactaMdor");
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			string renglon = "";
			char enter = '\n';
			for (int i = 1; i <= nudRenglon.Value ; i++)
				renglon += "\r\n";
			
			crvInfCompacta.Visible = true;
			dsCompactaRep1.Clear();

            if (chbOrienta.Checked)
            {
                cryRepCompacta1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cryRepCompacta1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
                cryRepCompacta1.SetDataSource(dsCompactaRep1);
                sqlDAInfCompacta.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
                sqlDAInfCompacta.SelectCommand.Parameters["@Folio1"].Value = (chbTodos.Checked ? "-1" : txtFolio.Text);
                sqlDAInfCompacta.Fill(dsCompactaRep1, "CompactaRep");
            }
            else
            {
                cryRepCompactah1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cryRepCompactah1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
                cryRepCompactah1.SetDataSource(dsCompactaRep1);
                sqlDAcMdorH.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
                sqlDAcMdorH.SelectCommand.Parameters["@Folio1"].Value = (chbTodos.Checked ? "-1" : txtFolio.Text);
                sqlDAcMdorH.Fill(dsCompactaRep1, "CompactaRep");
            }
			sqlDAFirmas.Fill(dsFirmas1, "Firmas");
			sqlDANorma.Fill(dsCompactaRep1, "Normas");
            try
            {
                if (chbOrienta.Checked)
                {
                    cryRepCompacta1.SetParameterValue("@F1", dsFirmas1.Tables[0].Rows[0][1].ToString());
                    cryRepCompacta1.SetParameterValue("@F2", dsFirmas1.Tables[0].Rows[1][1].ToString());
                    cryRepCompacta1.SetParameterValue("@F3", dsFirmas1.Tables[0].Rows[2][1].ToString());
                    cryRepCompacta1.SetParameterValue("@F4", dsFirmas1.Tables[0].Rows[3][1].ToString());
                    cryRepCompacta1.SetParameterValue("@F5", dsFirmas1.Tables[0].Rows[4][1].ToString());
                    cryRepCompacta1.SetParameterValue("@C1", dsFirmas1.Tables[0].Rows[0][2].ToString());
                    cryRepCompacta1.SetParameterValue("@C2", dsFirmas1.Tables[0].Rows[1][2].ToString());
                    cryRepCompacta1.SetParameterValue("@C3", dsFirmas1.Tables[0].Rows[2][2].ToString());
                    cryRepCompacta1.SetParameterValue("@C4", dsFirmas1.Tables[0].Rows[3][2].ToString());
                    cryRepCompacta1.SetParameterValue("@C5", dsFirmas1.Tables[0].Rows[4][2].ToString());
                    cryRepCompacta1.SetParameterValue("@Renglon", renglon);
                    cryRepCompacta1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
                    cryRepCompacta1.SetParameterValue("@Ruta", chbFormato.Checked);
                    cryRepCompacta1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                    cryRepCompacta1.SetParameterValue("@Lab", chbLab.Checked);
                    cryRepCompacta1.SetParameterValue("@Ineco", chbLab1.Checked);
                    crvInfCompacta.ReportSource = cryRepCompacta1;
                }
                else
                {
                    cryRepCompactah1.SetParameterValue("@F1", dsFirmas1.Tables[0].Rows[0][1].ToString());
                    cryRepCompactah1.SetParameterValue("@F2", dsFirmas1.Tables[0].Rows[1][1].ToString());
                    cryRepCompactah1.SetParameterValue("@F3", dsFirmas1.Tables[0].Rows[2][1].ToString());
                    cryRepCompactah1.SetParameterValue("@F4", dsFirmas1.Tables[0].Rows[3][1].ToString());
                    cryRepCompactah1.SetParameterValue("@F5", dsFirmas1.Tables[0].Rows[4][1].ToString());
                    cryRepCompactah1.SetParameterValue("@C1", dsFirmas1.Tables[0].Rows[0][2].ToString());
                    cryRepCompactah1.SetParameterValue("@C2", dsFirmas1.Tables[0].Rows[1][2].ToString());
                    cryRepCompactah1.SetParameterValue("@C3", dsFirmas1.Tables[0].Rows[2][2].ToString());
                    cryRepCompactah1.SetParameterValue("@C4", dsFirmas1.Tables[0].Rows[3][2].ToString());
                    cryRepCompactah1.SetParameterValue("@C5", dsFirmas1.Tables[0].Rows[4][2].ToString());
                    cryRepCompactah1.SetParameterValue("@Renglon", renglon);
                    cryRepCompactah1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
                    cryRepCompactah1.SetParameterValue("@Ruta", chbFormato.Checked);
                    cryRepCompactah1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                    cryRepCompactah1.SetParameterValue("@Lab", chbLab.Checked);
                    cryRepCompactah1.SetParameterValue("@Ineco", chbLab1.Checked);
                    cryRepCompactah1.SetParameterValue("@Respaldo", chbRespaldo.Checked);
                    crvInfCompacta.ReportSource = cryRepCompactah1;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

			// crvInfCompacta.RefreshReport();
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			if(dsCompactaMdor1.Tables["CompactaMdor"].Rows.Count > 0)
			{
				txtFolio.Text = dsCompactaMdor1.Tables["CompactaMdor"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
				btnVistaPrevia.Visible = true;
			}
			else
			{
				btnVistaPrevia.Visible = false;
			}

		}

		private void chbLab_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		
	}
}
