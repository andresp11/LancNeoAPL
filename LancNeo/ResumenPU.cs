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
	/// Descripción breve de ResumenPU.
	/// </summary>
	public class ResumenPU : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAResumen;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsDGObra dsDGObra1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdobra;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvResumen;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcepto;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.CheckBox cbkTotal;
		private LancNeo.dsResumenPU dsResumenPU1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAFechas;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.CryRepResumenPu cryRepResumenPu1;
		public System.Data.SqlClient.SqlDataAdapter sqlDAPresupuestoz;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbkFMax;
		private System.Windows.Forms.CheckBox cbkFMin;
		private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Label label3;
        private CheckBox cbkMortero;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ResumenPU()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResumenPU));
            this.sqlDAResumen = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsDGObra1 = new LancNeo.dsDGObra();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.cbkMortero = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbkFMin = new System.Windows.Forms.CheckBox();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.cbkFMax = new System.Windows.Forms.CheckBox();
            this.cbkTotal = new System.Windows.Forms.CheckBox();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.crvResumen = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAConcepto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsResumenPU1 = new LancNeo.dsResumenPU();
            this.sqlDAFechas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.cryRepResumenPu1 = new LancNeo.CryRepResumenPu();
            this.sqlDAPresupuestoz = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsResumenPU1)).BeginInit();
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
            this.sqlDAResumen.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(this.sqlDAResumen_RowUpdated);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[ResumenPrecios]";
            this.sqlSelectCommand1.CommandTimeout = 120;
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FfMax", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@FfMin", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.Bit, 1)});
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.cbkMortero);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbkFMin);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.cbkFMax);
            this.panel1.Controls.Add(this.cbkTotal);
            this.panel1.Controls.Add(this.cbkPrefijo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 70);
            this.panel1.TabIndex = 12;
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
            // cbkMortero
            // 
            this.cbkMortero.Checked = true;
            this.cbkMortero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkMortero.ForeColor = System.Drawing.Color.White;
            this.cbkMortero.Location = new System.Drawing.Point(342, 9);
            this.cbkMortero.Name = "cbkMortero";
            this.cbkMortero.Size = new System.Drawing.Size(102, 24);
            this.cbkMortero.TabIndex = 51;
            this.cbkMortero.Text = "Incluye mortero";
            this.cbkMortero.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Inicial:";
            this.label3.Visible = false;
            // 
            // cbkFMin
            // 
            this.cbkFMin.ForeColor = System.Drawing.Color.White;
            this.cbkFMin.Location = new System.Drawing.Point(458, 9);
            this.cbkFMin.Name = "cbkFMin";
            this.cbkFMin.Size = new System.Drawing.Size(148, 24);
            this.cbkFMin.TabIndex = 49;
            this.cbkFMin.Text = "Requiere fecha mínima";
            this.cbkFMin.CheckedChanged += new System.EventHandler(this.cbkFMin_CheckedChanged);
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(614, 10);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(80, 20);
            this.dtpIni.TabIndex = 48;
            this.dtpIni.Visible = false;
            // 
            // cbkFMax
            // 
            this.cbkFMax.ForeColor = System.Drawing.Color.White;
            this.cbkFMax.Location = new System.Drawing.Point(458, 38);
            this.cbkFMax.Name = "cbkFMax";
            this.cbkFMax.Size = new System.Drawing.Size(148, 24);
            this.cbkFMax.TabIndex = 47;
            this.cbkFMax.Text = "Requiere fecha máxima";
            this.cbkFMax.CheckedChanged += new System.EventHandler(this.cbkFMax_CheckedChanged);
            // 
            // cbkTotal
            // 
            this.cbkTotal.Checked = true;
            this.cbkTotal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkTotal.ForeColor = System.Drawing.Color.White;
            this.cbkTotal.Location = new System.Drawing.Point(187, 38);
            this.cbkTotal.Name = "cbkTotal";
            this.cbkTotal.Size = new System.Drawing.Size(148, 24);
            this.cbkTotal.TabIndex = 46;
            this.cbkTotal.Text = "Incluye total de muestas";
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.ForeColor = System.Drawing.Color.White;
            this.cbkPrefijo.Location = new System.Drawing.Point(342, 38);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 36;
            this.cbkPrefijo.Text = "No prefijo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsDGObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(214, 10);
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
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resumen de trabajos de laboratorio PU";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(784, 22);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(614, 38);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(80, 20);
            this.dtpFin.TabIndex = 21;
            this.dtpFin.Visible = false;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Final:";
            this.label4.Visible = false;
            // 
            // crvResumen
            // 
            this.crvResumen.ActiveViewIndex = -1;
            this.crvResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvResumen.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvResumen.EnableRefresh = false;
            this.crvResumen.Location = new System.Drawing.Point(0, 70);
            this.crvResumen.Name = "crvResumen";
            this.crvResumen.ShowCloseButton = false;
            this.crvResumen.ShowGroupTreeButton = false;
            this.crvResumen.ShowLogo = false;
            this.crvResumen.Size = new System.Drawing.Size(848, 311);
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
            this.sqlSelectCommand3.CommandText = "SELECT     IdConcepto, Concepto\r\nFROM         Concepto\r\nWHERE     (IdConcepto > 0" +
    ")\r\nORDER BY IdConcepto";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // dsResumenPU1
            // 
            this.dsResumenPU1.DataSetName = "dsResumenPU";
            this.dsResumenPU1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsResumenPU1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAFechas
            // 
            this.sqlDAFechas.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAFechas.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Fechas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Fi1", "Fi1"),
                        new System.Data.Common.DataColumnMapping("Ff1", "Ff1"),
                        new System.Data.Common.DataColumnMapping("Fi2", "Fi2"),
                        new System.Data.Common.DataColumnMapping("Ff2", "Ff2"),
                        new System.Data.Common.DataColumnMapping("Fi3", "Fi3"),
                        new System.Data.Common.DataColumnMapping("Ff3", "Ff3"),
                        new System.Data.Common.DataColumnMapping("Fi4", "Fi4"),
                        new System.Data.Common.DataColumnMapping("Ff4", "Ff4")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "[Fechas]";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FfMax", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@FfMin", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.Bit, 1)});
            // 
            // sqlDAPresupuestoz
            // 
            this.sqlDAPresupuestoz.SelectCommand = this.sqlSelectCommand4;
            this.sqlDAPresupuestoz.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("PresupuestoZ", "PresupuestoZ"),
                        new System.Data.Common.DataColumnMapping("Duracion", "Duracion")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // ResumenPU
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(848, 381);
            this.Controls.Add(this.crvResumen);
            this.Controls.Add(this.panel1);
            this.Name = "ResumenPU";
            this.Text = "Resumen de trabajos de laboratorio por precios unitarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ResumenPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsResumenPU1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            decimal D14 = 0, D16 = 0, D17 = 0; 
            cryRepResumenPu1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            cryRepResumenPu1.SetDataSource(dsResumenPU1);
            decimal [] tot  = new decimal[8];
			decimal [] tot1 = new decimal[8];
            for (int i = 0; i < 8; i++)
				tot[i] = tot1[i] = 0;
            decimal[,] Dtot1 = new decimal[6,12];
            decimal[,] totd = new decimal[6,12];
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 12; j++)
                    Dtot1[i,j] = totd[i,j] = 0;
            dsResumenPU1.Clear();
			try 
			{
				sqlDAConcepto.Fill(dsResumenPU1, "Concepto");
			}
			catch(Exception ex)
			{
				ex.ToString();
			}			
            crvResumen.Visible = true;
            dsResumenPU1.Clear();
            sqlDAConcepto.Fill(dsResumenPU1, "Concepto");
            sqlDAConcepto.Fill(dsResumenPU1, "Concepto1");
            sqlDAConcepto.Fill(dsResumenPU1, "Concepto2");
            sqlDAConcepto.Fill(dsResumenPU1, "Concepto3");
            sqlDAConcepto.Fill(dsResumenPU1, "Concepto4");

            sqlDAFechas.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim() + (cbkPrefijo.Checked  ? "" : "%");
			sqlDAFechas.SelectCommand.Parameters["@FfMax"].Value = (cbkFMax.Checked  ? dtpFin.Text : null);
			sqlDAFechas.SelectCommand.Parameters["@FfMin"].Value = (cbkFMin.Checked  ? dtpIni.Text : null);
            sqlDAFechas.SelectCommand.Parameters["@Mortero"].Value = cbkMortero.Checked;
            sqlDAFechas.Fill(dsResumenPU1, "Fechas");
			sqlDAResumen.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim() + (cbkPrefijo.Checked  ? "" : "%");
			sqlDAResumen.SelectCommand.Parameters["@FfMax"].Value = (cbkFMax.Checked  ? dtpFin.Text : null);
			sqlDAResumen.SelectCommand.Parameters["@FfMin"].Value = (cbkFMin.Checked  ? dtpIni.Text : null);
            sqlDAResumen.SelectCommand.Parameters["@Mortero"].Value = cbkMortero.Checked ;
            sqlDAResumen.Fill(dsResumenPU1, "ResumenPrecios");
			sqlDAPresupuestoz.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim();
			sqlDAPresupuestoz.Fill(dsResumenPU1, "Obra");
            DateTime Finicial = System.Convert.ToDateTime(dsResumenPU1.Fechas.Rows[0][8].ToString());
            DateTime Ffinal   = System.Convert.ToDateTime(dsResumenPU1.Fechas.Rows[0][1].ToString());
            TimeSpan dias = Ffinal.Subtract(Finicial);
            int diasL = dias.Days;
            foreach (DataRow dr in dsResumenPU1.Tables["ResumenPrecios"].Rows)
            {
                    if (dr["IdConcepto"].ToString() == "20")
                        for (int j=0; j < 12; j++)
                            Dtot1[0,j] = decimal.Parse(dr[j+2].ToString());
                    if (dr["IdConcepto"].ToString() == "19")
                        for (int j=0; j < 12; j++)
                            Dtot1[1,j] = decimal.Parse(dr[j+2].ToString());
                    if (dr["IdConcepto"].ToString() == "18")
                        for (int j=0; j < 12; j++)
                            Dtot1[2,j] = decimal.Parse(dr[j+2].ToString());
                    if (dr["IdConcepto"].ToString() == "25")
                        for (int j = 0; j < 12; j++)
                            totd[0,j] = decimal.Parse(dr[j + 2].ToString());
            }
            for(int i = 0; i <8; i += 2)
            {    
                int x = (i == 0 ? 8 : i );
                int y = (i == 6 ? 9 : i + 1);
                if (!string.IsNullOrEmpty(dsResumenPU1.Fechas.Rows[0][x].ToString()) && !string.IsNullOrEmpty(dsResumenPU1.Fechas.Rows[0][y].ToString()))
                {
                    Finicial = System.Convert.ToDateTime(dsResumenPU1.Fechas.Rows[0][x].ToString());
                    Ffinal   = System.Convert.ToDateTime(dsResumenPU1.Fechas.Rows[0][y].ToString());
                    dias = Ffinal.Subtract(Finicial);
                    x = dias.Days;
                    totd[1, i] = (x > 0 ? x / 7 : 0);
                }
            }
            if(Dtot1[1,0] > 0)
            {
                int diasP = System.Convert.ToInt32(Dtot1[2, 0]);
                int SemaP = System.Convert.ToInt32(Dtot1[1, 0]);
                
                if (Dtot1[2,5] > diasP)
                {
                    int diasR = System.Convert.ToInt32(Dtot1[2, 5]) - diasP;
                    for (int j=4; 0 < j; j--)
                    {
                        if (diasR >= System.Convert.ToInt32(Dtot1[2, j])) 
                        {
                            diasR = diasR - System.Convert.ToInt32(Dtot1[2, j]);
                            Dtot1[2,j] = 0;
                        }
                        else
                        {
                            Dtot1[2, j] = System.Convert.ToInt32(Dtot1[2, j]) - diasR;
                            diasR = 0;
                            j = 0;
                        }
                    }
                }
                //if (Dtot1[1,5] > SemaP)
                //{
                //    int SemaR = System.Convert.ToInt32(Dtot1[1, 5]) - SemaP;
                //    for (int j=4; 0 < j; j--)
                //    {
                //        if (SemaR >= System.Convert.ToInt32(Dtot1[1, j])) 
                //        {
                //            SemaR = SemaR - System.Convert.ToInt32(Dtot1[1, j]);
                //            Dtot1[1,j] = 0;
                //        }
                //        else
                //        {
                //            Dtot1[1, j] = System.Convert.ToInt32(Dtot1[1, j]) - SemaR;
                //            SemaR = 0;
                //            j = 0;
                //        }
                //    }
                //}
                //if (diasL > 30)
                //    Dtot1[0,1] = diasL/30;
                //    if ( string.IsNullOrEmpty(dsResumenPU1.Fechas.Rows[0][3].ToString()))
                //        Dtot1[0,2] = 0;
                //    else
                //        Dtot1[0,2] = 6;
                //    if ( string.IsNullOrEmpty(dsResumenPU1.Fechas.Rows[0][5].ToString()))
                //        Dtot1[0,3] = 0;
                //    else
                //        Dtot1[0,3] = 6;
                //    if ( string.IsNullOrEmpty(dsResumenPU1.Fechas.Rows[0][7].ToString()))
                //        Dtot1[0,4] = 0;
                //    else
                //        Dtot1[0,4] = 6;
                if (diasP < SemaP)
                for(int i = 0; i < 4 ; i++)
                    if (totd[0,i+1] != 0 && totd[1, (i *2)] != 0 )
                        Dtot1[1,i+1] = totd[1, (i * 2)];

                for (int i = 0; i < dsResumenPU1.Tables["ResumenPrecios"].Rows.Count; i++) 
                {
                    if (dsResumenPU1.ResumenPrecios[i]["IdConcepto"].ToString() == "20")
                    {
                        for (int j = 1; j < 5; j++)
                        {
                            dsResumenPU1.ResumenPrecios[i][j + 2] = Dtot1[0, j];
                            dsResumenPU1.ResumenPrecios[i][j + 7] = dsResumenPU1.ResumenPrecios[i][16];
                            dsResumenPU1.ResumenPrecios[i][j + 11] = Dtot1[0, j] * decimal.Parse(dsResumenPU1.ResumenPrecios.Rows[i][j + 7].ToString());
                        }
                        dsResumenPU1.ResumenPrecios[i][7] = Dtot1[0, 1] + Dtot1[0, 2] + Dtot1[0, 3] + Dtot1[0, 4];
                    }
                    if (dsResumenPU1.ResumenPrecios[i]["IdConcepto"].ToString() == "19")
                    {
                        for (int j = 1; j < 5; j++)
                        {
                            dsResumenPU1.ResumenPrecios[i][j + 2] = Dtot1[1, j];
                            dsResumenPU1.ResumenPrecios[i][j + 11] = Dtot1[1, j] * decimal.Parse(dsResumenPU1.ResumenPrecios.Rows[i][j + 7].ToString());
                        }
                        dsResumenPU1.ResumenPrecios[i][7] = Dtot1[1, 1] + Dtot1[1, 2] + Dtot1[1, 3] + Dtot1[1, 4];
                    }
                    if (dsResumenPU1.ResumenPrecios[i]["IdConcepto"].ToString() == "18")
                    {
                        for (int j = 1; j < 5; j++)
                        {
                            dsResumenPU1.ResumenPrecios[i][j + 2] = Dtot1[2, j];
                            dsResumenPU1.ResumenPrecios[i][j + 11] = Dtot1[2, j] * decimal.Parse(dsResumenPU1.ResumenPrecios.Rows[i][j + 7].ToString());
                        }
                        dsResumenPU1.ResumenPrecios[i][7] = Dtot1[2, 1] + Dtot1[2, 2] + Dtot1[2, 3] + Dtot1[2, 4];
                    }
                }


            }
            foreach (DataRow dr in dsResumenPU1.Tables["ResumenPrecios"].Rows)
			{
                if (int.Parse(dr["IdConcepto"].ToString()) <= 900)
                {
                    decimal Pres = (dr["Pres"].ToString() == "" ? 0 : decimal.Parse(dr["Pres"].ToString()));
                    tot[0] += Pres * decimal.Parse(dr["PreLis"].ToString());
                    tot[1] += decimal.Parse(dr["Impor1"].ToString());
                    tot[2] += decimal.Parse(dr["Impor2"].ToString());
                    tot[3] += decimal.Parse(dr["Impor3"].ToString());
                    tot[4] += decimal.Parse(dr["Impor4"].ToString());
                    if (dr["IdConcepto"].ToString() == "14")
                        D14 = decimal.Parse(dr["Impor1"].ToString()) + decimal.Parse(dr["Impor2"].ToString()) + decimal.Parse(dr["Impor3"].ToString()) + decimal.Parse(dr["Impor4"].ToString());
                    if (dr["IdConcepto"].ToString() == "16")
                        D16 = decimal.Parse(dr["Impor1"].ToString()) + decimal.Parse(dr["Impor2"].ToString()) + decimal.Parse(dr["Impor3"].ToString()) + decimal.Parse(dr["Impor4"].ToString());
                    if (dr["IdConcepto"].ToString() == "20")
                        D17 = decimal.Parse(dr["Impor1"].ToString()) + decimal.Parse(dr["Impor2"].ToString()) + decimal.Parse(dr["Impor3"].ToString()) + decimal.Parse(dr["Impor4"].ToString());
                    //                if (dr["IdConcepto"].ToString() != "14" && dr["IdConcepto"].ToString() != "16" && dr["IdConcepto"].ToString() != "17" && dr["IdConcepto"].ToString() != "18" && dr["IdConcepto"].ToString() != "19" && dr["IdConcepto"].ToString() != "20" && dr["IdConcepto"].ToString() != "140")
                    //                    tot[5] += decimal.Parse(dr["Impor1"].ToString()) + decimal.Parse(dr["Impor2"].ToString()) + decimal.Parse(dr["Impor3"].ToString()) + decimal.Parse(dr["Impor4"].ToString()); //14, 16, 17, 18, 19, 20, 140
                    if (dr["IdConcepto"].ToString() != "18" && dr["IdConcepto"].ToString() != "19" && dr["IdConcepto"].ToString() != "20" && dr["IdConcepto"].ToString() != "140")
                        tot[5] += decimal.Parse(dr["Impor1"].ToString()) + decimal.Parse(dr["Impor2"].ToString()) + decimal.Parse(dr["Impor3"].ToString()) + decimal.Parse(dr["Impor4"].ToString()); //14, 16, 17, 18, 19, 20, 140
                    if (dr["IdConcepto"].ToString() != "10" && dr["IdConcepto"].ToString() != "18" && dr["IdConcepto"].ToString() != "19" && dr["IdConcepto"].ToString() != "20" && dr["IdConcepto"].ToString() != "141" && dr["IdConcepto"].ToString() != "145")
                        tot[6] += decimal.Parse(dr["Impor1"].ToString()) + decimal.Parse(dr["Impor2"].ToString()) + decimal.Parse(dr["Impor3"].ToString()) + decimal.Parse(dr["Impor4"].ToString());
                    if (dr["IdConcepto"].ToString() != "10" && dr["IdConcepto"].ToString() != "14" && dr["IdConcepto"].ToString() != "16" && dr["IdConcepto"].ToString() != "17" && dr["IdConcepto"].ToString() != "30" && dr["IdConcepto"].ToString() != "141" && dr["IdConcepto"].ToString() != "145")
                        tot[7] += decimal.Parse(dr["Impor1"].ToString()) + decimal.Parse(dr["Impor2"].ToString()) + decimal.Parse(dr["Impor3"].ToString()) + decimal.Parse(dr["Impor4"].ToString());
                }
                else
                {
                    tot1[0] += decimal.Parse(dr["Pres"].ToString()) * decimal.Parse(dr["PreLis"].ToString());
                    tot1[1] += decimal.Parse(dr["Impor1"].ToString());
                    tot1[2] += decimal.Parse(dr["Impor2"].ToString());
                    tot1[3] += decimal.Parse(dr["Impor3"].ToString());
                    tot1[4] += decimal.Parse(dr["Impor4"].ToString());
                }
			}
            dsResumenPU1.Tables["Concepto"].Rows[0]["Tot1"] = tot[0];
			dsResumenPU1.Tables["Concepto"].Rows[0]["Tot2"] = tot[1];
			dsResumenPU1.Tables["Concepto"].Rows[0]["Tot3"] = tot[2];
			dsResumenPU1.Tables["Concepto"].Rows[0]["Tot4"] = tot[3];
			dsResumenPU1.Tables["Concepto"].Rows[0]["Tot5"] = tot[4];
			dsResumenPU1.Tables["Concepto"].Rows[0]["Tot6"] = tot[5];
			dsResumenPU1.Tables["Concepto"].Rows[0]["Tot7"] = tot[6];
			dsResumenPU1.Tables["Concepto"].Rows[0]["Tot8"] = tot[7];

            for (int i = 0; i < 8; i++)
                tot[i] = 0;
            foreach (DataRow dr in dsResumenPU1.Tables["ResumenPrecios"].Rows)
            {
                if (int.Parse(dr["IdConcepto"].ToString()) <= 900)
                    if (dr["IdConcepto"].ToString() != "18" && dr["IdConcepto"].ToString() != "19" && dr["IdConcepto"].ToString() != "20" && dr["IdConcepto"].ToString() != "140")
                {
                    tot[1] += decimal.Parse(dr["Impor1"].ToString());
                    tot[2] += decimal.Parse(dr["Impor2"].ToString());
                    tot[3] += decimal.Parse(dr["Impor3"].ToString());
                    tot[4] += decimal.Parse(dr["Impor4"].ToString());
                }
            }
            cryRepResumenPu1.SetParameterValue("Tot11", tot[1]);
            cryRepResumenPu1.SetParameterValue("Tot12", tot[2]);
            cryRepResumenPu1.SetParameterValue("Tot13", tot[3]);
            cryRepResumenPu1.SetParameterValue("Tot14", tot[4]);

            for (int i = 0; i < 8; i++)
                tot[i] = 0;
            foreach (DataRow dr in dsResumenPU1.Tables["ResumenPrecios"].Rows)
            {
                if (int.Parse(dr["IdConcepto"].ToString()) <= 900)
                    if (dr["IdConcepto"].ToString() != "10" && dr["IdConcepto"].ToString() != "18" && dr["IdConcepto"].ToString() != "19" && dr["IdConcepto"].ToString() != "20" && dr["IdConcepto"].ToString() != "141" && dr["IdConcepto"].ToString() != "145")
                {
                    tot[1] += decimal.Parse(dr["Impor1"].ToString());
                    tot[2] += decimal.Parse(dr["Impor2"].ToString());
                    tot[3] += decimal.Parse(dr["Impor3"].ToString());
                    tot[4] += decimal.Parse(dr["Impor4"].ToString());
                }
            }
            cryRepResumenPu1.SetParameterValue("Tot21", tot[1]);
            cryRepResumenPu1.SetParameterValue("Tot22", tot[2]);
            cryRepResumenPu1.SetParameterValue("Tot23", tot[3]);
            cryRepResumenPu1.SetParameterValue("Tot24", tot[4]);

            for (int i = 0; i < 8; i++)
                tot[i] = 0;
            foreach (DataRow dr in dsResumenPU1.Tables["ResumenPrecios"].Rows)
            {
                if (int.Parse(dr["IdConcepto"].ToString()) <= 900)
                    if (dr["IdConcepto"].ToString() != "10" && dr["IdConcepto"].ToString() != "14" && dr["IdConcepto"].ToString() != "16" && dr["IdConcepto"].ToString() != "17" && dr["IdConcepto"].ToString() != "30" && dr["IdConcepto"].ToString() != "141" && dr["IdConcepto"].ToString() != "145")
                {
                    tot[1] += decimal.Parse(dr["Impor1"].ToString());
                    tot[2] += decimal.Parse(dr["Impor2"].ToString());
                    tot[3] += decimal.Parse(dr["Impor3"].ToString());
                    tot[4] += decimal.Parse(dr["Impor4"].ToString());
                }
            }
            cryRepResumenPu1.SetParameterValue("Tot31", tot[1]);
            cryRepResumenPu1.SetParameterValue("Tot32", tot[2]);
            cryRepResumenPu1.SetParameterValue("Tot33", tot[3]);
            cryRepResumenPu1.SetParameterValue("Tot34", tot[4]);
            
            
            dsResumenPU1.ResumenPrecios.Rows[0]["Pres"] = (dsResumenPU1.Obra.Rows.Count > 0 ? dsResumenPU1.Obra.Rows[0][7] : 0);
            dsResumenPU1.ResumenPrecios.Rows.Add(txtIdobra.Text.Trim() + (cbkPrefijo.Checked ? "" : "%"), "900", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, tot1[1], tot1[2], tot1[3], tot1[4], 0);
            cryRepResumenPu1.SetParameterValue("@Cons", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][3].ToString());
			cryRepResumenPu1.SetParameterValue("@Ubica", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][1].ToString());
			cryRepResumenPu1.SetParameterValue("@Col", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][4].ToString());
			cryRepResumenPu1.SetParameterValue("@Zona", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][5].ToString());
            cryRepResumenPu1.SetParameterValue("@Total", cbkTotal.Checked);
            cryRepResumenPu1.SetParameterValue("Obras", txtIdobra.Text.Trim() + (cbkPrefijo.Checked ? "" : "%"));
            //            cryRepResumenPu1.SetParameterValue("@Presupuesto", dsObra1.Tables[0].Rows[0]["PresupuestoZ"].ToString());
            cryRepResumenPu1.SetParameterValue("@Cliente",(string.IsNullOrEmpty(dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][6].ToString()) ? "" : dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][6].ToString()));
			
			crvResumen.ReportSource = cryRepResumenPu1;
			//crvResumen.RefreshReport();

		}


		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			btnVistaPrevia.Visible = true;
		}

		private void ResumenPU_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsDGObra1, "Obra");
			dtpFin.Value = DateTime.Today;
//            dtpIni.Value = dtpFin.Value.AddYears(-5);
		}

		private void cbkFMax_CheckedChanged(object sender, System.EventArgs e)
		{
			if (cbkFMax.Checked)
				{
					label4.Visible = true;
					dtpFin.Visible = true;
				}
			else
				{
					label4.Visible = false;
					dtpFin.Visible = false;
				}
		}

		private void dtpFin_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void cbkFMin_CheckedChanged(object sender, System.EventArgs e)
		{
			if (cbkFMin.Checked)
			{
				label3.Visible = true;
				dtpIni.Visible = true;
			}
			else
			{
				label3.Visible = false;
				dtpIni.Visible = false;
			}
		}

        private void sqlDAResumen_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

	}
}
