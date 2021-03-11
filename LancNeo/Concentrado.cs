using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Concentrado.
	/// </summary>
	public class Concentrado : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcentrado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsConcentrado dsConcentrado1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpIni;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcentra;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsConcentra dsConcentra1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvConcentrado;
		private LancNeo.CryRepConcentrado cryRepConcentrado1;
		private LancNeo.dsDGObra dsDGObra1;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private LancNeo.dsConcentrados dsConcentrados1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcetradoTotal;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private CheckBox cbkMortero;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Concentrado()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concentrado));
            this.sqlDAConcentrado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsConcentrado1 = new LancNeo.dsConcentrado();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsConcentra1 = new LancNeo.dsConcentra();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsDGObra1 = new LancNeo.dsDGObra();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.sqlDAConcentra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.crvConcentrado = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryRepConcentrado1 = new LancNeo.CryRepConcentrado();
            this.dsConcentrados1 = new LancNeo.dsConcentrados();
            this.sqlDAConcetradoTotal = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.cbkMortero = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcentrado1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcentra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcentrados1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDAConcentrado
            // 
            this.sqlDAConcentrado.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAConcentrado.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Repdetcon", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("Volumen", "Volumen"),
                        new System.Data.Common.DataColumnMapping("Textra", "Textra"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Htrabajadas", "Htrabajadas"),
                        new System.Data.Common.DataColumnMapping("MorteroI", "MorteroI"),
                        new System.Data.Common.DataColumnMapping("MorteroC", "MorteroC"),
                        new System.Data.Common.DataColumnMapping("MorteroQ", "MorteroQ"),
                        new System.Data.Common.DataColumnMapping("AceroAI", "AceroAI"),
                        new System.Data.Common.DataColumnMapping("AceroAC", "AceroAC"),
                        new System.Data.Common.DataColumnMapping("AceroAQ", "AceroAQ"),
                        new System.Data.Common.DataColumnMapping("AceroBI", "AceroBI"),
                        new System.Data.Common.DataColumnMapping("AceroBC", "AceroBC"),
                        new System.Data.Common.DataColumnMapping("AceroBQ", "AceroBQ"),
                        new System.Data.Common.DataColumnMapping("AceroCI", "AceroCI"),
                        new System.Data.Common.DataColumnMapping("AceroCC", "AceroCC"),
                        new System.Data.Common.DataColumnMapping("AceroCQ", "AceroCQ"),
                        new System.Data.Common.DataColumnMapping("VigasI", "VigasI"),
                        new System.Data.Common.DataColumnMapping("VigasC", "VigasC"),
                        new System.Data.Common.DataColumnMapping("VigasQ", "VigasQ"),
                        new System.Data.Common.DataColumnMapping("TensionI", "TensionI"),
                        new System.Data.Common.DataColumnMapping("TensionC", "TensionC"),
                        new System.Data.Common.DataColumnMapping("TensionQ", "TensionQ"),
                        new System.Data.Common.DataColumnMapping("SoldaI", "SoldaI"),
                        new System.Data.Common.DataColumnMapping("SoldaC", "SoldaC"),
                        new System.Data.Common.DataColumnMapping("SoldaQ", "SoldaQ"),
                        new System.Data.Common.DataColumnMapping("CompactI", "CompactI"),
                        new System.Data.Common.DataColumnMapping("CompactC", "CompactC"),
                        new System.Data.Common.DataColumnMapping("CompactQ", "CompactQ"),
                        new System.Data.Common.DataColumnMapping("PrefabrI", "PrefabrI"),
                        new System.Data.Common.DataColumnMapping("PrefabrC", "PrefabrC"),
                        new System.Data.Common.DataColumnMapping("PrefabrQ", "PrefabrQ"),
                        new System.Data.Common.DataColumnMapping("VisualI", "VisualI"),
                        new System.Data.Common.DataColumnMapping("VisualC", "VisualC"),
                        new System.Data.Common.DataColumnMapping("VisualQ", "VisualQ"),
                        new System.Data.Common.DataColumnMapping("CalifiI", "CalifiI"),
                        new System.Data.Common.DataColumnMapping("CalifiC", "CalifiC"),
                        new System.Data.Common.DataColumnMapping("CalifiQ", "CalifiQ"),
                        new System.Data.Common.DataColumnMapping("LQPenI", "LQPenI"),
                        new System.Data.Common.DataColumnMapping("LQPenC", "LQPenC"),
                        new System.Data.Common.DataColumnMapping("LQPenQ", "LQPenQ"),
                        new System.Data.Common.DataColumnMapping("PorterI", "PorterI"),
                        new System.Data.Common.DataColumnMapping("PorterC", "PorterC"),
                        new System.Data.Common.DataColumnMapping("PorterQ", "PorterQ"),
                        new System.Data.Common.DataColumnMapping("ProctorI", "ProctorI"),
                        new System.Data.Common.DataColumnMapping("ProctorC", "ProctorC"),
                        new System.Data.Common.DataColumnMapping("ProctorQ", "ProctorQ"),
                        new System.Data.Common.DataColumnMapping("AsshtoI", "AsshtoI"),
                        new System.Data.Common.DataColumnMapping("AsshtoC", "AsshtoC"),
                        new System.Data.Common.DataColumnMapping("AsshtoQ", "AsshtoQ"),
                        new System.Data.Common.DataColumnMapping("RadiogI", "RadiogI"),
                        new System.Data.Common.DataColumnMapping("RadiogC", "RadiogC"),
                        new System.Data.Common.DataColumnMapping("RadiogQ", "RadiogQ")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[Repdetcon]";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.Bit, 1)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsConcentrado1
            // 
            this.dsConcentrado1.DataSetName = "dsConcentrado";
            this.dsConcentrado1.EnforceConstraints = false;
            this.dsConcentrado1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcentrado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.cbkMortero);
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
            this.panel1.Size = new System.Drawing.Size(856, 76);
            this.panel1.TabIndex = 11;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 650;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConcentra1.Concentra;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(371, 4);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
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
            this.btnVistaPrevia.Location = new System.Drawing.Point(760, 0);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(441, 40);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 36;
            this.cbkPrefijo.Text = "No prefijo";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(664, 42);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(664, 10);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsDGObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(282, 8);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // dsDGObra1
            // 
            this.dsDGObra1.DataSetName = "dsDGObra";
            this.dsDGObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDGObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Concentrado de labores ejecutadas por laboratoristas";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(538, 29);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(384, 32);
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
            // crvConcentrado
            // 
            this.crvConcentrado.ActiveViewIndex = -1;
            this.crvConcentrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvConcentrado.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvConcentrado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvConcentrado.EnableRefresh = false;
            this.crvConcentrado.Location = new System.Drawing.Point(0, 76);
            this.crvConcentrado.Name = "crvConcentrado";
            this.crvConcentrado.ShowCloseButton = false;
            this.crvConcentrado.ShowGroupTreeButton = false;
            this.crvConcentrado.ShowLogo = false;
            this.crvConcentrado.Size = new System.Drawing.Size(856, 329);
            this.crvConcentrado.TabIndex = 12;
            this.crvConcentrado.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsConcentrados1
            // 
            this.dsConcentrados1.DataSetName = "dsConcentrados";
            this.dsConcentrados1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcentrados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAConcetradoTotal
            // 
            this.sqlDAConcetradoTotal.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAConcetradoTotal.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Repdetcon1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Principal", "Principal"),
                        new System.Data.Common.DataColumnMapping("Adicional", "Adicional")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "[Repdetcon1]";
            this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.Bit, 1)});
            // 
            // cbkMortero
            // 
            this.cbkMortero.Checked = true;
            this.cbkMortero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkMortero.Location = new System.Drawing.Point(441, 8);
            this.cbkMortero.Name = "cbkMortero";
            this.cbkMortero.Size = new System.Drawing.Size(102, 24);
            this.cbkMortero.TabIndex = 52;
            this.cbkMortero.Text = "Incluye mortero";
            // 
            // Concentrado
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(856, 405);
            this.Controls.Add(this.crvConcentrado);
            this.Controls.Add(this.panel1);
            this.Name = "Concentrado";
            this.Text = "Concentrado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Concentrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsConcentrado1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcentra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcentrados1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Concentrado_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsDGObra1, "Obra");
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

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			if(dsConcentra1.Tables["Concentra"].Rows.Count > 0)
			{
				dtpIni.Text = dsConcentra1.Tables["Concentra"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
				btnVistaPrevia.Visible = true;
			}
			else
			{
				btnVistaPrevia.Visible = false;
			}
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			crvConcentrado.Visible = true;
            cryRepConcentrado1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            cryRepConcentrado1.SetDataSource(dsConcentrado1);				
			dsConcentrado1.Clear();
			sqlDAConcentrado.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim() + (cbkPrefijo.Checked  ? "" : "%");
			sqlDAConcentrado.SelectCommand.Parameters["@FIni"].Value = dtpIni.Text;
			sqlDAConcentrado.SelectCommand.Parameters["@FFin"].Value = dtpFin.Text;
            sqlDAConcentrado.SelectCommand.Parameters["@Mortero"].Value = cbkMortero.Checked;
            sqlDAConcentrado.Fill(dsConcentrado1, "RepDetCon");

			sqlDAConcetradoTotal.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim() + (cbkPrefijo.Checked  ? "" : "%");
			sqlDAConcetradoTotal.SelectCommand.Parameters["@FIni"].Value = dtpIni.Text;
			sqlDAConcetradoTotal.SelectCommand.Parameters["@FFin"].Value = dtpFin.Text;
            sqlDAConcetradoTotal.SelectCommand.Parameters["@Mortero"].Value = cbkMortero.Checked;
            sqlDAConcetradoTotal.Fill(dsConcentrado1, "RepDetCon1");

			cryRepConcentrado1.SetParameterValue("@Cons", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][3].ToString());
			cryRepConcentrado1.SetParameterValue("@Ubica", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][1].ToString());
			cryRepConcentrado1.SetParameterValue("@Col", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][4].ToString());
			cryRepConcentrado1.SetParameterValue("@Zona", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][5].ToString());

			
			crvConcentrado.ReportSource = cryRepConcentrado1;
		//	crvConcentrado.RefreshReport();
		}
	}
}
